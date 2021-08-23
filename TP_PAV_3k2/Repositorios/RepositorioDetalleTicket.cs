using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_3k2.Repositorios
{
    class RepositorioDetalleTicket
    {
        private accesoBD _BD;

        public RepositorioDetalleTicket()
        {
            _BD = new accesoBD();
        }
        public DataTable ObtenerDetalles(string numTicket)
        {
            //SELECT a.nroDetalleTicket, b.nombre, a.cantidad, a.precio, CAST(REPLACE(a.precio, ',', '.') as float) * a.cantidad as subtotal FROM DetalleTicket a, Producto b WHERE a.idProducto = b.idProducto AND a.nroTicket =
                string sqltxt = $"SELECT a.nroDetalleTicket, b.nombre, a.cantidad, a.precio, CAST(REPLACE(a.precio, ',', '.') as float)*a.cantidad as subtotal FROM DetalleTicket a, Producto b WHERE a.idProducto=b.idProducto AND a.nroTicket='{numTicket}'";
            return _BD.consulta(sqltxt);
        }
    }
}
