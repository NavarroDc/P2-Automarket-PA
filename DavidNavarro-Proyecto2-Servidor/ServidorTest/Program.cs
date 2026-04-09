using CapaAccesoDatos;
using CapaEntidades;
using System;
using System.Data.SqlClient;
using System.Linq.Expressions;

CategoriaVehiculoDatos datos = new CategoriaVehiculoDatos();

List<CategoriaVehiculo> lista = datos.ObtenerCategorias();

foreach (var item in lista)
{
    Console.WriteLine(item.IdCategoria + " - " + item.NombreCategoria);
}

Console.ReadLine();