using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_Dominio_Deposito__Actividad2
{
    internal class Producto : EntidadBase
    {

        public string Modelo { get; set; }

        public string Codigo { get; set; }

        public  string  Precio { get; set; }

        public string Descripcion { get; set; }
        public string Categoria { get; set; }
    }
}

