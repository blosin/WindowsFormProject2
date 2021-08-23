using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_3k2.Clases
{
    public class OrdenDeCompraa
    {
        public int numeroOrdenCompra { get; set; }

        public DateTime fecha { get; set; }

        public int legajo { get; set; }

        public string cuitSolicitante { get; set; }

        public IList<DetalleOrdenCompraa> detalleOrdenCompra { get; set; }

        public decimal MontoFinal { get; set; }

        public OrdenDeCompraa()
        {

        }


            public void Validar()
        {
            if (string.IsNullOrEmpty(legajo.ToString()))
                throw new ApplicationException("Ingrese legajo valido");
            if (string.IsNullOrEmpty(cuitSolicitante))
                throw new ApplicationException("Ingrese cuit valido");            
            if (detalleOrdenCompra == null || detalleOrdenCompra.Count == 0)
                throw new ApplicationException("Al menos se requiere un detalle");
            else
                foreach (var da in detalleOrdenCompra)
                    da.Validar();
            if (MontoFinal == 0)
                throw new ApplicationException("Al menos se requiere un detalle");
        }

        public string ObtenerFecha()
        {
            return fecha.ToString("yyyy-MM-dd");
        }

    }
}
