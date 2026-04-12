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
    public class VehiculoXSucursal
    {
        public Sucursal Sucursal { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public int Cantidad { get; set; }

        public VehiculoXSucursal()
        { 
        }

        public VehiculoXSucursal(Sucursal sucursal, Vehiculo vehiculo, int cantidad)
        {
            Sucursal = sucursal;
            Vehiculo = vehiculo;
            Cantidad = cantidad;
        }
    }
}
