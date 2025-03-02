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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 conexionVentana = new Form1(); // creo la isntancia  la clase Form1 para poder navegar entre ventanas
             
            //conexionVentana.Show();

            // El problema es que cada vez que haga click en ver perfil me va a isntanciar una ventana
            // POR ESO RECOMIENDO USAR ShowDialog

           conexionVentana.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();

            ventana.ShowDialog();

           
        }
    }
}
