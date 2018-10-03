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
            if (!Inventaario.esineet.Contains("taskulamppu")) { 

                Console.WriteLine("Hapuilet pimeässä tiskipöydän luo.\n" +
                "Pöydältä erottuu esine, jonka tunnistat ensiapulaukuksi.\n" +
                "Kädelläsi tavoitat myös vesihanan (A). Voit myös siirtyä ruokailutilaan (B) tai voit palata takaisin keittiön (C) puolelle.\n" +
                "WC-tilan (D) ovi näyttäisi olevan hieman raollaan. \n");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Helkkarin kiva, juoksevaa vettä ei tule.\n");
                    Console.ResetColor();
                    Avaa();
                    break;
                case "B":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Siirryt ruokailutilaan.\n");
                    Console.ResetColor();
                    Ruokailutila ruokailutila = new Ruokailutila();
                    ruokailutila.Avaa();
                    break;
                case "C":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Kävelet keittiöön.\n");
                    Console.ResetColor();
                    Keittio keittio = new Keittio();
                    keittio.Avaa();
                    break;
                case "D":
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
                    Avaa();
                    break;
                case "AVAA ENSIAPULAUKKU":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Tunnustelet ensiapulaukun sisältöä. Tunnistat hämärässä burana-paketin ja huomaat myös erään kookkaamman esineen.\n");
                    Console.ResetColor();
                    Ensiapulaukku();
                    break;
                case "TUTKI ENSIAPULAUKKU":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Tunnustelet ensiapulaukun sisältöä. Tunnistat hämärässä burana-paketin ja huomaat myös erään kookkaamman esineen.\n");
                    Console.ResetColor();
                    Ensiapulaukku();
                    break;
                case "AVAA ENSIAPU":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Tunnustelet ensiapulaukun sisältöä. Tunnistat hämärässä burana-paketin ja huomaat myös erään kookkaamman esineen.\n");
                    Console.ResetColor();
                    Ensiapulaukku();
                    break;
                case "AVAA LAUKKU":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Tunnustelet ensiapulaukun sisältöä. Tunnistat hämärässä burana-paketin ja huomaat myös erään kookkaamman esineen.\n");
                    Console.ResetColor();
                    Ensiapulaukku();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Epäkelpo valinta.\n");
                    Console.ResetColor();
                    Avaa();
                    break;
            }

            } else
            {
                Console.WriteLine("Hapuilet pimeässä tiskipöydän luo.\n" +
               "Pöydältä erottuu esine, jonka tunnistat ensiapulaukuksi.\n" +
               "Kädelläsi tavoitat myös vesihanan (A). Voit myös siirtyä ruokailutilaan (B) tai voit palata takaisin keittiön (C) puolelle.\n" +
               "WC-tilan (D) ovi näyttäisi olevan hieman raollaan. \n");
                vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();

                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Helkkarin kiva, juoksevaa vettä ei tule.\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Siirryt ruokailutilaan.\n");
                        Console.ResetColor();
                        Ruokailutila ruokailutila = new Ruokailutila();
                        ruokailutila.Avaa();
                        break;
                    case "C":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Kävelet keittiöön.\n");
                        Console.ResetColor();
                        Keittio keittio = new Keittio();
                        keittio.Avaa();
                        break;
                    case "D":
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
                        Avaa();
                        break;
                    case "AVAA ENSIAPULAUKKU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Tunnustelet ensiapulaukun sisältöä. Tunnistat hämärässä burana-paketin.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "TUTKI ENSIAPULAUKKU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Tunnustelet ensiapulaukun sisältöä. Tunnistat hämärässä burana-paketin.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "AVAA ENSIAPU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Tunnustelet ensiapulaukun sisältöä. Tunnistat hämärässä burana-paketin.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "AVAA LAUKKU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Tunnustelet ensiapulaukun sisältöä. Tunnistat hämärässä burana-paketin.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
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

        public void Ensiapulaukku()
        {
            string komento = "";
            string esine = "taskulamppu";

            if (Inventaario.esineet.Contains("vesipullo") && !Inventaario.esineet.Contains("taskulamppu"))
            {
                Console.WriteLine("Buranapaketissa (A) on onneksi vielä tabuja jäljellä. Voit myös tarkastella tuntematonta esinettä (B) tarkemmin.\n");
                komento = Console.ReadLine();
                komento = komento.ToUpper();

                switch (komento)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Nyt on burana, mutta jostain pitäisi saada vielä vettä.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "OTA VESIPULLO":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Onneksi tuli kerättyä vesipullo talteen. Viimein saan päänsäryn pois.");
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "JUO VETTÄ":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Onneksi tuli kerättyä vesipullo talteen. Viimein saat päänsäryn pois.");
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Nice, löysin taskulampun. Tästä voisi olla vielä hyötyä.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "LISÄÄ TASKULAMPPU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Taskulamppu lisätty Academy-kassiin.\n");
                        Inventaario inventaario = new Inventaario();
                        inventaario.LisaaEsine(esine);
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "OTA LAMPPU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Taskulamppu lisätty Academy-kassiin.\n");
                        Inventaario inventaario2 = new Inventaario();
                        inventaario2.LisaaEsine(esine);
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "LISÄÄ LAMPPU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Taskulamppu lisätty Academy-kassiin.\n");
                        Inventaario inventaario3 = new Inventaario();
                        inventaario3.LisaaEsine(esine);
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario4 = new Inventaario();
                        Console.WriteLine(inventaario4);
                        Console.ResetColor();
                        Avaa();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Ensiapulaukku();
                        Console.ResetColor();
                        break;
                }

            }
            else if (Inventaario.esineet.Contains("vesipullo") && Inventaario.esineet.Contains("taskulamppu"))
            {
                Console.WriteLine("Buranapaketissa (A) on onneksi vielä tabuja jäljellä.\n");
                komento = Console.ReadLine();
                komento = komento.ToUpper();

                switch (komento)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Nyt on burana, mutta jostain pitäisi saada vielä vettä.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "OTA VESIPULLO":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Onneksi tuli kerättyä vesipullo talteen. Viimein saat päänsäryn pois.");
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "JUO VETTÄ":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Onneksi tuli kerättyä vesipullo talteen. Viimein saat päänsäryn pois.");
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
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Ensiapulaukku();
                        Console.ResetColor();
                        break;
                }

            } else if (!Inventaario.esineet.Contains("vesipullo") && Inventaario.esineet.Contains("taskulamppu"))
            {
                Console.WriteLine("Buranapaketissa (A) on onneksi vielä tabuja jäljellä. Voit myös sulkea ensiapulaukun ja tutkia lisää keittokomeroa (B).\n");
                komento = Console.ReadLine();
                komento = komento.ToUpper();
                switch (komento)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Nyt on burana, mutta jostain pitäisi saada vielä vettä.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Nyt on burana, mutta jostain pitäisi saada vielä vettä.\n");
                        Console.ResetColor();
                        Keittokomero keittokomero = new Keittokomero();
                        keittokomero.Avaa();
                        break;
                    case "OTA VESIPULLO":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Hanasta ei tule mitään. Vettä pitäisi löytää jostain.");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "JUO VETTÄ":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Hanasta ei tule mitään. Vettä pitäisi löytää jostain.");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "LISÄÄ TASKULAMPPU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Kassissasi on jo taskulamppu.\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "OTA LAMPPU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Kassissasi on jo taskulamppu.\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "LISÄÄ LAMPPU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Kassissasi on jo taskulamppu.\n");
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
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Ensiapulaukku();
                        Console.ResetColor();
                        break;
                }

            } else //kun ei ole kumpaakaan esinettä kassissa
            {
                Console.WriteLine("Buranapaketissa (A) on onneksi vielä tabuja jäljellä. Voit myös tarkastella tuntematonta esinettä (B) tarkemmin.\n");
                komento = Console.ReadLine();
                komento = komento.ToUpper();
                switch (komento)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Nyt on burana, mutta jostain pitäisi saada vielä vettä.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "OTA VESIPULLO":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Hanasta ei tule mitään. Vettä pitäisi löytää jostain.");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "JUO VETTÄ":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Hanasta ei tule mitään. Vettä pitäisi löytää jostain.");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Nice, löysin taskulampun. Tästä voisi olla vielä hyötyä.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "LISÄÄ TASKULAMPPU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Taskulamppu lisätty Academy-kassiin.\n");
                        Inventaario inventaario = new Inventaario();
                        inventaario.LisaaEsine(esine);
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "OTA LAMPPU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Taskulamppu lisätty Academy-kassiin.\n");
                        Inventaario inventaario2 = new Inventaario();
                        inventaario2.LisaaEsine(esine);
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "LISÄÄ LAMPPU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Taskulamppu lisätty Academy-kassiin.\n");
                        Inventaario inventaario3 = new Inventaario();
                        inventaario3.LisaaEsine(esine);
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario4 = new Inventaario();
                        Console.WriteLine(inventaario4);
                        Console.ResetColor();
                        Avaa();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Ensiapulaukku();
                        Console.ResetColor();
                        break;
                }
            }
            
        }
    }
}
