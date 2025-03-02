using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_Dominio_Deposito__Actividad2
{
    internal class Compartimiento : EntidadBase
    {
     
        public Producto Producto { get; set; }
        public Cliente Cliente { get; set; }
    }
}

