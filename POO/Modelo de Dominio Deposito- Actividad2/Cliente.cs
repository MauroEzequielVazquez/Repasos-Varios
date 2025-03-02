using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_Dominio_Deposito__Actividad2
{
    internal class Cliente : EntidadBase
    {
  
        public string Contacto { get; set; }
        public Pasillo Pasillo { get; set; }
        public Compartimiento Compartimiento { get; set; }

    }
}
