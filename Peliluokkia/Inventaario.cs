using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    public class Inventaario
    {
        //Inventaario-luokka, lisää löydetyt esineet kassiin
        public string Esine { get; set; }
        public static List<string> esineet = new List<string>();

        public Inventaario()
        {

        }
        public Inventaario(string esine)
        {
            Esine = esine;
        }
        public void LisaaEsine(string esine)
        {
            if (!esineet.Contains(esine))
            {
                esineet.Add(esine);
            }
            else
            {
                Console.WriteLine("Oops, tämä esine on jo kassissasi!");
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var e in esineet)
            {
                sb.Append(e + "\n");
            }
            string kassinSisalto = sb.ToString();
            if (kassinSisalto.Length == 0)
                return "\nKassisi on tyhjä.\n";
            else
            return "Hienossa ACADEMY-kangaskassissasi on tällä hetkellä: \n- " + kassinSisalto;
                }

        //Main classissa luokka toimii jotenkuten näin
        //Inventaario inv = new Inventaario();
        //inv.LisaaEsine("taskulamppu");
        //inv.LisaaEsine("avain");
        //Console.WriteLine(inv.ToString());
        //Console.ReadKey();

    }
}
