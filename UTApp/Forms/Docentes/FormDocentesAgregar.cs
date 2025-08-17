using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTApp.Forms.Docentes;
using UTApp.Forms.Estudiantes;

namespace UTApp.Forms.Docentes
{
    public partial class FormDocentesAgregar : Form
    {
        EstudianteControlador controladorEst = new EstudianteControlador();
        DocenteControlador controladorDoc = new DocenteControlador();
        public FormDocentesAgregar()
        {
            InitializeComponent();
        }

        private void FormDocentesAgregar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtDocenteEmpleado_Leave(object sender, EventArgs e)
        {
            Docente Docente = controladorDoc.BuscarDocente(txtDocenteEmpleado.Text);

            if (Docente != null)
            {
                txtDocenteNombre.Text = Docente.DocenteNombreCompleto;
                txtDocenteNombre.Enabled = false;

                txtDocenteTitulo.Text = Docente.DocenteTituloAcademico;
                txtDocenteTitulo.Enabled = false;

                txtDocenteCorreo.Text = Docente.DocenteEmail;
                txtDocenteCorreo.Enabled = false;

                txtDocentePass.PasswordChar = '•';
                txtDocentePass.Text = Docente.DocentePassword;
                txtDocentePass.Enabled = false;
            }
            else if (txtDocenteNombre.Enabled ==  false)
            {
                txtDocenteNombre.Text = "";
                txtDocenteNombre.Enabled = true;

                txtDocenteTitulo.Text = "";
                txtDocenteTitulo.Enabled = true;

                txtDocenteCorreo.Text = "";
                txtDocenteCorreo.Enabled = true;

                txtDocentePass.PasswordChar = '\0';
                txtDocentePass.Text = "";
                txtDocentePass.Enabled = true;
            }
        }
        
        private void FormDocentesAgregar_Click(object sender, EventArgs e)
        {
            Docente Docente = controladorDoc.BuscarDocente(txtDocenteEmpleado.Text);

            if (Docente == null && txtDocenteNombre.Enabled == false)
            {
                if (txtDocenteNombre.Text != "")
                {
                    txtDocenteNombre.Text = "";
                    txtDocenteNombre.Enabled = true;
                }

                if (txtDocenteTitulo.Text != "")
                {
                    txtDocenteTitulo.Text = "";
                    txtDocenteTitulo.Enabled = true;
                }

                if (txtDocenteCorreo.Text != "")
                {
                    txtDocenteCorreo.Text = "";
                    txtDocenteCorreo.Enabled = true;
                }

                if (txtDocentePass.Text != "")
                {
                    txtDocentePass.Text = "";
                    txtDocentePass.PasswordChar = '\0';
                    txtDocentePass.Enabled = true;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            
            try
            {
                txtDocenteEmpleado.Text = Convert.ToInt32(txtDocenteEmpleado.Text).ToString();
                txtDocenteEmpleado.Text = txtDocenteEmpleado.Text.PadLeft(4, '0');

                if (bandera == false)
                {
                    if (txtDocenteEmpleado.Text == "" || txtDocenteEmpleado.Text.Length != 4)
                    {
                        MessageBox.Show("La matrícula debe de contener 4 carácteres.");
                        txtDocenteEmpleado.Focus();
                        return;
                    }
                    else if (txtDocenteNombre.Text == "")
                    {
                        MessageBox.Show("Es necesario ingresar un nombre.");
                        txtDocenteNombre.Focus();
                        return;
                    }
                    else if (txtDocenteTitulo.Text.Trim() == "")
                    {
                        MessageBox.Show("No ha ingresado título académico.");
                        txtDocenteTitulo.Focus();
                        return;
                    }
                    else if (txtDocenteCorreo.Text.Trim() == "")
                    {
                        MessageBox.Show("Introduza un correo electrónico.");
                        txtDocenteCorreo.Focus();
                        return;
                    }
                    else if (txtDocentePass.Text == "" || (txtDocentePass.Text.Length < 8 || txtDocentePass.Text.Length > 25))
                    {
                        MessageBox.Show("Ingrese una contraseña de entre 8 y 25 carácteres.");
                        txtDocentePass.Focus();
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
                        string numero = txtDocenteEmpleado.Text;
                        string nombre = txtDocenteNombre.Text;
                        string titulo = txtDocenteTitulo.Text;
                        string correo = txtDocenteCorreo.Text.Trim();
                        string pass = txtDocentePass.Text;

                        Docente nuevoDocente = controladorDoc.BuscarCorreoDocente(correo);

                        Estudiante estudiante = controladorEst.BuscarCorreoEstudiante(correo);

                        if (nuevoDocente == null && estudiante == null)
                        {
                            nuevoDocente = new Docente(numero, nombre, titulo, correo, pass);

                            controladorDoc.AgregarDocente(nuevoDocente);

                            MessageBox.Show("El correo fue registrado con éxito.");
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
                MessageBox.Show("Al parecer estás ingresando letras, intenta solo con números.", "Ocurrió un problema");
            }
        }

        private void FormDocentesAgregar_Load(object sender, EventArgs e)
        {

        }

        private void txtDocenteEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
