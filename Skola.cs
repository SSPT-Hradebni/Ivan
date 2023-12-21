using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKategorieZaciObj
{
    internal class Skola
    {
        private string nazev;
        private List<List<Zak>> kategorie; // List který obsahuje listy s žáky. Každý list reprezentuje jednu kategorii.

        public string Nazev { get { return nazev; } }
        public List<List<Zak>> Kategorie { get { return kategorie; } set { kategorie = value; } }

        public Skola(string nazev)
        {
            this.nazev = nazev;
        }
    }
}
