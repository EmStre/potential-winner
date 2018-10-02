using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    //Taskulampun päälläoloa tarkasteleva rajapinta. Metodit päällä/pois, ominaisuus LamppuPäällä.
    public interface ILamppu
    {
        
        void Päällä();
        void PoisPäältä();

        bool LamppuPäällä { get; }




    }
}
