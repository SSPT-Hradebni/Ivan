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

        private void pictureBox1_StudentNovy_Click(object sender, EventArgs e)
        {
            pomoc.NovyStudent();
        }

        private void lblStudentNovy_Click(object sender, EventArgs e)
        {
            pomoc.NovyStudent();
        }

        private void ukončitIvanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
