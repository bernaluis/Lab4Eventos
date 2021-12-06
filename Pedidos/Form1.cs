using Pedidos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos correctamente");
            }
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            refrescarGridCliente();
            refrescarGridProducto();
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
            idCliente = row.Cells[0].Value.ToString();
            txtNombres.Text = row.Cells["Nombres"].Value.ToString();
            txtApellidos.Text = row.Cells["Apellidos"].Value.ToString();
            txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
            txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
            txtCiudad.Text = row.Cells["Ciudad"].Value.ToString();
            txtDepartamento.Text = row.Cells["Departamento"].Value.ToString();
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
            idProducto = row.Cells[0].Value.ToString();
            txtNombreP.Text = row.Cells["Producto"].Value.ToString();
            txtDescripcionP.Text = row.Cells["Descripcion"].Value.ToString();
            txtPrecioP.Text = row.Cells["Precio"].Value.ToString();
            txtCantidadStock.Text = row.Cells["Stock"].Value.ToString();
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
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto a eliminar");
            }
        }
    }
}
