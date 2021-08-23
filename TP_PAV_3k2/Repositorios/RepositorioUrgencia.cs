using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_3k2
{
    class RepositorioUrgencia
    {
        private accesoBD _BD;

        public RepositorioUrgencia()
        {
            _BD = new accesoBD();
        }
        public DataTable ObtenerUrgencia()
        {
            //se define una variable local a la función <sqltxt> del tipo <string> donde en el 
            //momento de su creación se le asigan su contenido, que es el comando SELECT  
            //necesario para poder establecer la veracidad del usuario.
            string sqltxt = "SELECT * FROM dbo.Urgencia";

            return _BD.consulta(sqltxt);
        }

        public bool Guardar(Urgencia urgencia)
        {
            string sqltxt = $"INSERT [dbo].[Urgencia] ([Nombre]) " +
                $"VALUES ('{urgencia.Nombre}')";

            return _BD.EjecutarSQL(sqltxt);
        }
        public DataTable SoyUrgenciaExistente(string nombre)
        {
            string sqltxt = $"SELECT * FROM Urgencia WHERE nombre='{nombre}'";
            return _BD.consulta(sqltxt);
        }
        public bool Eliminar(string urgenciaId)
        {
            string sqltxt = $"DELETE FROM [dbo].[Urgencia] WHERE idUrgencia = {urgenciaId}";

            return _BD.EjecutarSQL(sqltxt);
        }

        public Urgencia ObtenerUrgencia(string urgenciaId)
        {
            string sqltxt = $"SELECT * FROM dbo.Urgencia WHERE idUrgencia={urgenciaId}";
            var tablaTemporal = _BD.consulta(sqltxt);

            if (tablaTemporal.Rows.Count == 0)
                return null;
            var urgencia = new Urgencia();
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue;
                urgencia.Id = int.Parse(fila.ItemArray[0].ToString());
                urgencia.Nombre = fila.ItemArray[1].ToString();
            }
            return urgencia;
        }

        public bool Actualizar(Urgencia urgencia)
        {
            string sqltxt = $"UPDATE dbo.Urgencia SET Nombre = '{urgencia.Nombre}' WHERE idUrgencia={urgencia.Id}";

            return _BD.EjecutarSQL(sqltxt);
        }
    }
}
