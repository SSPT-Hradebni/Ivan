namespace SediM
{
    public class Zak : IComparable<Zak>
    {
        private long id;
        private string jmeno;
        private string prijmeni;
        private long kategorie;
        private long skola;

        private int x;
        private int y;
        private int misto;

        public long Id { get { return id; } }
        public string Jmeno { get { return jmeno; } }
        public string Prijmeni { get { return prijmeni; } }
        public long Kategorie { get { return kategorie; } set { kategorie = value; } }
        public long Skola { get { return skola; } set { skola = value; } }
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public int Misto { get { return y; } set { y = value; } }

        /// <summary>
        /// Klasický konstruktor studenta
        /// </summary>
        /// <param name="id">ID studenta</param>
        /// <param name="jmeno">Křestní jméno studenta</param>
        /// <param name="prijmeni">Příjmení studenta</param>
        /// <param name="kategorie">Kategorie studenta</param>
        /// <param name="skola">ID školy studenta</param>
        public Zak(long id, string jmeno, string prijmeni, long kategorie, long skola)
        {
            this.id = id;
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.kategorie = kategorie;
            this.skola = skola;
        }

        /// <summary>
        /// Konstruktor pro pozice studentů
        /// </summary>
        /// <param name="x">Pozice X</param>
        /// <param name="y">Pozice Y</param>
        public Zak(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int CompareTo(Zak other)
        {
            return string.Compare(ToString(), other.ToString());
        }

        public Zak Clone()
        {
            return new Zak(this.Id, this.Jmeno, this.Prijmeni, this.Kategorie, this.Skola);
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
