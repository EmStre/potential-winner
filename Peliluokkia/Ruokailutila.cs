using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    class Ruokailutila
    {
        public void Avaa()
        {
            string vastaus;
            Console.WriteLine("Ruokailutilassa eteneminen on hankalaa pimeässä.\n" +
                "Parempi siis jatkaa eteenpäin sohvanurkkaukseen (A) tai hissikäytävään (B).\n" +
                "Voit myös palata WC-tilaan (C).\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Kompuroit sohvanurkkaukseen.\n");
                    Console.ResetColor();
                    Sohvanurkkaus sohvanurkkaus = new Sohvanurkkaus();
                    sohvanurkkaus.Avaa();
                    break;
                case "B":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Siirryt hissikäytävään.\n");
                    Console.ResetColor();
                    Hissikaytava hissikaytava = new Hissikaytava();
                    hissikaytava.Avaa();
                    break;
                case "C":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Siirryt WC-tilaan.\n");
                    Console.ResetColor();
                    WC vessa = new WC();
                    vessa.Avaa();
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
