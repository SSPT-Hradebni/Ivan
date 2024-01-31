using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SediM
{
    public class Trida
    {
        private long id;
        private string nazev;
        private int sirka;
        private int vyska;

        public long Id { get { return id; } }
        public string Nazev { get { return nazev; } set { nazev = value; } }
        public int Sirka { get { return sirka; } set { sirka = value; } }
        public int Vyska { get { return vyska; } set { vyska = value; } }

        /// <summary>
        /// Konstruktor třídy
        /// </summary>
        /// <param name="id">ID třídy</param>
        /// <param name="nazev">Název třídy</param>
        /// <param name="sirka">Šířka třídy (v polích)</param>
        /// <param name="vyska">Výška třídy (v polích)</param>
        public Trida(long id, string nazev, int sirka, int vyska)
        {
            this.id = id;
            this.nazev = nazev;
            this.sirka = sirka;
            this.vyska = vyska;
        }

        public override string ToString()
        {
            return nazev;
        }
    }
}
