using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pelitesting
{
    public class Inventaario
    {
        //Inventaario luokka, lisää löydetyt esineet kassiin
        public string Esine { get; set; }
        List<string> esineet = new List<string>();

        public Inventaario()
        {

        }
        public Inventaario(string esine)
        {
            Esine = esine;
        }
        public void LisaaEsine(string esine)
        {
            esineet.Add(esine);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var e in esineet)
            {
                sb.Append(e + "\n");
            }
            string kassinSisalto = sb.ToString();
            return "Academy kangaskassissasi on tällä hetkellä: \n" + kassinSisalto;
        }

        //Main classissa luokka toimii jotenkuten näin
        //Inventaario inv = new Inventaario();
        //inv.LisaaEsine("taskulamppu");
        //inv.LisaaEsine("avain");
        //Console.WriteLine(inv.ToString());
        //Console.ReadKey();

    }
}
