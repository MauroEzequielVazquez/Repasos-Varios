using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*       Hola! Cómo va?

       Vamos a trabajar con lo aprendido en ésta unidad.
       Te voy a dejar una serie de instrucciones para que vayas siguiendo y construyendo con el fin de poner en práctica y ver funcionando lo visto hasta aquí.

       Crear un proyecto de consola.Net Framework.
       Crear la clase Telefono(recordemos que una clase va en un archivo nuevo; click derecho en el proyecto, agregar, class).
       Agregale los siguientes atributos:
       Modelo string.
       Marca string.
       NumeroTelefonico string.
       CodigoOperador int (1, 2 o 3).

       Agregale las propiedades correspondientes.Podés hacer el formato largo o el corto.
       Modelo: solo lectura. Es decir, solo get.
       Marca: solo lectura.
       NumeroTelefonico: lectura y escritura.
       CodigoOperador: lectura y escritura.Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero.



       Agregar Constructor que reciba Modelo y Marca.
       Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono.
       Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
       Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto
       Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.

       Te propongo pensar alguna clase más, construirla y agregarle atributos, propiedades y métodos y hacer algunas pruebas; siempre teniendo en mente que la idea es representar la realidad en lo digital.

       No te olvides de la importancia de la práctica.

       Saludos.*/



            Telefono Telefono1 = new Telefono("S22", "Samsung");
            
       
            Telefono Telefono2 = new Telefono("15 PRO MAX", "Iphone");


            //ASIGNAMOS VALORES PARA PROBAR EL TELEFONO 1:

            Telefono1.NumeroTelefonico = 1137802708;
            Telefono1.CodigoOperador = 4;


            //ASIGNAMOS VALORES A OTRO OBJETO, TELEFONO 2

            Telefono2.NumeroTelefonico = 1154566360;
            Telefono2.CodigoOperador = 2;

            Console.WriteLine("Mi telefono tiene la marca y modelo : " + Telefono1.Marca + ", su modelo es " +  Telefono1.Modelo + " Su numero" +
                "telefonico es " +  Telefono1.NumeroTelefonico +  " y su codigo de operador es " + Telefono1.CodigoOperador );


            Console.WriteLine("El otro telefono ( tel 2 ) tiene la marca y modelo : " + Telefono2.Marca + ", su modelo es " + Telefono2.Modelo + " Su numero" +
                "telefonico es " + Telefono2.NumeroTelefonico + " y su codigo de operador es " + Telefono2.CodigoOperador);


            //Probamos los metodo creados, el comun y otro con la sobrecarga
            Console.WriteLine(Telefono1.Llamar());

            Console.WriteLine(Telefono1.Llamar("Micaela"));




            Console.WriteLine(Telefono2.Llamar() + "esta llamada pertenece al telefono2");
            Console.WriteLine(Telefono2.Llamar("Pancho"));

            Console.ReadKey();  





        }
    }
}
