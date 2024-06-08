namespace SediM
{
    public class Skola
    {
        private int id;
        private string nazev;
        private string adresa;
        private int ico;
        private string kod;

        public int Id { get { return id; } }
        public string Nazev { get { return nazev; } set { nazev = value; } }
        public string Adresa { get { return adresa; } set { adresa = value; } }
        public int Ico { get { return ico; } set { ico = value; } }
        public string Kod { get { return kod; } set { kod = value; } }

        /// <summary>
        /// Klasický konstruktor školy
        /// </summary>
        /// <param name="id">ID školy</param>
        /// <param name="nazev">Název školy</param>
        public Skola(int id, string nazev, string adresa, int ico, string kod)
        {
            this.id = id;
            this.nazev = nazev;
            this.adresa = adresa;
            this.ico = ico;
            this.kod = kod;
        }

        /// <summary>
        /// Přetížení s pouze ID školy
        /// </summary>
        /// <param name="id">ID školy</param>
        public Skola(int id)
        {
            this.id = id;
        }

        public int CompareTo(Skola other)
        {
            return string.Compare(ToString(), other.ToString());
        }

        public override string ToString()
        {
            return nazev;
        }
    }
}
