using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Util
{
    class Conexion
    {
        public SqlConnection conexion()
        {
            SqlConnection conn;
            try
            {
                string cadena = "Data Source=BERNAL\\SQLEXPRESS;Initial Catalog=pedidos;Persist Security Info=True;User ID=sa;Password=Pa$$w0rd";
                conn = new SqlConnection(cadena);
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al conectar", ex);
            }
            return conn;
        }
    }
}
