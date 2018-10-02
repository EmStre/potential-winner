using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Peliluokkia;

namespace Konsoli
{
    class Program
    {
        static void Main(string[] args)
        {
            Hejlsberg hejlsberg = new Hejlsberg();
            Kaytava kaytava = new Kaytava();
            Console.WriteLine("Istut perjantai-iltana yksn C#-ryhmän Hejlsberg-luokassa kun huomaat kattolamppujen valon värisevän.\n" +
                "Hetken päästä säpsähdät, kun suuren pamauksen saattelemana valot yhtäkkiä sammuvat ja kannettava tietokoneesi pimenee.\n" +
                "Vilkaiset kännykästä kelloa ja toteat sen olevan 23:18. Huomaat myös kännykän kuuluvuuskentän kadonneen.");
            hejlsberg.Avaa();
        }
    }
}
