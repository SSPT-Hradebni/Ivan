using SediM.Helpers;
using System.Data;
using System.Data.SqlClient;

namespace SediM.Forms
{
    public partial class Trida_Nova : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=37.60.252.204;Initial Catalog=Ivan;User ID=ivan;Password=mE3xBa0it8dVOGr");

        public MainHelp mainHelp = new MainHelp();
        public bool jePripojen = false;

        private List<Trida> _tridy;

        public Trida_Nova()
        {
            InitializeComponent();

            connection.Open();
            ConnectionState stavDB = connection.State;

            try
            {
                if (stavDB == ConnectionState.Broken && jePripojen == false)
                {
                    DialogResult pripojen = mainHelp.Alert("Nepodařilo se připojit k serveru", "Aplikaci se nepodařilo připojit k serveru.\nZkontrolujte prosím, zda je server v provozu, a také zkontrolujte správnost zadaných údajů pro připojení k serveru.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (pripojen == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }

                    return;
                }
            }
            catch (SqlException e)
            {
                mainHelp.Alert("Chyba SQL serveru", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public Trida_Nova(List<Trida> tridy)
        {
            _tridy = tridy;

            InitializeComponent();

            connection.Open();
            ConnectionState stavDB = connection.State;

            try
            {
                if (stavDB == ConnectionState.Broken && jePripojen == false)
                {
                    DialogResult pripojen = mainHelp.Alert("Nepodařilo se připojit k serveru", "Aplikaci se nepodařilo připojit k serveru.\nZkontrolujte prosím, zda je server v provozu, a také zkontrolujte správnost zadaných údajů pro připojení k serveru.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (pripojen == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }

                    return;
                }
            }
            catch (SqlException e)
            {
                mainHelp.Alert("Chyba SQL serveru", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void numSirka_ValueChanged(object sender, EventArgs e)
        {
            panelEditClassroom.Invalidate();
        }

        private void numVyska_ValueChanged(object sender, EventArgs e)
        {
            panelEditClassroom.Invalidate();
        }

        private void panelEditClassroom_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Obrys třídy
            g.DrawRectangle(
                Pens.Gray,
                0, 0, // Počáteční bod (vlevo nahoře)
                panelEditClassroom.Width - 1, panelEditClassroom.Height - 1); // Koncový bod (vpravo dole)
            // Tabule
            g.FillRectangle(
                Brushes.DarkGreen,
                0, panelEditClassroom.Height / 4, // Počáteční bod (0% od levé stěny, 25% od horní stěny)
                (int)(panelEditClassroom.Width * 0.02), // Šířka - 2%
                panelEditClassroom.Height / 2); // Délka (výška) - 50%
            // Katedra
            g.FillRectangle(
                Brushes.Black,
                (int)(panelEditClassroom.Height * 0.1), // Roh katedry (10% od levé stěny)
                panelEditClassroom.Height - (int)(panelEditClassroom.Height * 0.2), // Roh katedry (20% od dolní stěny)
                (int)(panelEditClassroom.Height * 0.15), // Šířka - 15%
                (int)(panelEditClassroom.Width * 0.2)); // Délka (výška) - 20%

            // Místa pro studenty
            // Poznámka: plocha pro vykreslování míst studentů je snížena o 5% od stěn a katedry
            Point pocatekPlochyMist = new Point((int)(panelEditClassroom.Width * 0.2), (int)(panelEditClassroom.Height * 0.05));
            // Vypočítá podíl rozdílu šířky plochy pro vykreslení míst a hodnoty numericUpDown
            // pro počet míst ve třídě do šířky hodnotou numericUpDown ... do šířky
            int mistoSirka = (int)((panelEditClassroom.Width * 0.75 - (double)numSirka.Value) / (double)numSirka.Value);

            // Stejný princip ale pro počet míst ve třídě do výšky
            int mistoVyska = (int)((panelEditClassroom.Height * 0.9 - (double)numVyska.Value) / (double)numVyska.Value);

            for (int r = 0; r < numVyska.Value; r++) // r - řádek
            {
                for (int s = 0; s < numSirka.Value; s++) // s - sloupec
                {
                    g.FillRectangle(
                        Brushes.Gray,
                        pocatekPlochyMist.X + s * mistoSirka + s, // Každé nadcházející vykreslení se odsadí o dalších mistoSirka + 1
                        pocatekPlochyMist.Y + r * mistoVyska + r, // To samé platí zde s rozdílem, že se vykreslení odsadí každý další řádek
                        mistoSirka,
                        mistoVyska);
                }
            }
        }

        private void btnVytvorit_Click(object sender, EventArgs e)
        {
            try
            {
                string nazev = tboxNazev.Text;
                int sirka = (int)numSirka.Value;
                int vyska = (int)numVyska.Value;

                // TODO: Proč se id přidává dohromady o 2? řádek 158
                // ID poslední vložené třídy do databáze (kvůli indexování o +1)
                int posledniID = _tridy.Count() + 1;

                if (nazev == "")
                {
                    throw new Exception("Název třídy nesmí být prázdný");
                }

                SqlCommand vytvorTridu = new SqlCommand($"INSERT INTO Tridy (Nazev, Sirka, Vyska) VALUES(@nazev, @sirka, @vyska)", connection);

                vytvorTridu.Parameters.AddWithValue("@nazev", nazev);
                vytvorTridu.Parameters.AddWithValue("@sirka", sirka);
                vytvorTridu.Parameters.AddWithValue("@vyska", vyska);

                int stav = vytvorTridu.ExecuteNonQuery();

                if (stav != 0)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    mainHelp.Alert("Chyba!", "Při přidání nové třídy do systému se vyskytla chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                mainHelp.Alert("Chyba!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
