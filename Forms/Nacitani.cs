using SediM.Helpers;
using System;
using System.IO;
using System.Media;
using System.Net.Http;
using System.Windows.Forms;

namespace SediM
{
    public partial class Nacitani : Form
    {
        private Main okno = new Main();
        private MainHelp pomoc;

        bool haIvanRead = false;
        bool ivanSeNacitaRead = false;
        bool ivanSkoroJeRead = false;
        bool ivanNactenyRead = false;

        private readonly string currentVersion = "1.0.0-ALPHA"; // Aktuální verze programu
        private readonly HttpClient httpClient = new HttpClient(); // Inicializace HttpClient
        private bool updateCheckCompleted = false; // Příznak, který určuje, zda byla kontrola aktualizací dokončena

        public Nacitani()
        {
            InitializeComponent();

            pomoc = new MainHelp();
            lblTip.Text = "";

            loading.Interval = 50;
        }

        private void CheckForUpdates()
        {
            try
            {
                // Zastavení načítání během kontroly aktualizací
                loading.Enabled = false;

                // URL s informací o verzi na serveru
                string versionUrl = "http://example.com/ivan/version.txt";

                // Synchronní načtení verze ze serveru
                HttpResponseMessage response = httpClient.GetAsync(versionUrl).Result;
                response.EnsureSuccessStatusCode();
                string serverVersion = response.Content.ReadAsStringAsync().Result.Trim();

                // Kontrola, zda je dostupná novější verze
                if (IsNewVersion(serverVersion, currentVersion))
                {
                    DialogResult result = MessageBox.Show($"Nová verze {serverVersion} je dostupná. Chcete ji nainstalovat?",
                                                          "Aktualizace programu",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        DownloadAndUpdate(serverVersion);
                    }
                    else
                    {
                        MessageBox.Show("V programu se mohou nacházet důležité bezpečnostní aktualizace, které nebudou aplikovány.",
                                        "Upozornění",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nepodařilo se zkontrolovat aktualizace: " + ex.Message,
                                "Chyba",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                updateCheckCompleted = true; // Nastavení příznaku na true, protože kontrola aktualizací byla dokončena
                loading.Enabled = true; // Pokračování v načítání
            }
        }

        private bool IsNewVersion(string serverVersion, string currentVersion)
        {
            // Rozdělení verzí na části
            Version server = new Version(serverVersion);
            Version current = new Version(currentVersion);

            return server.CompareTo(current) > 0;
        }

        private void DownloadAndUpdate(string serverVersion)
        {
            try
            {
                // URL ke stažení aktualizace
                string downloadUrl = $"http://example.com/ivan/download/{serverVersion}";
                string tempFilePath = Path.Combine(Path.GetTempPath(), $"update-{serverVersion}.exe");

                // Synchronní stažení souboru aktualizace
                HttpResponseMessage response = httpClient.GetAsync(downloadUrl).Result;
                response.EnsureSuccessStatusCode();

                using (var fs = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    response.Content.CopyToAsync(fs).Wait(); // Synchronní zápis obsahu do souboru
                }

                // Zahájení instalace aktualizace
                System.Diagnostics.Process.Start(tempFilePath);

                // Ukončení aktuální aplikace
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nepodařilo se stáhnout aktualizaci: " + ex.Message,
                                "Chyba",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void loading_Tick(object sender, EventArgs e)
        {
            loadingBar.Value = loadingBar.Value + 1;
            Random nahoda = new Random();
            int cislo = nahoda.Next(1, 100);

            double sanceNaNahodu = 20; // například 20% šance
            double nahodneCislo = nahoda.Next(-20, 20); // předpokládáme funkci pro generování náhodného čísla

            if (loadingBar.Value >= 0 && loadingBar.Value < 25 && !haIvanRead)
            {
                lblTip.Text = "Ha, Ivan!";
                haIvanRead = true;
            }
            else if (loadingBar.Value >= 25 && loadingBar.Value < 70 && !ivanSeNacitaRead)
            {
                lblTip.Text = "Ivan is loading";
                ivanSeNacitaRead = true;

                // Spuštění kontroly aktualizací, pokud nebyla spuštěna
                if (!updateCheckCompleted)
                {
                    CheckForUpdates();
                }
            }
            else if (loadingBar.Value >= 70 && loadingBar.Value < 95 && !ivanSkoroJeRead && loading.Enabled == true)
            {
                lblTip.Text = "Ivan is almost ...";
                ivanSkoroJeRead = true;
            }
            else if (loadingBar.Value >= 95 && loadingBar.Value < 100 && !ivanNactenyRead && loading.Enabled == true)
            {
                lblTip.Text = "... loaded!";
                ivanNactenyRead = true;
            }

            if (Properties.Settings.Default.LoadingEnabled)
            {
                loading.Enabled = true;

                if (loadingBar.Value >= 98)
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
