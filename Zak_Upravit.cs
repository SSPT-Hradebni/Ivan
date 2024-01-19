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
using System.Windows.Forms;

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

            _skoly.Sort(); // seřazení

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
        }

        private void cboxStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            Zak student = _studenti[cboxStudenti.SelectedIndex];

            tboxJmeno.Text = student.Jmeno;
            tboxPrijmeni.Text = student.Prijmeni;
            numKategorie.Value = student.Kategorie;
            // cboxSkoly.SelectedItem = (int)student.Skola;
        }
    }
}
