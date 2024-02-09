using Ivan.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ivan.Forms
{
    public partial class Hlavni : Form
    {
        private HlavniPomoc pomoc;

        public Hlavni()
        {
            InitializeComponent();

            pomoc = new HlavniPomoc();
        }

        private void Hlavni_Load(object sender, EventArgs e)
        {
            this.Text = pomoc.VytvorTitulek("Hlavní okno");
        }

        private void menuItem_StudentNovy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nový student");
        }
    }
}
