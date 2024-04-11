namespace SediM
{
    public class Skola
    {
        private int id;
        private string nazev;
        private string ulice;
        private int cp;
        private int psc;
        private string mesto;
        private Ucitel ucitel;

        public int Id { get { return id; } }
        public string Nazev { get { return nazev; } set { nazev = value; } }
        public string Ulice { get { return ulice; } set { ulice = value; } }
        public int Cp { get { return cp; } set { cp = value; } }
        public int Psc { get { return psc; } set { psc = value; } }
        public string Mesto { get { return mesto; } set { mesto = value; } }
        public Ucitel Ucitel { get { return ucitel; } set { ucitel = value; } }

        /// <summary>
        /// Klasický konstruktor školy
        /// </summary>
        /// <param name="id">ID školy</param>
        /// <param name="nazev">Název školy</param>
        public Skola(int id, string nazev, string ulice, int cp, int psc, string mesto, Ucitel ucitel)
        {
            this.id = id;
            this.nazev = nazev;
            this.ulice = ulice;
            this.cp = cp;
            this.psc = psc;
            this.mesto = mesto;
            this.ucitel = ucitel;
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
