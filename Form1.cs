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
        List<Zak> zaci = new List<Zak>();

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
                Zak zak = new Zak(radek[1].ToString(), int.Parse(radek[3].ToString()), int.Parse(radek[4].ToString()), 1, int.Parse(radek[2].ToString()), int.Parse(radek[0].ToString()), radek[5].ToString());
                zaci.Add(zak);

                dataviewStudenti.Rows.Add(zak.poradCislo, zak.jmeno, zak.kateg, zak.skola, zak.rocnik, zak.pozice);
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
            MySqlCommand prikaz;

            for (int i = 0; i < dataviewStudenti.Rows.Count; i++)
            {
                prikaz = new MySqlCommand("INSERT INTO `studenti`(`jmeno_prijmeni`, `kategorie`, `skola`, `rocnik`) VALUES (@JmenoPrijmeni, @Kategorie, @Skola, @Rocnik)", connection: mySqlConnection);

                prikaz.Parameters.Add("@JmenoPrijmeni", MySqlDbType.Text).Value = dataviewStudenti.Rows[i].Cells[1].Value;
                prikaz.Parameters.Add("@Kategorie", MySqlDbType.VarChar).Value = dataviewStudenti.Rows[i].Cells[2].Value;
                prikaz.Parameters.Add("@Skola", MySqlDbType.Int64).Value = dataviewStudenti.Rows[i].Cells[3].Value;
                prikaz.Parameters.Add("@Rocnik", MySqlDbType.Int64).Value = dataviewStudenti.Rows[i].Cells[4].Value;

                prikaz.ExecuteNonQuery();
            }

            mySqlConnection.Close();
        }
    }
}