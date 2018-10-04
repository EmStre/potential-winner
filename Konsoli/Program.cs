using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Peliluokkia;
using System.Globalization;

namespace Konsoli
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("fi-FI");
            Console.WindowHeight = 50;
            Console.WindowWidth = 185;
            Intro.KutsuIntro();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Black;
            Hejlsberg hejlsberg = new Hejlsberg();
            Kaytava kaytava = new Kaytava();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pelissä käytettävät komennot saat näkyviin kirjoittamalla HELP\n");
            Console.ResetColor();
            Console.WriteLine("Istut perjantai-iltana yksin C#-ryhmän Hejlsberg-luokassa kun huomaat kattolamppujen valon värisevän.\n" +
                "Hetken päästä säpsähdät, kun suuren pamauksen saattelemana valot yhtäkkiä sammuvat ja kannettava tietokoneesi samalla pimenee.\n" +
                "Istut hetken yllättyneenä pimeässä luokassa ihmetellen tapahtunutta.\n" +
                "Vilkaiset kännykästäsi kelloa ja toteat sen olevan 23:18. Huomaat samalla kännykän kuuluvuuskentän olevan nollassa ja akkua jäljellä 1%. Juuri tuolloin puhelimesikin sammuu.\n");
            hejlsberg.Avaa();
            GameOver.KutsuGameOver();
            Inventaario.esineet.Contains("taskulamppu");




        }
    }
}
