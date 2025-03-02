using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2_Ventas_
{
    internal class Articulo
    {

        // TERCER FORMA, MEDIANTE FORMA SIMPLIFICADA, OJO!! NO SE PUEDE PONER CONDICIONES EN AL SETEAR!!!
        // en Lugar de tener los atributos de forma private los tenemos public y ahi mismo hacemos
        // el set y get
        // Escribimos la palabra prop y apretamos tab 2 veces.. me genera la prop resumida

        public int codigoArticulo { set; get; }
        public float precio { get; set; }

        // que pasa si quiero manipular el set y el get, x ej quiero manipular el cod de marca
        // si este tiene que ir de 1 a 10, tengo que manipularlo como el atributo privado por un lado
        // y las propiedades por otro

        private int codMarca;
        public int CodMarca
        {
            get { return codMarca; }

            set
            {
                if (value > 0 && value < 11)

                    codMarca = value;
                else // si no cumple
                    codMarca = -1;
            }
        }
    }
}
