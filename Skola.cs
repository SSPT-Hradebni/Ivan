namespace SediM
{
    internal class Skola
    {
        private int id;
        private List<Zak>[] kategorie = new List<Zak>[7]; // Pole které obsahuje listy s žáky. Každý list reprezentuje jednu kategorii.

        public int Id { get { return id; } }
        public List<Zak>[] Kategorie { get { return kategorie; } set { kategorie = value; } }

        public Skola(int id)
        {
            this.id = id;

            // Inicializace jednotlivých kategorií
            for (int i = 0; i < kategorie.Length; i++)
                kategorie[i] = new List<Zak>();
        }
    }
}
