using SediM.Helpers;
using System.Data;
using System.Data.SqlClient;

namespace SediM
{
    public partial class Zak_Novy : Form
    {
        private SqlConnection connection = new SqlConnection($"Data Source={Properties.Settings.Default.MySQL_server};Initial Catalog={Properties.Settings.Default.MySQL_databaze};User ID={Properties.Settings.Default.MySQL_uzivatel};Password={Properties.Settings.Default.MySQL_heslo}");

        public MainHelp mainHelp = new MainHelp();
        public bool jePripojen = false;

        private List<Skola> _skoly;
        private List<Zak> _zaci;

        public Zak_Novy()
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

        public Zak_Novy(List<Skola> skoly, List<Zak> zaci)
        {
            _skoly = skoly;
            _zaci = zaci;

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

        private void Zak_Novy_Load(object sender, EventArgs e)
        {
            // načtení škol
            cboxSkoly.ValueMember = "Id";
            cboxSkoly.DisplayMember = "Nazev";
            cboxSkoly.DataSource = _skoly;

            // Nastavení formátování pro zobrazení zkratky
            cboxSkoly.Format += (s, args) => args.Value = mainHelp.ZkratkySkol(args.ListItem.ToString());
        }

        private void Zak_Novy_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mainHelp.ShowHelp(this, "student-novy.html");
        }

        private void btnVytvorit_Click(object sender, EventArgs e)
        {
            try
            {
                string jmeno = tboxJmeno.Text;
                string prijmeni = tboxPrijmeni.Text;
                int kategorie = (int)numKategorie.Value;
                int skola = (int)cboxSkoly.SelectedValue;

                if (jmeno == "")
                    throw new Exception("Křestní jméno žáka nesmí být prázdné");
                if (prijmeni == "")
                    throw new Exception("Příjmení žáka nesmí být prázdné");
                if ((jmeno + prijmeni).Length > 45)
                    throw new Exception("Délka jména a příjmení nesmí přesáhnout 45 znaků");
                if (skola == -1)
                    throw new Exception("Platná škola musí být vybrána");

                if (ExistujeZak(jmeno, prijmeni, kategorie, skola))
                {
                    // Pokud žák již existuje, zeptat se uživatele, zda jej chce vložit do systému
                    DialogResult result = mainHelp.Alert("Upozornění", "Žák s těmito údaji již existuje. Chcete ho i tak vložit do systému?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                        return; // Uživatel nechce vložit žáka do systému
                }

                SqlCommand vytvorZaka = new SqlCommand($"INSERT INTO Studenti (Jmeno, Prijmeni, Kategorie, Skola) VALUES(@jmeno, @prijmeni, @kategorie, @skola)", connection);

                vytvorZaka.Parameters.AddWithValue("@jmeno", $"{jmeno}");
                vytvorZaka.Parameters.AddWithValue("@prijmeni", $"{prijmeni}");
                vytvorZaka.Parameters.AddWithValue("@kategorie", kategorie);
                vytvorZaka.Parameters.AddWithValue("@skola", skola + 1);

                int stav = vytvorZaka.ExecuteNonQuery();

                if (stav != 0)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    mainHelp.Alert("Chyba!", "Při přidání nového žáka do systému se vyskytla chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                mainHelp.Alert("Chyba!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ExistujeZak(string jmeno, string prijmeni, int kategorie, int skola)
        {
            bool existuje = false;

            try
            {
                SqlCommand overeniZaka = new SqlCommand($"SELECT COUNT(*) FROM Studenti WHERE Jmeno = @jmeno AND Prijmeni = @prijmeni AND Kategorie = @kategorie AND Skola = @skola", connection);
                overeniZaka.Parameters.AddWithValue("@jmeno", jmeno);
                overeniZaka.Parameters.AddWithValue("@prijmeni", prijmeni);
                overeniZaka.Parameters.AddWithValue("@kategorie", kategorie);
                overeniZaka.Parameters.AddWithValue("@skola", skola);

                int pocet = (int)overeniZaka.ExecuteScalar();

                if (pocet > 0)
                    existuje = true;
            }
            catch (SqlException ex)
            {
                mainHelp.Alert("Chyba SQL serveru", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return existuje;
        }
    }
}
