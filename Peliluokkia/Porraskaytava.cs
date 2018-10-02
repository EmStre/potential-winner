
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    public class Porraskaytava
    {
        string vastaus;
        public void Avaa()
        {
            Console.WriteLine("Hätäuloskäyntiä ilmaisevan lampun hämyisän vihreä valo valaisee alaspäin johtavia portaita (A). Vieressäsi on ovi takaisin Academyn käytävään (B).\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.WriteLine("Lähdet kävelemään portaita alas kelmeän vihertävässä valossa.\n");
                    PorraskaytavaAlaovi porraskaytavaAlaovi = new PorraskaytavaAlaovi();
                    porraskaytavaAlaovi.Avaa();
                    break;
                case "B":
                    Console.WriteLine("Avaat oven käytävään\n.");
                    Kaytava kaytava = new Kaytava();
                    kaytava.Avaa();
                    break;
                default:
                    Console.WriteLine("Epäkelpo valinta.\n");
                    Avaa();
                    break;
            }
        }
    }
}
