using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3k2.Clases;

namespace TP_PAV_3k2.Repositorios
{
    class RepositorioTiposDoc
    {
        private accesoBD _BD;

        public RepositorioTiposDoc()
        {
            _BD = new accesoBD();
        }
        public DataTable ObtenerTiposDocumento()
        {
            //se define una variable local a la función <sqltxt> del tipo <string> donde en el 
            //momento de su creación se le asigan su contenido, que es el comando SELECT  
            //necesario para poder establecer la veracidad del usuario.
            string sqltxt = "SELECT * FROM dbo.TipoDocumento";

            return _BD.consulta(sqltxt);
        }
        public DataTable SoySucursalExistente(string nombre)
        {
            string sqltxt = $"SELECT * FROM TipoDocumento WHERE nombre='{nombre}'";
            return _BD.consulta(sqltxt);
        }

        public bool Guardar(TipoDocumento tipoDocumento)
        {
            string sqltxt = $"INSERT dbo.TipoDocumento (Nombre) " +
                $"VALUES ('{tipoDocumento.Nombre}')";

            return _BD.EjecutarSQL(sqltxt);
        }
        public DataTable SoyTipoDocExistente(string nombre)
        {
            string sqltxt = $"SELECT * FROM TipoDocumento WHERE nombre='{nombre}'";
            return _BD.consulta(sqltxt);
        }
        public bool Eliminar(string TipoDocumentoID)
        {
            string sqltxt = $"DELETE FROM [dbo].[TipoDocumento] WHERE idTipoDocumento = {TipoDocumentoID}";

            return _BD.EjecutarSQL(sqltxt);
        }

        public TipoDocumento ObtenerTipoDocumento(string TipoDocumentoID)
        {
            string sqltxt = $"SELECT * FROM dbo.TipoDocumento WHERE idTipoDocumento={TipoDocumentoID}";
            var tablaTemporal = _BD.consulta(sqltxt);

            if (tablaTemporal.Rows.Count == 0)
                return null;
            var tipoDocumento = new TipoDocumento();
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue;
                tipoDocumento.Id = int.Parse(fila.ItemArray[0].ToString());
                tipoDocumento.Nombre = fila.ItemArray[1].ToString();
            }
            return tipoDocumento;
        }

        public bool Actualizar(TipoDocumento tipoDocumento)
        {
            string sqltxt = $"UPDATE dbo.TipoDocumento SET nombre = '{tipoDocumento.Nombre}' WHERE idTipoDocumento={tipoDocumento.Id}";

            return _BD.EjecutarSQL(sqltxt);
        }
    }
}
