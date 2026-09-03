using System;
using System.Data.Odbc;

namespace CapaModelo
{
    // Capa Modelo: unica capa autorizada a hablar con ODBC / SQL.
    public class Conexion
    {
        // Nombre del DSN (Data Source Name) creado en el Administrador de
        // origenes de datos ODBC de Windows. Debe coincidir exactamente
        // con el nombre que se le dio al DSN.
        private const string NOMBRE_DSN = "asignacion_cursos";

        public OdbcConnection conexion()
        {
            OdbcConnection conn = new OdbcConnection("Dsn=" + NOMBRE_DSN);
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
            return conn;
        }

        public void desconexion(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No se desconectó");
            }
        }
    }
}
