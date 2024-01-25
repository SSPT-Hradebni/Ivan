namespace SediM
{
    public class Zak : IComparable<Zak>
    {
        private long id;
        private string jmeno;
        private string prijmeni;
        private long kategorie;
        private long skola;

        private long misto;

        public long Id { get { return id; } }
        public string Jmeno { get { return jmeno; } }
        public string Prijmeni { get { return prijmeni; } }
        public long Kategorie { get { return kategorie; } set { kategorie = value; } }
        public long Skola { get { return skola; } set { skola = value; } }
        public long Misto { get { return misto; } set { misto = value; } }

        public Zak(long id, string jmeno, string prijmeni, long kategorie, long skola)
        {
            this.id = id;
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.kategorie = kategorie;
            this.skola = skola;
        }

        public int CompareTo(Zak other)
        {
            return string.Compare(ToString(), other.ToString());
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
