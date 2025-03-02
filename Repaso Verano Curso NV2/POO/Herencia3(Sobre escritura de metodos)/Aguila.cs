using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3_Sobre_escritura_de_metodos_
{
    internal class Aguila : AnimalSalvaje, IFlyable
    {
       public  string volar()
        {
            return "vuela como un aguila";
        }
    }
}
