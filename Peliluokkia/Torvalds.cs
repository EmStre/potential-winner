﻿using System;
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
        string esine;

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
            lamppu = new Torvalds();


            if (Inventaario.esineet.Contains("taskulamppu") && !Inventaario.esineet.Contains("fläppitaulu"))
            {
                Console.WriteLine("Astut sisään Torvalds-huoneeseen. Siirryt ikkunaa kohti ja melkein kompastut fläppitauluun.\n" +
                    "Taulussa on tekstiä, mutta et saa siitä selvää, koska on liian pimeää. Takanasi on ovi takaisin hissikäytävään (A).\n");
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
                    case "TASKULAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        ValoisaTorvalds();
                        break;
                    case "LAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        ValoisaTorvalds();
                        break;
                    case "AVAA LAMPPU":
                        lamppu.Päällä();
                        ValoisaTorvalds();
                        break;
                    case "LAITA LAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        ValoisaTorvalds();
                        break;
                    case "KYTKE LAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        ValoisaTorvalds();
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
                    case "TASKULAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        ValoisaTorvalds();
                        break;
                    case "LAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        ValoisaTorvalds();
                        break;
                    case "AVAA LAMPPU":
                        lamppu.Päällä();
                        ValoisaTorvalds();
                        break;
                    case "LAITA LAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        ValoisaTorvalds();
                        break;
                    case "KYTKE LAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        ValoisaTorvalds();
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
                Console.WriteLine("Astut sisään Torvalds-huoneeseen. Siirryt ikkunaa kohti ja melkein kompastut fläppitauluun.\n" +
                   "Taulussa on tekstiä, mutta et saa siitä selvää, koska on liian pimeää. Takanasi on ovi takaisin hissikäytävään (A).\n");
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
                    case "LAMPPU PÄÄLLE":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Sinulla ei ole lamppua.\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "TASKULAMPPU PÄÄLLE":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Sinulla ei ole lamppua.\n");
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


        public void ValoisaTorvalds()
        {
            lamppu = new Torvalds();

            if (!Inventaario.esineet.Contains("fläppitaulu"))
            {
                Console.WriteLine("Tarkastelet Torvalds-huonetta taskulampun valossa.\n" +
                    "Fläppitaulussa oleva teksti paljastuukin hyvin eksplisiittiseksi kuvaksi, jonka seurauksena mieleesi juolahtaa kaksinumeroinen luku. \nKenties tästäkin voisi olla hyötyä... Takanasi on ovi takaisin hissikäytävään (A).\n");
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
                    case "OTA FLÄPPITAULU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Fläppitaulu lisätty Academy-kassiin.\n");
                        Inventaario inventaario2 = new Inventaario();
                        inventaario2.LisaaEsine(esine);
                        Console.ResetColor();
                        ValoisaTorvalds();
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
                Console.WriteLine("Tarkastelet Torvalds-huonetta taskunlampun valossa.\n" +
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
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        Avaa();
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
