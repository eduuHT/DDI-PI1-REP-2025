using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTApp.Clases;

namespace UTApp.ClasesControladoras
{
    internal class ClaseControladora
    {
        public bool InsertarClase(int Docente, int Materia, int Grupo)
        {
            SqlConnection conn = new SqlConnection(strConexion.stringConexion);
            try
            {
                SqlCommand cmd = new SqlCommand("InsertarClase", conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@GrupoID",Grupo );
                cmd.Parameters.AddWithValue("@MateriaID", Materia);
                cmd.Parameters.AddWithValue("@DocenteID", Docente);

                cmd.ExecuteNonQuery();

                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return false;
            }
        }
        public int BuscarClase(int Materia, int Grupo, int Docente)
        {
            SqlConnection conn = new SqlConnection(strConexion.stringConexion);
            try
            {
                SqlCommand cmd = new SqlCommand("BuscarClase", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ClaseID = new SqlParameter("@ClaseID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                cmd.Parameters.Add(ClaseID);
                cmd.Parameters.AddWithValue("@DocenteID", Docente);
                cmd.Parameters.AddWithValue("@MateriaID", Materia);
                cmd.Parameters.AddWithValue("@GrupoID", Grupo);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                cmd.ExecuteNonQuery();

                if (ClaseID.Value == DBNull.Value)
                    return -1;

                return Convert.ToInt32(ClaseID.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return -1;
            }
        }
        public List<Clase> ListarClases()
        {
            SqlConnection conn = new SqlConnection(strConexion.stringConexion);
            List<Clase> Clases = new List<Clase>();
            try
            {
                SqlCommand cmd = new SqlCommand("ListarClases", conn);
                DataTable tabla = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                cmd.CommandType = CommandType.StoredProcedure;
                adaptador.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        Clase nueva = new Clase(
                        Convert.ToInt32(tabla.Rows[i].ItemArray[0]),
                        Convert.ToInt32(tabla.Rows[i].ItemArray[1]),
                        Convert.ToInt32(tabla.Rows[i].ItemArray[2]),
                        Convert.ToInt32(tabla.Rows[i].ItemArray[3])
                        );
                        Clases.Add(nueva);
                    }
                }
                return Clases;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return Clases;
            }
        }
    }
}
