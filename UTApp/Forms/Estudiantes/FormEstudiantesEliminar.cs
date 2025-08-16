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

namespace UTApp.Forms.Estudiantes
{
    public partial class FormEstudiantesEliminar : Form
    {
        public static string connectionString = "user id=sa;password=uts;server=.;database=UTApp_Integradora1";
        //public static string connectionString = "workstation id=UTApp_Integradora1.mssql.somee.com;packet size=4096;user id=LuisRomán123_SQLLogin_1;pwd=b7jxk7yxyk;data source=UTApp_Integradora1.mssql.somee.com;persist security info=False;initial catalog=UTApp_Integradora1;TrustServerCertificate=True";

        EstudianteControlador controladorEst = new EstudianteControlador();
        DocenteControlador controladorDoc = new DocenteControlador();
        public FormEstudiantesEliminar()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                bool elimino = false;
                txtEstudianteMatricula.Text = Convert.ToInt32(txtEstudianteMatricula.Text).ToString();

                if (MessageBox.Show($"¿Desea eliminar el estudiante {txtEstudianteMatricula.Text}?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    elimino = controladorEst.EliminarEstudiante(txtEstudianteMatricula.Text);

                    if (elimino == true)
                    {
                        MessageBox.Show("El estudiante ha sido eliminado.");

                        txtEstudianteMatricula.Text = "";
                        txtEstudianteNombre.Text = "";
                        txtEstudianteCorreo.Text = "";
                        txtEstudianteGrupo.Text = "";
                    }
                    else
                        MessageBox.Show("El cliente no se eliminó.");
                }
            }
            catch
            {
                MessageBox.Show("Al parecer estás ingresando letras, intenta solo con números.");
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                txtEstudianteMatricula.Text = txtEstudianteMatricula.Text.Trim();

                if (txtEstudianteMatricula.Text.Length == 10)
                {
                    Estudiante estudiante = null;
                    estudiante = controladorEst.BuscarEstudiante(txtEstudianteMatricula.Text);

                    if (estudiante != null)
                    {
                        txtEstudianteGrupo.Text = estudiante.GrupoID.ToString();
                        txtEstudianteNombre.Text = estudiante.EstudianteNombreCompleto;
                        txtEstudianteCorreo.Text = estudiante.EstudianteEmail;
                    }
                    else
                    {
                        MessageBox.Show($"No se ha encontrado ningún registro con la matrícula {txtEstudianteMatricula.Text}.");
                    }
                }
                else
                    MessageBox.Show("La matrícula debe ser de 10 números.");

            }
            catch
            {
                if (txtEstudianteMatricula.Text == "")
                    MessageBox.Show("Ingrese una matrícula.");
                else
                    MessageBox.Show("Al parecer estás ingresando letras, intenta con números.");
            }
        }
    }
}
