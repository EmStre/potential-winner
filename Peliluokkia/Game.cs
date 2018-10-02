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
            
            Console.WriteLine("Olet Hejslberg-huoneessa, ja voit siirtyä joko A) käytävään tai B) Hawking-luokkaan. Mikä on valintasi?");
            string vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch(vastaus)
            {
                case "A":
                    // ladataan vaihtoehto A
                    break;
                case "B":
                    // ladataan vaihtoehto B
                    break;
            }
        }   

    }
}
