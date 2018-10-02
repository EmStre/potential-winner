using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    public class Kaytava
    {
        string vastaus;
        public void Avaa()
        {
            Console.WriteLine("Olet hämärässä käytävässä, jonka toisessa päässä on keittiö (A), toisessa porraskäytävä (B).\n\n" +
                "Lisäksi käytävän varrelta löytyy C#-ryhmän Hejlsberg-luokka (C), pienet huoneet Lovelace (D), Hopper (E), Jobs (F) ja Gosling (G) sekä konsolipelinurkkaus (H) ja varasto (I).");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.WriteLine("Lähdet kävelemään kohti keittiötä.\n");
                    Keittio keittio = new Keittio();
                    keittio.Avaa();
                    break;
                case "B":
                    Console.WriteLine("Avaat käytävän perältä löytyvän hätäuloskäynnin oven porraskäytävään.");
                    Porraskaytava porraskaytava = new Porraskaytava();
                    porraskaytava.Avaa();
                    break;
                case "C":
                    Console.WriteLine("Avaat ovat C#-ryhmän luokkaan.");
                    Hejlsberg hejlsberg = new Hejlsberg();
                    hejlsberg.Avaa();
                    break;
                case "D":
                    Console.WriteLine("Avaat oven Lovelace-huoneeseen.");
                    Love love = new Love();
                    love.Avaa();
                    break;
                case "E":
                    Console.WriteLine("Avaat oven Hopper-neukkariin");
                    Hopper hopper = new Hopper();
                    hopper.Avaa();
                    break;
                case "F":
                    Console.WriteLine("Avaat oven Jobs-neukkariin");
                    Jobs jobs = new Jobs();
                    jobs.Avaa();
                    break;
                case "G":
                case "I":
                    Console.WriteLine("Väännät kahvasta, mutta toteat oven olevan lukossa.");
                    Avaa();
                    break;
                case "H":
                    Console.WriteLine("Koska sähkö ovat poikki, pysyy pelikonsoli mykkänä");
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
