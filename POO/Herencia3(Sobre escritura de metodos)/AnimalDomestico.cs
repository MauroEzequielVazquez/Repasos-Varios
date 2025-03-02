using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3_Sobre_escritura_de_metodos_
{
    internal class AnimalDomestico : Animal
    {

        public string Nombre { get; set; }


        // asi se sobre escribe un metodo

        public override string ToString()
        {
            //return base.ToString(); por defecto me arma esto q seria devolveme de mi clase base el metodo tostring
            // NO tiene sentido

            return "Animal " + Nombre;  // AHORA el metodo Tostring me devuelve : Animal + Nombre
        }
    }
}
