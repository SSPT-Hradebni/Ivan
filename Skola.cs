using static Azure.Core.HttpHeader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SediM
{
    public class Skola
    {
        private long id;
        private string nazev;

        public long Id { get { return id; } }
        public string Nazev { get { return nazev; } set { nazev = value; } }

        /// <summary>
        /// Klasický konstruktor školy
        /// </summary>
        /// <param name="id">ID školy</param>
        /// <param name="nazev">Název školy</param>
        public Skola(long id, string nazev)
        {
            this.id = id;
            this.nazev = nazev;
        }

        /// <summary>
        /// Přetížení s pouze ID školy
        /// </summary>
        /// <param name="id">ID školy</param>
        public Skola(long id)
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
