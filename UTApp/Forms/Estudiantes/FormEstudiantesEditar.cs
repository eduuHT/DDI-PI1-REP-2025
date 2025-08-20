using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTApp.Forms.Docentes;
using UTApp.Forms.Grupos;

namespace UTApp.Forms.Estudiantes
{
    public partial class FormEstudiantesEditar : Form
    {
        EstudianteControlador controladorEst = new EstudianteControlador();
        DocenteControlador controladorDoc = new DocenteControlador();
        GrupoDAL controladorGrupo = new GrupoDAL();

        public FormEstudiantesEditar()
        {
            InitializeComponent();
        }

        private void FormEstudiantesEditar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtEstudianteMatricula.Text.Length == 10)
            {
                List<Grupo> grupos = null;
                grupos = controladorGrupo.GetGrupos();
                cbGrupo.DataSource = grupos;
                cbGrupo.DisplayMember = "Nombre";
                cbGrupo.ValueMember = "Id";

                try
                {
                    Estudiante estudianteEditando = null;
                    estudianteEditando = controladorEst.BuscarEstudiante(txtEstudianteMatricula.Text);

                    if (estudianteEditando != null)
                    {
                        cbGrupo.SelectedIndex = (estudianteEditando.GrupoID) - 1;
                        txtEstudianteNombre.Text = estudianteEditando.EstudianteNombreCompleto;
                        txtEstudianteCorreo.Text = estudianteEditando.EstudianteEmail;
                        txtEstudiantePass.Text = estudianteEditando.EstudiantePassword;
                        btnGuardar.Enabled = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Ocurrió un error.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese una matrícula de 10 carácteres.");
                txtEstudianteMatricula.Focus();
            }
        }

        private void txtEstudianteMatricula_Leave(object sender, EventArgs e)
        {
            if (txtEstudianteMatricula.Text == "" || txtEstudianteMatricula.Text != "" || txtEstudianteMatricula.Text.Length != 10)
            {
                cbGrupo.DataSource = null;
                txtEstudianteNombre.Text = "";
                txtEstudianteCorreo.Text = "";
                txtEstudiantePass.Text = "";
                btnGuardar.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Estudiante editEstudiante = null;
            Estudiante pruebaEstudiante = null;
            try
            {
                string matricula = txtEstudianteMatricula.Text;
                string nombre = txtEstudianteNombre.Text;
                string correo = txtEstudianteCorreo.Text.Trim();
                string pass = txtEstudiantePass.Text;
                int grupo = Convert.ToInt32(cbGrupo.SelectedValue);

                Docente docente = controladorDoc.BuscarCorreoDocente(correo);
                editEstudiante = controladorEst.BuscarCorreoEstudiante(correo);

                if (docente == null || editEstudiante != null)
                {
                    editEstudiante = new Estudiante(matricula, nombre, correo, pass, grupo);
                    List<Estudiante> listaEstudiantes = controladorEst.ListarEstudiantes();
                    bool bandera = false;
                    pruebaEstudiante = new Estudiante();
                    int i = 0;


                    do
                    {
                        pruebaEstudiante = listaEstudiantes[i];

                        if (editEstudiante.EstudianteMatricula == pruebaEstudiante.EstudianteMatricula)
                        {
                            if (editEstudiante.EstudianteNombreCompleto != pruebaEstudiante.EstudianteNombreCompleto
                                ||
                                editEstudiante.EstudianteEmail != pruebaEstudiante.EstudianteEmail
                                ||
                                editEstudiante.GrupoID != pruebaEstudiante.GrupoID)
                            {
                                bandera = true;
                            }
                        }
                        i++;
                    } while (!bandera);

                    bool cambio = controladorEst.EditarEstudiante(editEstudiante);

                    if (cambio && bandera)
                        MessageBox.Show("Los cambios se han realizado con éxito.");
                }
                else
                    MessageBox.Show("El correo que ingresó ya está en uso.");
            }
            catch
            {
                if (editEstudiante.EstudianteNombreCompleto == pruebaEstudiante.EstudianteNombreCompleto
                    &&
                    editEstudiante.EstudianteEmail == pruebaEstudiante.EstudianteEmail
                    &&
                    editEstudiante.GrupoID == pruebaEstudiante.GrupoID)
                    MessageBox.Show("No ha habido actualización en los datos.");
                else
                    MessageBox.Show("Ocurrió un error, no se pudo editar.");
            }
        }
        

        private void FormEstudiantesEditar_Load(object sender, EventArgs e)
        {
            txtEstudianteMatricula.CharacterCasing = CharacterCasing.Upper;
            txtEstudianteMatricula.MaxLength = 10;
            txtEstudianteNombre.MaxLength = 200;
            txtEstudianteCorreo.MaxLength = 200;
            btnGuardar.Enabled = false;

            Limpiar();

            txtEstudianteMatricula.Focus();
        }

        private void txtEstudianteMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;


            if (char.IsControl(e.KeyChar))
                return;

            if ((e.KeyChar == 'L' || e.KeyChar == 'l') && txt.Text.Length == 0)
                return;


            if (char.IsDigit(e.KeyChar))
                return;

            e.Handled = true;
        }

        private void pbRegresar_Click(object sender, EventArgs e)
        {
            FormEstudiantes back = new FormEstudiantes();
            this.Hide();
            back.Show();
        }

        public void Limpiar()
        {
            txtEstudianteMatricula.Text = "";
            cbGrupo.SelectedIndex = -1;
            txtEstudianteNombre.Text = "";
            txtEstudianteCorreo.Text = "";
            txtEstudiantePass.Text = "";
        }

        private void txtEstudianteMatricula_TextChanged(object sender, EventArgs e)
        {
            txtEstudianteNombre.Text = "";
            txtEstudianteCorreo.Text = "";
            cbGrupo.DataSource = null;
            btnGuardar.Enabled = false;
        }

        private void txtEstudianteNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
