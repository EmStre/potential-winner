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
                    if (Inventaario.esineet.Contains("avain"))
                    {
                        Console.WriteLine("Kaivat Academy-laukustasi avaimet ja kokeilet sitä takaoveen.\n)";
                        Thread.Sleep(800);
                        Console.WriteLine("Olet jo varautunut pahimpaan - avain ei sopisikaan oven lukkoon - mutta vastoin odotuksiasi, avain sopii lukkoon ja ovi aukeaa!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Ovi on lukossa. Jumalauta.\n");
                        Console.ResetColor();
                        Jatka();
                    }
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
                    Thread.Sleep(600);
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
                case "HALP":
                case "HELP":
                    Help help = new Help();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(help);
                    Console.ResetColor();
                    Avaa();
                    break;
                case "RIKO OVI":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Raivoissasi ryhdyt potkimaan ovea, mutta onnistut vain satuttamaan jalkasi.\n");
                    Console.ResetColor();
                    Jatka();
                    break;
                case "H-HELP":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Heikki heikki = new Heikki();
                    heikki.Help();
                    Console.ResetColor();
                    Avaa();
                    break;
                case "KARTTA":
                    Kartta kartta = new Kartta();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    kartta.KutsuKartta();
                    Console.ResetColor();
                    Avaa();
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
                case "RIKO OVI":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Raivoissasi ryhdyt potkimaan ovea, mutta onnistut vain satuttamaan jalkasi.\n");
                    Console.ResetColor();
                    Jatka();
                    break;
                case "KASSI":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Inventaario inventaario = new Inventaario();
                    Console.WriteLine(inventaario);
                    Console.ResetColor();
                    Jatka();
                    break;
                case "HALP":
                case "HELP":
                    Help help = new Help();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(help);
                    Console.ResetColor();
                    Jatka();
                    break;
                case "H-HELP":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Heikki heikki = new Heikki();
                    heikki.Help();
                    Console.ResetColor();
                    Jatka();
                    break;
                case "KARTTA":
                    Kartta kartta = new Kartta();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    kartta.KutsuKartta();
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
