using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    public class Hejlsberg
    {
        string vastaus;
        public void Avaa()
        {
            Console.WriteLine("C#-ryhmän luokka on tyhjä ja hämärä, lähes täysin pimeä.\n\n" +
                "Joten kuten erotat valonkatkaisijan (A), kaksi ovea käytävään (B) ja oven Java-ryhmän Hawking-luokkaan (C).");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.WriteLine("Painat valonkatkaisijaa, mutta mitään ei tapahdu. Sähköt tosiaan taitavat olla poikki.\n");
                    Avaa();
                    break;
                case "B":
                    Console.WriteLine("Avaat oven käytävään.");
                    Kaytava kaytava = new Kaytava();
                    kaytava.Avaa();
                    break;
                case "C":
                    Console.WriteLine("Väännät Java-ryhmän huoneen oven kahvasta, mutta toteat oven olevan lukossa.");
                    Avaa();
                    break;
                default:
                    Console.WriteLine("Epäkelpo valinta.");
                    Avaa();
                    break;
            }
        }
    }
}
