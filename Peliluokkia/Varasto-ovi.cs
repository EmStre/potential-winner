using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    public class VarastoOvi : ILamppu
    {
        string vastaus;
        private bool lamppuPäällä = false;

        public bool LamppuPäällä
        {
            get
            {
                return lamppuPäällä;
            }
        }

        VarastoOvi lamppu;
        public void Avaa()
        {
            Console.WriteLine("Muistat Maisan kertoneen, että varastossa on sähkökaappi, joka käynnistää Academyn generaattorin tarjoten sähköä oleellisimmille toiminoille.\n " +
                "Voisi olla hyödyllistä saada sähköt päälle.\n");
            Jatka();

        }
        public void Jatka()
        {
            lamppu = new VarastoOvi();
            if(Inventaario.esineet.Contains("CV") && Inventaario.esineet.Contains("vihko") && Inventaario.esineet.Contains("fläppitaulu"))
            {
                Console.WriteLine("Koodi on 7-numeroinen ja sinulla on kaikki esineet, joden avulla voit saada oven auki.. On kuitenkin melko pimeää!\nVoit toki halutessasi palata" +
                    "tutkimaan käytävää (A).");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Tarkastelet taas käytävää.\n");
                        Console.ResetColor();
                        Kaytava kaytava = new Kaytava();
                        kaytava.Avaa();
                        break;
                    case "TASKULAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        ValoisaOvi();
                        break;
                    case "LAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        ValoisaOvi();
                        break;
                    case "AVAA LAMPPU":
                        lamppu.Päällä();
                        ValoisaOvi();
                        break;
                    case "LAITA LAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        ValoisaOvi(); 
                        break;
                    case "KYTKE LAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        ValoisaOvi();
                        break;
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
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        Jatka();
                        break;
                }
            }

            else if ((!Inventaario.esineet.Contains("CV") && Inventaario.esineet.Contains("vihko") && Inventaario.esineet.Contains("fläppitaulu")) || (Inventaario.esineet.Contains("CV") && !Inventaario.esineet.Contains("vihko") && Inventaario.esineet.Contains("fläppitaulu")) || (Inventaario.esineet.Contains("CV") && Inventaario.esineet.Contains("vihko") && !Inventaario.esineet.Contains("fläppitaulu")))
            {
                Console.WriteLine("Sinulta puuttuu yksi esine. Et voi saadaa ovea auki ilman sitä. Jatka etsimistä.\nMuistathan lisätä löytämäsi esineet kassiin.\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Tarkastelet taas käytävää.\n");
                Console.ResetColor();
                Kaytava kaytava = new Kaytava();
                kaytava.Avaa();
                
            }
            else if ((!Inventaario.esineet.Contains("CV") && !Inventaario.esineet.Contains("vihko") && Inventaario.esineet.Contains("fläppitaulu")) || (Inventaario.esineet.Contains("CV") && !Inventaario.esineet.Contains("vihko") && !Inventaario.esineet.Contains("fläppitaulu")) || (!Inventaario.esineet.Contains("CV") && Inventaario.esineet.Contains("vihko") && !Inventaario.esineet.Contains("fläppitaulu")))
            {
                Console.WriteLine("Sinulta puuttuu esineitä. Et voi saadaa ovea auki ilman niitä. Jatkahan etsimistä.\nMuistathan lisätä löytämäsi esineet kassiin.\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Tarkastelet taas käytävää.\n");
                Console.ResetColor();
                Kaytava kaytava = new Kaytava();
                kaytava.Avaa();
            }
            else if (!Inventaario.esineet.Contains("CV") && !Inventaario.esineet.Contains("vihko") && !Inventaario.esineet.Contains("fläppitaulu"))
            {
                Console.WriteLine("Sinulta puuttuu KAIKKI esineet. Yritäppäs löytää ne!");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Tarkastelet taas käytävää.\n");
                Console.ResetColor();
                Kaytava kaytava = new Kaytava();
                kaytava.Avaa();
            }
        }

        public void ValoisaOvi()
        {
            lamppu = new VarastoOvi();
            int kokeilu = 0;
            kokeilu++;

            if (kokeilu == 1)
            {
                Console.WriteLine("Otat kassistasi fläppitaulun, vihkon ja CV:n\nNiiden avulla yrität keksiä 7-numeroisen koodin, jonka näppäilet lukon numeronäppäimistöön.\nHUOM! Järjestyksellä on väliä!\n");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "6910542":
                        Console.WriteLine("Tosi hyvä!! Ovi on auki!");
                        lamppu.PoisPäältä();
                        Varasto varasto = 
                        break;

                    case "SAMMUTA VALO":
                        lamppu.PoisPäältä();
                        Avaa();
                        break;
                    case "SAMMUTA TASKULAMPPU":
                        lamppu.PoisPäältä();
                        Avaa();
                        break;
                    case "SAMMUTA LAMPPU":
                        lamppu.PoisPäältä();
                        Avaa();
                        break;
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
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                }

            }
            else if (kokeilu < 15)
            {
                Console.WriteLine("Koodi oli väärin, yritä uudelleen!");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "6910542":
                        Console.WriteLine("Tosi hyvä!! Ovi on auki!");


                        break;

                    case "SAMMUTA VALO":
                        lamppu.PoisPäältä();
                        Avaa();
                        break;
                    case "SAMMUTA TASKULAMPPU":
                        lamppu.PoisPäältä();
                        Avaa();
                        break;
                    case "SAMMUTA LAMPPU":
                        lamppu.PoisPäältä();
                        Avaa();
                        break;
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
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                }

            }
        }

        public void PoisPäältä()
        {
            lamppuPäällä = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Taskulamppu sammui.\n");
            Console.ResetColor();
        }

        public void Päällä()
        {
            lamppuPäällä = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Taskulamppu on päällä.\n");
            Console.ResetColor();
        }
    }
}
