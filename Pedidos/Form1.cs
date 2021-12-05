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
        //metodo para llenar el datagrid y/o refrescarlo cliente
        private void refrescarGridCliente()
        {
            dgvUsuario.DataSource = c.getCliente();
            limpiarCliente();

        }
        //limpiar form cliente
        private void limpiarCliente()
        {
            dgvUsuario.ClearSelection();
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
            if (!string.IsNullOrEmpty(txtNombres.Text.Trim())&& !string.IsNullOrEmpty(txtApellidos.Text.Trim()) && !string.IsNullOrEmpty(txtCiudad.Text.Trim()) && !string.IsNullOrEmpty(txtDepartamento.Text.Trim()) && !string.IsNullOrEmpty(txtDireccion.Text.Trim()) && !string.IsNullOrEmpty(txtTelefono.Text.Trim()))
            {
                //ingresar los valores
                c.Nombres = txtNombres.Text.Trim();
                c.Apellidos=txtApellidos.Text.Trim();
                c.Direccion=txtDireccion.Text.Trim();
                c.Telefono=txtTelefono.Text.Trim();
                c.Departamento=txtDepartamento.Text.Trim();
                c.Ciudad=txtCiudad.Text.Trim();
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
            else{
                MessageBox.Show("Ingrese los datos correctamente");
            }
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            refrescarGridCliente();
        }
        //modificar cliente
        private void btnModificarU_Click(object sender, EventArgs e)
        {
            //verificar si no estan vacios
            if (!string.IsNullOrEmpty(txtNombres.Text.Trim()) && !string.IsNullOrEmpty(txtApellidos.Text.Trim()) && !string.IsNullOrEmpty(txtCiudad.Text.Trim()) && !string.IsNullOrEmpty(txtDepartamento.Text.Trim()) && !string.IsNullOrEmpty(txtDireccion.Text.Trim()) && !string.IsNullOrEmpty(txtTelefono.Text.Trim())&&idCliente!=null)
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
            txtNombres.Text = row.Cells["nombres"].Value.ToString();
            txtApellidos.Text = row.Cells["apellidos"].Value.ToString();
            txtTelefono.Text= row.Cells["telefono"].Value.ToString();
            txtDireccion.Text= row.Cells["direccion"].Value.ToString();
            txtCiudad.Text= row.Cells["ciudad"].Value.ToString();
            txtDepartamento.Text= row.Cells["departamento"].Value.ToString();
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            c.Apellidos = txtBuscarUsuario.Text.Trim();
            dgvUsuario.DataSource = c.buscarClientes();
        }

        private void tabClientePag_Enter(object sender, EventArgs e)
        {

        }
    }
}
