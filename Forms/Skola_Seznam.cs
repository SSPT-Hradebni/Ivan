namespace SediM.Forms
{
    public partial class Skola_Seznam : Form
    {
        public List<Skola> skoly = new List<Skola>();

        public Skola_Seznam(List<Skola> skoly)
        {
            InitializeComponent();
            this.skoly = skoly;
        }

        private void Zak_Seznam_Load(object sender, EventArgs e)
        {
            dataviewSkoly.Rows.Clear();

            foreach (Skola skola in skoly)
                dataviewSkoly.Rows.Add(skola.Id, skola.Nazev, skola.Adresa, skola.Ico, skola.Kod);
        }
    }
}
