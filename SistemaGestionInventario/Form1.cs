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
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("¿Desea salir de SIGAL SW?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }
    }
}
