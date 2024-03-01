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

        private DataTable NactiSkoly()
        {
            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter;
            SqlCommand cmd = new("SELECT * FROM Skoly", connection);

            dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(data);

            return data;
        }

        /// <summary>
        /// Načte třídy z databáze
        /// </summary>
        /// <param name="jenNerozsazene">Zda se mají načíst pouze nerozsazené třídy</param>
        /// <returns>Tabulka dat tříd</returns>
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

        public void NactiData(bool nerozsazeneTridy = false)
        {
            data = NactiStudenty();
            List<Zak> noveZaci = mainHelp.ListZaku(data);
            zaci.Clear(); // vymazání starých údajů
            zaci = noveZaci;

            data = NactiSkoly();
            List<Skola> noveSkoly = mainHelp.ListSkol(data);
            skoly.Clear(); // vymazání starých údajů
            skoly = noveSkoly;

            data = NactiTridy(nerozsazeneTridy);
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

            MessageBox.Show($"Aplikace Ivan\n2023 - {DateTime.Now.Year} © ŠSPT pro SPŠ, SOŠ a SOU Hradec Králové\n\n{verze}\n\nAplikace umožňuje správu a organizaci krajského kola matematické soutěže pro Královéhradecký kraj.");
        }
        /* POZNÁMKA:
         * Při rozsazování se odebírají jak studenti, tak třídy. 
         * Nejsem si však jistý, jestli je to žádoucí chování, či nikoliv.
         * Odebírání studentů dle mého není žádoucí, odebírání tříd však
         * pravděpodobně ano kvůli pozdější implementaci úpravy rozsazení.
        */
        private void noveRozsazeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularRozsazeni okno = new FormularRozsazeni(tridy, zaci);
            okno.Owner = this;

            DialogResult stav = okno.ShowDialog();

            if (stav == DialogResult.OK)
            {
                NactiData(true);
            }
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
            mainHelp.StudentForm_New(this, skoly, zaci);
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

        private void upravitTriduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trida_Uprava okno = new Trida_Uprava(tridy);
            okno.Owner = this;

            DialogResult stav = okno.ShowDialog();

            if (stav == DialogResult.OK)
            {
                NactiData();
            }
        }

        private void picbox_StudentNovy_Click(object sender, EventArgs e)
        {
            DialogResult stav = mainHelp.StudentForm_New(this, skoly, zaci);

            if (stav == DialogResult.OK)
            {
                NactiData();
            }
        }

        private void nováToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult stav = mainHelp.SkolaForm_New(this, ucitele);

            if (stav == DialogResult.OK)
            {
                NactiData();
            }
        }

        private void novýToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mainHelp.JesteNeni("Vytvořit nového učitele");
        }

        private void upravitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mainHelp.JesteNeni("Upravit existujícího učitele");
        }

        private void seznamUčitelůToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainHelp.JesteNeni("Zobrazit seznam učitelů");
        }

        private void seznamTřídToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainHelp.JesteNeni("Zobrazit seznam rozsazených i nerozsazených tříd");
        }

        private void seznamŠkolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainHelp.JesteNeni("Zobrazit seznam škol");
        }

        private void upravitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            mainHelp.JesteNeni("Upravit existující školu");
        }

        private void zobrazitRozsazenítoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mainHelp.JesteNeni("Zobrazit rozsazenou třídu");
        }
    }
}
