using SediM.Forms;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Text.RegularExpressions;

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

        public DialogResult SkolaForm_New(Form form)
        {
            Skola_Nova okno = new Skola_Nova();
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

        public string ZkratkySkol(string nazev)
        {
            Dictionary<string, string> skoly = new Dictionary<string, string>()
    {
        {"České vysoké učení technické","ČVUT"},
        {"české vysoké učení technické","ČVUT"},
            {"Základní škola", "ZŠ"},
            {"základní škola", "ZŠ"},
            {"Základní umělecká škola", "ZUŠ"},
            {"základní umělecká škola", "ZUŠ"},
            {"Střední škola", "SŠ"},
            {"střední škola", "SŠ"}, // Varianta s malým počátečním písmenem
            {"Střední odborná škola", "SOŠ"},
            {"střední odborná škola", "SOŠ"}, // Varianta s malým počátečním písmenem
            {"Střední průmyslová škola", "SPŠ"},
            {"střední průmyslová škola", "SPŠ"}, // Varianta s malým počátečním písmenem
            {"Střední odborné učiliště", "SOU"},
            {"střední odborné učiliště", "SOU"}, // Varianta s malým počátečním písmenem
            {"Střední škola informatiky, poštovnictví a finančnictví", "SŠIPF"},
            {"střední škola informatiky, poštovnictví a finančnictví", "SŠIPF"}, // Varianta s malým počátečním písmenem
            {"Střední škola technická a ekonomická","SŠTE"},
            {"střední škola technická a ekonomická","SŠTE"}, // Varianta s malým počátečním písmenem
            {"Integrovaná střední škola","ISŠ"},
            {"integrovaná střední škola","ISŠ"}, // Varianta s malým počátečním písmenem
            {"Střední zdravotnická škola","SZŠ"},
            {"střední zdravotnická škola","SZŠ"}, // Varianta s malým počátečním písmenem
            {"Střední škola elektrotechnická","SŠE"},
            {"střední škola elektrotechnická","SŠE"}, // Varianta s malým počátečním písmenem
            {"Střední škola polytechnická","SŠP"},
            {"střední škola polytechnická","SŠP"}, // Varianta s malým počátečním písmenem
            {"Střední škola technická a dopravní","SŠTD"},
            {"střední škola technická a dopravní","SŠTD"}, // Varianta s malým počátečním písmenem
            {"Integrovaná střední škola technická a ekonomická","ISŠTE"},
            {"integrovaná střední škola technická a ekonomická","ISŠTE"}, // Varianta s malým počátečním písmenem
            {"Střední odborné učiliště strojírenské","SOUs"},
            {"střední odborné učiliště strojírenské","SOUs"}, // Varianta s malým počátečním písmenem
            {"Obchodní akademie","OA"},
            {"obchodní akademie","OA"}, // Varianta s malým počátečním písmenem
            {"Jazyková škola","JŠ"},
            {"jazyková škola","JŠ"}, // Varianta s malým počátečním písmenem
            {"Hotelová škola","HŠ"},
            {"hotelová škola","HŠ"}, // Varianta s malým počátečním písmenem
            {"Gymnázium", "G"},
            {"gymnázium", "G"}, // Varianta s malým počátečním písmenem
            {"vyšší odborná škola", "VOŠ"}, // Varianta s malým počátečním písmenem
            {"Vyšší odborná škola", "VOŠ"},
            {"Zemědělská akademie", "ZA"},
            {"zemědělská akademie", "ZA"}, // Varianta s malým počátečním písmenem
            {"střední zemědělská škola","SZŠ" }, // Varianta s malým počátečním písmenem
            {"Střední zemědělská škola","SZŠ" },
            // Přidejte další školy podle potřeby
    };

            string upravenyNazev = nazev;

            foreach (KeyValuePair<string, string> entry in skoly)
            {
                // Nahrazujeme všechny výskyty názvu školy v textu, zachováváme původní formát
                upravenyNazev = Regex.Replace(upravenyNazev, @"\b" + Regex.Escape(entry.Key) + @"\b", entry.Value);
            }

            return upravenyNazev;
        }
    }
}
