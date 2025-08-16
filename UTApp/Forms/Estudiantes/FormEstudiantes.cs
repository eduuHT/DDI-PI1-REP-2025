using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTApp.Forms.Estudiantes
{
    public partial class FormEstudiantes : Form
    {
        public static string connectionString = "user id=sa;password=uts;server=.;database=UTApp_Integradora1";
        //public static string connectionString = "workstation id=UTApp_Integradora1.mssql.somee.com;packet size=4096;user id=LuisRomán123_SQLLogin_1;pwd=b7jxk7yxyk;data source=UTApp_Integradora1.mssql.somee.com;persist security info=False;initial catalog=UTApp_Integradora1;TrustServerCertificate=True";

        public FormEstudiantes()
        {
            InitializeComponent();
        }

        private void FormEstudiantes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormEstudiantes_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT EstudianteMatricula, EstudianteNombreCompleto FROM Estudiante";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, connectionString);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gridEstudiantes.DataSource = dt;
        }

        private void pbAgregar_Click(object sender, EventArgs e)
        {
            FormEstudiantesAgregar nuevoAlumno = new FormEstudiantesAgregar();
            this.Hide();
            nuevoAlumno.Show();
        }

        private string gridEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string matricula = "";

            if (gridEstudiantes.Rows.Count > 0)
            {
                matricula = gridEstudiantes[0, e.RowIndex].Value.ToString();
            }

            return matricula;
        }

        private void gridEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            FormEstudiantesEditar editar = new FormEstudiantesEditar();
            this.Hide();
            editar.Show();
        }
    }
}
