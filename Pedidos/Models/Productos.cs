using Pedidos.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Models
{
    class Productos
    {
        //propiedades del producto
        private long idProducto;
        private string producto;
        private string descripcion;
        private int cantidadEnStock;
        private decimal precioVenta;
        private string estado;
        //constructores
        public Productos() { 
       }

        public Productos(long idProducto, string descripcion, int cantidadEnStock, decimal precioVenta, string estado, string producto)
        {
            this.idProducto = idProducto;
            this.descripcion = descripcion;
            this.cantidadEnStock = cantidadEnStock;
            this.precioVenta = precioVenta;
            this.estado = estado;
            this.Producto = producto;
        }
        //gets y sets
        public long IdProducto { get => idProducto; set => idProducto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int CantidadEnStock { get => cantidadEnStock; set => cantidadEnStock = value; }
        public decimal PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Producto { get => producto; set => producto = value; }

        //metodos
        //para verificar el inventario del producto
        public void leerInventario()
        {
            DataTable mydt = new DataTable();
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "select cantidadEnStock from productos where idProducto=@idProducto;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idProducto", this.idProducto);
            SqlDataReader mydr = null;
            try
            {
                conn.Open();
                mydr = cmd.ExecuteReader();
                mydt.Load(mydr);
                this.cantidadEnStock = Convert.ToInt32(mydt.Rows[0][0].ToString());
                
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

        }
        //para llenar el comobobx de producto
        public DataTable getProductoCmb()
        {
            DataTable mydt = new DataTable();
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "select idProducto,producto from productos where estado='1';";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader mydr = null;
            try
            {
                mydt.Columns.Add("idProducto",typeof(string));
                mydt.Columns.Add("producto",typeof(string));
                conn.Open();
                mydr = cmd.ExecuteReader();
                mydt.Load(mydr);

            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return mydt;
        }
        //obtener productos
        public DataTable getProductos()
        {
            DataTable mydt = new DataTable();
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "select idProducto as ID,producto as Producto,descripcion as Descripcion, precioVenta as Precio,cantidadEnStock as Stock from productos  where estado='1';";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader mydr = null;
            try
            {
                conn.Open();
                mydr = cmd.ExecuteReader();
                mydt.Load(mydr);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return mydt;
        }
        //buscar productos por su nombre
        public DataTable buscarProductos()
        {
            DataTable mydt = new DataTable();
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "select idProducto as ID,producto as Producto,descripcion as Descripcion, precioVenta as Precio,cantidadEnStock as Stock from  productos where producto like @producto and estado='1';";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@producto", '%' + this.producto + '%');
            SqlDataReader mydr = null;
            try
            {
                conn.Open();
                mydr = cmd.ExecuteReader();
                mydt.Load(mydr);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return mydt;
        }
        //agregar producto
        public long agregarProducto()
        {
            long id = 0;
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "INSERT INTO productos(producto,descripcion,cantidadEnStock,precioVenta , estado) VALUES  (@producto,@descripcion,@cantidadEnStock,@precioVenta, @estado);  select IDENT_CURRENT('pedidos') as id;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@producto", this.producto);
            cmd.Parameters.AddWithValue("@descripcion", this.descripcion);
            cmd.Parameters.AddWithValue("@cantidadEnStock", this.cantidadEnStock);
            cmd.Parameters.AddWithValue("@precioVenta", this.precioVenta);
            cmd.Parameters.AddWithValue("@estado", this.estado);
            try
            {
                conn.Open();
                id = Convert.ToInt64(cmd.ExecuteScalar());
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return id;
        }
        //modificar
        public int modificarProducto()
        {
            int mod = 0;
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "UPDATE productos set producto=@producto,descripcion=@descripcion,cantidadEnStock=@cantidadEnStock,precioVenta=@precioVenta WHERE idProducto=@idProducto;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@producto", this.producto);
            cmd.Parameters.AddWithValue("@descripcion", this.descripcion);
            cmd.Parameters.AddWithValue("@cantidadEnStock", this.cantidadEnStock);
            cmd.Parameters.AddWithValue("@precioVenta", this.precioVenta);
            cmd.Parameters.AddWithValue("@idProducto", this.idProducto);
            try
            {
                conn.Open();
                mod = cmd.ExecuteNonQuery();

            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return mod;
        }
        //metodo para solo modificar el stock
        public int modificarStockProducto()
        {
            int mod = 0;
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "UPDATE productos set cantidadEnStock=@cantidadEnStock WHERE idProducto=@idProducto;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cantidadEnStock", this.cantidadEnStock);
            cmd.Parameters.AddWithValue("@idProducto", this.idProducto);
            try
            {
                conn.Open();
                mod = cmd.ExecuteNonQuery();

            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return mod;
        }
        //metodo para solo modificar el precio
        public int modificarPrecioProducto()
        {
            int mod = 0;
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "UPDATE productos set precioVenta=@precioVenta WHERE idProducto=@idProducto;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@precioVenta", this.precioVenta);
            cmd.Parameters.AddWithValue("@idProducto", this.idProducto);
            try
            {
                conn.Open();
                mod = cmd.ExecuteNonQuery();

            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return mod;
        }
        //eliminar 
        public int eliminarProducto()
        {
            int mod = 0;
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "update productos set estado='0' where idProducto=@idProducto;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idProducto", this.idProducto);
            try
            {
                conn.Open();
                mod = cmd.ExecuteNonQuery();
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return mod;
        }

    }
}
