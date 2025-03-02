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
    public partial class ventanaEmergente : Form
    {
        public ventanaEmergente()
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

            cbxDiasLibres.Items.Add("Lunes de 9 a 10hs");
            cbxDiasLibres.Items.Add("Lunes de 10 a 11hs");
            cbxDiasLibres.Items.Add("Lunes de 12 a 13hs");
            cbxDiasLibres.Items.Add("Lunes de 18 a 19hs");
            cbxDiasLibres.Items.Add("Lunes de 20 a 21hs");


            //cbxDiasLibres.Items.Add("Martes");
            //cbxDiasLibres.Items.Add("Miercoles");
            //cbxDiasLibres.Items.Add("Jueves");
            //cbxDiasLibres.Items.Add("Viernes");

        }

        private void bntPerfil_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;

            DateTime dtp = dtpFechaNac.Value;// aca va value no text

            //Operador ternario, seria como un if en una sola linea

            string primeraVez = ckbPrimeraVez.Checked == true ? "Si, es su primera vez" : "no es su primera vez, ya realizo pilates antes";

            string avance = "No especificado";

            if (rbt1.Checked && !ckbPrimeraVez.Checked)
                avance = "Principiante";
            else if (rbt2.Checked && !ckbPrimeraVez.Checked)
                avance = "Avanzado/a";
            else if (rbt3.Checked && !ckbPrimeraVez.Checked)
                avance = "Experto/a";

            // es como decir cbk.primeravez.checked = false.. pero uso el NOT!



            string DiasLibres = cbxDiasLibres.SelectedItem.ToString(); // combo box
            //del combo, selecciona el item y hacelo string , xq cuando obtengo el item me devuelve un object


            string cantidadDeHoras = cantHoras.Value.ToString();

            string preferencias = txtPreferencias.Text;

            string resultado = "El nombre del /la recluta es " + Nombre + " ,nos indico que " + primeraVez + ", su nivel de avance es " + avance + "; el horario solicitao fue a las "
                + cantidadDeHoras + "hs, y sus dias libres son " + DiasLibres + " ;ademas sus  preferencias adicionales son " + preferencias;

            MessageBox.Show(resultado);





        }

        
    }
}
