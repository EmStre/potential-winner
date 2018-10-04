using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Peliluokkia
{
    public class Heikki
    {
        public string Vihje { get; set; }
        int indeksi = 0;


        string[] helpTekstit = File.ReadAllLines(@"..\..\..\Peliluokkia\HeikkiHelp.txt").ToArray();
        Random random = new Random();

        public void Help()
        {
        CultureInfo.CurrentCulture = new CultureInfo("fi-FI");
        //Asettaa rivit random_järjestykseen
        string[] randomTekstit = helpTekstit.OrderBy(x => random.Next()).ToArray();

            
                Console.WriteLine(randomTekstit[0]);
                indeksi++;
            
            //return Vihje;
        }
    }
            //Esim näin pääsee mainissa tätä käyttämään
            //Heikki help = new Heikki();
            //string syote = Console.ReadLine();
            //if (syote.Equals("help"))
            //{
            //    help.Help();
            //}
            //Console.ReadKey();
}
