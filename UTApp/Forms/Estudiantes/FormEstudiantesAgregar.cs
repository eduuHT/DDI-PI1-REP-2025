using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTApp.Forms.Estudiantes;
using UTApp.Forms.Docentes;
using UTApp.Forms.Grupos;

namespace UTApp.Forms.Estudiantes
{
    public partial class FormEstudiantesAgregar : Form
    {
        EstudianteControlador controladorEst = new EstudianteControlador();
        DocenteControlador controladorDoc = new DocenteControlador();
        GrupoDAL controladorGrupo = new GrupoDAL();

        public FormEstudiantesAgregar()
        {
            InitializeComponent();
        }

        private void FormEstudiantesAgregar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool bandera = false;

                if (bandera == false)
                {

                    if (txtEstudianteMatricula.Text == "" || txtEstudianteMatricula.Text.Length != 10)
                    {
                        MessageBox.Show("La matrícula debe de contener 10 carácteres.");
                        txtEstudianteMatricula.Focus();
                        return;
                    }
                    else if (txtEstudianteNombre.Text == "")
                    {
                        MessageBox.Show("Es necesario ingresar un nombre con mínimo.");
                        txtEstudianteNombre.Focus();
                        return;
                    }
                    else if (txtEstudianteCorreo.Text.Trim() == "")
                    {
                        MessageBox.Show("Introduza un correo electrónico.");
                        txtEstudianteCorreo.Focus();
                        return;
                    }
                    else if (txtEstudiantePass.Text == "" || (txtEstudiantePass.Text.Length < 8 || txtEstudiantePass.Text.Length > 25))
                    {
                        MessageBox.Show("Ingrese una contraseña de entre 8 y 25 carácteres.");
                        txtEstudiantePass.Focus();
                        return;
                    }
                    else
                    {
                        bandera = true;
                    }
                }
                else
                {
                    bandera = true;
                }

                if (bandera == true)
                {
                    try
                    {
                        string matricula = txtEstudianteMatricula.Text.Trim().ToUpper();
                        string nombre = txtEstudianteNombre.Text;
                        string correo = txtEstudianteCorreo.Text.Trim();
                        string pass = txtEstudiantePass.Text;
                        int grupo = Convert.ToInt32(cbGrupo.SelectedValue);

                        Estudiante nuevoEstudiante = controladorEst.BuscarCorreoEstudiante(correo);
                        Docente docente = controladorDoc.BuscarCorreoDocente(correo);


                        if (nuevoEstudiante == null && docente == null)
                        {
                            nuevoEstudiante = new Estudiante(matricula, nombre, correo, pass, grupo);

                            controladorEst.AgregarEstudiante(nuevoEstudiante);

                            MessageBox.Show("El estudiante fue registrado con éxito.");
                        }
                        else
                            MessageBox.Show("El correo se registró previamente.");
                    }
                    catch
                    {
                        MessageBox.Show("Ocurrió un error, no se pudo registrar.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ocurrió un problema");
            }
        }

        private void txtEstudianteMatricula_Leave(object sender, EventArgs e)
        {
            Estudiante estudiante = controladorEst.BuscarEstudiante(txtEstudianteMatricula.Text);

            if (estudiante != null)
            {
                List<Grupo> grupos = controladorGrupo.GetGrupos();
                txtEstudianteNombre.Text = estudiante.EstudianteNombreCompleto;
                txtEstudianteNombre.Enabled = false;

                txtEstudianteCorreo.Text = estudiante.EstudianteEmail;
                txtEstudianteCorreo.Enabled = false;

                txtEstudiantePass.PasswordChar = '•';
                txtEstudiantePass.Text = estudiante.EstudiantePassword;
                txtEstudiantePass.Enabled = false;

                cbGrupo.SelectedIndex = (estudiante.GrupoID) - 1;
                cbGrupo.Enabled = false;
            }
            else if (txtEstudianteNombre.Enabled == false)
            {
                txtEstudianteNombre.Text = "";
                txtEstudianteNombre.Enabled = true;

                txtEstudianteCorreo.Text = "";
                txtEstudianteCorreo.Enabled = true;

                txtEstudiantePass.PasswordChar = '\0';
                txtEstudiantePass.Text = "";
                txtEstudiantePass.Enabled = true;
            }
        }

        private void FormEstudiantesAgregar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = controladorEst.BuscarEstudiante(txtEstudianteMatricula.Text);

            if (estudiante == null && txtEstudianteNombre.Enabled == false)
            {
                if (txtEstudianteNombre.Text != "")
                {
                    txtEstudianteNombre.Text = "";
                    txtEstudianteNombre.Enabled = true;
                }

                if (txtEstudianteCorreo.Text != "")
                {
                    txtEstudianteCorreo.Text = "";
                    txtEstudianteCorreo.Enabled = true;
                }

                if (txtEstudiantePass.Text != "")
                {
                    txtEstudiantePass.Text = "";
                    txtEstudiantePass.PasswordChar = '\0';
                    txtEstudiantePass.Enabled = true;
                }
            }
        }

        private void txtEstudianteMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pbRegresar_Click(object sender, EventArgs e)
        {
            FormEstudiantes back = new FormEstudiantes();
            this.Hide();
            back.Show();
        }

        private void FormEstudiantesAgregar_Load(object sender, EventArgs e)
        {
            txtEstudianteMatricula.CharacterCasing = CharacterCasing.Upper;
            txtEstudianteMatricula.MaxLength = 10;
            txtEstudianteNombre.MaxLength = 200;
            txtEstudianteCorreo.MaxLength = 200;

            Limpiar();
            List<Grupo> grupos = null;
            grupos = controladorGrupo.GetGrupos();
            cbGrupo.DataSource = grupos;
            cbGrupo.DisplayMember = "Nombre";
            cbGrupo.ValueMember = "Id";
        }

        private void txtEstudianteMatricula_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEstudianteMatricula.Text))
                return;

            string matricula = txtEstudianteMatricula.Text;

            if (matricula.Length >= 1)
            {
                if (matricula[0] != 'L' && 
                   matricula[0] != '0' && matricula[0] != '1' && matricula[0] != '2' && matricula[0] != '3' && matricula[0] != '4' &&
                   matricula[0] != '5' && matricula[0] != '6' && matricula[0] != '7' && matricula[0] != '8' && matricula[0] != '9')
                {
                    MessageBox.Show("Solo se permite la letra 'L' o números como primer carácter.");
                    txtEstudianteMatricula.Text = "";
                }
            }
        }
        public void Limpiar()
        {
            txtEstudianteMatricula.Text = "";
            cbGrupo.SelectedIndex = -1;
            txtEstudianteNombre.Text = "";
            txtEstudianteCorreo.Text = "";
            txtEstudiantePass.Text = "";
        }
    }
}
