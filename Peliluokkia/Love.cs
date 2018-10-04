using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    public class Love : ILamppu
    {
        //Avaa-metodi pohjautuen muihin huoneisiin -ES Lisätty lamppu rajapinnan toteutus
        string vastaus;
        private bool lamppuPäällä = false;   
        public bool LamppuPäällä
        {
            get
            {
                return lamppuPäällä;
            }
        }
        Love lamppu;
        public void Avaa()
        {
            Console.WriteLine("Olet Lovelace-neuvotteluhuoneessa.\n" +
                "Pimeässä näet fläppitaulun, johon on kirjoitettu jotakin, mutta et saa kirjoituksesta selvää, koska on PIMEÄÄ.\n" +
                "Voit halutessasi palata takaisin käytävään (A)");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();
            lamppu = new Love();
            if (Inventaario.esineet.Contains("taskulamppu"))
            {
                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Siirryt takaisin käytävään.\n");
                        Console.ResetColor();
                        Kaytava kaytava = new Kaytava();
                        kaytava.Avaa();
                        break;
                    case "TASKULAMPPU PÄÄLLE":
                    case "LAMPPU PÄÄLLE":
                    case "AVAA LAMPPU":
                    case "LAITA LAMPPU PÄÄLLE":
                    case "KYTKE LAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        ValoisaHuone();
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
                    case "H-HELP":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Heikki heikki = new Heikki();
                        heikki.Help();
                        Console.ResetColor();
                        Avaa();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("En ymmärrä sinua :(\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                }
            }
            else
            {
            switch(vastaus)
                    {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Siirryt takaisin käytävään.\n");
                        Console.ResetColor();
                        Kaytava kaytava = new Kaytava();
                        kaytava.Avaa();
                        break;
                    case "AVAA LAMPPU":
                    case "LAMPPU":
                    case "LAMPPU PÄÄLLE":
                    case "AVAA TASKULAMPPU":
                    case "TASKULAMPPU PÄÄLLE":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Sinulla ei ole lamppua\n");
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
                        Console.WriteLine("En ymmärrä sinua :(\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                }
            }
        }
        public void ValoisaHuone()
        {
            Console.WriteLine("Nyt näet fläppitaulun ja huomaat, että ahkerat konsultit ovat pelanneet risti-nollaa ja risteillä pelannut henkilö on voittanut joka kerta. \n" +
                "Voit halutessasi palata takaisin käytävään (A)");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();
            switch (vastaus)
            {
                case "A":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Siirryt takaisin käytävään.\n");
                    Console.ResetColor();
                    Kaytava kaytava = new Kaytava();
                    lamppu.PoisPäältä();
                    kaytava.Avaa();
                    break;
                case "SAMMUTA VALO":
                case "SAMMUTA TASKULAMPPU":
                case "SAMMUTA LAMPPU":
                    lamppu.PoisPäältä();
                    Avaa();
                    break;
                case "KASSI":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Inventaario inventaario = new Inventaario();
                    Console.ResetColor();
                    Console.WriteLine(inventaario);
                    Console.ResetColor();
                    ValoisaHuone();
                    break;
                case "OTA TAULU":
                case "OTA FLÄPPITAULU":
                case "FLÄPPITAULU":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Et voi tehdä tälle mitään. Se on pultattu kiinni, eikä ole tusseja :( :\n");
                    Console.ResetColor();
                    ValoisaHuone();
                    break;
                case "HALP":
                case "HELP":
                    Help help = new Help();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(help);
                    Console.ResetColor();
                    ValoisaHuone();
                    break;
                case "KARTTA":
                    Kartta kartta = new Kartta();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    kartta.KutsuKartta();
                    Console.ResetColor();
                    ValoisaHuone();
                    break;
                case "H-HELP":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Heikki heikki = new Heikki();
                    heikki.Help();
                    Console.ResetColor();
                    ValoisaHuone();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("En ymmärrä sinua :(\n");
                    Console.ResetColor();
                    ValoisaHuone();
                    break;
            }
        }
        public void PoisPäältä()
        {
            lamppuPäällä = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sammutit taskulampun.\n");
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
