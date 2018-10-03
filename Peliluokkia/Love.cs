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
            Console.WriteLine("Olet Lovelace-neuvotteluhuoneessa.\nPimeässä näet flappitaulun, johon on kirjoitettu jotakin, mutta et saa kirjoituksesta selvää, koska on PIMEÄÄ.Voit halutessasi palata takaisin käytävään(A)");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();
            lamppu = new Love();
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
                        Console.WriteLine("En ymmärrä sinua :(");
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
            Console.WriteLine("Nyt näet fläppitaulun ja huomaat, että ahkerat konsultit ovat pelanneet risti-nollaa ja risteillä pelannut henkilö on voittanut joka kerta. Voit halutessasi palata takaisin käytävään (A)");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Siirryt takaisin käytävään.");
                    Kaytava kaytava = new Kaytava();
                    kaytava.Avaa();
                    break;
                case "SAMMUTA LAMPPU":
                    lamppu.PoisPäältä();
                    Avaa();
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
