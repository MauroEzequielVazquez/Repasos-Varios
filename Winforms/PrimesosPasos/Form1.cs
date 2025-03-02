using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimesosPasos
{ 
    // Tenemos el modificador partial (vimos public, static, abstract, etc)


    public partial class Form1 : Form // Form1 hereda de la clase Form, la clase Form nos permite hacer que 1 clase se convierta en 1 ventana
    {
        // aca dentro voy a definir la FUNCIONABILIDAD DE LA CLASE  
        public Form1() // ESTO ES un CONSTRUCTOR..
        {
            InitializeComponent();//el Constructor llama a esta funcion que lo que hace es
                                  //que todo lo que modifique de manera visual, me genera el 
                                  // Código x detras, tmb puedo hacerlo solo x codigo
                                  //Esto seria el Form1.Designer.Cs, donde se va autogenerando
                                  //el codigo que hago de manera visual
        }




        //EVENTO ---> Es un metodo asociado a 1 determinado contexto,en este caso al ahcer CLICK al boton

        //METODO QUE SE VA A EJECUTAR CUANDO SE HAGA CLICK en el boton saludar

        // Esa accion se llama EVENTOOOOOO
        private void button1_Click(object sender, EventArgs e)
        {

         // Para mostrar algo x pantalla uso esto
          //  MessageBox.Show("Hola mundo");

            string texto = txtNombre.Text;
            //EN LA VARIBLE TEXTO, guardame lo que tiene el OBJETO txtnombre.texto, es una prop de este objeto txtNombre

            //una vez que capture el texto de la caja de texto, se la asigno a la label
          lblSaludo.Text = "Hola" + texto;

          //  o puedo hacer de una
           lblSaludo.Text = "Hola " + txtNombre.Text;

        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Bienvenido ala App");
        //}

        //private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    MessageBox.Show("Hasta pronto, gracias por visitarnos");
        //}

     
    }


    }


//asi como podes agregar 1 clase, podes hacer click derecho , agregar FORMULARIO Windorws form

//Partial es un MODIFICADOR QUE PERMITE TENER PEDAZOS DE CLASES DISTRIBUIDAS EN DISTINTOS
//PLANOS, siempre y cuando sea la misma clase, x eso con el consutrctor, llamamos a un metodo que 
// en realidad esta dentro de otra ventana , el InitializeComponent()