using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep(988, 300);
                    Console.WriteLine("GAME OVER.\n");
                    Console.Beep(784, 300);
                    Console.Beep(740, 300);
                    Console.Beep(698, 600);
                    Console.ResetColor();
                    Console.ReadKey();
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
                default:
                    Console.WriteLine("Epäkelpo valinta.\n");
                    Avaa();
                    break;
            }
        }
    }
}
