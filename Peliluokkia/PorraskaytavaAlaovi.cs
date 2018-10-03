using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Peliluokkia
{
    public class PorraskaytavaAlaovi
    {
        string vastaus;
        public void Avaa()
        {
            Console.WriteLine("Käveltyäsi kuusi kerrosta hämärää porraskäytävää alas saavut vihdoin rakennuksen takaovelle.\n" +
                "Avaatko oven (A) vai palaatko takaisin (B)?\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Ovi on lukossa. Jumalauta.\n");
                    Console.ResetColor();
                    Jatka();
                    break;
                case "B":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Lähdet kapuamaan portaita takaisin kuudenteen kerrokseen.\n.");
                    Console.ResetColor();
                    Thread.Sleep(600);
                    Console.WriteLine("...toinen kerros...\n");
                    Thread.Sleep(600);
                    Console.WriteLine("...kolmas kerros...\n");
                    Thread.Sleep(600);
                    Console.WriteLine("...neljäs kerros...\n");
                    Thread.Sleep(600);
                    Console.WriteLine("...viides kerros...\n");
                    Thread.Sleep(600);
                    Console.WriteLine("...ja kuudes kerros.\n");
                    Porraskaytava porraskaytava = new Porraskaytava();
                    porraskaytava.Avaa();
                    break;
                case "KASSI":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Inventaario inventaario = new Inventaario();
                    Console.WriteLine(inventaario);
                    Console.ResetColor();
                    Jatka();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Epäkelpo valinta.\n");
                    Console.ResetColor();
                    Jatka();
                    break;
            }
        }
        public void Jatka()
        {
            Console.WriteLine("Seisot porraskäytävän alapäässä, rakennuksen hätäuloskäynnin edessä.\n" +
                "Avaatko oven (A) vai palaatko takaisin (B)?\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Kuten olet jo aiemmin todennut, on ovi lukossa.\n");
                    Console.ResetColor();
                    Jatka();
                    break;
                case "B":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Lähdet kapuamaan portaita takaisin kuudenteen kerrokseen.\n.");
                    Console.ResetColor();
                    Thread.Sleep(600);
                    Console.WriteLine("...toinen kerros...\n");
                    Thread.Sleep(600);
                    Console.WriteLine("...kolmas kerros...\n");
                    Thread.Sleep(600);
                    Console.WriteLine("...neljäs kerros...\n");
                    Thread.Sleep(600);
                    Console.WriteLine("...viides kerros...\n");
                    Thread.Sleep(600);
                    Console.WriteLine("...ja kuudes kerros.\n");
                    Porraskaytava porraskaytava = new Porraskaytava();
                    porraskaytava.Avaa();
                    break;
                case "KASSI":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Inventaario inventaario = new Inventaario();
                    Console.WriteLine(inventaario);
                    Console.ResetColor();
                    Jatka();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Epäkelpo valinta.\n");
                    Console.ResetColor();
                    Jatka();
                    break;
            }
        }
    }
}
