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

namespace UTApp.Forms.Docentes
{
    public partial class FormDocentes : Form
    {
        public static string connectionString = "user id=sa;password=uts;server=.;database=UTApp_Integradora1";
        //public static string connectionString = "workstation id=UTApp_Integradora1.mssql.somee.com;packet size=4096;user id=LuisRomán123_SQLLogin_1;pwd=b7jxk7yxyk;data source=UTApp_Integradora1.mssql.somee.com;persist security info=False;initial catalog=UTApp_Integradora1;TrustServerCertificate=True";
        public FormDocentes()
        {
            InitializeComponent();
        }

        private void FormDocentes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormDocentes_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT DocenteNumeroEmpleado, DocenteNombreCompleto FROM Docente";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, connectionString);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gridDocentes.DataSource = dt;
        }

        private void pbAgregar_Click(object sender, EventArgs e)
        {
            FormDocentesAgregar nuevoDocente = new FormDocentesAgregar();
            this.Hide();
            nuevoDocente.Show();
        }
    }
}
