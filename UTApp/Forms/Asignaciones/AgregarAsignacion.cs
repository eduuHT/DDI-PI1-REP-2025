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
    public partial class AgregarAsignacion : Form
    {
        AsignacionControlador controlador = new AsignacionControlador();
        ClaseControladora claseControlador = new ClaseControladora();
        PlataformaControlador plataformaControlador = new PlataformaControlador();
        DocenteControlador DocenteControlador = new DocenteControlador();
        List<Asignacion> asignaciones = new List<Asignacion>();
        List<ClaseDocenteID> docentes = new List<ClaseDocenteID>();
        List<Plataforma> plataformas = new List<Plataforma>();
        public AgregarAsignacion()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormAsignaciones asignaciones = new FormAsignaciones();
            asignaciones.Show();
            this.Hide();
        }

        private void AgregarAsignacion_FormClosed(object sender, FormClosedEventArgs e)
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
        public bool ValidarCampos()
        {
                if (!string.IsNullOrEmpty(txtTitulo.Text) &&
                    CBGrupo.SelectedIndex > -1 &&
                    CBDocente.SelectedIndex > -1 &&
                    CBMateria.SelectedIndex > -1 &&
                    CBPlataforma.SelectedIndex > -1 &&
                    DTEntrega.Value > DateTime.Now  &&
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarAsignacion_Load(object sender, EventArgs e)
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
            CBPlataforma.DisplayMember ="plataformaNombre";
            CBPlataforma.ValueMember = "plataformaID";
            /*
            CBGrupo.DisplayMember =;
            CBGrupo.ValueMember =;
            CBGrupo.DataSource =;
            CBGrupo.DataSource =;
            CBMateria.DisplayMember= ;
            CBMateria.ValueMember =;
            CBPlataforma.DataSource =;;*/
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    string titulo = txtTitulo.Text;
                    string descripcion = txtDescripcion.Text;
                    int Docente = CBDocente.SelectedIndex;
                    int Materia = CBMateria.SelectedIndex;
                    int Grupo = CBPlataforma.SelectedIndex;
                    int plataforma = CBPlataforma.SelectedIndex;
                    DateTime entrega = DTEntrega.Value;
                    int clase = claseControlador.BuscarClase(Materia,Grupo,Docente);

                    if (controlador.InsertarAsignacion(titulo, descripcion, entrega, clase, plataforma))
                    {
                        MessageBox.Show("La asignación se ha insertado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error.....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
