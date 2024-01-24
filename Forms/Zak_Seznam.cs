using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SediM.Forms
{
    public partial class Zak_Seznam : Form
    {
        public List<Zak> zaci = new List<Zak>();

        public Zak_Seznam(List<Zak> zaci)
        {
            InitializeComponent();
            this.zaci = zaci;
        }

        private void Zak_Seznam_Load(object sender, EventArgs e)
        {
            dataviewStudenti.Rows.Clear();

            // Vysvětlení jednotlivých indexů datového typu DataRow
            // [0] - ID
            // [1] - Jméno
            // [2] - Kategorie
            // [3] - Škola

            foreach (Zak zak in zaci)
            {
                dataviewStudenti.Rows.Add(zak.Id, $"{zak.Prijmeni} {zak.Jmeno}", zak.Kategorie, zak.Skola);
            }
        }
    }
}
