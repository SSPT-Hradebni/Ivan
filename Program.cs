namespace SediM
{
    internal static class Program
    {
        /// <summary>
        /// Hlavn� vstupn� bod aplikace.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}