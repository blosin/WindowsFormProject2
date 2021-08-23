using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_3k2
{
    class RepositorioTipoCombustible
    {
        private accesoBD _BD;

        public RepositorioTipoCombustible()
        {
            _BD = new accesoBD();
        }

        public DataTable ObtenerTiposCombustible()
        {
            //se define una variable local a la función <sqltxt> del tipo <string> donde en el 
            //momento de su creación se le asigan su contenido, que es el comando SELECT  
            //necesario para poder establecer la veracidad del usuario.
            string sqltxt = "SELECT * FROM dbo.TipoCombustible";

            return _BD.consulta(sqltxt);
        }

        public DataTable SoyTipoCombustibleExistente(string nombre)
        {
            string sqltxt = $"SELECT * FROM TipoCombustible WHERE nombre='{nombre}'";
            return _BD.consulta(sqltxt);
        }
        public string ObtenerNombreTipoCombustible(string numSurtidor)
        {
            string sqltxt;
            if (!string.IsNullOrEmpty(numSurtidor))
            {
                sqltxt = $"SELECT tipoCombustible.nombre FROM TipoCombustible tipoCombustible, Surtidor surtidor, Ticket ticket WHERE tipoCombustible.idTipoCombustible=surtidor.idTipoCombustible AND surtidor.numeroSurtidor=ticket.numeroSurtidor AND surtidor.numeroSurtidor='{numSurtidor}'";
                var tablaTemporal = _BD.consulta(sqltxt);
                if (tablaTemporal.Rows.Count == 0)
                    return null;
                string nombre = "";
                foreach (DataRow fila in tablaTemporal.Rows)
                {
                    if (fila.HasErrors)
                        continue;
                    nombre = fila.ItemArray[0].ToString();

                }
                return nombre;
            }
            else
                return "";
            
        }

        public bool Guardar(TipoCombustible tipoCombustible)
        {
            string sqltxt = $"INSERT dbo.TipoCombustible ( Nombre) " +
                $"VALUES ('{tipoCombustible.Nombre}')";               

            return _BD.EjecutarSQL(sqltxt);
        }

        public bool Eliminar(string TipoCombustibleID)
        {
            string sqltxt = $"DELETE FROM [dbo].[TipoCombustible] WHERE idTipoCombustible = {TipoCombustibleID}";

            return _BD.EjecutarSQL(sqltxt);
        }

        public TipoCombustible ObtenerTipoCombustible(string TipoCombustibleId)
        {
            string sqltxt = $"SELECT * FROM dbo.TipoCombustible WHERE idTipoCombustible={TipoCombustibleId}";
            var tablaTemporal = _BD.consulta(sqltxt);

            if (tablaTemporal.Rows.Count == 0)
                return null;
            var tipoCombustible = new TipoCombustible();
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue;
                tipoCombustible.Id = int.Parse(fila.ItemArray[0].ToString());
                tipoCombustible.Nombre = fila.ItemArray[1].ToString();
            }
            return tipoCombustible;
        }

        public bool Actualizar(TipoCombustible tipoCombustible)
        {
            string sqltxt = $"UPDATE dbo.TipoCombustible SET Nombre = '{tipoCombustible.Nombre}' WHERE idTipoCombustible={tipoCombustible.Id}";

            return _BD.EjecutarSQL(sqltxt);
        }
    }
}
