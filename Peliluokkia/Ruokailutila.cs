using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    class Ruokailutila
    {
        public void Avaa()
        {
            if (!Inventaario.esineet.Contains("vesipullo"))
            {
                string vastaus;
                string esine = "vesipullo";
                Console.WriteLine("Ruokailutilassa eteneminen on hankalaa pimeässä. Törmäät pöytään ja saat vesipullon kaatumaan. \n" +
                    "Parempi siis jatkaa eteenpäin sohvanurkkaukseen (A) tai hissikäytävään (B).\n" +
                    "Voit myös siirtyä WC-tilaan (C) tai keittokomeroon (D).\n");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();

                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Kompuroit sohvanurkkaukseen.\n");
                        Console.ResetColor();
                        Sohvanurkkaus sohvanurkkaus = new Sohvanurkkaus();
                        sohvanurkkaus.Avaa();
                        break;
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Siirryt hissikäytävään.\n");
                        Console.ResetColor();
                        Hissikaytava hissikaytava = new Hissikaytava();
                        hissikaytava.Avaa();
                        break;
                    case "C":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Siirryt WC-tilaan.\n");
                        Console.ResetColor();
                        WC vessa = new WC();
                        vessa.Avaa();
                        break;
                    case "D":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Siirryt keittokomeroon.\n");
                        Console.ResetColor();
                        Keittokomero keittokomero = new Keittokomero();
                        keittokomero.Avaa();
                        break;
                    case "OTA VESIPULLO":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Vesipullo lisätty Academy-kassiin.\n");
                        Inventaario invent = new Inventaario();
                        invent.LisaaEsine(esine);
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "LISÄÄ VESIPULLO":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Vesipullo lisätty Academy-kassiin.\n");
                        Inventaario invent2 = new Inventaario();
                        invent2.LisaaEsine(esine);
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
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
            else
            {
                string vastaus;
                string esine = "vesipullo";
                Console.WriteLine("Ruokailutilassa eteneminen on hankalaa pimeässä.\n" +
                    "Parempi siis jatkaa eteenpäin sohvanurkkaukseen (A) tai hissikäytävään (B).\n" +
                    "Voit myös palata WC-tilaan (C).\n");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();

                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Kompuroit sohvanurkkaukseen.\n");
                        Console.ResetColor();
                        Sohvanurkkaus sohvanurkkaus = new Sohvanurkkaus();
                        sohvanurkkaus.Avaa();
                        break;
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Siirryt hissikäytävään.\n");
                        Console.ResetColor();
                        Hissikaytava hissikaytava = new Hissikaytava();
                        hissikaytava.Avaa();
                        break;
                    case "C":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Siirryt WC-tilaan.\n");
                        Console.ResetColor();
                        WC vessa = new WC();
                        vessa.Avaa();
                        break;
                    case "OTA VESIPULLO":
                        Console.WriteLine("Vesipullo lisätty Academy-kassiin.\n");
                        Inventaario invent = new Inventaario();
                        invent.LisaaEsine(esine);
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "LISÄÄ VESIPULLO":
                        Console.WriteLine("Vesipullo lisätty Academy-kassiin.\n");
                        Inventaario invent2 = new Inventaario();
                        invent2.LisaaEsine(esine);
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
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
}
