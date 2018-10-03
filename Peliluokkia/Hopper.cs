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
            Console.WriteLine("Olet Hopper-huoneessa. Ikkunasta näkyy kuun valoa, jonka avaulla näet, että fläppitaulun nurkkaan on kirjoitettu jotakin. Voisi olla hyötyä, saada teksti luettua...\nVoit myös halutessasi palata takaisin käytävään(A).\n\n");
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
                        lamppu.Päällä();
                        ValoisaHuone();
                        break;
                    case "LAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        ValoisaHuone();
                        break;
                    case "AVAA LAMPPU":
                        lamppu.Päällä();
                        ValoisaHuone();
                        break;
                    case "LAITA LAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        ValoisaHuone();
                        break;
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
                        Console.WriteLine("En ymmärrä sinua :(\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                }

            }

        }




        public void ValoisaHuone()
        {
            Console.WriteLine("Nyt näet fläppitaulun ja pystyt lukemaan tekstin: 'Do or do not. There is no try...'.\n 'Mitä ihmettä, ei tästäkään mitään hyötyä', ajattelet ääneen.\nVoit halutessasi palata takaisin käytävään (A)");
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
                case "YODA":
                    lamppu.PoisPäältä();
                    Console.WriteLine("Pimeässä huoneessa kuuluu kummia...\n");
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("'Patience you must have, my young padawan.'");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("'Clear your mind must be, if you are to find the villains behind this plot.'");
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
