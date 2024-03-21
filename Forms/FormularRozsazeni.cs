using System.Drawing.Imaging;
using SediM.Helpers;
using System.Data;
using System.Data.SqlClient;
using iText.IO.Image;
using iText.Kernel.Events;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

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

        // List polí barev. Počet barev v poli na daném indexu odpovídá počtu kategorií vyplněné třídy
        private List<SolidBrush> barvyKategorii = new List<SolidBrush>();

        // Uchovává počet kategorií pro každou vyplňovanou třídu.
        private List<int> pocetKategoriiNaTridu = new List<int>();

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
            // Zvolí ruleset SPC&SPC protože je jediný, který je ve funkčním stavu
            cboxRuleset.SelectedIndex = 0;
            cboxRuleset.Enabled = false;
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
            Trida aktualniTrida = ZiskejAktualniTridu();

            // Vyvoláme metodu pro vykreslení míst
            VykresleniMist(g, aktualniTrida);
        }

        private void VykresleniMist(Graphics g, Trida aktualniTrida)
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

            // Opakuje pro každý řádek míst ve třídě
            for (int r = 0; r < aktualniTrida.Vyska; r++)
            {
                // Opakuje pro každé místo v řádku ve třídě
                for (int s = 0; s < aktualniTrida.Sirka; s++)
                {
                    // Pravda pokud máme zvolenou třídu a ID žáka na daném místě není -1 (není prázdné místo)
                    bool vyplnitBarevne = indexVyplneneTridy != -1
                        ? tridyZaku[indexVyplneneTridy][r, s].Id != -1
                        : false;

                    g.FillRectangle(
                        ZiskejBarvuDleKategorie(
                            vyplnitBarevne
                                ? (r * 2 + s) % pocetKategoriiNaTridu[indexVyplneneTridy]
                                : -1),
                        pocatekPlochyMist.X + s * mistoSirka + s,
                        pocatekPlochyMist.Y + r * mistoVyska + r,
                        mistoSirka, mistoVyska);

                    if (indexVyplneneTridy != -1)
                    {
                        // Zjistí velikost vykreslovaného řetězce
                        SizeF velikostCisla = g.MeasureString(
                            tridyZaku[indexVyplneneTridy][r, s].Misto.ToString(),
                            new Font("Arial", 10));

                        // kontrast textu s barvou pozadí buňky
                        float barva = ZiskejBarvuDleKategorie(vyplnitBarevne ? (r * 2 + s) % pocetKategoriiNaTridu[indexVyplneneTridy] : -1).Color.GetBrightness();

                        // Vykreslí řetězec na střed buňky (místa)
                        g.DrawString(
                            $"{tridyZaku[indexVyplneneTridy][r, s].Misto}\r\n{mainHelp.CisloKategorieNaRimske(tridyZaku[indexVyplneneTridy][r, s].Kategorie)}",
                            new Font("Arial", 10),
                            barva > 0.65 ? Brushes.Black : Brushes.White,
                            pocatekPlochyMist.X + s * mistoSirka + s + mistoSirka / 2 - velikostCisla.Width / 2,
                            pocatekPlochyMist.Y + r * mistoVyska + r + mistoVyska / 2 - velikostCisla.Height / 2);

                        // Přidá žáka včetně jeho místa do listboxu seznamu studentů ve třídě
                        string prazdnyNeboJmeno =
                            tridyZaku[indexVyplneneTridy][r, s].CeleJmeno == "MÍSTO PRÁZDNÉ"
                            ? "PRÁZDNÉ MÍSTO"
                            : tridyZaku[indexVyplneneTridy][r, s].CeleJmeno;

                        listbxSeznamStudentu.Items.Add(
                            $"{tridyZaku[indexVyplneneTridy][r, s].Misto} - " +
                            $"{prazdnyNeboJmeno}");
                    }
                }
            }
        }
        /// <summary>
        /// Vygeneruje dodatečné barvy, obsahuje-li list barvyKategorii nižší počet barev, 
        /// než je zadáno počtem kategorií na třídu v numericUpDown.
        /// Barvy se generují v rozpětí 0 až 64 v intervalu uzavřeném o obou stran z 
        /// důvodu zvýšení kontrastu při vykreslování jednotlivých míst. - TODO: Dopsat popisky
        /// </summary>
        private void AktualizujListBarev()
        {
            Random rng = new Random();

            while (barvyKategorii.Count < numupdownKategoriiNaTridu.Value)
            {
                // Rozsah randomu je omezen na <0,65) [prakticky však <0,64>] (namísto <0,256)),
                // kvůli zvýšení kontrastu mezi barvami
                int r = rng.Next(0, 64 + 1) * 4;
                int g = rng.Next(0, 64 + 1) * 4;
                int b = rng.Next(0, 64 + 1) * 4;

                SolidBrush sb = new SolidBrush(
                    Color.FromArgb(
                        r == 256 ? r - 1 : r,
                        g == 256 ? g - 1 : g,
                        b == 256 ? b - 1 : b));

                // Přeskočí přidání duplicitní barvy
                if (barvyKategorii.Exists(barva => barva.Color == sb.Color)) continue;
                barvyKategorii.Add(sb);
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
                case -1:
                    return new SolidBrush(Color.FromArgb(100, 100, 100));
                default:
                    return barvyKategorii[kategorie];
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
            Trida aktualniTrida = ZiskejAktualniTridu();

            // Vytvoří 2D pole objektů Zak - naši třídu
            tridyZaku.Add(new Zak[aktualniTrida.Vyska, aktualniTrida.Sirka]);

            // Rozšíří list barev je-li třeba přidat další barvy
            if ((int)numupdownKategoriiNaTridu.Value > barvyKategorii.Count)
                AktualizujListBarev();

            // Rozsazení podle pravidel SPC&SPC (Single pupil's category and school per classroom) - kdyžtak přejmenuju
            if (cboxRuleset.SelectedIndex == 0)
            {
                pocetKategoriiNaTridu.Add((int)numupdownKategoriiNaTridu.Value);

                // Překopíruje globální list žáků a přeskupí kategorie
                // podle nejvyššího počtu žáků v kategorii
                List<Zak> kopieZaku = NastavListZaku();

                // Vyplní právě přidanou třídu žáky
                VyplnTridu(tridyZaku.Count - 1, aktualniTrida.Sirka, aktualniTrida.Vyska, kopieZaku, aktualniTrida);
            }
            // Rozsazení podle HvAR
            else if (cboxRuleset.SelectedIndex == 1)
            {
                // TODO - Rozsazení podle HvAR
            }

            aktualniTrida.Rozsazena = true;

            // Přesune zvolenou třídu mezi vyplněné třídy
            listbxVyplneneTridy.Items.Add(cboxTridy.Items[selectedIndex]);
            vyplneneTridy.Add(aktualniTrida);

            // odstranění vyplněné třídy z comboboxu
            tridy.Remove(aktualniTrida);
            cboxTridy.DataSource = null; // při DataSource nejde vymazat cbox, proto nastaveno teď na null
            cboxTridy.Items.Clear();
            cboxTridy.DataSource = tridy.FindAll(trida => trida.Rozsazena == false);

            // "Překlikne" na nově vyplněnou třídu
            cboxTridy.SelectedIndex = -1;
            listbxVyplneneTridy.SelectedIndex = listbxVyplneneTridy.Items.Count - 1;
        }

        /// <summary>
        /// Procykluje každé místo ve třídě a přiradí do dvourozměrného pole představující třídu žáka, 
        /// který je vrácen funkcí ZiskejZaka, algoritmem Knight.
        /// </summary>
        /// <param name="indexTridy">Index určující právě vyplňovanou třídu</param>
        /// <param name="sirka">Šířka třídy v místech</param>
        /// <param name="vyska">Výška třídy v místech</param>
        /// <param name="kopieZaku">List, který je kopií globálního listu zaci, vyžadován funkcí ZiskejZaka.</param>
        /// <param name="aktualniTrida">Aktuální vyplňovaná třída</param>
        private void VyplnTridu(int indexTridy, int sirka, int vyska, List<Zak> kopieZaku, Trida aktualniTrida)
        {
            string data = "";

            // Opakuje pro každý řádek míst ve třídě
            for (int r = 0; r < vyska; r++)
            {
                // Opakuje pro každé místo v řádku ve třídě
                for (int s = 0; s < sirka; s++)
                {
                    // Přidá žáka podle kategorie pomocí funkce ziskejZaka - tento řádek
                    // je implementovám aby řadil žáky pouze podle aloritmu Knight!
                    Zak zak = ZiskejZaka(((r * 2 + s) % (int)numupdownKategoriiNaTridu.Value) + 1, kopieZaku);

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
        private Zak ZiskejZaka(int kategorie, List<Zak> kopieZaku)
        {
            // Vytvoříme žáka returnZak s jménem "PRÁZDNÉ MÍSTO" pro případ, že by
            // for cyklus došel do konce bez přenastavení této proměnné
            Zak returnZak = new Zak(-1, "PRÁZDNÉ", "MÍSTO", -1, -1, 0);

            if (kopieZaku.Find(zak => zak.Kategorie == kategorie) != null)
            {
                returnZak = kopieZaku.Find(zak => zak.Kategorie == kategorie);
                zaci[zaci.FindIndex(zak => zak.Id == returnZak.Id)].JeRozsazen = true;
                kopieZaku.RemoveAll(zak => zak.Kategorie == kategorie && zak.Skola == returnZak.Skola);
            }

            returnZak.Misto = mistoZaka;
            mistoZaka++;
            return returnZak;
        }

        // Osobně se mi moc toto řešení nelíbí jelikož modifikace kategorie dle mého
        // není ideální metodou a pravděpodobně zavedu dodatečnou proměnnou
        // ve třídě Zak i přesto, že to není příliš paměťově úsporné. - TODO
        private List<Zak> NastavListZaku()
        {
            List<Zak> serazeniZaci = new List<Zak>();

            List<List<Zak>> zaciDleKategorie = new List<List<Zak>>();

            // Separuje veškeré žáky do kategorií pro následovné řazení
            foreach (Zak zak in zaci)
            {
                // Pokud se kategorie žáka nachází v proměnné, přeskoč na dalšího žáka
                if (zaciDleKategorie.Exists(kategorie => zak.Kategorie == kategorie[0].Kategorie))
                    continue;

                // Dočasně uloží veškeré nerozsazené žáky nevložené kategorie do proměnné
                List<Zak> novaKategorie = new List<Zak>();
                novaKategorie = zaci.FindAll(hledanyZak => hledanyZak.Kategorie == zak.Kategorie && !hledanyZak.JeRozsazen);

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
                    zak.Kategorie = i + 1;

                // Vloží žáky s modifikovanou kategorií (prioritou) do listu
                serazeniZaci.AddRange(zaciDleKategorie[i]);
            }

            return serazeniZaci;
        }

        private void FormularRozsazeni_Load(object sender, EventArgs e)
        {
            cboxTridy.ValueMember = "Id";
            cboxTridy.DisplayMember = "Nazev";
            cboxTridy.DataSource = tridy.FindAll(trida => trida.Rozsazena == false);

            if(PocetVolnychTrid(tridy.Count) == 0)
            {
                DialogResult nejsouTridy = mainHelp.Alert("Upozornění", "Program nenalezl žádnou třídu, kterou by bylo možné rozsadit.\r\nChcete automaticky vytvořit novou třídu o výchzozí velikosti?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if(nejsouTridy == DialogResult.No)
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
                    cboxTridy.DataSource = tridy.FindAll(trida => trida.Rozsazena == false);
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

        private Trida ZiskejAktualniTridu()
        {
            if (cboxTridy.SelectedIndex != -1)
            {
                return tridy.Find(tridy => tridy.Id == (long)cboxTridy.SelectedValue);
            }
            else if (listbxVyplneneTridy.SelectedIndex != -1)
            {
                return vyplneneTridy[listbxVyplneneTridy.SelectedIndex];
            }
            else
            {
                return null;
            }
        }

        private void toolStripButton_Tisk_Click(object sender, EventArgs e)
        {
            int width = panelVykresleniRozsazeni.Width;
            int height = panelVykresleniRozsazeni.Height;

            Bitmap bmp = new Bitmap(width, height);
            panelVykresleniRozsazeni.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files|*.pdf";
            saveFileDialog.Title = "Exportovat jako PDF";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                using (var memoryStream = new MemoryStream())
                {
                    bmp.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png); // Uložíme jako PNG pro kvalitu

                    using (var pdfWriter = new PdfWriter(saveFileDialog.FileName))
                    {
                        using (var pdfDocument = new PdfDocument(pdfWriter))
                        {
                            var pageSize = new iText.Kernel.Geom.PageSize(height, width); // Orientace na šířku
                            pdfDocument.SetDefaultPageSize(pageSize);

                            var document = new Document(pdfDocument);

                            PageRotationEventHandler eventHandler = new PageRotationEventHandler();
                            pdfDocument.AddEventHandler(PdfDocumentEvent.START_PAGE, eventHandler);

                            var image = new iText.Layout.Element.Image(ImageDataFactory.Create(memoryStream.ToArray()));
                            image.SetAutoScale(true);
                            eventHandler.SetRotation(PORTRAIT);
                            document.Add(image);
                            document.Close();
                        }
                    }

                    MessageBox.Show("Panel byl uložen jako PDF.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            bmp.Dispose();
        }

        // Metoda pro kontrolu počtu volných tříd
        private int PocetVolnychTrid(int celek)
        {
            int celkovyPocetTrid = celek; // Předávaný počet tříd
            int pocetRozsazenychTrid = 0;

            foreach (Trida trida in tridy)
            {
                if (trida.Rozsazena)
                {
                    pocetRozsazenychTrid++;
                }
            }

            int pocetVolnychTrid = celkovyPocetTrid - pocetRozsazenychTrid;
            return pocetVolnychTrid;
        }

        private class PageRotationEventHandler : IEventHandler
        {
            private PdfNumber rotation = PORTRAIT;

            public void SetRotation(PdfNumber orientation)
            {
                this.rotation = orientation;
            }

            public void HandleEvent(Event currentEvent)
            {
                PdfDocumentEvent docEvent = (PdfDocumentEvent)currentEvent;
                docEvent.GetPage().Put(PdfName.Rotate, rotation);
            }
        }
    }
}
