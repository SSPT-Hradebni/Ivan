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
using System.Timers;
using System.Windows.Forms;

namespace SediM
{
    public partial class Main : Form
    {
        public static NpgsqlDataSourceBuilder dataSourceBuilder = new NpgsqlDataSourceBuilder($"Host={Properties.Settings.Default.MySQL_server};Port={Properties.Settings.Default.MySQL_port};Username={Properties.Settings.Default.MySQL_uzivatel};Password={Properties.Settings.Default.MySQL_heslo};Database={Properties.Settings.Default.MySQL_databaze};");
        public static NpgsqlDataSource dataSource = dataSourceBuilder.Build();

        private NpgsqlConnection? connection;
        private DataTable data;
        private System.Timers.Timer _systemTimer;

        public MainHelp mainHelp = new MainHelp();
        public bool jePripojen = false;
        List<Zak> zaci = new List<Zak>();

        public Main()
        {
            InitializeComponent();

            _systemTimer = new System.Timers.Timer(2000);
            _systemTimer.Elapsed += _systemTimer_Elapsed;

            toolStripStatusLabel.Text = string.Empty;


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

        void _systemTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            toolStripStatusLabel.Text = string.Empty;
            _systemTimer.Stop(); // stop it if you don't want it repeating 
        }


        private DataTable NactiStudenty()
        {
            DataTable data = new DataTable();
            NpgsqlDataAdapter dataAdapter;
            NpgsqlCommand cmd = new("SELECT * FROM studenti", connection);

            dataAdapter = new NpgsqlDataAdapter(cmd);
            dataAdapter.Fill(data);

            return data;
        }

        private void NactiStudentyDoSelectu()
        {
            data = NactiStudenty();

            foreach (DataRow radek in data.Rows)
            {
                string[] prijmeniJmeno = radek[1].ToString().Split(' ');
                cboxStudenti.Items.Add($"{prijmeniJmeno[1]} {prijmeniJmeno[0]}");
            }
        }

        private void NactiData()
        {
            dataviewStudenti.Rows.Clear();

            DataTable data = NactiStudenty();

            foreach (DataRow radek in data.Rows)
            {
                Zak zak = new Zak(radek[1].ToString() ?? "", int.Parse(radek[2].ToString() ?? ""), int.Parse(radek[4].ToString() ?? ""), 0, int.Parse(radek[3].ToString() ?? ""), int.Parse(radek[0].ToString() ?? ""), radek[5].ToString() ?? "");
                zaci.Add(zak);

                dataviewStudenti.Rows.Add(zak.poradCislo, zak.jmeno, zak.kateg, zak.skola, zak.rocnik, zak.pozice);
                radek.Delete();
            }

            data.Rows.Clear();
        }

        private void Exportovat()
        {
            SaveFileDialog ulozit = new SaveFileDialog();
            ulozit.Filter = "Tabulka (*.csv)|*.csv";
            ulozit.DefaultExt = "csv";
            ulozit.AddExtension = true;

            ulozit.ShowDialog();

            if (ulozit.CheckFileExists == false)
            {
                mainHelp.ToCSV(data, ulozit.FileName);
                toolStripStatusLabel.Text = $"Data exportována do \"{ulozit.FileName}\"";
                _systemTimer.Start();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            NactiData();
            NactiStudentyDoSelectu();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exportovat();
        }

        private void ukončitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opravdu = MessageBox.Show(this, "Opravdu chcete aplikaci ukončit? Všechna neuložená data budou ztracena.", "Ukončit aplikaci", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(opravdu == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        private void oAplikaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Aplikace SediM\n2023 - {DateTime.Now.Year} © ŠSPT pro SPŠ, SOŠ a SOU Hradec Králové\n\nAplikace SediM umožňuje správu a organizaci krajského kola matematické soutěže.");
        }
    }
}
