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
        public List<Trida> tridy = new List<Trida>();
        public FormWiev(List<Trida> tridy)
        {
            InitializeComponent();
            this.tridy = tridy;
        }

        private void FormWiev_Load(object sender, EventArgs e)
        {

            createwiev();



        }
        Random ran = new Random();
        int pos = 60;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            createwiev();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createwiev();
        }

        public void createwiev()
        {
            this.Controls.Clear();
            this.Controls.Add(numericUpDown1); this.Controls.Add(button1);
            try
            {
                Trida ttp = tridy[(int)numericUpDown1.Value];//tridy.Find(tridy => tridy.Id == 86);//Convert.ToInt32(textBox1.Text));
                if (ttp != null)
                {
                    int border = 6;
                    int n = 0;
                    string[] tmp = ttp.Data.Split(",");
                    foreach (string s in tmp)
                    {

                        Label label = new Label();
                        label.Size = new Size(50, 50);
                        label.BackColor = Color.FromArgb(255, ran.Next(100, 255), ran.Next(100, 255), ran.Next(100, 255));
                        label.Font = new Font(label.Font, FontStyle.Bold);
                        int a = Convert.ToInt32(s.Split("=")[0].Replace('=', ' '));//misto= zak
                                                                                   //  int b;// = Convert.ToInt32(s.Split("=")[1]);
                                                                                   //label.Size.Width = pos;
                                                                                   //label.Size.Height = pos;

                        

                        label.Location = new Point((n * pos), ((int)(a / border) * pos));

                        label.Text = s.Split("=")[1]; //jmeno
                        this.Controls.Add(label);
                        if (n >= border+1)
                            n = 0;
                        else
                            n++;

                    }

                }

            }
            catch { }
        }
    }
}


