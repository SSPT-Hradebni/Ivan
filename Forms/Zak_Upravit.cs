using System.Windows.Forms;
using Npgsql;
using SediM.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SediM
{
    public partial class Zak_Upravit : Form
    {
        private static NpgsqlDataSourceBuilder dataSourceBuilder = new NpgsqlDataSourceBuilder($"Host={Properties.Settings.Default.MySQL_server};Port={Properties.Settings.Default.MySQL_port};Username={Properties.Settings.Default.MySQL_uzivatel};Password={Properties.Settings.Default.MySQL_heslo};Database={Properties.Settings.Default.MySQL_databaze};");
        private static NpgsqlDataSource dataSource = dataSourceBuilder.Build();
        private NpgsqlConnection? connection;

        public MainHelp mainHelp = new MainHelp();
        public bool jePripojen = false;

        private List<Skola> _skoly;
        private List<Zak> _studenti;

        public Zak_Upravit()
        {
            InitializeComponent();
        }

        public Zak_Upravit(List<Skola> skoly, List<Zak> studenti)
        {
            _skoly = skoly;
            _studenti = studenti;

            InitializeComponent();

            var conn = dataSource.OpenConnectionAsync();
            connection = conn.Result;

            try
            {
                if (conn.IsFaulted && jePripojen == false)
                {
                    DialogResult pripojen = mainHelp.Alert("Nepodařilo se připojit k serveru", "Aplikaci se nepodařilo připojit k serveru.\nZkontrolujte prosím, zda je server v provozu, a také zkontrolujte správnost zadaných údajů pro připojení k serveru.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (pripojen == DialogResult.Cancel)
                    {
                        Close();
                    }

                    return;
                }
            }
            catch (NpgsqlException e)
            {
                mainHelp.Alert("Chyba PostgreSQL", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
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
                NpgsqlCommand vytvorStudenta = new NpgsqlCommand($"UPDATE studentiv2 SET jmeno_prijmeni = @jmenoprijmeni, kategorie = @kategorie, skola = @skola WHERE id = @id", connection);

                vytvorStudenta.Parameters.AddWithValue("@jmenoprijmeni", $"{jmeno} {prijmeni}");
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
