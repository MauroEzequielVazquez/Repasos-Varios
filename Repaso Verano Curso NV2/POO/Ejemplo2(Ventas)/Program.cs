using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2_Ventas_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Primer lote con 10 registros de productos, cada producto tiene:
            - codigoArticulo ( 3 digitos no correlativos)
            - precio
            - codigoMarca ( DEL 1 AL 10)

            Segundo Lote con las ventas de la semana. Cada lote tiene:
            - codigoArticulo
            - Cantidad
            - CodigoCliente ( 1 al 100)
            Este lote corta con Codigo Cliente cero. */

            //Articulo Articulos = new Articulo(); // creo instancia, objeto de la clase articulo

            // En lugar de crear 3 vectores y en cada uno 10 elem
            // xq son 3 atributos que tiene un articulo, y tener que leerlos, recorrer y todo por separado
            // me creo 1 vector de articulo que  dentro tenga 10 objetos articulos..


            Articulo[] articulos = new Articulo[10];

            // Articulos[6].CodMarca = 6;  ej, TRABAJAS TODO junto en 1 solo vector


            // como cargo ?

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("ingrese los datos del producto");
                Console.WriteLine("Código -  3 digitos No coorelativos");
                articulos[x].codigoArticulo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el precio");
                articulos[x].precio = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el codigo de Marca ( 1 al 10)");
                articulos[x].CodMarca = int.Parse(Console.ReadLine());

                //  TRABAJAMOS todo en 1 solo vector y no en 3 vectores como antes, uno para
                // cada propiedad, habia que cargarlos y recorrerlos por separado...
                // YA TENEMOS cargado el Vector COMPLETO con los 10 articulos

                Venta venta = new Venta();  // Creo objeto venta de tipo venta 


                Console.WriteLine("Ingrese la venta");

                Console.WriteLine("Ingrese el Codigo de cliente");
                venta.CodigoCliente = int.Parse(Console.ReadLine());

                while (venta.CodigoCliente != 0) // si se cumple, entro al ciclo y pido los datos
                                                 // xq el corte era si es cero
                {
                    Console.WriteLine("ingrese la Cantidad Vendida");
                    venta.Cantidad = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el Codigo de Cliente");
                    venta.CodigoArticulo = int.Parse(Console.ReadLine());

                    // trabajamos

                    // pido nuevamente el CodCliente aver si sigue el ciclo
                    Console.WriteLine("Ingrese el Codigo de cliente, ingrese 0 para cortar la carga");
                    venta.CodigoCliente = int.Parse(Console.ReadLine());



                }



            }
        }
    }
}
