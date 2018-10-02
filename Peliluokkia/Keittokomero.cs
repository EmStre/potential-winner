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
                "Kädelläsi tavoitat myös vesihanan (A). (B) vie sinut ruokailutilaan tai voit siirtyä takaisin (C) keittiön puolelle.\n" +
                "WC-tilan (D) ovi näyttäisi olevan hieman raollaan. \n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.WriteLine("Helkkarin kiva, juoksevaa vettä ei tule.\n");
                    Avaa();
                    break;
                case "B":
                    Console.WriteLine("Siirryt ruokailutilaan.\n");
                    Avaa();
                    break;
                case "C":
                    Console.WriteLine("Kävelet keittiöön.\n");
                    Keittio keittio = new Keittio();
                    keittio.Avaa();
                    break;
                case "D":
                    Console.WriteLine("Astut WC-tilaan.\n");
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
