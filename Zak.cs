﻿namespace SediM
{
    public class Zak : IComparable<Zak>
    {
        private int id;
        private string jmeno;
        private string prijmeni;
        private int priorita = -1;
        private int kategorie;
        private int skola;
        private int trida;
        private int misto;

        public int Id { get { return id; } }
        public string Jmeno { get { return jmeno; } }
        public string Prijmeni { get { return prijmeni; } }
        public int Priorita { get { return priorita; } set { priorita = value; } }
        public int Kategorie { get { return kategorie; } }
        public int Skola { get { return skola; } set { skola = value; } }
        public int Trida { get { return trida; } set { trida = value; } }
        public int Misto { get { return misto; } set { misto = value; } }

        /// <summary>
        /// Klasický konstruktor studenta
        /// </summary>
        /// <param name="id">ID studenta</param>
        /// <param name="jmeno">Křestní jméno studenta</param>
        /// <param name="prijmeni">Příjmení studenta</param>
        /// <param name="kategorie">Kategorie studenta</param>
        /// <param name="skola">ID školy studenta</param>
        public Zak(int id, string jmeno, string prijmeni, int kategorie, int skola, int trida)
        {
            this.id = id;
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.kategorie = kategorie;
            this.skola = skola;
            this.trida = trida;
        }

        public int CompareTo(Zak other)
        {
            return string.Compare(ToString(), other.ToString());
        }

        public Zak Clone()
        {
            return new Zak(this.Id, this.Jmeno, this.Prijmeni, this.Kategorie, this.Skola, this.Trida);
        }

        public override string ToString()
        {
            return $"{prijmeni} {jmeno}";
        }

        public string CeleJmeno
        {
            get { return $"{prijmeni} {jmeno}"; }
        }
    }
}
