using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2__Ejemplos_vehiculos_
{
    internal class Auto
    {
        // constructor., 
        public Auto() 
        { 
        
         Chasis = new Chasis();  // cuando el auto nace, nace con chasis , x eso es asociacion de COMPOSICION
        
        }   

      


        public string Modelo { get; set; }

        public int Año { get; set; }

        public string Color { get; set; }



        // ASOCIACION ----->  SE DIVIDE EN COMPOSICION  / AGREGACION

        // LA RELACION SE LEE CON TIENE, un auto tiene.. . una persona tiene..
        // A diferencia de HERENCIA que se lee con ES,, un auto es, ,una persona es..


        // COMPOSICION ...  xq el AUTO DEBE NACER CON UN CHASIS

        public Chasis Chasis { get; } // SOLO obtener, no vamos a modificar el chasis
                                    


        // Agregacion
        public Motor motor { get; set; }




        public override string ToString()
        {
            return "rum rum";
        }

  


    }
}
