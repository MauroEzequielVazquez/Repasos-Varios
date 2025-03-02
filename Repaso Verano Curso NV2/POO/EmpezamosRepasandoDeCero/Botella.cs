using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpezamosRepasandoDeCero
{
    internal class Botella
    {

        //CONSTRUCTORES 

        //PEQUEÑA FUNCION QUE ES DE TIPO PUBLIC,  tiene EL MISMO nombre que la CLase y puede tener
        //parametros O NO,si creas uno llamado Botella, pisas el heredado por la clase objetc
        //y te va  a pedir parametros donde habiamos cargado 1 valor en la instancia Botella1
        // El constructor lo que hace es dar la instancia a la clase para generar el objeto y le da
        //esos valores inciiales a dicho objeto, como dijmos CON o SIN parametros. 


        //Ejercicio para practicar metodos y constructores
        //Creamos una botella con una capadidad maxima de 100, dentro del constructor
        // Cantidad actual,,inicia en 0
        //metodo de regarca : Inicia al 100 y DEVuelve el costo a recargar,,50 por cada 100 ml cargados


        //ej de Constructor

        public Botella (string color, string material)
        {        //this. color es "YO BOTELLA" , a mi color,,asignale el color que vino x parametro
            this.color = color; 
            this.material = material;
            capacidad = 100; // la botella nace con caapacidad 100 y cant actual 0
            cantidadActual = 0;




        }

        // Sobrecargar el constructor ( Volver a crear el mismo constructor pero con dif caract)
        // TIENE QUE CAMBIAR LA FIRMA DEL CONSTRUCTOR...osea los parametos que recibe, cant y tipo

        // Se hace igual, con el mismo nombre de la clase pero por ej en este casi creo uno sin parametro
        // PODEMOS TENER todos los constructores que querramos..

        //Destructores...no se trabajan en C#, se usa el famoso Garbage Collector, para admiistrar y limpiar
        //La memoria, al ver objetos, variables y  memorias q no se utilizan
        ~Botella() { } //Asi se declara un DESTRUCTOR, que repito NO USAREMOS


        public Botella() { }



        private int capacidad;
        private string color;
        public string material { get; set; }
        private int cantidadActual;
        private float monto;



        //public void SetCapacidad(int c)
        //{
        //    capacidad = c;
        //}

        //public int GetCapacidad()
        //{
        //    return capacidad;
        //}


        // POPIEDADES.... Es como lo maneja puntualmente C#

        public string Color  // NOTA!!! No se puede llamar igual que el atributo, usar nombre de fun con  Minuscula
        {
            get { return color; }
            set { color = value; }


        }



        public int Capacidad
        {
            get
            {
                return capacidad;
            }

        }


        public int CantidadActual
        {
            get
            {
                return cantidadActual;
            }
        }

        public float Monto
        {
            get
            {
                return monto;
            }
        }


        //METODO PARA RECARGAR LA BOTELLA

        public float recargarBotella()
        {

            if (cantidadActual > 0)
            {
                int diferencia = capacidad - cantidadActual;
                //  100 _______50
                //  dif______ X = ??
                float monto = diferencia * 50 / 100;
                cantidadActual += diferencia;
                return monto;
            }

            cantidadActual = 100;
            return  50;

        }

        //Sobrecarga del metodo recargar, en esta sobrecarga PODEMOS ELEGIR CUANTO CAGAR

        public float recargarBotella(int cantidad)
        {
            cantidadActual += cantidad;
            return cantidad * 50 /100;

            //100____ 50
            // cantidad _____ x = ??? 
        }







    }




}
