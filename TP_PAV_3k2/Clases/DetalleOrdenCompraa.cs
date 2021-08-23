using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_3k2.Clases
{
    public class DetalleOrdenCompraa
    {
        public int numDetalleOrden { get; set; }

        public OrdenDeCompraa numOrdenCompra { get; set; }

        public Productoo producto { get; set; }

        public int cantidad { get; set; }

        public string unidadMedida { get; set; }

        public decimal precio { get; set; }

        public Urgencia urgencia { get; set; }


        public void Validar()
        {
            if (string.IsNullOrEmpty(cantidad.ToString()) || cantidad < 0)
                throw new ApplicationException("Ingrese cantidad valida");

            if (precio < 0)
                throw new ApplicationException("Ingrese precio valido");
        }

    }
}
