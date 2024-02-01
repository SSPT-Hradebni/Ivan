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

        /// <summary>
        /// Klasický konstruktor školy
        /// </summary>
        /// <param name="id">ID školy</param>
        /// <param name="nazev">Název školy</param>
        public Skola(long id, string nazev)
        {
            this.id = id;
            this.nazev = nazev;

            // Inicializace jednotlivých kategorií
            for (int i = 0; i < kategorie.Length; i++)
                kategorie[i] = new List<Zak>();
        }
        public Skola Clone()
        {
            Skola skola = new Skola(id, nazev);

            // Procykluje veškeré kategorie ve klonované škole
            for (int i = 0; i < kategorie.Length; i++)
            {
                // Procykluje veškeré žáky v kategorii klonované školy
                foreach (Zak zak in kategorie[i])
                {
                    skola.kategorie[i].Add(new Zak(zak.Id, zak.Jmeno, zak.Prijmeni, zak.Kategorie, zak.Skola));
                }
            }

            return skola;
        }

        /// <summary>
        /// Přetížení s pouze ID školy
        /// </summary>
        /// <param name="id">ID školy</param>
        public Skola(long id)
        {
            this.id = id;

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
