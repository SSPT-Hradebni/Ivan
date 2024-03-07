using SediM.Helpers;
using System.Data;
using System.Data.SqlClient;

namespace SediM.Forms
{
    public partial class Trida_Seznam : Form
    {
        private SqlConnection connection = new SqlConnection($"Data Source={Properties.Settings.Default.MySQL_server};Initial Catalog={Properties.Settings.Default.MySQL_databaze};User ID={Properties.Settings.Default.MySQL_uzivatel};Password={Properties.Settings.Default.MySQL_heslo}");

        private bool jePripojen = false;
        private List<Trida> tridy = new List<Trida>();
        private MainHelp mainHelp = new MainHelp();
        private bool dataZmenena;

        public Trida_Seznam(List<Trida> tridy)
        {
            InitializeComponent();

            connection.Open();
            ConnectionState stavDB = connection.State;

            try
            {
                if (stavDB == ConnectionState.Broken && jePripojen == false)
                {
                    DialogResult pripojen = mainHelp.Alert("Nepodařilo se připojit k serveru", "Aplikaci se nepodařilo připojit k serveru.\nZkontrolujte prosím, zda je server v provozu, a také zkontrolujte správnost zadaných údajů pro připojení k serveru.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (pripojen == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }

                    return;
                }
            }
            catch (SqlException e)
            {
                mainHelp.Alert("Chyba SQL serveru", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            this.tridy = tridy;
        }

        private void Trida_Seznam_Load(object sender, EventArgs e)
        {
            dataviewTridy.Rows.Clear();

            foreach (Trida trida in tridy)
                dataviewTridy.Rows.Add(trida.Id, trida.Nazev, trida.Sirka, trida.Vyska, trida.Rozsazena ? "Ano" : "Ne");
        }

        private void dataviewTridy_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Funkce se přeruší za předpokladu, že není nakliknuta buňka vypisující
            // stav rozsazení a nebo je označen celý řádek
            if (dataviewTridy.CurrentCell.ColumnIndex != 4 || dataviewTridy.SelectedRows.Count == 1)
                return;

            bool jeRozsazena = dataviewTridy[4, dataviewTridy.CurrentRow.Index].Value == "Ano" ? true : false;

            if (!jeRozsazena)
            {
                mainHelp.Alert("Chyba!", "Nelze nastavit nerozsazenou třídu zpět na rozsazenou.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int id = int.Parse(dataviewTridy[0, dataviewTridy.CurrentRow.Index].Value.ToString());

                SqlCommand vytvorTridu = new SqlCommand($"UPDATE Tridy SET JeRozsazena = @jeRozsazena WHERE TridaId = @id", connection);

                vytvorTridu.Parameters.AddWithValue("@id", id);
                vytvorTridu.Parameters.AddWithValue("@jeRozsazena", 0);

                int stav = vytvorTridu.ExecuteNonQuery();

                if (stav != 0)
                {
                    // Text buňky značící stav rozsazení se změní
                    dataviewTridy[4, dataviewTridy.CurrentRow.Index].Value = "Ne";

                    dataZmenena = true;
                }
                else
                {
                    mainHelp.Alert("Chyba!", "Při úpravě stavu rozsazení třídy v systému nastala chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                mainHelp.Alert("Chyba!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Trida_Seznam_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = dataZmenena ? DialogResult.OK : DialogResult.Cancel;
        }

        private void dataviewTridy_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Pokud je stisknuta klávesa Backspace a zároveň je označený celý řádek.
            if (!(e.KeyChar == (char)Keys.Back && dataviewTridy.SelectedRows.Count == 1))
                return;

            bool jeRozsazena = dataviewTridy[4, dataviewTridy.CurrentRow.Index].Value == "Ano" ? true : false;

            if (jeRozsazena)
            {
                DialogResult result = mainHelp.Alert("Upozornění", "Třída, kterou se chystáte vymazat, je rozsazená. Jste si jisti?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result != DialogResult.OK)
                    return;
            }

            try
            {
                int id = int.Parse(dataviewTridy[0, dataviewTridy.CurrentRow.Index].Value.ToString());

                SqlCommand vytvorTridu = new SqlCommand($"DELETE FROM Tridy WHERE TridaId = @id", connection);

                vytvorTridu.Parameters.AddWithValue("@id", id);

                int stav = vytvorTridu.ExecuteNonQuery();

                if (stav != 0)
                {
                    dataviewTridy.Rows.RemoveAt(dataviewTridy.CurrentRow.Index);
                    dataZmenena = true;
                }
                else
                {
                    mainHelp.Alert("Chyba!", "Při odebírání třídy v systému nastala chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                mainHelp.Alert("Chyba!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
