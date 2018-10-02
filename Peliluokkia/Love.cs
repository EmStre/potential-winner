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
            Console.WriteLine("Astut sisään Lovelace-neuvotteluhuoneeseen.\n Pimeässä näet flappitaulun, johon on kirjoitettu jotakin, mutta et saa kirjoituksesta selvää pimeässä. Voit halutessasi palata takaisin käytävään (A)");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            Love lamppu = new Love();

            while (vastaus != "A")
            {
             string [] lause = vastaus.Split(' ');

                if (lause.Length == 2 || lause.Length == 3)
                {
                    if ((lause[0].Contains("AVAA") && lause[1].Contains("LAMPPU")) || (lause[0].Contains("LAITA") && lause[1].Contains("LAMPPU") && lause[2].Contains("PÄÄL")))
                    {

                        lamppu.Päällä();
                        Console.WriteLine(lamppu.LamppuPäällä);

                        Console.WriteLine("Nyt näet fläppitaulun ja huomaat, että ahkerat opiskelijat ovat pelanneet risti-nollaa... Voit halutessasi palata takaisin käytävään (A)");
                        string vastaus2 = Console.ReadLine();
                        vastaus2 = vastaus2.ToUpper();
                        switch (vastaus2)
                        {
                            case "A":
                                Console.WriteLine("Siirryt takaisin käytävään.");
                                Kaytava kaytava = new Kaytava();
                                kaytava.Avaa();
                                break;

                            default:
                                Console.WriteLine("En ymmärrä sinua o: palataan alkuun");
                                Avaa();
                                break;


                        }



                    }
                    else
                    {
                        Console.WriteLine("Huoneessa on pimeää. Näet, että fläppitaululle on kirjoitettu asioita, mutta et saa niistä selvää. Voit halutessasi palata takaisin käytävään (A)");
                        vastaus = Console.ReadLine();
                        vastaus = vastaus.ToUpper();
                        switch (vastaus)
                        {
                            case "A":
                                Console.WriteLine("Siirryt takaisin käytävään.");
                                Kaytava kaytava = new Kaytava();
                                kaytava.Avaa();
                                break;
                            default:
                                Console.WriteLine("En ymmärrä sinua o: aloitataan alusata");
                                Avaa();
                                break;
                        }

                    }

                }

                else
                {
                    Console.WriteLine("En ymmärrä sinua :( ");
                    Console.WriteLine("On pimeää... Voit halutessasi palata takaisin käytävään (A)");
                    vastaus = Console.ReadLine();
                    vastaus = vastaus.ToUpper();
                    switch (vastaus)
                    {
                        case "A":
                            Console.WriteLine("Siirryt takaisin käytävään.");
                            Kaytava kaytava = new Kaytava();
                            kaytava.Avaa();
                            break;
                        default:
                            Console.WriteLine("En ymmärrä sinua o: Aloitetaan alusta");
                            Avaa();
                            break;
                    }
                }
            }


            switch (vastaus)
            {
                 case "A":

                    Console.WriteLine("Siirryt takaisin käytävään.");
                    Kaytava kaytava = new Kaytava();
                    kaytava.Avaa();
                    break;
                default:
                    Console.WriteLine("En ymmärrä sinua");
                    Avaa();
                    break;
            }
          
        }

        public void PoisPäältä()
        {
            lamppuPäällä = false;
            Console.WriteLine("Taskulamppu sammui");    
        }

        public void Päällä()
        {
            lamppuPäällä = true;
            Console.WriteLine("Taskulamppu on päällä");
        }
    }
}
