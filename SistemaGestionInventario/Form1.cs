using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionInventario
{
    public partial class frmAlmacen : Form
    {
        public frmAlmacen()
        {
            InitializeComponent();
        }

        private void frmAlmacen_Load(object sender, EventArgs e)
        {

        }
        /////////////////////////////////////EVENTOS BOTON CUENTA/////////////////////////////////////
        private void btnCuenta_MouseEnter(object sender, EventArgs e)
        {
            btnCuenta.BackColor = Color.FromArgb(38, 50, 56);
        }

        private void btnCuenta_MouseLeave(object sender, EventArgs e)
        {
            btnCuenta.BackColor = Color.Transparent;
        }
    }
}
