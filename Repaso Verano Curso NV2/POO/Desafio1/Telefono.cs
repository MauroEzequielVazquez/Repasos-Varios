using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Telefono
    {


        //Agregale los siguientes atributos:

        // Modelo string.
        //Marca string.
        //NumeroTelefonico string.
        //CodigoOperador int (1, 2 o 3).


        private string modelo;
        private string marca;
        private int numeroTelefonico;
        private int codigoOperador;



        //Agregale las propiedades correspondientes. Podés hacer el formato largo o el corto.
        public string Modelo { get; }
        

        public string Marca { get; }

        public int NumeroTelefonico { get; set; }

        public int CodigoOperador
        {
            set
            {
                if (value >= 1 && value <= 3)


                    numeroTelefonico = value;

                else
                    numeroTelefonico = 0;

            }

            get { return numeroTelefonico; }
        }
    


            // Agregar Constructor que reciba Modelo y Marca, osea que el telefono nace con mod y marca

            public Telefono ( string Modelo, string Marca)
        {

            this.Modelo = Modelo;
            this.Marca = Marca;

        }


        //Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".

        public string Llamar()
        {
            return "Realizando llamada...";

        }

        //Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto


        public string Llamar( string contacto)
        {

            return "LLamando a " + contacto;
        }


    }

} 



