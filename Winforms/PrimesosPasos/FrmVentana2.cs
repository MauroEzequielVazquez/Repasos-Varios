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
    public partial class FrmVentana2 : Form
    {
        public FrmVentana2()
        {
            InitializeComponent();
        }

        private void FrmVentana2_Load(object sender, EventArgs e)
        {

        }

        private void btnBoton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtNombre.Text);

        }
    }
}
