using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    class Keittio
    {
        string vastaus;
        string avain = "avain";
        public void Avaa()
        {
            if (Game.sahkoa == 1)
            {
                ValoisaAcademy();
            }

            else if (Game.olutlaskuri > 0)
            {
                Console.WriteLine("Keittiöön tulee hieman valoa ulkona palavista katulampuista.\n" +
                "Suutasi kuivaa ja muistat (A) jääkaappiin jääneen bisseä Terrific Thursdayn jäljiltä.\n" +
                "Kahvi kyllä piristäisi, mutta ilman virtaa et saa kahvia koneesta.\n" +
                "Toki (B) keittokomeron vesihanasta saisi myös raikasta vettä. (C) vie sinut takaisin käytävään tai voit myös siirtyä (D) ruokailutilaan.\n");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Avaat jääkaapin ja onneksesi huomaat oluen olevan vielä kylmää sähkökatkosta huolimatta. Nautit virvokkeen.\n");
                        Console.ResetColor();
                        Game.olutlaskuri--;
                        Avaa();
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
                        Console.WriteLine("Siirryt takaisin käytävään.\n");
                        Console.ResetColor();
                        Kaytava kaytava = new Kaytava();
                        kaytava.Avaa();
                        break;
                    case "D":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Törmäät pöytään etkä pääse etenemään.\n");
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
                    case "OLUT":
                        Console.WriteLine(Game.olutlaskuri.ToString());
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
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Keittiöön tulee hieman valoa ulkona palavista katulampuista.\n" +
             "Suutasi kuivaa ja arvelet jääkaappiin (A) jääneen bisseä Terrific Thursdayn jäljiltä.\n" +
             "Kahvi kyllä piristäisi, mutta ilman virtaa et saa kahvia koneesta.\n" +
             "Toki (B) keittokomeron vesihanasta saisi myös raikasta vettä. (C) vie sinut takaisin käytävään tai voit myös siirtyä (D) ruokailutilaan.\n");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Avaat jääkaapin todetaksesi sen ammottavan tyhjyyttään - juotuasi itse sieltä kaikki oluet.\n");
                        Console.ResetColor();
                        Avaa();
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
                        Console.WriteLine("Siirryt takaisin käytävään.\n");
                        Console.ResetColor();
                        Kaytava kaytava = new Kaytava();
                        kaytava.Avaa();
                        break;
                    case "D":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Törmäät pöytään etkä pääse etenemään.\n");
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
                    case "H-HELP":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Heikki heikki = new Heikki();
                        heikki.Help();
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "OLUT":
                        Console.WriteLine(Game.olutlaskuri.ToString());
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
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                }
            }
        }

        public void ValoisaAcademy()
        {
            Console.WriteLine("Jaahas. Kahvikoneessa palaa valo ja nyt voit laittaa firman piikkiin espressot tulille.\n");
            Kahvihetki();    
        }

        public void Kahvihetki()
        {
            Console.WriteLine("Valitse mieleisesi tuote (espresso, maitokahvi, kahvi, red eye)\n" +
                "Voit myös kävellä (A) keittokomeron puolelle tai (B) vie sinut takaisin käytävään.\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch(vastaus)
            {
                case "A":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Kävelet keittokomeron puolelle.\n");
                    Console.ResetColor();
                    Keittokomero keittokomero = new Keittokomero();
                    keittokomero.Jatka();
                    break;
                case "B":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Kävelet keittokomeron puolelle.\n");
                    Console.ResetColor();
                    Kaytava kaytava = new Kaytava();
                    kaytava.Avaa();
                    break;
                case "ESPRESSO":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Pavut vähissä. Lisää papuja. \n");
                    Console.ResetColor();
                    Kahvihetki();
                    break;
                case "MAITOKAHVI":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Pavut vähissä. Lisää papuja.\n");
                    Console.ResetColor();
                    Kahvihetki();
                    break;
                case "KAHVI":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Pavut vähissä. Lisää papuja.\n");
                    Console.ResetColor();
                    Kahvihetki();
                    break;
                case "RED EYE":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Pavut vähissä. Lisää papuja.\n");
                    Console.ResetColor();
                    Kahvihetki();
                    break;
                case "LISÄÄ PAPUJA":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Papuja lisätessäsi kuuluu erikoinen kolaus. Papupussin sisältä tupsahti avain!\n");
                    Console.ResetColor();
                    Kahvihetki();
                    break;
                case "OTA AVAIN":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Avain lisätty Academy-kassiin.\n");
                    Console.ResetColor();
                    Inventaario inventaario = new Inventaario();
                    inventaario.LisaaEsine(avain);
                    Kahvihetki();
                    break;
                case "LISÄÄ AVAIN":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Avain lisätty Academy-kassiin.\n");
                    Console.ResetColor();
                    Inventaario inventaario2 = new Inventaario();
                    inventaario2.LisaaEsine(avain);
                    Kahvihetki();
                    break;
                case "H-HELP":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Heikki heikki = new Heikki();
                    heikki.Help();
                    Console.ResetColor();
                    Kahvihetki();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Epäkelpo valinta.\n");
                    Console.ResetColor();
                    Kahvihetki();
                    break;
            }

        }
    }
}
