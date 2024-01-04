using System;
using System.Drawing;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace SediM
{
    public partial class FormularRozsazeni : Form
    {
        private List<Skola> skoly = new List<Skola>();
        private List<SolidBrush> barvyKategorii = new List<SolidBrush>();
        private List<SolidBrush[]> barvyVyplnenychTrid = new List<SolidBrush[]>();
        public FormularRozsazeni(IEnumerable<string> tridy)
        {
            InitializeComponent();
            // Automaticky zvolí jediný doposud vyřešený algoritmus - Knight (Jezdec)
            combobxAlgoritmus.SelectedIndex = 0;
            // Je využito funkce Skip() s parametrem 1 jelikož 0 je položka "Nový". S touto položkou nemáme zapotřebí pracovat.
            listbxVybraneTridy.Items.AddRange(tridy.Skip(1).ToArray());
            inicializaceListuBarev();
        }

        internal void setSkoly(List<Skola> skoly)
        {
            this.skoly = skoly;
        }

        private void listbxVyberTrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            // FIXME: Z neznámého důvodu se při označení jiného prvku v jiném listboxu
            // odznačí i ta klikaná položka - platí pro všechny listboxy ve formu
            listbxVybraneTridy.SelectedIndex = -1;
            listbxVyplneneTridy.SelectedIndex = -1;
            btnPresunTridu.Text = ">";
        }

        private void listbxVybraneTridy_SelectedIndexChanged(object sender, EventArgs e)
        {
            listbxVyberTrid.SelectedIndex = -1;
            listbxVyplneneTridy.SelectedIndex = -1;
            btnPresunTridu.Text = "<";

            panelVykresleniRozsazeni.Invalidate();
        }

        private void btnPresunTridu_Click(object sender, EventArgs e)
        {
            if (listbxVyberTrid.SelectedIndex == -1 && listbxVybraneTridy.SelectedIndex == -1)
            {
                return; // Předchází pádu aplikace kvůli přístupu k položce na indexu -1
            }
            // Pokud přesouváne z vybraných tříd do výběru tříd
            else if (listbxVyberTrid.SelectedIndex == -1)
            {
                listbxVyberTrid.Items.Add(listbxVybraneTridy.Items[listbxVybraneTridy.SelectedIndex]);
                listbxVybraneTridy.Items.RemoveAt(listbxVybraneTridy.SelectedIndex);
            }
            // Pokud přesouváme z výběru tříd do vybraných tříd
            else if (listbxVybraneTridy.SelectedIndex == -1)
            {
                listbxVybraneTridy.Items.Add(listbxVyberTrid.Items[listbxVyberTrid.SelectedIndex]);
                listbxVyberTrid.Items.RemoveAt(listbxVyberTrid.SelectedIndex);
            }
        }

        private void listbxVyplneneTridy_SelectedIndexChanged(object sender, EventArgs e)
        {
            listbxVyberTrid.SelectedIndex = -1;
            listbxVybraneTridy.SelectedIndex = -1;

            panelVykresleniRozsazeni.Invalidate();
        }

        private void panelVykresleniRozsazeni_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Obrys třídy
            g.DrawRectangle(
                Pens.Gray,
                0, 0,
                panelVykresleniRozsazeni.Width - 1, panelVykresleniRozsazeni.Height - 1);

            // Tabule
            g.FillRectangle(
                Brushes.DarkGreen,
                panelVykresleniRozsazeni.Width / 4, (int)(panelVykresleniRozsazeni.Height * 0.98),
                panelVykresleniRozsazeni.Width / 2, (int)(panelVykresleniRozsazeni.Height * 0.02));

            // Katedra
            g.FillRectangle(
                Brushes.Black,
                (int)(panelVykresleniRozsazeni.Width * 0.7), (int)(panelVykresleniRozsazeni.Height * 0.75),
                (int)(panelVykresleniRozsazeni.Width * 0.3), (int)(panelVykresleniRozsazeni.Height * 0.15));

            if (listbxVybraneTridy.SelectedIndex == -1 && listbxVyplneneTridy.SelectedIndex == -1) return;

            vykresleniMist(g);
        }

        private void vykresleniMist(Graphics g)
        {
            Point pocatekPlochyMist = new Point(
                (int)(panelVykresleniRozsazeni.Width * 0.05),
                (int)(panelVykresleniRozsazeni.Height * 0.05));

            int[] dimensions = extrahujDimenze();

            int mistoSirka = (int)((panelVykresleniRozsazeni.Width * 0.9 - dimensions[1]) / dimensions[1]);
            int mistoVyska = (int)((panelVykresleniRozsazeni.Height * 0.65 - dimensions[0]) / dimensions[0]);

            for (int r = 0; r < dimensions[0]; r++)
            {
                for (int s = 0; s < dimensions[1]; s++)
                {
                    g.FillRectangle(
                        ziskejBarvuDleKategorie(listbxVyplneneTridy.SelectedIndex != -1 ? (r * 2 + s) % (int)numupdownKategoriiNaTridu.Value : -1),
                        pocatekPlochyMist.X + s * mistoSirka + s,
                        pocatekPlochyMist.Y + r * mistoVyska + r,
                        mistoSirka, mistoVyska);
                }
            }
        }

        private int[] extrahujDimenze()
        {
            string[] dimensions = new string[2];

            if (listbxVyberTrid.SelectedIndex == -1 && listbxVybraneTridy.SelectedIndex != -1 && listbxVyplneneTridy.SelectedIndex == -1)
            {
                dimensions = listbxVybraneTridy.Text.Split('(')[1].Split('x');
            }
            else if (listbxVyberTrid.SelectedIndex == -1 && listbxVybraneTridy.SelectedIndex == -1 && listbxVyplneneTridy.SelectedIndex != -1)
            {
                dimensions = listbxVyplneneTridy.Text.Split('(')[1].Split('x');
            }

            dimensions[1] = dimensions[1].Remove(dimensions[1].Length - 1);


            for (int r = 0; r < int.Parse(dimensions[0]); r++)
            {
                for (int s = 0; s < int.Parse(dimensions[1]); s++)
                {
                    g.FillRectangle(
                        ziskejBarvuDleKategorie(listbxVyplneneTridy.SelectedIndex != -1 ? listbxVyplneneTridy.SelectedIndex : -1, (r * 2 + s) % (int)numupdownKategoriiNaTridu.Value),
                        pocatekPlochyMist.X + s * mistoSirka + s,
                        pocatekPlochyMist.Y + r * mistoVyska + r,
                        mistoSirka, mistoVyska);
                }
            }
        }

        private void numupdownKategoriiNaTridu_ValueChanged(object sender, EventArgs e)
        {
            inicializaceListuBarev();
        }

        private void inicializaceListuBarev()
        {
            barvyKategorii.Clear();
            Random rng = new Random();
            int i = 0;
            while (i < numupdownKategoriiNaTridu.Value)
            {
                SolidBrush sb = new SolidBrush(Color.FromArgb(rng.Next(0, 255), rng.Next(0, 255), rng.Next(0, 255)));
                // Přeskočí přidání duplicitní barvy
                if (barvyKategorii.Exists(barva => barva.Color == sb.Color)) continue;
                i++;
                barvyKategorii.Add(sb);
            }
        }

        private SolidBrush ziskejBarvuDleKategorie(int indexTridy, int kategorie)
        {
            switch (indexTridy)
            {
                case -1:
                    return new SolidBrush(Color.FromArgb(100, 100, 100));
                default:
                    return barvyVyplnenychTrid[indexTridy][kategorie];
            }
        }

        private void btnVyplnit_Click(object sender, EventArgs e)
        {
            if (listbxVybraneTridy.SelectedIndex == -1) return;
            // POZNÁMKA: Řádky níže jsou pouze dočasné jelikož slouží jako debug pomůcka, jestli
            // jsou jednotlivá místa správně zabarvená. Zde se bude řešit řazení žáků - TODO
            listbxVyplneneTridy.Items.Add(listbxVybraneTridy.Items[listbxVybraneTridy.SelectedIndex]);
            listbxVybraneTridy.Items.RemoveAt(listbxVybraneTridy.SelectedIndex);
            barvyVyplnenychTrid.Add(barvyKategorii.ToArray());
        }

        private void ExportToPdf(string filePath)
        {
            // Vytvoření nového dokumentu PDF
            PdfDocument document = new PdfDocument();

            // Vytvoření stránky v dokumentu
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Získání obsahu panelu, který chcete exportovat
            Bitmap panelContent = new Bitmap(panelVykresleniRozsazeni.Width, panelVykresleniRozsazeni.Height);
            panelVykresleniRozsazeni.DrawToBitmap(panelContent, new Rectangle(0, 0, panelVykresleniRozsazeni.Width, panelVykresleniRozsazeni.Height));

            // Převod obsahu panelu na XImage
            XImage image = XImage.FromGdiPlusImage(panelContent);

            // Vložení obrázku do PDF stránky
            gfx.DrawImage(image, 0, 0);

            // Uložení dokumentu do souboru
            document.Save(filePath);

            // Zavření dokumentu
            document.Close();
        }

        private void btnTisk_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.AddExtension = true;
            dialog.DefaultExt = "pdf";

            DialogResult stav = dialog.ShowDialog();

            if(stav == DialogResult.OK)
            {
                ExportToPdf(dialog.FileName);
            }
        }
    }
}
