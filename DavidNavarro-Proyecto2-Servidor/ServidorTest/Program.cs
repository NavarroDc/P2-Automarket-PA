using System;
using System.Data.SqlClient;
using System.Linq.Expressions;
using CapaAccesoDatos;

Console.WriteLine("INICIO DEL PROGRAMA");

ConexionBaseDatos conexionDB = new ConexionBaseDatos();

using (SqlConnection conexion = conexionDB.CrearConexionDatos())
{
    try
    {
        conexion.Open();
        Console.WriteLine("CONEXION EXITOSA");

        string consulta = "SELECT IdCategoria, NombreCategoria, Descripcion FROM CategoriaVehiculo";

        SqlCommand comando = new SqlCommand(consulta, conexion);

        SqlDataReader reader = comando.ExecuteReader();

        Console.WriteLine("\nDATOS DE CATEGORIA\n");

        while (reader.Read())
        {
            Console.WriteLine("ID: " + reader["IdCategoria"]);
            Console.WriteLine("Nombre: " + reader["NombreCategoria"]);
            Console.WriteLine("Descripción: " + reader["Descripcion"]);
            Console.WriteLine("---------------------------");
        }

        reader.Close();
    } catch (Exception ex)
    {
        Console.WriteLine("ERROR: " + ex.Message);
    }
}
Console.ReadLine();