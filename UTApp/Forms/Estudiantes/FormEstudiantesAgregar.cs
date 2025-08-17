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

namespace UTApp.Forms.Estudiantes
{
    public partial class FormEstudiantesAgregar : Form
    {
        EstudianteControlador controladorEst = new EstudianteControlador();
        DocenteControlador controladorDoc = new DocenteControlador();
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
                    else if (txtEstudianteGrupo.Text.Trim() == "")
                    {
                        MessageBox.Show("No ha ingresado un grupo.");
                        txtEstudianteGrupo.Focus();
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
                        int grupo = Convert.ToInt32(txtEstudianteGrupo.Text);

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

        private void txtEstudianteGrupo_Leave(object sender, EventArgs e)
        {
            try
            {
                txtEstudianteGrupo.Text = Convert.ToInt32(txtEstudianteGrupo.Text).ToString();
            }
            catch
            {
                txtEstudianteGrupo.Text = "\0";
            }
        }

        private void txtEstudianteMatricula_Leave(object sender, EventArgs e)
        {
            Estudiante estudiante = controladorEst.BuscarEstudiante(txtEstudianteMatricula.Text);

            if (estudiante != null)
            {
                txtEstudianteNombre.Text = estudiante.EstudianteNombreCompleto;
                txtEstudianteNombre.Enabled = false;

                txtEstudianteCorreo.Text = estudiante.EstudianteEmail;
                txtEstudianteCorreo.Enabled = false;

                txtEstudiantePass.PasswordChar = '•';
                txtEstudiantePass.Text = estudiante.EstudiantePassword;
                txtEstudiantePass.Enabled = false;

                txtEstudianteGrupo.Text = estudiante.GrupoID.ToString();
                txtEstudianteGrupo.Enabled = false;
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

                txtEstudianteGrupo.Text = "";
                txtEstudianteGrupo.Enabled = true;
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

                if (txtEstudianteGrupo.Text != "")
                {
                    txtEstudianteGrupo.Text = "";
                    txtEstudianteGrupo.Enabled = true;
                }
            }
        }

        private void FormEstudiantesAgregar_Load(object sender, EventArgs e)
        {

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
    }
}
