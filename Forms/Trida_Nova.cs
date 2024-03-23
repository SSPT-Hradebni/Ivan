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
                0, 0,
                panelEditClassroom.Width - 1, panelEditClassroom.Height - 1);

            // Tabule
            g.FillRectangle(
                Brushes.DarkGreen,
                panelEditClassroom.Width / 4, (int)(panelEditClassroom.Height * 0.98),
                panelEditClassroom.Width / 2, (int)(panelEditClassroom.Height * 0.02));

            // Katedra
            g.FillRectangle(
                Brushes.Black,
                (int)(panelEditClassroom.Width * 0.7), (int)(panelEditClassroom.Height * 0.75),
                (int)(panelEditClassroom.Width * 0.3), (int)(panelEditClassroom.Height * 0.15));

            // Vytvořen "počáteční" bod pro vykreslování míst
            Point pocatekPlochyMist = new Point(
                (int)(panelEditClassroom.Width * 0.05),
                (int)(panelEditClassroom.Height * 0.05));

            // Vypočítá velikost jednoho místa na základě velikosti dimenzí
            int mistoSirka = (int)((panelEditClassroom.Width * 0.9) / (double)numSirka.Value);
            int mistoVyska = (int)((panelEditClassroom.Height * 0.65) / (double)numVyska.Value);

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

                if (nazev == "")
                    throw new Exception("Název třídy nesmí být prázdný");
                if (_tridy.Exists(hledanaTrida => hledanaTrida.Nazev == nazev))
                    throw new Exception("Název třídy se shoduje s již existující třídou");

                SqlCommand vytvorTridu = new SqlCommand($"INSERT INTO Tridy (Nazev, Sirka, Vyska, JeRozsazena) VALUES(@nazev, @sirka, @vyska, @jeRozsazena)", connection);

                vytvorTridu.Parameters.AddWithValue("@nazev", nazev);
                vytvorTridu.Parameters.AddWithValue("@sirka", sirka);
                vytvorTridu.Parameters.AddWithValue("@vyska", vyska);
                vytvorTridu.Parameters.AddWithValue("@jeRozsazena", 0);

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
