namespace SediM.Forms
{
    public partial class Zak_Seznam : Form
    {
        public List<Zak> zaci = new List<Zak>();

        public Zak_Seznam(List<Zak> zaci)
        {
            InitializeComponent();
            this.zaci = zaci;
        }

        private void Zak_Seznam_Load(object sender, EventArgs e)
        {
            dataviewStudenti.Rows.Clear();

            foreach (Zak zak in zaci)
                dataviewStudenti.Rows.Add(zak.Id, zak.CeleJmeno, zak.Kategorie, zak.Skola);
        }
    }
}
