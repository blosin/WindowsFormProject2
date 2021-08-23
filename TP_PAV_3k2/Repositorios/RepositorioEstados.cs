using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3k2.Clases;

namespace TP_PAV_3k2.Repositorios
{
    class RepositorioEstados
    {
        private accesoBD _BD;

        public RepositorioEstados()
        {
            _BD = new accesoBD();
        }
        public DataTable ObtenerEstados()
        {
            //se define una variable local a la función <sqltxt> del tipo <string> donde en el 
            //momento de su creación se le asigan su contenido, que es el comando SELECT  
            //necesario para poder establecer la veracidad del usuario.
            string sqltxt = "SELECT * FROM dbo.Estado";

            return _BD.consulta(sqltxt);
        }
        public DataTable SoyEstadoExistente(string nombre)
        {
            string sqltxt = $"SELECT * FROM Estado WHERE nombre='{nombre}'";
            return _BD.consulta(sqltxt);
        }
        public bool Guardar(Estadoss estado)
        {
            string sqltxt = $"INSERT dbo.Estado (nombre) " +
                $"VALUES ('{estado.Nombre}')";

            return _BD.EjecutarSQL(sqltxt);
        }

        public bool Eliminar(string estadoID)
        {
            string sqltxt = $"DELETE FROM [dbo].[Estado] WHERE idEstado = {estadoID}";

            return _BD.EjecutarSQL(sqltxt);
        }

        public Estadoss ObtenerEstado(string estadoID)
        {
            string sqltxt = $"SELECT * FROM dbo.Estado WHERE idEstado={estadoID}";
            var tablaTemporal = _BD.consulta(sqltxt);

            if (tablaTemporal.Rows.Count == 0)
                return null;
            var estado = new Estadoss();
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue;
                estado.Id = int.Parse(fila.ItemArray[0].ToString());
                estado.Nombre= fila.ItemArray[1].ToString();
            }
            return estado;
        }

        public bool Actualizar(Estadoss estado)
        {
            string sqltxt = $"UPDATE dbo.Estado SET nombre = '{estado.Nombre}' WHERE idEstado={estado.Id}";

            return _BD.EjecutarSQL(sqltxt);
        }
    }
}
