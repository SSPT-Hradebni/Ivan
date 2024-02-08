using Npgsql;
using SediM.Forms;
using SediM.Helpers;
using System.Data;
using System.Reflection;

namespace SediM
{
    public partial class Main : Form
    {
        public static NpgsqlDataSourceBuilder dataSourceBuilder = new NpgsqlDataSourceBuilder($"Host={Properties.Settings.Default.MySQL_server};Port={Properties.Settings.Default.MySQL_port};Username={Properties.Settings.Default.MySQL_uzivatel};Password={Properties.Settings.Default.MySQL_heslo};Database={Properties.Settings.Default.MySQL_databaze};");
        public static NpgsqlDataSource dataSource = dataSourceBuilder.Build();

        private NpgsqlConnection connection;
        private DataTable? data;

        public MainHelp mainHelp = new MainHelp();
        public bool jePripojen = false;

        public List<Zak> zaci = new List<Zak>();
        public List<Trida> tridy = new List<Trida>();
        private List<Skola> skoly = new List<Skola>();

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

        private DataTable NactiSkoly()
        {
            DataTable data = new DataTable();
            NpgsqlDataAdapter dataAdapter;
            NpgsqlCommand cmd = new("SELECT * FROM skoly", connection);

            dataAdapter = new NpgsqlDataAdapter(cmd);
            dataAdapter.Fill(data);

            return data;
        }

        private DataTable NactiTridy()
        {
            DataTable data = new DataTable();
            NpgsqlDataAdapter dataAdapter;
            NpgsqlCommand cmd = new("SELECT * FROM tridy", connection);

            dataAdapter = new NpgsqlDataAdapter(cmd);
            dataAdapter.Fill(data);

            return data;
        }

        private DataTable NactiStudenty()
        {
            DataTable data = new DataTable();
            NpgsqlDataAdapter dataAdapter;
            NpgsqlCommand cmd = new("SELECT * FROM studentiv2", connection);

            dataAdapter = new NpgsqlDataAdapter(cmd);
            dataAdapter.Fill(data);

            return data;
        }

        private void NactiData()
        {
            data = NactiStudenty();
            zaci = mainHelp.ListZaku(data);

            data = NactiSkoly();
            skoly = mainHelp.ListSkol(data);

            data = NactiTridy();
            tridy = mainHelp.ListTrid(data);
        }

        private void Exportovat()
        {
            SaveFileDialog ulozit = new SaveFileDialog();
            ulozit.Filter = "Tabulka (*.csv)|*.csv";
            ulozit.DefaultExt = "csv";
            ulozit.AddExtension = true;

            if (ulozit.ShowDialog() == DialogResult.OK)
            {
                if (ulozit.CheckFileExists == false)
                {
                    mainHelp.ToCSV(data, ulozit.FileName);
                }
            }
        }

        private void Importovat()
        {
            OpenFileDialog otevrit = new OpenFileDialog();
            otevrit.Filter = "Tabulka (*.csv)|*.csv";
            otevrit.DefaultExt = "csv";
            otevrit.AddExtension = true;

            if (otevrit.ShowDialog() == DialogResult.OK)
            {
                // TODO: uložení importovaných dat
                MessageBox.Show("Data byla úspěšně importována", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            NactiData();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exportovat();
        }

        private void ukončitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opravdu = MessageBox.Show(this, "Opravdu chcete aplikaci ukončit? Všechna neuložená data budou ztracena.", "Ukončit aplikaci", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opravdu == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        private void oAplikaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Version verzeAplikace = Assembly.GetExecutingAssembly().GetName().Version;
            string verze = $"Verze {verzeAplikace.Major}.{verzeAplikace.Minor}.{verzeAplikace.Build}";

            MessageBox.Show($"Aplikace SediM\n2023 - {DateTime.Now.Year} © ŠSPT pro SPŠ, SOŠ a SOU Hradec Králové\n\n{verze}\n\nAplikace SediM umožňuje správu a organizaci krajského kola matematické soutěže.");
        }
        /* POZNÁMKA:
         * Při rozsazování se odebírají jak studenti, tak třídy. 
         * Nejsem si však jistý, jestli je to žádoucí chování, či nikoliv.
         * Odebírání studentů dle mého není žádoucí, odebírání tříd však
         * pravděpodobně ano kvůli pozdější implementaci úpravy rozsazení.
        */
        private void noveRozsazeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularRozsazeni formularRozsazeni = new FormularRozsazeni(tridy, zaci, connection);
            formularRozsazeni.Owner = this;
            formularRozsazeni.ShowDialog();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Importovat();
        }

        /// <summary>
        /// Toolstrip pro otevření okna pro vytvoření nového studenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void novýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zak_Novy okno = new Zak_Novy(skoly, zaci);
            okno.Owner = this;

            DialogResult stav = okno.ShowDialog();

            if (stav == DialogResult.OK)
            {
                NactiData();
            }
        }

        private void upravitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zak_Upravit okno = new Zak_Upravit(skoly, zaci);
            okno.Owner = this;

            DialogResult stav = okno.ShowDialog();

            if (stav == DialogResult.OK)
            {
                NactiData();
            }
        }

        private void seznamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zak_Seznam okno = new Zak_Seznam(zaci);
            okno.Owner = this;

            DialogResult stav = okno.ShowDialog();
        }

        private void nováToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Trida_Nova okno = new Trida_Nova(tridy);
            okno.Owner = this;

            DialogResult stav = okno.ShowDialog();

            if (stav == DialogResult.OK)
            {
                NactiData();
            }
        }

        private void nápovědaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainHelp.ShowHelp(this);
        }
    }
}
