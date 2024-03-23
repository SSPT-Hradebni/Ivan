using SediM.Helpers;
using System.Data;
using System.Data.SqlClient;

namespace SediM
{
    public partial class Zak_Upravit : Form
    {
        private SqlConnection connection = new SqlConnection($"Data Source={Properties.Settings.Default.MySQL_server};Initial Catalog={Properties.Settings.Default.MySQL_databaze};User ID={Properties.Settings.Default.MySQL_uzivatel};Password={Properties.Settings.Default.MySQL_heslo}");

        public MainHelp mainHelp = new MainHelp();
        public bool jePripojen = false;

        private List<Skola> _skoly;
        private List<Zak> _zaci;

        public Zak_Upravit()
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

        public Zak_Upravit(List<Skola> skoly, List<Zak> zaci)
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

        private void Zak_Upravit_Load(object sender, EventArgs e)
        {

            // _skoly.Sort(); // seřazení

            // MessageBox.Show(_skoly.Count.ToString());

            // načtení škol
            cboxSkoly.DataSource = _skoly;
            cboxSkoly.ValueMember = "id";
            cboxSkoly.DisplayMember = "nazev";

            _zaci.Sort(); // seřazení

            // načtení žáků
            cboxZaci.DataSource = _zaci;
            cboxZaci.ValueMember = "Id";
            cboxZaci.DisplayMember = "CeleJmeno";

            // povolení autocomplete
            cboxZaci.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboxZaci.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnUlozit_Click(object sender, EventArgs e)
        {
            string jmeno = tboxJmeno.Text;
            string prijmeni = tboxPrijmeni.Text;
            int kategorie = (int)numKategorie.Value;
            int skola = cboxSkoly.SelectedIndex + 1;
            int zakID = int.Parse(lblZakID.Text);

            try
            {
                SqlCommand vytvorZaka = new SqlCommand($"UPDATE Studenti SET Jmeno = @jmeno, Prijmeni = @prijmeni, Kategorie = @kategorie, Skola = @skola WHERE StudentId = @id", connection);

                vytvorZaka.Parameters.AddWithValue("@jmeno", $"{jmeno}");
                vytvorZaka.Parameters.AddWithValue("@prijmeni", $"{prijmeni}");
                vytvorZaka.Parameters.AddWithValue("@kategorie", kategorie);
                vytvorZaka.Parameters.AddWithValue("@skola", skola);
                vytvorZaka.Parameters.AddWithValue("@id", zakID);

                int stav = vytvorZaka.ExecuteNonQuery();

                if (stav != 0)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    mainHelp.Alert("Chyba!", "Při ukládání úprav žáka do systému se vyskytla chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                mainHelp.Alert("Chyba!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboxZaci_SelectedIndexChanged(object sender, EventArgs e)
        {
            Zak zak = _zaci[cboxZaci.SelectedIndex];

            tboxJmeno.Text = zak.Jmeno;
            tboxPrijmeni.Text = zak.Prijmeni;
            numKategorie.Value = zak.Kategorie;
            cboxSkoly.SelectedIndex = (int)zak.Skola - 1;
            lblZakID.Text = $"{zak.Id}";
        }
    }
}
