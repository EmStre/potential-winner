using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    public class Kaytava
    {
        string vastaus;
        public void Avaa()
        {
            if (!Inventaario.esineet.Contains("taskulamppu"))
            {
                Console.WriteLine("Sinulla on himmee hedari ja olet hämärässä käytävässä, jonka toisessa päässä on keittiö (A), toisessa porraskäytävä (B).\n" +
                "Lisäksi käytävän varrelta löytyy C#-ryhmän Hejlsberg-luokka (C), neuvotteluhuoneet Lovelace (D), Hopper (E), Jobs (F) ja Gosling (G) sekä konsolipelinurkkaus (H) ja varasto (I).");
            }
            else
            {
                Console.WriteLine("Olet hämärässä käytävässä, jonka toisessa päässä on keittiö (A), toisessa porraskäytävä (B).\n" +
               "Lisäksi käytävän varrelta löytyy C#-ryhmän Hejlsberg-luokka (C), neuvotteluhuoneet Lovelace (D), Hopper (E), Jobs (F) ja Gosling (G) sekä konsolipelinurkkaus (H) ja varasto (I).");
            }

                vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Lähdet kävelemään kohti keittiötä.\n");
                    Console.ResetColor();
                    Keittio keittio = new Keittio();
                    keittio.Avaa();
                    break;
                case "B":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Avaat käytävän perältä löytyvän hätäuloskäynnin oven porraskäytävään.\n");
                    Console.ResetColor();
                    Porraskaytava porraskaytava = new Porraskaytava();
                    porraskaytava.Avaa();
                    break;
                case "C":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Avaat ovat C#-ryhmän luokkaan.\n");
                    Console.ResetColor();
                    Hejlsberg hejlsberg = new Hejlsberg();
                    hejlsberg.Avaa();
                    break;
                case "D":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Avaat oven Lovelace-huoneeseen.");
                    Console.ResetColor();
                    Love love = new Love();
                    love.Avaa();
                    break;
                case "E":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Avaat oven Hopper-neukkariin");
                    Console.ResetColor();
                    Hopper hopper = new Hopper();
                    hopper.Avaa();
                    break;
                case "F":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Avaat oven Jobs-neukkariin");
                    Console.ResetColor();
                    Jobs jobs = new Jobs();
                    jobs.Avaa();
                    break;
                case "G":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Miksi haluaisit mennä Gosling-huoneeseen?? Eihän siellä edes koodata... Onneksesi näyttää siltä, että ovi on visusti kiinni! Huh!\n");
                    Console.ResetColor();
                    Avaa();
                    break;
                case "I":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Yllätykseksesi huomaat, että varaston ovi on lukittu ja siinä on koodilukko.\n");
                    Console.ResetColor();
                    VarastoOvi ovi = new VarastoOvi();
                    ovi.Avaa();
                    break;
                case "H":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Koska sähkö on poikki, pysyy pelikonsoli mykkänä.\n");
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
                        Console.WriteLine("Taskulamppu välähtää, mutta koska se on älykäs, se ymmärtää, ettet oikeasti halua käyttää sitä käytävässä...\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                    }
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
