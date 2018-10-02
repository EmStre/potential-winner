using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    class Keittokomero
    {
        public void Avaa()
        {
            string vastaus;
            Console.WriteLine("Hapuilet pimeässä tiskipöydän luo.\n" +
                "Pöydältä erottuu esine, jonka tunnistat ensiapulaukuksi.\n" +
                "Kädelläsi tavoitat myös vesihanan. (A) vie sinut ruokailutilaan tai voit siirtyä takaisin (B) keittiön puolelle.\n" +
                "WC-tilan (C) ovi näyttäisi olevan hieman raollaan. \n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.WriteLine("Siirryt ruokailutilaan");
                    Avaa();
                    break;
                case "B":
                    Console.WriteLine("Siirryt keittokomeron puolelle.");
                    Keittio keittio = new Keittio();
                    keittio.Avaa();
                    break;
                case "C":
                    Console.WriteLine("Siirryt WC-tilaan.");
                    WC vessa = new WC();
                    vessa.Avaa();
                    break;
                default:
                    Console.WriteLine("Epäkelpo valinta.");
                    Avaa();
                    break;
            }
        }
    }
}
