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

            // FIXME: Všichni žáci se budou hlásit jako nerozsazení, jelikož při přidávání z databáze se nemění základní stav rozsazení
            // FIX: Přidání dodatečného sloupce v databázi k žákům NEBO po získání žáků a tříd se nastaví jejich parametr rozsazení
            // z vlastnosti data u každé třídy 
            // POZN. k FIXU: Pokud se přistoupí na možnost 2, data jsou odděleny čárkou a jsou ve formátu [Místo žáka]=[ID žáka].
            // Tím lze sice vydedukovat chybějící vlastnosti (jestli je rozsazen a pokud ano, tak jeho místo), nelze však zjistit
            // do jaké třídy patří a od jakého místa se čísluje daná třída. To by teoreticky bylo možné vyřešit dalším sloupcem či vlastností
            // třídy zak (daná třída lze zjistit když přistupujeme k vlastnosti data dané třídy).
            foreach (Zak zak in zaci)
                dataviewStudenti.Rows.Add(zak.Id, zak.CeleJmeno, zak.Kategorie, zak.Skola, /*zak.JeRozsazen ? "Ano" : "Ne"*/ "TODO");
        }
    }
}
