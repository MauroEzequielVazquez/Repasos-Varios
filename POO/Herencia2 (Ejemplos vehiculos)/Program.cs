using System;
using System.Collections.Generic;// es necesario para crear 1 coleccion
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2__Ejemplos_vehiculos_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto A1 = new Auto();
            Vehiculo V1 = new Vehiculo();
            V1.Motor = "EN linea";



            // El Vehiculo tiene motor pero NO cant max de peso ,
            //porque??

            // la relacion dentro de la jerarquia es de ABAJO hacia arriba,
            // la camioneta ES un vehiculo pero el vehiculo NO sabe que clases tiene debajo 
            Camioneta C1 = new Camioneta();
            C1.CargaMaxima = 1000;



            Camioneta c2 = new Camioneta();
            c2.Color = "Blue";

            Camioneta c3 = new Camioneta();
             
            c3.Color = "Red";

            //OJOO!!
            // a mi vehiculo2 le asigno una nueva instancia de camioneta
            // Esto pasa porque una camioneta es de la familia de vehiculos, ES un vehiculo
            // yo puedo guardarlo pero si yo hago una camioneta dentro al reves 
            //Camioneta 2 = new Vehiculo();

            // me da error porque no se si un vehiculo es una camio pero SI se que una camio es un vehiculo.

            Vehiculo V2 = new Camioneta();




            // COLECCIONES // EVOLUCION DEL VECTOR... TENEMOS VARIAS PERO VAMOS A USAR LAS TIPO LISTAS

            //no hace falta marcar el tamaño, y podes trabajar / manipular muchos objetos con 1 solo objeto que es la lista

            //Las colecciones mas usadas son las tipo SETS(CONJUNTOS), MAPAS Y LISTAS..
            //Algunas son mas rapidas q otras, algunas permiten objetos repetidos otras no,,etc.


            //dentro de <> tenemos que poner el tipo de objeto que vamos a manipular, <> significa q es generico pero igual tengo q definirlo

            // usamos un tipo listado de camionetas

            List  <Camioneta> listaCamionetas = new List <Camioneta>();

            listaCamionetas.Add (C1);// AGREGO un elemento a la lista de camionetas

            listaCamionetas.Add(c2);

            listaCamionetas.Add(c3);

           

            //para saber la cantidad de elementos de mi lista

            Console.WriteLine ("La cantidad de elementos de mi Coleccion es: " + listaCamionetas.Count);    

            //Como muestro una posicion en especifica de la lista? se hace como en los vectores

            Console.WriteLine ("El color de la camioneta en la posicion 2, indice 1 es " + listaCamionetas[1].Color);

            //mismo asi puedo manipular el dato.. ej


            listaCamionetas[1].Color = "Black";

            Console.WriteLine("El color de la camioneta en la posicion 2, indice 1 es " + listaCamionetas[1].Color);

           

            //Para recorrer estas listas  / colecciones vamos  a utilizar el famoso FOREACH

            foreach (Camioneta item in listaCamionetas) // in ----> la coleccion a recorrer. donde dice var puedo dejarlo 
                                                  //o Ponerle Camioneta, lo mismo con item , puedo dejarlo o modificarlo paara q sea mas especifico
            {
                Console.WriteLine("El Color del item es " +  item.Color);
            }
            //Esto va a recorrer la lista hasta que termine, y en cada vuelta ( no importa la cantidad )
            //la cantidad de elementos que tenga esta lista es la cantidad de vueltas que va a dar,
            // y en cada 1 de esas vueltas va a agarrar el elemento siguiente y guardarlo en la variable item

            listaCamionetas.Remove(c3);// REMUEVO /QUITO un elemento

            Console.WriteLine("La cantidad de elementos de mi Coleccion es: " + listaCamionetas.Count);


            A1.motor = new Motor(); // le asigno un motor al auto

            A1.motor.CaballosFuerza = "145 cv"; // auto . motor . la carac del motor xq el auto TIENE un motor
                                                // y meto ese objeto DENTRO de otro

            //Auto A2 = new Auto("Verde"); // nace el auto 2 con el chasis verde

            Console.WriteLine(A1.ToString()); // METODO sobre escrito de la clase objetc



            Console.ReadKey();  





        }
    }
}
