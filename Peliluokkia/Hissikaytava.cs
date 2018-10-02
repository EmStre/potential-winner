using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    public class Hissikaytava
    {
        string vastaus;
        public void Avaa()
        {
            Console.WriteLine("Hissikäytävällä sijaitsevien kahden hissin ovet (A) seisovat varsin järkähtämättömän oloisina kiinni.\n" +
                "Vieressäsi ovat ovet Torvalds-huoneeseen (B), Java-ryhmän Hawking-luokkaan (C) ja vessaan (D).\n" +
                "Voit myös palata takaisin keittiöön (E).");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hissin nappi ei reagoi painallukseen, eivätkä hissien ovet eivät avaudu milliäkään.");
                    Console.ResetColor();
                    Avaa();
                    break;
                case "B":
                    Console.WriteLine("Avaat oven Torvalds-huoneeseen.");
                    Torvalds torvalds = new Torvalds();
                    torvalds.Avaa();
                    break;
                case "D":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Ovi on näköjään lukossa.");
                    Console.ResetColor();
                    break;
                case "C":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Avaat oven Java-luokkaan.");
                    Console.ResetColor();
                    Hawking hawking = new Hawking();
                    hawking.Avaa();
                    break;
                case "E":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Siirryt keittiöön");
                    Console.ResetColor();
                    Keittio keittio = new Keittio();
                    keittio.Avaa();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Epäkelpo valinta.");
                    Console.ResetColor();
                    Avaa();
                    break;
            }
        }
    }
}
