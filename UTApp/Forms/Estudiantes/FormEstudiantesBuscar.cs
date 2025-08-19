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
using UTApp.Forms.Grupos;

namespace UTApp.Forms.Estudiantes
{
    public partial class FormEstudiantesBuscar : Form
    {
        public static string connectionString = "user id=sa;password=uts;server=.;database=UTApp_Integradora1";
        //public static string connectionString = "workstation id=UTApp_Integradora1.mssql.somee.com;packet size=4096;user id=LuisRomán123_SQLLogin_1;pwd=b7jxk7yxyk;data source=UTApp_Integradora1.mssql.somee.com;persist security info=False;initial catalog=UTApp_Integradora1;TrustServerCertificate=True";

        EstudianteControlador controladorEst = new EstudianteControlador();
        DocenteControlador controladorDoc = new DocenteControlador();
        GrupoDAL controladorGrupo = new GrupoDAL();

        public FormEstudiantesBuscar()
        {
            InitializeComponent();
        }

        private void FormEstudiantesBuscar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEstudianteMatricula.Text.Length == 10)
                {
                    Estudiante estudiante = null;
                    estudiante = controladorEst.BuscarEstudiante(txtEstudianteMatricula.Text);

                    if (estudiante != null)
                    {
                        List<Grupo> grupos = controladorGrupo.GetGrupos();

                        txtEstudianteGrupo.Text = grupos[estudiante.GrupoID-1].Nombre;
                        txtEstudianteNombre.Text = estudiante.EstudianteNombreCompleto;
                        txtEstudianteCorreo.Text = estudiante.EstudianteEmail;
                        txtEstudiantePass.Text = estudiante.EstudiantePassword;
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
                MessageBox.Show("Ocurrió un problema.");
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

        private void FormEstudiantesBuscar_Load(object sender, EventArgs e)
        {
            txtEstudianteMatricula.CharacterCasing = CharacterCasing.Upper;
            txtEstudianteMatricula.MaxLength = 10;
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
    }
}
