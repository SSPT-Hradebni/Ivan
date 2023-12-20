using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
