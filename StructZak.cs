public struct Zak
{
    public string jmeno { get; set; }
    public int skola { get; set; }
    public int rocnik { get; set; }
    public int typOboru { get; set; }
    public int kateg { get; set; }
    public int poradCislo { get; set; }
    public int mistnost { get; set; }
    public string pozice { get; set; }

    /// <summary>
    /// Struktura pro žáka
    /// </summary>
    /// <param name="jmeno">Jméno a přijmení žáka</param>
    /// <param name="skola">ID školy, kterou žák navštěvuje</param>
    /// <param name="rocnik">Ročník, do kterého žák dochází</param>
    /// <param name="typOboru">Typ oboru:<br />0 - učební<br />1 - maturitní</param>
    /// <param name="kateg">Kategorie (I až VII)</param>
    /// <param name="poradCislo">Pořadové číslo žáka (ID z tabulky v databázi)</param>
    /// <param name="mistnost">ID místnosti, kam má být žák přiřazen</param>
    /// <param name="pozice">Souřadnice ve výsledné tabulce rozsazení</param>
    public Zak(string jmeno, int skola, int rocnik, int typOboru, int kateg, int poradCislo, int mistnost, string pozice)
    {
        this.jmeno = jmeno;
        this.skola = skola;
        this.rocnik = rocnik;
        this.typOboru = typOboru;
        this.kateg = kateg;
        this.poradCislo = poradCislo;
        this.mistnost = mistnost;
        this.pozice = pozice;
    }
}