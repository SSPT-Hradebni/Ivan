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
    public partial class FormWiev : Form
    {
        public FormWiev()
        {
            InitializeComponent();
        }
        public List<Trida> tridy = new List<Trida>();
        private void FormWiev_Load(object sender, EventArgs e)
        {
         
                createwiev();


        }

        private void createwiev()
        {
            //try
            //{
                Point posid = new Point(-1, -1);
                while (true)
                {

                    if (posid.X == tridy.Find(x => x.Nazev == textBox1.Text).Sirka)
                        posid.Y++;

                    string[] tmp = tridy.Find(x => x.Nazev == textBox1.Text).Data.Split(",");
                    foreach (string s in tmp)
                    {
                        Label label = new Label();
                        label.BackColor = Color.OrangeRed;
                        label.Font = new Font(label.Font, FontStyle.Bold);
                    
                        label.Location = new Point(Convert.ToInt32(s.Split("=")[0]) % tridy.Find(x => x.Nazev == textBox1.Text).Sirka, Convert.ToInt32(s.Split("=")[0]) / tridy.Find(x => x.Nazev == textBox1.Text).Sirka); //pos
                        label.Text = s.Split("=")[1]; //jmeno
                        this.Controls.Add(label);
                    }
                    posid.X++;
                }
            //}
            //catch { }
        }


        private void FormWiev_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            createwiev();
        }
    }
}
