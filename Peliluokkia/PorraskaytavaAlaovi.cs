using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    public class PorraskaytavaAlaovi
    {
        string vastaus;
        public void Avaa()
        {
            Console.WriteLine("Käveltyäsi kuusi kerrosta hämärää porraskäytävää alas saavut vihdoin rakennuksen takaovelle\n." +
                "Avaatko oven (A) vai palaatko takaisin (B)?\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Ovi on lukossa. Jumalauta.\n");
                    Console.ResetColor();
                    Avaa();
                    break;
                case "B":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Lähdet kapuamaan portaita takaisin kuudenteen kerrokseen.\n.");
                    Console.ResetColor();
                    Porraskaytava porraskaytava = new Porraskaytava();
                    porraskaytava.Avaa();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Epäkelpo valinta.\n");
                    Console.ResetColor();
                    Avaa();
                    break;
            }
        }
    }
}
