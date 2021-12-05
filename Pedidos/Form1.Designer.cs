
namespace Pedidos
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabPedidosPag = new System.Windows.Forms.TabPage();
            this.tabClientePag = new System.Windows.Forms.TabPage();
            this.tabProductoPag = new System.Windows.Forms.TabPage();
            this.tabInventarioPag = new System.Windows.Forms.TabPage();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnAgregarU = new System.Windows.Forms.Button();
            this.btnLimpiarU = new System.Windows.Forms.Button();
            this.btnModificarU = new System.Windows.Forms.Button();
            this.btnEliminarU = new System.Windows.Forms.Button();
            this.btnHistorialU = new System.Windows.Forms.Button();
            this.tabMenu.SuspendLayout();
            this.tabClientePag.SuspendLayout();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabPedidosPag);
            this.tabMenu.Controls.Add(this.tabClientePag);
            this.tabMenu.Controls.Add(this.tabProductoPag);
            this.tabMenu.Controls.Add(this.tabInventarioPag);
            this.tabMenu.Controls.Add(this.tabAbout);
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(1309, 667);
            this.tabMenu.TabIndex = 0;
            // 
            // tabPedidosPag
            // 
            this.tabPedidosPag.Location = new System.Drawing.Point(4, 22);
            this.tabPedidosPag.Name = "tabPedidosPag";
            this.tabPedidosPag.Padding = new System.Windows.Forms.Padding(3);
            this.tabPedidosPag.Size = new System.Drawing.Size(1301, 641);
            this.tabPedidosPag.TabIndex = 0;
            this.tabPedidosPag.Text = "Pedidos";
            this.tabPedidosPag.UseVisualStyleBackColor = true;
            // 
            // tabClientePag
            // 
            this.tabClientePag.Controls.Add(this.dgvUsuario);
            this.tabClientePag.Controls.Add(this.groupBox2);
            this.tabClientePag.Controls.Add(this.groupBox1);
            this.tabClientePag.Location = new System.Drawing.Point(4, 22);
            this.tabClientePag.Name = "tabClientePag";
            this.tabClientePag.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientePag.Size = new System.Drawing.Size(1301, 641);
            this.tabClientePag.TabIndex = 1;
            this.tabClientePag.Text = "Clientes";
            this.tabClientePag.UseVisualStyleBackColor = true;
            // 
            // tabProductoPag
            // 
            this.tabProductoPag.Location = new System.Drawing.Point(4, 22);
            this.tabProductoPag.Name = "tabProductoPag";
            this.tabProductoPag.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductoPag.Size = new System.Drawing.Size(1301, 641);
            this.tabProductoPag.TabIndex = 2;
            this.tabProductoPag.Text = "Productos";
            this.tabProductoPag.UseVisualStyleBackColor = true;
            // 
            // tabInventarioPag
            // 
            this.tabInventarioPag.Location = new System.Drawing.Point(4, 22);
            this.tabInventarioPag.Name = "tabInventarioPag";
            this.tabInventarioPag.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventarioPag.Size = new System.Drawing.Size(1301, 641);
            this.tabInventarioPag.TabIndex = 3;
            this.tabInventarioPag.Text = "Inventario";
            this.tabInventarioPag.UseVisualStyleBackColor = true;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.pictureBox3);
            this.tabAbout.Controls.Add(this.pictureBox2);
            this.tabAbout.Controls.Add(this.pictureBox1);
            this.tabAbout.Controls.Add(this.lblDetalle);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(1301, 641);
            this.tabAbout.TabIndex = 4;
            this.tabAbout.Text = "Sobre la aplicacion";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(99, 334);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(1140, 165);
            this.lblDetalle.TabIndex = 0;
            this.lblDetalle.Text = "Aplicacion desarrollada por:\r\nLuis Ricardo Bernal Martinez BM101219\r\nFernando Ern" +
    "esto Carranza Guardado CG102319";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pedidos.Properties.Resources.shut;
            this.pictureBox3.Location = new System.Drawing.Point(742, 151);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 112);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pedidos.Properties.Resources.hack;
            this.pictureBox2.Location = new System.Drawing.Point(401, 151);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pedidos.Properties.Resources._3x__11_;
            this.pictureBox1.Location = new System.Drawing.Point(575, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarU);
            this.groupBox1.Controls.Add(this.lblBuscar);
            this.groupBox1.Controls.Add(this.lblDepartamento);
            this.groupBox1.Controls.Add(this.lblCiudad);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.lblApellidos);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtBuscarUsuario);
            this.groupBox1.Controls.Add(this.txtDepartamento);
            this.groupBox1.Controls.Add(this.txtCiudad);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1287, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHistorialU);
            this.groupBox2.Controls.Add(this.btnEliminarU);
            this.groupBox2.Controls.Add(this.btnModificarU);
            this.groupBox2.Controls.Add(this.btnLimpiarU);
            this.groupBox2.Location = new System.Drawing.Point(8, 573);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1287, 53);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(8, 222);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuario.Size = new System.Drawing.Size(1287, 345);
            this.dgvUsuario.TabIndex = 0;
            this.dgvUsuario.SelectionChanged += new System.EventHandler(this.dgvUsuario_SelectionChanged);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(157, 49);
            this.txtNombres.MaxLength = 75;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(228, 20);
            this.txtNombres.TabIndex = 0;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(157, 92);
            this.txtApellidos.MaxLength = 75;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(228, 20);
            this.txtApellidos.TabIndex = 1;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(492, 49);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(148, 20);
            this.txtTelefono.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(492, 96);
            this.txtDireccion.MaxLength = 75;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(284, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(933, 49);
            this.txtCiudad.MaxLength = 50;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(167, 20);
            this.txtCiudad.TabIndex = 4;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(933, 92);
            this.txtDepartamento.MaxLength = 50;
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(167, 20);
            this.txtDepartamento.TabIndex = 5;
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Location = new System.Drawing.Point(400, 161);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(376, 20);
            this.txtBuscarUsuario.TabIndex = 6;
            this.txtBuscarUsuario.TextChanged += new System.EventHandler(this.txtBuscarUsuario_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(76, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombres:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(76, 99);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(52, 13);
            this.lblApellidos.TabIndex = 8;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(416, 56);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 9;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(416, 99);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(826, 56);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 11;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(826, 99);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(77, 13);
            this.lblDepartamento.TabIndex = 12;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(314, 164);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(77, 13);
            this.lblBuscar.TabIndex = 13;
            this.lblBuscar.Text = "Buscar cliente:";
            // 
            // btnAgregarU
            // 
            this.btnAgregarU.Location = new System.Drawing.Point(1161, 73);
            this.btnAgregarU.Name = "btnAgregarU";
            this.btnAgregarU.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarU.TabIndex = 14;
            this.btnAgregarU.Text = "Agregar";
            this.btnAgregarU.UseVisualStyleBackColor = true;
            this.btnAgregarU.Click += new System.EventHandler(this.btnAgregarU_Click);
            // 
            // btnLimpiarU
            // 
            this.btnLimpiarU.Location = new System.Drawing.Point(23, 19);
            this.btnLimpiarU.Name = "btnLimpiarU";
            this.btnLimpiarU.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarU.TabIndex = 15;
            this.btnLimpiarU.Text = "Limpiar";
            this.btnLimpiarU.UseVisualStyleBackColor = true;
            this.btnLimpiarU.Click += new System.EventHandler(this.btnLimpiarU_Click);
            // 
            // btnModificarU
            // 
            this.btnModificarU.Location = new System.Drawing.Point(391, 19);
            this.btnModificarU.Name = "btnModificarU";
            this.btnModificarU.Size = new System.Drawing.Size(75, 23);
            this.btnModificarU.TabIndex = 2;
            this.btnModificarU.Text = "Modificar";
            this.btnModificarU.UseVisualStyleBackColor = true;
            this.btnModificarU.Click += new System.EventHandler(this.btnModificarU_Click);
            // 
            // btnEliminarU
            // 
            this.btnEliminarU.Location = new System.Drawing.Point(512, 19);
            this.btnEliminarU.Name = "btnEliminarU";
            this.btnEliminarU.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarU.TabIndex = 16;
            this.btnEliminarU.Text = "Eliminar";
            this.btnEliminarU.UseVisualStyleBackColor = true;
            this.btnEliminarU.Click += new System.EventHandler(this.btnEliminarU_Click);
            // 
            // btnHistorialU
            // 
            this.btnHistorialU.Location = new System.Drawing.Point(1097, 19);
            this.btnHistorialU.Name = "btnHistorialU";
            this.btnHistorialU.Size = new System.Drawing.Size(134, 23);
            this.btnHistorialU.TabIndex = 17;
            this.btnHistorialU.Text = "Ver historial de pedidos";
            this.btnHistorialU.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 671);
            this.Controls.Add(this.tabMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Manejo de pedidos";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabMenu.ResumeLayout(false);
            this.tabClientePag.ResumeLayout(false);
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabPedidosPag;
        private System.Windows.Forms.TabPage tabClientePag;
        private System.Windows.Forms.TabPage tabProductoPag;
        private System.Windows.Forms.TabPage tabInventarioPag;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Button btnHistorialU;
        private System.Windows.Forms.Button btnEliminarU;
        private System.Windows.Forms.Button btnModificarU;
        private System.Windows.Forms.Button btnLimpiarU;
        private System.Windows.Forms.Button btnAgregarU;
    }
}

