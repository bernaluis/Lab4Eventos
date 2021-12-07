using Pedidos.Models;
using System;
using System.Windows.Forms;

namespace Pedidos
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //instancia y id para usar en el modificar y eliminar cliente
        private readonly Cliente c = new Cliente();
        string idCliente = null;
        //instancia y id para usar en el modificar y eliminar producto
        private readonly Productos p = new Productos();
        string idProducto = null;
        //instancia y id para usar en el pedido
        private readonly Pedido pe = new Pedido();
        string idPedido = null;
        //instancia y id para usar en el pedido detalle
        private readonly DetallePedido ped = new DetallePedido();
        string idDetalle = null;
        //metodo para llenar el datagrid y/o refrescarlo cliente
        private void refrescarGridCliente()
        {
            dgvUsuario.DataSource = c.getCliente();
            limpiarCliente();

        }
        //metodo para llenar el datagrid y/o refrescarlo producto
        private void refrescarGridProducto()
        {
            dgvProductos.DataSource = p.getProductos();
            limpiarProducto();

        }
        //limpiar form producto
        private void limpiarProducto()
        {

            dgvProductos.ClearSelection();
            dgvProductos.AutoResizeColumns();
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            txtBuscarP.Clear();
            txtDescripcionP.Clear();
            txtPrecioP.Clear();
            txtNombreP.Clear();
            txtCantidadStock.Clear();
        }
        //limpiar form cliente
        private void limpiarCliente()
        {

            dgvUsuario.ClearSelection();
            dgvUsuario.AutoResizeColumns();
            dgvUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            txtApellidos.Clear();
            txtBuscarUsuario.Clear();
            txtCiudad.Clear();
            txtDepartamento.Clear();
            txtDireccion.Clear();
            txtNombres.Clear();
            txtTelefono.Clear();
        }
        private void btnLimpiarU_Click(object sender, EventArgs e)
        {
            //limpiar el form
            limpiarCliente();

        }
        //agregar cliente
        private void btnAgregarU_Click(object sender, EventArgs e)
        {
            //verificar si no estan vacios
            if (!string.IsNullOrEmpty(txtNombres.Text.Trim()) && !string.IsNullOrEmpty(txtApellidos.Text.Trim()) && !string.IsNullOrEmpty(txtCiudad.Text.Trim()) && !string.IsNullOrEmpty(txtDepartamento.Text.Trim()) && !string.IsNullOrEmpty(txtDireccion.Text.Trim()) && !string.IsNullOrEmpty(txtTelefono.Text.Trim()))
            {
                //ingresar los valores
                c.Nombres = txtNombres.Text.Trim();
                c.Apellidos = txtApellidos.Text.Trim();
                c.Direccion = txtDireccion.Text.Trim();
                c.Telefono = txtTelefono.Text.Trim();
                c.Departamento = txtDepartamento.Text.Trim();
                c.Ciudad = txtCiudad.Text.Trim();
                c.Estado = "1";
                //agregar
                long id = c.agregarCliente();
                //verificar si se agrego
                if (id > 0)
                {
                    MessageBox.Show("Agregado con exito");
                    refrescarGridCliente();
                    llenarCmbCliente();
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos correctamente");
            }
        }
        //para llenar el combobox del cliente
        private void llenarCmbCliente()
        {
            
            cmbCliente.DataSource = c.getClienteCmb();
            cmbCliente.DisplayMember ="Nombre";
            cmbCliente.ValueMember = "ID" ;
            
        }
        //para llenar el combobox del producto
        private void llenarCmbProducto()
        {

            cmbProducto.DataSource = p.getProductoCmb();
            cmbProducto.DisplayMember = "producto";
            cmbProducto.ValueMember = "idProducto";

        }
        //refrescar grid de pedidos
        private void refrescarGridPedidos()
        {
            
            dgvPedidos.DataSource = pe.getPedidos();
            

        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            refrescarGridPedidos(); 
            refrescarGridCliente();
            refrescarGridProducto();
            llenarCmbCliente();
            llenarCmbProducto();
            dtpFechaPedido.Value = DateTime.Now;
            dgvPedidos.AutoResizeColumns();
        }
        //modificar cliente
        private void btnModificarU_Click(object sender, EventArgs e)
        {
            //verificar si no estan vacios
            if (!string.IsNullOrEmpty(txtNombres.Text.Trim()) && !string.IsNullOrEmpty(txtApellidos.Text.Trim()) && !string.IsNullOrEmpty(txtCiudad.Text.Trim()) && !string.IsNullOrEmpty(txtDepartamento.Text.Trim()) && !string.IsNullOrEmpty(txtDireccion.Text.Trim()) && !string.IsNullOrEmpty(txtTelefono.Text.Trim()) && idCliente != null)
            {
                //ingresar los valores
                c.Nombres = txtNombres.Text.Trim();
                c.Apellidos = txtApellidos.Text.Trim();
                c.Direccion = txtDireccion.Text.Trim();
                c.Telefono = txtTelefono.Text.Trim();
                c.Departamento = txtDepartamento.Text.Trim();
                c.Ciudad = txtCiudad.Text.Trim();
                c.IdCliente = Convert.ToInt64(idCliente);
                //modificar
                long id = c.modificarCliente();
                //verificar si se modifico
                if (id >= 0)
                {
                    MessageBox.Show("Modificado con exito");
                    refrescarGridCliente();
                    llenarCmbCliente();
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos correctamente");
            }
        }
        //eliminar cliente
        private void btnEliminarU_Click(object sender, EventArgs e)
        {
            if (idCliente != null)
            {
                c.IdCliente = Convert.ToInt64(idCliente);
                int id = c.eliminarCliente();
                if (id > 0)
                {
                    MessageBox.Show("Eliminado con exito");
                    refrescarGridCliente();
                    llenarCmbCliente();
                }
            }
            else
            {
                MessageBox.Show("Seleccione el cliente a eliminar");
            }
        }
        //metodo de dgv cliente
        private void dgvUsuario_SelectionChanged(object sender, EventArgs e)
        {
            var row = dgvUsuario.CurrentRow;
            if (row != null)
            {
                idCliente = row.Cells[0].Value.ToString();
                txtNombres.Text = row.Cells["Nombres"].Value.ToString();
                txtApellidos.Text = row.Cells["Apellidos"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                txtCiudad.Text = row.Cells["Ciudad"].Value.ToString();
                txtDepartamento.Text = row.Cells["Departamento"].Value.ToString();
            }
                
        }

        //buscar cliente 
        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            c.Apellidos = txtBuscarUsuario.Text.Trim();
            dgvUsuario.DataSource = c.buscarClientes();
        }
        //validar solo numeros en form de producto
        private void txtCantidadStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validacion para solo numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //validacion solo numeros en form de producto
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validacion para solo numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //un decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        //para que llene los txt de producto al seleccionar en el datagrid
        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            var row = dgvProductos.CurrentRow;
            if (row != null)
            {
                idProducto = row.Cells[0].Value.ToString();
                txtNombreP.Text = row.Cells["Producto"].Value.ToString();
                txtDescripcionP.Text = row.Cells["Descripcion"].Value.ToString();
                txtPrecioP.Text = row.Cells["Precio"].Value.ToString();
                txtCantidadStock.Text = row.Cells["Stock"].Value.ToString();
            }
                
            
        }
        //limpiar form de producto
        private void btnLimpiarP_Click(object sender, EventArgs e)
        {
            refrescarGridProducto();
        }
        //agregar producto
        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            //verificar si no estan vacios
            if (!string.IsNullOrEmpty(txtNombreP.Text.Trim())&&!string.IsNullOrEmpty(txtPrecioP.Text.Trim()) && !string.IsNullOrEmpty(txtDescripcionP.Text.Trim()) && !string.IsNullOrEmpty(txtCantidadStock.Text.Trim()))
            {
                //ingresar los valores
                p.Producto = txtNombreP.Text.Trim();
                p.Descripcion = txtDescripcionP.Text.Trim();
                p.PrecioVenta = Convert.ToDecimal(txtPrecioP.Text.Trim());
                p.CantidadEnStock = Convert.ToInt32(txtCantidadStock.Text.Trim());
                p.Estado = "1";
                //agregar
                long id = p.agregarProducto();
                //verificar si se agrego
                if (id > 0)
                {
                    MessageBox.Show("Agregado con exito");
                    refrescarGridProducto();
                    llenarCmbProducto();
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos correctamente");
            }
        }
        //modificar producto
        private void btnModificarP_Click(object sender, EventArgs e)
        {
            //verificar si no estan vacios
            if (!string.IsNullOrEmpty(txtNombreP.Text.Trim()) && !string.IsNullOrEmpty(txtPrecioP.Text.Trim()) && !string.IsNullOrEmpty(txtDescripcionP.Text.Trim()) && !string.IsNullOrEmpty(txtCantidadStock.Text.Trim())&&idProducto!=null)
            {
                //ingresar los valores
                p.Producto = txtNombreP.Text.Trim();
                p.Descripcion = txtDescripcionP.Text.Trim();
                p.PrecioVenta = Convert.ToDecimal(txtPrecioP.Text.Trim());
                p.CantidadEnStock = Convert.ToInt32(txtCantidadStock.Text.Trim());
                p.IdProducto = Convert.ToInt64(idProducto);
                //agregar
                long id = p.modificarProducto();
                //verificar si se modifico
                if (id > 0)
                {
                    MessageBox.Show("Modificado con exito");
                    refrescarGridProducto();
                    llenarCmbProducto();
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos correctamente");
            }
        }

        private void btnModificarPStock_Click(object sender, EventArgs e)
        {
            //verificar si no estan vacios
            if (!string.IsNullOrEmpty(txtCantidadStock.Text.Trim()) && idProducto != null)
            {
                //ingresar los valores
               
                p.CantidadEnStock = Convert.ToInt32(txtCantidadStock.Text.Trim());
                p.IdProducto = Convert.ToInt64(idProducto);
                //agregar
                long id = p.modificarStockProducto();
                //verificar si se modifico
                if (id > 0)
                {
                    MessageBox.Show("Modificado el Stock con exito");
                    refrescarGridProducto();
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos correctamente");
            }
        }

        private void btnModificarPPrecio_Click(object sender, EventArgs e)
        {
            //verificar si no estan vacios
            if (!string.IsNullOrEmpty(txtPrecioP.Text.Trim()) && idProducto != null)
            {
                //ingresar los valores
                
                p.PrecioVenta = Convert.ToDecimal(txtPrecioP.Text.Trim());
                
                p.IdProducto = Convert.ToInt64(idProducto);
                //agregar
                long id = p.modificarPrecioProducto();
                //verificar si se modifico
                if (id > 0)
                {
                    MessageBox.Show("Modificado el precio con exito");
                    refrescarGridProducto();
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos correctamente");
            }
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            //verificar si no estan vacios
            if (idProducto != null)
            {
                //ingresar los valores
                p.IdProducto = Convert.ToInt64(idProducto);
                //agregar
                long id = p.eliminarProducto();
                //verificar si se modifico
                if (id > 0)
                {
                    MessageBox.Show("Eliminado con exito");
                    refrescarGridProducto();
                    llenarCmbProducto();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto a eliminar");
            }
        }
        //para agregar al carrito de compra
        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            if (cmbProducto.Items.Count == 0)
            {
                MessageBox.Show("No hay productos registrados");
            }
            else
            {
                p.IdProducto = Convert.ToInt64(cmbProducto.SelectedValue.ToString());
                p.leerInventario();
                //si la cantidad solicitada es menor al stock pasa
                if (p.CantidadEnStock >= Convert.ToInt32(txtCantidad.Text.Trim()))
                {

                    //ver si tiene rows el dgv

                    if (dgvCarrito.Rows.Count >= 1)
                    {

                        //bucle para recorrer el dgv
                        for (int i = 0; dgvCarrito.Rows.Count > i; i++)
                        {
                            //verificar si hay otro registro con el producto seleccionado
                            if (dgvCarrito.Rows[i].Cells[0].Value.ToString().Contains(cmbProducto.SelectedValue.ToString()))
                            {
                                //reemplazar la row con la nueva cantidad y precio
                                dgvCarrito.Rows.RemoveAt(i);
                                dgvCarrito.Rows.Add(cmbProducto.SelectedValue.ToString(), cmbProducto.Text, txtPrecioU.Text.Trim(), Convert.ToInt32(txtCantidad.Text.Trim()));

                                break;
                            }
                            else if (dgvCarrito.Rows.Count == i + 1)
                            {
                                dgvCarrito.Rows.Add(cmbProducto.SelectedValue.ToString(), cmbProducto.Text, txtPrecioU.Text.Trim(), Convert.ToInt32(txtCantidad.Text.Trim()));

                            }
                        }
                        txtPrecioU.Clear();
                        txtCantidad.Clear();

                    }
                    else
                    {
                        //si el dgv no tiene rows se agrega 
                        dgvCarrito.Rows.Add(cmbProducto.SelectedValue.ToString(), cmbProducto.Text, txtPrecioU.Text.Trim(), Convert.ToInt32(txtCantidad.Text.Trim()));
                        txtPrecioU.Clear();
                        txtCantidad.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("Excede la cantidad en inventario");
                }
            }


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //borra la celda que se selecciona en el carrito de compra
            dgvCarrito.Rows.RemoveAt(dgvCarrito.CurrentCell.RowIndex);
        }
        private void limpiarPedido()
        {
            dgvCarrito.Rows.Clear();
            txtComentarios.Clear();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarPedido();
        }
        //validacion solo numeros
        private void txtPrecioU_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validacion para solo numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //un decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        //validacion para solo numeros
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validacion para solo numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }

            
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //validando
            if (cmbCliente.Items.Count==0)
            {
                MessageBox.Show("No hay clientes registrados");
            }
            else
            {
                if (dgvCarrito.Rows.Count == 0)
                {
                    MessageBox.Show("Agregue productos al pedido");
                }
                else
                {
                    if (dtpFechaPedido.Value >= dtpFechaEsperada.Value)
                    {
                        MessageBox.Show("La fecha del pedido no puede ser la misma o menor a la de la fecha esperada");
                    }
                    else
                    {
                        if (txtComentarios.Text != "")
                        {
                            //ingresar los valores para el pedido general
                            pe.IdCliente = Convert.ToInt64(cmbCliente.SelectedValue.ToString());
                            pe.FechaPedido = dtpFechaPedido.Value;
                            pe.FechaEsperada = dtpFechaEsperada.Value;
                            pe.Comentarios = txtComentarios.Text.Trim();
                            //estado puede ser Procesado,En Camino, Enviado y Cancelado
                            //solo puede ser cancelado si aun esta en estado de procesado
                            pe.Estado = "Procesado";
                            //agregar
                            long id = pe.agregarPedido();
                            Console.WriteLine(id);
                            //verificar si se agrego
                            if (id > 0)
                            {
                                double totalPagar=0;
                                //agregando el detalle
                               for(int i=0;dgvCarrito.Rows.Count>i;i++)
                                {
                                    //ingresar los valores para el pedido general
                                    ped.IdPedido = id;
                                    ped.IdProducto = Convert.ToInt64(dgvCarrito.Rows[i].Cells[0].Value.ToString());
                                    ped.PrecioUnidad = Convert.ToDouble(dgvCarrito.Rows[i].Cells[2].Value.ToString());
                                    ped.NumeroLinea = Convert.ToInt32(dgvCarrito.Rows[i].Cells[3].Value.ToString());  
                                    ped.Estado = "1";
                                    totalPagar += (Convert.ToDouble(dgvCarrito.Rows[i].Cells[2].Value.ToString()) * Convert.ToInt32(dgvCarrito.Rows[i].Cells[3].Value.ToString()));
                                    //agregar
                                    long idd = ped.agregarDetallePedido(); 
                                    //verificar si se agrego
                                    if (idd > 0)
                                    {
                                        //descontando la orden del stock del producto
                                        p.IdProducto= Convert.ToInt64(dgvCarrito.Rows[i].Cells[0].Value.ToString());
                                        p.leerInventario();
                                        int nuevaCantidad = p.CantidadEnStock - ped.NumeroLinea;
                                        p.CantidadEnStock = nuevaCantidad;
                                        long idprod = p.modificarStockProducto();
                                        //verificar si se modifico
                                        if (idprod > 0)
                                        {
                                            
                                            refrescarGridProducto();
                                            refrescarGridPedidos(); 
                                        }
                                    }
                                }
                                MessageBox.Show("Pedido creado exitosamente, el total a pagar sera de: " + totalPagar+ "$");
                                limpiarPedido();   
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un comentario");
                        }
                    }
                }
            }
        }
        //buscar producto
        private void txtBuscarP_TextChanged(object sender, EventArgs e)
        {
            p.Producto = txtBuscarP.Text.Trim();
            dgvProductos.DataSource = p.buscarProductos();
        }
        //buscar pedido segun cliente
        private void txtBuscarPedido_TextChanged(object sender, EventArgs e)
        {
            pe.Comentarios = txtBuscarPedido.Text.Trim();
            dgvPedidos.DataSource = pe.buscarPedidos();
        }
        //mostrar todos los pedidos
        private void btnMostrarG_Click(object sender, EventArgs e)
        {
            dgvPedidos.DataSource = pe.getPedidos();
        }

        private void btnMostrarP_Click(object sender, EventArgs e)
        {
            dgvPedidos.DataSource = pe.getPedidosProcesados();
        }

        private void btnMostrarEC_Click(object sender, EventArgs e)
        {
            dgvPedidos.DataSource = pe.getPedidosEnCamino();
        }

        private void btnMostrarE_Click(object sender, EventArgs e)
        {
            dgvPedidos.DataSource = pe.getPedidosEnviados();
        }

        private void btnMostrarC_Click(object sender, EventArgs e)
        {
            dgvPedidos.DataSource = pe.getPedidosCancelados();
        }

        private void btnModificarPedido_Click(object sender, EventArgs e)
        {
            pe.IdPedido = Convert.ToInt64(idPedido);
            pe.leerPedido();
            if (pe.Estado == "Cancelado"|| pe.Estado == "Enviado")
            {
                MessageBox.Show("Un pedido cancelado/enviado no puede ser modificado");
            }
            else
            {
                if (dtpFECambio.Value <= pe.FechaPedido)
                {
                    MessageBox.Show("La fecha esperada no puede ser menor o la misma a cuando se realizo el pedido");
                }
                else
                {
                    if (txtComentarioC.Text.Trim() != "" && cmbEstado.SelectedIndex != -1 && idPedido != null)
                    {
                        pe.Comentarios = txtComentarioC.Text.Trim();
                        pe.FechaEsperada = dtpFECambio.Value;
                        pe.Estado = cmbEstado.Text;
                        pe.IdPedido = Convert.ToInt64(idPedido);
                        //modificar
                        long id = pe.modificarPedido();
                        //verificar si se modifico
                        if (id >= 0)
                        {
                            MessageBox.Show("Modificado con exito");
                            refrescarGridPedidos();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese los datos");
                    }
                }
            }
        }

        private void dgvPedidos_SelectionChanged(object sender, EventArgs e)
        {

            var row = dgvPedidos.CurrentRow;
            if (row != null)
            {
                
                idPedido = row.Cells[0].Value.ToString();
                txtComentarioC.Text = row.Cells["Comentarios"].Value.ToString();
            }


        }

        private void btnCancelarP_Click(object sender, EventArgs e)
        {
            pe.IdPedido = Convert.ToInt64(idPedido);
            pe.leerPedido();
            if (idPedido != null&&pe.Estado!="Cancelado" && pe.Estado != "Enviado" && pe.Estado != "En Camino")
            {
                pe.IdPedido = Convert.ToInt64(idPedido);
                //modificar
                long id = pe.cancelarPedido();
                //verificar si se modifico
                if (id >= 0)
                {
                    MessageBox.Show("Cancelado con exito");
                    refrescarGridPedidos();

                }
            }
            else
            {
                MessageBox.Show("Solo se pueden cancelar los pedidos que aun esten siendo procesados");
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            DetalleFrm frm = new DetalleFrm(idPedido);
            frm.ShowDialog();
            
        }
    }
}
