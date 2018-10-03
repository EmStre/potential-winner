using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    class Varasto
    {
        string vastaus;
        public void Avaa()
        {
            Console.WriteLine("Varasto on pilkkopimeä ja täynnä viinalaatikoita. Pimeässä on hankala lähteä etenemään.\n" +
                "Muistat, että sähkökaappi löytyy varaston perältä! Olisikohan siellä sellainen varavirtakytkin kuten leffoissa.");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":    
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
                    Console.ResetColor();
                    Avaa();
                    break;
            }
        }
    }
}
