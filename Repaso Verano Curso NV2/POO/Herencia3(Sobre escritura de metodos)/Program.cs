using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3_Sobre_escritura_de_metodos_
{
    internal class Program
    {
        static void Main(string[] args)

        {
            AnimalDomestico  AD1 = new AnimalDomestico();
            Gato G1 = new Gato();
            

            //AD1.Nombre = "Pirka";

            //Console.WriteLine(AD1.ToString());// metodo heredado de la clase object, no me sirve de nada
                          // por eso voy a SOBRE ESCRIBIR el metodo heredado de la clase base, en este caso clase object
            
            //Console.WriteLine(AD1.Comunicarse());
            
            //Console.WriteLine("El gato al comunicarse hace: " + G1.Comunicarse());




            // Vamos a crear una lista de animales, como todos ellos pertenecen a la familia, puedo meterlos
            // dentro de mi lista sin problemas

            //List <Animal> animales = new List<Animal>();
            //animales.Add(AD1);
            //animales.Add(G1); //agrego el objeto que esta referenciado a una variable y a su vez a la posicion en la lista, en este caso g1
            //animales.Add(new Canario()); //agrego un objeto que esta referenciado a la posicion / ubicacion en la lista.
            //animales.Add(new Tigre());  //ESTOS OBJETOS no van a poder ser accedidos de otro lado que no sea la lista
            //animales.Add(new Aguila());                     //al menos que luego los referencie a una variable

            


            Animal A1 = G1; // el gato que es el que esta a la derecha, conoce a Animal,, puedo hacer esto

            // si yo quiero hacer

            // A1.Nombre  NO VOY  poder, xq si bien con gato se puede ver el nombre, con animal solo puedo
            // ver son las prop y metodos que defina a nivel animal y a nivel animal no defini nombre

            // para poder ver la prop nombre desde animal, hago esto

            // CASTEO EXPLICITO!!! con esta sentencia le  ASEGURO AL ANIMAL QUE ES UN GATO, xq Animal no conoce a gato

            //Gato G8 = (Gato) A1;
            // G8.Nombre = "Manchitas";


            // foreach (Animal item in animales)
            // {
            //     Console.WriteLine(item.Comunicarse());

            // }

            // esto que sucede, donde cada animal se comunica como sabe hacer, se llama POLIMORFISMO
            // ES LA CARACTERISTICA QUE TIENEN LOS OBJETOS DE FRENTE A UN MISMO ESTIMULO, RESPONDER
            // DE MANERA DISTINTA, osea que el gato dice miau, el perro guau, etc..., si bien el estimulo
            // es el mismo ( COMUNICARSE ) , ellos responder de maneras distintas. 





            // INTERFACES / CONTRATOS

            //Si bien c# no trabaja la herencia compartida, podemos simularla con las interfaces
            // La interfaz es un contrato , que vamos a implementar en alguna clase y esa clase tiene que
            // cumplir lo que esa interfaz define, ejemplo un comportamiento, define el QUE y no el COMO
            // una clase debe implementar determinado metodo pero no define como, eso lo define la clase
            // la clase que implementa una interfaz, tiene que contar con un metodo c ese nombre, vemos el ej en animal salvaje

            // para que usamos interfaces?
            // 1.Para obligar a implementar dichos metedos que de define la interfaz. (puede heredar de 1 sola clase pero implementar las interfaz q quieras)
            //2. Sirve para segmentar objetos,, por lo que sea, en el ejemplo vamos a ver segmentado x animales que vuelan

            // vemos el ejemplo de segmentar animales por un tipo

            // NO SE PUEDE CREAR UNA INSTANCIA DE UNA INTERFAZ o de un tipo ABSTRACTO  IFlyable f1 = new IFlyable();
            //ENTONCES CREO una instancia de una LISTA de voladores


            List<IFlyable> listaVoladores = new List<IFlyable>();
            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Aguila()); 
    







            Console.ReadKey();




        }
        
    }
}
