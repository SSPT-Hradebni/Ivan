namespace SediM
{
    public partial class FormularRozsazeni : Form
    {
        private List<Skola> skoly = new List<Skola>();
        private bool poprveSpusten = true;
        public FormularRozsazeni(IEnumerable<string> tridy)
        {
            InitializeComponent();
            combobxAlgoritmus.SelectedIndex = 0; // Automaticky zvolí jediný doposud vyřešený algoritmus - Knight (Jezdec)
            // Je využito funkce Skip() s parametrem 1 jelikož 0 je položka "Nový". S touto položkou nemáme zapotřebí pracovat
            listbxVybraneTridy.Items.AddRange(tridy.Skip(1).ToArray());
        }
        internal void setSkoly(List<Skola> skoly)
        {
            this.skoly = skoly;
        }

        private void listbxVyberTrid_SelectedIndexChanged(object sender, EventArgs e)
        {
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

            Point pocatekPlochyMist = new Point(
                (int)(panelVykresleniRozsazeni.Width * 0.05),
                (int)(panelVykresleniRozsazeni.Height * 0.05));

            if (poprveSpusten)
            {
                poprveSpusten = false;
                return;
            }

            string[] dimensions = listbxVybraneTridy.Text.Split('(')[1].Split('x');
            dimensions[1] = dimensions[1].Remove(dimensions[1].Length - 1);
            int mistoSirka = (int)((panelVykresleniRozsazeni.Width * 0.9 - int.Parse(dimensions[1])) / int.Parse(dimensions[1]));
            int mistoVyska = (int)((panelVykresleniRozsazeni.Height * 0.65 - int.Parse(dimensions[0])) / int.Parse(dimensions[0]));

            for (int r = 0; r < int.Parse(dimensions[0]); r++)
            {
                for (int s = 0; s < int.Parse(dimensions[1]); s++)
                {
                    g.FillRectangle(
                        Brushes.Gray,
                        pocatekPlochyMist.X + s * mistoSirka + s,
                        pocatekPlochyMist.Y + r * mistoVyska + r,
                        mistoSirka, mistoVyska); ;
                }
            }
        }
    }
}
