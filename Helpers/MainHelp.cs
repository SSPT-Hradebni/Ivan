using Npgsql;
using Npgsql.Internal;
using PdfSharp;
using System.Data;
using System.Text;
using System.Windows.Forms;

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

        public List<Zak> ListZaku(DataTable data)
        {
            List<Zak> list = new List<Zak>();

            // Vysvětlení jednotlivých indexů datového typu DataRow
            // [0] - ID
            // [1] - Jméno
            // [2] - Příjmení
            // [2] - Kategorie
            // [3] - Škola ID

            foreach (DataRow zak in data.Rows)
            {
                string[] jmenoPrijmeni = zak[1].ToString().Split(' ');
                list.Add(new Zak(int.Parse(zak[0].ToString()), jmenoPrijmeni[0], jmenoPrijmeni[1], int.Parse(zak[2].ToString()), int.Parse(zak[3].ToString())));
                zak.Delete();
            }

            return list;
        }
    }
}
