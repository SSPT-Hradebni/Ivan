using Ivan.Forms;
using Ivan.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SediM
{
    public partial class Nacitani : Form
    {
        private SoundPlayer player;
        private Main okno = new Main();

        private HlavniPomoc pomoc;

        bool haIvanRead = false;
        bool ivanSeNacitaRead = false;
        bool ivanSkoroJeRead = false;
        bool ivanNactenyRead = false;

        public Nacitani()
        {
            InitializeComponent();

            pomoc = new HlavniPomoc();
            lblTip.Text = "";

            player = new SoundPlayer(SediM.Properties.Resources.loading);
            // player.Play();
        }

        private void loading_Tick(object sender, EventArgs e)
        {
            loadingBar.Value = loadingBar.Value + 1;
            Random nahoda = new Random();
            int cislo = nahoda.Next(20, 70);

            double sanceNaNahodu = 20; // například 20% šance
            double nahodneCislo = nahoda.Next(-20, 90); // předpokládáme funkci pro generování náhodného čísla

            if (loadingBar.Value >= 0 && loadingBar.Value < 25 && !haIvanRead)
            {
                lblTip.Text = "Ha, Ivan!";
                pomoc.RekniTo(lblTip.Text, true);
                haIvanRead = true;
            }
            else if (loadingBar.Value >= 25 && loadingBar.Value < 70 && !ivanSeNacitaRead)
            {
                lblTip.Text = "Ivan se načítá";
                if (nahodneCislo < sanceNaNahodu)
                {
                    //lblTip.Text = pomoc.NahodnyIvan(cislo); // nahrazení textu náhodnou větou
                }
                pomoc.RekniTo(lblTip.Text, true);
                ivanSeNacitaRead = true;
            }
            else if (loadingBar.Value >= 70 && loadingBar.Value < 95 && !ivanSkoroJeRead)
            {
                lblTip.Text = "Ivan už skoro je ...";
                pomoc.RekniTo(lblTip.Text, true);
                ivanSkoroJeRead = true;
            }
            else if (loadingBar.Value >= 95 && loadingBar.Value < 100 && !ivanNactenyRead)
            {
                lblTip.Text = "... načtený!";
                pomoc.RekniTo(lblTip.Text, true);
                ivanNactenyRead = true;
            }

            if (SediM.Properties.Settings.Default.LoadingEnabled)
            {
                loading.Enabled = true;

                // pokud je program načten
                if (loadingBar.Value >= 99)
                {
                    loading.Enabled = false;

                    okno.FormClosed += (s, args) =>
                    {
                        this.Close(); // Uzavře načítací okno
                        okno.FormClosed -= (se, arg) => { }; // Odstraní událost FormClosed
                    };

                    this.Hide();
                    okno.Show(); // Zobrazí hlavní okno
                }
            }
            else
            {
                okno.FormClosed += (s, args) =>
                {
                    this.Close(); // Uzavře načítací okno
                    okno.FormClosed -= (se, arg) => { }; // Odstraní událost FormClosed
                };

                this.Hide();
                okno.Show(); // Zobrazí hlavní okno
            }
        }

        private void Nacitani_Load(object sender, EventArgs e)
        {
            loading.Enabled = true;
            this.Text = pomoc.VytvorTitulek("Načítání");
        }
    }
}
