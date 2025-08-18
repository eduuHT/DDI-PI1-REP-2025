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
using UTApp.Forms.Grupos;
using UTApp.Forms.Materias;

namespace UTApp.Forms.Asignaciones
{
    public partial class EditarAsignacion : Form
    {
        AsignacionControlador controlador = new AsignacionControlador();
        ClaseControladora claseControlador = new ClaseControladora();
        PlataformaControlador plataformaControlador = new PlataformaControlador();
        DocenteControlador DocenteControlador = new DocenteControlador();
        GrupoDAL grupoControlador = new GrupoDAL();
        MateriaDAL materiaControlador = new MateriaDAL();
        List<Asignacion> asignaciones = new List<Asignacion>();
        List<ClaseDocenteID> docentes = new List<ClaseDocenteID>();
        List<Plataforma> plataformas = new List<Plataforma>();
        List<Grupo> grupos = new List<Grupo>();
        List<Materia> materias = new List<Materia>();
        Asignacion Actual = null;
        public EditarAsignacion(Asignacion actual)
        {
            InitializeComponent();
            Actual = actual;
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
            grupos = grupoControlador.GetGrupos();
            materias = materiaControlador.GetMaterias();
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
            LlenarCampos();

            CBDocente.DataSource = docentes;
            CBDocente.DisplayMember = "docenteNombreCompleto";
            CBDocente.ValueMember = "docenteID";

            CBPlataforma.DataSource = plataformas;
            CBPlataforma.DisplayMember = "plataformaNombre";
            CBPlataforma.ValueMember = "plataformaID";

            CBMateria.DataSource = materias;
            CBMateria.DisplayMember = "Nombre";
            CBMateria.ValueMember = "Id";

            CBGrupo.DataSource = grupos;
            CBGrupo.DisplayMember = "Nombre";
            CBGrupo.ValueMember = "Id";
        }
        public void LlenarCampos() // Acuerdate de modificarla para llenarla con el click del grid
        {
            txtDescripcion.Text = Actual.AsignacionDescripcion;
            txtTitulo.Text = Actual.AsignacionTitulo;
            CBGrupo.Text = string.Empty;
            CBDocente.Text = string.Empty;
            CBMateria.Text = string.Empty;
            CBPlataforma.Text = string.Empty;
            DTEntrega.Value = Actual.AsignacionFechaLimite;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    Asignacion nueva = null;
                    string titulo = txtTitulo.Text;
                    string descripcion = txtDescripcion.Text;
                    int Docente = Convert.ToInt32(CBDocente.SelectedValue);
                    int Materia = Convert.ToInt32(CBMateria.SelectedValue);
                    int Grupo = Convert.ToInt32(CBGrupo.SelectedValue);
                    int plataforma = Convert.ToInt32(CBPlataforma.SelectedValue);
                    DateTime entrega = DTEntrega.Value;
                    int clase = claseControlador.BuscarClase(Materia, Grupo, Docente);
                    if (clase == -1)
                    {
                        claseControlador.InsertarClase(Docente, Materia, Grupo);
                        clase = claseControlador.BuscarClase(Materia, Grupo, Docente);

                        nueva = new Asignacion(Actual.AsignacionID, titulo, descripcion, entrega, clase, plataforma);

                        if (controlador.EditarAsignacion(nueva))
                        {
                            MessageBox.Show("La asignación se ha editado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        nueva = new Asignacion(Actual.AsignacionID, titulo, descripcion, entrega, clase, plataforma);
                        if (controlador.EditarAsignacion(nueva))
                        {
                            MessageBox.Show("La asignación se ha editado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    pictureBox1_Click(sender,e);
                }
                else
                {
                    MessageBox.Show("No se ha podido editar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
