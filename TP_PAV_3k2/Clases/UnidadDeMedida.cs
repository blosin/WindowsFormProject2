using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_3k2
{
    class UnidadDeMedida
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public bool NombreValido()
        {
            if (!string.IsNullOrEmpty(Nombre) && Nombre.Length < 51)
                return true;
            return false;
        }
    }
}
