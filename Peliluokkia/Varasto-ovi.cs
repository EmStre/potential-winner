using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    public class VarastoOvi : ILamppu
    {
        string vastaus;
        private bool lamppuPäällä = false;

        public bool LamppuPäällä
        {
            get
            {
                return lamppuPäällä;
            }
        }

        VarastoOvi lamppu;
        public void Avaa()
        {
            Console.WriteLine("Muistat Maisan kertoneen, että varastossa on sähkökaappi, joka käynnistää Academyn generaattorin tarjoten sähköä oleellisimmille toiminoille.\n " +
                "Voisi olla hyödyllistä saada sähköt päälle.\n");
            Jatka();

        }
        public void Jatka()
        {
            lamppu = new VarastoOvi();
            if(Inventaario.esineet.Contains("CV") && Inventaario.esineet.Contains("vihko") && Inventaario.esineet.Contains("fläppitaulu"))
            {
                Console.WriteLine("Koodi on 7-numeroinen ja sinulla on kaikki esineet, joden avulla voit saada oven auki.. On kuitenkin melko pimeää!\nVoit toki halutessasi palata" +
                    "tutkimaan käytää (A).");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Tarkastelet taas käytävää.\n");
                        Console.ResetColor();
                        Kaytava kaytava = new Kaytava();
                        kaytava.Avaa();
                        break;
                    case "TASKULAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        ValoisaOvi();
                        break;
                    case "LAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        ValoisaOvi();
                        break;
                    case "AVAA LAMPPU":
                        lamppu.Päällä();
                        ValoisaOvi();
                        break;
                    case "LAITA LAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        ValoisaOvi(); 
                        break;
                    case "KYTKE LAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        ValoisaOvi();
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
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        Jatka();
                        break;
                }
            }

            else if ((!Inventaario.esineet.Contains("CV") && Inventaario.esineet.Contains("vihko") && Inventaario.esineet.Contains("fläppitaulu")) || (Inventaario.esineet.Contains("CV") && !Inventaario.esineet.Contains("vihko") && Inventaario.esineet.Contains("fläppitaulu")) || (Inventaario.esineet.Contains("CV") && Inventaario.esineet.Contains("vihko") && !Inventaario.esineet.Contains("fläppitaulu")))
            {
                Console.WriteLine("Sinulta puuttuu yksi esine. Et voi saadaa ovea auki ilman sitä. Jatka etsimistä.\nMuistathan lisätä löytämäsi esineet kassiin.\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Tarkastelet taas käytävää.\n");
                Console.ResetColor();
                Kaytava kaytava = new Kaytava();
                kaytava.Avaa();
                
            }
            else if ((!Inventaario.esineet.Contains("CV") && !Inventaario.esineet.Contains("vihko") && Inventaario.esineet.Contains("fläppitaulu")) || (Inventaario.esineet.Contains("CV") && !Inventaario.esineet.Contains("vihko") && !Inventaario.esineet.Contains("fläppitaulu")) || (!Inventaario.esineet.Contains("CV") && Inventaario.esineet.Contains("vihko") && !Inventaario.esineet.Contains("fläppitaulu")))
            {
                Console.WriteLine("Sinulta puuttuu esineitä. Et voi saadaa ovea auki ilman niitä. Jatkahan etsimistä.\nMuistathan lisätä löytämäsi esineet kassiin.\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Tarkastelet taas käytävää.\n");
                Console.ResetColor();
                Kaytava kaytava = new Kaytava();
                kaytava.Avaa();
            }
            else if (!Inventaario.esineet.Contains("CV") && !Inventaario.esineet.Contains("vihko") && !Inventaario.esineet.Contains("fläppitaulu"))
            {
                Console.WriteLine("Sinulta puuttuu KAIKKI esineet. Yritäppäs löytää ne!");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Tarkastelet taas käytävää.\n");
                Console.ResetColor();
                Kaytava kaytava = new Kaytava();
                kaytava.Avaa();
            }
        }

        public void ValoisaOvi()
        {
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();

        }

        public void PoisPäältä()
        {
            lamppuPäällä = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Taskulamppu sammui.\n");
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
