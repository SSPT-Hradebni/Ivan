using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// knihovny aplikace
using SediM.Helpers;
using Npgsql;

namespace SediM
{
    public partial class Form1 : Form
    {
        public static NpgsqlDataSourceBuilder dataSourceBuilder = new NpgsqlDataSourceBuilder($"Host={Properties.Settings.Default.MySQL_server};Port={Properties.Settings.Default.MySQL_port};Username={Properties.Settings.Default.MySQL_uzivatel};Password={Properties.Settings.Default.MySQL_heslo};Database={Properties.Settings.Default.MySQL_databaze};");
        public static NpgsqlDataSource dataSource = dataSourceBuilder.Build();

        private NpgsqlConnection? connection;

        public MainHelp mainHelp = new MainHelp();
        public bool jePripojen = false;
        List<Zak> zaci = new List<Zak>();

        public Form1()
        {
            InitializeComponent();

            var conn = dataSource.OpenConnectionAsync();
            connection = conn.Result;

            try
            {
                if (conn.IsFaulted && jePripojen == false)
                {
                    DialogResult pripojen = mainHelp.Alert("Nepodaøilo se pøipojit k serveru", "Aplikaci se nepodaøilo pøipojit k serveru.\nZkontrolujte prosím, zda je server v provozu, a také zkontrolujte správnost zadaných údajù pro pøipojení k serveru.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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

        private void NactiData(NpgsqlConnection? conn)
        {
            dataviewStudenti.Rows.Clear();

            DataTable data = new DataTable();
            NpgsqlDataAdapter dataAdapter;
            NpgsqlCommand cmd = new("SELECT * FROM studenti", conn);

            dataAdapter = new NpgsqlDataAdapter(cmd);
            dataAdapter.Fill(data);

            foreach (DataRow radek in data.Rows)
            {
                Zak zak = new Zak(radek[1].ToString() ?? "", int.Parse(radek[2].ToString() ?? ""), int.Parse(radek[4].ToString() ?? ""), 0, int.Parse(radek[3].ToString() ?? ""), int.Parse(radek[0].ToString() ?? ""), radek[5].ToString() ?? "");
                zaci.Add(zak);

                dataviewStudenti.Rows.Add(zak.poradCislo, zak.jmeno, zak.kateg, zak.skola, zak.rocnik, zak.pozice);
                radek.Delete();
            }

            data.Rows.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NactiData(connection);
        }

        private void btnAktualizujData_Click(object sender, EventArgs e)
        {
            NactiData(connection);
        }

        private void btnVypis_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 7; i++)
            {
                MessageBox.Show($"Poèet žákù v {i}. kategorii je {zaci.Count(item => item.kateg == i)}");
            }
        }

        /// <summary>
        /// Vloží nová data do databáze
        /// </summary>
        /// <remarks>
        /// !!! Opravit vložení již existujících dat !!!
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVlozit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nic tady není");
        }

        private void btnHO_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
        }
    }
}