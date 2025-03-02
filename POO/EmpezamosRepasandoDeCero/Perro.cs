using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpezamosRepasandoDeCero
{
    internal class Perro
    {
        private string Nombre;
        private string Color;
        public string Origen { get; set; }
        // Usando 2 funciones para el set / get
        public void SetNombre( string n)   
        {
            Nombre = n;
        }

        public string getNombre()
        { return Nombre; }


        // Usando Propiedades

        public string color
        {
            get { return Color; }
            set { Color = value; }
        }


    }
}
