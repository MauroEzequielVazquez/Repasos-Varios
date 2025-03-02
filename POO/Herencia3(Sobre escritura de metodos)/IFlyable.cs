using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3_Sobre_escritura_de_metodos_
{//definimos el metodo volar dentro de la  interfaz flyable. todas las clases que la implementen la van a  tener
    interface IFlyable 
    {
        // va sin public el metodo dentro de la interfaz   
         string volar(); 


    }
}
