using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ivan
{
    public partial class Nacitani : Form
    {
        public Nacitani()
        {
            InitializeComponent();
        }

        private void loading_Tick(object sender, EventArgs e)
        {
            loadingBar.Value = loadingBar.Value + 1;

            // změna typu na základě aktuální hodnoty načítání
            if(loadingBar.Value >= 0 && loadingBar.Value < 25)
            {
                lblTip.Text = "Ha, Ivan!";
            }
            else if(loadingBar.Value >= 25 && loadingBar.Value < 70)
            {
                lblTip.Text = "Ivan se načítá";
            }
            else if( loadingBar.Value >= 70 && loadingBar.Value < 95)
            {
                lblTip.Text = "Ivan už skoro je ...";
            }
            else if (loadingBar.Value >= 95 && loadingBar.Value < 100)
            {
                lblTip.Text = "... načtený!";
            }

            // pokud je program načten
            if (loadingBar.Value >= 99)
            {
                loading.Enabled = false;
            }
        }
    }
}
