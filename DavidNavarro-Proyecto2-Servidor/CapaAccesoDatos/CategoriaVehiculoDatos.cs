using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class CategoriaVehiculoDatos
    {
        private ConexionBaseDatos conexionBD = new ConexionBaseDatos();

        public List<CategoriaVehiculo> ObtenerCategorias()
        {
            List<CategoriaVehiculo> listaCategorias = new List<CategoriaVehiculo>();

            using (SqlConnection conexion = conexionBD.CrearConexionDatos())
            {
                try
                {
                    conexion.Open();
                    string consulta = "SELECT IdCategoria, NombreCategoria, Descripcion FROM CategoriaVehiculo";

                    SqlCommand comando = new SqlCommand(consulta, conexion);

                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        CategoriaVehiculo categoria = new CategoriaVehiculo();

                        categoria.IdCategoria = Convert.ToInt32(reader["IdCategoria"]);
                        categoria.NombreCategoria = reader["NombreCategoria"].ToString();
                        categoria.Descripcion = reader["Descripcion"].ToString();

                        listaCategorias.Add(categoria);
                    }
                    reader.Close();
                }catch(Exception ex)
                {
                    throw new Exception("Error al obtener las categorías: " + ex.Message);
                }
            }
            return listaCategorias;
        }
    }
}
