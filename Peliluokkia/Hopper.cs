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
            Console.WriteLine("Olet Hopper-huoneessa.\nIkkunasta näkyy kuun valoa, jonka avaulla näet, että fläppitaulun nurkkaan on kirjoitettu jotakin. Voisi olla hyötyä, saada teksti luettua... Voit myös halutessasi palata takaisin käytävään(A)");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();
            lamppu = new Hopper();
            if (Inventaario.esineet.Contains("taskulamppu"))
            {

                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Siirryt takaisin käytävään.");
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
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Pahoittelut, en saanut selvää.");
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
                        Console.WriteLine("Siirryt takaisin käytävään.");
                        Kaytava kaytava = new Kaytava();
                        kaytava.Avaa();
                        break;
                    case "LAMPPU PÄÄLLE":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Sinulla ei ole lamppua");
                        Avaa();
                        break;
                    case "TASKULAMPPU PÄÄLLE":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Sinulla ei ole lamppua");
                        Avaa();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("En ymmärrä sinua :(");
                        Avaa();
                        break;
                }

            }

        }




        public void ValoisaHuone()
        {
            Console.WriteLine("Nyt näet fläppitaulun ja pystyt lukemaan tekstin: 'Do or do not. There is no try...'.\n 'Mitä ihmettä, ei tästäkään mitään hyötyä', ajattelet ääneen. Voit halutessasi palata takaisin käytävään (A)");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();
            Kaytava kaytava = new Kaytava();

            switch (vastaus)
            {
                case "A":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Siirryt takaisin käytävään.");
                    lamppu.PoisPäältä();
                    kaytava.Avaa();
                    break;
                case "SAMMUTA LAMPPU":
                    lamppu.PoisPäältä();
                    Avaa();
                    break;
                case "YODA":
                    lamppu.PoisPäältä();
                    Console.WriteLine("Pimeässä huoneessa kuuluu kummia...");
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("'Patience you must have, my young padawan.'");
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("'Clear your mind must be, if you are to find the villains behind this plot.'");
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Nämä syvälliset sanat antavat sinulle ajattelemisen (ja ehkä vähän huolen) aihetta ja samalla työnnyt takaisin käytävään.");
                    kaytava.Avaa();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("En ymmärrä sinua :(");
                    ValoisaHuone();
                    break;


            }
        }


        public void PoisPäältä()
        {
            lamppuPäällä = false;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Taskulamppu sammui");
        }

        public void Päällä()
        {
            lamppuPäällä = true;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Taskulamppu on päällä");
        }
    }
}
