using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    public class Game
    {
        static void Valinta()
        {
            string vastaus = "";
            Console.WriteLine("Olet Hejslberg-huoneessa, ja voit siirtyä joko A) käytävään tai B) Hawking-luokkaan. Mikä on valintasi?");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch(vastaus)
            {
                case "A":
                    Console.WriteLine("Valitsit A");
                    break;
                case "B":
                    Console.WriteLine("Valitsit B");
                    break;
            }
        }   

    }
}
