using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3_Sobre_escritura_de_metodos_
{
    internal class Gato : AnimalDomestico
    {

        // vamos a sobreescribir el metodo comunicarse heredado de animal

        public override string Comunicarse()
        {
            return "MIAU MIAU";
        }
    }
}
