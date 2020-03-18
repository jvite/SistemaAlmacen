using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionInventario;


namespace SistemaGestionInventario
{
    public partial class frmUserAdmin : Form
    {
        public frmUserAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está a pundo de reestablecer la contraseña actual, ¿Desea continuar?", "Reestablecer contraseña", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                //int c = GenerarContrasena(8);
                //MessageBox.Show("La contraseña del usuario actual se reestableció con éxito. La contraseña es: " + c , "Reestablecer contraseña", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
        }
    }
}
