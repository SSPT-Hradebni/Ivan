using SediM.Forms;
using System.Data;
using System.Globalization;
using System.Speech.Synthesis;
using System.Text;

namespace SediM.Helpers
{
    public class MainHelp
    {
        /// <summary>
        /// Zobrazí upozornění výchozího formátu
        /// </summary>
        /// <param name="titulek">Titulek okna upozornění</param>
        /// <param name="obsah">Obsah (text) okna upozornění</param>
        /// <param name="messageBoxButtons">Tlačítka daného upozornění</param>
        /// <param name="messageBoxIcon">Ikona daného upozornění</param>
        public DialogResult Alert(string titulek, string obsah, MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK, MessageBoxIcon messageBoxIcon = MessageBoxIcon.None)
        {
            return MessageBox.Show(obsah, titulek, messageBoxButtons, messageBoxIcon);
        }

        /// <summary>
        /// Exportování dat do CSV
        /// </summary>
        /// <param name="dtDataTable">Tabulka s daty k exportu</param>
        /// <param name="nazev">Název souboru</param>
        public void ToCSV(DataTable dtDataTable, string nazev)
        {
            StreamWriter sw = new StreamWriter(nazev, false, Encoding.UTF8);

            //headers
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                sw.Write(dtDataTable.Columns[i]);

                if (i < dtDataTable.Columns.Count - 1)
                {
                    sw.Write(";");
                }
            }

            sw.Write(sw.NewLine);

            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();

                        if (value.Contains(';'))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(";");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }

        /// <summary>
        /// Import dat z CSV souboru do DataTable
        /// </summary>
        /// <param name="csvFilePath">Cesta k CSV souboru</param>
        /// <returns>DataTable obsahující načtená data</returns>
        public DataTable FromCSV(string csvFilePath)
        {
            DataTable tabulka = new DataTable();

            try
            {
                StreamReader sr = new StreamReader(csvFilePath);
                // přečte a zahodí první řádek kde jsou vypsány názvy sloupců
                sr.ReadLine();

                tabulka.Columns.Add("ID");
                tabulka.Columns.Add("Jméno a příjmení");
                tabulka.Columns.Add("Kategorie");
                tabulka.Columns.Add("Škola");

                // čte řádky dokud nedojde ke konci souboru
                while (sr.Peek() != -1)
                {
                    string[] radek = sr.ReadLine().Split(';');

                    // [1] - ID (přiřadí se pak v databázi - proto je teď 0)
                    // [2] - jméno a příjmení
                    // [3] - číslo kategorie
                    // [4] - ID školy

                    tabulka.Rows.Add(0, radek[1], radek[2], radek[3]);
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error is " + ex.ToString());
                throw;
            }

            return tabulka;
        }

        /// <summary>
        /// Zobrazí soubor nápovědy na určitém tématu
        /// </summary>
        /// <param name="trigger">Z jakého okna je nápověda zavolána (obvykle <strong>this</strong>)</param>
        /// <param name="topicPage">Stránka v nápovědě, která má být zobrazena</param>
        public void ShowHelp(Form form, string topicPage)
        {
            Help.ShowHelp(form, "SediM.chm", HelpNavigator.Topic, topicPage);
        }

        /// <summary>
        /// Zobrazení souboru nápovědy na indexu
        /// </summary>
        /// <param name="trigger">Z jakého okna je nápověda zavolána (obvykle <strong>this</strong>)</param>
        public void ShowHelp(Form form)
        {
            Help.ShowHelp(form, "SediM.chm", HelpNavigator.Index);
        }

        public DialogResult StudentForm_New(Form form, List<Skola> skoly, List<Zak> zaci)
        {
            Zak_Novy okno = new Zak_Novy(skoly, zaci);
            okno.Owner = form;

            DialogResult stav = okno.ShowDialog();

            return stav;
        }

        public DialogResult SkolaForm_New(Form form, List<Ucitel> ucitele)
        {
            Skola_Nova okno = new Skola_Nova(ucitele);
            okno.Owner = form;

            DialogResult stav = okno.ShowDialog();

            return stav;
        }

        /// <summary>
        /// Funkce pro mluvení zadaného textu.
        /// </summary>
        /// <param name="text">Text, který má být promluven.</param>
        /// <param name="muzeMluvit">Určuje, zda má být text promluven (true) nebo ne (false).</param>
        public void RekniTo(string text, bool muzeMluvit)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();

            // Nastavení hlasu na český hlas
            // synthesizer.SelectVoice("Microsoft Jakub");
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.NotSet, 0, CultureInfo.GetCultureInfo("en-US"));

            if (muzeMluvit)
            {
                synthesizer.SpeakAsync(text);
            }
        }

        /// <summary>
        /// Titulek pro okna aplikace
        /// </summary>
        /// <param name="text">Text v titulku</param>
        /// <returns>Titulek s konkrétním textem včetně názvu aplikace</returns>
        public string VytvorTitulek(string? text)
        {
            return text != null ? $"{text} | {Properties.Settings.Default.AppName}" : Properties.Settings.Default.AppName;
        }

        /// <summary>
        /// Skloňování slova z 1. pádu do 5. pádu
        /// </summary>
        /// <param name="slovo">Slovo ke skloňování</param>
        /// <returns>Slovo v pátém pádu</returns>
        public string Sklonuj(string slovo)
        {
            if (string.IsNullOrEmpty(slovo) || slovo.Length < 1)
                return string.Empty;
            slovo = slovo.Trim();
            int i = slovo.Length - 1; // Index posledniho pismene
            slovo = slovo[0].ToString().ToUpper() + slovo.Substring(1, i);

            string vysledneSlovo = slovo;

            if (!((slovo[i - 1] == 'u' && slovo[i] == 'm') ||
                (slovo[i - 1] == 'o' && slovo[i] == 'n')))
            {
                if (slovo[i - 1] == 'i' && slovo[i] == 'a') // Maria
                    // Nebo -io, -eio
                    // Záleží na výslovnosti ...
                    vysledneSlovo = slovo.Substring(0, i - 1) + "ie";

                else if (slovo[i - 1] == 'í' && slovo[i] == 'a') // María
                    vysledneSlovo = slovo.Substring(0, i - 1) + "íe";

                else if (slovo[i - 1] == 'e' && slovo[i] == 'c') // Otec
                    vysledneSlovo = slovo.Substring(0, i - 1) + "če";

                else if (slovo[i - 1] == 'e' && slovo[i] == 'k') // Bobek
                    vysledneSlovo = slovo.Substring(0, i - 1) + "ku";

                else if (slovo[i - 1] == 'e' && slovo[i] == 'l') // Bobek
                    vysledneSlovo = slovo.Substring(0, i - 1) + "le";

                else if (slovo[i - 1] == 'c' && slovo[i] == 'h')
                    vysledneSlovo += "u";

                else if (slovo[i] == 'a' ||
                    slovo[i] == 'á')
                    vysledneSlovo = slovo.Substring(0, i) + "o";

                else if (slovo[i] == 'ž' ||
                    slovo[i] == 'l' ||
                    slovo[i] == 'j' ||
                    slovo[i] == 's' ||
                    slovo[i] == 'č' ||
                    slovo[i] == 'c' ||
                    slovo[i] == 'x' ||
                    slovo[i] == 'š' ||
                    slovo[i] == 'z' ||
                    slovo[i] == 'ř')
                    vysledneSlovo += "i";

                else if (slovo[i] == 'n' ||
                    slovo[i] == 't' ||
                    slovo[i] == 'b' ||
                    slovo[i] == 'd' ||
                    slovo[i] == 'ď' ||
                    slovo[i] == 'f' ||
                    slovo[i] == 't' ||
                    slovo[i] == 'n' ||
                    slovo[i] == 'ň' ||
                    slovo[i] == 'p' ||
                    slovo[i] == 'm' ||
                    slovo[i] == 'v' ||
                    slovo[i] == 'w' ||
                    slovo[i] == 'r')
                    vysledneSlovo += "e";

                else if (slovo[i] == 'k' ||
                   slovo[i] == 'g')
                    vysledneSlovo += "u";

                else if (slovo[i] == 'é')
                    vysledneSlovo = slovo.Substring(0, i) + "e";

                else if (slovo[i] == 'ó' ||
                    slovo[i] == 'ň')
                    vysledneSlovo = slovo.Substring(0, i) + "o";

                //if(slovo[i] == 'r')
                //    vysledneSlovo = slovo.Substring(0, i) + "ře";
            }
            return vysledneSlovo;
        }

        /// <summary>
        /// Generátor "náhodných" vět
        /// </summary>
        /// <param name="nahoda">Index náhody</param>
        /// <returns>Náhodná věta ze zadaného indexu <paramref name="nahoda"/></returns>
        public string NahodnyIvan(int nahoda)
        {
            string veta;

            switch (nahoda)
            {
                case int n when (n <= 30):
                    veta = "This is gonna be a long one.";
                    break;
                case int n when (n > 30 && n <= 65):
                    veta = "I hope you're well today.";
                    break;
                default:
                    veta = "There's nothing here";
                    break;
            }

            return veta;
        }

        /// <summary>
        /// Zobrazí box informující o nehotové/nedokončené části aplikace
        /// </summary>
        /// <param name="coNeni">Název části aplikace, které se oznámení týká</param>
        public void JesteNeni(string? coNeni)
        {
            if (coNeni == null)
            {
                MessageBox.Show("Tato část aplikace není hotová.", "Nehotová část", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Část \"{coNeni}\" v aplikaci není hotová.", "Nehotová část", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public string CisloKategorieNaRimske(int cislo)
        {
            string rimsky;

            switch (cislo)
            {
                case 1:
                    rimsky = "I.";
                    break;
                case 2:
                    rimsky = "II.";
                    break;
                case 3:
                    rimsky = "III.";
                    break;
                case 4:
                    rimsky = "IV.";
                    break;
                case 5:
                    rimsky = "V.";
                    break;
                case 6:
                    rimsky = "VI.";
                    break;
                case 7:
                    rimsky = "VII.";
                    break;
                default:
                    rimsky = "Err";
                    break;
            }

            return rimsky;
        }

        /// <summary>
        /// Převedení ID školy na písmeno
        /// </summary>
        /// <param name="cislo">ID školy</param>
        /// <returns>Písmeno (písmena) abecedy označující školu</returns>
        public string SkolaNaPismeno(int cislo)
        {
            // Převedení ID školy na písmeno (bez háčků a čárek)
            string abeceda = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // Písmena abecedy bez háčků a čárek
            int delkaAbecedy = abeceda.Length; // Celková délka abecedy

            // Pokud je číslo mimo rozsah abecedy, spočítat další písmeno
            if (cislo >= delkaAbecedy)
            {
                int zbytek = cislo;
                string pismena = "";

                while (zbytek >= delkaAbecedy)
                {
                    int indexPoslednihoPismena = (zbytek - 1) % delkaAbecedy; // Index posledního písmena v abecedě
                    zbytek = (zbytek - 1) / delkaAbecedy; // Nový zbytek pro další iteraci

                    char posledniPismeno = abeceda[indexPoslednihoPismena]; // Poslední písmeno pro aktuální číslo
                    pismena = posledniPismeno + pismena; // Přidat písmeno na začátek řetězce
                }

                // Zbývající zbytek po výpočtu
                char prvniPismeno = abeceda[zbytek - 1];
                return prvniPismeno + pismena; // Vrátit kombinaci písmen
            }

            // Pokud je číslo v rámci rozsahu abecedy, vrátit příslušné písmeno
            if (cislo >= 0 && cislo < delkaAbecedy)
            {
                char pismeno = abeceda[cislo]; // Písmeno odpovídající indexu čísla
                return pismeno.ToString(); // Vrátit písmeno jako řetězec
            }

            // Pokud je číslo mimo rozsah abecedy, vrátit prázdný řetězec
            return "";
        }
    }
}
