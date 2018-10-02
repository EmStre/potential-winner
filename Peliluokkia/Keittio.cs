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
                "Toki (B) keittokomeron vesihanasta saisi myös raikasta vettä. (C) vie sinut takaisin käytävään tai voit myös siirtyä (D) ruokailutilaan.\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.WriteLine("Avaat jääkaapin ja onneksesi huomaat oluet olevan vielä kylmää sähkökatkosta huolimatta. Nautit virvokkeen.");
                    Avaa();
                    break;
                case "B":
                    Console.WriteLine("Siirryt keittokomeron puolelle.");
                    Keittokomero keittokomero = new Keittokomero();
                    keittokomero.Avaa();
                    break;
                case "C":
                    Console.WriteLine("Siirryt takaisin käytävään.");
                    Kaytava kaytava = new Kaytava();
                    kaytava.Avaa();
                    break;
                case "D":
                    Console.WriteLine("Törmäät pöytään etkä pääse etenemään.");
                    Avaa();
                    break;
                default:
                    Console.WriteLine("Epäkelpo valinta.");
                    Avaa();
                    break;
            }
        }
    }
}
