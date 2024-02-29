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
    public partial class Trida_Seznam : Form
    {
        private List<Trida> tridy = new List<Trida>();
        public Trida_Seznam(List<Trida> tridy)
        {
            InitializeComponent();

            this.tridy = tridy;
        }

        private void Trida_Seznam_Load(object sender, EventArgs e)
        {
            dataviewTridy.Rows.Clear();

            foreach (Trida trida in tridy)
                dataviewTridy.Rows.Add(trida.Id, trida.Nazev, trida.Sirka, trida.Vyska, trida.Rozsazena ? "Ano" : "Ne");
        }
    }
}
