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
using UTApp.ClasesControladoras;
using UTApp.Forms.Docentes;

namespace UTApp.Forms.Asignaciones
{
    public partial class EditarAsignacion : Form
    {
        AsignacionControlador controlador = new AsignacionControlador();
        List<Asignacion> asignaciones = new List<Asignacion>();
        DocenteControlador DocenteControlador = new DocenteControlador();
        List<ClaseDocenteID> docentes = new List<ClaseDocenteID>();
        PlataformaControlador plataformaControlador = new PlataformaControlador();
        List<Plataforma> plataformas = new List<Plataforma>();
        ClaseControladora claseControlador = new ClaseControladora();
        public EditarAsignacion()
        {
            InitializeComponent();
        }

        private void lblAsignaciones_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormAsignaciones asignaciones = new FormAsignaciones();
            asignaciones.Show();
            this.Hide();
        }

        private void EditarAsignacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void LlenarLista()
        {
            asignaciones = controlador.ListarAsignaciones();
            docentes = DocenteControlador.ListarDocentesID();
            plataformas = plataformaControlador.ListarPlataformas();
        }
        public void LimpiarCampos()
        {
            txtDescripcion.Text = string.Empty;
            txtTitulo.Text = string.Empty;
            CBGrupo.SelectedIndex = -1;
            CBDocente.SelectedIndex = -1;
            CBMateria.SelectedIndex = -1;
            CBPlataforma.SelectedIndex = -1;
            DTEntrega.Text = string.Empty;
        }

        private void EditarAsignacion_Load(object sender, EventArgs e) // tmb asigna las propiedades una vez hechos los demás cruds
        {
            LlenarLista();
            LimpiarCampos();
            CBGrupo.DataSource = null;
            CBPlataforma.DataSource = null;
            CBDocente.DataSource = null;
            CBPlataforma.DataSource = null;
            CBDocente.DataSource = docentes;
            CBPlataforma.DataSource = plataformas;
            CBDocente.DisplayMember = "docenteNombreCompleto";
            CBDocente.ValueMember = "docenteID";
            CBPlataforma.DisplayMember = "plataformaNombre";
            CBPlataforma.ValueMember = "plataformaID";
        }
        public void LlenarCampos() // Acuerdate de modificarla para llenarla con el click del grid
        {
            txtDescripcion.Text = string.Empty;
            txtTitulo.Text = string.Empty;
            CBGrupo.Text = string.Empty;
            CBDocente.Text = string.Empty;
            CBMateria.Text = string.Empty;
            CBPlataforma.Text = string.Empty;
            DTEntrega.Text = string.Empty;
        }
        public bool ValidarCampos()
        {
            if (!string.IsNullOrEmpty(txtTitulo.Text) &&
                CBGrupo.SelectedIndex > -1 &&
                CBDocente.SelectedIndex > -1 &&
                CBMateria.SelectedIndex > -1 &&
                CBPlataforma.SelectedIndex > -1 &&
                DTEntrega.Value > DateTime.Now &&
                DTEntrega.Checked
                )
            {
                return true;
            }
            else
            {
                MessageBox.Show("Favor de llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
