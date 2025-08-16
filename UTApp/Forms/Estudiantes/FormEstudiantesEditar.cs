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

namespace UTApp.Forms.Estudiantes
{
    public partial class FormEstudiantesEditar : Form
    {
        EstudianteControlador controladorEst = new EstudianteControlador();
        DocenteControlador controladorDoc = new DocenteControlador();
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
            if (txtEstudianteMatricula.Text != "" || txtEstudianteMatricula.Text.Length != 10)
            {
                if (txtEstudianteMatricula.Text.Length == 10)
                {
                    try
                    {
                        Estudiante estudianteEditando = null;
                        estudianteEditando = controladorEst.BuscarEstudiante(txtEstudianteMatricula.Text);

                        if (estudianteEditando != null)
                        {
                            txtEstudianteGrupo.Text = estudianteEditando.GrupoID.ToString();
                            txtEstudianteNombre.Text = estudianteEditando.EstudianteNombreCompleto;
                            txtEstudianteCorreo.Text = estudianteEditando.EstudianteEmail;
                            txtEstudiantePass.Text = estudianteEditando.EstudiantePassword;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ocurrió un error.");
                    }
                }
                else
                    MessageBox.Show("Ingrese una matrícula de 10 carácteres.");
                
            }
            else
            {
                MessageBox.Show("Ingrese una matrícula de 10 carácteres.");
            }
            
        }

        private void txtEstudianteMatricula_Leave(object sender, EventArgs e)
        {
            if (txtEstudianteMatricula.Text == "" || txtEstudianteMatricula.Text != "" || txtEstudianteMatricula.Text.Length != 10)
            {
                txtEstudianteGrupo.Text = "";
                txtEstudianteNombre.Text = "";
                txtEstudianteCorreo.Text = "";
                txtEstudiantePass.Text = "";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string empleado = txtEstudianteMatricula.Text.Trim();
                string nombre = txtEstudianteNombre.Text;
                string correo = txtEstudianteCorreo.Text.Trim();
                string pass = txtEstudiantePass.Text;
                int grupo = Convert.ToInt32(txtEstudianteGrupo.Text);

                Docente docente = controladorDoc.BuscarCorreoDocente(correo);
                Estudiante nuevoEstudiante = controladorEst.BuscarCorreoEstudiante(correo);


                if (nuevoEstudiante == null && docente == null)
                {
                    nuevoEstudiante = new Estudiante(empleado, nombre, correo, pass, grupo);

                    bool prueba = controladorEst.EditarEstudiante(nuevoEstudiante);

                    if (prueba)
                        MessageBox.Show("El estudiante fue actualizado con éxito.");
                    else
                        MessageBox.Show("Ocurrió un error");
                }
                else
                    MessageBox.Show("El correo ya está ocupado.");
            }
            catch
            {
                MessageBox.Show("Ocurrió un error, no se pudo editar.");
            }
        }
        

        private void FormEstudiantesEditar_Load(object sender, EventArgs e)
        {

        }
    }
}
