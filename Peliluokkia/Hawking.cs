using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    public class Hawking
    {
        string vastaus;
        public void Avaa()
        {
            Console.WriteLine("Java-luokassa on aavemainen tunnelma. Ulkona on jo täysin pimeää, etkä oikein näe eteesi. Yhtäkkiä kompastut lattialla lojuvaan möykkyyn. (Tähän joku Tutki-metodi myöhemmin).\n" +
                "Pääset Hawking-luokasta hissikäytävään (A) tai takaisin C#-luokkaan (B).");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.WriteLine("Avaat oven hissikäytävään.\n");
                    Hissikaytava hissikaytava = new Hissikaytava();
                    hissikaytava.Avaa();
                    break;
                case "B":
                    Console.WriteLine("Avaat oven C#-luokkaan.\n");
                    Hejlsberg hejlsberg = new Hejlsberg();
                    hejlsberg.Avaa();
                    break;
                default:
                    Console.WriteLine("Epäkelpo valinta.\n");
                    Avaa();
                    break;
            }
        }
    }
}
