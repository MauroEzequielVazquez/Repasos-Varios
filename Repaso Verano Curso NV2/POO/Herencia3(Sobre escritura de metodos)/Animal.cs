using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3_Sobre_escritura_de_metodos_
{
    internal class Animal
    {
        //como todos los animales emiten un ruido vamos a crear un metodo para el mismo..

        //NOTA !!! ---> PARA UN METODO SER sobreescrito debe llevar la palabra clave VIRTUAL
        // AL MENOS QUE SEA escrito de la clase objetc , donde tampoco se le puede poner el nombre
        // como aca, sino que lleva el nombre original de la clase object

        public int Color { get; set; }
        public virtual string Comunicarse()
        {
            return "ruido ruido";
        }

    }
}
