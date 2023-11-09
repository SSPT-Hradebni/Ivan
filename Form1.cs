using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.Collections;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

// knihovny aplikace
using SediM.Helpers;

namespace SediM
{
    public partial class Form1 : Form
    {
        public MySqlConnection mySqlConnection = new MySqlConnection($"Server={Properties.Settings.Default.MySQL_server}; database={Properties.Settings.Default.MySQL_databaze}; uID={Properties.Settings.Default.MySQL_uzivatel}; pwd={Properties.Settings.Default.MySQL_heslo}");
        public MainHelp mainHelp = new MainHelp();
        public bool jePripojen = false;

        private void NactiData()
        {
            dataviewStudenti.Rows.Clear();

            DataTable data = new DataTable();
            MySqlDataAdapter dataAdapter;
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM studenti", mySqlConnection);

            dataAdapter = new MySqlDataAdapter(cmd);
            dataAdapter.Fill(data);

            foreach (DataRow radek in data.Rows)
            {
                dataviewStudenti.Rows.Add(radek[0], radek[1], radek[2], radek[3], radek[4], radek[5]);
                radek.Delete();
            }

            data.Rows.Clear();
        }

        public Form1()
        {
            InitializeComponent();

            try
            {
                mySqlConnection.Open();

                if (!mySqlConnection.Ping() && jePripojen == false)
                {
                    DialogResult pripojen = mainHelp.Alert("Nepodaøilo se pøipojit k serveru", "Aplikaci se nepodaøilo pøipojit k serveru.\nZkontrolujte prosím, zda je server v provozu, a také zkontrolujte správnost zadaných údajù pro pøipojení k serveru.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (pripojen == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                    else if (pripojen == DialogResult.Retry)
                    {
                        while (jePripojen == false)
                        {
                            mySqlConnection.Close();
                            Task.Delay(1000);
                            mySqlConnection.Open();

                            if (!mySqlConnection.Ping())
                            {
                                jePripojen = false;
                            }
                            else
                            {
                                jePripojen = true;
                            }
                        }
                    }

                    return;
                }
            }
            catch (MySqlException e)
            {
                mainHelp.Alert("Chyba MySQL", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NactiData();
        }

        private void btnAktualizujData_Click(object sender, EventArgs e)
        {
            NactiData();
        }
    }
}