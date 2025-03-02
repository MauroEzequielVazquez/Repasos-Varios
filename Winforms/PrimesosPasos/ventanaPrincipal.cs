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
    public partial class ventanaPrincipal : Form
    {
        public ventanaPrincipal()
        {
            InitializeComponent();
        }

   

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlesVarios_OperadorTernario ventana2 = new ControlesVarios_OperadorTernario();
            //creo de forma manual, una instancia del objeto   y lo guardo en 1 variable de tipo  form

           // ventana2.Show();  No me conviene xq asi cada vez q haga click en ver perfil
           // me crea 1 instancia , osea 1 ventana nueva 

            ventana2.ShowDialog(); // para evitar esto usamo ShowDialog


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //instancia para abrir ventana EMERGENTE
            ControlesVarios_OperadorTernario ventana2 = new ControlesVarios_OperadorTernario();
            ventana2.ShowDialog();
        }

        private void btnFormulario_Click(object sender, EventArgs e)
        {
            ControlesVarios_OperadorTernario ventana2 = new ControlesVarios_OperadorTernario();
            //creo de forma manual, una instancia del objeto   y lo guardo en 1 variable de tipo  form

            // ventana2.Show();  No me conviene xq asi cada vez q haga click en ver perfil
            // me crea 1 instancia , osea 1 ventana nueva 

            ventana2.ShowDialog(); // para evitar esto usamo ShowDialog
        }
    }
}
