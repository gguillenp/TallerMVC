using System.Data.Odbc;

namespace CapaModelo
{
    // Capa Modelo: aqui se guardan las sentencias SQL contra la tabla
    // maestra "curso" de la base de datos asignacion_cursos.
    public class Sentencias
    {
        Conexion con = new Conexion();

        // Trae todos los registros de la tabla indicada (parametrizada
        // desde la capa vista, pasando por el controlador).
        public OdbcDataAdapter llenarTbl(string nombreTabla)
        {
            string sql = "SELECT * FROM " + nombreTabla + ";";
            OdbcDataAdapter dataAdapterSentencias = new OdbcDataAdapter(sql, con.conexion());
            return dataAdapterSentencias;
        }
    }
}
