namespace SediM
{
    public class Trida
    {
        private long id;
        private string nazev;
        private int sirka;
        private int vyska;
        private bool jeRozsazena;
        private string data;
        private List<int[]>[,] prijatelneKategorieMista;

        public long Id { get { return id; } }
        public string Nazev { get { return nazev; } set { nazev = value; } }
        public int Sirka { get { return sirka; } set { sirka = value; } }
        public int Vyska { get { return vyska; } set { vyska = value; } }
        public bool JeRozsazena { get { return jeRozsazena; } set { jeRozsazena = value; } }
        public string Data { get { return data; } set { data = value; } }
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
        public Trida(long id, string nazev, int sirka, int vyska, string data, bool jeRozsazena = false)
        {
            this.id = id;
            this.nazev = nazev;
            this.sirka = sirka;
            this.vyska = vyska;
            this.jeRozsazena = jeRozsazena;
            this.data = data;
            prijatelneKategorieMista = new List<int[]>[vyska, sirka];
        }

        public override string ToString()
        {
            return nazev;
        }
    }
}
