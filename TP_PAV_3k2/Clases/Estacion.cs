using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_3k2.Clases
{
    class Estacion
    {
        public string cuit { get; set; }
        public string razonSocial { get; set; }
        public string calle { get; set; }
        public int numero { get; set; }
        public DateTime fechaHabilitacion { get; set; } 
    
        public bool cuitValido()
        {
            if (!string.IsNullOrEmpty(cuit.ToString()) && cuit.ToString().Length < 51)
                return true;
            return false;
        }
        public bool razonSocialValida()
        {
            if (!string.IsNullOrEmpty(razonSocial) && razonSocial.Length < 51)
                return true;
            return false;
        }
        public bool calleValida()
        {
            if (!string.IsNullOrEmpty(calle) && calle.Length < 51)
                return true;
            return false;
        }
        public bool numeroValido()
        {
            if (!string.IsNullOrEmpty(numero.ToString()) && numero.ToString().Length < 20)
                return true;
            return false;
        }
        public bool fechaValida()
        {
            DateTime fechaActual = DateTime.Today.Date;
            if (fechaHabilitacion > fechaActual)
                return false;
            return true;
        }
        public string ReturnFechaHabilitacion()
        {
            return fechaHabilitacion.ToString("yyyy-MM-dd");
        }
    }
}
