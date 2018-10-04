using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    class Sohvanurkkaus
    {
        public void Avaa()
        {
            string vastaus;
            Console.WriteLine("Sohvanurkkaukseen kajastaa hieman valoa ulkoa, mutta et näe mitään, mikä auttaisi ulospääsyyn.\n" +
                "Mietit pitäisikö palata ruokailutilaan (A) vai siirtyä hissikäytävään (B).\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Astut kompuroiden ruokailutilaan.\n");
                    Console.ResetColor();
                    Ruokailutila ruokailutila = new Ruokailutila();
                    ruokailutila.Avaa();
                    break;
                case "B":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Kävelet hissikäytävään.\n");
                    Console.ResetColor();
                    Hissikaytava hissikaytava = new Hissikaytava();
                    hissikaytava.Avaa();
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
                        Console.WriteLine("Sinulla ei ole lamppua\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Game.sohva++;
                        if (Game.sohva == 1)
                        {
                            Console.WriteLine("Taskulamppu syttyy ja sohvalla makaa Aino sammuneena. Yrität kovasti saada häntä hereille, mutta mitään ei tapahdu.\n" +
                                "Päätät jättää hänet selviämään ja jatkaa matkaa pimeässä (sammutat lampun).\n");
                        }
                        else
                        {
                            Console.WriteLine("Taskulamppu syttyy. Sohvalla makaa edelleen se sammunut konsultti.\n" +
                                "Parempi antaa hänen levätä rauhassa. Sammutat valon ja pohdit vaihtoehtojasi.\n");
                        }
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
                case "H-HELP":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Heikki heikki = new Heikki();
                    heikki.Help();
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
