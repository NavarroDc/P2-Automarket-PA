using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* UNED I Cuatrimestre
 * Programación avanzada
 * Profesor: Johan Figueroa Guevara
 * Proyecto 2: Automarket
 * Estudiante: David Navarro Camacho
 * Fecha: 12/4/2026
 */

namespace CapaEntidades
{
    public class CategoriaVehiculo
    {
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion {  get; set; }

        public CategoriaVehiculo()
        {
        }

        public CategoriaVehiculo(int idCategoria, string nombreCategoria, string descripcion)
        {
            IdCategoria = idCategoria;
            NombreCategoria = nombreCategoria;
            Descripcion = descripcion;
        }

        public CategoriaVehiculo(string nombreCategoria, string descripcion)
        {
            NombreCategoria = nombreCategoria;
            Descripcion = descripcion;
        }
    }
}
