using SediM.Helpers;

namespace SediM
{
    public class Trida
    {
        private int id;
        private string nazev;
        private int sirka;
        private int vyska;
        private bool jeRozsazena;
        private Zak[,] rozsazeniZaci;
        private List<int[]>[,] prijatelneKategorieMista;

        public int Id { get { return id; } }
        public string Nazev { get { return nazev; } set { nazev = value; } }
        public int Sirka { get { return sirka; } set { sirka = value; } }
        public int Vyska { get { return vyska; } set { vyska = value; } }
        public bool JeRozsazena { get { return jeRozsazena; } set { jeRozsazena = value; } }
        public Zak[,] RozsazeniZaci { get { return rozsazeniZaci; } set { rozsazeniZaci = value; } }
        public List<int[]>[,] PrijatelneKategorieASkolyMista { get { return prijatelneKategorieMista; } set { prijatelneKategorieMista = value; } }
        
        /// <summary>
        /// Konstruktor třídy
        /// </summary>
        /// <param name="id">ID třídy</param>
        /// <param name="nazev">Název třídy</param>
        /// <param name="sirka">Šířka třídy (v polích)</param>
        /// <param name="vyska">Výška třídy (v polích)</param>
        /// <param name="rozsazena">Třída je/není rozsazená</param>
        /// <param name="data">Data rozsazené třídy</param>
        public Trida(int id, string nazev, int sirka, int vyska, string data, bool jeRozsazena = false)
        {
            this.id = id;
            this.nazev = nazev;
            this.sirka = sirka;
            this.vyska = vyska;
            rozsazeniZaci = new Zak[vyska, sirka];
            // Pokud nejsou data prázdná, vyplníme dvourozměrné pole rozřazenými žáky
            if (data != "")
                ExtrahujZaky(data);
            this.jeRozsazena = jeRozsazena;

            prijatelneKategorieMista = new List<int[]>[vyska, sirka];
        }

        private void ExtrahujZaky(string data)
        {
            string[] mistaSZaky = data.Split(',');
            List<Zak> zaci = DBNaObjekty.ZiskejListZaku(DBKomunikace.NactiZaky());

            for (int r = 0; r < vyska; r++)
            {
                for (int s = 0; s < sirka; s++)
                {
                    string[] dataMista = mistaSZaky[r * sirka + s].Split('=');
                    int id = int.Parse(dataMista[1]);
                    int misto = int.Parse(dataMista[0]);

                    // Proměnná zak bude null tehdy, nenachází-li se dané id v databázi.
                    // V tom případě považujeme místo za prázdné.
                    Zak? zak = zaci.Find(hledanyZak => hledanyZak.Id == id);
                    if (zak == null)
                        zak = new Zak(-1, "PRÁZDNÉ", "MÍSTO", -1, -1, -1);
                    zak.Misto = misto;

                    rozsazeniZaci[r, s] = zak;
                }
            }
        }

        public override string ToString()
        {
            return nazev;
        }
    }
}
