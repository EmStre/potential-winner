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
                "Kahvi kyllä piristäisi, mutta sitten muistat sähköjen olevan poikki.\n" +
                "Toki (B) keittokomeron vesihanasta saisi myös raikasta vettä. (C) vie sinut takaisin käytävään tai voit myös siirtyä (D) ruokailutilaan.\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Avaat jääkaapin ja onneksesi huomaat oluen olevan vielä kylmää sähkökatkosta huolimatta. Nautit virvokkeen.\n");
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
                    Console.WriteLine("Siirryt takaisin käytävään.\n");
                    Console.ResetColor();
                    Kaytava kaytava = new Kaytava();
                    kaytava.Avaa();
                    break;
                case "D":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Törmäät pöytään etkä pääse etenemään.\n");
                    Console.ResetColor();
                    Avaa();
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
