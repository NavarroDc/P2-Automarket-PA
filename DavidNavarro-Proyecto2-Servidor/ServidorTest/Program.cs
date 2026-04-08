using System;
using System.Data.SqlClient;
using CapaAccesoDatos;

Console.WriteLine("INICIO DEL PROGRAMA");

ConexionBaseDatos conexionDB = new ConexionBaseDatos();

using (SqlConnection conexion = conexionDB.CrearConexionDatos())
{
    try
    {
        Console.WriteLine("ANTES DE ABRIR CONEXION");

        conexion.Open();

        Console.WriteLine("CONEXION EXITOSA ");
    }
    catch (Exception ex)
    {
        Console.WriteLine("ERROR: " + ex.Message);
    }
}

Console.ReadLine();