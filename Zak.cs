namespace SediM
{
    internal class Zak : IComparable<Zak>
    {
        private int id;
        private string jmeno;

        // private string prijmeni;
        private int misto;

        public string Jmeno { get { return jmeno; } }
        // public string Prijmeni { get { return prijmeni; } }
        public int Misto { get { return misto; } set { misto = value; } }

        public Zak(string jmeno)
        {
            this.jmeno = jmeno;
            // this.prijmeni = prijmeni;
        }

        public int CompareTo(Zak? other)
        {
            return string.Compare(ZamenaJmenoPrijmeni(), other.ZamenaJmenoPrijmeni());
        }

        public string ZamenaJmenoPrijmeni()
        {
            string[] udaje = this.jmeno.Split(' ');

            return $"{udaje[1]} {udaje[0]}";
        }

        public override string ToString()
        {
            return ZamenaJmenoPrijmeni();
        }
    }
}
