using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using SediM.Helpers;

namespace SediM
{
    public partial class FormularRozsazeni : Form
    {
        private MainHelp mainHelp = new MainHelp();

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

        // Proměnná, jejíž hodnota se přiřadí každému dalšímu zákovi při řazení do třídy.
        // Po nastavení její hodnoty žákovi se inkrementuje aby se předešlo dvěma místům se stejnou hodnotou
        private int mistoZaka = 1;

        public FormularRozsazeni(List<Trida> tridy, List<Zak> zaci)
        {
            InitializeComponent();

            this.tridy = tridy;
            this.zaci = zaci;

            // Automaticky zvolí jediný doposud vyřešený algoritmus - Knight (Jezdec)
            combobxAlgoritmus.SelectedIndex = 0;
        }

        private void cboxTridy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxTridy.SelectedIndex == -1) return;
            listbxVyplneneTridy.SelectedIndex = -1;
            panelVykresleniRozsazeni.Invalidate();
        }

        private void listbxVyplneneTridy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbxVyplneneTridy.SelectedIndex == -1) return;
            cboxTridy.SelectedIndex = -1;
            panelVykresleniRozsazeni.Invalidate();
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

                        // Vykreslí řetězec na střed buňky (místa)
                        g.DrawString(
                            tridyZaku[indexVyplneneTridy][r, s].Misto.ToString(),
                            new Font("Arial", 10),
                            Brushes.Black,
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

            // Získáme aktuální vybranou třídu
            Trida aktualniTrida = ZiskejAktualniTridu();

            // MessageBox.Show($"Aktuální třída: {aktualniTrida.Nazev}\nŠířka: {aktualniTrida.Sirka} míst\nVýška: {aktualniTrida.Vyska} míst");

            NastavParametryProVyplneni(cboxTridy.SelectedIndex, aktualniTrida);
        }

        private void NastavParametryProVyplneni(int selectedIndex, Trida aktualniTrida)
        {
            // Vytvoří 2D pole objektů Zak - naši třídu
            tridyZaku.Add(new Zak[aktualniTrida.Vyska, aktualniTrida.Sirka]);

            pocetKategoriiNaTridu.Add((int)numupdownKategoriiNaTridu.Value);

            // Rozšíří list barev je-li třeba přidat další barvy
            if ((int)numupdownKategoriiNaTridu.Value > barvyKategorii.Count)
                AktualizujListBarev();

            // Překopíruje globální list žáků a přeskupí kategorie
            // podle nejvyššího počtu žáků v kategorii
            List<Zak> kopieZaku = NastavListZaku();

            // Vyplní právě přidanou třídu žáky
            VyplnTridu(tridyZaku.Count - 1, aktualniTrida.Sirka, aktualniTrida.Vyska, kopieZaku);

            // Přesune zvolenou třídu mezi vyplněné třídy
            listbxVyplneneTridy.Items.Add(cboxTridy.Items[selectedIndex]);
            vyplneneTridy.Add(aktualniTrida);

            // odstranění vyplněné třídy z comboboxu
            tridy.Remove(aktualniTrida);
            cboxTridy.DataSource = null; // při DataSource nejde vymazat cbox, proto nastaveno teď na null
            cboxTridy.Items.Clear();
            cboxTridy.DataSource = tridy;

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
        private void VyplnTridu(int indexTridy, int sirka, int vyska, List<Zak> kopieZaku)
        {
            // Opakuje pro každý řádek míst ve třídě
            for (int r = 0; r < vyska; r++)
            {
                // Opakuje pro každé místo v řádku ve třídě
                for (int s = 0; s < sirka; s++)
                {
                    // Přidá žáka podle kategorie pomocí funkce ziskejZaka - tento řádek
                    // je implementovám aby řadil žáky pouze podle aloritmu Knight!
                    tridyZaku[indexTridy][r, s] = ZiskejZaka(((r * 2 + s) % (int)numupdownKategoriiNaTridu.Value) + 1, kopieZaku);
                }
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

        private void ExportToPdf(string filePath)
        {
            // Vytvoření nového dokumentu PDF
            PdfDocument document = new PdfDocument();

            // Vytvoření stránky v dokumentu
            PdfPage page = document.AddPage();
            XGraphics g = XGraphics.FromPdfPage(page);

            XTextFormatter tf = new XTextFormatter(g);
            tf.Alignment = XParagraphAlignment.Center;

            // Slouží pouze jako test. Později bude optimalizováno - TODO

            int width = 720, height = 480;
            // Vytvořen "počáteční" bod pro vykreslování míst
            Point pocatekPlochyMist = new Point(
                (int)(width * 0.05),
                (int)(height * 0.05));

            // Extrahuje dimenze třídy z právě označeného listboxu ve formátu [0] - šířka, [1] - výška
            int[] dimenze = { tridyZaku[0].GetLength(1), tridyZaku[0].GetLength(0) };

            // Vypočítá velikost jednoho místa na základě velikosti dimenzí - stejný princip jako ve formuláři Main
            int mistoSirka = (int)((width * 0.9) / dimenze[0]);
            int mistoVyska = (int)((height * 0.65) / dimenze[1]);

            page.Size = PdfSharp.PageSize.A4;
            page.Orientation = PdfSharp.PageOrientation.Landscape;

            // Opakuje pro každý řádek míst ve třídě
            for (int r = 0; r < dimenze[1]; r++)
            {
                // Opakuje pro každé místo v řádku ve třídě
                for (int s = 0; s < dimenze[0]; s++)
                {
                    g.DrawRectangle(
                        new XPen(Color.Black),
                        pocatekPlochyMist.X + s * mistoSirka + s,
                        pocatekPlochyMist.Y + r * mistoVyska + r,
                        mistoSirka, mistoVyska);

                    // Zjistí velikost vykreslovaného řetězce
                    XSize velikostCisla = g.MeasureString(
                        $"{tridyZaku[0][r, s].Misto}",
                        new XFont("Arial", 10, XFontStyleEx.Regular));

                    // 
                    XSize velikostJmena = g.MeasureString(
                        tridyZaku[0][r, s].Jmeno,
                        new XFont("Arial", 10, XFontStyleEx.Regular));

                    // Vykreslí řetězec na střed buňky (místa)
                    tf.DrawString(
                        $"{tridyZaku[0][r, s].Misto}\n{tridyZaku[0][r, s].Jmeno}",
                        new XFont("Arial", 10, XFontStyleEx.Regular),
                        XBrushes.Black,
                        new XRect(pocatekPlochyMist.X + s * mistoSirka + s + mistoSirka / 2 - velikostJmena.Width / 2,
                        pocatekPlochyMist.Y + r * mistoVyska + r + mistoVyska / 2 - velikostJmena.Height / 2, mistoSirka, mistoVyska));
                }
            }

            // Uložení dokumentu do souboru
            document.Save(filePath);

            // Zavření dokumentu
            document.Close();
        }

        private void FormularRozsazeni_Load(object sender, EventArgs e)
        {
            List<Trida> volneTridy = new List<Trida>();

            for (int i = 0; i < tridy.Count; i++)
            {
                Trida trida = tridy[i];

                if (trida.Rozsazena == false)
                {
                    volneTridy.Add(trida);
                }
            }

            cboxTridy.DataSource = volneTridy;
            cboxTridy.ValueMember = "Id";
            cboxTridy.DisplayMember = "Nazev";
        }

        private Trida ZiskejAktualniTridu()
        {
            if (cboxTridy.SelectedIndex != -1)
            {
                return tridy[cboxTridy.SelectedIndex];
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

        private void UpdateData(Trida trida)
        {

        }
    }
}
