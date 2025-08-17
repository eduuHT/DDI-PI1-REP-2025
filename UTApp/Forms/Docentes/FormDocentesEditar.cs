using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTApp.Forms.Estudiantes;

namespace UTApp.Forms.Docentes
{
    public partial class FormDocentesEditar : Form
    {
        EstudianteControlador controladorEst = new EstudianteControlador();
        DocenteControlador controladorDoc = new DocenteControlador();
        public FormDocentesEditar()
        {
            InitializeComponent();
        }

        private void FormDocentesEditar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDocenteEmpleado.Text != "" || txtDocentePass.Text.Length != 4)
            {
                if (txtDocenteEmpleado.Text.Length == 4)
                {
                    try
                    {
                        Docente docenteEditando = null;
                        docenteEditando = controladorDoc.BuscarDocente(txtDocenteEmpleado.Text);

                        if (docenteEditando != null)
                        {
                            txtDocenteNombre.Text = docenteEditando.DocenteNombreCompleto;
                            txtDocenteTitulo.Text = docenteEditando.DocenteTituloAcademico;
                            txtDocenteCorreo.Text = docenteEditando.DocenteEmail;
                            txtDocentePass.Text = docenteEditando.DocentePassword;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ocurrió un error.");
                    }
                }
                else
                    MessageBox.Show("Ingrese un número de empleado de 4 carácteres.");

            }
            else
            {
                MessageBox.Show("Ingrese un número de empleado de 4 carácteres.");
            }
        }

        private void txtDocenteEmpleado_Leave(object sender, EventArgs e)
        {
            if (txtDocenteEmpleado.Text == "" || txtDocenteEmpleado.Text != "" || txtDocenteEmpleado.Text.Length != 4)
            {
                txtDocenteNombre.Text = "";
                txtDocenteTitulo.Text = "";
                txtDocenteCorreo.Text = "";
                txtDocentePass.Text = "";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string empleado = txtDocenteEmpleado.Text.Trim();
                string nombre = txtDocenteNombre.Text;
                string titulo = txtDocenteTitulo.Text;
                string correo = txtDocenteCorreo.Text.Trim();
                string pass = txtDocentePass.Text;

                Estudiante estudiante = controladorEst.BuscarCorreoEstudiante(correo);
                Docente editDocente = controladorDoc.BuscarCorreoDocente(correo);

                if (estudiante == null || editDocente.DocenteNumeroEmpleado == empleado)
                {
                    editDocente = new Docente(empleado, nombre, titulo, correo, pass);
                    List<Docente> listaDocentes = controladorDoc.ListarDocentes();
                    bool bandera = false;
                    Docente pruebaDocente = new Docente();
                    int i = 0;

                    do
                    {
                        pruebaDocente = listaDocentes[i];

                        if (editDocente.DocenteNumeroEmpleado == pruebaDocente.DocenteNumeroEmpleado)
                        {
                            if (editDocente.DocenteNombreCompleto != pruebaDocente.DocenteNombreCompleto
                                ||
                                editDocente.DocenteEmail != pruebaDocente.DocenteEmail
                                ||
                                editDocente.DocenteTituloAcademico != pruebaDocente.DocenteTituloAcademico)
                            {
                                bandera = true;
                            }
                        }
                        i++;
                    } while (!bandera);

                    bool cambio = controladorDoc.EditarDocente(editDocente);

                    if (cambio && bandera)
                        MessageBox.Show("El docente fue actualizado con éxito.");
                    else
                        MessageBox.Show("No fue posible realizar los cambios.");
                }
                else
                    MessageBox.Show("No fue posible realizar los cambios."); 
            }
            catch
            {
                MessageBox.Show("Ocurrió un error, no se pudo editar.");
            }
        }
    }
}
