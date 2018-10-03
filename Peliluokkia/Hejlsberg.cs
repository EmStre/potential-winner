using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    public class Hejlsberg: ILamppu
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


        public void Avaa()
        {
            if (Game.kassilaskuri > 0)
            {
                Console.WriteLine("C#-ryhmän luokka on tyhjä ja hämärä, lähes täysin pimeä.\n\n" +
                "Kätesi ulottuvilla on Academyn kangaskassi. Päätät pitää sen, jotta voit säilyttää siellä tavaroitasi.\n" +
                "Joten kuten erotat valonkatkaisijan (A), kaksi ovea käytävään (B) ja oven Java-ryhmän Hawking-luokkaan (C).\n" +
                "Tunnet niskassasi tuulenvireen takanasi auki olevata ikkunasta (D).\n" +
                "Tuuli saa pöydällä olevan vihkon sivut lepattamaan äänekkäästi.");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                Game.kassilaskuri--;

                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Painat valonkatkaisijaa, mutta mitään ei tapahdu. Sähköt tosiaan taitavat olla poikki.\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Avaat oven käytävään.\n");
                        Console.ResetColor();
                        Kaytava kaytava = new Kaytava();
                        kaytava.Avaa();
                        break;
                    case "C":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Väännät Java-ryhmän huoneen oven kahvasta, mutta toteat oven olevan lukossa.\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "D":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Astut ikkunan luo ja vilkaiset alas.\n");
                        Console.ResetColor();
                        Ikkuna ikkuna = new Ikkuna();
                        ikkuna.Avaa();
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
                        Avaa();
                        break;
                }
            }
            else
                Console.WriteLine("C#-ryhmän luokka on tyhjä ja hämärä, lähes täysin pimeä.\n\n" +
                "Joten kuten erotat valonkatkaisijan (A), kaksi ovea käytävään (B) ja oven Java-ryhmän Hawking-luokkaan (C).\n" +
                "Tunnet niskassasi tuulenvireen takanasi auki olevata ikkunasta (D).\n" +
                "Tuuli saa pöydällä olevan vihkon sivut lepattamaan äänekkäästi.");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Painat valonkatkaisijaa, mutta mitään ei tapahdu. Sähköt tosiaan taitavat olla poikki.\n");
                    Console.ResetColor();
                    Avaa();
                    break;
                case "B":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Avaat oven käytävään.\n");
                    Console.ResetColor();
                    Kaytava kaytava = new Kaytava();
                    kaytava.Avaa();
                    break;
                case "C":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Väännät Java-ryhmän huoneen oven kahvasta, mutta toteat oven olevan lukossa.\n");
                    Console.ResetColor();
                    Avaa();
                    break;
                case "D":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Astut ikkunan luo ja vilkaiset alas.\n");
                    Console.ResetColor();
                    Ikkuna ikkuna = new Ikkuna();
                    ikkuna.Avaa();
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
                    Avaa();
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
