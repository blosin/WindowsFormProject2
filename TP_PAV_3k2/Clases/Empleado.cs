using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_3k2.Clases
{
    class Empleado
    {
        public int legajo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tipoDoc { get; set; }
        public int nroDoc { get;set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime fechaAlta { get; set; }
        public int legajoSuperior { get; set; }
        public string cuit { get; set; }

        public bool cuitValido()
        {
            if (!string.IsNullOrEmpty(cuit.ToString()) && cuit.ToString().Length < 51)
                return true;
            return false;
        }
        public bool legajoValido()
        {
            if (!string.IsNullOrEmpty(legajo.ToString()))
                return true;
            return false;
        }
        public bool nombreValido()
        {
            if (!string.IsNullOrEmpty(nombre.ToString()) && nombre.ToString().Length < 51)
                return true;
            return false;
        }
        public bool apellidoValido()
        {
            if (!string.IsNullOrEmpty(apellido.ToString()) && apellido.ToString().Length < 51)
                return true;
            return false;
        }
        public bool tipoDocValido()
        {
            if (!string.IsNullOrEmpty(tipoDoc.ToString()) && tipoDoc.ToString().Length < 10)
                return true;
            return false;
        }
        public bool nroDocValido()
        {
            if (!string.IsNullOrEmpty(nroDoc.ToString()) && nroDoc.ToString().Length < 50)
                return true;
            return false;
        }
        public bool fechaNacimientoValida()
        {
            DateTime fechaActual = DateTime.Today.Date;
            if (fechaNacimiento > fechaActual)
                return false;
            return true;
        }
        public bool fechaAltaValida()
        {
            DateTime fechaActual = DateTime.Today.Date;
            if (fechaAlta > fechaActual)
                return false;
            return true;
        }
        public string ReturnfechaNacimiento()
        {
            return fechaNacimiento.ToString("yyyy-MM-dd");
        }
        public void AsignarFechaAlta()
        {
            fechaAlta= DateTime.Today.Date;
        }
        public string ReturnFechaAlta()
        {
            return fechaAlta.ToString("yyyy-MM-dd");
        }


    }
}
