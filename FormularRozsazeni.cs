namespace SediM
{
    public partial class FormularRozsazeni : Form
    {
        private List<Skola> skoly = new List<Skola>();
        private List<SolidBrush> barvyKategorii = new List<SolidBrush>();
        // List polí barev. Počet barev v poli na daném indexu odpovídá počtu kategorií vyplněné třídy
        private List<SolidBrush[]> barvyVyplnenychTrid = new List<SolidBrush[]>();
        // TODO - vysvětlit
        private List<Zak[,]> tridyZaku = new List<Zak[,]>();
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

            int[] dimenze = extrahujDimenze();
            int mistoSirka = (int)((panelVykresleniRozsazeni.Width * 0.9 - dimenze[0]) / dimenze[0]);
            int mistoVyska = (int)((panelVykresleniRozsazeni.Height * 0.65 - dimenze[1]) / dimenze[1]);

            // Vytvoří 2-dimenzionální pole o velikosti zvolené vyplňované třídy
            if (listbxVyplneneTridy.SelectedIndex != -1)
            {
                tridyZaku.Add(new Zak[dimenze[0], dimenze[1]]);
            }

            for (int r = 0; r < dimenze[1] ; r++)
            {
                for (int s = 0; s < dimenze[0]; s++)
                {
                    g.FillRectangle(
                        ziskejBarvuDleKategorie(listbxVyplneneTridy.SelectedIndex != -1 ? listbxVyplneneTridy.SelectedIndex : -1, listbxVyplneneTridy.SelectedIndex != -1 ? (r * 2 + s) % barvyVyplnenychTrid[listbxVyplneneTridy.SelectedIndex].Length : -1),
                        pocatekPlochyMist.X + s * mistoSirka + s,
                        pocatekPlochyMist.Y + r * mistoVyska + r,
                        mistoSirka, mistoVyska);
                }
            }
        }
        private int[] extrahujDimenze()
        {
            string[] tmp = new string[2];
            if (listbxVyberTrid.SelectedIndex == -1 && listbxVybraneTridy.SelectedIndex != -1 && listbxVyplneneTridy.SelectedIndex == -1)
            {
                tmp = listbxVybraneTridy.Text.Split('(')[1].Split('x');
            }
            else if (listbxVyberTrid.SelectedIndex == -1 && listbxVybraneTridy.SelectedIndex == -1 && listbxVyplneneTridy.SelectedIndex != -1)
            {
                tmp = listbxVyplneneTridy.Text.Split('(')[1].Split('x');
            }
            tmp[1] = tmp[1].Remove(tmp[1].Length - 1);
            return new int[] { int.Parse(tmp[1]), int.Parse(tmp[0]) };
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
            listbxVyplneneTridy.Items.Add(listbxVybraneTridy.Items[listbxVybraneTridy.SelectedIndex]);
            listbxVybraneTridy.Items.RemoveAt(listbxVybraneTridy.SelectedIndex);
            barvyVyplnenychTrid.Add(barvyKategorii.ToArray());
            // TODO - po kliknutí na tlačítlo se odznačí listbox a tedy nemůže pracovat funkce extrahujDimenze
            //int[] tmp = extrahujDimenze();
            //tridyZaku.Add(new Zak[tmp[0],tmp[1]]);
            //vyplnZaky(tridyZaku.Count-1);
        }
        private void vyplnZaky(int indexTridy)
        {
            // TODO - Zde se bude vyplňovat specifikovaná třída na indexu zadaném v parametru funkce
        }
    }
}
