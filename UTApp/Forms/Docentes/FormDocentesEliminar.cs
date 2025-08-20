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
    public partial class FormDocentesEliminar : Form
    {
        public static string connectionString = "user id=sa;password=uts;server=.;database=UTApp_Integradora1";
        //public static string connectionString = "workstation id=UTApp_Integradora1.mssql.somee.com;packet size=4096;user id=LuisRomán123_SQLLogin_1;pwd=b7jxk7yxyk;data source=UTApp_Integradora1.mssql.somee.com;persist security info=False;initial catalog=UTApp_Integradora1;TrustServerCertificate=True";

        DocenteControlador controladorDoc = new DocenteControlador();
        public FormDocentesEliminar()
        {
            InitializeComponent();
        }

        private void FormDocentesEliminar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDocenteEmpleado.Text.Length > 0)
            {
                
                Docente docente = null;
                docente = controladorDoc.BuscarDocente(txtDocenteEmpleado.Text.PadLeft(4, '0'));

                if (docente != null)
                {
                    txtDocenteEmpleado.Text = txtDocenteEmpleado.Text.PadLeft(4, '0');
                    txtDocenteNombre.Text = docente.DocenteNombreCompleto;
                    txtDocenteTitulo.Text = docente.DocenteTituloAcademico;
                    txtDocenteCorreo.Text = docente.DocenteEmail;
                    btnEliminar.Enabled = true;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool elimino = false;

            if (MessageBox.Show($"¿Desea eliminar el docente {txtDocenteEmpleado.Text.PadLeft(4, '0')}?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                elimino = controladorDoc.EliminarDocente(txtDocenteEmpleado.Text);

                if (elimino == true)
                {
                    MessageBox.Show("El docente ha sido eliminado.");

                    txtDocenteEmpleado.Text = "";
                    txtDocenteNombre.Text = "";
                    txtDocenteTitulo.Text = "";
                    txtDocenteCorreo.Text = "";
                    btnEliminar.Enabled = true;
                }
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

        private void FormDocentesEliminar_Load(object sender, EventArgs e)
        {
            txtDocenteEmpleado.MaxLength = 4;
            btnEliminar.Enabled = false;
            txtDocenteEmpleado.Focus();
        }

        private void txtDocenteEmpleado_Leave(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
        }

        private void txtDocenteEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (txtDocenteTitulo.Text != "")
            {
                txtDocenteNombre.Text = "";
                txtDocenteTitulo.Text = "";
                txtDocenteCorreo.Text = "";
                btnEliminar.Enabled = false;
            }
        }
    }
}
