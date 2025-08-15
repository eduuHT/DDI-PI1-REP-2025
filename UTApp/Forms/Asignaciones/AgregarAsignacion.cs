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

namespace UTApp.Forms.Asignaciones
{
    public partial class AgregarAsignacion : Form
    {
        AsignacionControlador controlador = new AsignacionControlador();
        ClaseControladora claseControlador = new ClaseControladora();
        PlataformaControlador plataformaControlador = new PlataformaControlador();
        List<Asignacion> asignaciones = new List<Asignacion>();
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
        }

        public void LimpiarCampos()
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
            CBDocente.DisplayMember = ;
            CBDocente.ValueMember =;
            CBGrupo.DisplayMember =;
            CBGrupo.ValueMember =;
            CBMateria.DisplayMember= ;
            CBMateria.ValueMember =;
            CBPlataforma.DisplayMember =;
            CBPlataforma.ValueMember =;
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

                    }
                }
            }
            catch
            {

            }
        }
    }
}
