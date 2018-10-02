using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    class WC
    {
        public void Avaa()
        {
            string vastaus;
            Console.WriteLine("Olet vessassa ja mietit voisiko avain ulospääsyyn löytyä vessanpöntöstä(A).\n" +
                "Vessasta pääset jatkamaan haparointia takaisin keittokomeroon (B) tai ruokailutilaan (C).\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.WriteLine("Pöntöstä ei löydy mitään.\n");
                    Avaa();
                    break;
                case "B":
                    Console.WriteLine("Siirryt keittokomeron puolelle.\n");
                    Keittokomero keittokomero = new Keittokomero();
                    keittokomero.Avaa();
                    break;
                case "C":
                    Console.WriteLine("Astut ruokailutilaan.\n");
                    Ruokailutila ruokailutila = new Ruokailutila();
                    ruokailutila.Avaa();
                    break;
                default:
                    Console.WriteLine("Epäkelpo valinta.\n");
                    Avaa();
                    break;
            }
        }
    }
}
