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
            cboxSkoly.ValueMember = "id";
            cboxSkoly.DisplayMember = "nazev";
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
                int skola = cboxSkoly.SelectedIndex;

                if (jmeno == "")
                    throw new Exception("Křestní jméno žáka nesmí být prázdné");
                if (prijmeni == "")
                    throw new Exception("Příjmení žáka nesmí být prázdné");
                if ((jmeno + prijmeni).Length > 45)
                    throw new Exception("Délka jména a příjmení nesmí přesáhnout 45 znaků");
                if (skola == -1)
                    throw new Exception("Platná škola musí být vybrána");

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
    }
}
