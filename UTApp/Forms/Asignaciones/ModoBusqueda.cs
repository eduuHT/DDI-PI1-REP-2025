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
using UTApp.Forms.Grupos;
using UTApp.Forms.Materias;

namespace UTApp.Forms.Asignaciones
{
    public partial class ModoBusqueda : Form
    {
        DocenteControlador DocenteControlador = new DocenteControlador();
        AsignacionControlador controlador = new AsignacionControlador();
        MateriaDAL materiaDAL = new MateriaDAL();
        GrupoDAL grupoDAL = new GrupoDAL();
        int busqueda;
        int entidad;
        private FormAsignaciones _formAsignaciones;
        public ModoBusqueda(FormAsignaciones formAsignaciones)
        {
            InitializeComponent();
            _formAsignaciones = formAsignaciones;
        }

        private void ModoBusqueda_Load(object sender, EventArgs e)
        {
        }

        public void llenarGridBusqueda()
        {
            controlador.BuscarAsignacion(busqueda,entidad);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int entidad = Convert.ToInt32(CBEntidad.SelectedValue);
            var tabla = controlador.BuscarAsignacion(busqueda, entidad);
            _formAsignaciones.ActualizarGrid(tabla);
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CBFiltro.SelectedIndex)
            {
                case 0:
                    busqueda = 0;
                    CBEntidad.DataSource = materiaDAL.GetMaterias();
                    CBEntidad.DisplayMember = "Nombre";
                    CBEntidad.ValueMember = "Id";
                    break;
                case 1:
                    busqueda = 1;
                    CBEntidad.DataSource = DocenteControlador.ListarDocentesID();
                    CBEntidad.DisplayMember = "docenteNombreCompleto";
                    CBEntidad.ValueMember = "docenteID";
                    break;
                case 2:
                    busqueda = 2;
                    CBEntidad.DataSource = grupoDAL.GetGrupos();
                    CBEntidad.DisplayMember = "Nombre";
                    CBEntidad.ValueMember = "Id";
                    break;
            }
        }
    }
}
