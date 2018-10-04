using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    class WC
    {
      
        public void Avaa()
        {
            string vastaus;
            Console.WriteLine("Olet vessassa ja mietit voisiko avain ulospääsyyn löytyä vessanpöntöstä (A)?\n" +
                "Voit myös jatkaa haparointia takaisin keittokomeroon (B) tai ruokailutilaan (C).\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Et varsinaisesti ylläty siitä, että pöntöstä ei löydy mitään.\n");
                    Console.ResetColor();
                    Jatka();
                    break;
                case "B":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Siirryt keittokomeron puolelle.\n");
                    Console.ResetColor();
                    Keittokomero keittokomero = new Keittokomero();
                    keittokomero.Avaa();
                    break;
                case "C":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Astut ruokailutilaan.\n");
                    Console.ResetColor();
                    Ruokailutila ruokailutila = new Ruokailutila();
                    ruokailutila.Avaa();
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
                    Avaa();
                    break;
                case "H-HELP":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Heikki heikki = new Heikki();
                    heikki.Help();
                    Console.ResetColor();
                    Avaa();
                    break;
                case "LAMPPU PÄÄLLE":
                case "SYTYTÄ LAMPPU":
                case "AVAA LAMPPU":
                case "TASKULAMPPU PÄÄLLE":
                case "SYTYTÄ TASKULAMPPU":
                case "AVAA TASKULAMPPU":
                    if (!Inventaario.esineet.Contains("taskulamppu"))
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Sinulla ei ole lamppua\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Taskulamppu syttyy, jolloin näet, että WC-tila on törkyisessä kunnossa. Mietitkin sisään astuessasi, että siellä haisi kovin pahalta\nPäätät sulkea lampun saman tien.\n" );
                        Console.ResetColor();
                        Avaa();
                        break;
                    }
                case "PISSAA":
                case "KÄY VESSASSA":
                case "KÄY PÖNTÖLLÄ":                    
                case "KÄY PISSALLA":
                    int juomat = (3 - Game.olutlaskuri + Game.juodutKahvit);
                    juomat = juomat - Game.nollaa;
                        if(juomat >= 3)
                        {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Tässähän olikin jo kova hätä!!\n");
                        Console.ResetColor();
                    }
                        else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Kaverilla on vähän pienempi rakko! Ei kai siinä...\n");
                        Console.ResetColor();
                    }
                    Game.nollaa = juomat;
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
        public void Jatka()
        {
            string vastaus;
            Console.WriteLine("Seisot pilkkopimeässä vessassa. Vieressäsi on vessanpönttö (A), jota et näe, mutta tiedät sen olevan siinä vieressä.\n" +
                "Voit myös poistua vessasta keittokomeron puolelle (B) tai ruokailutilaan (C).\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Pöntössä ei edelleenkään ole mitään.\n");
                    Console.ResetColor();
                    Jatka();
                    break;
                case "B":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Siirryt keittokomeron puolelle.\n");
                    Console.ResetColor();
                    Keittokomero keittokomero = new Keittokomero();
                    keittokomero.Avaa();
                    break;
                case "C":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Astut ruokailutilaan.\n");
                    Console.ResetColor();
                    Ruokailutila ruokailutila = new Ruokailutila();
                    ruokailutila.Avaa();
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
                case "LAMPPU PÄÄLLE":
                case "SYTYTÄ LAMPPU":
                case "AVAA LAMPPU":
                case "TASKULAMPPU PÄÄLLE":
                case "SYTYTÄ TASKULAMPPU":
                case "AVAA TASKULAMPPU":
                    if (!Inventaario.esineet.Contains("taskulamppu"))
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Sinulla ei ole lamppua\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Taskulamppu syttyy, jolloin näet, että WC-tila on törkysessä kunnossa. Mietitkin sisään astuessasi, että siellä haisi kovin pahalta\nPäätät sulkea lampun saman tien.\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                    }
                case "PISSAA":
                case "KÄY VESSASSA":
                case "KÄY PISSALLA":
                case "KÄY PÖNTÖLLÄ":
                    int juomat = (3 - Game.olutlaskuri + Game.juodutKahvit);
                    juomat = juomat - Game.nollaa;
                    if (juomat >= 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Tässähän olikin jo kova hätä!!\n");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Kaverilla on vähän pienempi rakko! Ei kai siinä...\n");
                        Console.ResetColor();
                    }
                    Game.nollaa = juomat;
                    Avaa();
                    break;
                case "H-HELP":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Heikki heikki = new Heikki();
                    heikki.Help();
                    Console.ResetColor();
                    Avaa();
                    break;
                case "KARTTA":
                    Kartta kartta = new Kartta();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    kartta.KutsuKartta();
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
    }
}
