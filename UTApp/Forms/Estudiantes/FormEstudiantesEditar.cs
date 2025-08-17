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
                string matricula = txtEstudianteMatricula.Text;
                string nombre = txtEstudianteNombre.Text;
                string correo = txtEstudianteCorreo.Text.Trim();
                string pass = txtEstudiantePass.Text;
                int grupo = Convert.ToInt32(txtEstudianteGrupo.Text);

                Docente docente = controladorDoc.BuscarCorreoDocente(correo);
                Estudiante editEstudiante = controladorEst.BuscarCorreoEstudiante(correo);


                if (docente == null || editEstudiante != null)
                {
                    editEstudiante = new Estudiante(matricula, nombre, correo, pass, grupo);
                    List<Estudiante> listaEstudiantes = controladorEst.ListarEstudiantes();
                    bool bandera = false;
                    Estudiante pruebaEstudiante = new Estudiante();
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
                        MessageBox.Show("El estudiante fue actualizado con éxito.");
                    else
                        MessageBox.Show("No fue posible realizar los cambios.");
                }
                else
                    MessageBox.Show("El correo que ingresó ya está en uso.");
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
