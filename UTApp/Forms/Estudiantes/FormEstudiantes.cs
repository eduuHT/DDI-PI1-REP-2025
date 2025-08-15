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
        public static string connectionString = "workstation id=UTApp_Integradora1.mssql.somee.com;packet size=4096;user id=LuisRomán123_SQLLogin_1;pwd=b7jxk7yxyk;data source=UTApp_Integradora1.mssql.somee.com;persist security info=False;initial catalog=UTApp_Integradora1;TrustServerCertificate=True";

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
    }
}
