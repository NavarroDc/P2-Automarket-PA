using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Sucursal
    {
        public int IdSucursal { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Vendedor Vendedor { get; set; }
        public bool Activo { get; set; }

        public Sucursal()
        {
        }

        public Sucursal(int idSucursal, string nombre, string direccion, string telefono, Vendedor vendedor, bool activo)
        {
            IdSucursal = idSucursal;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Vendedor = vendedor;
            Activo = activo;
        }
    }
}
