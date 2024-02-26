namespace SediM
{
    public class Ucitel
    {
        private int id;
        private string jmeno;
        private string prijmeni;
        private string email;
        private string heslo;

        public int Id { get { return id; } }
        public string Jmeno { get { return jmeno; } }
        public string Prijmeni { get { return prijmeni; } }
        public string Email { get { return email; } set { email = value; } }
        public string Heslo { get { return heslo; } set { heslo = value; } }

        /// <summary>
        /// Klasický konstruktor učitele
        /// </summary>
        /// <param name="id">ID učitele</param>
        /// <param name="jmeno">Křestní jméno učitele</param>
        /// <param name="prijmeni">Příjmení učitele</param>
        /// <param name="email">Přihlašovací email učitele do webové aplikace</param>
        /// <param name="heslo">Heslo učitele pro přihlašování do webové aplikace</param>
        public Ucitel(int id, string jmeno, string prijmeni, string email, string heslo)
        {
            this.id = id;
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.email = prijmeni;
            this.heslo = heslo;
        }

        public override string ToString()
        {
            return $"{prijmeni} {jmeno}";
        }

        public string CeleJmeno
        {
            get { return $"{prijmeni} {jmeno}"; }
        }
    }
}
