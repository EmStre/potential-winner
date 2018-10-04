using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    //Avaa-metodi pohjautuen muihin huoneisiin -ES

    public class Jobs : ILamppu
    {
        //Avaa-metodi pohjautuen muihin huoneisiin -ES Lisätty lamppu rajapinnan toteutus
        string vastaus;
            int laskuri = 0;

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
            Console.WriteLine("Astut sisään Pixarin perustajan mukaan nimettyyn Jobs-huoneeseen.\nPimeässä näet fläppitaulun, jossa on kirjoitusta, mutta et saa kirjoituksesta selvää pimeässä. \nVoit halutessasi palata takaisin käytävään (A).\n");
            Jatka();
        }


        public void Jatka()
        {
            Jobs lamppu = new Jobs();
            laskuri++;
            if (laskuri != 1)
            {
                Console.WriteLine("Olet (B)Jobs-huoneessa.\nPimeässä näet fläppitaulun, jossa on kirjoitusta, mutta et saa kirjoituksesta selvää pimeässä. \nVoit halutessasi palata takaisin käytävään (A).");
            }
           
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();

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
                        Console.WriteLine("Nyt huomaat, että joku tylsistynyt konsultti on piirtänyt siihen rivoja kuvija. Silmiisi sattuu... \nVoit halutessasi palata takaisin käytävään (A)");
                        lamppu.PoisPäältä();
                        vastaus = Console.ReadLine();
                        vastaus = vastaus.ToUpper();
                        if (vastaus == "A")
                        {
                            Kaytava kaytava2 = new Kaytava();
                            kaytava2.Avaa();
                            break;
                        }
                        else
                        {
                            Jatka();
                            break;
                        }
                    case "AVAA TASKULAMPPU":
                    case "LAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        Console.WriteLine("Nyt huomaat, että joku tylsistynyt konsultti on piirtänyt siihen rivoja kuvija. Silmiisi sattuu... \nVoit halutessasi palata takaisin käytävään (A)");
                        lamppu.PoisPäältä();
                        vastaus = Console.ReadLine();
                        vastaus = vastaus.ToUpper();
                        if (vastaus == "A")
                        {
                            Kaytava kaytava2 = new Kaytava();
                            kaytava2.Avaa();
                            break;
                        }
                        else
                        {
                            Jatka();
                            break;
                        }
                    case "AVAA LAMPPU":
                        lamppu.Päällä();
                        Console.WriteLine("Nyt huomaat, että joku tylsistynyt konsultti on piirtänyt siihen rivoja kuvija. Silmiisi sattuu... \nVoit halutessasi palata takaisin käytävään (A)");
                        lamppu.PoisPäältä();
                        vastaus = Console.ReadLine();
                        vastaus = vastaus.ToUpper();
                        if (vastaus == "A")
                        {
                            Kaytava kaytava2 = new Kaytava();
                            kaytava2.Avaa();
                            break;
                        }
                        else
                        {
                            Jatka();
                            break;
                        }
                    case "LAITA LAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        Console.WriteLine("Nyt huomaat, että joku tylsistynyt konsultti on piirtänyt siihen rivoja kuvija. Silmiisi sattuu... \nVoit halutessasi palata takaisin käytävään (A)");
                        lamppu.PoisPäältä();
                        vastaus = Console.ReadLine();
                        vastaus = vastaus.ToUpper();
                        if (vastaus == "A")
                        {
                            Kaytava kaytava2 = new Kaytava();
                            kaytava2.Avaa();
                            break;
                        }
                        else
                        {
                            Jatka();
                            break;
                        }
                    case "KYTKE LAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        Console.WriteLine("Nyt huomaat, että joku tylsistynyt konsultti on piirtänyt siihen rivoja kuvija. Silmiisi sattuu... \nVoit halutessasi palata takaisin käytävään (A)");
                        lamppu.PoisPäältä();
                        vastaus = Console.ReadLine();
                        vastaus = vastaus.ToUpper();
                        if (vastaus == "A")
                        {
                            Kaytava kaytava2 = new Kaytava();
                            kaytava2.Avaa();
                            break;
                        }
                        else
                        {
                            Jatka();
                            break;
                        }
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "H-HELP":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Heikki heikki = new Heikki();
                        heikki.Help();
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
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
                        Console.ResetColor();
                        Jatka();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("En ymmärrä sinua :(\n");
                        Console.ResetColor();
                        Jatka();
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
                    case "AVAA LAMPPU":
                    case "AVAA TASKULAMPPU":
                    case "LAMPPU PÄÄLLE":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Sinulla ei ole lamppua.\n");
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "TASKULAMPPU PÄÄLLE":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Sinulla ei ole lamppua.\n");
                        Console.ResetColor();
                        Jatka();
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
                    case "H-HELP":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Heikki heikki = new Heikki();
                        heikki.Help();
                        Console.ResetColor();
                        Jatka();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("En ymmärrä sinua :(\n");
                        Console.ResetColor();
                        Jatka();
                        break;
                }

            }

        }


    

    public void ValoisaHuone()
    {

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
