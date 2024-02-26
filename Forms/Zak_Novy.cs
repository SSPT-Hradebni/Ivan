using SediM.Helpers;
using System.Data;
using System.Data.SqlClient;

namespace SediM
{
    public partial class Zak_Novy : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=37.60.252.204;Initial Catalog=Ivan;User ID=ivan;Password=mE3xBa0it8dVOGr");

        public MainHelp mainHelp = new MainHelp();
        public bool jePripojen = false;

        private List<Skola> _skoly;
        private List<Zak> _studenti;

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

        public Zak_Novy(List<Skola> skoly, List<Zak> studenti)
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

        private void Zak_Novy_Load(object sender, EventArgs e)
        {
            // načtení škol
            cboxSkoly.DataSource = _skoly;
            cboxSkoly.ValueMember = "id";
            cboxSkoly.DisplayMember = "nazev";
        }

        private void btnVytvořit_Click(object sender, EventArgs e)
        {
            try
            {
                string jmeno = tboxJmeno.Text;
                string prijmeni = tboxPrijmeni.Text;
                int kategorie = (int)numKategorie.Value;
                int skola = cboxSkoly.SelectedIndex;

                // ID posledního vloženého studenta do databáze (kvůli indexování o +1)
                int posledniID = _studenti.Count() + 1;

                if (jmeno == "")
                {
                    throw new Exception("Křestní jméno studenta nesmí být prázdné");
                }

                if (prijmeni == "")
                {
                    throw new Exception("Příjmení studenta nesmí být prázdné");
                }

                if (kategorie < 1 || kategorie > 7)
                {
                    throw new Exception("Kategorie musí být v intervalu od 1 do 7 (včetně)");
                }

                if (skola < 0)
                {
                    throw new Exception("Platná škola musí být vybrána");
                }

                SqlCommand vytvorStudenta = new SqlCommand($"INSERT INTO Studenti (Jmeno, Prijmeni, Kategorie, Skola) VALUES(@jmeno, @prijmeni, @kategorie, @skola)", connection);

                vytvorStudenta.Parameters.AddWithValue("@jmeno", $"{jmeno}");
                vytvorStudenta.Parameters.AddWithValue("@prijmeni", $"{prijmeni}");
                vytvorStudenta.Parameters.AddWithValue("@kategorie", kategorie);
                vytvorStudenta.Parameters.AddWithValue("@skola", skola + 1);

                int stav = vytvorStudenta.ExecuteNonQuery();

                if (stav != 0)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    mainHelp.Alert("Chyba!", "Při přidání nového studenta do systému se vyskytla chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                mainHelp.Alert("Chyba!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Zak_Novy_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mainHelp.ShowHelp(this, "student-novy.html");
        }
    }
}
