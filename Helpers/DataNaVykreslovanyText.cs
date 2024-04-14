namespace SediM.Helpers
{
    internal static class DataNaVykreslovanyText
    {
        public static string KategorieNaRimske(int kategorie)
        {
            switch (kategorie)
            {
                case -1:
                    return "--"; // Empty Seat/Space - Prázdné místo; Anglicky aby se nepletlo s ostatními římskými číslicemi
                case 1:
                    return "I.";
                case 2:
                    return "II.";
                case 3:
                    return "III.";
                case 4:
                    return "IV.";
                case 5:
                    return "V.";
                case 6:
                    return "VI.";
                case 7:
                    return "VII.";
                default:
                    return "ERR";
            }
        }

        public static string SkolaNaPismeno(int skola)
        {
            if (skola == -1)
                return "--";
            if (skola > 26)
                return $"{skola}";
            if (skola < -1)
                return "ERR";
            // -1 protože chceme aby škola číslo 1 byla převedena na písmeno 'A'
            return $"{(char)(skola + 'A' - 1)}";
        }
    }
}
