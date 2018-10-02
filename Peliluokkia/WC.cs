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
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Pöntöstä ei löydy mitään.\n");
                    Console.ResetColor();
                    Avaa();
                    break;
                case "B":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Siirryt keittokomeron puolelle.\n");
                    Console.ResetColor();
                    Keittokomero keittokomero = new Keittokomero();
                    keittokomero.Avaa();
                    break;
                case "C":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Astut ruokailutilaan.\n");
                    Console.ResetColor();
                    Ruokailutila ruokailutila = new Ruokailutila();
                    ruokailutila.Avaa();
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
