using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;
using System.Speech.Synthesis;
using System.Globalization;

namespace Ivan.Helpers
{
    public class HlavniPomoc
    {
        /// <summary>
        /// Funkce pro mluvení zadaného textu.
        /// </summary>
        /// <param name="text">Text, který má být promluven.</param>
        /// <param name="muzeMluvit">Určuje, zda má být text promluven (true) nebo ne (false).</param>
        public void RekniTo(string text, bool muzeMluvit)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();

            // Nastavení hlasu na český hlas
            synthesizer.SelectVoice("Microsoft Jakub");

            if (muzeMluvit)
            {
                synthesizer.SpeakAsync(text);
            }
        }

        /// <summary>
        /// Titulek pro okna aplikace
        /// </summary>
        /// <param name="text">Text v titulku</param>
        /// <returns>Titulek s konkrétním textem včetně názvu aplikace</returns>
        public string VytvorTitulek(string text)
        {
            return text.Length > 0 ? $"{text} | {Properties.Settings.Default.AppName}" : Properties.Settings.Default.AppName;
        }

        /// <summary>
        /// Skloňování slova z 1. pádu do 5. pádu
        /// </summary>
        /// <param name="slovo">Slovo ke skloňování</param>
        /// <returns>Slovo v pátém pádu</returns>
        public string Sklonuj(string slovo)
        {
            if (string.IsNullOrEmpty(slovo) || slovo.Length < 1)
                return string.Empty;
            slovo = slovo.Trim();
            int i = slovo.Length - 1; // Index posledniho pismene
            slovo = slovo[0].ToString().ToUpper() + slovo.Substring(1, i);

            string vysledneSlovo = slovo;

            if (!((slovo[i - 1] == 'u' && slovo[i] == 'm') ||
                (slovo[i - 1] == 'o' && slovo[i] == 'n')))
            {
                if (slovo[i - 1] == 'i' && slovo[i] == 'a') // Maria
                    // Nebo -io, -eio
                    // Záleží na výslovnosti ...
                    vysledneSlovo = slovo.Substring(0, i - 1) + "ie";

                else if (slovo[i - 1] == 'í' && slovo[i] == 'a') // María
                    vysledneSlovo = slovo.Substring(0, i - 1) + "íe";

                else if (slovo[i - 1] == 'e' && slovo[i] == 'c') // Otec
                    vysledneSlovo = slovo.Substring(0, i - 1) + "če";

                else if (slovo[i - 1] == 'e' && slovo[i] == 'k') // Bobek
                    vysledneSlovo = slovo.Substring(0, i - 1) + "ku";

                else if (slovo[i - 1] == 'e' && slovo[i] == 'l') // Bobek
                    vysledneSlovo = slovo.Substring(0, i - 1) + "le";

                else if (slovo[i - 1] == 'c' && slovo[i] == 'h')
                    vysledneSlovo += "u";

                else if (slovo[i] == 'a' ||
                    slovo[i] == 'á')
                    vysledneSlovo = slovo.Substring(0, i) + "o";

                else if (slovo[i] == 'ž' ||
                    slovo[i] == 'l' ||
                    slovo[i] == 'j' ||
                    slovo[i] == 's' ||
                    slovo[i] == 'č' ||
                    slovo[i] == 'c' ||
                    slovo[i] == 'x' ||
                    slovo[i] == 'š' ||
                    slovo[i] == 'z' ||
                    slovo[i] == 'ř')
                    vysledneSlovo += "i";

                else if (slovo[i] == 'n' ||
                    slovo[i] == 't' ||
                    slovo[i] == 'b' ||
                    slovo[i] == 'd' ||
                    slovo[i] == 'ď' ||
                    slovo[i] == 'f' ||
                    slovo[i] == 't' ||
                    slovo[i] == 'n' ||
                    slovo[i] == 'ň' ||
                    slovo[i] == 'p' ||
                    slovo[i] == 'm' ||
                    slovo[i] == 'v' ||
                    slovo[i] == 'w' ||
                    slovo[i] == 'r')
                    vysledneSlovo += "e";

                else if (slovo[i] == 'k' ||
                   slovo[i] == 'g')
                    vysledneSlovo += "u";

                else if (slovo[i] == 'é')
                    vysledneSlovo = slovo.Substring(0, i) + "e";

                else if (slovo[i] == 'ó' ||
                    slovo[i] == 'ň')
                    vysledneSlovo = slovo.Substring(0, i) + "o";

                //if(slovo[i] == 'r')
                //    vysledneSlovo = slovo.Substring(0, i) + "ře";
            }
            return vysledneSlovo;
        }
    }
}
