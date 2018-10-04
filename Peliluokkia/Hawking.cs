using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    public class Hawking : ILamppu
    {
        string vastaus;
        string esine = "CV";
        private bool lamppuPäällä = false;

        public bool LamppuPäällä
        {
            get
            {
                return lamppuPäällä;
            }
        }
        Hawking lamppu;
        public void Avaa()
        {
            Console.WriteLine("Java-luokassa on aavemainen tunnelma. Ulkona on jo täysin pimeää, etkä oikein näe eteesi.\n");
            Jatka();

        }

        public void Jatka()
        {
            lamppu = new Hawking();

            if (!Inventaario.esineet.Contains("taskulamppu"))
            {
                Console.WriteLine("Yhtäkkiä kompastalet lattialla lojuvaan möykkyyn. Pääset pimeästä Hawking-luokasta hissikäytävään (A) tai C#-luokkaan (B).\n");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Avaat oven hissikäytävään.\n");
                        Console.ResetColor();
                        Hissikaytava hissikaytava = new Hissikaytava();
                        hissikaytava.Avaa();
                        break;
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Yrität avata ovea, mutta se on jostain syystä lukittu.\n");
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "KARTTA":
                        Kartta kartta = new Kartta();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        kartta.KutsuKartta();
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "AVAA LAMPPU":
                    case "LAMPPU PÄÄLLE":
                    case "LAMPPU":
                    case "AVAA TASKULAMPPU":
                    case "TASKULAMPPU PÄÄLLE":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Sinulla ei ole lamppua.\n");
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "OTA MÖYKKY":
                    case "TUTKI MÖYKKY":
                    case "OTA PAPERIPALLO":
                    case "TUTKI PAPERIPALLO":
                    case "OTA PAPERI":
                    case "TUTKI PAPERI":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Huomaat, että möykky on paperipallo, mutta on pimeää etkä saa mitään selvää, mitä siinä lukee. Tiputat paperipallon lattialle.\n");
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "H-HELP":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Heikki heikki = new Heikki();
                        heikki.Help();
                        Console.ResetColor();
                        Jatka();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        Jatka();
                        break;
                }

            }
            else
            {
                if (!Inventaario.esineet.Contains("CV"))
                {
                    Console.WriteLine("Kompastalet lattialla lojuvaan möykkyyn. Pääset pimeästä Hawking-luokasta hissikäytävään (A) tai C#-luokkaan (B).\n");
                    vastaus = Console.ReadLine();
                    vastaus = vastaus.ToUpper();
                    switch (vastaus)
                    {
                        case "A":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Avaat oven hissikäytävään.\n");
                            Console.ResetColor();
                            Hissikaytava hissikaytava = new Hissikaytava();
                            hissikaytava.Avaa();
                            break;
                        case "B":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Yrität avata ovea, mutta se on jostain syystä lukittu.\n");
                            Console.ResetColor();
                            Jatka();
                            break;
                        case "HALP":
                        case "HELP":
                            Help help = new Help();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(help);
                            Console.ResetColor();
                            Jatka();
                            break;
                        case "KARTTA":
                            Kartta kartta = new Kartta();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            kartta.KutsuKartta();
                            Console.ResetColor();
                            Jatka();
                            break;
                        case "LAMPPU":
                        case "TASKULAMPPU PÄÄLLE":
                        case "LAMPPU PÄÄLLE":
                        case "AVAA LAMPPU":
                        case "LAITA LAMPPU PÄÄLLE":
                        case "KYTKE LAMPPU PÄÄLLE":
                            lamppu.Päällä();
                            ValoisaHawking();
                            break;
                        case "OTA MÖYKKY":
                        case "TUTKI MÖYKKY":
                        case "OTA PAPERIPALLO":
                        case "TUTKI PAPERIPALLO":
                        case "OTA PAPERI":
                        case "TUTKI PAPERI":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Huomaat, että möykky on paperipallo, mutta on pimeää etkä saa mitään selvää, mitä siinä lukee. Tiputat paperipallon lattialle.\n");
                            Console.ResetColor();
                            Jatka();
                            break;
                        case "KASSI":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Inventaario inventaario = new Inventaario();
                            Console.WriteLine(inventaario);
                            Console.ResetColor();
                           Jatka();
                            break;
                        case "H-HELP":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Heikki heikki = new Heikki();
                            heikki.Help();
                            Console.ResetColor();
                            Jatka();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Epäkelpo valinta.\n");
                            Console.ResetColor();
                            Jatka();
                            break;
                    }
                }
                else
                {
                        Console.WriteLine("Hawking-luokassa on pimeää. Pääset täältä hissikäytävään (A) tai C#-luokkaan (B).\n");
                        vastaus = Console.ReadLine();
                        vastaus = vastaus.ToUpper();
                        switch (vastaus)
                        {
                            case "A":
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Avaat oven hissikäytävään.\n");
                                Console.ResetColor();
                                Hissikaytava hissikaytava = new Hissikaytava();
                                hissikaytava.Avaa();
                                break;
                            case "B":
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Yrität avata ovea, mutta se on jostain syystä lukittu.\n");
                                Console.ResetColor();
                                Jatka();
                                break;
                            case "HALP":
                            case "HELP":
                                Help help = new Help();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(help);
                                Console.ResetColor();
                                Jatka();
                                break;
                            case "KARTTA":
                                Kartta kartta = new Kartta();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                kartta.KutsuKartta();
                                Console.ResetColor();
                                Jatka();
                                break;
                            case "H-HELP":
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Heikki heikki = new Heikki();
                                heikki.Help();
                                Console.ResetColor();
                                Jatka();
                                break;
                            case "TASKULAMPPU PÄÄLLE":
                            case "LAMPPU":
                            case "LAMPPU PÄÄLLE":
                            case "AVAA LAMPPU":
                            case "LAITA LAMPPU PÄÄLLE":
                                lamppu.Päällä();
                                ValoisaHawking();
                                break;
                            case "KYTKE LAMPPU PÄÄLLE":
                                lamppu.Päällä();
                                ValoisaHawking();
                                break;
                            
                            case "KASSI":
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Inventaario inventaario = new Inventaario();
                                Console.WriteLine(inventaario);
                                Console.ResetColor();
                                Jatka();
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Epäkelpo valinta.\n");
                                Console.ResetColor();
                                Jatka();
                                break;
                        }
                    }
            }
        }

        public void ValoisaHawking()
        {
            lamppu = new Hawking();
            lamppuPäällä = true;
            if (!Inventaario.esineet.Contains("CV"))
            {
                Console.WriteLine("Nyt on valoisaa ja näet möykyn selvästi lattialla. Pääset Hawking-luokasta hissikäytävään (A) tai C#-luokkaan (B).\n");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Avaat oven hissikäytävään.\n");
                        Console.ResetColor();
                        lamppu.PoisPäältä();
                        Hissikaytava hissikaytava = new Hissikaytava();
                        hissikaytava.Avaa();
                        break;
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Yrität avata ovea, mutta se on jostain syystä lukittu.\n");
                        Console.ResetColor();
                        ValoisaHawking();
                        break;
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
                        Console.ResetColor();
                        ValoisaHawking();
                        break;
                    case "H-HELP":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Heikki heikki = new Heikki();
                        heikki.Help();
                        Console.ResetColor();
                        ValoisaHawking();
                        break;
                    case "KARTTA":
                        Kartta kartta = new Kartta();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        kartta.KutsuKartta();
                        Console.ResetColor();
                        ValoisaHawking();
                        break;
                    case "SAMMUTA VALO":
                    case "SAMMUTA TASKULAMPPU":
                    case "SAMMUTA LAMPPU":
                        lamppu.PoisPäältä();
                        Jatka();
                        break;
                    case "OTA MÖYKKY":
                    case "TUTKI MÖYKKY":
                        Möykky();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        ValoisaHawking();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        ValoisaHawking();
                        break;
                }

            }
            else if (Game.java == 0)
            {
                Console.WriteLine("Taskulampun valossa katselet ympärillessi JAVA-luokkaa. Täällä on jotain jännää JAVA-koodia (jota et ymmärrä) kirjoitettu ympäri huonetta kaikille tussitaululle.\n" +
                    "Pääset Hawking-luokasta hissikäytävään (A) tai C#-luokkaan (B).\n");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Avaat oven hissikäytävään.\n");
                        Console.ResetColor();
                        lamppu.PoisPäältä();
                        Hissikaytava hissikaytava = new Hissikaytava();
                        hissikaytava.Avaa();
                        break;
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Yrität avata ovea, mutta se on jostain syystä lukittu.\n");
                        Console.ResetColor();
                        ValoisaHawking();
                        break;
                    case "POISTA KOODI":
                    case "PYYHI KOODI":
                    case "POISTA JAVA":
                    case "PYYHI":
                    case "PYYHI TAULU":
                    case "PYYHI TAULUT":
                        Game.java++;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Noin! Nyt on parempi!\n");
                        Console.ResetColor();
                        ValoisaHawking();
                        break;
                    case "SAMMUTA VALO":
                    case "SAMMUTA TASKULAMPPU":
                    case "SAMMUTA LAMPPU":
                        lamppu.PoisPäältä();
                        Jatka();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        ValoisaHawking();
                        break;
                    case "KARTTA":
                        Kartta kartta = new Kartta();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        kartta.KutsuKartta();
                        Console.ResetColor();
                        ValoisaHawking();
                        break;
                    case "H-HELP":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Heikki heikki = new Heikki();
                        heikki.Help();
                        Console.ResetColor();
                        ValoisaHawking();
                        break;
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
                        Console.ResetColor();
                        ValoisaHawking();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        ValoisaHawking();
                        break;
                }
            }

            else
            {
                Console.WriteLine("Taskulampun valossa katselet ympärillessi JAVA-luokkaa. Nyt ei ole enää JAVA-koodia häritsemässä ja voit taas keskittyä ollennaiseen.\n" +
                    "Pääset Hawking-luokasta hissikäytävään (A) tai C#-luokkaan (B).\n");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Avaat oven hissikäytävään.\n");
                        Console.ResetColor();
                        lamppu.PoisPäältä();
                        Hissikaytava hissikaytava = new Hissikaytava();
                        hissikaytava.Avaa();
                        break;
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Yrität avata ovea, mutta se on jostain syystä lukittu.\n");
                        Console.ResetColor();
                        ValoisaHawking();
                        break;
                    case "SAMMUTA VALO":
                    case "SAMMUTA TASKULAMPPU":
                    case "SAMMUTA LAMPPU":
                        lamppu.PoisPäältä();
                        Jatka();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        ValoisaHawking();
                        break;
                    case "KARTTA":
                        Kartta kartta = new Kartta();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        kartta.KutsuKartta();
                        Console.ResetColor();
                        ValoisaHawking();
                        break;
                    case "H-HELP":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Heikki heikki = new Heikki();
                        heikki.Help();
                        Console.ResetColor();
                        ValoisaHawking();
                        break;
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
                        Console.ResetColor();
                        ValoisaHawking();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        ValoisaHawking();
                        break;
                }
            }

        }

        public void Möykky()
        {
            Console.WriteLine("Poimit paperipallon maasta, rullaat sen auki ja ihmettelet sen sisältöä lampun valossa.\n");
            Console.Write("'Tulin, näin voitin...' Kyseessä on Julius Caesarin ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("CV!!\n");
            Console.ResetColor();

            Console.WriteLine("Perin omituista, mutta todennäköisesti hyödyllistä.");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();
            switch (vastaus)
            {
                case "OTA JULIUS CAESARIN CV":
                case "OTA CV":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("CV lisätty Academy-kassiin.\n");
                    Inventaario inventaario = new Inventaario();
                    inventaario.LisaaEsine(esine);
                    Console.ResetColor();
                    ValoisaHawking();
                    break;
                case "LISÄÄ JULIUS CAESARIN CV":
                case "LISÄÄ CV":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("CV lisätty Academy-kassiin.\n");
                    Inventaario inventaario2 = new Inventaario();
                    inventaario2.LisaaEsine(esine);
                    Console.ResetColor();
                    ValoisaHawking();
                    break;
                case "SAMMUTA VALO":
                case "SAMMUTA TASKULAMPPU":
                case "SAMMUTA LAMPPU":
                    lamppu.PoisPäältä();
                    Jatka();
                    break;
                case "HALP":
                case "HELP":
                    Help help = new Help();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(help);
                    Console.ResetColor();
                    Möykky();
                    break;
                case "KARTTA":
                    Kartta kartta = new Kartta();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    kartta.KutsuKartta();
                    Console.ResetColor();
                    Möykky();
                    break;
                case "H-HELP":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Heikki heikki = new Heikki();
                    heikki.Help();
                    Console.ResetColor();
                    Möykky();
                    break;
                case "KASSI":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Inventaario inventaario3 = new Inventaario();
                    Console.WriteLine(inventaario3);
                    Console.ResetColor();
                    Möykky();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Epäkelpo valinta.\n");
                    Console.ResetColor();
                    Möykky();
                    break;
            }
        }

        public void PoisPäältä()
        {
            lamppuPäällä = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Taskulamppu sammui");
            Console.ResetColor();
        }

        public void Päällä()
        {
            lamppuPäällä = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Taskulamppu on päällä\n");
            Console.ResetColor();
        }
    }
}
