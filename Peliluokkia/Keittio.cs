using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    class Keittio
    {
        string vastaus;
        public void Avaa()
        {
            Console.WriteLine("Keittiöön tulee hieman valoa ulkona palavista katulampuista.\n" +
                "Suutasi kuivaa ja muistat (A) jääkaappiin jääneen bisseä Terrific Thursdayn jäljiltä.\n" + 
                "Toki (B) vesihanasta saisi myös raikasta vettä. (C) vie sinut takaisin käytävään\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.WriteLine("Avaat jääkaapin ja onneksesi huomaat oluen olevan vielä kylmää sähkökatkosta huolimatta. Nautit virvokkeen.\n");
                    Avaa();
                    break;
                case "B":
                    Console.WriteLine("Menet kraanan luokse, mutta huomaat, että vesikin on poikki.\n");
                    Avaa();
                    break;
                case "C":
                    Console.WriteLine("Siirryt takaisin käytävään.\n");
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
