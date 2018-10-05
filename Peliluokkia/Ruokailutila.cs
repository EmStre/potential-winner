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
                Console.Write("Ruokailutilassa eteneminen on hankalaa pimeässä. Törmäät pöytään ja saat ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("vesipullo");
                Console.ResetColor();
                Console.WriteLine("n kaatumaan. \n" +
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
                    case "LISÄÄ VESIPULLO":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Vesipullo lisätty Academy-kassiin.\n");
                        Inventaario invent2 = new Inventaario();
                        invent2.LisaaEsine(esine);
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "JUO VETTÄ":
                    case "JUO VESI":
                        Game.vesiHuikat++;
                        if (Game.vesiHuikat == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Onpas harvinaisen pahaa ja lämmintä vettä.\n");
                            Console.ResetColor();
                            Avaa();
                        }
                        else if (Game.vesiHuikat == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Otat huikan ja mietit eikö täältä oikeasti löydy muuta juotavaa.\n");
                            Console.ResetColor();
                            Avaa();
                        }
                        else if (Game.vesiHuikat == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Vesipullo on melkein tyhjä.\n");
                            Console.ResetColor();
                            Avaa();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Vesipullo on tyhjä.\n");
                            Console.ResetColor();
                            Avaa();
                        }
                        break;
                    case "LAMPPU PÄÄLLE":
                    case "SYTYTÄ LAMPPU":
                    case "AVAA LAMPPU":
                    case "TASKULAMPPU PÄÄLLE":
                    case "SYTYTÄ TASKULAMPPU":
                    case "AVAA TASKULAMPPU":
                        if (!Inventaario.esineet.Contains("taskulamppu"))
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Sinulla ei ole lamppua.\n");
                            Console.ResetColor();
                            Avaa();
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Olet huolissasi taskulampun pattereiden riittävyydestä, joten päätät sulkea lampun ja edetä pimeässä.\n");
                            Console.ResetColor();
                            Avaa();
                            break;
                        }
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "H-HELP":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Heikki heikki = new Heikki();
                        heikki.Help();
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "KARTTA":
                        Kartta kartta = new Kartta();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        kartta.KutsuKartta();
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
                    "Voit myös palata WC-tilaan (C), keittokomeroon (D) tai siirtyä keittiöön (E).\n");
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
                        Console.WriteLine("Kävelet keittokomeron puolelle.\n");
                        Console.ResetColor();
                        Keittokomero keittokomero = new Keittokomero();
                        keittokomero.Avaa();
                        break;
                    case "E":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Kävelet keittiöön.\n");
                        Console.ResetColor();
                        Keittio keittio = new Keittio();
                        keittio.Avaa();
                        break;
                    case "OTA VESIPULLO":
                    case "LISÄÄ VESIPULLO":
                    case "LISÄÄ VESI":
                        Console.WriteLine("Vesipullo lisätty Academy-kassiin.\n");
                        Inventaario inventaar = new Inventaario();
                        inventaar.LisaaEsine(esine);
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "JUO VESI":
                    case "JUO VETTÄ":
                        Game.vesiHuikat++;
                        if (Inventaario.esineet.Contains("vesipullo") && Game.vesiHuikat == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Onpas harvinaisen pahaa ja lämmintä vettä.\n");
                            Console.ResetColor();
                            Avaa();
                        }
                        else if (Game.vesiHuikat == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Otat huikan ja mietit eikö täältä oikeasti löydy muuta juotavaa.\n");
                            Console.ResetColor();
                            Avaa();
                        }
                        else if (Game.vesiHuikat == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Vesipullo on melkein tyhjä.\n");
                            Console.ResetColor();
                            Avaa();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Vesipullo on tyhjä.");
                            Console.ResetColor();
                            Avaa();
                        }
                        break;
                    case "LAMPPU PÄÄLLE":
                    case "SYTYTÄ LAMPPU":
                    case "AVAA LAMPPU":
                    case "TASKULAMPPU PÄÄLLE":
                    case "SYTYTÄ TASKULAMPPU":
                    case "AVAA TASKULAMPPU":
                        if (!Inventaario.esineet.Contains("taskulamppu"))
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Sinulla ei ole lamppua.\n");
                            Console.ResetColor();
                            Avaa();
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Olet huolissasi taskulampun pattereiden riittävyydestä, joten päätät sulkea lampun ja edetä pimeässä.\n");
                            Console.ResetColor();
                            Avaa();
                            break;
                        }
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "H-HELP":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Heikki heikki = new Heikki();
                        heikki.Help();
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "KARTTA":
                        Kartta kartta = new Kartta();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        kartta.KutsuKartta();
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
