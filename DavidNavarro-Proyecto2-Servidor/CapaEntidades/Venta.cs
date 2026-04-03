using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public int IdSucursal { get; set; }
        public int IdVehiculo { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Monto { get; set; }

        //Constructor sin IdVenta
        public Venta(int idCliente, int idSucursal, int idVehiculo, DateTime fechaVenta, decimal monto)
        {
            IdCliente = idCliente;
            IdSucursal = idSucursal;
            IdVehiculo = idVehiculo;
            FechaVenta = fechaVenta;
            Monto = monto;
        }

        //Constructor con IdVenta
        public Venta(int idVenta, int idCliente, int idSucursal, int idVehiculo, DateTime fechaVenta, decimal monto)
        {
            IdVenta = idVenta;
            IdCliente = idCliente;
            IdSucursal = idSucursal;
            IdVehiculo = idVehiculo;
            FechaVenta = fechaVenta;
            Monto = monto;
        }
    }
}
