using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using UTApp.Forms.Docentes;

namespace UTApp.Forms.Estudiantes
{
    internal class EstudianteControlador
    {
        public static string connectionString = "user id=sa;password=uts;server=.;database=UTApp_Integradora1";
        //public static string connectionString = "workstation id=UTApp_Integradora1.mssql.somee.com;packet size=4096;user id=LuisRomán123_SQLLogin_1;pwd=b7jxk7yxyk;data source=UTApp_Integradora1.mssql.somee.com;persist security info=False;initial catalog=UTApp_Integradora1;TrustServerCertificate=True";

        public EstudianteControlador()
        {

        }

        public bool AgregarEstudiante(Estudiante estudiante)
        {
            try
            {
                SqlConnection con = new SqlConnection(Connection.connectionString);
                
                if (con.State == 0)
                    con.Open();
                
                SqlCommand cmd = new SqlCommand("RegistrarEstudiante", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EstudianteMatricula", estudiante.EstudianteMatricula);
                cmd.Parameters.AddWithValue("@EstudianteNombreCompleto", estudiante.EstudianteNombreCompleto);
                cmd.Parameters.AddWithValue("@EstudianteEmail", estudiante.EstudianteEmail);
                cmd.Parameters.AddWithValue("@EstudiantePassword", estudiante.EstudiantePassword);
                cmd.Parameters.AddWithValue("@GrupoID", estudiante.GrupoID);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public Estudiante BuscarEstudiante(string matricula)
        {
            Estudiante estudiante = null;
            try
            {
                SqlConnection con = new SqlConnection(Connection.connectionString);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                DataTable datos = new DataTable();

                if (con.State == 0)
                    con.Open();

                SqlCommand cmd = new SqlCommand("BuscarEstudiante", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EstudianteMatricula", matricula);
                adaptador.SelectCommand = cmd;
                adaptador.Fill(datos);

                if(datos.Rows.Count > 0)
                {
                    estudiante = new Estudiante{
                        EstudianteMatricula = matricula,
                        EstudianteNombreCompleto = (datos.Rows[0].ItemArray[2]).ToString(),
                        EstudianteEmail = (datos.Rows [0].ItemArray[3]).ToString(),
                        EstudiantePassword = (datos.Rows[0].ItemArray [4]).ToString(),
                        GrupoID = Convert.ToInt32(datos.Rows[0].ItemArray[5])
                    };
                }

                return estudiante;
            }
            catch
            {
                return estudiante;
            }
        }

        public bool EditarEstudiante(Estudiante estudiante)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Connection.connectionString);
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("EditarEstudiante", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EstudianteMatricula", estudiante.EstudianteMatricula);
                cmd.Parameters.AddWithValue("@EstudianteNombreCompleto", estudiante.EstudianteNombreCompleto);
                cmd.Parameters.AddWithValue("@EstudianteEmail", estudiante.EstudianteEmail);
                cmd.Parameters.AddWithValue("@EstudiantePassword", estudiante.EstudiantePassword);
                cmd.Parameters.AddWithValue("@GrupoID", estudiante.GrupoID);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool EliminarEstudiante(int matricula)
        {
            try
            {
                SqlConnection con = new SqlConnection(Connection.connectionString);

                if (con.State == 0)
                    con.Open();

                SqlCommand cmd = new SqlCommand("EliminarEstudiante", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EstudianteMatricula", matricula);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public Estudiante BuscarCorreoEstudiante(string correo)
        {
            Estudiante prueba = null;
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("BuscarCorreoEstudiante", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                if (con.State == 0)
                    con.Open();

                cmd.Parameters.AddWithValue("@EstudianteEmail", correo);

                adaptador.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    prueba = new Estudiante(
                    // Matrícula
                    dt.Rows[0].ItemArray[0].ToString(),
                    // Nombre
                    dt.Rows[0].ItemArray[1].ToString(),
                    // Email
                    dt.Rows[0].ItemArray[2].ToString(),
                    // Password
                    dt.Rows[0].ItemArray[3].ToString(),
                    // GrupoID
                    Convert.ToInt32(dt.Rows[0].ItemArray[4])
                    );
                }

                return prueba;
            }
            catch
            {
                return prueba;
            }
        }
    }
}
