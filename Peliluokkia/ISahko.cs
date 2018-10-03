using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    interface ISahko
    {
        void SahkotPaalla();

        void SahkotPois();

        bool Electricity { get; }
    }
}
