using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_Dominio_Deposito__Actividad2
{
    
    //Para aplicar el concepto de herencia, pagclase base queIdy Nombreestán presentes en Deposito, 
    // Pasillo, Lado, Compartimiento, Productoy Cliente.


    internal class EntidadBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
