using System;
using System.Threading;

namespace Peliluokkia
{
    class Ikkuna
    {
        string vastaus;
        public void Avaa()
        {
            Console.WriteLine("Ikkunasta puhaltaa viileää ilmaa kasvoillesi ja hetkeksi yllesi saapuu synkkyys.\n" +
                "Mieleen hiipii morkkis viime viikonlopun tanssista Rymy-Eetun pöydällä ja oksentamisesta taksiin illan päätteeksi.\n" +
                "Tästä olisi niin helppo vain nojata eteenpäin (A) tai sitten palata takaisin tutkiskelemaan luokkaa (B).\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.WriteLine("Hyvästi julma Academy ja kaiken maailman for-loopit ja boolean-operaattorit!\n");
                    Console.Write("Voitit pelin, hävisit elämän. ");
                    Game.life--;
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep(988, 300);
                    Console.WriteLine("GAME OVER.\n");
                    Console.Beep(784, 300);
                    Console.Beep(740, 300);
                    Console.Beep(698, 600);
                    Console.ResetColor();
                    Thread.Sleep(1500);
                    break;
                case "B":
                    Console.WriteLine("Huh helkkari, nyt oli synkkää! Astut ikkunan äärestä takaisin keskelle C#-luokkaa.");
                    Hejlsberg hejlsberg = new Hejlsberg();
                    hejlsberg.Avaa();
                    break;
                case "KASSI":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Inventaario inventaario = new Inventaario();
                    Console.WriteLine(inventaario);
                    Console.ResetColor();
                    Avaa();
                    break;
                case "LAMPPU":
                case "TASKULAMPPU PÄÄLLE":
                case "LAMPPU PÄÄLLE":
                case "AVAA LAMPPU":
                case "LAITA LAMPPU PÄÄLLE":
                case "KYTKE LAMPPU PÄÄLLE":
                    if (Inventaario.esineet.Contains("taskulamppu"))
                        Console.WriteLine("Osoittelet fikkarilla ikkunasta ulos, mutta siitä ei tunnu olevan mitään apua. Laitat lampun takaisin laukkuun.");
                   else
                        Console.WriteLine("Mitä?");
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
                    Console.WriteLine("Epäkelpo valinta.\n");
                    Avaa();
                    break;
            }
        }
    
    }
}
