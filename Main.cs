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
    public partial class Main : Form
    {
        public static NpgsqlDataSourceBuilder dataSourceBuilder = new NpgsqlDataSourceBuilder($"Host={Properties.Settings.Default.MySQL_server};Port={Properties.Settings.Default.MySQL_port};Username={Properties.Settings.Default.MySQL_uzivatel};Password={Properties.Settings.Default.MySQL_heslo};Database={Properties.Settings.Default.MySQL_databaze};");
        public static NpgsqlDataSource dataSource = dataSourceBuilder.Build();

        private NpgsqlConnection? connection;

        public MainHelp mainHelp = new MainHelp();
        public bool jePripojen = false;
        List<Zak> zaci = new List<Zak>();

        public Main()
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
            DataTable data = NactiStudenty();

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

            // mainHelp.ToCSV(data, "studenti");
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
    }
}
