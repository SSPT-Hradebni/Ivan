using Npgsql;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using SediM.Helpers;

namespace SediM
{
    public partial class FormularRozsazeni : Form
    {
        private NpgsqlConnection connection;
        private MainHelp mainHelp = new MainHelp();

        // TODO/FIXME: Když uživatel zavře a znovu otevře tento form bez ukončení aplikace (formulář Main)
        // tak zůstanou nastaveny globální proměnné. To je nežádoucí.

        // List polí barev. Počet barev v poli na daném indexu odpovídá počtu kategorií vyplněné třídy
        private List<SolidBrush[]> barvyVyplnenychTrid = new List<SolidBrush[]>();

        // List vyplněných tříd žáky. Každý index dané položky v listu odpovídá indexu vyplněné třídy v listboxu vyplněných tříd
        private List<Zak[,]> tridyZaku = new List<Zak[,]>();
        private List<Trida> tridy = new List<Trida>();
        private List<Trida> vyplneneTridy = new List<Trida>();
        private List<Zak> zaci = new List<Zak>();

        // Proměnná, jejíž hodnota se přiřadí každému dalšímu zákovi při řazení do třídy.
        // Po nastavení její hodnoty žákovi se inkrementuje aby se předešlo dvěma místům se stejnou hodnotou
        private int mistoZaka = 1;

        public FormularRozsazeni(List<Trida> tridy, List<Zak> zaci, NpgsqlConnection connection)
        {
            InitializeComponent();

            this.tridy = tridy;
            this.zaci = zaci;
            this.connection = connection;

            // Automaticky zvolí jediný doposud vyřešený algoritmus - Knight (Jezdec)
            combobxAlgoritmus.SelectedIndex = 0;
        }
        // TODO/FIXME: Při výběru třídy v jiné komponentě se odznačí právě označená třída
        private void cboxTridy_SelectedIndexChanged(object sender, EventArgs e)
        {
            listbxVyplneneTridy.SelectedIndex = -1;
            panelVykresleniRozsazeni.Invalidate();
        }

        private void listbxVyplneneTridy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxTridy.SelectedIndex = -1;
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

            if (cboxTridy.SelectedIndex == -1 && listbxVyplneneTridy.SelectedIndex == -1) return;

            // Získáme aktuální vybranou třídu
            Trida aktualniTrida = ZiskejAktualniTridu();

            // Vyvoláme metodu pro vykreslení míst
            vykresleniMist(g, aktualniTrida);
        }

        private void vykresleniMist(Graphics g, Trida aktualniTrida)
        {
            // Odstraní veškeré studenty z listboxu aby se nepřidávali přes sebe
            listbxSeznamStudentu.Items.Clear();

            if (aktualniTrida == null) return;

            // Vytvořen "počáteční" bod pro vykreslování míst
            Point pocatekPlochyMist = new Point(
                (int)(panelVykresleniRozsazeni.Width * 0.05),
                (int)(panelVykresleniRozsazeni.Height * 0.05));

            // Vypočítá velikost jednoho místa na základě velikosti dimenzí
            int mistoSirka = (int)((panelVykresleniRozsazeni.Width * 0.9) / aktualniTrida.Sirka);
            int mistoVyska = (int)((panelVykresleniRozsazeni.Height * 0.65) / aktualniTrida.Vyska);

            int indexVyplneneTridy = listbxVyplneneTridy.SelectedIndex;

            // Opakuje pro každý řádek míst ve třídě
            for (int r = 0; r < aktualniTrida.Vyska; r++)
            {
                // Opakuje pro každé místo v řádku ve třídě
                for (int s = 0; s < aktualniTrida.Sirka; s++)
                {
                    g.FillRectangle(
                        ziskejBarvuDleKategorie(
                            indexVyplneneTridy,
                            indexVyplneneTridy != -1
                                ? (r * 2 + s) % barvyVyplnenychTrid[indexVyplneneTridy].Length
                                : -1),
                        pocatekPlochyMist.X + s * mistoSirka + s,
                        pocatekPlochyMist.Y + r * mistoVyska + r,
                        mistoSirka, mistoVyska);

                    if (indexVyplneneTridy != -1)
                    {
                        // Zjistí velikost vykreslovaného řetězce
                        SizeF velikostCisla = g.MeasureString(
                            tridyZaku[indexVyplneneTridy][r, s].Misto.ToString(),
                            new Font("Arial", 10));

                        // Vykreslí řetězec na střed buňky (místa)
                        g.DrawString(
                            tridyZaku[indexVyplneneTridy][r, s].Misto.ToString(),
                            new Font("Arial", 10),
                            Brushes.Black,
                            pocatekPlochyMist.X + s * mistoSirka + s + mistoSirka / 2 - velikostCisla.Width / 2,
                            pocatekPlochyMist.Y + r * mistoVyska + r + mistoVyska / 2 - velikostCisla.Height / 2);

                        // Přidá žáka včetně jeho místa do listboxu seznamu studentů ve třídě
                        string prazdnyNeboJmeno =
                            tridyZaku[indexVyplneneTridy][r, s].CeleJmeno == "MÍSTO PRÁZDNÉ"
                            ? "PRÁZDNÉ MÍSTO"
                            : tridyZaku[indexVyplneneTridy][r, s].CeleJmeno;
                        listbxSeznamStudentu.Items.Add(
                            $"{tridyZaku[indexVyplneneTridy][r, s].Misto} - " +
                            $"{prazdnyNeboJmeno}");
                    }
                }
            }
        }

        private List<SolidBrush> inicializujListBarev()
        {
            List<SolidBrush> barvyKategorii = new List<SolidBrush>();
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
            return barvyKategorii;
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
            if (cboxTridy.SelectedIndex == -1) return;

            // Získáme aktuální vybranou třídu
            Trida aktualniTrida = ZiskejAktualniTridu();

            MessageBox.Show($"Aktuální třída: {aktualniTrida.Nazev}\nŠířka: {aktualniTrida.Sirka} míst\nVýška: {aktualniTrida.Vyska} míst");

            nastavParametryProVyplneni(cboxTridy.SelectedIndex, aktualniTrida);
        }

        private void nastavParametryProVyplneni(int selectedIndex, Trida aktualniTrida)
        {
            tridyZaku.Add(new Zak[aktualniTrida.Vyska, aktualniTrida.Sirka]);

            // Vyplní právě přidanou třídu žáky
            vyplnTridu(tridyZaku.Count - 1, aktualniTrida.Sirka, aktualniTrida.Vyska);

            // Přesune zvolenou třídu mezi vyplněné třídy
            listbxVyplneneTridy.Items.Add(cboxTridy.Items[selectedIndex]);
            vyplneneTridy.Add(aktualniTrida);

            // odstranění vyplněné třídy z comboboxu
            tridy.Remove(aktualniTrida);
            cboxTridy.DataSource = null; // při DataSource nejde vymazat cbox, proto nastaveno teď na null
            cboxTridy.Items.Clear();
            cboxTridy.DataSource = tridy;

            cboxTridy.SelectedIndex = -1;
            listbxVyplneneTridy.SelectedIndex = listbxVyplneneTridy.Items.Count - 1;
        }

        private void vyplnTridu(int indexTridy, int sirka, int vyska)
        {
            barvyVyplnenychTrid.Add(inicializujListBarev().ToArray());
            List<Zak> kopieZaku = new List<Zak>();
            foreach (Zak zak in zaci)
                kopieZaku.Add(zak.Clone());

            // Opakuje pro každý řádek míst ve třídě
            for (int r = 0; r < vyska; r++)
            {
                // Opakuje pro každé místo v řádku ve třídě
                for (int s = 0; s < sirka; s++)
                {
                    // Přidá žáka podle kategorie pomocí funkce ziskejZaka - tento řádek
                    // je implementovám aby řadil žáky pouze podle aloritmu Knight!
                    tridyZaku[indexTridy][r, s] = ziskejZaka(((r * 2 + s) % (int)numupdownKategoriiNaTridu.Value) + 1, kopieZaku);
                }
            }
        }

        private Zak ziskejZaka(int kategorie, List<Zak> kopieZaku)
        {
            // Vytvoříme žáka returnZak s jménem "PRÁZDNÉ MÍSTO" pro případ, že by
            // for cyklus došel do konce bez přenastavení této proměnné
            Zak returnZak = new Zak(-1, "PRÁZDNÉ", "MÍSTO", -1, -1);

            if (kopieZaku.Find(zak => zak.Kategorie == kategorie) != null)
            {
                returnZak = kopieZaku.Find(zak => zak.Kategorie == kategorie);
                zaci.RemoveAt(zaci.FindIndex(zak => zak.Id == returnZak.Id));
                kopieZaku.RemoveAll(zak => zak.Kategorie == kategorie && zak.Skola == returnZak.Skola);
            }

            returnZak.Misto = mistoZaka;
            mistoZaka++;
            return returnZak;
        }

        private void ExportToPdf(string filePath)
        {
            // Vytvoření nového dokumentu PDF
            PdfDocument document = new PdfDocument();

            // Vytvoření stránky v dokumentu
            PdfPage page = document.AddPage();
            XGraphics g = XGraphics.FromPdfPage(page);

            XTextFormatter tf = new XTextFormatter(g);
            tf.Alignment = XParagraphAlignment.Center;

            // Slouží pouze jako test. Později bude optimalizováno - TODO

            int width = 720, height = 480;
            // Vytvořen "počáteční" bod pro vykreslování míst
            Point pocatekPlochyMist = new Point(
                (int)(width * 0.05),
                (int)(height * 0.05));

            // Extrahuje dimenze třídy z právě označeného listboxu ve formátu [0] - šířka, [1] - výška
            int[] dimenze = { tridyZaku[0].GetLength(1), tridyZaku[0].GetLength(0) };

            // Vypočítá velikost jednoho místa na základě velikosti dimenzí - stejný princip jako ve formuláři Main
            int mistoSirka = (int)((width * 0.9) / dimenze[0]);
            int mistoVyska = (int)((height * 0.65) / dimenze[1]);

            page.Size = PdfSharp.PageSize.A4;
            page.Orientation = PdfSharp.PageOrientation.Landscape;

            // Opakuje pro každý řádek míst ve třídě
            for (int r = 0; r < dimenze[1]; r++)
            {
                // Opakuje pro každé místo v řádku ve třídě
                for (int s = 0; s < dimenze[0]; s++)
                {
                    g.DrawRectangle(
                        new XPen(Color.Black),
                        pocatekPlochyMist.X + s * mistoSirka + s,
                        pocatekPlochyMist.Y + r * mistoVyska + r,
                        mistoSirka, mistoVyska);

                    // Zjistí velikost vykreslovaného řetězce
                    XSize velikostCisla = g.MeasureString(
                        $"{tridyZaku[0][r, s].Misto}",
                        new XFont("Arial", 10, XFontStyleEx.Regular));

                    // 
                    XSize velikostJmena = g.MeasureString(
                        tridyZaku[0][r, s].Jmeno,
                        new XFont("Arial", 10, XFontStyleEx.Regular));

                    // Vykreslí řetězec na střed buňky (místa)
                    tf.DrawString(
                        $"{tridyZaku[0][r, s].Misto}\n{tridyZaku[0][r, s].Jmeno}",
                        new XFont("Arial", 10, XFontStyleEx.Regular),
                        XBrushes.Black,
                        new XRect(pocatekPlochyMist.X + s * mistoSirka + s + mistoSirka / 2 - velikostJmena.Width / 2,
                        pocatekPlochyMist.Y + r * mistoVyska + r + mistoVyska / 2 - velikostJmena.Height / 2, mistoSirka, mistoVyska));
                }
            }

            // Uložení dokumentu do souboru
            document.Save(filePath);

            // Zavření dokumentu
            document.Close();
        }

        private void FormularRozsazeni_Load(object sender, EventArgs e)
        {
            List<Trida> volneTridy = new List<Trida>();

            for(int i = 0; i < tridy.Count; i++)
            {
                Trida trida = tridy[i];

                if(trida.Rozsazena == false)
                {
                    volneTridy.Add(trida);
                }
            }

            cboxTridy.DataSource = volneTridy;
            cboxTridy.ValueMember = "Id";
            cboxTridy.DisplayMember = "Nazev";
        }

        private Trida ZiskejAktualniTridu()
        {
            if (cboxTridy.SelectedIndex != -1)
            {
                return tridy[cboxTridy.SelectedIndex];
            }
            else if (listbxVyplneneTridy.SelectedIndex != -1)
            {
                return vyplneneTridy[listbxVyplneneTridy.SelectedIndex];
            }
            else
            {
                return null;
            }
        }
    }
}
