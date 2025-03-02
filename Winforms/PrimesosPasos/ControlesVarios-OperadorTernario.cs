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
    public partial class ControlesVarios_OperadorTernario : Form
    {
        public ControlesVarios_OperadorTernario()
        {
            InitializeComponent();
        }

        //usamos varios controles y les dimos una locura para 
        // jugar, con el click del boton imprimimos algo x pantalla
        //mas adelante lo vamos a transformar en objetos ..

        private void bntAgregar_Click(object sender, EventArgs e)
        {
            string elelemento = txtPreferencias.Text;
            // guArdo en 1 var lo que tiene el objeto txt.elemento...

             //   lwElemento.Items.Add(elelemento); saque la lista xq al pedo estaba
            // list view es UNA lista de elementos, x ende agregas elementos como un listado
        }

        private void ControlesVarios_OperadorTernario_Load(object sender, EventArgs e)
        {
            // se maneja igual que la list view, es un objeto que tiene items

            //cbxDiayHora.Items.Clear(); // Limpiar para evitar duplicados

            //La funciónActualizarHorarios() se activa desde los eventos, poniendo
            //cheackedChanged, esta llama ala funcion y actualiza, asi me marca los horarios
            // de los dias que chequee

            //    if (ckbLunes.Checked)
            //    {
            //        cbxDiayHora.Items.Add("Lunes de 9 a 10hs");
            //        cbxDiayHora.Items.Add("Lunes de 10 a 11hs");
            //        cbxDiayHora.Items.Add("Lunes de 12 a 13hs");
            //        cbxDiayHora.Items.Add("Lunes de 18 a 19hs");
            //        cbxDiayHora.Items.Add("Lunes de 20 a 21hs");
            //    }

            //    if (ckbMartes.Checked)
            //    {
            //        cbxDiayHora.Items.Add("Martes de 9 a 10hs");
            //        cbxDiayHora.Items.Add("Martes de 10 a 11hs");
            //        cbxDiayHora.Items.Add("Martes de 12 a 13hs");
            //        cbxDiayHora.Items.Add("Martes de 18 a 19hs");
            //        cbxDiayHora.Items.Add("Martes de 20 a 21hs");
            //    }

            //    if (ckbMiercoles.Checked)
            //    {
            //        cbxDiayHora.Items.Add("Miércoles de 9 a 10hs");
            //        cbxDiayHora.Items.Add("Miércoles de 10 a 11hs");
            //        cbxDiayHora.Items.Add("Miércoles de 12 a 13hs");
            //        cbxDiayHora.Items.Add("Miércoles de 18 a 19hs");
            //        cbxDiayHora.Items.Add("Miércoles de 20 a 21hs");
            //    }

            //    if (ckbJueves.Checked)
            //    {
            //        cbxDiayHora.Items.Add("Jueves de 9 a 10hs");
            //        cbxDiayHora.Items.Add("Jueves de 10 a 11hs");
            //        cbxDiayHora.Items.Add("Jueves de 12 a 13hs");
            //        cbxDiayHora.Items.Add("Jueves de 18 a 19hs");
            //        cbxDiayHora.Items.Add("Jueves de 20 a 21hs");
            //    }

            //    if (ckbViernes.Checked)
            //    {
            //        cbxDiayHora.Items.Add("Viernes de 9 a 10hs");
            //        cbxDiayHora.Items.Add("Viernes de 10 a 11hs");
            //        cbxDiayHora.Items.Add("Viernes de 12 a 13hs");
            //        cbxDiayHora.Items.Add("Viernes de 18 a 19hs");
            //        cbxDiayHora.Items.Add("Viernes de 20 a 21hs");
            //    }
            //}{
            ActualizarHorarios(); // Se llama al cargar el formulario
        }
            private void ActualizarHorarios()
            {
                lbxDiayHora.Items.Clear(); // Limpiar el ListBox antes de agregar nuevos horarios

                if (ckbLunes.Checked)
                {
                    lbxDiayHora.Items.Add("Lunes de 9 a 10hs");
                    lbxDiayHora.Items.Add("Lunes de 10 a 11hs");
                    lbxDiayHora.Items.Add("Lunes de 12 a 13hs");
                    lbxDiayHora.Items.Add("Lunes de 18 a 19hs");
                    lbxDiayHora.Items.Add("Lunes de 20 a 21hs");
                }

                if (ckbMartes.Checked)
                {
                    lbxDiayHora.Items.Add("Martes de 9 a 10hs");
                    lbxDiayHora.Items.Add("Martes de 10 a 11hs");
                    lbxDiayHora.Items.Add("Martes de 12 a 13hs");
                    lbxDiayHora.Items.Add("Martes de 18 a 19hs");
                    lbxDiayHora.Items.Add("Martes de 20 a 21hs");
                }

                if (ckbMiercoles.Checked)
                {
                    lbxDiayHora.Items.Add("Miércoles de 9 a 10hs");
                    lbxDiayHora.Items.Add("Miércoles de 10 a 11hs");
                    lbxDiayHora.Items.Add("Miércoles de 12 a 13hs");
                    lbxDiayHora.Items.Add("Miércoles de 18 a 19hs");
                    lbxDiayHora.Items.Add("Miércoles de 20 a 21hs");
                }

                if (ckbJueves.Checked)
                {
                    lbxDiayHora.Items.Add("Jueves de 9 a 10hs");
                    lbxDiayHora.Items.Add("Jueves de 10 a 11hs");
                    lbxDiayHora.Items.Add("Jueves de 12 a 13hs");
                    lbxDiayHora.Items.Add("Jueves de 18 a 19hs");
                    lbxDiayHora.Items.Add("Jueves de 20 a 21hs");
                }

                if (ckbViernes.Checked)
                {
                    lbxDiayHora.Items.Add("Viernes de 9 a 10hs");
                    lbxDiayHora.Items.Add("Viernes de 10 a 11hs");
                    lbxDiayHora.Items.Add("Viernes de 12 a 13hs");
                    lbxDiayHora.Items.Add("Viernes de 18 a 19hs");
                    lbxDiayHora.Items.Add("Viernes de 20 a 21hs");
                }
            }


            private void bntPerfil_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;

            DateTime dtp = dtpFechaNac.Value;// aca va value no text

            //Operador ternario, seria como un if en una sola linea

            string primeraVez = ckbPrimeraVez.Checked == true ? "Si, es su primera vez" : "no es su primera vez, ya realizo pilates antes";

            string avance = "No especificado";

            if (rbt1.Checked && !ckbPrimeraVez.Checked) // USE EL NOT para decir  SI NO ESTA CHECK , osea si no es la primera vez
                avance = "Principiante";
            else if (rbt2.Checked && !ckbPrimeraVez.Checked)
                avance = "Avanzado/a";
            else if (rbt3.Checked && !ckbPrimeraVez.Checked)
                avance = "Experto/a";

            // es como decir cbk.primeravez.checked = false.. pero uso el NOT!



            string DiasLibres = cbxDiayHora.SelectedItem.ToString(); // combo box
            //del combo, selecciona el item y hacelo string , xq cuando obtengo el item me devuelve un object


          

            string preferencias = txtPreferencias.Text;

            string resultado = "El nombre del /la recluta es " + Nombre + " , nos indico que " + primeraVez + ", su nivel de conocimiento es " + avance + "; el horario solicitado fue a las "
                + cbxDiayHora.ToString() + "hs, y sus dias libres son " + DiasLibres + " ; ademas sus  preferencias adicionales son " + preferencias;

            MessageBox.Show(resultado);





        }

        
    }
}
