using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EmpezamosRepasandoDeCero
{
    internal class Persona
    {
        //Atributos o Miembros de mi Clase Persona

        // usan un Modificador de visibilidad private
        private int Edad;
        private float Sueldo;
        private string Nombre;

        //creo un constructor para darle un nombre

        public Persona ( string Nombre)
        {

            this.Nombre = Nombre;
        }



        //¿Como seteo y leo el valor de ese atributo si es privado?

        // Vamos a crear 1 funcion para leer y otra para setear dichos atributos


        public void SetEdad(int e) // Func de tipo VOID ( no devuelve nada y recibe 1 valor
        {
            Edad = e;
        }


        public int GetEdad() // funcion de tipo entero que no recibe parametros y retorna la edad
        {
            return Edad;
        }



        // la forma de leer y escribir los atributos con 2 func, las hago solo con 1 atributo para practicar



        // Manejamos los atributos con las PROPIEDADES

        //Creamos una funcion sola tipo public para seterar y guetear

        public float sueldo
        {
            get { return Sueldo; }
            set { Sueldo = value; }


        }

        //Metodos: Los metodos de esta clase, van a  ser "comportamientos" de esta clase , osea del objeto Persona
        //Ese objeto Persona NO solo va a tener su infomacion mediante atributos/props, sino tmb va a
        //tener comportamientos, esos comportamientos van a ser los comportamientos q va a tener
        //Los metodos tienen que ser public como las funciones

        //Ej

        public string Saludar()
        {

        return "Hola soy "+ Nombre;
        }
    
        // Vamos a  sobrecargar el metodo saludar, hay que cambiar la firma, mantenemos
        //tipo de dato y nombre pero cambiamos los parametros

        //Ejemplo de sobrecarga de metodo que va a saludar a alguien y dice mi nombre
        public string Saludar(string personaje)
        {
            return "Hola" + personaje + "soy " + this.Nombre;
        }
    


    }
}
