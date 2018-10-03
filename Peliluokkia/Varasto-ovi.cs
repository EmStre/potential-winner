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
                    "tutkimaan käytävää (A).");
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
                        Jatka();
                        break;
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
                        Console.ResetColor();
                       Jatka();
                        break;
                    case "KARTTA":
                        Kartta kartta = new Kartta();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        kartta.KutsuKartta();
                        Console.ResetColor();
                        Jatka();
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
                Console.WriteLine("Sinulta puuttuu yksi oven avaamiseen tarvittava esine. Jatka etsimistä.\nMuistathan lisätä löytämäsi esineet kassiin.\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Tarkastelet taas käytävää.\n");
                Console.ResetColor();
                Kaytava kaytava = new Kaytava();
                kaytava.Avaa();
                
            }
            else if ((!Inventaario.esineet.Contains("CV") && !Inventaario.esineet.Contains("vihko") && Inventaario.esineet.Contains("fläppitaulu")) || (Inventaario.esineet.Contains("CV") && !Inventaario.esineet.Contains("vihko") && !Inventaario.esineet.Contains("fläppitaulu")) || (!Inventaario.esineet.Contains("CV") && Inventaario.esineet.Contains("vihko") && !Inventaario.esineet.Contains("fläppitaulu")))
            {
                Console.WriteLine("Sinulta puuttuu esineitä, joita ilman et voi saadaa ovea auki. Jatkahan etsimistä.\nMuistathan lisätä löytämäsi esineet kassiin.\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Tarkastelet taas käytävää.\n");
                Console.ResetColor();
                Kaytava kaytava = new Kaytava();
                kaytava.Avaa();
            }
            else if (!Inventaario.esineet.Contains("CV") && !Inventaario.esineet.Contains("vihko") && !Inventaario.esineet.Contains("fläppitaulu"))
            {
                Console.WriteLine("Sinulta puuttuu KAIKKI oven avaamiseen tarvittavat esineet. Yritäppäs löytää ne!");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Tarkastelet taas käytävää.\n");
                Console.ResetColor();
                Kaytava kaytava = new Kaytava();
                kaytava.Avaa();
            }
        }

        public void ValoisaOvi()
        {
            lamppu = new VarastoOvi();
            int kokeilu = 0;
            kokeilu++;

            if (kokeilu == 1)
            {
                Console.WriteLine("Otat kassistasi fläppitaulun, vihkon ja CV:n\nNiiden avulla yrität keksiä 7-numeroisen koodin, jonka näppäilet lukon numeronäppäimistöön.\nHUOM! Järjestyksellä on väliä!\n");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "6910542":
                        Console.WriteLine("Tosi hyvä!! Ovi on auki!");
                        lamppu.PoisPäältä();
                        Varasto varasto = new Varasto();
                        varasto.Avaa();
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
                    case "VIHKO":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Selaat vihkoa:\n" +
                            "Vihkon yhdellä sivulla on lause: 'Varastoon pääsy kulminoituu osittain elämään, maailmankaikkeuteen ja kaikkeen muuhun sellaiseen liittyvän kysymyksen vastaukseen'\n");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "FLÄPPITAULU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Tutkit punastellen fläppitaulua, jolloin kuva mieeleesi aiemmin tuoma kaskisnumeroinen luku palaa ajatuksiisi\n");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "CV":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Julius Caesar ja CV...\n");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "KARTTA":
                        Kartta kartta = new Kartta();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        kartta.KutsuKartta();
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                }

            }
            else if (kokeilu < 20)
            {
                Console.WriteLine("Koodi oli väärin, yritä uudelleen!");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "6910542":
                        lamppu.PoisPäältä();
                        Varasto varasto = new Varasto();
                        varasto.Avaa();
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
                    case "VIHKO":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Selaat vihkoa:\n" +
                            "Vihkon yhdellä sivulla on lause: 'Varastoon pääsy kulminoituu osittain elämään, maailmankaikkeuteen ja kaikkeen muuhun sellaiseen liittyvän kysymyksen vastaukseen'\n");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "FLÄPPITAULU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Tutkit punastellen fläppitaulua, jolloin kuva mieeleesi aiemmin tuoma kaskisnumeroinen luku palaa ajatuksiisi\n");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "CV":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Julius Caesar ja CV...\n");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "KARTTA":
                        Kartta kartta = new Kartta();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        kartta.KutsuKartta();
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                }

            }
            else
            {
                Console.WriteLine("Koodi oli väärin, yritä uudelleen! Huomaa, että numeroiden oikea järjestys on fläppitaulu, CV ja vihko.");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "6910542":
                        lamppu.PoisPäältä();
                        Varasto varasto = new Varasto();
                        varasto.Avaa();
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
                    case "VIHKO":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Selaat vihkoa:\n" +
                            "Vihkon yhdellä sivulla on lause: 'Varastoon pääsy kulminoituu osittain elämään, maailmankaikkeuteen ja kaikkeen muuhun sellaiseen liittyvän kysymyksen vastaukseen'\n");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "FLÄPPITAULU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Tutkit punastellen fläppitaulua, jolloin kuva mieeleesi aiemmin tuoma kaskisnumeroinen luku palaa ajatuksiisi\n");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                    case "CV":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Julius Caesar ja CV...\n");
                        Console.ResetColor();
                        ValoisaOvi();
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
                        ValoisaOvi();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        ValoisaOvi();
                        break;
                }

            }
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
