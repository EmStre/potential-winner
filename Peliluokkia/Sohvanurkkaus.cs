using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    class Sohvanurkkaus
    {
        public void Avaa()
        {
            string vastaus;
            Console.WriteLine("Sohvanurkkaukseen kajastaa hieman valoa ulkoa, mutta et näe mitään, mikä auttaisi ulospääsyyn.\n" +
                "Mietit pitäisikö palata ruokailutilaan (A) vai siirtyä hissikäytävään (B).\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Astut kompuroiden ruokailutilaan.\n");
                    Console.ResetColor();
                    Ruokailutila ruokailutila = new Ruokailutila();
                    ruokailutila.Avaa();
                    break;
                case "B":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Kävelet hissikäytävään.\n");
                    Console.ResetColor();
                    Hissikaytava hissikaytava = new Hissikaytava();
                    hissikaytava.Avaa();
                    break;
                case "KASSI":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Inventaario inventaario = new Inventaario();
                    Console.WriteLine(inventaario);
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
