
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Peliluokkia
{
    public class Porraskaytava
    {
        string vastaus;
        public void Avaa()
        {
            Console.WriteLine("Hätäuloskäyntiä ilmaisevan lampun hämyisän vihreä valo valaisee alaspäin johtavia portaita (A). Vieressäsi on ovi takaisin Academyn käytävään (B).\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Lähdet kävelemään portaita alas kelmeän vihertävässä valossa.\n");
                    Console.ResetColor();
                    Thread.Sleep(600);
                    Console.WriteLine("...viides kerros...\n");
                    Thread.Sleep(600);
                    Console.WriteLine("...neljäs kerros...\n");
                    Thread.Sleep(600);
                    Console.WriteLine("...kolmas kerros...\n");
                    Thread.Sleep(600);
                    Console.WriteLine("...toinen kerros...\n");
                    Thread.Sleep(600);
                    Console.WriteLine("...ja ensimmäinen kerros.\n");
                    Thread.Sleep(600);
                    PorraskaytavaAlaovi porraskaytavaAlaovi = new PorraskaytavaAlaovi();
                    porraskaytavaAlaovi.Avaa();
                    break;
                case "B":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Avaat oven käytävään.\n");
                    Console.ResetColor();
                    Kaytava kaytava = new Kaytava();
                    kaytava.Avaa();
                    break;
                case "KASSI":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Inventaario inventaario = new Inventaario();
                    Console.WriteLine(inventaario);
                    Console.ResetColor();
                    Avaa();
                    break;
                case "HALP":
                case "HELP":
                    Help help = new Help();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(help);
                    Console.ResetColor();
                    Avaa();
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
