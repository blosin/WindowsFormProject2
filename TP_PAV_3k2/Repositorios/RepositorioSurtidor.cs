using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3k2.Clases;

namespace TP_PAV_3k2.Repositorios
{
    class RepositorioSurtidor
    {
        private accesoBD _BD;

        public RepositorioSurtidor()
        {
            _BD = new accesoBD();
        }

        public DataTable ObtenerTiposCombustible()
        {
            string sqltxt = "SELECT * FROM dbo.TipoCombustible";

            return _BD.consulta(sqltxt);
        }
        public string ObtenerUnidadMedia(string numSurtidor)
        {
            //SELECT idTipoCombustible FROM Surtidor WHERE numeroSurtidor = numSurtidor;
            string sqltxt = $"SELECT unidadMedida FROM dbo.Producto " +
            $"WHERE nombre= (SELECT nombre FROM TipoCombustible WHERE idTipoCombustible=(SELECT idTipoCombustible FROM Surtidor WHERE numeroSurtidor = '{numSurtidor}'))";
            var tablaTemporal = _BD.consulta(sqltxt);

            if (tablaTemporal.Rows.Count == 0)
                return null;
            string unidadMedida="";
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue;
                unidadMedida= fila.ItemArray[0].ToString();               

            }
            return unidadMedida;
        }

        public DataTable ObtenerEstados()
        {
            string sqltxt = "SELECT * FROM Estado";

            return _BD.consulta(sqltxt);
        }

        public DataTable ObtenerCuits()
        {
            string sqltxt = "SELECT * FROM dbo.Estacion";

            return _BD.consulta(sqltxt);
        }
        public DataTable ObtenerComboSucursales()
        {
            string sqltxt = "SELECT cuit, razonSocial+' '+\'('+cuit+\')' as sucursales FROM dbo.Estacion";

            return _BD.consulta(sqltxt);
        }
        public DataTable ObtenerSurtidores()
        {            
            string sqltxt = "SELECT a.numeroSurtidor, a.cuit, b.nombre, c.nombre FROM Surtidor a, Estado b, TipoCombustible c WHERE a.idEstado=b.idEstado AND a.idTipoCombustible=c.idTipoCombustible";

            return _BD.consulta(sqltxt);
        }
        public DataTable ObtenerSurtidoresCombo()
        {
            string sqltxt = "SELECT a.numeroSurtidor as numeroSurtidor, CAST(a.numeroSurtidor AS varchar)+' '+c.nombre as nombre FROM Surtidor a, TipoCombustible c WHERE a.idTipoCombustible=c.idTipoCombustible";

            return _BD.consulta(sqltxt);
        }
        public DataTable ObtenerSurtidoresPorCuit(string cuit)
        {
            string sqltxt = $"SELECT a.numeroSurtidor as numeroSurtidor, c.nombre+' '+\'('+CAST(a.numeroSurtidor AS varchar)+\')' as nombre FROM Surtidor a, TipoCombustible c WHERE a.idTipoCombustible=c.idTipoCombustible AND a.cuit='{cuit}'";

            return _BD.consulta(sqltxt);
        }

        public bool Guardar(Surtidorr surtidor)
        {
            string sqltxt =$"INSERT dbo.Surtidor (cuit, idEstado, idTipoCombustible)" +
                    $"VALUES ('{surtidor.cuit}', (SELECT idEstado FROM Estado WHERE nombre='{surtidor.idEstado}'), (SELECT idTipoCombustible FROM TipoCombustible WHERE nombre='{surtidor.idTipoCombustible}'))";
            
            return _BD.EjecutarSQL(sqltxt);
        }

        public bool Eliminar(string numeroSurtidor)
        {
            string sqltxt = $"DELETE FROM [dbo].[Surtidor] WHERE numeroSurtidor = {numeroSurtidor}";

            return _BD.EjecutarSQL(sqltxt);
        }

        public Surtidorr ObtenerSurtidor(string numeroSurtidor)
        {
            // a.numeroSurtidor, a.cuit, b.nombre, c.nombre FROM Surtidor a, Estado b, TipoCombustible c WHERE a.idEstado=b.idEstado AND a.idTipoCombustible=c.idTipoCombustible"
            string sqltxt = $"SELECT a.numeroSurtidor, a.cuit, b.nombre, c.nombre FROM Surtidor a, Estado b, TipoCombustible c WHERE a.idEstado=b.idEstado AND a.idTipoCombustible=c.idTipoCombustible AND a.numeroSurtidor={numeroSurtidor}";
            var tablaTemporal = _BD.consulta(sqltxt);

            if (tablaTemporal.Rows.Count == 0)
                return null;
            var surtidor = new Surtidorr();
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue;
                surtidor.numeroSurtidor = int.Parse(fila.ItemArray[0].ToString());
                surtidor.cuit = fila.ItemArray[1].ToString();
                surtidor.idEstado= fila.ItemArray[2].ToString();
                surtidor.idTipoCombustible = fila.ItemArray[3].ToString();
                
            }
            return surtidor;
        }

        public bool Actualizar(Surtidorr surtidor)
        {
            string sqltxt= $"UPDATE dbo.Surtidor SET cuit = '{surtidor.cuit}', idEstado = (SELECT idEstado FROM Estado WHERE nombre='{surtidor.idEstado}'), idTipoCombustible= (SELECT idTipoCombustible FROM TipoCombustible WHERE nombre='{surtidor.idTipoCombustible}')" +
                $" WHERE numeroSurtidor={surtidor.numeroSurtidor}";
            
            return _BD.EjecutarSQL(sqltxt);
        }

    }
}
