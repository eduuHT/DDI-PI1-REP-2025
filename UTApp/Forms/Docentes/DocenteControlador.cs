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
        public DocenteControlador()
        {

        }

        public bool AgregarDocente(Docente Docente)
        {
            try
            {
                SqlConnection con = new SqlConnection(Connection.connectionString);

                if (con.State == 0)
                    con.Open();

                SqlCommand cmd = new SqlCommand("RegistrarDocente", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DocenteNumeroEmpleado", Docente.DocenteNumeroEmpleado);
                cmd.Parameters.AddWithValue("@DocenteNombreCompleto", Docente.DocenteNombreCompleto);
                cmd.Parameters.AddWithValue("@DocenteTituloAcademico", Docente.DocenteTituloAcademico);
                cmd.Parameters.AddWithValue("@DocenteEmail", Docente.DocenteEmail);
                cmd.Parameters.AddWithValue("@DocentePassword", Docente.DocentePassword);

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
                cmd.Parameters.AddWithValue("@DocentePassword", Docente.DocentePassword);

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
        
        public bool BuscarCorreoEstudiante(string correo)
        {
            try
            {
                int prueba = 0;

                SqlConnection con = new SqlConnection(Connection.connectionString);

                if (con.State == 0)
                    con.Open();

                SqlCommand cmd = new SqlCommand("BuscarCorreoEstudiante", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EstudianteEmail", correo);

                prueba = cmd.ExecuteNonQuery();
                if (prueba != 0)
                    return false;
                else
                    return true;
                
            }
            catch
            {
                return false;
            }
        }
    }
}
