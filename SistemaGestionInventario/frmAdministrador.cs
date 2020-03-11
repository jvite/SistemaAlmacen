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

        private void abrirForm(object formHija) //Metodo para abrir un formulario dentro de un panel
        {
            if (plContenedor.Controls.Count > 0)
            {
                this.plContenedor.Controls.RemoveAt(0);//Se vacía el conetenedor
            }
            Form fh = formHija as Form;//se declara el obejo
            fh.TopLevel = false;//no es una ventana
            fh.Dock = DockStyle.Fill;//para que se acople
            this.plContenedor.Controls.Add(fh);//se añade el form al panel
            this.plContenedor.Tag = fh;
            fh.Show();//se muestra el form
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("¿Desea salir de SIGAL SW?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        /////////////////////////////////////EVENTOS BOTON CUENTA/////////////////////////////////////
        private void btnCuenta_MouseEnter(object sender, EventArgs e)//El mouse pasa sobre el botón
        {
            btnCuenta.BackColor = Color.FromArgb(38, 50, 56);
            btnCuenta.ForeColor = Color.White;
        }

        private void btnCuenta_MouseLeave(object sender, EventArgs e)//El mouse se sale del boton
        {
            btnCuenta.BackColor = Color.Transparent;
            btnCuenta.ForeColor = Color.Silver;
        }
        /////////////////////////////////////EVENTOS BOTON ESCRITORIO/////////////////////////////////////
        private void btnEscritorio_MouseEnter(object sender, EventArgs e)
        {
            btnEscritorio.BackColor = Color.FromArgb(38, 50, 56);
            btnEscritorio.ForeColor = Color.White;
        }

        private void btnEscritorio_MouseLeave(object sender, EventArgs e)
        {
            btnEscritorio.BackColor = Color.Transparent;
            btnEscritorio.ForeColor = Color.Silver;
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            abrirForm(new frmAlmacen()); //Se llama la función para abrir el formulario
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está a punto de cerrar sesión, ¿Continuar?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Dispose();
                frmInicioDeSesion inicio = new frmInicioDeSesion();
                inicio.Show();
            }
        }
    }
}
