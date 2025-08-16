using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTApp.Forms.Docentes;
using UTApp.Forms.Estudiantes;
using System.Windows.Forms;

namespace UTApp.Forms.Docentes
{
    internal class DocenteControlador
    {
        public static string connectionString = "user id=sa;password=uts;server=.;database=UTApp_Integradora1";
        //public static string connectionString = "workstation id=UTApp_Integradora1.mssql.somee.com;packet size=4096;user id=LuisRomán123_SQLLogin_1;pwd=b7jxk7yxyk;data source=UTApp_Integradora1.mssql.somee.com;persist security info=False;initial catalog=UTApp_Integradora1;TrustServerCertificate=True";

        public DocenteControlador()
        {

        }

        public bool AgregarDocente(Docente docente)
        {
            try
            {
                SqlConnection con = new SqlConnection(Connection.connectionString);

                if (con.State == 0)
                    con.Open();

                SqlCommand cmd = new SqlCommand("RegistrarDocente", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DocenteNumeroEmpleado", docente.DocenteNumeroEmpleado);
                cmd.Parameters.AddWithValue("@DocenteNombreCompleto", docente.DocenteNombreCompleto);
                cmd.Parameters.AddWithValue("@DocenteTituloAcademico", docente.DocenteTituloAcademico);
                cmd.Parameters.AddWithValue("@DocenteEmail", docente.DocenteEmail);
                cmd.Parameters.AddWithValue("@DocentePassword", docente.DocentePassword);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditarDocente(Docente Docente)
        {
            try
            {
                SqlConnection con = new SqlConnection(Connection.connectionString);

                if (con.State == 0)
                    con.Open();

                SqlCommand cmd = new SqlCommand("EditarDocente", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DocenteNumeroEmpleado", Docente.DocenteNumeroEmpleado);
                cmd.Parameters.AddWithValue("@DocenteNombreCompleto", Docente.DocenteNombreCompleto);
                cmd.Parameters.AddWithValue("@DocenteTituloAcademico", Docente.DocenteTituloAcademico);
                cmd.Parameters.AddWithValue("@DocenteEmail", Docente.DocenteEmail);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarDocente(int NumeroEmpleado)
        {
            try
            {
                SqlConnection con = new SqlConnection(Connection.connectionString);

                if (con.State == 0)
                    con.Open();

                SqlCommand cmd = new SqlCommand("EliminarDocente", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DocenteNumeroEmpleado", NumeroEmpleado);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public Docente BuscarDocente(string NumeroEmpleado)
        {
            Docente Docente = null;

            try
            {
                SqlConnection con = new SqlConnection(Connection.connectionString);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                DataTable datos = new DataTable();

                if (con.State == 0)
                    con.Open();

                SqlCommand cmd = new SqlCommand("BuscarDocente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DocenteNumeroEmpleado", NumeroEmpleado);
                adaptador.SelectCommand = cmd;
                adaptador.Fill(datos);

                if (datos.Rows.Count > 0)
                {
                    Docente = new Docente
                    {
                        DocenteNumeroEmpleado = NumeroEmpleado,
                        DocenteNombreCompleto = (datos.Rows[0].ItemArray[2]).ToString(),
                        DocenteTituloAcademico = (datos.Rows[0].ItemArray[3]).ToString(),
                        DocenteEmail = (datos.Rows[0].ItemArray[4]).ToString(),
                        DocentePassword = (datos.Rows[0].ItemArray[5]).ToString(),
                    };
                }

                return Docente;
            }
            catch
            {
                return Docente;
            }
        }

        public Docente BuscarCorreoDocente(string correo)
        {
            Docente prueba = null;
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("BuscarCorreoDocente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                if (con.State == 0)
                    con.Open();

                cmd.Parameters.AddWithValue("@DocenteEmail", correo);

                adaptador.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    prueba = new Docente(
                    // Empleado
                    dt.Rows[0].ItemArray[1].ToString(),
                    //Nombre
                    dt.Rows[0].ItemArray[2].ToString(),
                    //Título Académico
                    dt.Rows[0].ItemArray[3].ToString(),
                    //Email
                    correo,
                    //Password
                    dt.Rows[0].ItemArray[5].ToString()
                    );
                }

                return prueba;
            }
            catch
            {
                return prueba;
            }
        }

        public List<Docente> ListarDocentes()
        {
            SqlConnection con = new SqlConnection(Connection.connectionString);

            List<Docente> docentes = new List<Docente>();

            try
            {
                SqlCommand cmd = new SqlCommand("ListarDocentes", con);
                DataTable tabla = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);

                if (con.State == 0)
                    con.Open();

                cmd.CommandType = CommandType.StoredProcedure;
                adaptador.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        Docente docente = new Docente(
                            // Numero Empleado
                            tabla.Rows[i].ItemArray[1].ToString(),
                            // Nombre
                            tabla.Rows[i].ItemArray[2].ToString(),
                            // Titulo Académico
                            tabla.Rows[i].ItemArray[3].ToString(),
                            // Correo
                            tabla.Rows[i].ItemArray[4].ToString(),
                            // Password
                            tabla.Rows[i].ItemArray[5].ToString()
                        );

                        docentes.Add(docente);
                    }
                }

                return docentes;
            }
            catch
            {
                return docentes;
            }
        }
    }
}
