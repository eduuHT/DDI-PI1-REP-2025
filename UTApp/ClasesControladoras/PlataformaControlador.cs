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
    }
}
