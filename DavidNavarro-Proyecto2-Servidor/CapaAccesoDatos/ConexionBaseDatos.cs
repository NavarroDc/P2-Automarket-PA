using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class ConexionBaseDatos
    {
        private string connectionString;

        public ConexionBaseDatos()
        {
            connectionString = ConfigurationManager.ConnectionStrings["AutoMarketDB"].ConnectionString;
        }

        public SqlConnection CrearConexionDatos()
        {
            return new SqlConnection(connectionString);
        }
    }
}
