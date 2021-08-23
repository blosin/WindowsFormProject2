using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_3k2
{
    public class Urgencia
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nombre { get; set; }
                
        public bool NombreValido()
        {
            if (!string.IsNullOrEmpty(Nombre) && Nombre.Length < 51)
                return true;
            return false;
        }
    }
}
