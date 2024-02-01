using System.Data;
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
        /// Načítání studentů do listu z <paramref name="data"/>
        /// </summary>
        /// <param name="data">Surová tabulka dat studentů</param>
        /// <returns>Všichni studenti z databáze v listu</returns>
        public List<Zak> ListZaku(DataTable data)
        {
            // vytvoření dočasného listu studentů
            List<Zak> zaci = new List<Zak>();

            foreach(DataRow radek in data.Rows)
            {
                // rozdělení jména a příjmení
                string[] jmeno = radek[1].ToString().Split(' ');

                // [0] - ID studenta
                // [1] - Jméno studenta
                // [2] - Příjmení studenta
                // [3] - Studentovo číslo kategorie
                // [4] - ID školy
                Zak zak = new Zak(long.Parse(radek[0].ToString()), jmeno[0], jmeno[1], long.Parse(radek[2].ToString()), long.Parse(radek[3].ToString()));
                zaci.Add(zak);
            }

            return zaci;
        }

        /// <summary>
        /// Načítání tříd do listu z <paramref name="data"/>
        /// </summary>
        /// <param name="data">Surová tabulka dat tříd</param>
        /// <returns>Všechny třídy z databáze v listu</returns>
        public List<Trida> ListTrid(DataTable data)
        {
            // vytvoření dočasného listu tříd
            List<Trida> tridy = new List<Trida>();

            foreach (DataRow radek in data.Rows)
            {
                // [0] - ID třídy
                // [1] - Název třídy
                // [2] - Šířka třídy (v místech)
                // [3] - Výška třídy (v místech)
                Trida trida = new Trida(long.Parse(radek[0].ToString()), radek[1].ToString(), int.Parse(radek[2].ToString()), int.Parse(radek[3].ToString()));
                tridy.Add(trida);
            }

            return tridy;
        }

        /// <summary>
        /// Načítání škol do listu z <paramref name="data"/>
        /// </summary>
        /// <param name="data">Surová tabulka dat škol</param>
        /// <returns>Všechny školy z databáze v listu</returns>
        public List<Skola> ListSkol(DataTable data)
        {
            // vytvoření dočasného listu škol
            List<Skola> skoly = new List<Skola>();

            foreach (DataRow radek in data.Rows)
            {
                // [0] - ID školy
                // [1] - Název školy
                Skola skola = new Skola(long.Parse(radek[0].ToString()), radek[1].ToString());
                skoly.Add(skola);
            }

            return skoly;
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
    }
}
