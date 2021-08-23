using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_3k2.Clases
{
    public class Productoo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public DateTime FechaUltimaActualizacion { get; set; }
        public string UnidadMedida { get; set; }

        public bool NombreValido()
        {
            if (!string.IsNullOrEmpty(Nombre) && Nombre.Length < 30)
                return true;
            return false;
        }
        public bool DescripcionValida()
        {
            if (!string.IsNullOrEmpty(Descripcion) && Nombre.Length < 200)
                return true;
            return false;
        }
        public bool StockValido()
        {
            if (!string.IsNullOrEmpty(Stock.ToString()) && Stock >= 0)
                return true;
            return false;
        }
        public bool PrecioCompraValido()
        {
            if (!string.IsNullOrEmpty(PrecioCompra.ToString()) && PrecioCompra > 0)
                return true;
            return false;
        }
        public bool PrecioVentaValido()
        {
            if (!string.IsNullOrEmpty(PrecioVenta.ToString()) && PrecioVenta > 0)
                return true;
            return false;
        }
        public string ReturnFechaActualizacion()
        {
            return FechaUltimaActualizacion.ToString("yyyy-MM-dd");
        }

    }
}
