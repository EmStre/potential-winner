using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    class Keittokomero

    {

        public void Avaa()
        {
            string vastaus;
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
                    Avaa();
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
        }

        public void Ensiapulaukku()
        {
            string komento;
            string esine = "taskulamppu";
            Console.WriteLine("Buranapaketissa (A) on onneksi vielä tabuja jäljellä. Voit myös tarkastella tuntematonta esinettä (B) tarkemmin.\n");
            komento = Console.ReadLine();
            komento = komento.ToUpper();

            switch(komento)
            {
                case "A":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Nyt on burana, mutta jostain pitäisi saada vielä vettä.\n");
                    Console.ResetColor();
                    Ensiapulaukku();
                    break;
                case "B":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hittolainen, löysin taskulampun. Tästä voisi olla vielä hyötyä.\n");
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
