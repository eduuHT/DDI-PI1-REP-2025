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
        public static string connectionString = "user id=sa;password=uts;server=.;database=UTApp_Integradora1";
        //public static string connectionString = "workstation id=UTApp_Integradora1.mssql.somee.com;packet size=4096;user id=LuisRomán123_SQLLogin_1;pwd=b7jxk7yxyk;data source=UTApp_Integradora1.mssql.somee.com;persist security info=False;initial catalog=UTApp_Integradora1;TrustServerCertificate=True";

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

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                txtDocenteEmpleado.Text = Convert.ToInt32(txtDocenteEmpleado.Text).ToString();
                txtDocenteEmpleado.Text = txtDocenteEmpleado.Text.PadLeft(4, '0');

                if (txtDocenteEmpleado.Text.Length == 4)
                {
                    Docente docente = null;
                    docente = controladorDoc.BuscarDocente(txtDocenteEmpleado.Text);

                    if (docente != null)
                    {
                        txtDocenteNombre.Text = docente.DocenteNombreCompleto;
                        txtTitulo.Text = docente.DocenteTituloAcademico;
                        txtDocenteCorreo.Text = docente.DocenteEmail;
                        txtDocentePass.Text = docente.DocentePassword;
                    }
                    else
                    {
                        MessageBox.Show($"No se ha encontrado ningún registro con el número de empleado {txtDocenteEmpleado.Text}.");
                    }
                }
                else
                    MessageBox.Show("El número de empleado debe ser de 4 números.");
            }
            catch
            {
                MessageBox.Show("Al parecer estás ingresando letras, intenta solo con números.","Ocurrió un problema");
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
    }
}
