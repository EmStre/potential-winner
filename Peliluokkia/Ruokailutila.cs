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
            Console.WriteLine("Ruokailutilassa eteneminen on hankalaa pimeässä.\n +" +
                "Parempi siis jatkaa eteenpäin sohvanurkkaukseen (A) tai hissikäytävään (B). \n +" +
                "Voit myös palata WC-tilaan (C).\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.WriteLine("Kompuroit sohvanurkkaukseen.\n");
                    Sohvanurkkaus sohvanurkkaus = new Sohvanurkkaus();
                    sohvanurkkaus.Avaa();
                    break;
                case "B":
                    Console.WriteLine("Siirryt hissikäytävään.\n");
                    Hissikaytava hissikaytava = new Hissikaytava();
                    hissikaytava.Avaa();
                    break;
                case "C":
                    Console.WriteLine("Siirryt WC-tilaan.\n");
                    WC vessa = new WC();
                    vessa.Avaa();
                    break;
                default:
                    Console.WriteLine("Epäkelpo valinta.\n");
                    Avaa();
                    break;
            }
        }
    }
}
