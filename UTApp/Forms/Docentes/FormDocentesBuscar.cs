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
using UTApp.Forms.Menu_Principal;

namespace UTApp.Forms.Docentes
{
    public partial class FormDocentesBuscar : Form
    {
        DocenteControlador controladorDoc = new DocenteControlador();
        public FormDocentesBuscar()
        {
            InitializeComponent();
        }

        private void FormDocentesBuscar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormDocentesBuscar_Load(object sender, EventArgs e)
        {
            txtDocenteEmpleado.MaxLength = 4;

            txtDocenteEmpleado.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDocenteEmpleado.Text.Length > 0)
                {
                    txtDocenteEmpleado.Text = txtDocenteEmpleado.Text.PadLeft(4, '0');

                    Docente docente = null;
                    docente = controladorDoc.BuscarDocente(txtDocenteEmpleado.Text);

                    if (docente != null)
                    {
                        txtDocenteNombre.Text = docente.DocenteNombreCompleto;
                        txtDocenteTitulo.Text = docente.DocenteTituloAcademico;
                        txtDocenteCorreo.Text = docente.DocenteEmail;
                        txtDocentePass.Text = docente.DocentePassword;
                    }
                    else
                    {
                        MessageBox.Show($"No se ha encontrado ningún registro con el número de empleado {txtDocenteEmpleado.Text}.");
                        txtDocenteEmpleado.Focus();
                    }
                }
                else
                    txtDocenteEmpleado.Focus();
            }
            catch
            {
                MessageBox.Show("Ocurrió un problema.");
            }
        }

        private void txtDocenteEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pbRegresar_Click(object sender, EventArgs e)
        {
            FormDocentes back = new FormDocentes();
            this.Hide();
            back.Show();
        }

        private void txtDocenteEmpleado_TextChanged(object sender, EventArgs e)
        {
            txtDocenteNombre.Text = "";
            txtDocenteTitulo.Text = "";
            txtDocenteCorreo.Text = "";
            txtDocentePass.Text = "";
        }
    }
}
