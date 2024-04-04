using SediM.Forms;
using SediM.Helpers;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace SediM
{
    public partial class Main : Form
    {
        private SqlConnection connection = new SqlConnection($"Data Source={Properties.Settings.Default.MySQL_server};Initial Catalog={Properties.Settings.Default.MySQL_databaze};User ID={Properties.Settings.Default.MySQL_uzivatel};Password={Properties.Settings.Default.MySQL_heslo}");
        private DataTable? data;

        public MainHelp mainHelp = new MainHelp();
        public bool jePripojen = false;

        public List<Zak> zaci = new List<Zak>();
        public List<Trida> tridy = new List<Trida>();
        public List<Trida> nerozsazeneTridy = new List<Trida>();
        private List<Skola> skoly = new List<Skola>();
        private List<Ucitel> ucitele = new List<Ucitel>();

        public Main()
        {
            InitializeComponent();

            connection.Open();
            ConnectionState stavDB = connection.State;

            try
            {
                if (stavDB == ConnectionState.Broken && jePripojen == false)
                {
                    DialogResult pripojen = mainHelp.Alert("Nepodařilo se připojit k serveru", "Aplikaci se nepodařilo připojit k serveru.\nZkontrolujte prosím, zda je server v provozu, a také zkontrolujte správnost zadaných údajů pro připojení k serveru.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (pripojen == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }

                    return;
                }
            }
            catch (SqlException e)
            {
                mainHelp.Alert("Chyba SQL serveru", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private DataTable NactiSkoly()
        {
            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter;
            SqlCommand cmd = new("SELECT * FROM Skoly", connection);

            dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(data);

            return data;
        }

        private DataTable NactiTridy(bool jenNerozsazene = false)
        {
            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter;

            SqlCommand cmd;

            if (jenNerozsazene)
            {
                cmd = new($"SELECT * FROM Tridy WHERE JeRozsazena = 0", connection);
            }
            else
            {
                cmd = new($"SELECT * FROM Tridy", connection);
            }

            dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(data);

            return data;
        }

        private DataTable NactiStudenty()
        {
            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter;
            SqlCommand cmd = new("SELECT * FROM Studenti", connection);

            dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(data);

            return data;
        }

        private DataTable NactiUcitele()
        {
            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter;
            SqlCommand cmd = new("SELECT * FROM Ucitele", connection);

            dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(data);

            return data;
        }

        public void NactiData()
        {
            data = NactiStudenty();
            List<Zak> noveZaci = mainHelp.ListZaku(data);
            zaci.Clear(); // vymazání starých údajů
            zaci = noveZaci;

            data = NactiSkoly();
            List<Skola> noveSkoly = mainHelp.ListSkol(data);
            skoly.Clear(); // vymazání starých údajů
            skoly = noveSkoly;

            data = NactiTridy();
            List<Trida> noveTridy = mainHelp.ListTrid(data);
            tridy.Clear(); // vymazání starých údajů
            tridy = noveTridy;

            data = NactiUcitele();
            List<Ucitel> noveUcitele = mainHelp.ListUcitelu(data);
            ucitele.Clear(); // vymazání starých údajů
            ucitele = noveUcitele;
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

        private void oAplikaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Version verzeAplikace = Assembly.GetExecutingAssembly().GetName().Version;
            string verze = $"Verze {verzeAplikace.Major}.{verzeAplikace.Minor}.{verzeAplikace.Build}";

            MessageBox.Show($"Aplikace {Properties.Settings.Default.AppName}\n2023 - {DateTime.Now.Year} © ŠSPT pro SPŠ, SOŠ a SOU, Hradec Králové\n\n{verze}\n\nAplikace umožňuje organizaci přihlašování a rozsazení žáků celostátního kola matematické soutěže.");
        }

        private void napovedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainHelp.ShowHelp(this);
        }

        private void ukoncitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opravdu = MessageBox.Show(this, "Opravdu chcete aplikaci ukončit? Všechna neuložená data budou ztracena.", "Ukončit aplikaci", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opravdu == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        private void novyUcitelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainHelp.JesteNeni("Vytvořit nového učitele");
        }

        private void upravitUciteleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainHelp.JesteNeni("Upravit existujícího učitele");
        }

        private void seznamUciteluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainHelp.JesteNeni("Zobrazit seznam učitelů");
        }

        private void novaSkolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult stav = mainHelp.SkolaForm_New(this, ucitele);

            NactiData();
        }

        private void upravitSkoluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainHelp.JesteNeni("Úprava stávající školy");
        }

        private void seznamSkolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainHelp.JesteNeni("Zobrazení seznamu škol");
        }

        private void novaTridaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trida_Nova okno = new Trida_Nova(tridy);
            okno.Owner = this;

            DialogResult stav = okno.ShowDialog();

            NactiData();
        }

        private void upravitTriduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trida_Uprava okno = new Trida_Uprava(tridy);
            okno.Owner = this;

            DialogResult stav = okno.ShowDialog();

            NactiData();
        }

        private void seznamTridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trida_Seznam okno = new Trida_Seznam(tridy);
            okno.Owner = this;

            DialogResult stav = okno.ShowDialog();

            NactiData();
        }

        private void noveRozsazeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularRozsazeni okno = new FormularRozsazeni(tridy, zaci);
            okno.Owner = this;

            DialogResult stav = okno.ShowDialog();

            NactiData();
        }

        private void zobrazitRozsazenitoolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainHelp.JesteNeni("Zobrazení rozsazených tříd");
        }

        private void novyZakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zak_Novy okno = new Zak_Novy(skoly, zaci);
            okno.Owner = this;

            DialogResult stav = okno.ShowDialog();

            NactiData();
        }

        private void upravitZakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zak_Upravit okno = new Zak_Upravit(skoly, zaci);
            okno.Owner = this;

            DialogResult stav = okno.ShowDialog();

            NactiData();
        }

        private void seznamZakuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zak_Seznam okno = new Zak_Seznam(zaci);
            okno.Owner = this;

            DialogResult stav = okno.ShowDialog();

            NactiData();
        }

        private void picbox_NovyZak_Click(object sender, EventArgs e)
        {
            DialogResult stav = mainHelp.StudentForm_New(this, skoly, zaci);

            NactiData();
        }
    }
}
