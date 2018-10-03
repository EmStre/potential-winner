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



        public void Avaa()
        {
            Love lamppu = new Love();
            Console.WriteLine("Olet Lovelace-neuvotteluhuoneessa.\nPimeässä näet flappitaulun, johon on kirjoitettu jotakin, mutta et saa kirjoituksesta selvää, koska on PIMEÄÄ. Voit halutessasi palata takaisin käytävään (A)");
            
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();


            while (vastaus != "A")
            {
                string[] lause = vastaus.Split(' ');

                if (lause.Length == 2 || lause.Length == 3)
                {
                    if ((lause[0].Contains("AVAA") && lause[1].Contains("LAMPPU")) || (lause[0].Contains("LAITA") && lause[1].Contains("LAMPPU") && lause[2].Contains("PÄÄL")))
                    {

                        lamppu.Päällä();
                        //   Console.WriteLine(lamppu.LamppuPäällä);

                        Console.WriteLine("Nyt näet fläppitaulun ja huomaat, että ahkerat opiskelijat ovat pelanneet risti-nollaa... Voit halutessasi palata takaisin käytävään (A)");
                        string vastaus2 = Console.ReadLine();
                        vastaus2 = vastaus2.ToUpper();
                        switch (vastaus2)
                        {
                            case "A":
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Siirryt takaisin käytävään.");
                                Console.ResetColor();
                                Kaytava kaytava = new Kaytava();
                                kaytava.Avaa();
                                break;
                            case "KASSI":
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Inventaario inventaario = new Inventaario();
                                Console.WriteLine(inventaario);
                                Console.ResetColor();
                                Avaa();
                                break;

                            default:
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("En ymmärrä sinua o: palataan alkuun");
                                Console.ResetColor();
                                Avaa();
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Huoneessa on edelleeen pimeää. Näet, että fläppitaululle on kirjoitettu asioita, mutta et saa niistä selvää. Voit halutessasi palata takaisin käytävään (A)");
                        vastaus = Console.ReadLine();
                        vastaus = vastaus.ToUpper();
                        switch (vastaus)
                        {
                            case "A":
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Siirryt takaisin käytävään.");
                                Console.ResetColor();
                                Kaytava kaytava = new Kaytava();
                                kaytava.Avaa();
                                break;
                            case "KASSI":
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Inventaario inventaario = new Inventaario();
                                Console.WriteLine(inventaario);
                                Console.ResetColor();
                                Avaa();
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("En ymmärrä sinua o: aloitetaan alusta");
                                Console.ResetColor();
                                Avaa();
                                break;
                        }

                    }

                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("En ymmärrä sinua :( ");
                    Console.WriteLine("On pimeää... Voit halutessasi palata takaisin käytävään (A)");
                    Console.ResetColor();
                    vastaus = Console.ReadLine();
                    vastaus = vastaus.ToUpper();
                    switch (vastaus)
                    {
                        case "A":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Siirryt takaisin käytävään.");
                            Console.ResetColor();
                            Kaytava kaytava = new Kaytava();
                            kaytava.Avaa();
                            break;
                        case "KASSI":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Inventaario inventaario = new Inventaario();
                            Console.WriteLine(inventaario);
                            Console.ResetColor();
                            Avaa();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("En ymmärrä sinua :( ");
                            Console.ResetColor();
                            Avaa();
                            break;
                    }
                }
            }


            switch (vastaus)
            {
                 case "A":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Siirryt takaisin käytävään.");
                    Console.ResetColor();
                    Kaytava kaytava = new Kaytava();
                    kaytava.Avaa();
                    break;
                case "KASSI":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Inventaario inventaario = new Inventaario();
                    Console.WriteLine(inventaario);
                    Console.ResetColor();
                    Avaa();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("En ymmärrä sinua");
                    Console.ResetColor();
                    Avaa();
                    break;
            }

        }

      


        public void PoisPäältä()
        {
            lamppuPäällä = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sammutit taskulampun.");
            Console.ResetColor();
        }

        public void Päällä()
        {
            lamppuPäällä = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Taskulamppu on päällä.");
            Console.ResetColor();
        }
    }
}
