using System.Data;
using System.Data.Odbc;
using CapaModelo;

namespace CapaControlador
{
    // Capa Controlador: intermediario entre la vista y el modelo.
    // No contiene SQL ni ODBC directo, solo orquesta la llamada al modelo.
    public class Controlador
    {
        Sentencias sentencias = new Sentencias();

        public DataTable llenarDGV(string nombreTabla)
        {
            OdbcDataAdapter dataAdapterControlador = sentencias.llenarTbl(nombreTabla);
            DataTable dtControlador = new DataTable();
            dataAdapterControlador.Fill(dtControlador);
            return dtControlador;
        }
    }
}
