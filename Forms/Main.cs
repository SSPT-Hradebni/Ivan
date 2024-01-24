using System.Windows.Forms;
using Npgsql;
using SediM.Helpers;
using System.Data;
using System.Reflection;
using System.Timers;
using System.Xml;
using SediM.Forms;

namespace SediM
{
    public partial class Main : Form
    {
        public static NpgsqlDataSourceBuilder dataSourceBuilder = new NpgsqlDataSourceBuilder($"Host={Properties.Settings.Default.MySQL_server};Port={Properties.Settings.Default.MySQL_port};Username={Properties.Settings.Default.MySQL_uzivatel};Password={Properties.Settings.Default.MySQL_heslo};Database={Properties.Settings.Default.MySQL_databaze};");
        public static NpgsqlDataSource dataSource = dataSourceBuilder.Build();

        private NpgsqlConnection? connection;
        private DataTable? data;
        private DataTable? dataSkoly;
        private System.Timers.Timer _systemTimer;

        public MainHelp mainHelp = new MainHelp();
        public bool jePripojen = false;
        private List<Skola> skoly = new List<Skola>();

        public List<Zak> zaci = new List<Zak>();

        // Pomocná proměnná. Zabraňuje opakovanému přesunutí komponent při události comboboxu výběru tříd.
        private bool vyberTridNovyVybrana = true;

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

            combobxVyberTrid.SelectedIndex = 0;
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
            data = NactiStudenty();
            dataSkoly = NactiSkoly();

            // načtení žáků do listu pro práci s dočasnými hodnotami (data mohou být aktualizována přímo na serveru bez obnovení dat v aplikaci)
            zaci = mainHelp.ListZaku(data);
            skoly = mainHelp.ListSkol(dataSkoly);

            // načtení dat do hlavní tabulky
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

        private void numupdownClassroomWidth_ValueChanged(object sender, EventArgs e)
        {
            panelEditClassroom.Invalidate();
        }

        private void numupdownClassroomHeight_ValueChanged(object sender, EventArgs e)
        {
            panelEditClassroom.Invalidate();
        }

        private void panelEditClassroom_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Obrys třídy
            g.DrawRectangle(
                Pens.Gray,
                0, 0, // Počáteční bod (vlevo nahoře)
                panelEditClassroom.Width - 1, panelEditClassroom.Height - 1); // Koncový bod (vpravo dole)
            // Tabule
            g.FillRectangle(
                Brushes.DarkGreen,
                0, panelEditClassroom.Height / 4, // Počáteční bod (0% od levé stěny, 25% od horní stěny)
                (int)(panelEditClassroom.Width * 0.02), // Šířka - 2%
                panelEditClassroom.Height / 2); // Délka (výška) - 50%
            // Katedra
            g.FillRectangle(
                Brushes.Black,
                (int)(panelEditClassroom.Height * 0.1), // Roh katedry (10% od levé stěny)
                panelEditClassroom.Height - (int)(panelEditClassroom.Height * 0.2), // Roh katedry (20% od dolní stěny)
                (int)(panelEditClassroom.Height * 0.15), // Šířka - 15%
                (int)(panelEditClassroom.Width * 0.2)); // Délka (výška) - 20%

            // Místa pro studenty
            // Poznámka: plocha pro vykreslování míst studentů je snížena o 5% od stěn a katedry
            Point pocatekPlochyMist = new Point((int)(panelEditClassroom.Width * 0.2), (int)(panelEditClassroom.Height * 0.05));
            // Vypočítá podíl rozdílu šířky plochy pro vykreslení míst a hodnoty numericUpDown
            // pro počet míst ve třídě do šířky hodnotou numericUpDown ... do šířky
            int mistoSirka = (int)((panelEditClassroom.Width * 0.75 - (double)numupdownClassroomWidth.Value) / (double)numupdownClassroomWidth.Value);

            // Stejný princip ale pro počet míst ve třídě do výšky
            int mistoVyska = (int)((panelEditClassroom.Height * 0.9 - (double)numupdownClassroomHeight.Value) / (double)numupdownClassroomHeight.Value);

            for (int r = 0; r < numupdownClassroomHeight.Value; r++) // r - řádek
            {
                for (int s = 0; s < numupdownClassroomWidth.Value; s++) // s - sloupec
                {
                    g.FillRectangle(
                        Brushes.Gray,
                        pocatekPlochyMist.X + s * mistoSirka + s, // Každé nadcházející vykreslení se odsadí o dalších mistoSirka + 1
                        pocatekPlochyMist.Y + r * mistoVyska + r, // To samé platí zde s rozdílem, že se vykreslení odsadí každý další řádek
                        mistoSirka,
                        mistoVyska);
                }
            }

        }

        private void combobxVyberTrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobxVyberTrid.Text == "Nový")
            {
                numupdownClassroomWidth.Value = 1;
                numupdownClassroomHeight.Value = 1;

                // Při prvotním spuštění předchází přesunutí komponent
                if (vyberTridNovyVybrana) return;
                txtbxNazevTridy.Visible = true;
                numupdownClassroomWidth.Location = new Point(numupdownClassroomWidth.Location.X, numupdownClassroomWidth.Location.Y + 29);
                lblUpravaTrid.Location = new Point(lblUpravaTrid.Location.X, lblUpravaTrid.Location.Y + 29);
                numupdownClassroomHeight.Location = new Point(numupdownClassroomHeight.Location.X, numupdownClassroomHeight.Location.Y + 29);
                btnNastavitTridu.Location = new Point(btnNastavitTridu.Location.X, btnNastavitTridu.Location.Y + 29);
                btnOdstranitTridu.Location = new Point(btnOdstranitTridu.Location.X, btnOdstranitTridu.Location.Y + 29);
                vyberTridNovyVybrana = true;

                txtbxNazevTridy.Text = "";

                return;
            }

            // Formát tříd v comboboxu: LV04 (4x5)
            numupdownClassroomWidth.Value = int.Parse(combobxVyberTrid.Text.Split('(')[1].Split('x')[0]);
            numupdownClassroomHeight.Value = int.Parse(combobxVyberTrid.Text.Split('(')[1].Split('x')[1].Replace(")", ""));

            if (!vyberTridNovyVybrana) return;
            txtbxNazevTridy.Visible = false;
            numupdownClassroomWidth.Location = new Point(numupdownClassroomWidth.Location.X, numupdownClassroomWidth.Location.Y - 29);
            lblUpravaTrid.Location = new Point(lblUpravaTrid.Location.X, lblUpravaTrid.Location.Y - 29);
            numupdownClassroomHeight.Location = new Point(numupdownClassroomHeight.Location.X, numupdownClassroomHeight.Location.Y - 29);
            btnNastavitTridu.Location = new Point(btnNastavitTridu.Location.X, btnNastavitTridu.Location.Y - 29);
            btnOdstranitTridu.Location = new Point(btnOdstranitTridu.Location.X, btnOdstranitTridu.Location.Y - 29);
            vyberTridNovyVybrana = false;

            txtbxNazevTridy.Text = combobxVyberTrid.Text;
        }

        private void btnOdstranitTridu_Click(object sender, EventArgs e)
        {
            if (combobxVyberTrid.Text == "Nový")
            {
                numupdownClassroomWidth.Value = 1;
                numupdownClassroomHeight.Value = 1;
                return;
            }

            string nazev = combobxVyberTrid.Text;

            combobxVyberTrid.Items.RemoveAt(combobxVyberTrid.SelectedIndex);
        }

        private void btnNastavitTridu_Click(object sender, EventArgs e)
        {
            if (txtbxNazevTridy.Text == combobxVyberTrid.Text)
            {
                MessageBox.Show("Nevypracovaná funkcionalita! - TODO\r\nÚprava stávající třídy", "Chyba při zpracování třídy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtbxNazevTridy.Text.Contains('(') | txtbxNazevTridy.Text.Contains(')'))
            {
                MessageBox.Show("Název třídy nesmí obsahovat kulaté závorky!", "Chyba při zpracování třídy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtbxNazevTridy.Text == "")
            {
                MessageBox.Show("Nelze vytvořit bezejmennou třídu", "Chyba při zpracování třídy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (combobxVyberTrid.Text == "Nový")
            {
                combobxVyberTrid.Items.Add($"{txtbxNazevTridy.Text} ({numupdownClassroomWidth.Value}x{numupdownClassroomHeight.Value})");
            }
            // TODO: Chybí kontrola proti opakovanému vkládání stejnojmenných tříd.
        }

        private void noveRozsazeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularRozsazeni formularRozsazeni = new FormularRozsazeni(combobxVyberTrid.Items.Cast<string>());
            formularRozsazeni.setSkoly(skoly);
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

            if (stav == DialogResult.OK)
            {
                NactiData();
            }
        }
    }
}
