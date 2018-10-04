using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Peliluokkia
{

    //Avaa-metodi pohjautuen muihin huoneisiin -ES
    public class Hopper: ILamppu
    {
        //Avaa-metodi pohjautuen muihin huoneisiin -ES Lisätty lamppu rajapinnan toteutus ja tarkistus, onko pelaajalla lammpua.
        string vastaus;

        private bool lamppuPäällä = false;



        public bool LamppuPäällä
        {
            get
            {
                return lamppuPäällä;
            }
        }

        Hopper lamppu;
        public void Avaa()
        {
            Console.WriteLine("Olet Hopper-huoneessa. Ikkunasta näkyy kuun valoa, jonka avulla näet, että fläppitaulun nurkkaan on kirjoitettu jotakin. Voisi olla hyötyä saada teksti luettua...\nVoit myös halutessasi palata takaisin käytävään(A).\n\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();
            lamppu = new Hopper();
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
                    case "LAMPPU":
                        lamppu.Päällä();
                        ValoisaHuone();
                        break;
                    case "LUE FLÄPPITAULU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("On pimeää, etkä näe, mitä taululla lukee.\n");
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
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Pahoittelut, en saanut selvää.\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                }
            }

            else
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
                    case "LAMPPU PÄÄLLE":
                    case "TASKULAMPPU PÄÄLLE":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Sinulla ei ole lamppua.\n");
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
                    case "LUE FLÄPPITAULU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("On pimeää, etkä näe, mitä taululla lukee.\n");
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
                        Console.WriteLine("En ymmärrä sinua :(\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                }

            }

        }




        public void ValoisaHuone()
        {
            Console.WriteLine("Nyt näet fläppitaulun ja pystyt lukemaan tekstin: 'Do or do not. There is no try...'.\n'Mitä ihmettä, ei kyllä tästäkään ole mitään hyötyä...', ajattelet ääneen.\n" +
                "Voit halutessasi palata takaisin käytävään (A)");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();
            Kaytava kaytava = new Kaytava();

            switch (vastaus)
            {
                case "A":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Siirryt takaisin käytävään.\n");
                    Console.ResetColor();
                    lamppu.PoisPäältä();
                    kaytava.Avaa();
                    break;
                case "SAMMUTA VALO":
                case "SAMMUTA TASKULAMPPU":
                case "SAMMUTA LAMPPU":
                    lamppu.PoisPäältä();
                    Avaa();
                    break;
                case "YODA":
                    lamppu.PoisPäältä();
                    Console.WriteLine("Pimeässä huoneessa kuuluu kummia...\n");
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("'Patience you must have, my young padawan.'\n");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("'Clear your mind must be, if you are to find the villains behind this plot.'\n");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("'Bye, bye'\n");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Nämä syvälliset sanat antavat sinulle ajattelemisen (ja ehkä vähän huolen) aihetta ja samalla työnnyt takaisin käytävään.\n\n");
                    Console.ResetColor();
                    kaytava.Avaa();
                    break;
                case "KASSI":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Inventaario inventaario = new Inventaario();
                    Console.WriteLine(inventaario);
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
