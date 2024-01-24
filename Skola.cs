using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SediM
{
    public class Skola
    {
        private long id;
        private string nazev;
        private List<Zak>[] kategorie = new List<Zak>[7]; // Pole které obsahuje listy s žáky. Každý list reprezentuje jednu kategorii.

        public long Id { get { return id; } }
        public string Nazev { get { return nazev; } set { nazev = value; } }
        public List<Zak>[] Kategorie { get { return kategorie; } set { kategorie = value; } }

        public Skola(long id, string nazev)
        {
            this.id = id;
            this.nazev = nazev;

            // Inicializace jednotlivých kategorií
            for (int i = 0; i < kategorie.Length; i++)
                kategorie[i] = new List<Zak>();
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
