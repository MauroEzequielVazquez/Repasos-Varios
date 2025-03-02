using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mi_Primer_App_Windors_Form
{
    public partial class frmPrimerApp : Form
    {
        public frmPrimerApp()
        {
            InitializeComponent();
        }

        private void frmPrimerApp_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienveido a esta app nueva");
        }

        private void frmPrimerApp_FormClosed(object sender, FormClosedEventArgs e)
        {

            MessageBox.Show("Hasta luego");
        }

        private void bnt1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparó el evento click del botón");
            //this.BackColor = Color.BlueViolet; // Al dispararse el evento click del boton,  Cambia el color de fondo  del formulario al hacer clic


            if (txt1.Text == " ")
            {
                txt1.BackColor = Color.Red;
            }
            else
            {
                txt1.BackColor = System.Drawing.SystemColors.Control;
            }

        }


        //System.Drawing.SystemColors.Control en C# representa un color del sistema operativo,
        //específicamente el color de fondo predeterminado de los controles en Windows Forms.






        private void frmPrimerApp_Click(object sender, EventArgs e) // EVENTO CLICK DEL FORMULARIO
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
            {
                MessageBox.Show("Presiono el boton izquierdo del mouse");

            }

            else if (click.Button == MouseButtons.Right)
            {
                MessageBox.Show("Se presiono el boton derecho del mouse");
            }

            else if (click.Button == MouseButtons.Middle)
            {
                MessageBox.Show("Se presiono el boton del medio del mouse");


            }
        }
        //El evento MouseMove en C# se activa cuando el puntero del mouse se mueve dentro de
        //los límites de un control en Windows Forms o WPF.
        private void lblEtiqueta_MouseMove(object sender, MouseEventArgs e)
        {
            //cambiamos el color de la propiedad back color al activar el evento Mouse Move

            lblEtiqueta.BackColor = Color.Red;


            // Cambia el ESTILO del cursor al mover el mouse ( evento mouse  move)

            lblEtiqueta.Cursor = Cursors.Hand; // CAMBIAMOS EL ESTILO DEL CURSOR
        }






        //El evento MouseLeave en C# se usa para detectar cuando el puntero del mouse sale
        //del área de un control en una aplicación Windows Forms o WPF
        private void lblEtiqueta_MouseLeave(object sender, EventArgs e)

        {
            // al dispararse el evento Mouse leave se RESTABLECE el color de la etiqueta

            lblEtiqueta.BackColor = System.Drawing.SystemColors.Control;

            lblEtiqueta.Cursor = Cursors.Arrow;



        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        //La función que has escrito en C# es un manejador de eventos para el evento KeyPress de un TextBox.
        //Su propósito es restringir la entrada de caracteres en el cuadro de texto (txt1), permitiendo solo números (0-9)
        //y la tecla de retroceso (Backspace).






        private void frmPrimerApp_Leave(object sender, EventArgs e)
        {

            // vamos a MOSTRAR cuantos caracteres se ingresador una vez que el control pierde el foco

            MessageBox.Show("Tiene " + txt2.Text.Length + " caracteres");

        }



  //La función frmPrimerApp_Leave es un manejador de eventos en C# que se ejecuta cuando el formulario frmPrimerApp pierde el foco (cuando el usuario cambia a otra ventana o aplicación).

//        Explicación:
//Evento Leave: Se dispara cuando el formulario deja de estar activo.
//MessageBox.Show(...): Muestra un cuadro de mensaje con la cantidad de caracteres ingresados en el control txt2(asumimos que es un TextBox).
//txt2.Text.Length: Obtiene la cantidad de caracteres en el TextBox txt2.


    }
}





