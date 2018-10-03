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
            Console.WriteLine("Astut sisään Pixarin perustajan mukaan nimettyyn Jobs-huoneeseen.\nPimeässä näet flappitaulun, jossa on kirjoitusta, mutta et saa kirjoituksesta selvää pimeässä. \nVoit halutessasi palata takaisin käytävään (A).");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();
            Jobs lamppu = new Jobs();

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
                        Console.WriteLine("Nyt näe, että fläppitaululle on piirretty  huomaat, että joku tylsistynyt konsultti on piirtänyt siihen rivoja kuvija. Silmiisi sattuu... \nVoit halutessasi palata takaisin käytävään (A)");
                        lamppu.PoisPäältä();
                        vastaus = Console.ReadLine();
                        vastaus = vastaus.ToUpper();
                        Avaa();
                        break;
                    case "LAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        Console.WriteLine("Nyt näe, että fläppitaululle on piirretty  huomaat, että joku tylsistynyt konsultti on piirtänyt siihen rivoja kuvija. Silmiisi sattuu...\nVoit halutessasi palata takaisin käytävään (A)");
                        lamppu.PoisPäältä();
                        vastaus = Console.ReadLine();
                        vastaus = vastaus.ToUpper();
                        Avaa();
                        break;
                    case "AVAA LAMPPU":
                        lamppu.Päällä();
                        Console.WriteLine("Nyt näe, että fläppitaululle on piirretty  huomaat, että joku tylsistynyt konsultti on piirtänyt siihen rivoja kuvija. Silmiisi sattuu... \nVoit halutessasi palata takaisin käytävään (A)");
                        lamppu.PoisPäältä();
                        vastaus = Console.ReadLine();
                        vastaus = vastaus.ToUpper();
                        Avaa();
                        break;

                    case "LAITA LAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        Console.WriteLine("Nyt näe, että fläppitaululle on piirretty  huomaat, että joku tylsistynyt konsultti on piirtänyt siihen rivoja kuvija. Silmiisi sattuu... \nVoit halutessasi palata takaisin käytävään (A)");
                        lamppu.PoisPäältä();
                        vastaus = Console.ReadLine();
                        vastaus = vastaus.ToUpper();
                        Avaa();
                        break;

                    case "KYTKE LAMPPU PÄÄLLE":
                        lamppu.Päällä();
                        Console.WriteLine("Nyt huomaat, että joku tylsistynyt konsultti on piirtänyt siihen rivoja kuvija. Silmiisi sattuu... \nVoit halutessasi palata takaisin käytävään (A)");
                        lamppu.PoisPäältä();
                        vastaus = Console.ReadLine();
                        vastaus = vastaus.ToUpper();
                        Avaa();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        Avaa();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("En ymmärrä sinua :(\n");
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
                        Console.WriteLine("Sinulla ei ole lamppua\n");
                        Console.ResetColor();
                        Avaa();
                        break;
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
