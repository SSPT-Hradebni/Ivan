using SediM.Helpers;
using System.Data;
using System.Data.SqlClient;

namespace SediM.Forms
{
    public partial class Skola_Nova : Form
    {
        private SqlConnection connection = new SqlConnection($"Data Source={Properties.Settings.Default.MySQL_server};Initial Catalog={Properties.Settings.Default.MySQL_databaze};User ID={Properties.Settings.Default.MySQL_uzivatel};Password={Properties.Settings.Default.MySQL_heslo}");

        public MainHelp mainHelp = new MainHelp();
        public bool jePripojen = false;

        public Skola_Nova()
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

        private void btnVytvorit_Click(object sender, EventArgs e)
        {
            try
            {
                string nazev = tboxNazev.Text;
                string ulice = tboxUlice.Text;
                int cp = (int)numCP.Value;
                int psc = (int)numPSC.Value;
                string mesto = cboxMesto.Text;

                if (nazev == "")
                    throw new Exception("Název školy nesmí být prázdný");
                if (ulice == "")
                    throw new Exception("Ulice v adrese školy nesmí být prázdná");
                if (cp == 0)
                    throw new Exception("Číslo popisné v adrese školy nesmí být prázdné");
                if (psc == 0)
                    throw new Exception("Poštovní směrovací číslo v adrese školy nesmí být prázdné");

                // Vytvoření příkazu pro zjištění počtu škol se stejným názvem
                SqlCommand vyberSkoly = new SqlCommand("SELECT COUNT(SkolaId) FROM Skoly WHERE Nazev = @nazev", connection);
                vyberSkoly.Parameters.AddWithValue("@nazev", nazev);

                // Získání počtu škol se stejným názvem
                int pocetShodnychSkol = (int)vyberSkoly.ExecuteScalar();

                // Pokud je počet větší než 0, škola již existuje, vyhodit výjimku
                if (pocetShodnychSkol > 0)
                    throw new Exception("Škola s tímto názvem již byla vytvořena");

                SqlCommand vyvorSkolu = new SqlCommand($"INSERT INTO Skoly (Nazev, Ulice, CisloPopisne, PSC, Mesto) VALUES(@nazev, @ulice, @cp, @psc, @mesto)", connection);

                vyvorSkolu.Parameters.AddWithValue("@nazev", $"{nazev}");
                vyvorSkolu.Parameters.AddWithValue("@ulice", $"{ulice}");
                vyvorSkolu.Parameters.AddWithValue("@cp", cp);
                vyvorSkolu.Parameters.AddWithValue("@psc", psc);
                vyvorSkolu.Parameters.AddWithValue("@mesto", mesto);

                int stav = vyvorSkolu.ExecuteNonQuery();

                if (stav != 0)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    mainHelp.Alert("Chyba!", "Při přidání nové školy do systému se vyskytla chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                mainHelp.Alert("Chyba!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Skola_Nova_Load(object sender, EventArgs e)
        {
        }
    }
}
