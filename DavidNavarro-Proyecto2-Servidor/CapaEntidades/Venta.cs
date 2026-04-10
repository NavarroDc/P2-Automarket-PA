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
    public class Venta
    {
        public int IdVenta { get; set; }
        public Cliente Cliente { get; set; }
        public Sucursal Sucursal { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Monto { get; set; }


        public Venta()
        { 
        }

        //Constructor sin IdVenta
        public Venta(Cliente cliente, Sucursal sucursal, Vehiculo vehiculo, DateTime fechaVenta, decimal monto)
        {
            Cliente = cliente;
            Sucursal = sucursal;
            Vehiculo = vehiculo;
            FechaVenta = fechaVenta;
            Monto = monto;
        }

        //Constructor con IdVenta
        public Venta(int idVenta, Cliente cliente, Sucursal sucursal, Vehiculo vehiculo, DateTime fechaVenta, decimal monto)
        {
            IdVenta = idVenta;
            Cliente = cliente;
            Sucursal = sucursal;
            Vehiculo = vehiculo;
            FechaVenta = fechaVenta;
            Monto = monto;
        }
    }
}
