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

namespace Ivan
{
    public partial class Nacitani : Form
    {
        private SoundPlayer player;
        private Hlavni okno;

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

            player = new SoundPlayer(Properties.Resources.loading);
            // player.Play();
        }

        private void loading_Tick(object sender, EventArgs e)
        {
            object odeslal = sender;
            loadingBar.Value = loadingBar.Value + 1;

            // Pro každý stav načítání, pokud ještě nebyl text přečten, přečíst ho a nastavit příslušný stav na true
            if (loadingBar.Value >= 0 && loadingBar.Value < 25 && !haIvanRead)
            {
                lblTip.Text = "Ha, Ivan!";
                pomoc.RekniTo(lblTip.Text, true);
                haIvanRead = true;
            }
            else if (loadingBar.Value >= 25 && loadingBar.Value < 70 && !ivanSeNacitaRead)
            {
                lblTip.Text = "Ivan se načítá";
                pomoc.RekniTo("Načítám se", true);
                ivanSeNacitaRead = true;
            }
            else if (loadingBar.Value >= 70 && loadingBar.Value < 95 && !ivanSkoroJeRead)
            {
                lblTip.Text = "Ivan už skoro je ...";
                pomoc.RekniTo("Už skoro jsem", true);
                ivanSkoroJeRead = true;
            }
            else if (loadingBar.Value >= 95 && loadingBar.Value < 100 && !ivanNactenyRead)
            {
                lblTip.Text = "... načtený!";
                pomoc.RekniTo("Načetl jsem se", true);
                ivanNactenyRead = true;
            }

            // pokud je program načten
            if (loadingBar.Value >= 99)
            {
                loading.Enabled = false;

                okno = new Hlavni();

                okno.FormClosed += (s, args) =>
                {
                    this.Close(); // Uzavře načítací okno
                    okno.FormClosed -= (se, arg) => { }; // Odstraní událost FormClosed
                };

                player.Stop();
                this.Hide(); // Skryje načítací okno
                okno.Show(); // Zobrazí hlavní okno
            }
        }

        private void Nacitani_Load(object sender, EventArgs e)
        {
            this.Text = pomoc.VytvorTitulek("Načítání");
        }
    }
}
