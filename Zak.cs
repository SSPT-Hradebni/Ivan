namespace SediM
{
    internal class Zak
    {
        private string jmeno;
        private int misto;

        public string Jmeno { get { return jmeno; } }
        public int Misto { get { return misto; } set { misto = value; } }

        public Zak(string jmeno)
        {
            this.jmeno = jmeno;
        }
    }
}
