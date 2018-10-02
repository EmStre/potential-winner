using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    public class Kaytava
    {
        public void Avaa()
        {
            Console.WriteLine("Olet hämärässä käytävässä, jonka toisessa päässä on keittiö (A), toisessa porraskäytävä (B).\n\n" +
                "Lisäksi käytävän varrelta löytyvät luokat Lovelace (C), Hopper (D), Jobs (E) ja Gosling (F) sekä konsolipelinurkkaus (G) ja varasto (H).");
            Console.ReadLine();
        }
    }
}
