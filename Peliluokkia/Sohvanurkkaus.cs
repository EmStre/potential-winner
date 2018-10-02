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
                "Mietit pitäisikö palata ruokailutilaan (A) vai edetä hissikäytävään (B).\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.WriteLine("Astut kompuroiden ruokailutilaan.\n");
                    Ruokailutila ruokailutila = new Ruokailutila();
                    ruokailutila.Avaa();
                    break;
                case "B":
                    Console.WriteLine("Kävelet hissikäytävään.\n");
                    Hissikaytava hissikaytava = new Hissikaytava();
                    hissikaytava.Avaa();
                    break;
                default:
                    Console.WriteLine("Epäkelpo valinta.\n");
                    Avaa();
                    break;
            }
        }
    }
}
