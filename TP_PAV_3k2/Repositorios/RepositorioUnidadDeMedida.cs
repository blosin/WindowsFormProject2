using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_3k2
{
    class RepositorioUnidadDeMedida
    {
        private accesoBD _BD;

        public RepositorioUnidadDeMedida()
        {
            _BD = new accesoBD();
        }
        public DataTable ObtenerUnidadesMedida()
        {
            //se define una variable local a la función <sqltxt> del tipo <string> donde en el 
            //momento de su creación se le asigan su contenido, que es el comando SELECT  
            //necesario para poder establecer la veracidad del usuario.
            string sqltxt = "SELECT * FROM dbo.UnidadMedida";

            return _BD.consulta(sqltxt);
        }
        public DataTable SoyUnidadMedidaExistente(string nombre)
        {
            string sqltxt = $"SELECT * FROM UnidadMedida WHERE nombre='{nombre}'";
            return _BD.consulta(sqltxt);
        }
        public bool Guardar(UnidadDeMedida unidadmedida)
        {
            string sqltxt = $"INSERT dbo.UnidadMedida (Nombre) " +
                $"VALUES ('{unidadmedida.Nombre}')";

            return _BD.EjecutarSQL(sqltxt);
        }

        public bool Eliminar(string unidadmedidaId)
        {
            string sqltxt = $"DELETE FROM [dbo].[UnidadMedida] WHERE idUnidadMedida = {unidadmedidaId}";

            return _BD.EjecutarSQL(sqltxt);
        }

        public UnidadDeMedida OtenerUnidadMedida(string unidadmedidaId)
        {
            string sqltxt = $"SELECT * FROM dbo.UnidadMedida WHERE idUnidadMedida={unidadmedidaId}";
            var tablaTemporal = _BD.consulta(sqltxt);

            if (tablaTemporal.Rows.Count == 0)
                return null;
            var unidadmedida = new UnidadDeMedida();
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue;
                unidadmedida.Id = int.Parse(fila.ItemArray[0].ToString());
                unidadmedida.Nombre = fila.ItemArray[1].ToString();
            }
            return unidadmedida;
        }

        public bool Actualizar(UnidadDeMedida unidadmedida)
        {
            string sqltxt = $"UPDATE dbo.UnidadMedida SET Nombre = '{unidadmedida.Nombre}' WHERE idUnidadMedida={unidadmedida.Id}";

            return _BD.EjecutarSQL(sqltxt);
        }

        public string ObtenerNombreUnidadMedida(string id)
        {
            string sqltxt;
            if (!string.IsNullOrEmpty(id))
            {
                sqltxt = $"SELECT nombre FROM UnidadMedida WHERE idUnidadMedida={id}";
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
    }
}
