using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    class Torvalds
    {
        string vastaus;
        public void Avaa()
        {
            Console.WriteLine("Astut sisään Torvalds-huoneeseen. Siirryt ikkunaa kohti ja melkein kompastut fläppitauluun.\n" +
                "Taulussa on tekstiä, mutta et saa siitä selvää, koska on liian pimeää. Takanasi on ovi takaisin hissikäytävään(A).\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.WriteLine("Astut takaisin hissikäytävään.");
                    Hissikaytava hissikaytava = new Hissikaytava();
                    hissikaytava.Avaa();
                    break;
                default:
                    Console.WriteLine("Epäkelpo valinta.");
                    Avaa();
                    break;
            }
        }
    }
}
