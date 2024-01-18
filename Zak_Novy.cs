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
    public partial class Zak_Novy : Form
    {
        private static NpgsqlDataSourceBuilder dataSourceBuilder = new NpgsqlDataSourceBuilder($"Host={Properties.Settings.Default.MySQL_server};Port={Properties.Settings.Default.MySQL_port};Username={Properties.Settings.Default.MySQL_uzivatel};Password={Properties.Settings.Default.MySQL_heslo};Database={Properties.Settings.Default.MySQL_databaze};");
        private static NpgsqlDataSource dataSource = dataSourceBuilder.Build();
        private NpgsqlConnection? connection;

        public MainHelp mainHelp = new MainHelp();
        public bool jePripojen = false;

        private DataTable _skoly;

        public Zak_Novy()
        {
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
                        Application.Exit();
                    }

                    return;
                }
            }
            catch (NpgsqlException e)
            {
                mainHelp.Alert("Chyba PostgreSQL", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public Zak_Novy(DataTable skoly)
        {
            _skoly = skoly;
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

        private void Zak_Novy_Load(object sender, EventArgs e)
        {
            cboxSkoly.DataSource = _skoly;
            cboxSkoly.ValueMember = "id";
            cboxSkoly.DisplayMember = "nazev";
        }

        private void btnVytvořit_Click(object sender, EventArgs e)
        {
            string jmeno = tboxJmeno.Text ?? "";
            string prijmeni = tboxPrijmeni.Text ?? "";
            int kategorie = (int)numKategorie.Value;
            int skola = cboxSkoly.SelectedIndex;

                try
                {
                    NpgsqlCommand vytvorStudenta = new NpgsqlCommand($"INSERT INTO studentiv2 (jmeno_prijmeni, kategorie, skola) VALUES(@jmenoprijmeni, @kategorie, @skola)", connection);

                    vytvorStudenta.Parameters.AddWithValue("@jmenoprijmeni", $"{tboxJmeno.Text} {tboxPrijmeni.Text}");
                    vytvorStudenta.Parameters.AddWithValue("@kategorie", kategorie);
                    vytvorStudenta.Parameters.AddWithValue("@skola", skola);

                    int stav = vytvorStudenta.ExecuteNonQuery();

                    if(stav != 0)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        mainHelp.Alert("Chyba!", "Při přidání nového student do systému se vyskytla chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } catch (Exception ex)
                {
                    mainHelp.Alert("Chyba!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
