using System;
using System.Data;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class FormPrincipal : Form
    {
        // Tabla maestra que se va a consultar (base de datos asignacion_cursos).
        string nombreTabla = "curso";

        Controlador controlador = new Controlador();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        public void actualizarDataGridView()
        {
            DataTable dtVista = controlador.llenarDGV(nombreTabla);
            dgbConsultaTabla.DataSource = dtVista;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            actualizarDataGridView();
        }
    }
}
