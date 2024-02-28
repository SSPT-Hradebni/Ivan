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
        private List<Zak> _studenti;

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

        public Zak_Upravit(List<Skola> skoly, List<Zak> studenti)
        {
            _skoly = skoly;
            _studenti = studenti;

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

            _studenti.Sort(); // seřazení

            // načtení studentů
            cboxStudenti.DataSource = _studenti;
            cboxStudenti.ValueMember = "Id";
            cboxStudenti.DisplayMember = "CeleJmeno";

            // povolení autocomplete
            cboxStudenti.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboxStudenti.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cboxStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            Zak student = _studenti[cboxStudenti.SelectedIndex];

            tboxJmeno.Text = student.Jmeno;
            tboxPrijmeni.Text = student.Prijmeni;
            numKategorie.Value = student.Kategorie;
            cboxSkoly.SelectedIndex = (int)student.Skola - 1;
            lblStudentID.Text = $"{student.Id}";
        }

        private void btnUlozit_Click(object sender, EventArgs e)
        {
            string jmeno = tboxJmeno.Text;
            string prijmeni = tboxPrijmeni.Text;
            int kategorie = (int)numKategorie.Value;
            int skola = cboxSkoly.SelectedIndex + 1;
            int studentID = int.Parse(lblStudentID.Text);

            try
            {
                SqlCommand vytvorStudenta = new SqlCommand($"UPDATE Studenti SET Jmeno = @jmeno, Prijmeni = @prijmeni, Kategorie = @kategorie, Skola = @skola WHERE StudentId = @id", connection);

                vytvorStudenta.Parameters.AddWithValue("@jmeno", $"{jmeno}");
                vytvorStudenta.Parameters.AddWithValue("@prijmeni", $"{prijmeni}");
                vytvorStudenta.Parameters.AddWithValue("@kategorie", kategorie);
                vytvorStudenta.Parameters.AddWithValue("@skola", skola);
                vytvorStudenta.Parameters.AddWithValue("@id", studentID);

                int stav = vytvorStudenta.ExecuteNonQuery();

                if (stav != 0)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    mainHelp.Alert("Chyba!", "Při ukládání úprav studenta do systému se vyskytla chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                mainHelp.Alert("Chyba!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
