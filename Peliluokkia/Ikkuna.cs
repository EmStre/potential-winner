using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    class Ikkuna
    {
        string vastaus;
        public void Avaa()
        {
            Console.WriteLine("Ikkunasta puhaltaa viileää ilmaa ja hetkeksi yllesi saapuu synkkyys.\n" +
                "Mieleen hiipii morkkis viime viikonlopun tanssista Rymy-Eetun pöydällä ja oksentamisesta taksiin.\n" +
                "Tästä olisi helppo nojata vaan eteenpäin (A) tai palata takaisin tutkiskelemaan luokkaa.\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.WriteLine("Hyvästi julma Academy ja kaiken maailman for-loopit ja boolean-operaattorit!\n");
                    Console.Write("Voitit pelin, hävisit elämän. ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("GAME OVER.\n");
                    Console.ResetColor();
                    Console.ReadKey();
                    break;
                case "B":
                    Console.WriteLine("Huh helkkari, nyt oli synkkää! Astut takaisin keskelle C#-luokkaa.");
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
