using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
                "Suutasi kuivaa ja muistat jääkaappiin jääneen bisseä (A) Terrific Thursdayn jäljiltä.\n" +
                "Kahvi kyllä piristäisi, mutta ilman virtaa et saa kahvia koneesta.\n" +
                "Toki keittokomeron (B) vesihanasta saisi myös raikasta vettä. Voit myös siirtyä takaisin C#-luokan käytävään (C), ruokailutilaan (D) tai hissikäytävään (E)\n");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Avaat jääkaapin ja onneksesi huomaat oluen olevan vielä kylmää sähkökatkosta huolimatta. Sihautat pullon auki ja nautit ravitsevan virvokkeen.\n");
                        Game.olutlaskuri--;
                        if (Game.olutlaskuri == 0)
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("...hik!\n");
                            Thread.Sleep(700);
                        }
                        else if (Game.olutlaskuri>0)
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("...aaahh...\n");
                            Thread.Sleep(700);
                        }
                        Console.ResetColor();
                        Game.oluet++;
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
                    case "E":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Siirryt takaisin käytävään.\n");
                        Console.ResetColor();
                        Hissikaytava hissikaytava = new Hissikaytava();
                        hissikaytava.Avaa();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "OLUT":
                        Console.WriteLine("Jääkaapin oluttilanne: " + Game.olutlaskuri.ToString());
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
                            Console.WriteLine("Täällä tuskin kannattaa kuluttaa lampun rajallista akkua...\n");
                            Console.ResetColor();
                            Avaa();
                            break;
                        }
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
             "Toki keittokomeron (B) vesihanasta saisi myös raikasta vettä. Voit myös siirtyä C#-luokan käytävään (C), ruokailutilaan (D) tai hissikäytävään (E)\n");
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
                        Console.WriteLine("Törmäät hämärässä pöytään etkä pääse etenemään.\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "E":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Siirryt takaisin käytävään.\n");
                        Console.ResetColor();
                        Hissikaytava hissikaytava = new Hissikaytava();
                        hissikaytava.Avaa();
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
                        Console.WriteLine("Jääkaapin oluttilanne: " + Game.olutlaskuri.ToString());
                        Avaa();
                        break;
                    case "LAMPPU PÄÄLLE":
                    case "SYTYTÄ LAMPPU":
                    case "AVAA LAMPPU":
                    case "LAMPPU":
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
                            Console.WriteLine("Täällä tuskin kannattaa kuluttaa rajallista akkua taskulampussa...\n");
                            Console.ResetColor();
                            Avaa();
                            break;
                        }
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
            Console.WriteLine("Jaahas. Kahvikoneessa palaa valot ja nyt voit laittaa sumpit tulille firman piikkiin. Ai että!\n");
            if (Game.olutlaskuri > 0)
                KahvihetkiJaKaljaa();
            else
                Kahvihetki();    
        }
        public void Kahvihetki()
        {
            Console.Write("Valitse mieleisesi tuote (");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("espresso, maitokahvi, kahvi, red eye");
            Console.ResetColor();
            Console.Write(")\n" +
                "Voit myös siirtyä keittokomeroon (A), C#-luokan käytävään (B), ruokailutilaan (C) tai hissikäytävään (D)\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();
            Inventaario inventaario = new Inventaario();
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
                    Console.WriteLine("Kävelet C#-luokan käytävään.\n");
                    Console.ResetColor();
                    Kaytava kaytava = new Kaytava();
                    kaytava.Avaa();
                    break;
                case "C":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Tallustelet ruokailutilaan.\n");
                    Console.ResetColor();
                    Ruokailutila ruokailutila = new Ruokailutila();
                    ruokailutila.Avaa();
                    break;
                case "D":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Siirryt hissikäytävään.\n");
                    Console.ResetColor();
                    Hissikaytava hissikaytava = new Hissikaytava();
                    hissikaytava.Avaa();
                    break;
                case "KASSI":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(inventaario);
                    Console.ResetColor();
                    Avaa();
                    break;
                case "ESPRESSO":
                    if (Game.kahvipavut == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Pavut vähissä. Lisää papuja. \n");
                        Console.ResetColor();
                        Kahvihetki();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Kone ruksuttaa hetken ja puskee sinulle jämäkän espresson. Puhaltelet kahvia viileämmäksi, huitaiset kupillisen kerralla huiviin ja tunnet, kuinka kofeiini virkistää väsyneitä aivojasi.\n");
                        Console.ResetColor();
                        Game.kahvipavut--;
                        Game.juodutKahvit++;
                        Kahvihetki();
                    }
                    break;
                case "MAITOKAHVI":
                    if (Game.kahvipavut == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Pavut vähissä. Lisää papuja. \n");
                        Console.ResetColor();
                        Kahvihetki();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Kone ruksuttaa hetken ja puskee sinulle vaalean maitokahvin. Ei tämä kunnon laatu-lattesta mene, mutta kahvin maku silti nostaa fiiliksiäsi.\n");
                        Console.ResetColor();
                        Game.kahvipavut--;
                        Game.juodutKahvit++;
                        Kahvihetki();
                    }
                        break;
                case "KAHVI":
                    if (Game.kahvipavut == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Pavut vähissä. Lisää papuja. \n");
                        Console.ResetColor();
                        Kahvihetki();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Kone ruksuttaa hetken ja puskee sinulle aivan tavallisen peruskahvin. Ei teeskentelyä, kofeiinia vain koneeseen.\n");
                        Console.ResetColor();
                        Game.kahvipavut--;
                        Game.juodutKahvit++;
                        Kahvihetki();
                    }
                    break;
                case "RED EYE":
                    if (Game.kahvipavut == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Pavut vähissä. Lisää papuja. \n");
                        Console.ResetColor();
                        Kahvihetki();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Mikä hitto edes on Red Eye? No, kokeillaan.\n" +
                            "Kone ruksuttaa hetken ja puskee sinulle kahvin ja siihen perään vielä espresson. Pärisee!\n");
                        Console.ResetColor();
                        Game.kahvipavut--;
                        Game.juodutKahvit++;
                        Kahvihetki();
                    }
                    break;
                case "LISÄÄ PAPUJA":
                    if (Game.avain == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Papuja lisätessäsi kuuluu erikoinen kolaus. Papupussin sisältä tupsahti avain!\n");
                        Console.ResetColor();
                        Game.kahvipavut = 5;
                        Game.avain++;
                        Kahvihetki();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Lisäät papuja kahvikoneeseen\n");
                        Console.ResetColor();
                        Game.kahvipavut = 6;
                        Kahvihetki();
                    }
                    break;
                case "OTA AVAIN":
                case "LISÄÄ AVAIN":
                    if (Game.avain > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Avain lisätty Academy-kassiin.\n");
                        Console.ResetColor();
                        inventaario.LisaaEsine(avain);
                        Game.avain = -5;
                        Kahvihetki();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        Kahvihetki();
                    }
                    break;
                case "H-HELP":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Heikki heikki = new Heikki();
                    heikki.Help();
                    Console.ResetColor();
                    Kahvihetki();
                    break;
                case "KARTTA":
                    Kartta kartta = new Kartta();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    kartta.KutsuKartta();
                    Console.ResetColor();
                    Avaa();
                    break;
                case "LAMPPU PÄÄLLE":
                case "SYTYTÄ LAMPPU":
                case "AVAA LAMPPU":
                case "LAMPPU":
                case "TASKULAMPPU PÄÄLLE":
                case "SYTYTÄ TASKULAMPPU":
                case "AVAA TASKULAMPPU":
                    if (!Inventaario.esineet.Contains("taskulamppu"))
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Sinulla ei ole lamppua\n");
                        Console.ResetColor();
                        Kahvihetki();
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Kahvikoneen valo saa nyt riittää.\n");
                        Console.ResetColor();
                        Kahvihetki();
                        break;
                    }
                default:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Epäkelpo valinta.\n");
                    Console.ResetColor();
                    Kahvihetki();
                    break;
            }
        }
        public void KahvihetkiJaKaljaa()
        {
            Console.Write("Valitse mieleisesi tuote (");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("espresso, maitokahvi, kahvi, red eye");
            Console.ResetColor();
            Console.Write(")\n" +
                "Voit myös kaivaa jääkaapista Terrific Thursdaylta ylijääneitä oluita (A). Voit myös siirtyä keittokomeron puolelle (B), C#-luokan käytävään (C), ruokailutilaan (D) tai hissikäytävään (E)\n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();
            Inventaario inventaario = new Inventaario();
            switch (vastaus)
            {
                case "A":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Kaivat jääkaapista oluen ja hörpit sitä hetken samalla ihmetellen, että mitä hittoa sitä tekisi seuraavaksi.\n");
                    Console.ResetColor();
                    Game.olutlaskuri--;
                    Game.oluet++;
                    if (Game.olutlaskuri > 0)
                        KahvihetkiJaKaljaa();
                    else
                        Kahvihetki();
                    break;
                case "B":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Kävelet keittokomeron puolelle.\n");
                    Console.ResetColor();
                    Keittokomero keittokomero = new Keittokomero();
                    keittokomero.Jatka();
                    break;
                case "C":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Kävelet käytävään C#-luokan eteen.\n");
                    Console.ResetColor();
                    Kaytava kaytava = new Kaytava();
                    kaytava.Avaa();
                    break;
                case "D":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Tallustelet ruokailutilaan.\n");
                    Console.ResetColor();
                    Ruokailutila ruokailutila = new Ruokailutila();
                    ruokailutila.Avaa();
                    break;
                case "E":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Siirryt hissikäytävään.\n");
                    Console.ResetColor();
                    Hissikaytava hissikaytava = new Hissikaytava();
                    hissikaytava.Avaa();
                    break;
                case "KASSI":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(inventaario);
                    Console.ResetColor();
                    Avaa();
                    break;
                case "ESPRESSO":
                    if (Game.kahvipavut == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Pavut vähissä. Lisää papuja. \n");
                        Console.ResetColor();
                        KahvihetkiJaKaljaa();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Kone ruksuttaa hetken ja puskee sinulle jämäkän espresson. Puhaltelet kahvia viileämmäksi, huitaiset kupillisen kerralla huiviin ja tunnet, kuinka kofeiini piristää.\n");
                        Console.ResetColor();
                        Game.kahvipavut--;
                        Game.juodutKahvit++;
                        KahvihetkiJaKaljaa();
                    }
                    break;
                case "MAITOKAHVI":
                    if (Game.kahvipavut == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Pavut vähissä. Lisää papuja. \n");
                        Console.ResetColor();
                        KahvihetkiJaKaljaa();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Kone ruksuttaa hetken ja puskee sinulle vaalean maitokahvin. Ei tämä kunnon laatu-lattesta mene, mutta kahvin maku silti nostaa fiiliksiäsi.\n");
                        Console.ResetColor();
                        Game.kahvipavut--;
                        Game.juodutKahvit++;
                        KahvihetkiJaKaljaa();
                    }
                    break;
                case "KAHVI":
                    if (Game.kahvipavut == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Pavut vähissä. Lisää papuja. \n");
                        Console.ResetColor();
                        KahvihetkiJaKaljaa();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Kone ruksuttaa hetken ja puskee sinulle aivan tavallisen peruskahvin. Ei teeskentelyä, kofeiinia vain koneeseen.\n");
                        Console.ResetColor();
                        Game.kahvipavut--;
                        Game.juodutKahvit++;
                        KahvihetkiJaKaljaa();
                    }
                    break;
                case "RED EYE":
                    if (Game.kahvipavut == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Pavut vähissä. Lisää papuja. \n");
                        Console.ResetColor();
                        Kahvihetki();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Mikä hitto edes on Red Eye? No, kokeillaan.\n" +
                            "Kone ruksuttaa hetken ja puskee sinulle kahvin ja siihen perään vielä espresson. Pärisee!\n");
                        Console.ResetColor();
                        Game.kahvipavut--;
                        Game.juodutKahvit++;
                        KahvihetkiJaKaljaa();
                    }
                    break;
                case "LISÄÄ PAPUJA":
                    if (Game.avain == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Papuja lisätessäsi kuuluu erikoinen kolaus. Papupussin sisältä tupsahti avain!\n");
                        Console.ResetColor();
                        Game.kahvipavut = 5;
                        Game.avain++;
                        KahvihetkiJaKaljaa();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Lisäät papuja kahvikoneeseen\n");
                        Console.ResetColor();
                        Game.kahvipavut = 6;
                        KahvihetkiJaKaljaa();
                    }
                    break;
                case "LISÄÄ AVAIN":
                case "OTA AVAIN":
                    if (Game.avain > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Avain lisätty Academy-kassiin.\n");
                        Console.ResetColor();
                        inventaario.LisaaEsine(avain);
                        Game.avain = -5;
                        Kahvihetki();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        Kahvihetki();
                    }
                    break;
                case "KARTTA":
                    Kartta kartta = new Kartta();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    kartta.KutsuKartta();
                    Console.ResetColor();
                    Avaa();
                    break;
                case "LAMPPU PÄÄLLE":
                case "SYTYTÄ LAMPPU":
                case "AVAA LAMPPU":
                case "LAMPPU":
                case "TASKULAMPPU PÄÄLLE":
                case "SYTYTÄ TASKULAMPPU":
                case "AVAA TASKULAMPPU":
                    if (!Inventaario.esineet.Contains("taskulamppu"))
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Sinulla ei ole lamppua\n");
                        Console.ResetColor();
                        Kahvihetki();
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Kahvikoneen valo saa nyt riittää.\n");
                        Console.ResetColor();
                        Kahvihetki();
                        break;
                    }
                case "H-HELP":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Heikki heikki = new Heikki();
                    heikki.Help();
                    Console.ResetColor();
                    KahvihetkiJaKaljaa();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Epäkelpo valinta.\n");
                    Console.ResetColor();
                    KahvihetkiJaKaljaa();
                    break;
            }
        }
    }
}
