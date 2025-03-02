using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpezamosRepasandoDeCero
{
    internal class Program
    {                  

        //CLASES ... las vamos a utilizar para MANIPULAR la estructura de un dato, veamos varios ejemplos:
         //La idea de POO es MANIPULAR los datos todos juntos y no por separado, en lugar de tener varias
         // variables y cada una con una caracteristica, trabajarlas todas juntas dentro del objeto.
        static void Main(string[] args)
        {

            Persona Persona1 = new Persona("Mauro");

            //Persona1.SetEdad(20); // Se setea con el valor entero entre ()
            //Console.WriteLine("La edad del objeto Persona1 es : " + Persona1.GetEdad());
            //Persona1.sueldo = 200000;
            //Console.WriteLine("El sueldo de la Persona es =  : " + Persona1.sueldo);

            //LEEMOS METODOS
            //Console.WriteLine(Persona1.Saludar());
            //Console.WriteLine(Persona1.Saludar("Don Pepito"));

            //float  valor = 1.233F;// hay que marcarle q es float
            //Console.WriteLine(valor.ToString("0.00"));
            //tostring transforma el num a texto y el metodo tostring ya viene con 4 sobrecargas internas del metodo




            Botella Botella1 = new Botella("rojo", "plastico");// le pongo param xq cree un constructor
           // Botella1.SetCapacidad(20);// Si lo hago con PROPIEDADES asigno con = y no cn ()
            //Console.WriteLine("La capacidad de la botella es : " + Botella1.GetCapacidad());
           // Botella1.color = "Azul"; // al crear una propr, directamente MANIPULO el atributo y no llamo a la func
           // Console.WriteLine("El color asignado a mi Botella1 es :" + Botella1.color);


            Console.WriteLine("La capacidad de la botella es: " + Botella1.Capacidad);
            Console.WriteLine("La cantidad actual de la botella es: " + Botella1.CantidadActual);

            Botella1.recargarBotella(20);
            Console.WriteLine("La cantidad actual de la botella es: " + Botella1.CantidadActual);

            Botella1.recargarBotella();
            Console.WriteLine("La cantidad de liquido de la botella LUEGO DE SER RECARGADA nuevamente por el metodo original ES " + Botella1.Capacidad);
            
           //Console.WriteLine("El monto a pagar es:" + Botella1.Monto);




            //Perro Perro1 = new Perro();
            //Perro1.SetNombre ("Pirka"); // va entre () cuando use 2 funciones separadas para set y get
            //Console.WriteLine("Su nombre es : " + Perro1.getNombre());
            //Perro1.color = "Marron";
            //Console.WriteLine("El color de mi perrito es:" + Perro1.color);







            Console.ReadKey();



            //!! NOOOOTA :Fijarme que los atributos figuran como una llave INGLES
           // y que cuando hago las Propiedades, la func se llame IGaul que el atributo pero con Minuscula
           //y el retunr atributo y el value van con la primera MAYUSCULA como se crearon


        }
    }
}
