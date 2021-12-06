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
    class Pedido
    {
        //propiedades
        private long idPedido;
        private long idCliente;
        private DateTime fechaPedido;
        private DateTime fechaEsperada;
        private string comentarios;
        private string estado;
        public Pedido()
        {

        }
        public Pedido(long idPedido, long idCliente, DateTime fechaPedido, DateTime fechaEsperada, string comentarios, string estado)
        {
            this.IdPedido = idPedido;
            this.IdCliente = idCliente;
            this.FechaPedido = fechaPedido;
            this.FechaEsperada = fechaEsperada;
            this.Comentarios = comentarios;
            this.Estado = estado;
        }
        //gets y sets
        public long IdPedido { get => idPedido; set => idPedido = value; }
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public DateTime FechaPedido { get => fechaPedido; set => fechaPedido = value; }
        public DateTime FechaEsperada { get => fechaEsperada; set => fechaEsperada = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }
        public string Estado { get => estado; set => estado = value; }
        //obtener todos los pedidos 
        public DataTable getPedidos()
        {
            DataTable mydt = new DataTable();
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "select pedidos.idPedido as 'ID Pedido',clientes.idCliente as 'ID Cliente',concat(clientes.nombres,' ',clientes.apellidos)as 'Nombre Cliente',pedidos.fechaPedido as 'Fecha pedido',pedidos.fechaEsperada as 'Fecha esperada',pedidos.comentarios as 'Comentarios',pedidos.estado as 'Estado'   from pedidos inner join clientes on pedidos.idCliente=clientes.idCliente order by pedidos.idPedido desc;";
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
        //leer pedido para validar si se puede cancelar o no o si ya esta cancelado
        public void leerPedido()
        {
            DataTable mydt = new DataTable();
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "select pedidos.idPedido as 'ID Pedido',clientes.idCliente as 'ID Cliente',pedidos.fechaPedido as 'Fecha pedido',pedidos.fechaEsperada as 'Fecha esperada',pedidos.comentarios as 'Comentarios',pedidos.estado as 'Estado'   from pedidos inner join clientes on pedidos.idCliente=clientes.idCliente where pedidos.idPedido=@idPedido;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idPedido", this.idPedido);
            SqlDataReader mydr = null;
            try
            {
                conn.Open();
                mydr = cmd.ExecuteReader();
                mydt.Load(mydr);
                this.fechaEsperada = Convert.ToDateTime(mydt.Rows[0][3].ToString());
                this.estado = mydt.Rows[0][5].ToString();
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            
        }
        //pedidos procesados
        public DataTable getPedidosProcesados()
        {
            DataTable mydt = new DataTable();
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "select pedidos.idPedido as 'ID Pedido',clientes.idCliente as 'ID Cliente',concat(clientes.nombres,' ',clientes.apellidos)as 'Nombre Cliente',pedidos.fechaPedido as 'Fecha pedido',pedidos.fechaEsperada as 'Fecha esperada',pedidos.comentarios as 'Comentarios',pedidos.estado as 'Estado'   from pedidos inner join clientes on pedidos.idCliente=clientes.idCliente where pedidos.estado='Procesado' order by pedidos.idPedido desc";
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
        //pedidos enviados
        public DataTable getPedidosEnviados()
        {
            DataTable mydt = new DataTable();
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "select pedidos.idPedido as 'ID Pedido',clientes.idCliente as 'ID Cliente',concat(clientes.nombres,' ',clientes.apellidos)as 'Nombre Cliente',pedidos.fechaPedido as 'Fecha pedido',pedidos.fechaEsperada as 'Fecha esperada',pedidos.comentarios as 'Comentarios',pedidos.estado as 'Estado'   from pedidos inner join clientes on pedidos.idCliente=clientes.idCliente where pedidos.estado='Enviado' order by pedidos.idPedido desc";
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
        //pedidos en transito
        public DataTable getPedidosEnCamino()
        {
            DataTable mydt = new DataTable();
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "select pedidos.idPedido as 'ID Pedido',clientes.idCliente as 'ID Cliente',concat(clientes.nombres,' ',clientes.apellidos)as 'Nombre Cliente',pedidos.fechaPedido as 'Fecha pedido',pedidos.fechaEsperada as 'Fecha esperada',pedidos.comentarios as 'Comentarios',pedidos.estado as 'Estado'   from pedidos inner join clientes on pedidos.idCliente=clientes.idCliente where pedidos.estado='En Camino' order by pedidos.idPedido desc";
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
        //pedidos cancelados
        public DataTable getPedidosCancelados()
        {
            DataTable mydt = new DataTable();
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "select pedidos.idPedido as 'ID Pedido',clientes.idCliente as 'ID Cliente',concat(clientes.nombres,' ',clientes.apellidos)as 'Nombre Cliente',pedidos.fechaPedido as 'Fecha pedido',pedidos.fechaEsperada as 'Fecha esperada',pedidos.comentarios as 'Comentarios',pedidos.estado as 'Estado'   from pedidos inner join clientes on pedidos.idCliente=clientes.idCliente where pedidos.estado='Cancelado' order by pedidos.idPedido desc";
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
        //buscar pedidos por cliente
        public DataTable buscarPedidos()
        {
            DataTable mydt = new DataTable();
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "select pedidos.idPedido as 'ID Pedido',clientes.idCliente as 'ID Cliente',concat(clientes.nombres,' ',clientes.apellidos)as 'Nombre Cliente',pedidos.fechaPedido as 'Fecha pedido',pedidos.fechaEsperada as 'Fecha esperada',pedidos.comentarios as 'Comentarios',pedidos.estado as 'Estado'   from pedidos inner join clientes on pedidos.idCliente=clientes.idCliente where clientes.nombres like @apellidos or clientes.apellidos like @apellidos order by pedidos.idPedido desc;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@apellidos", '%' + this.comentarios + '%');
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
        //agregar pedido
        public long agregarPedido()
        {
            long id = 0;
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "INSERT INTO pedidos(idCliente, fechaPedido,fechaEsperada,comentarios,estado)values(@idCliente,@fechaPedido,@fechaEsperada,@comentarios,@estado)  ; select IDENT_CURRENT('productos') as id;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idCliente", this.idCliente);
            cmd.Parameters.AddWithValue("@fechaPedido", this.fechaPedido.Date);
            cmd.Parameters.AddWithValue("@fechaEsperada", this.fechaEsperada.Date);
            cmd.Parameters.AddWithValue("@comentarios", this.comentarios);
            cmd.Parameters.AddWithValue("@estado", this.estado);
            try
            {
                conn.Open();
                id = Convert.ToInt64(cmd.ExecuteScalar());
                Console.WriteLine(id);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return id;
        }
        //modificar
        public int modificarPedido()
        {
            int mod = 0;
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "UPDATE pedidos set fechaEsperada=@fechaEsperada,comentarios=@comentarios,estado=@estado WHERE idPedido=@idPedido;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@fechaEsperada", this.fechaEsperada.Date);
            cmd.Parameters.AddWithValue("@comentarios", this.comentarios);
            cmd.Parameters.AddWithValue("@estado", this.estado);
            cmd.Parameters.AddWithValue("@idPedido", this.idPedido);
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
        public int cancelarPedido()
        {
            int mod = 0;
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "update pedidos set estado='Cancelado' where idPedido=@idPedido;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idPedido", this.idPedido);
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
