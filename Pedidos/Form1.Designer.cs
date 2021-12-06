
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
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHistorialU = new System.Windows.Forms.Button();
            this.btnEliminarU = new System.Windows.Forms.Button();
            this.btnModificarU = new System.Windows.Forms.Button();
            this.btnLimpiarU = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarU = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.tabProductoPag = new System.Windows.Forms.TabPage();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCantidadStock = new System.Windows.Forms.Label();
            this.lblBuscarP = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.txtDescripcionP = new System.Windows.Forms.TextBox();
            this.txtCantidadStock = new System.Windows.Forms.TextBox();
            this.txtPrecioP = new System.Windows.Forms.TextBox();
            this.txtBuscarP = new System.Windows.Forms.TextBox();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.btnLimpiarP = new System.Windows.Forms.Button();
            this.btnModificarP = new System.Windows.Forms.Button();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.btnModificarPStock = new System.Windows.Forms.Button();
            this.btnModificarPPrecio = new System.Windows.Forms.Button();
            this.tabMenu.SuspendLayout();
            this.tabClientePag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabProductoPag.SuspendLayout();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabPedidosPag);
            this.tabMenu.Controls.Add(this.tabClientePag);
            this.tabMenu.Controls.Add(this.tabProductoPag);
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
            // btnHistorialU
            // 
            this.btnHistorialU.Location = new System.Drawing.Point(1097, 19);
            this.btnHistorialU.Name = "btnHistorialU";
            this.btnHistorialU.Size = new System.Drawing.Size(134, 23);
            this.btnHistorialU.TabIndex = 17;
            this.btnHistorialU.Text = "Ver historial de pedidos";
            this.btnHistorialU.UseVisualStyleBackColor = true;
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
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(314, 164);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(77, 13);
            this.lblBuscar.TabIndex = 13;
            this.lblBuscar.Text = "Buscar cliente:";
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
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(826, 56);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 11;
            this.lblCiudad.Text = "Ciudad:";
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
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(416, 56);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 9;
            this.lblTelefono.Text = "Telefono:";
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
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(76, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombres:";
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Location = new System.Drawing.Point(400, 161);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(376, 20);
            this.txtBuscarUsuario.TabIndex = 6;
            this.txtBuscarUsuario.TextChanged += new System.EventHandler(this.txtBuscarUsuario_TextChanged);
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(933, 92);
            this.txtDepartamento.MaxLength = 50;
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(167, 20);
            this.txtDepartamento.TabIndex = 5;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(933, 49);
            this.txtCiudad.MaxLength = 50;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(167, 20);
            this.txtCiudad.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(492, 96);
            this.txtDireccion.MaxLength = 75;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(284, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(492, 49);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(148, 20);
            this.txtTelefono.TabIndex = 2;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(157, 92);
            this.txtApellidos.MaxLength = 75;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(228, 20);
            this.txtApellidos.TabIndex = 1;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(157, 49);
            this.txtNombres.MaxLength = 75;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(228, 20);
            this.txtNombres.TabIndex = 0;
            // 
            // tabProductoPag
            // 
            this.tabProductoPag.Controls.Add(this.groupBox4);
            this.tabProductoPag.Controls.Add(this.dgvProductos);
            this.tabProductoPag.Controls.Add(this.groupBox3);
            this.tabProductoPag.Location = new System.Drawing.Point(4, 22);
            this.tabProductoPag.Name = "tabProductoPag";
            this.tabProductoPag.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductoPag.Size = new System.Drawing.Size(1301, 641);
            this.tabProductoPag.TabIndex = 2;
            this.tabProductoPag.Text = "Productos";
            this.tabProductoPag.UseVisualStyleBackColor = true;
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
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(62, 33);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(109, 13);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Nombre del producto:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(62, 93);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblCantidadStock
            // 
            this.lblCantidadStock.AutoSize = true;
            this.lblCantidadStock.Location = new System.Drawing.Point(483, 33);
            this.lblCantidadStock.Name = "lblCantidadStock";
            this.lblCantidadStock.Size = new System.Drawing.Size(96, 13);
            this.lblCantidadStock.TabIndex = 2;
            this.lblCantidadStock.Text = "Cantidad en stock:";
            // 
            // lblBuscarP
            // 
            this.lblBuscarP.AutoSize = true;
            this.lblBuscarP.Location = new System.Drawing.Point(462, 166);
            this.lblBuscarP.Name = "lblBuscarP";
            this.lblBuscarP.Size = new System.Drawing.Size(88, 13);
            this.lblBuscarP.TabIndex = 3;
            this.lblBuscarP.Text = "Buscar producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio de venta:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAgregarP);
            this.groupBox3.Controls.Add(this.txtBuscarP);
            this.groupBox3.Controls.Add(this.txtPrecioP);
            this.groupBox3.Controls.Add(this.txtCantidadStock);
            this.groupBox3.Controls.Add(this.txtDescripcionP);
            this.groupBox3.Controls.Add(this.txtNombreP);
            this.groupBox3.Controls.Add(this.lblCantidadStock);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblProducto);
            this.groupBox3.Controls.Add(this.lblBuscarP);
            this.groupBox3.Controls.Add(this.lblDescripcion);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1289, 197);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(6, 209);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(1289, 334);
            this.dgvProductos.TabIndex = 6;
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnModificarPPrecio);
            this.groupBox4.Controls.Add(this.btnModificarPStock);
            this.groupBox4.Controls.Add(this.btnEliminarP);
            this.groupBox4.Controls.Add(this.btnModificarP);
            this.groupBox4.Controls.Add(this.btnLimpiarP);
            this.groupBox4.Location = new System.Drawing.Point(6, 549);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1289, 86);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opciones";
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(177, 26);
            this.txtNombreP.MaxLength = 100;
            this.txtNombreP.Multiline = true;
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(234, 54);
            this.txtNombreP.TabIndex = 5;
            // 
            // txtDescripcionP
            // 
            this.txtDescripcionP.Location = new System.Drawing.Point(177, 86);
            this.txtDescripcionP.MaxLength = 200;
            this.txtDescripcionP.Multiline = true;
            this.txtDescripcionP.Name = "txtDescripcionP";
            this.txtDescripcionP.Size = new System.Drawing.Size(234, 69);
            this.txtDescripcionP.TabIndex = 6;
            // 
            // txtCantidadStock
            // 
            this.txtCantidadStock.Location = new System.Drawing.Point(585, 30);
            this.txtCantidadStock.Name = "txtCantidadStock";
            this.txtCantidadStock.Size = new System.Drawing.Size(117, 20);
            this.txtCantidadStock.TabIndex = 7;
            this.txtCantidadStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadStock_KeyPress);
            // 
            // txtPrecioP
            // 
            this.txtPrecioP.Location = new System.Drawing.Point(585, 86);
            this.txtPrecioP.Name = "txtPrecioP";
            this.txtPrecioP.Size = new System.Drawing.Size(117, 20);
            this.txtPrecioP.TabIndex = 8;
            this.txtPrecioP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // txtBuscarP
            // 
            this.txtBuscarP.Location = new System.Drawing.Point(556, 163);
            this.txtBuscarP.Name = "txtBuscarP";
            this.txtBuscarP.Size = new System.Drawing.Size(370, 20);
            this.txtBuscarP.TabIndex = 9;
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Location = new System.Drawing.Point(825, 57);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarP.TabIndex = 0;
            this.btnAgregarP.Text = "Agregar";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click);
            // 
            // btnLimpiarP
            // 
            this.btnLimpiarP.Location = new System.Drawing.Point(24, 38);
            this.btnLimpiarP.Name = "btnLimpiarP";
            this.btnLimpiarP.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarP.TabIndex = 10;
            this.btnLimpiarP.Text = "Limpiar";
            this.btnLimpiarP.UseVisualStyleBackColor = true;
            this.btnLimpiarP.Click += new System.EventHandler(this.btnLimpiarP_Click);
            // 
            // btnModificarP
            // 
            this.btnModificarP.Location = new System.Drawing.Point(336, 38);
            this.btnModificarP.Name = "btnModificarP";
            this.btnModificarP.Size = new System.Drawing.Size(75, 23);
            this.btnModificarP.TabIndex = 11;
            this.btnModificarP.Text = "Modificar";
            this.btnModificarP.UseVisualStyleBackColor = true;
            this.btnModificarP.Click += new System.EventHandler(this.btnModificarP_Click);
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.Location = new System.Drawing.Point(453, 38);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarP.TabIndex = 12;
            this.btnEliminarP.Text = "Eliminar";
            this.btnEliminarP.UseVisualStyleBackColor = true;
            this.btnEliminarP.Click += new System.EventHandler(this.btnEliminarP_Click);
            // 
            // btnModificarPStock
            // 
            this.btnModificarPStock.Location = new System.Drawing.Point(947, 38);
            this.btnModificarPStock.Name = "btnModificarPStock";
            this.btnModificarPStock.Size = new System.Drawing.Size(102, 23);
            this.btnModificarPStock.TabIndex = 13;
            this.btnModificarPStock.Text = "Modificar Stock";
            this.btnModificarPStock.UseVisualStyleBackColor = true;
            this.btnModificarPStock.Click += new System.EventHandler(this.btnModificarPStock_Click);
            // 
            // btnModificarPPrecio
            // 
            this.btnModificarPPrecio.Location = new System.Drawing.Point(1095, 38);
            this.btnModificarPPrecio.Name = "btnModificarPPrecio";
            this.btnModificarPPrecio.Size = new System.Drawing.Size(104, 23);
            this.btnModificarPPrecio.TabIndex = 14;
            this.btnModificarPPrecio.Text = "Modificar Precio";
            this.btnModificarPPrecio.UseVisualStyleBackColor = true;
            this.btnModificarPPrecio.Click += new System.EventHandler(this.btnModificarPPrecio_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabProductoPag.ResumeLayout(false);
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabPedidosPag;
        private System.Windows.Forms.TabPage tabClientePag;
        private System.Windows.Forms.TabPage tabProductoPag;
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBuscarP;
        private System.Windows.Forms.TextBox txtPrecioP;
        private System.Windows.Forms.TextBox txtCantidadStock;
        private System.Windows.Forms.TextBox txtDescripcionP;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.Label lblCantidadStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblBuscarP;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnModificarPPrecio;
        private System.Windows.Forms.Button btnModificarPStock;
        private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.Button btnModificarP;
        private System.Windows.Forms.Button btnLimpiarP;
        private System.Windows.Forms.Button btnAgregarP;
    }
}

