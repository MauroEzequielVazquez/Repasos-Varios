using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_Dominio_Deposito__Actividad2
{
    internal class Program
    {
        //Desarrollar un modelo de dominio para resolver la administración de un depósito multipropósito.
        //Generar el diseño de las clases.
        //Sólo del modelo de dominio, SIN comportamiento, solo clases con
        //atributos y sus tipos.Se debe contemplar en el diseño las relaciones de Herencia y Asociación dentro del modelo.
        //El depósito a administrar puede ser cualquiera.Además, quizá se podrían llegar a administrar más de
        //un depósito desde la misma aplicación. Un depósito puede contar con “N” cantidad de pasillos, con lados y “N”
        //cantidad de compartimientos por lado.Cada compartimiento va a almacenar un tipo de producto.Puede que un compartimiento,
        //o inclusive un pasillo entero pertenezca a un cliente.Contemplar en el modelo todas las clases mencionadas y analizar
        //las que no.



//        Relaciones de Asociación:
//​

//Deposito → Pasillo(Asociación Uno a Uno o Uno a Muchos)

//Uno Depositotiene al menos uno Pasillo.
//Puede ajustarse a una relación uno a muchos si se permite más de un Pasillodentro de un Deposito.
//Pasillo → Lado (Asociación Uno a Uno o Uno a Muchos)

//Un Pasillo tiene un Lado, pero podría modificarse para permitir múltiples lados(izquierdo y derecho, por ejemplo).

//Lado → Compartimiento(Asociación Uno a Uno o Uno a Muchos)

//Un Lado contiene un Compartimiento, pero en una implementación realista, podría haber múltiples compartimentos en cada lado.
//Compartimiento → Producto (Asociación Uno a Uno)

//Un Compartimiento almacena un Producto.
//Cliente → Compartimiento y Cliente → Pasillo (Asociaciones Uno a Uno o Uno a Muchos)

//Un Cliente puede ser dueño de un Compartimiento o un Pasillo.
//En un escenario real, podría haber varios Compartimientoso Pasillos asociados a un Cliente.
//Relaciones de Herencia:




        static void Main(string[] args)
        {


        }
    }
}
