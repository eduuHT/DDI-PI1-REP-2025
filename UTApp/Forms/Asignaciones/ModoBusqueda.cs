using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTApp.Clases;
using UTApp.Forms.Docentes;

namespace UTApp.Forms.Asignaciones
{
    public partial class ModoBusqueda : Form
    {
        DocenteControlador DocenteControlador = new DocenteControlador();
        AsignacionControlador controlador = new AsignacionControlador();
        int busqueda;
        int entidad;
        public ModoBusqueda()
        {
            InitializeComponent();
        }

        private void ModoBusqueda_Load(object sender, EventArgs e)
        {
            CBFiltro.DataSource = DocenteControlador.ListarDocentes();
        }

        public void llenarGridBusqueda()
        {
            try
            {
                controlador.BuscarAsignacion(busqueda, entidad);
            }
            catch
            {

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CBFiltro.SelectedIndex)
            {
                case 0:
                    busqueda = 0;
                    break;
                case 1:
                    busqueda = 1;
                    CBEntidad.DataSource = DocenteControlador.ListarDocentes();
                    CBEntidad.DisplayMember = "docenteNombreCompleto";
                    CBEntidad.ValueMember = "docenteNumeroEmpleado";
                    break;
                case 2:
                    busqueda = 2;
                    break;

            }
        }
    }
}
