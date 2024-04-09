using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using SediM.Helpers;
using System.Data;
using System.Data.SqlClient;
using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Rectangle = iText.Kernel.Geom.Rectangle;

namespace SediM
{
    public partial class FormularRozsazeni : Form
    {
        public static readonly PdfNumber PORTRAIT = new PdfNumber(0);
        public static readonly PdfNumber LANDSCAPE = new PdfNumber(90);
        public static readonly PdfNumber INVERTEDPORTRAIT = new PdfNumber(180);
        public static readonly PdfNumber SEASCAPE = new PdfNumber(270);

        private SqlConnection connection = new SqlConnection($"Data Source={Properties.Settings.Default.MySQL_server};Initial Catalog={Properties.Settings.Default.MySQL_databaze};User ID={Properties.Settings.Default.MySQL_uzivatel};Password={Properties.Settings.Default.MySQL_heslo}");

        public MainHelp mainHelp = new MainHelp();
        public bool jePripojen = false;

        // TODO/FIXME: Když uživatel zavře a znovu otevře tento form bez ukončení aplikace (formulář Main)
        // tak zůstanou nastaveny globální proměnné. To je nežádoucí.


        private List<Trida> tridy = new List<Trida>();
        private List<Zak> zaci = new List<Zak>();

        // Proměnná, jejíž hodnota se přiřadí každému dalšímu žákovi při řazení do třídy.
        // Po nastavení její hodnoty žákovi se inkrementuje aby se předešlo dvěma místům se stejnou hodnotou
        private int mistoZaka;

        public FormularRozsazeni(List<Trida> tridy, List<Zak> zaci)
        {
            InitializeComponent();

            try
            {
                connection.Open();
                ConnectionState stavDB = connection.State;

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

            this.tridy = tridy;
            this.zaci = zaci;
            mistoZaka = NasledujiciMistoZaka();
        }

        private int NasledujiciMistoZaka()
        {
            int pocetRozsazenychMist = 0;
            List<Trida> rozsazeneTridy = tridy.FindAll(trida => trida.JeRozsazena);

            foreach (Trida trida in rozsazeneTridy)
                pocetRozsazenychMist += trida.Sirka * trida.Vyska;

            // +1, protože se do mistoZaka vkládá *následující* číslo místa,
            // nikoliv stávající počet rozsazených míst.
            return pocetRozsazenychMist + 1;
        }

        private void cboxTridy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxTridy.SelectedIndex == -1) return;
            listbxVyplneneTridy.SelectedIndex = -1;
            panelVykresleniRozsazeni.Invalidate();

            toolStripButton_Tisk.Visible = false;
        }

        private void listbxVyplneneTridy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbxVyplneneTridy.SelectedIndex == -1) return;
            cboxTridy.SelectedIndex = -1;
            panelVykresleniRozsazeni.Invalidate();

            toolStripButton_Tisk.Visible = true;
        }

        private void panelVykresleniRozsazeni_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Obrys třídy
            g.DrawRectangle(
                Pens.Gray,
                0, 0,
                panelVykresleniRozsazeni.Width - 1, panelVykresleniRozsazeni.Height - 1);

            // Tabule
            g.FillRectangle(
                Brushes.DarkGreen,
                panelVykresleniRozsazeni.Width / 4, (int)(panelVykresleniRozsazeni.Height * 0.98),
                panelVykresleniRozsazeni.Width / 2, (int)(panelVykresleniRozsazeni.Height * 0.02));

            // Katedra
            g.FillRectangle(
                Brushes.Black,
                (int)(panelVykresleniRozsazeni.Width * 0.7), (int)(panelVykresleniRozsazeni.Height * 0.75),
                (int)(panelVykresleniRozsazeni.Width * 0.3), (int)(panelVykresleniRozsazeni.Height * 0.15));

            if (cboxTridy.SelectedIndex == -1 && listbxVyplneneTridy.SelectedIndex == -1) return;

            // Získáme aktuální vybranou třídu
            Trida? aktualniTrida = tridy.Find(hledanaTrida => hledanaTrida.Id == (cboxTridy.SelectedIndex != -1 ? (int)cboxTridy.SelectedValue : (int)listbxVyplneneTridy.SelectedValue));

            // Vyvoláme metodu pro vykreslení míst
            VykresleniMist(g, aktualniTrida);
        }

        private void VykresleniMist(Graphics g, Trida? aktualniTrida)
        {
            // Odstraní veškeré studenty z listboxu aby se nepřidávali přes sebe
            listbxSeznamStudentu.Items.Clear();

            if (aktualniTrida == null) return;

            // Vytvořen "počáteční" bod pro vykreslování míst
            Point pocatekPlochyMist = new Point(
                (int)(panelVykresleniRozsazeni.Width * 0.05),
                (int)(panelVykresleniRozsazeni.Height * 0.05));

            // Vypočítá velikost jednoho místa na základě velikosti dimenzí
            int mistoSirka = (int)((panelVykresleniRozsazeni.Width * 0.9) / aktualniTrida.Sirka);
            int mistoVyska = (int)((panelVykresleniRozsazeni.Height * 0.65) / aktualniTrida.Vyska);

            bool jeTridaRozrazena = listbxVyplneneTridy.SelectedIndex != -1;

            // Hodnoty, které se opakovaně přenastaví ve for cyklech jsou-li třeba
            Zak zak = null;
            bool vyplnitBarevne = false;

            // Opakuje pro každý řádek míst ve třídě
            for (int r = 0; r < aktualniTrida.Vyska; r++)
            {
                // Opakuje pro každé místo v řádku ve třídě
                for (int s = 0; s < aktualniTrida.Sirka; s++)
                {
                    if (jeTridaRozrazena)
                    {
                        // Aktuální objekt žáka, ze kterého získáváme potřebná data
                        zak = aktualniTrida.RozsazeniZaci[r, s];
                        vyplnitBarevne = true;
                    }

                    g.FillRectangle(
                        ZiskejBarvuDleKategorie(
                            vyplnitBarevne
                                ? zak.Kategorie
                                : -1),
                        pocatekPlochyMist.X + s * mistoSirka + s,
                        pocatekPlochyMist.Y + r * mistoVyska + r,
                        mistoSirka, mistoVyska);

                    if (jeTridaRozrazena)
                    {
                        string jmenoZaka =
                            zak.CeleJmeno == "MÍSTO PRÁZDNÉ"
                            ? "PRÁZDNÉ MÍSTO"
                            : zak.CeleJmeno;

                        // Zjistí velikost vykreslovaného řetězce
                        SizeF velikostTextuMista = g.MeasureString($"{zak.Misto}\r\n \r\n ", new Font("Arial", 10));
                        SizeF velikostTextuJmena = g.MeasureString($" \r\n{jmenoZaka}\r\n ", new Font("Arial", 9));
                        SizeF velikostTextuKategorieASkoly = g.MeasureString($" \r\n \r\n{mainHelp.CisloKategorieNaRimske(zak.Kategorie)} {zak.Skola}", new Font("Arial", 10));

                        // kontrast textu s barvou pozadí buňky
                        float svetlostBarvy = ZiskejBarvuDleKategorie(vyplnitBarevne ? zak.Kategorie : -1).Color.GetBrightness();

                        // Vykreslí řetězec na střed buňky (místa)
                        g.DrawString(
                            $"{zak.Misto}\r\n \r\n ",
                            new Font("Arial", 10),
                            svetlostBarvy > 0.65 ? Brushes.Black : Brushes.White,
                            pocatekPlochyMist.X + s * mistoSirka + s + mistoSirka / 2 - velikostTextuMista.Width / 2,
                            pocatekPlochyMist.Y + r * mistoVyska + r + mistoVyska / 2 - velikostTextuMista.Height / 2);
                        g.DrawString(
                            $" \r\n{jmenoZaka}\r\n ",
                            new Font("Arial", 9),
                            svetlostBarvy > 0.65 ? Brushes.Black : Brushes.White,
                            pocatekPlochyMist.X + s * mistoSirka + s + mistoSirka / 2 - velikostTextuJmena.Width / 2,
                            pocatekPlochyMist.Y + r * mistoVyska + r + mistoVyska / 2 - velikostTextuJmena.Height / 2);
                        g.DrawString(
                            $" \r\n \r\n{mainHelp.CisloKategorieNaRimske(zak.Kategorie)} {zak.Skola}",
                            new Font("Arial", 10),
                            svetlostBarvy > 0.65 ? Brushes.Black : Brushes.White,
                            pocatekPlochyMist.X + s * mistoSirka + s + mistoSirka / 2 - velikostTextuKategorieASkoly.Width / 2,
                            pocatekPlochyMist.Y + r * mistoVyska + r + mistoVyska / 2 - velikostTextuKategorieASkoly.Height / 2);

                        // Přidá žáka včetně jeho místa do listboxu seznamu studentů ve třídě
                        listbxSeznamStudentu.Items.Add(
                            $"{zak.Misto} - " +
                            $"{jmenoZaka}");
                    }
                }
            }
        }
        /// <summary>
        /// Získá barvu podle kategorie, ke které je přiřazena. Tato barva je získána z globálního listu barvyKategorii.
        /// </summary>
        /// <param name="kategorie">Kategorie, po níž vyžadujeme její barevnou reprezentaci.</param>
        /// <returns>Barva odpovídající kategorii.</returns>
        private SolidBrush ZiskejBarvuDleKategorie(int kategorie)
        {
            switch (kategorie)
            {
                case 1:
                    return new SolidBrush(Color.LightGreen);
                case 2:
                    return new SolidBrush(Color.Purple);
                case 3:
                    return new SolidBrush(Color.Firebrick);
                case 4:
                    return new SolidBrush(Color.ForestGreen);
                case 5:
                    return new SolidBrush(Color.Indigo);
                case 6:
                    return new SolidBrush(Color.Maroon);
                case 7:
                    return new SolidBrush(Color.PaleVioletRed);
                case 8:
                    return new SolidBrush(Color.SaddleBrown);
                case 9:
                    return new SolidBrush(Color.RoyalBlue);
                case 10:
                    return new SolidBrush(Color.MediumTurquoise);
                case 11:
                    return new SolidBrush(Color.MediumSeaGreen);
                case 12:
                    return new SolidBrush(Color.MidnightBlue);
                default:
                    return new SolidBrush(Color.FromArgb(100, 100, 100));
            }
        }

        private void btnVyplnit_Click(object sender, EventArgs e)
        {
            if (cboxTridy.SelectedIndex == -1) return;

            NastavParametryProVyplneni();
        }

        private void NastavParametryProVyplneni()
        {
            // Získáme aktuální vybranou třídu
            Trida? aktualniTrida = tridy.Find(tridy => tridy.Id == (int)cboxTridy.SelectedValue);

            // Vyplní právě přidanou třídu žáky
            if (VyplnTridu(aktualniTrida.Sirka, aktualniTrida.Vyska, aktualniTrida) == -1)
                return;

            aktualniTrida.JeRozsazena = true;

            // Přesune zvolenou třídu mezi vyplněné třídy
            listbxVyplneneTridy.DataSource = null; // při DataSource nejde vymazat cbox, proto nastaveno teď na null
            listbxVyplneneTridy.DataSource = tridy.FindAll(trida => trida.JeRozsazena);

            // odstranění vyplněné třídy z comboboxu
            cboxTridy.DataSource = null;
            cboxTridy.DataSource = tridy.FindAll(trida => !trida.JeRozsazena);
        }

        /// <summary>
        /// Procykluje každé místo ve třídě a přiradí do dvourozměrného pole představující třídu žáka, 
        /// který je vrácen funkcí ZiskejZaka, algoritmem Knight, zvoleným rulesetem.
        /// </summary>
        /// <param name="indexTridy">Index určující právě vyplňovanou třídu</param>
        /// <param name="sirka">Šířka třídy v místech</param>
        /// <param name="vyska">Výška třídy v místech</param>
        /// <param name="kopieZaku">List, který je kopií globálního listu zaci, vyžadován funkcí ZiskejZaka.</param>
        /// <param name="aktualniTrida">Aktuální vyplňovaná třída</param>
        private int VyplnTridu(int sirka, int vyska, Trida aktualniTrida)
        {
            try
            {
                // Upraví všem nerozsazeným žákům svoji prioritu
                NastavListZaku();
                List<Zak> nerozsazeniZaci = zaci.FindAll(zak => zak.Trida == 0);

                if (nerozsazeniZaci.Count == 0)
                {
                    MessageBox.Show(
                        "Nebyl nalezen dostatečný počet žáků k rozsazení. Učebna nebude vyplněna.",
                        "Upozornění",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return -1;
                }

                VyplnTriduKombinacemi(aktualniTrida, nerozsazeniZaci);

                string data = "";

                // Opakuje pro každý řádek míst ve třídě
                for (int r = 0; r < vyska; r++)
                {
                    // Opakuje pro každé místo v řádku ve třídě
                    for (int s = 0; s < sirka; s++)
                    {
                        Zak zak = ZiskejZaka(aktualniTrida, r, s, nerozsazeniZaci);

                        zak.Misto = mistoZaka;
                        mistoZaka++;

                        data += $"{zak.Misto}={zak.Id}";

                        // Pokud nejsme na posledním místě, přidejte oddělovač
                        if (!(r == vyska - 1 && s == sirka - 1))
                            data += ",";

                        aktualniTrida.RozsazeniZaci[r, s] = zak;

                        if (zak.Id > 0)
                        {
                            SqlCommand upravZaka = new SqlCommand("UPDATE Studenti SET Trida = @trida WHERE StudentId = @student", connection);

                            upravZaka.Parameters.AddWithValue("@trida", aktualniTrida.Id);
                            upravZaka.Parameters.AddWithValue("@student", zak.Id);

                            upravZaka.ExecuteNonQuery();
                        }
                    }
                }

                SqlCommand vyplnTridu = new SqlCommand($"UPDATE Tridy SET JeRozsazena = @stav, DataRozsazeni = @data WHERE TridaId = @id", connection);

                vyplnTridu.Parameters.AddWithValue("@stav", 1);
                vyplnTridu.Parameters.AddWithValue("@data", data);
                vyplnTridu.Parameters.AddWithValue("@id", aktualniTrida.Id);

                vyplnTridu.ExecuteNonQuery();

                return 0;
            }
            catch (Exception ex)
            {
                mainHelp.Alert("Chyba!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private Zak ZiskejZaka(Trida trida, int radek, int sloupec, List<Zak> zaciKRozsazeni)
        {
            Zak returnZak;

            List<int[]> listParametru = trida.PrijatelneKategorieASkolyMista[radek, sloupec];
            // Prohledá dostupné žáky zda-li nemají vhodnou kategorii a třídu
            foreach (int[] parametry in listParametru)
            {
                if ((returnZak = zaciKRozsazeni.Find(hledanyZak => hledanyZak.Skola == parametry[0] && hledanyZak.Priorita == parametry[1])) != null)
                {
                    zaci[zaci.FindIndex(zak => zak.Id == returnZak.Id)].Trida = trida.Id;
                    zaciKRozsazeni.RemoveAt(zaciKRozsazeni.FindIndex(zak => zak.Id == returnZak.Id));
                    UpravMistaTridy(trida, parametry, radek, sloupec);
                    return zaci[zaci.FindIndex(zak => zak.Id == returnZak.Id)];
                }
            }

            return new Zak(-1, "PRÁZDNÉ", "MÍSTO", -1, -1, -1);
        }

        private void UpravMistaTridy(Trida trida, int[] parametry, int radek, int sloupec)
        {
            // Procykluje buňky kolem umístěného žáka (mimo předešlých buněk) a odstraní parametry obsahující stejné školy nebo kategorie
            int[,] bunky = new int[,] {
                {radek, sloupec + 1},
                {radek, sloupec + 2},
                {radek + 1, sloupec - 1},
                {radek + 1, sloupec},
                {radek + 1, sloupec + 1 },
                {radek + 2, sloupec}};

            for (int i = 0; i < bunky.GetLength(0); i++)
                if (bunky[i, 0] < trida.Vyska && bunky[i, 1] >= 0 && bunky[i, 1] < trida.Sirka)
                    trida.PrijatelneKategorieASkolyMista[bunky[i, 0], bunky[i, 1]]
                        .RemoveAll(hledanyParametr => hledanyParametr[0] == parametry[0] || hledanyParametr[1] == parametry[1]);

            // Procykluje třídu počínaje řádkem umístěného žáka a pokračuje až na konec třídy
            for (int r = radek; r < trida.Vyska; r++)
                for (int s = 0; s < trida.Sirka; s++)
                    trida.PrijatelneKategorieASkolyMista[r, s]
                        .RemoveAll(hledanyParametr => hledanyParametr[0] == parametry[0] && hledanyParametr[1] == parametry[1]);

        }

        private void VyplnTriduKombinacemi(Trida trida, List<Zak> zaciKRozsazeni)
        {
            List<int[]> unikatniKategorieSkoly = new List<int[]>();

            foreach (Zak zak in zaciKRozsazeni)
            {
                // Vloží novou kombinaci pokud se nenachází již v listu
                if (unikatniKategorieSkoly.Find(parametry => parametry[0] == zak.Skola && parametry[1] == zak.Priorita) == null)
                    unikatniKategorieSkoly.Add(new int[] { zak.Skola, zak.Priorita });
            }

            // Seřadí parametry v listu na základě dynamických kategorií (vzestupně)
            unikatniKategorieSkoly.Sort((p1, p2) =>
            {
                // Dynamická kategorie kombinace p1 je nižší hodnoty (vyšší priority) - je tedy posunuta blíže k začátku listu
                if (p1[1] < p2[1])
                    return -1;
                // Jinak je kombinace p2 nižší hodnoty, tu tedy přesuneme blíže k začátku listu
                else
                    return 1;
            });

            for (int r = 0; r < trida.Vyska; r++)
            {
                for (int s = 0; s < trida.Sirka; s++)
                {
                    // Jelikož list je referenční datový typ, pro každé místo musíme tedy vytvořit samostatný list (aby se nepřepisovaly)
                    List<int[]> kopieListu = new List<int[]>();

                    foreach (int[] parametry in unikatniKategorieSkoly)
                        kopieListu.Add(parametry);

                    trida.PrijatelneKategorieASkolyMista[r, s] = kopieListu;
                }
            }
        }

        private void NastavListZaku()
        {
            List<Zak> serazeniZaci = new List<Zak>();

            List<List<Zak>> zaciDleKategorie = new List<List<Zak>>();

            List<Zak> nerozsazeniZaci = zaci.FindAll(zak => zak.Trida == 0);

            // Separuje veškeré žáky do kategorií pro následovné řazení
            foreach (Zak zak in nerozsazeniZaci)
            {
                // Pokud je žák již rozsazen nebo se kategorie žáka nachází v proměnné, přeskoč na dalšího žáka
                if (zaciDleKategorie.Exists(kategorie => zak.Kategorie == kategorie[0].Kategorie))
                    continue;

                // Dočasně uloží veškeré nerozsazené žáky nevložené kategorie do proměnné
                List<Zak> novaKategorie = new List<Zak>();
                novaKategorie = zaci.FindAll(hledanyZak => hledanyZak.Kategorie == zak.Kategorie && hledanyZak.Trida == 0);

                // Nakonec vloží novoý list žáků stejné kategorie do proměnné, která uchovává veškeré kategorie
                zaciDleKategorie.Add(novaKategorie);
            }

            // Seřadí kategorie sestupně dle počtu žáků v kategorii
            zaciDleKategorie.Sort((k1, k2) =>
            {
                // Pokud si jsou dvě porovnávané kategorie rovny počtem žáků, nic se nezmění.
                if (k1.Count == k2.Count)
                    return 0;
                // Pokud je k1 menší než k2, vrátí se že je "větší" - větší se posouvají ke konci
                // (řadíme sestupně proto k1 považujeme za "větší" aby se posunula ke konci)
                else if (k1.Count < k2.Count)
                    return 1;
                // Jinak je k2 délkou menší ale vracíme, že
                // je větší aby se posunula více ke konci
                else
                    return -1;
            });

            // Procykluje každou kategorii
            for (int i = 0; i < zaciDleKategorie.Count; i++)
            {
                // Procykluje každého žáka v kategorii
                foreach (Zak zak in zaciDleKategorie[i])
                    zak.Priorita = i + 1;
            }
        }

        private void FormularRozsazeni_Load(object sender, EventArgs e)
        {
            if (tridy.FindAll(trida => !trida.JeRozsazena).Count == 0)
            {
                DialogResult nejsouTridy = mainHelp.Alert("Upozornění", "Program nenalezl žádnou třídu, kterou by bylo možné rozsadit.\r\nChcete automaticky vytvořit novou třídu o výchzozí velikosti?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (nejsouTridy == DialogResult.No)
                {
                    Close();
                }
                else
                {
                    SqlCommand vytvorTridu = new SqlCommand($"INSERT INTO Tridy (Nazev, Sirka, Vyska, JeRozsazena) VALUES(@nazev, @sirka, @vyska, @jeRozsazena)", connection);

                    vytvorTridu.Parameters.AddWithValue("@nazev", $"Trida{tridy.Count + 1}");
                    vytvorTridu.Parameters.AddWithValue("@sirka", 6);
                    vytvorTridu.Parameters.AddWithValue("@vyska", 5);
                    vytvorTridu.Parameters.AddWithValue("@jeRozsazena", 0);

                    int stav = vytvorTridu.ExecuteNonQuery();

                    if (stav == 0)
                    {
                        mainHelp.Alert("Chyba!", "Při automatickém vytvoření nové třídy do systému se vyskytla chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }

                    tridy = DBNaObjekty.ZiskejListTrid(DBKomunikace.NactiTridy());
                }
            }

            cboxTridy.ValueMember = "Id";
            cboxTridy.DisplayMember = "Nazev";
            cboxTridy.DataSource = tridy.FindAll(trida => !trida.JeRozsazena);

            listbxVyplneneTridy.ValueMember = "Id";
            listbxVyplneneTridy.DisplayMember = "Nazev";
            listbxVyplneneTridy.DataSource = tridy.FindAll(trida => trida.JeRozsazena);
        }

        private void toolStripButton_Tisk_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF files|*.pdf";
            sfd.Title = "Exportovat jako PDF";

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            Trida vyplnenaTrida = tridy.Find(trida => trida.Id == (int)listbxVyplneneTridy.SelectedValue);

            PdfDocument doc = new PdfDocument(new PdfWriter(sfd.FileName));

            PageSize velikostStrany = PageSize.A4.Rotate();
            doc.SetDefaultPageSize(velikostStrany);


            PdfCanvas canvas = new PdfCanvas(doc.AddNewPage());

            float sirka = velikostStrany.GetWidth();
            float vyska = velikostStrany.GetHeight();

            Size pocatekStrany = new Size((int)(sirka * 0.05), (int)(vyska * 0.08));

            int pocetRadku = vyplnenaTrida.Vyska;
            int pocetSloupcu = vyplnenaTrida.Sirka;

            // Vypočítá velikost jednoho místa na základě velikosti dimenzí
            // Odsazení: 5% vlevo, 5% vpravo -> 100% - 2x5% = 90% šířky dokumentu vyhrazeno pro vykreslení míst
            int mistoSirka = (int)((sirka * 0.9) / pocetSloupcu);
            // Odsazení: 8% nahoře, 5% dole -> 100% - 8% - 5% = 87% výšky dokumentu...
            int mistoVyska = (int)((vyska * 0.87) / pocetRadku);

            // Nastavíme Arial font jelikož základní nezobrazuje korektně diakritiku
            PdfFont font = PdfFontFactory.CreateFont(
                System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Fonts) + "\\arial.ttf", PdfEncodings.IDENTITY_H);

            // Název třídy v horní části dokumentu
            Paragraph nazevTridy = new Paragraph(vyplnenaTrida.Nazev);
            new Canvas(canvas, velikostStrany).Add(nazevTridy.SetTextAlignment(TextAlignment.CENTER).SetFont(font));

            Rectangle misto = new Rectangle(mistoSirka, mistoVyska);

            for (int radek = 0; radek < pocetRadku; radek++)
            {
                for (int sloupec = 0; sloupec < pocetSloupcu; sloupec++)
                {
                    misto.SetX(pocatekStrany.Width + mistoSirka * sloupec);
                    misto.SetY(vyska - pocatekStrany.Height - mistoVyska - mistoVyska * radek);

                    // Vykreslení místa
                    canvas.Rectangle(misto).Stroke();

                    // Vykleslení textu do místa
                    Canvas grafikaMista = new Canvas(canvas, misto);
                    Zak zak = vyplnenaTrida.RozsazeniZaci[radek, sloupec];
                    grafikaMista.Add(
                        new Paragraph(
                            zak.Misto.ToString())
                        .SetTextAlignment(TextAlignment.CENTER).SetFont(font));
                    grafikaMista.Add(
                        new Paragraph(zak.CeleJmeno == "MÍSTO PRÁZDNÉ" ? "PRÁZDNÉ MÍSTO" : zak.CeleJmeno)
                        .SetTextAlignment(TextAlignment.CENTER).SetFont(font));
                    grafikaMista.Add(
                        new Paragraph($"{mainHelp.CisloKategorieNaRimske(zak.Kategorie)} {zak.Skola}")
                        .SetTextAlignment(TextAlignment.CENTER).SetFont(font));
                }
            }

            doc.Close();

            MessageBox.Show("Panel byl uložen jako PDF.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
