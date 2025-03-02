using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Mostramos un poco la Clase String

            string nombre = "Mauro";

            nombre = "Hola como estas " + nombre;

            //  ALGUNAS Funciones del Framewokr ya armadas para la Clase STRING

            //Muestro toda la cadena de texto en minusculas
            nombre.ToLower();

            // Cuantos caracteres tiene esta variable string

            int cantidadCaracteres = nombre.Length;



            //Transformo la cadena a mayusculas, EN EL MOMENTO
            nombre.ToUpper();



            // si quiero dejarlo fijo en mayusculas

            nombre  =   nombre.ToUpper();


            // UNO MUY USADO ES EL METODO REEMPLAZAR... REPLACE ( cambia un caracter viejo x uno nuevo)
            //si reemplazo caracteres van con ' ' simple y si reemplazo cadena con " " ...

           //nombre = nombre.Replace('A', 'E');


            // NOTA !! SI el caracter ORIGINAL estaba en mayus, en el REPLACE tiene que estar
            // TAL CUAL para que lo identifique..




            // Ejemplo del metodo Replace , reemplazando una cadena de caracteres y no uno solo
            // es una sobrecarga de este metodo, ya otorgada por el Framework


            nombre = nombre.Replace("HOLA", "CHAU");

            Console.WriteLine(nombre.ToUpper() + " y su cantidad de caracteres es "+ cantidadCaracteres);

            //nombre = Console.ReadLine(); El metodo ReadLine ya devuelve un string de por si,
                                        // pero eso no hacemos la conversion
           





            Console.ReadKey();







        }
    }
}
