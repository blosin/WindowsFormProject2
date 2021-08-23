using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_3k2.Clases
{
    public class Tickett
    {
        public int numTicket { get; set; }

        public DateTime fecha { get; set; }

        public string cuit { get; set; }

        public Surtidorr numeroSurtidor { get; set; }

        public int cantidad { get; set; }

        public string unidadMedida { get; set; }        

        public IList<DetalleTickett> detalleTicket { get; set; }

        public string observacion { get; set; }

        public decimal MontoFinal { get; set; }

        public void Validar()
        {
            if (string.IsNullOrEmpty(cuit))
                throw new ApplicationException("Ingrese cuit valido");
            /*if (detalleTicket == null || detalleTicket.Count == 0)
                throw new ApplicationException("Al menos se requiere un detalle");
            else
                foreach (var da in detalleTicket)
                    da.Validar();*/
            if (MontoFinal == 0)
                throw new ApplicationException("Al menos se requiere un detalle");
        }

        public string ObtenerFecha()
        {
            return fecha.ToString("yyyy-MM-dd");
        }


        
    }
}
