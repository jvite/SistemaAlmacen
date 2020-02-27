namespace SistemaGestionInventario
{
    partial class frmAlmacen
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlmacen));
            this.plMenuContactos = new System.Windows.Forms.Panel();
            this.plMenuLateral = new System.Windows.Forms.Panel();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.btnEscritorio = new System.Windows.Forms.Button();
            this.btnCuenta = new System.Windows.Forms.Button();
            this.pbxSeparador = new System.Windows.Forms.PictureBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pbxImagenPerfil = new System.Windows.Forms.PictureBox();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.plMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSeparador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // plMenuContactos
            // 
            this.plMenuContactos.BackgroundImage = global::SistemaGestionInventario.Properties.Resources.color1;
            this.plMenuContactos.Location = new System.Drawing.Point(780, 0);
            this.plMenuContactos.Name = "plMenuContactos";
            this.plMenuContactos.Size = new System.Drawing.Size(56, 526);
            this.plMenuContactos.TabIndex = 1;
            // 
            // plMenuLateral
            // 
            this.plMenuLateral.BackgroundImage = global::SistemaGestionInventario.Properties.Resources.color1;
            this.plMenuLateral.Controls.Add(this.btnFacturas);
            this.plMenuLateral.Controls.Add(this.btnReportes);
            this.plMenuLateral.Controls.Add(this.btnPagos);
            this.plMenuLateral.Controls.Add(this.btnProveedores);
            this.plMenuLateral.Controls.Add(this.pictureBox2);
            this.plMenuLateral.Controls.Add(this.btnAlmacen);
            this.plMenuLateral.Controls.Add(this.btnEscritorio);
            this.plMenuLateral.Controls.Add(this.btnCuenta);
            this.plMenuLateral.Controls.Add(this.pbxSeparador);
            this.plMenuLateral.Controls.Add(this.lblEstado);
            this.plMenuLateral.Controls.Add(this.pictureBox1);
            this.plMenuLateral.Controls.Add(this.lblNombre);
            this.plMenuLateral.Controls.Add(this.pbxImagenPerfil);
            this.plMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.plMenuLateral.Name = "plMenuLateral";
            this.plMenuLateral.Size = new System.Drawing.Size(192, 595);
            this.plMenuLateral.TabIndex = 0;
            // 
            // btnPagos
            // 
            this.btnPagos.BackColor = System.Drawing.Color.Transparent;
            this.btnPagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.Image = global::SistemaGestionInventario.Properties.Resources.money___1183_;
            this.btnPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.Location = new System.Drawing.Point(0, 396);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(192, 32);
            this.btnPagos.TabIndex = 10;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagos.UseVisualStyleBackColor = false;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Image = global::SistemaGestionInventario.Properties.Resources.chart_fill___1291_;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 368);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(192, 29);
            this.btnReportes.TabIndex = 9;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.Transparent;
            this.btnProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.Image = global::SistemaGestionInventario.Properties.Resources.car___646_;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(-1, 339);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(192, 29);
            this.btnProveedores.TabIndex = 8;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProveedores.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SistemaGestionInventario.Properties.Resources.linea;
            this.pictureBox2.Location = new System.Drawing.Point(0, 287);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.BackColor = System.Drawing.Color.Transparent;
            this.btnAlmacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlmacen.FlatAppearance.BorderSize = 0;
            this.btnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlmacen.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmacen.Image = global::SistemaGestionInventario.Properties.Resources.database_system___1797_;
            this.btnAlmacen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlmacen.Location = new System.Drawing.Point(0, 309);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(192, 29);
            this.btnAlmacen.TabIndex = 7;
            this.btnAlmacen.Text = "Amacén";
            this.btnAlmacen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlmacen.UseVisualStyleBackColor = false;
            // 
            // btnEscritorio
            // 
            this.btnEscritorio.BackColor = System.Drawing.Color.Transparent;
            this.btnEscritorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEscritorio.FlatAppearance.BorderSize = 0;
            this.btnEscritorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscritorio.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscritorio.Image = global::SistemaGestionInventario.Properties.Resources.desktop___232_;
            this.btnEscritorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEscritorio.Location = new System.Drawing.Point(0, 255);
            this.btnEscritorio.Name = "btnEscritorio";
            this.btnEscritorio.Size = new System.Drawing.Size(192, 29);
            this.btnEscritorio.TabIndex = 6;
            this.btnEscritorio.Text = "Escritorio";
            this.btnEscritorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEscritorio.UseVisualStyleBackColor = false;
            // 
            // btnCuenta
            // 
            this.btnCuenta.BackColor = System.Drawing.Color.Transparent;
            this.btnCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCuenta.FlatAppearance.BorderSize = 0;
            this.btnCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuenta.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuenta.Image = global::SistemaGestionInventario.Properties.Resources.profile___1335_1;
            this.btnCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuenta.Location = new System.Drawing.Point(0, 211);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(191, 29);
            this.btnCuenta.TabIndex = 5;
            this.btnCuenta.Text = "Cuenta";
            this.btnCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCuenta.UseVisualStyleBackColor = false;
            this.btnCuenta.MouseEnter += new System.EventHandler(this.btnCuenta_MouseEnter);
            this.btnCuenta.MouseLeave += new System.EventHandler(this.btnCuenta_MouseLeave);
            // 
            // pbxSeparador
            // 
            this.pbxSeparador.BackColor = System.Drawing.Color.Transparent;
            this.pbxSeparador.Image = global::SistemaGestionInventario.Properties.Resources.linea;
            this.pbxSeparador.Location = new System.Drawing.Point(0, 237);
            this.pbxSeparador.Name = "pbxSeparador";
            this.pbxSeparador.Size = new System.Drawing.Size(192, 25);
            this.pbxSeparador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSeparador.TabIndex = 4;
            this.pbxSeparador.TabStop = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(75, 163);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(103, 23);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "<<estado>>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(31, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 23);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(42, 128);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 23);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "<<usuario>>";
            // 
            // pbxImagenPerfil
            // 
            this.pbxImagenPerfil.BackColor = System.Drawing.Color.Transparent;
            this.pbxImagenPerfil.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbxImagenPerfil.ErrorImage")));
            this.pbxImagenPerfil.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxImagenPerfil.InitialImage")));
            this.pbxImagenPerfil.Location = new System.Drawing.Point(46, 25);
            this.pbxImagenPerfil.Name = "pbxImagenPerfil";
            this.pbxImagenPerfil.Size = new System.Drawing.Size(100, 100);
            this.pbxImagenPerfil.TabIndex = 0;
            this.pbxImagenPerfil.TabStop = false;
            // 
            // btnFacturas
            // 
            this.btnFacturas.BackColor = System.Drawing.Color.Transparent;
            this.btnFacturas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFacturas.FlatAppearance.BorderSize = 0;
            this.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturas.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturas.Image = global::SistemaGestionInventario.Properties.Resources.file_double___1695_;
            this.btnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturas.Location = new System.Drawing.Point(0, 428);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(192, 29);
            this.btnFacturas.TabIndex = 10;
            this.btnFacturas.Text = "Facturas";
            this.btnFacturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacturas.UseVisualStyleBackColor = false;
            // 
            // frmAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 594);
            this.ControlBox = false;
            this.Controls.Add(this.plMenuContactos);
            this.Controls.Add(this.plMenuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlmacen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAlmacen_Load);
            this.plMenuLateral.ResumeLayout(false);
            this.plMenuLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSeparador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plMenuLateral;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbxImagenPerfil;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbxSeparador;
        private System.Windows.Forms.Button btnCuenta;
        private System.Windows.Forms.Button btnEscritorio;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel plMenuContactos;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnFacturas;
    }
}

