namespace SediM
{
    public class Zak : IComparable<Zak>
    {
        private int id;
        private string jmeno;
        private string prijmeni;
        private int kategorie;
        private int skola;

        private int misto;

        public int Id { get { return id; } }
        public string Jmeno { get { return jmeno; } }
        public string Prijmeni { get { return prijmeni; } }
        public int Kategorie { get { return kategorie; } set { kategorie = value; } }
        public int Skola { get { return skola; } set { skola = value; } }
        public int Misto { get { return misto; } set { misto = value; } }

        public Zak(int id, string jmeno, string prijmeni, int kategorie, int skola)
        {
            this.id = id;
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.kategorie = kategorie;
            this.skola = skola;
        }

        public int CompareTo(Zak? other)
        {
            return string.Compare(ZamenaJmenoPrijmeni(), other.ZamenaJmenoPrijmeni());
        }

        public string ZamenaJmenoPrijmeni()
        {
            string[] udaje = jmeno.Split(' ');

            return $"{udaje[1]} {udaje[0]}";
        }

        public override string ToString()
        {
            return ZamenaJmenoPrijmeni();
        }
    }
}
