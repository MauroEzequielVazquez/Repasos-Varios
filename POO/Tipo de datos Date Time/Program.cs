using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipo_de_datos_Date_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Date Time es un tipo de dato struc
            // el Struc es un tipo de dato valor, no maneja la referencia separada , va a conglomerar internamente varias variables
            // tiene "superpoderes", si bien no es 1 clase, implementa INTERFACES, tiene atributos y constructores


            // como le podemos dar valores al tipo de dato date time?
            // 1.podemos hacer una instancia y ponerle valores al constructor (el cual tiene muchisimas sobrecargas)

            // DATE TIME TE DA FECHA Y HORA


            DateTime fecha = new DateTime(2024, 04, 1);// si no le cargas datos te da 1/1/1 a las 12am
            Console.WriteLine("La fecha es:" + fecha.ToString());

            //otra forma de cargarlo sin hacer una isntancia es:

            DateTime fecha2 = DateTime.Now; //toma la fecha ACTUAL DEL SISTEMA
            Console.WriteLine("La fecha es :" + fecha2.ToString());
            Console.WriteLine("La fecha es :" + fecha2.AddDays(2) + "agrego 2 dias con  el metodo Add Days, puedo hacer lo mismo con horas, minutos, etc");
            Console.WriteLine("La fecha es :" + fecha2.ToShortDateString() + " me muestra sol la fecha");
            Console.WriteLine("La fecha es :" + fecha2.ToShortTimeString() + " me muestra sol la hora");
            Console.WriteLine("El mes es:" + fecha2.Month);
            Console.WriteLine("El año es: " + fecha2.Year);

            // algo mas personalizado con metodo ToString

            Console.WriteLine("La fecha es :" + fecha2.ToString("dddd mm / yyyy")); // cuatro dddd te dice el dia de la semana

            Console.ReadKey();
















        }
    }
}
