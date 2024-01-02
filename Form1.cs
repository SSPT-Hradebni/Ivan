using Npgsql;
// knihovny aplikace
using SediM.Helpers;
using System.Data;

namespace SediM
{
    public partial class Form1 : Form
    {
        public static NpgsqlDataSourceBuilder dataSourceBuilder = new NpgsqlDataSourceBuilder($"Host={Properties.Settings.Default.MySQL_server};Port={Properties.Settings.Default.MySQL_port};Username={Properties.Settings.Default.MySQL_uzivatel};Password={Properties.Settings.Default.MySQL_heslo};Database={Properties.Settings.Default.MySQL_databaze};");
        public static NpgsqlDataSource dataSource = dataSourceBuilder.Build();

        private NpgsqlConnection? connection;

        public MainHelp mainHelp = new MainHelp();
        public bool jePripojen = false;
        //List<Zak> zaci = new List<Zak>();
        List<Skola> skoly = new List<Skola>();

        public Form1()
        {
            InitializeComponent();

            var conn = dataSource.OpenConnectionAsync();
            connection = conn.Result;

            try
            {
                if (conn.IsFaulted && jePripojen == false)
                {
                    DialogResult pripojen = mainHelp.Alert("Nepoda�ilo se p�ipojit k serveru", "Aplikaci se nepoda�ilo p�ipojit k serveru.\nZkontrolujte pros�m, zda je server v provozu, a tak� zkontrolujte spr�vnost zadan�ch �daj� pro p�ipojen� k serveru.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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

            // Vysv�tlen� jednotliv�ch index� datov�ho typu DataRow
            // [0] - Po�adov� ��slo
            // [1] - Jm�no 
            // [2] - �kola 
            // [3] - Kategorie 
            // [4] - Ro�n�k 
            // [5] - Pozice
            foreach (DataRow zak in data.Rows)
            {
                // [1], [2], [4], 0, [3], [0], [5]
                //Zak zak = new Zak(radek[1].ToString() ?? "", int.Parse(radek[2].ToString() ?? ""), int.Parse(radek[4].ToString() ?? ""), 0, int.Parse(radek[3].ToString() ?? ""), int.Parse(radek[0].ToString() ?? ""), radek[5].ToString() ?? "");
                //zaci.Add(zak);

                // Pokud �kola, v kter� se dan� ��k nach�z� neexistuje v listu skoly, vytvo�� se.
                if (skoly.Exists(skola => skola.Id == (int)zak[2]) == false) skoly.Add(new Skola((int)zak[2]));
                // ��k se um�st� do p��slu�n� �koly a kategorie
                skoly.Find(skola => skola.Id == (int)zak[2]).Kategorie[(int)zak[3]].Add(new Zak(zak[1].ToString() ?? ""));

                //dataviewStudenti.Rows.Add(zak.poradCislo, zak.jmeno, zak.kateg, zak.skola, zak.rocnik, zak.pozice);
                zak.Delete();
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
                //MessageBox.Show($"Po�et ��k� v {i}. kategorii je {zaci.Count(item => item.kateg == i)}"); // FIXME
            }
        }

        /// <summary>
        /// Vlo�� nov� data do datab�ze
        /// </summary>
        /// <remarks>
        /// !!! Opravit vlo�en� ji� existuj�c�ch dat !!!
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVlozit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nic tady nen�");
        }

        private void btnHO_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
        }
    }
}