namespace SediM
{
    public class Trida
    {
        private long id;
        private string nazev;
        private int sirka;
        private int vyska;
        private bool rozsazena;
        private string data;

        public long Id { get { return id; } }
        public string Nazev { get { return nazev; } set { nazev = value; } }
        public int Sirka { get { return sirka; } set { sirka = value; } }
        public int Vyska { get { return vyska; } set { vyska = value; } }
        public bool Rozsazena { get { return rozsazena; } set { rozsazena = value; } }
        public string Data { get { return data; } set { data = value; } }

        /// <summary>
        /// Konstruktor třídy
        /// </summary>
        /// <param name="id">ID třídy</param>
        /// <param name="nazev">Název třídy</param>
        /// <param name="sirka">Šířka třídy (v polích)</param>
        /// <param name="vyska">Výška třídy (v polích)</param>
        /// <param name="rozsazena">Třída je/není rozsazená</param>
        /// <param name="data">Data rozsazené třídy</param>
        public Trida(long id, string nazev, int sirka, int vyska, string data, bool rozsazena = false)
        {
            this.id = id;
            this.nazev = nazev;
            this.sirka = sirka;
            this.vyska = vyska;
            this.rozsazena = rozsazena;
            this.data = data;
        }

        public override string ToString()
        {
            return nazev;
        }
    }
}
