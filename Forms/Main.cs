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
            zaci = DBNaObjekty.ZiskejListZaku(DBKomunikace.NactiZaky());
            tridy = DBNaObjekty.ZiskejListTrid(DBKomunikace.NactiTridy());
            skoly = DBNaObjekty.ZiskejListSkol(DBKomunikace.NactiSkoly());
            ucitele = DBNaObjekty.ZiskejListUcitelu(DBKomunikace.NactiUcitele());
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

            skoly = DBNaObjekty.ZiskejListSkol(DBKomunikace.NactiSkoly());
        }

        private void upravitSkoluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainHelp.JesteNeni("Úprava stávající školy");
        }

        private void novyZakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zak_Novy okno = new Zak_Novy(skoly, zaci);
            okno.Owner = this;

            DialogResult stav = okno.ShowDialog();

            zaci = DBNaObjekty.ZiskejListZaku(DBKomunikace.NactiZaky());
        }

        private void upravitZakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zak_Upravit okno = new Zak_Upravit(skoly, zaci);
            okno.Owner = this;

            DialogResult stav = okno.ShowDialog();

            zaci = DBNaObjekty.ZiskejListZaku(DBKomunikace.NactiZaky());
        }

        private void seznamZakuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zak_Seznam okno = new Zak_Seznam(zaci);
            okno.Owner = this;

            okno.Show();

            zaci = DBNaObjekty.ZiskejListZaku(DBKomunikace.NactiZaky());
        }

        private void seznamSkolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Skola_Seznam okno = new Skola_Seznam(skoly);
            okno.Owner = this;

            DialogResult stav = okno.ShowDialog();
        }

        private void novaUcebnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trida_Nova okno = new Trida_Nova(tridy);
            okno.Owner = this;

            DialogResult stav = okno.ShowDialog();

            tridy = DBNaObjekty.ZiskejListTrid(DBKomunikace.NactiTridy());
        }

        private void upravitUcebnuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trida_Uprava okno = new Trida_Uprava(tridy);
            okno.Owner = this;

            DialogResult stav = okno.ShowDialog();

            tridy = DBNaObjekty.ZiskejListTrid(DBKomunikace.NactiTridy());
        }

        private void seznamUcebenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trida_Seznam okno = new Trida_Seznam(tridy);
            okno.Owner = this;

            okno.Show();
        }

        private void picbox_NovyZak_Click(object sender, EventArgs e)
        {
            DialogResult stav = mainHelp.StudentForm_New(this, skoly, zaci);

            tridy = DBNaObjekty.ZiskejListTrid(DBKomunikace.NactiTridy());
            zaci = DBNaObjekty.ZiskejListZaku(DBKomunikace.NactiZaky());
        }

        private void RozsazenitoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularRozsazeni okno = new FormularRozsazeni(tridy, zaci);
            okno.Owner = this;

            okno.Show();

            tridy = DBNaObjekty.ZiskejListTrid(DBKomunikace.NactiTridy());
            zaci = DBNaObjekty.ZiskejListZaku(DBKomunikace.NactiZaky());
        }
    }
}
