using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    //Lisätty taskulamppu ja fläpptaulun nouto
    public class Torvalds : ILamppu
    {
        string vastaus;
        private bool lamppuPäällä = false;
        string esine = "fläppitaulu";

        public bool LamppuPäällä
        {
            get
            {
                return lamppuPäällä;
            }
        }

        Torvalds lamppu;

        public void Avaa()
        {
            Console.WriteLine("Astut sisään Torvalds-huoneeseen. Siirryt ikkunaa kohti.\n");
            Jatka();
        }


        public void Jatka()
        {
            lamppu = new Torvalds();


            if (Inventaario.esineet.Contains("taskulamppu") && !Inventaario.esineet.Contains("fläppitaulu"))
            {
                Console.WriteLine("Kävellessäsi melkein kompastut fläppitauluun. Taulussa on tekstiä, mutta et saa siitä selvää, koska on liian pimeää. Takanasi on ovi takaisin hissikäytävään (A).\n");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Astut takaisin hissikäytävään.\n");
                        Console.ResetColor();
                        Hissikaytava hissikaytava = new Hissikaytava();
                        hissikaytava.Avaa();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "LAMPPU":
                    case "OTA LAMPPU":
                    case "TASKULAMPPU PÄÄLLE":
                    case "LAMPPU PÄÄLLE":
                    case "AVAA LAMPPU":
                    case "LAITA LAMPPU PÄÄLLE":
                    case "KYTKE LAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        ValoisaTorvalds();
                        break;
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
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
                    case "KARTTA":
                        Kartta kartta = new Kartta();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        kartta.KutsuKartta();
                        Console.ResetColor();
                        Jatka();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                }
            }
            else if (Inventaario.esineet.Contains("taskulamppu") && Inventaario.esineet.Contains("fläppitaulu"))
            {
                Console.WriteLine("Tarkastelet Torvalds-huonetta pimeässä.\n" +
                   "Vietyäsi fläppitaulun, huone on melko tyhjä. Takanasi on ovi takaisin hissikäytävään (A).\n");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Astut takaisin hissikäytävään.\n");
                        Console.ResetColor();
                        Hissikaytava hissikaytava = new Hissikaytava();
                        hissikaytava.Avaa();
                        break;
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
                    case "OTA LAMPPU":
                    case "LAMPPU":
                    case "TASKULAMPPU PÄÄLLE":
                    case "LAMPPU PÄÄLLE":
                    case "AVAA LAMPPU":
                    case "LAITA LAMPPU PÄÄLLE":
                    case "KYTKE LAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        ValoisaTorvalds();
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
                Console.WriteLine("Taulussa on tekstiä, mutta et saa siitä selvää, koska on liian pimeää. Takanasi on ovi takaisin hissikäytävään (A).\n");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Astut takaisin hissikäytävään.\n");
                        Console.ResetColor();
                        Hissikaytava hissikaytava = new Hissikaytava();
                        hissikaytava.Avaa();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "LAMPPU":
                    case "LAMPPU PÄÄLLE":
                    case "OTA LAMPPU":
                    case "AVAA LAMPPU":
                    case "TASKULAMPPU PÄÄLLE":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Sinulla ei ole lamppua.\n");
                        Console.ResetColor();
                        Avaa();
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
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        Jatka();
                        break;
                }
            }
        }


        public void ValoisaTorvalds()
        {
            lamppu = new Torvalds();

            if (!Inventaario.esineet.Contains("fläppitaulu"))
            {
                Console.WriteLine("Tarkastelet Torvalds-huonetta taskulampun valossa.\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Fläppitaulussa");
                Console.ResetColor();
                Console.WriteLine("oleva teksti paljastuukin hyvin rivoksi, kahta henkilöä esittäväksi kuvaksi, jonka seurauksena mieleesi juolahtaa kaksinumeroinen luku. \n" +
                    "Kenties tästäkin voisi olla hyötyä... Takanasi on ovi takaisin hissikäytävään (A).\n");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Astut takaisin hissikäytävään.\n");
                        Console.ResetColor();
                        lamppu.PoisPäältä();
                        Hissikaytava hissikaytava = new Hissikaytava();
                        hissikaytava.Avaa();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        ValoisaTorvalds();
                        break;
                    case "H-HELP":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Heikki heikki = new Heikki();
                        heikki.Help();
                        Console.ResetColor();
                        ValoisaTorvalds();
                        break;
                    case "SAMMUTA VALO":
                    case "SAMMUTA TASKULAMPPU":
                    case "SAMMUTA LAMPPU":
                        lamppu.PoisPäältä();
                        Jatka();
                        break;
                    case "OTA FLÄPPITAULU":
                    case "LISÄÄ FLÄPPITAULU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Fläppitaulu lisätty Academy-kassiin.\n");
                        Inventaario inventaario3 = new Inventaario();
                        inventaario3.LisaaEsine(esine);
                        Console.ResetColor();
                        ValoisaTorvalds();
                        break;
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
                        Console.ResetColor();
                        ValoisaTorvalds();
                        break;
                    case "KARTTA":
                        Kartta kartta = new Kartta();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        kartta.KutsuKartta();
                        Console.ResetColor();
                        ValoisaTorvalds();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        ValoisaTorvalds();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Tarkastelet Torvalds-huonetta taskulampun valossa.\n" +
                    "Vietyäsi fläppitaulun, huone on melko tyhjä. Takanasi on ovi takaisin hissikäytävään (A).\n");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Astut takaisin hissikäytävään.\n");
                        Console.ResetColor();
                        lamppu.PoisPäältä();
                        Hissikaytava hissikaytava = new Hissikaytava();
                        hissikaytava.Avaa();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        ValoisaTorvalds();
                        break;
                    case "H-HELP":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Heikki heikki = new Heikki();
                        heikki.Help();
                        Console.ResetColor();
                        ValoisaTorvalds();
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
                        ValoisaTorvalds();
                        break;
                    case "KARTTA":
                        Kartta kartta = new Kartta();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        kartta.KutsuKartta();
                        Console.ResetColor();
                        ValoisaTorvalds();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        ValoisaTorvalds();
                        break;
                }
            }

        }

        public void PoisPäältä()
        {
            lamppuPäällä = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Taskulamppu sammui\n");
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
