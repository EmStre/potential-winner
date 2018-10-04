using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    class Keittokomero
    {
        string vastaus;
        public void Avaa()
        {
            Console.WriteLine("Hapuilet pimeässä tiskipöydän luo. Pöydältä erottuu esine, jonka tunnistat ensiapulaukuksi. Kädelläsi tavoitat myös vesihanan.\n");
            Jatka();
        }
        public void Jatka()
        {
            if (!Inventaario.esineet.Contains("taskulamppu"))
            {
                string vastaus;
                Console.WriteLine("Okei, eli ulottuvillasi on ensiapulaukku (A) ja vesihana (B). Voit myös siirtyä ruokailutilaan (C) tai voit palata takaisin keittiön (D) puolelle.\n" +
                    "WC-tilan (E) ovi näyttäisi olevan hieman raollaan.\n");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Tämä on kaikin puolin hyvin standardinmukainen ensiapulaukku.\n" +
                            "Mitä haluaisit tehdä laukulle?\n");
                        Console.ResetColor();
                        vastaus = Console.ReadLine();
                        vastaus = vastaus.ToUpper();
                        if (vastaus == "AVAA ENSIAPULAUKKU" || vastaus == "TUTKI ENSIAPULAUKKU" || vastaus == "AVAA ENSIAPU" || vastaus == "OTA LAUKKU" || vastaus == "OTA ENSIAPULAUKKU" || vastaus == "AVAA LAUKKU")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Tunnustelet ensiapulaukun sisältöä. Tunnistat hämärässä burana-paketin ja huomaat myös jonkun kookkaamman esineen.\n");
                            Console.ResetColor();
                            Ensiapulaukku();
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Epäkelpo valinta.\n");
                            Console.ResetColor();
                            Jatka();
                            break;
                        }
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Helkkarin kiva, juoksevaa vettä ei tule.\n");
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "C":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Siirryt ruokailutilaan.\n");
                        Console.ResetColor();
                        Ruokailutila ruokailutila = new Ruokailutila();
                        ruokailutila.Avaa();
                        break;
                    case "D":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Kävelet keittiöön.\n");
                        Console.ResetColor();
                        Keittio keittio = new Keittio();
                        keittio.Avaa();
                        break;
                    case "E":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Astut WC-tilaan.\n");
                        Console.ResetColor();
                        WC vessa = new WC();
                        vessa.Avaa();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "OTA LAUKKU":
                    case "OTA ENSIAPULAUKKU":
                    case "LISÄÄ LAUKKU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Sinulla on jo hieno Academy-kassi, miksi vaihtaisit sen tähän? Löydät ensiapulaukun täältä jatkossakin.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "AVAA ENSIAPULAUKKU":
                    case "TUTKI ENSIAPULAUKKU":                       
                    case "AVAA ENSIAPU":
                    case "AVAA LAUKKU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Tunnustelet ensiapulaukun sisältöä. Tunnistat hämärässä burana-paketin ja huomaat myös jonkun kookkaamman esineen.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "AVAA LAMPPU":
                    case "LAMPPU PÄÄLLE":
                    case "AVAA TASKULAMPPU":
                    case "TASKULAMPPU PÄÄLLE":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        if (Inventaario.esineet.Contains("taskulamppu"))
                        {
                            Console.WriteLine("Osoittelet lampulla ympärillesi, mutta et näe mitään merkittävää tai mielenkiintoista lampun valossa ja sammutat sen.\n");
                        }
                        else
                        {
                            Console.WriteLine("Sinulla ei ole lamppua.\n");
                        }
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
                    case "JUO VETTÄ":
                    case "JUO VESI":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Mistä noin kova jano, jos vaikka yrittäisit päästä pois täältä.\n");
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
            else
            {
                Console.WriteLine("Okei, eli ulottuvillasi on ensiapulaukku (A) ja vesihana (B).\n" +
                "Voit myös siirtyä ruokailutilaan (C) tai voit palata takaisin keittiön (D) puolelle.\n" +
               "WC-tilan (E) ovi näyttäisi olevan hieman raollaan. \n");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();

                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Edelleen tosi hyvä laukku.\n" +
                            "Mitä haluaisit tehdä laukulle?\n");
                        Console.ResetColor();
                        vastaus = Console.ReadLine();
                        vastaus = vastaus.ToUpper();
                        if (vastaus == "AVAA ENSIAPULAUKKU" || vastaus == "TUTKI ENSIAPULAUKKU" || vastaus == "AVAA ENSIAPU" || vastaus == "AVAA LAUKKU" || vastaus == "OTA LAUKKU" || vastaus == "OTA ENSIAPULAUKKU")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Tunnustelet ensiapulaukun sisältöä. Tunnistat hämärässä burana-paketin.\n");
                            Console.ResetColor();
                            Ensiapulaukku();
                            break;
                        }
                        else
                        {
                            Jatka();
                            break;
                        }
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Helkkarin kiva, juoksevaa vettä ei tule.\n");
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "C":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Siirryt ruokailutilaan.\n");
                        Console.ResetColor();
                        Ruokailutila ruokailutila = new Ruokailutila();
                        ruokailutila.Avaa();
                        break;
                    case "D":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Kävelet keittiöön.\n");
                        Console.ResetColor();
                        Keittio keittio = new Keittio();
                        keittio.Avaa();
                        break;
                    case "E":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Astut WC-tilaan.\n");
                        Console.ResetColor();
                        WC vessa = new WC();
                        vessa.Avaa();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "JUO VETTÄ":
                    case "JUO VESI":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Mistä noin kova jano, jos vaikka yrittäisit päästä pois täältä.\n");
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "AVAA LAMPPU":
                    case "LAMPPU PÄÄLLE":
                    case "AVAA TASKULAMPPU":
                    case "TASKULAMPPU PÄÄLLE":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        if (Inventaario.esineet.Contains("taskulamppu"))
                        {
                            Console.WriteLine("Osoittelet lampulla ympärillesi, mutta et näe mitään merkittävää tai mielenkiintoista lampun valossa ja sammutat sen.\n");
                        }
                        else
                        {
                            Console.WriteLine("Sinulla ei ole lamppua.\n");
                        }
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
                    case "OTA LAUKKU":
                    case "OTA ENSIAPULAUKKU":
                    case "LISÄÄ LAUKKU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Sinulla on jo hieno Academy-kassi, miksi vaihtaisit sen tähän? Löydät ensiapulaukun täältä jatkossakin.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "AVAA ENSIAPULAUKKU":
                    case "TUTKI ENSIAPULAUKKU":
                    case "AVAA ENSIAPU":
                    case "AVAA LAUKKU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Tunnustelet ensiapulaukun sisältöä. Tunnistat hämärässä burana-paketin.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
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
        }
        public void Ensiapulaukku()
        {
            string komento = "";
            string esine = "taskulamppu";
            if (Inventaario.esineet.Contains("vesipullo") && !Inventaario.esineet.Contains("taskulamppu"))
            {
                Console.WriteLine("Burana-paketissa (A) on onneksi vielä tabuja jäljellä. Voit myös tarkastella tuntematonta esinettä (B) tarkemmin tai jättää ensiapulaukun sikseen (C).\n");
                komento = Console.ReadLine();
                komento = komento.ToUpper();
                switch (komento)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Nyt on tabletti, mutta jostain pitäisi saada vielä vettä.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "OTA LAUKKU":
                    case "OTA ENSIAPULAUKKU":
                    case "LISÄÄ LAUKKU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Sinulla on jo hieno Academy-kassi, miksi vaihtaisit sen tähän? Löydät ensiapulaukun täältä jatkossakin.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "VESIPULLO":
                    case "JUO VESI":
                    case "JUO VETTÄ":
                        Game.vesiHuikat++;
                        if (Game.vesiHuikat == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Onneksi tuli kerättyä vesipullo talteen. Viimein saat päänsäryn pois.");
                            Console.ResetColor();
                            Ensiapulaukku();
                        }
                        else if (Game.vesiHuikat == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Otat huikan ja mietit eikö täältä oikeasti löydy muuta juotavaa.");
                            Console.ResetColor();
                            Ensiapulaukku();
                        }
                        else if (Game.vesiHuikat == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Vesipullo on melkein tyhjä.");
                            Console.ResetColor();
                            Ensiapulaukku();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Vesipullo on tyhjä.");
                            Console.ResetColor();
                            Ensiapulaukku();
                        }
                        break;
                    case "OTA LÄÄKE":
                    case "OTA BURANA":
                        Game.buranaLaskuri++;
                        if (Game.buranaLaskuri == 1)

                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Nyt on tabletti, mutta olikohan sitä vettä missään. Voit kokeilla vaikkapa komentoa JUO... \n");
                            Console.ResetColor();
                            Ensiapulaukku();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Ai lisää lääkettä? No anna palaa, Frank.\n");
                            Console.ResetColor();
                            Ensiapulaukku();
                        }
                        break;
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Nice, taskulamppu! Tästä voisi olla vielä hyötyä!\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "C":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Lasket ensiapulaukun takaisin pöydälle.\n");
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "LISÄÄ TASKULAMPPU":
                    case "LISÄÄ LAMPPU":
                    case "OTA LAMPPU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Taskulamppu lisätty Academy-kassiin.\n");
                        Inventaario inventaario = new Inventaario();
                        inventaario.LisaaEsine(esine);
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "AVAA LAMPPU":
                    case "LAMPPU PÄÄLLE":
                    case "AVAA TASKULAMPPU":
                    case "TASKULAMPPU PÄÄLLE":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        if (Inventaario.esineet.Contains("taskulamppu"))
                        {
                            Console.WriteLine("Osoittelet lampulla ympärillesi, mutta et näe mitään merkittävää tai mielenkiintoista lampun valossa ja sammutat sen.\n");
                        }
                        else
                        {
                            Console.WriteLine("Sinulla ei ole lamppua.\n");
                        }
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario4 = new Inventaario();
                        Console.WriteLine(inventaario4);
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "KARTTA":
                        Kartta kartta = new Kartta();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        kartta.KutsuKartta();
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "H-HELP":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Heikki heikki = new Heikki();
                        heikki.Help();
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                }
            }
            else if (Inventaario.esineet.Contains("vesipullo") && Inventaario.esineet.Contains("taskulamppu"))
            {
                Console.WriteLine("Buranapaketissa on onneksi vielä tabuja jäljellä. Voit halutessasi ottaa särkylääkkeen ja vettä olisi hyvä olla myös.\n" +
                    "Voit myös sulkea laukun ja jatkaa keittokomeron (A) tutkimista");
                komento = Console.ReadLine();
                komento = komento.ToUpper();

                switch (komento)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Suljet ensiapulaukun ja seisot edelleen keittokomerossa.\n");
                        Console.ResetColor();
                        Keittokomero keittokomero = new Keittokomero();
                        keittokomero.Jatka();
                        break;
                    case "OTA LAUKKU":
                    case "OTA ENSIAPULAUKKU":
                    case "LISÄÄ LAUKKU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Sinulla on jo hieno Academy-kassi, miksi vaihtaisit sen tähän? Löydät ensiapulaukun täältä jatkossakin.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "OTA BURANA":
                    case "OTA LÄÄKE":
                        Game.buranaLaskuri++;
                        if (Game.buranaLaskuri == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Nyt on lääke, mutta olikohan sitä vettä missään.\n");
                            Console.ResetColor();
                            Ensiapulaukku();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Ai lisää lääkettä? No anna palaa, Frank.\n");
                            Console.ResetColor();
                            Ensiapulaukku();
                        }
                        break;
                    case "VESIPULLO":
                    case "JUO VETTÄ":
                    case "JUO VESI":
                        Game.vesiHuikat++;
                        if (Game.vesiHuikat == 1)
                        { 
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Oh yes. Lämpimällä vedellä saa huuhtoa kurkkua..");
                        Console.ResetColor();
                        Ensiapulaukku();
                        } else if (Game.vesiHuikat == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Otat huikan ja mietit eikö täältä oikeasti löydy muuta juotavaa.");
                            Console.ResetColor();
                            Ensiapulaukku();
                        } else if (Game.vesiHuikat == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Vesipullo on melkein tyhjä.");
                            Console.ResetColor();
                            Ensiapulaukku();
                        } else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Vesipullo on tyhjä.");
                            Console.ResetColor();
                            Ensiapulaukku();
                        }
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "AVAA LAMPPU":
                    case "LAMPPU PÄÄLLE":
                    case "AVAA TASKULAMPPU":
                    case "TASKULAMPPU PÄÄLLE":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        if (Inventaario.esineet.Contains("taskulamppu"))
                        {
                            Console.WriteLine("Osoittelet lampulla ympärillesi, mutta et näe mitään merkittävää tai mielenkiintoista lampun valossa ja sammutat sen.\n");
                        }
                        else
                        {
                            Console.WriteLine("Sinulla ei ole lamppua.\n");
                        }
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "KARTTA":
                        Kartta kartta = new Kartta();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        kartta.KutsuKartta();
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "H-HELP":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Heikki heikki = new Heikki();
                        heikki.Help();
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                }
            }
            else if (!Inventaario.esineet.Contains("vesipullo") && Inventaario.esineet.Contains("taskulamppu"))
            {
                Console.WriteLine("Buranapaketissa (A) on onneksi vielä tabuja jäljellä. Voit myös sulkea ensiapulaukun ja tutkia lisää keittokomeroa (B).\n");
                komento = Console.ReadLine();
                komento = komento.ToUpper();
                switch (komento)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Nyt on tabletti, mutta jostain pitäisi saada vielä vettä. Palaa ottamaan lääke sitten.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Suljet ensiapulaukun ja seisot edelleen keittokomerossa.\n");
                        Console.ResetColor();
                        Keittokomero keittokomero = new Keittokomero();
                        keittokomero.Jatka();
                        break;
                    case "OTA LAUKKU":
                    case "OTA ENSIAPULAUKKU":
                    case "LISÄÄ LAUKKU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Sinulla on jo hieno Academy-kassi, miksi vaihtaisit sen tähän? Löydät ensiapulaukun täältä jatkossakin.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "JUO VESI":
                    case "JUO VETTÄ":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Hanasta ei tule mitään. Vettä pitäisi löytää jostain.");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "LISÄÄ TASKULAMPPU":
                    case "OTA LAMPPU":
                    case "LISÄÄ LAMPPU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Kassissasi on jo taskulamppu.\n");
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "AVAA LAMPPU":
                    case "LAMPPU PÄÄLLE":
                    case "AVAA TASKULAMPPU":
                    case "TASKULAMPPU PÄÄLLE":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        if (Inventaario.esineet.Contains("taskulamppu"))
                        {
                            Console.WriteLine("Osoittelet lampulla ympärillesi, mutta et näe mitään merkittävää tai mielenkiintoista lampun valossa ja sammutat sen.\n");
                        }
                        else
                        {
                            Console.WriteLine("Sinulla ei ole lamppua.\n");
                        }
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "KARTTA":
                        Kartta kartta = new Kartta();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        kartta.KutsuKartta();
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "H-HELP":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Heikki heikki = new Heikki();
                        heikki.Help();
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                }

            }
            else //kun ei ole kumpaakaan esinettä kassissa
            {
                Console.WriteLine("Buranapaketissa (A) on onneksi vielä tabuja jäljellä. Voit myös tarkastella tuntematonta esinettä (B) tarkemmin tai jättää ensiapulaukun sikseen (C).\n");
                komento = Console.ReadLine();
                komento = komento.ToUpper();
                switch (komento)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Nyt on burana, mutta jostain pitäisi saada vielä vettä. Palaa ottamaan lääke sitten. \n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "JUO VESI":
                    case "JUO VETTÄ":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Hanasta ei tule mitään. Vettä pitäisi löytää jostain.");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "B":
                        Console.Write("Nice, löysin "); 
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("taskulampun. ");
                        Console.ResetColor();
                        Console.WriteLine("Tästä voisi olla vielä hyötyä.\n");
                        Ensiapulaukku();
                        break;
                    case "C":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Lasket ensiapulaukun takaisin pöydälle.\n");
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "OTA LAUKKU":
                    case "OTA ENSIAPULAUKKU":
                    case "LISÄÄ LAUKKU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Sinulla on jo hieno Academy-kassi, miksi vaihtaisit sen tähän? Löydät ensiapulaukun täältä jatkossakin.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "LISÄÄ LAMPPU":
                    case "LISÄÄ TASKULAMPPU":
                    case "OTA LAMPPU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Taskulamppu lisätty Academy-kassiin.\n");
                        Inventaario inventaario = new Inventaario();
                        inventaario.LisaaEsine(esine);
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "AVAA LAMPPU":
                    case "LAMPPU PÄÄLLE":
                    case "AVAA TASKULAMPPU":
                    case "TASKULAMPPU PÄÄLLE":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        if (Inventaario.esineet.Contains("taskulamppu"))
                        {
                            Console.WriteLine("Osoittelet lampulla ympärillesi, mutta et näe mitään merkittävää tai mielenkiintoista lampun valossa ja sammutat sen.\n");
                        }
                        else
                        {
                            Console.WriteLine("Sinulla ei ole lamppua.\n");
                        }
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario4 = new Inventaario();
                        Console.WriteLine(inventaario4);
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "KARTTA":
                        Kartta kartta = new Kartta();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        kartta.KutsuKartta();
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "H-HELP":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Heikki heikki = new Heikki();
                        heikki.Help();
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                }
            }
        }
    }
}
