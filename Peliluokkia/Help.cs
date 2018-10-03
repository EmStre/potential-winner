using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    public class Help
    {
        public Help()
        {

        }
        public override string ToString()
        {
                return "\nPelikomennot ovat:\n" +
                "KASSI: näyttää Academy-kangaskassisi sisällön.\n" +
                "AVAA x: avaa kohteen, jos mahdollista. Muuten palauttaa: 'Epäkelpo valinta'\n" +
                "OTA x: ottaa kohteen ja pakkaa sen kassiin, jos mahdollista. Muuten palauttaa: 'Epäkelpo valinta'\n" +
                "HELP: näyttää tämän listan.\n";
        }

        //Main classissa luokka toimii jotenkuten näin
        //Inventaario inv = new Inventaario();
        //inv.LisaaEsine("taskulamppu");
        //inv.LisaaEsine("avain");
        //Console.WriteLine(inv.ToString());
        //Console.ReadKey();

    }
}
