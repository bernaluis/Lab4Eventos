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
    class DetallePedido
    {
        private long idDetallePedido;
        private long idPedido;
        private long idProducto;
        private double precioUnidad;
        private int numeroLinea;
        private string estado;

        public DetallePedido()
        {

        }
        public DetallePedido(long idDetallePedido, double precioUnidad, string estado, int numeroLinea, long idPedido, long idProducto)
        {
            this.IdDetallePedido = idDetallePedido;

            this.PrecioUnidad = precioUnidad;
            this.Estado = estado;
            this.NumeroLinea = numeroLinea;
            this.IdPedido = idPedido;
            this.IdProducto = idProducto;
        }

        public long IdDetallePedido { get => idDetallePedido; set => idDetallePedido = value; }
        public double PrecioUnidad { get => precioUnidad; set => precioUnidad = value; }
        public string Estado { get => estado; set => estado = value; }
        
        public int NumeroLinea { get => numeroLinea; set => numeroLinea = value; }
        public long IdPedido { get => idPedido; set => idPedido = value; }
        public long IdProducto { get => idProducto; set => idProducto = value; }

        //obtener detalle pedido
        public DataTable getDetallePedido()
        {
            DataTable mydt = new DataTable();
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "select po.idProducto as 'ID producto',po.producto 'Nombre',d.numeroLinea as 'Cantidad',d.precioUnidad as 'Precio unitario' from detalle_pedido as d inner join pedidos as p on d.idPedido=p.idPedido inner join productos as po on po.idProducto=d.idProducto where d.idPedido=@idPedido";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idPedido", this.idPedido);
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
        
        //agregar detalle pedido
        public long agregarDetallePedido()
        {
            long id = 0;
            Conexion c = new Conexion();
            SqlConnection conn = c.conexion();
            string sql = "insert into detalle_pedido(idPedido,idProducto,precioUnidad,numeroLinea,estado)values(@idPedido,@idProducto,@precioUnidad,@numeroLinea,@estado);  select IDENT_CURRENT('pedidos') as id;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idPedido", this.idPedido);
            cmd.Parameters.AddWithValue("@idProducto", this.idProducto);
            cmd.Parameters.AddWithValue("@precioUnidad", this.precioUnidad);
            cmd.Parameters.AddWithValue("@numeroLinea", this.NumeroLinea);
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
    }
}
