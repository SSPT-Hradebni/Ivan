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
            if (dataviewTridy.CurrentCell.ColumnIndex != 4)
                return;

            bool jeRozsazena = dataviewTridy[4, dataviewTridy.CurrentRow.Index].Value == "Ano" ? true : false;

            try
            {
                int id = int.Parse(dataviewTridy[0, dataviewTridy.CurrentRow.Index].Value.ToString());

                SqlCommand vytvorTridu = new SqlCommand($"UPDATE Tridy SET JeRozsazena = @jeRozsazena WHERE TridaId = @id", connection);

                vytvorTridu.Parameters.AddWithValue("@id", id);
                // Stav rozsazení se prohodí
                vytvorTridu.Parameters.AddWithValue("@jeRozsazena", jeRozsazena ? 0 : 1);

                int stav = vytvorTridu.ExecuteNonQuery();

                if (stav != 0)
                {
                    // Text buňky značící stav rozsazení se také změní
                    dataviewTridy[4, dataviewTridy.CurrentRow.Index].Value = jeRozsazena ? "Ne" : "Ano";

                    dataZmenena = true;
                }
                else
                {
                    mainHelp.Alert("Chyba!", "Při přidání nové třídy do systému se vyskytla chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
