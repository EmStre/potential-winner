using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Peliluokkia
{
    public class Heikki
    {
        public string Vihje { get; set; }
        int indeksi = 0;

        string[] helpTekstit = File.ReadAllLines(@"..\..\..\Peliluokkia\HeikkiHelp.txt").ToArray();
        Random random = new Random();

        public string Help()
        {
        //Asettaa rivit random_järjestykseen
        string[] randomTekstit = helpTekstit.OrderBy(x => random.Next()).ToArray();
        foreach (var t in randomTekstit)
            {
                Console.WriteLine(t);
                indeksi++;
            }
            return Vihje;
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
