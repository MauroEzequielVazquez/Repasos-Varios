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
    public partial class frmDatosPersonales : Form
    {
        public frmDatosPersonales()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // al presionar el boton aceptar, se debe validad que los text Apellido, Nombre, Edad y Direccion
            // tengan datos, en caso de estar macios marcarlos de color rojo-
            // Quitar espacios y verificar si los campos están vacíos
            if (txtApellido.Text.Trim() == "" || txtNombre.Text.Trim() == "" || txtEdad.Text.Trim() == "" || txtDireccion.Text.Trim() == "")
            {
                // Si están vacíos, poner en rojo
                if (txtApellido.Text.Trim() == "") txtApellido.BackColor = Color.Red;
                if (txtNombre.Text.Trim() == "") txtNombre.BackColor = Color.Red;
                if (txtEdad.Text.Trim() == "") txtEdad.BackColor = Color.Red;
                if (txtDireccion.Text.Trim() == "") txtDireccion.BackColor = Color.Red;

                MessageBox.Show("ERROR, Todos los campos son obligatorios.", "Por favor complete todos los campos");
                return; // Detener ejecución si falta algún dato
            }

            // Si los campos están completos, restaurar color
            txtApellido.BackColor = SystemColors.Window; 
            txtNombre.BackColor = SystemColors.Window;
            txtEdad.BackColor = SystemColors.Window;
            txtDireccion.BackColor = SystemColors.Window;

            // Mostrar el texto en txtResultado
            txtResultado.Text = "Apellido y Nombre: " + txtApellido.Text.ToUpper() + " " + txtNombre.Text.ToUpper() + "\r\n" +
                                "Edad: " + txtEdad.Text + "\r\n" +  // salto de línea
                                "Dirección: " + txtDireccion.Text.ToUpper(); 

        }



        // aceptar solo numeros


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual . osea donde estoy parado, THIS .CLOSE 
        }

        private void frmDatosPersonales_Load(object sender, EventArgs e)
        {
            txtApellido.TabIndex = 0;
            txtNombre.TabIndex = 1;
            txtEdad.TabIndex = 2;
            txtDireccion.TabIndex = 3;
            txtResultado.TabIndex = 4;
        }

        private void txtEdad_KeyPress_1(object sender, KeyPressEventArgs e)
        {       
            
            // aceptar solo numeros


            // Permitir solo números y la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea el carácter
            }

        }
    }

}