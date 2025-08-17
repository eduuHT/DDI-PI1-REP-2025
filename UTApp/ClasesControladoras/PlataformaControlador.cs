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
    internal class PlataformaControlador
    {
        public bool InsertarPlataforma(string nombre, string url)
        {
            SqlConnection conn = new SqlConnection(strConexion.stringConexion);
            try
            {
                SqlCommand cmd = new SqlCommand("InsertarPlataforma", conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PlataformaNombre", nombre);
                cmd.Parameters.AddWithValue("@PlataformaURL", url);

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
        public List<Plataforma> ListarPlataformas()
        {
            SqlConnection conn = new SqlConnection(strConexion.stringConexion);
            List<Plataforma> plataformas = new List<Plataforma>();
            try
            {
                SqlCommand cmd = new SqlCommand("ListarPlataformas", conn);
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
                        Plataforma nueva = new Plataforma(
                        Convert.ToInt32(tabla.Rows[i].ItemArray[0]),
                        tabla.Rows[i].ItemArray[1].ToString(),
                        tabla.Rows[i].ItemArray[2].ToString()
                        );
                        plataformas.Add(nueva);
                    }
                }

                return plataformas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return plataformas;
            }
        } 
    }
}
