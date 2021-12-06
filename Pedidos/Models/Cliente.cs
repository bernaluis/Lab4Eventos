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
    class Cliente
    {
        //propiedades de usuario
        private long idCliente;
        private string nombres;
        private string apellidos;
        private string telefono;
        private string direccion;
        private string ciudad;
        private string departamento;
        private string estado;
        public Cliente()
        {

        }
        //constructor
        public Cliente(long idCliente, string nombres, string apellidos, string telefono, string direccion, string ciudad, string departamento, string estado)
        {
            this.IdCliente = idCliente;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Ciudad = ciudad;
            this.Departamento = departamento;
            this.Estado = estado;
        }
        //gets y sets de usuario
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Estado { get => estado; set => estado = value; }



        //metodos
        //para llenar el comobobx de cliente
        public DataTable getClienteCmb()
        {
            DataTable mydt = new DataTable();
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "select idCliente as ID,concat(nombres,' ',apellidos)as Nombre from clientes where estado='1';";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader mydr = null;
            try
            {
                mydt.Columns.Add("ID");
                mydt.Columns.Add("Nombres");
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
        //obtener clientes
        public DataTable getCliente()
        {
            DataTable mydt = new DataTable();
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "select idCliente as ID,nombres as Nombres,apellidos as Apellidos,telefono as Telefono,direccion as Direccion,ciudad as Ciudad,departamento as Departamento from clientes where estado='1';";
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
        //buscar clientes por apellidos o nombres
        public DataTable buscarClientes()
        {
            DataTable mydt = new DataTable();
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "select idCliente as ID,nombres as Nombres,apellidos as Apellidos,telefono as Telefono,direccion as Direccion,ciudad as Ciudad,departamento as Departamento from clientes where apellidos like @apellidos or nombres like @apellidos and estado='1';";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@apellidos", '%' + this.apellidos + '%');
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
        //agregar cliente
        public long agregarCliente()
        {
            long id = 0;
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "INSERT INTO clientes(nombres, apellidos , telefono , direccion , ciudad, departamento , estado) VALUES  (@nombres, @apellidos , @telefono   , @direccion , @ciudad, @departamento   , @estado) ; select IDENT_CURRENT('clientes') as id;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nombres", this.nombres);
            cmd.Parameters.AddWithValue("@apellidos", this.apellidos);
            cmd.Parameters.AddWithValue("@telefono", this.telefono);
            cmd.Parameters.AddWithValue("@direccion", this.direccion);
            cmd.Parameters.AddWithValue("@ciudad", this.ciudad);
            cmd.Parameters.AddWithValue("@departamento", this.ciudad);
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
        public int modificarCliente()
        {
            int mod = 0;
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "UPDATE clientes SET nombres = @nombres ,apellidos = @apellidos,telefono = @telefono, direccion=@direccion ,ciudad = @ciudad ,departamento = @departamento WHERE idCliente=@idCliente;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nombres", this.nombres);
            cmd.Parameters.AddWithValue("@apellidos", this.apellidos);
            cmd.Parameters.AddWithValue("@telefono", this.telefono);
            cmd.Parameters.AddWithValue("@direccion", this.direccion);
            cmd.Parameters.AddWithValue("@ciudad", this.ciudad);
            cmd.Parameters.AddWithValue("@departamento", this.ciudad);
            cmd.Parameters.AddWithValue("@idCliente", this.idCliente);
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
        //eliminar cliente
        public int eliminarCliente()
        {
            int mod = 0;
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "update clientes set estado='0' where idCliente=@idCliente;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idCliente", this.idCliente);
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
