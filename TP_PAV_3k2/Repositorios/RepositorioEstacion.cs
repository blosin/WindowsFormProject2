using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3k2.Clases;

namespace TP_PAV_3k2.Repositorios
{
    class RepositorioEstacion
    {
        private accesoBD _BD;

        public RepositorioEstacion()
        {
            _BD = new accesoBD();
        }

        public DataTable ObtenerSucursales()
        {
            //se define una variable local a la función <sqltxt> del tipo <string> donde en el 
            //momento de su creación se le asigan su contenido, que es el comando SELECT  
            //necesario para poder establecer la veracidad del usuario.
            string sqltxt = "SELECT * FROM dbo.Estacion";

            return _BD.consulta(sqltxt);
        }
        public DataTable ObtenerComboSucursales()
        {
            string sqltxt = "SELECT cuit, razonSocial+' '+\'('+cuit+\')' as sucursales FROM dbo.Estacion";

            return _BD.consulta(sqltxt);
        }
        public DataTable SoySucursalExistente(string cuit)
        {
            string sqltxt = $"SELECT * FROM Estacion WHERE cuit='{cuit}'";
            return _BD.consulta(sqltxt);
        }

        public bool Guardar(Estacion estacion)
        {
            string sqltxt = $"INSERT dbo.Estacion (cuit, razonSocial, calle, numero, fechaHabilitacion)" +
                $"VALUES ('{estacion.cuit}', '{estacion.razonSocial}', '{estacion.calle}', '{estacion.numero}', '{estacion.ReturnFechaHabilitacion()}')";

            return _BD.EjecutarSQL(sqltxt);
        }

        public bool Eliminar(string cuit)
        {
            string sqltxt = $"DELETE FROM [dbo].[Estacion] WHERE cuit = {cuit}";

            return _BD.EjecutarSQL(sqltxt);
        }

        public Estacion ObtenerSucursal(string estacionID)
        {
            string sqltxt = $"SELECT * FROM dbo.Estacion WHERE cuit={estacionID}";
            var tablaTemporal = _BD.consulta(sqltxt);

            if (tablaTemporal.Rows.Count == 0)
                return null;
            var estacion = new Estacion();
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                DateTime fecha;
                if (fila.HasErrors)
                    continue;
                estacion.cuit = fila.ItemArray[0].ToString();
                estacion.razonSocial = fila.ItemArray[1].ToString();
                estacion.calle = fila.ItemArray[2].ToString();
                estacion.numero = int.Parse(fila.ItemArray[3].ToString());
                DateTime.TryParse(fila.ItemArray[4]?.ToString(), out fecha);
                estacion.fechaHabilitacion = fecha;

            }
            return estacion;
        }
        public bool existeEstacion(string estacionID)
        {
            string sqltxt = $"SELECT * FROM dbo.Estacion WHERE cuit={estacionID}";
            var tablaTemporal = _BD.consulta(sqltxt);

            if (tablaTemporal.Rows.Count == 0)
                return true;
            else
                return false;
        }

        public bool Actualizar(Estacion estacion)
        {
            string sqltxt = $"UPDATE dbo.Estacion SET cuit= '{estacion.cuit}', razonSocial = '{estacion.razonSocial}', " +
                $"calle = '{estacion.calle}', numero= '{estacion.numero}', fechaHabilitacion = '{estacion.fechaHabilitacion.ToString("yyyy-MM-dd")}'  WHERE cuit={estacion.cuit}";

            return _BD.EjecutarSQL(sqltxt);
        }

        public DataTable ObtenerCuits()
        {
            string sqltxt = "SELECT cuit FROM dbo.Estacion";

            return _BD.consulta(sqltxt);
        }
    }
}
