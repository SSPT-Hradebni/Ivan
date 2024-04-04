using iText.IO.Image;
using iText.Kernel.Events;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Layout;
using SediM.Helpers;
using System.Data;
using System.Data.SqlClient;
using Point = System.Drawing.Point;

namespace SediM
{
    public partial class FormularRozsazeni : Form
    {
        public static readonly PdfNumber PORTRAIT = new PdfNumber(0);
        public static readonly PdfNumber LANDSCAPE = new PdfNumber(90);
        public static readonly PdfNumber INVERTEDPORTRAIT = new PdfNumber(180);
        public static readonly PdfNumber SEASCAPE = new PdfNumber(270);

        private SqlConnection connection = new SqlConnection($"Data Source={Properties.Settings.Default.MySQL_server};Initial Catalog={Properties.Settings.Default.MySQL_databaze};User ID={Properties.Settings.Default.MySQL_uzivatel};Password={Properties.Settings.Default.MySQL_heslo}");
        private DataTable? data;

        public MainHelp mainHelp = new MainHelp();
        public bool jePripojen = false;

        // TODO/FIXME: Když uživatel zavře a znovu otevře tento form bez ukončení aplikace (formulář Main)
        // tak zůstanou nastaveny globální proměnné. To je nežádoucí.

        // List vyplněných tříd žáky. Každý index dané položky v listu odpovídá indexu vyplněné třídy v listboxu vyplněných tříd
        private List<Zak[,]> tridyZaku = new List<Zak[,]>();
        private List<Trida> tridy = new List<Trida>();
        private List<Trida> vyplneneTridy = new List<Trida>();
        private List<Zak> zaci = new List<Zak>();

        // Proměnná, jejíž hodnota se přiřadí každému dalšímu žákovi při řazení do třídy.
        // Po nastavení její hodnoty žákovi se inkrementuje aby se předešlo dvěma místům se stejnou hodnotou
        private int mistoZaka = 1;

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

            // Automaticky zvolí jediný doposud vyřešený algoritmus - Knight (Jezdec)
            combobxAlgoritmus.SelectedIndex = 0;
            combobxAlgoritmus.Enabled = false;

            // Zvolí ruleset RAR a zablokuje možnost změny
            cboxRuleset.SelectedIndex = 0;
            cboxRuleset.Enabled = false;
            numupdownKategoriiNaTridu.Enabled = false;
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
            Trida? aktualniTrida = listbxVyplneneTridy.SelectedIndex != -1 ? vyplneneTridy[listbxVyplneneTridy.SelectedIndex] : tridy.Find(hledanaTrida => hledanaTrida.Id == (long)cboxTridy.SelectedValue);

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

            int indexVyplneneTridy = listbxVyplneneTridy.SelectedIndex;

            // Hodnoty, které se opakovaně přenastaví ve for cyklech jsou-li třeba
            Zak zak = null;
            bool vyplnitBarevne = false;

            // Opakuje pro každý řádek míst ve třídě
            for (int r = 0; r < aktualniTrida.Vyska; r++)
            {
                // Opakuje pro každé místo v řádku ve třídě
                for (int s = 0; s < aktualniTrida.Sirka; s++)
                {
                    if (indexVyplneneTridy != -1)
                    {
                        // Aktuální objekt žáka, ze kterého získáváme potřebná data
                        zak = tridyZaku[indexVyplneneTridy][r, s];
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

                    if (indexVyplneneTridy != -1)
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
            else if (cboxRuleset.SelectedIndex == -1) return;

            NastavParametryProVyplneni(cboxTridy.SelectedIndex);
        }

        private void NastavParametryProVyplneni(int selectedIndex)
        {
            // Získáme aktuální vybranou třídu
            Trida? aktualniTrida = tridy.Find(tridy => tridy.Id == (long)cboxTridy.SelectedValue);

            // Vytvoří 2D pole objektů Zak - naši třídu
            tridyZaku.Add(new Zak[aktualniTrida.Vyska, aktualniTrida.Sirka]);

            // Vyplní právě přidanou třídu žáky
            VyplnTridu(tridyZaku.Count - 1, aktualniTrida.Sirka, aktualniTrida.Vyska, aktualniTrida);

            aktualniTrida.JeRozsazena = true;

            // Přesune zvolenou třídu mezi vyplněné třídy
            listbxVyplneneTridy.Items.Add(cboxTridy.Items[selectedIndex]);
            vyplneneTridy.Add(aktualniTrida);

            // odstranění vyplněné třídy z comboboxu
            tridy.Remove(aktualniTrida);
            cboxTridy.DataSource = null; // při DataSource nejde vymazat cbox, proto nastaveno teď na null
            cboxTridy.Items.Clear();
            cboxTridy.DataSource = tridy.FindAll(trida => trida.JeRozsazena == false);

            // "Překlikne" na nově vyplněnou třídu
            cboxTridy.SelectedIndex = -1;
            listbxVyplneneTridy.SelectedIndex = listbxVyplneneTridy.Items.Count - 1;
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
        private void VyplnTridu(int indexTridy, int sirka, int vyska, Trida aktualniTrida)
        {
            List<Zak> kopieZaku = new List<Zak>();

            // Překopíruje globální list žáků a přeskupí kategorie
            // podle nejvyššího počtu žáků v kategorii
            kopieZaku = NastavListZaku();

            if (cboxRuleset.SelectedIndex == 0)
                VyplnTriduKombinacemiRAR(aktualniTrida, kopieZaku);

            string data = "";

            // Opakuje pro každý řádek míst ve třídě
            for (int r = 0; r < vyska; r++)
            {
                // Opakuje pro každé místo v řádku ve třídě
                for (int s = 0; s < sirka; s++)
                {
                    // Přidá žáka podle kategorie pomocí funkce ziskejZaka příslušného rulesetu
                    Zak zak = new Zak(-1, "PRÁZDNÉ", "MÍSTO", -1, -1, 0);

                    if (cboxRuleset.SelectedIndex == 0)
                        zak = ZiskejZakaRAR(aktualniTrida, r, s, kopieZaku);
                    else if (cboxRuleset.SelectedIndex == 1)
                        // U numupdown je + 1 kvůli tomu, že kategorie číslujeme od 1
                        zak = ZiskejZakaSPC2(((r * 2 + s) % (int)numupdownKategoriiNaTridu.Value) + 1, kopieZaku);

                    zak.Misto = mistoZaka;
                    mistoZaka++;

                    data += $"{zak.Misto}={zak.Id}";

                    // Pokud nejsme na posledním místě, přidejte oddělovač
                    if (!(r == vyska - 1 && s == sirka - 1))
                    {
                        data += ",";
                    }

                    tridyZaku[indexTridy][r, s] = zak;
                }
            }

            try
            {
                SqlCommand vyplnTridu = new SqlCommand($"UPDATE Tridy SET JeRozsazena = @stav, DataRozsazeni = @data WHERE TridaId = @id", connection);

                vyplnTridu.Parameters.AddWithValue("@stav", 1);
                vyplnTridu.Parameters.AddWithValue("@data", data);
                vyplnTridu.Parameters.AddWithValue("@id", aktualniTrida.Id);

                int stav = vyplnTridu.ExecuteNonQuery();
                // int stav = 0;
            }
            catch (SqlException ex)
            {
                mainHelp.Alert("Chyba!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Získá žáka ze zadaného listu, jehož kategorie je rovna parametru této funkce.
        /// V případě nálezu žáka splňující požadavek kategorie, odstraní se tato kategorie ze školy, ve které se nachází.
        /// Vrácený žák s vlastností misto, má hodnotu proměnné mistoZaka, které začíná na 
        /// čísle 1 a po každém dalším průchodu této funkce se inkrementuje o číslo 1.
        /// </summary>
        /// <param name="kategorie">Kategorie, který musí hledaný žák mít.</param>
        /// <param name="kopieZaku">List, ze kterého se hledá kandidát splňující požadavek kategorie.</param>
        /// <returns>Žák, který splňuje požadavek kategorie, jinak instanci Zak se jménem "PRÁZDNÉ MÍSTO".</returns>
        private Zak ZiskejZakaSPC2(int kategorie, List<Zak> kopieZaku)
        {
            // Vytvoříme žáka returnZak s jménem "PRÁZDNÉ MÍSTO" pro případ, že by
            // for cyklus došel do konce bez přenastavení této proměnné
            Zak returnZak;

            if ((returnZak = kopieZaku.Find(zak => zak.DynKategorie == kategorie)) != null)
            {
                zaci[zaci.FindIndex(zak => zak.Id == returnZak.Id)].JeRozsazen = true;
                kopieZaku.RemoveAll(zak => zak.DynKategorie == kategorie && zak.Skola == returnZak.Skola);
                return returnZak;
            }

            return new Zak(-1, "PRÁZDNÉ", "MÍSTO", -1, -1, 0);
        }

        private Zak ZiskejZakaRAR(Trida trida, int radek, int sloupec, List<Zak> kopieZaku)
        {
            Zak returnZak;

            List<int[]> listParametru = trida.PrijatelneKategorieASkolyMista[radek, sloupec];
            // Prohledá dostupné žáky zda-li nemají vhodnou kategorii a třídu
            foreach (int[] parametry in listParametru)
            {
                if ((returnZak = kopieZaku.Find(hledanyZak => hledanyZak.Skola == parametry[0] && hledanyZak.DynKategorie == parametry[1])) != null)
                {
                    zaci[zaci.FindIndex(zak => zak.Id == returnZak.Id)].JeRozsazen = true;
                    kopieZaku.RemoveAt(kopieZaku.FindIndex(zak => zak.Id == returnZak.Id));
                    UpravMistaTridyRAR(trida, parametry, radek, sloupec);
                    return returnZak;
                }
            }


            return new Zak(-1, "PRÁZDNÉ", "MÍSTO", -1, -1, 0);
        }

        private void UpravMistaTridyRAR(Trida trida, int[] parametry, int radek, int sloupec)
        {
            /*
             * Musí se upravit místa na souřadnicích:
             *                                     [radek-2, sloupec]
             *                [radek-1, sloupec-1] [radek-1, sloupec] [radek-1, sloupec+1]
             *  [radek, sloupec-2] [radek, sloupec-1] [MÍSTO ŽÁKA] [radek, sloupec+1] [radek, sloupec+2]
             *                [radek+1, sloupec-1] [radek+1, sloupec] [radek+1, sloupec+1]
             *                                     [radek+2, sloupec]
             *  
             *  Pokud jsou v jedné z buněk proměnné radek nebo sloupec nižší než 0, 
             *  přeskočíme úpravu této buňnky jelikož zasahuje mimo třídu (buňka se nenachází ve třídě)
             *  
             *  V těchto buňkách odstraníme veškeré kombinace, které obsahují třídu či kategorii 
             *  totožnou s třídou či kategorií umístěného žáka
             *  
             *  Ve všech ostatních buňkách odstraníme přesnou kombinaci třídy a kategorie (můžeme začít na místě umístěného žáka
             *  pro drobné urychlení)
             *

             *
             * TODO - upraví místa podle pravidel
             * NOTE: bylo mi řečeno že žák určité kategorie a školy múže být pouze jeden na třídu - upravit dvojice kombinací 
             * pro každé místo ve třídě
             *

             * Když tak přemýšlím tak potřebuji pouze upravovat dolní polovinu míst pomyslné hvězdy a pravou stranu
             * horizontály od umístěného žáka (vynechat místa na 9.-2. hodině po směru hod. ruč.). Drobná vizualizace níže.
             * '*' je místo, kde je třeba upravit kombinace, 'x' je místo, kde je umístěný žák a '-' je místo, které by mělo být možné vyjmout
             * z úpravy. Proč? Protože algoritmus prochází třídu zleva doprava, zhora dolů. Úprava míst, která algoritmus již prošel je
             * tedy nadbytečná.
             *
             *   *        -
             *  ***      ---
             * **x** -> --x**
             *  ***      ***
             *   *        *
             *   
             * Pozor na to, že proměnné řádek a sloupec jsou číslované od nuly! Pokud tedy kontrolujeme zápis mimo třídu musíme kontrolovat, 
             * zda-li výpočet (např. radek-2 nebo sloupec+1) nejsou menší než nula a nebo větší než šířka-1 nebo výška-1. Pokud jsou, zasáhli bychom mimo třídu
             */


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

        private void VyplnTriduKombinacemiRAR(Trida trida, List<Zak> kopieZaku)
        {
            List<int[]> unikatniKategorieSkoly = new List<int[]>();

            foreach (Zak zak in kopieZaku)
            {
                // Vloží novou kombinaci pokud se nenachází již v listu
                if (unikatniKategorieSkoly.Find(parametry => parametry[0] == zak.Skola && parametry[1] == zak.DynKategorie) == null)
                    unikatniKategorieSkoly.Add(new int[] { zak.Skola, zak.DynKategorie });
            }

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

        private List<Zak> NastavListZaku()
        {
            List<Zak> serazeniZaci = new List<Zak>();

            List<List<Zak>> zaciDleKategorie = new List<List<Zak>>();

            // Separuje veškeré žáky do kategorií pro následovné řazení
            foreach (Zak zak in zaci)
            {
                // Pokud se kategorie žáka nachází v proměnné, přeskoč na dalšího žáka
                if (zaciDleKategorie.Exists(kategorie => zak.DynKategorie == kategorie[0].DynKategorie))
                    continue;

                // Dočasně uloží veškeré nerozsazené žáky nevložené kategorie do proměnné
                List<Zak> novaKategorie = new List<Zak>();
                novaKategorie = zaci.FindAll(hledanyZak => hledanyZak.DynKategorie == zak.DynKategorie && !hledanyZak.JeRozsazen);

                // Vytvoří kopii této kategorie
                List<Zak> kopiekategorie = new List<Zak>();
                foreach (Zak zakNoveKategorie in novaKategorie)
                    kopiekategorie.Add(zakNoveKategorie.Clone());

                // Nakonec vloží kopii do proměnné, která uchovává veškeré kategorie
                zaciDleKategorie.Add(kopiekategorie);
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
            for (int i = 0; i < zaciDleKategorie.Count(); i++)
            {
                // Procykluje každého žáka v kategorii
                foreach (Zak zak in zaciDleKategorie[i])
                    zak.DynKategorie = i + 1;

                // Vloží žáky s modifikovanou kategorií (prioritou) do listu
                serazeniZaci.AddRange(zaciDleKategorie[i]);
            }

            return serazeniZaci;
        }

        private void FormularRozsazeni_Load(object sender, EventArgs e)
        {
            cboxTridy.ValueMember = "Id";
            cboxTridy.DisplayMember = "Nazev";
            cboxTridy.DataSource = tridy.FindAll(trida => trida.JeRozsazena == false);

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

                    data = NactiTridy();
                    List<Trida> noveTridy = mainHelp.ListTrid(data);
                    tridy.Clear(); // vymazání starých údajů
                    tridy = noveTridy;

                    cboxTridy.DataSource = null;

                    cboxTridy.ValueMember = "Id";
                    cboxTridy.DisplayMember = "Nazev";
                    cboxTridy.DataSource = tridy.FindAll(trida => trida.JeRozsazena == false);
                }
            }
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

        private void toolStripButton_Tisk_Click(object sender, EventArgs e)
        {
            int sirkaDokumentu = 1080;
            int vyskaDokumentu = 1920;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF files|*.pdf";
            sfd.Title = "Exportovat jako PDF";

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            Zak[,] vyplnenaTrida = tridyZaku[listbxVyplneneTridy.SelectedIndex];

            PdfDocument doc = new PdfDocument(new PdfWriter(sfd.FileName));

            PageSize velikostStrany = new PageSize(sirkaDokumentu, vyskaDokumentu);
            doc.SetDefaultPageSize(velikostStrany);

            PdfCanvas canvas = new PdfCanvas(doc.AddNewPage());

            float sirka = velikostStrany.GetWidth();
            float vyska = velikostStrany.GetHeight();

            Point pocatekStrany = new Point((int)(sirka * 0.05), (int)(vyska * 0.05));

            int pocetRadku = vyplnenaTrida.GetLength(0);
            int pocetSloupcu = vyplnenaTrida.GetLength(1);

            // Vypočítá velikost jednoho místa na základě velikosti dimenzí
            int mistoSirka = (int)((sirka * 0.9 - pocetSloupcu) / pocetSloupcu);
            int mistoVyska = (int)((sirka * 0.9 - pocetRadku) / pocetRadku);

            canvas.SetFillColor(iText.Kernel.Colors.ColorConstants.WHITE);

            for (int radek = 0; radek < pocetRadku; radek++)
            {
                for (int sloupec = 0; sloupec < pocetSloupcu; sloupec++)
                {
                    /*canvas.Rectangle(
                        sloupec*mistoSirka+sloupec,
                        );*/
                }
            }

            canvas.Fill();

            doc.Close();
        }
    }
}
