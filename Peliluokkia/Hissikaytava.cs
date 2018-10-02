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
                    Console.WriteLine("Hissin nappi ei reagoi painallukseen, eivätkä hissien ovet eivät avaudu milliäkään.");
                    Avaa();
                    break;
                case "B":
                    Console.WriteLine("Avaat oven Torvalds-huoneeseen.");
                    Torvalds torvalds = new Torvalds();
                    torvalds.Avaa();
                    break;
                case "D":
                    Console.WriteLine("Ovi on näköjään lukossa.");
                    break;
                case "C":
                    Console.WriteLine("Avaat oven Java-luokkaan.");
                    Hawking hawking = new Hawking();
                    hawking.Avaa();
                    break;
                case "E":
                    Console.WriteLine("Siirryt keittiöön");
                    Keittio keittio = new Keittio();
                    keittio.Avaa();
                    break;
                default:
                    Console.WriteLine("Epäkelpo valinta.");
                    Avaa();
                    break;
            }
        }
    }
}
