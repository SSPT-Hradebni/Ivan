using System.Data;

namespace SediM.Helpers
{
    internal static class DBNaObjekty
    {
        /// <summary>
        /// Načítání studentů do listu z <paramref name="data"/>
        /// </summary>
        /// <param name="data">Surová tabulka dat studentů</param>
        /// <returns>Všichni studenti z databáze v listu</returns>
        public static List<Zak> ZiskejListZaku(DataTable data)
        {
            // vytvoření dočasného listu studentů
            List<Zak> zaci = new List<Zak>();

            foreach (DataRow radek in data.Rows)
            {
                // [0] - ID studenta
                // [1] - Jméno studenta
                // [2] - Příjmení studenta
                // [3] - Studentovo číslo kategorie
                // [4] - ID školy
                // [5] - ID třídy
                Zak zak = new Zak((int)radek[0], (string)radek[1], (string)radek[2], (int)radek[3], (int)radek[4], (int)radek[5]);
                zaci.Add(zak);
            }

            return zaci;
        }

        /// <summary>
        /// Načítání tříd do listu z <paramref name="data"/>
        /// </summary>
        /// <param name="data">Surová tabulka dat tříd</param>
        /// <returns>Všechny třídy z databáze v listu</returns>
        public static List<Trida> ZiskejListTrid(DataTable data)
        {
            // vytvoření dočasného listu tříd
            List<Trida> tridy = new List<Trida>();

            foreach (DataRow radek in data.Rows)
            {
                // [0] - ID třídy
                // [1] - Název třídy
                // [2] - Šířka třídy (v místech)
                // [3] - Výška třídy (v místech)
                // [4] - stav rozsazení třídy (je = true, není = false)
                // [5] - data o rozsazení
                Trida trida = new Trida(int.Parse(radek[0].ToString()), radek[1].ToString(), int.Parse(radek[2].ToString()), int.Parse(radek[3].ToString()), radek[5].ToString(), int.Parse(radek[4].ToString()) == 0 ? false : true);
                tridy.Add(trida);
            }

            return tridy;
        }

        /// <summary>
        /// Načítání škol do listu z <paramref name="data"/>
        /// </summary>
        /// <param name="data">Surová tabulka dat škol</param>
        /// <returns>Všechny školy z databáze v listu</returns>
        public static List<Skola> ZiskejListSkol(DataTable data)
        {
            // vytvoření dočasného listu škol
            List<Skola> skoly = new List<Skola>();

            foreach (DataRow radek in data.Rows)
            {
                // [0] - ID školy
                // [1] - Název školy
                // [2] - Ulice
                // [3] - Číslo popisné
                // [4] - PSČ
                // [5] - Město
                // [6] - Učitel (ID)
                Skola skola = new Skola(int.Parse(radek[0].ToString()), radek[1].ToString(), radek[2].ToString(), int.Parse(radek[3].ToString()), int.Parse(radek[4].ToString()), radek[5].ToString(), new Ucitel(int.Parse(radek[6].ToString()))); // TODO FIX
                skoly.Add(skola);
            }

            return skoly;
        }

        /// <summary>
        /// Načítání učitelů do listu z <paramref name="data"/>
        /// </summary>
        /// <param name="data">Surová tabulka dat učitelů</param>
        /// <returns>Všichni učitelé z databáze v listu</returns>
        public static List<Ucitel> ZiskejListUcitelu(DataTable data)
        {
            // vytvoření dočasného listu učitelů
            List<Ucitel> ucitele = new List<Ucitel>();

            foreach (DataRow radek in data.Rows)
            {
                // [0] - ID učitele
                // [1] - Křestní jméno
                // [2] - Příjmení
                // [3] - Email
                // [4] - Heslo
                Ucitel ucitel = new Ucitel(int.Parse(radek[0].ToString()), radek[1].ToString(), radek[2].ToString(), radek[3].ToString(), radek[4].ToString());
                ucitele.Add(ucitel);
            }

            return ucitele;
        }
    }
}
