using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3k2.Clases;

namespace TP_PAV_3k2.Repositorios
{
    class RepositorioTickets
    {
        private accesoBD _BD;

        public RepositorioTickets()
        {
            _BD = new accesoBD();
        }


        public DataTable ObtenerTickets()
        {
            string sqltxt = "SELECT * FROM Ticket";

            return _BD.consulta(sqltxt);
        }
        public DataTable ObtenerTicket(string numTicket)
        {
            string sqltxt = $"SELECT * FROM Ticket WHERE numTicket='{numTicket}'";

            return _BD.consulta(sqltxt);
        }

        public DataTable ObtenerLegajos()
        {
            string sqltxt = "SELECT legajo FROM dbo.Empleado";

            return _BD.consulta(sqltxt);
        }

        public int Guardar(Tickett v)
        {
            int numticket=0;
            using (var tx = _BD.IniciarTransaccion())
            {
                try
                {                    //CAST(REPLACE( '{producto.PrecioCompra}', ',', '.') as float)
                    string sqltxt = $"INSERT [dbo].[Ticket] ([fecha], [cuit], [numeroSurtidor], [cantidad], [idUnidadMedida], [observacion], [montoFinal])" +
                        $" VALUES ('{v.ObtenerFecha()}', '{v.cuit}', '{v.numeroSurtidor.numeroSurtidor}', '{v.cantidad}', (SELECT idUnidadMedida FROM UnidadMedida WHERE nombre='{v.unidadMedida}'), '{v.observacion}', CAST(REPLACE( '{v.MontoFinal}', ',', '.') as float))";
                    v.numTicket = _BD.EjecutarTransaccion(sqltxt);
                    numticket = v.numTicket;
                    if (v.numTicket == 0)
                        throw new ApplicationException();
                    string sqltxt2 = $"SELECT stockActual FROM dbo.Producto " +
            $"WHERE nombre= (SELECT nombre FROM TipoCombustible WHERE idTipoCombustible=(SELECT idTipoCombustible FROM Surtidor WHERE numeroSurtidor = '{v.numeroSurtidor.numeroSurtidor}'))";
                    var stock2 =int.Parse(_BD.ConsultaDuranteTransaccion(sqltxt2).Rows[0]["stockActual"].ToString());
                   string sqltxt3 = $"UPDATE [dbo].[Producto] SET stockActual = '{stock2 - v.cantidad}' WHERE nombre= (SELECT nombre FROM TipoCombustible WHERE idTipoCombustible=(SELECT idTipoCombustible FROM Surtidor WHERE numeroSurtidor = '{v.numeroSurtidor.numeroSurtidor}'))";
                    _BD.EjecutarTransaccion(sqltxt3);

                    foreach (var d in v.detalleTicket)
                    {

                        sqltxt = $"INSERT [dbo].[DetalleTicket] " +
                            $"([nroTicket], [idProducto], [Cantidad], [precio]) " +
                            $"VALUES ({v.numTicket}, {d.producto.Id}, {d.cantidad}, CAST(REPLACE( '{d.precio}', ',', '.') as float))";
                        _BD.EjecutarTransaccion(sqltxt);

                        sqltxt = $"SELECT stockActual FROM Producto WHERE idProducto={d.producto.Id}";

                        var stock =
                            int.Parse(_BD.ConsultaDuranteTransaccion(sqltxt).Rows[0]["stockActual"].ToString());
                        if (stock - d.cantidad < 0)
                            throw new ApplicationException("falta stock");

                        sqltxt = $"UPDATE [dbo].[Producto] SET stockActual = '{stock - d.cantidad}' WHERE idProducto={d.producto.Id}";
                        _BD.EjecutarTransaccion(sqltxt);
                    }

                    tx.Commit();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new ApplicationException("No se pudo guardar la orden de compra." + ex.Message);
                }
                finally
                {
                    _BD.cerrar();
                    
                }

            }
            return numticket;
        }
    }
}
