using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTApp.Clases
{
    internal class AsignacionControlador
    {
        public bool InsertarAsignacion(string Titulo, string Descripcion, DateTime FechaLimite, int ClaseID, int PlataformaID)
        {
            SqlConnection conn = new SqlConnection(strConexion.stringConexion);
            try
            {
                SqlCommand cmd = new SqlCommand("InsertarAsignacion",conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AsignacionTitulo",Titulo);
                cmd.Parameters.AddWithValue("@AsignacionDescripcion", Descripcion);
                cmd.Parameters.AddWithValue("@AsignacionFechaLimite",FechaLimite);
                cmd.Parameters.AddWithValue("@ClaseID",ClaseID);
                cmd.Parameters.AddWithValue("@PlataformaID",PlataformaID);

                cmd.ExecuteNonQuery();

                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                conn.Close();
                return false;
            }
        }

        public bool EliminarAsignacion(int ID)
        {
            SqlConnection conn = new SqlConnection(strConexion.stringConexion);
            try
            {
                SqlCommand cmd = new SqlCommand("EliminarAsignacion", conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AsignacionID", ID);

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
        public bool EditarAsignacion(Asignacion AsignacionEditar)
        {
            SqlConnection conn = new SqlConnection(strConexion.stringConexion);
            try
            {
                SqlCommand cmd = new SqlCommand("EditarAsignacion", conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AsignacionID",AsignacionEditar.AsignacionID);
                cmd.Parameters.AddWithValue("@AsignacionTitulo", AsignacionEditar.AsignacionTitulo);
                cmd.Parameters.AddWithValue("@AsignacionDescripcion", AsignacionEditar.AsignacionDescripcion);
                cmd.Parameters.AddWithValue("@AsignacionFechaLimite", AsignacionEditar.AsignacionFechaLimite);
                cmd.Parameters.AddWithValue("@ClaseID", AsignacionEditar.ClaseID);
                cmd.Parameters.AddWithValue("@PlataformaID", AsignacionEditar.PlataformaID);
                cmd.Parameters.AddWithValue("@AsignacionEntrega", AsignacionEditar.AsignacionEntrega);

                cmd.ExecuteNonQuery();
                
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return false;
            }
        }

        public void BuscarAsignacion(int Busqueda, int ID)
        {
            SqlConnection conn = new SqlConnection(strConexion.stringConexion);
            Asignacion asignacion = null;
            try
            {
                SqlCommand cmd = new SqlCommand("BuscarAsignacion", conn);
                DataTable tabla = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ModoBusqueda", Busqueda);
                cmd.Parameters.AddWithValue("@ID", ID);

                adaptador.Fill(tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        public List<Asignacion> ListarAsignaciones()
        {
            SqlConnection conn = new SqlConnection(strConexion.stringConexion);
            List<Asignacion> asignaciones = new List<Asignacion>();
            try
            {
                SqlCommand cmd = new SqlCommand("ListarAsignaciones", conn);
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
                    for(int i = 0; i < tabla.Rows.Count; i++)
                    {
                        Asignacion nueva = new Asignacion(
                        Convert.ToInt32(tabla.Rows[i].ItemArray[0]),
                        tabla.Rows[i].ItemArray[1].ToString(),
                        tabla.Rows[i].ItemArray[2].ToString(),
                        Convert.ToDateTime(tabla.Rows[i].ItemArray[3]),
                        Convert.ToInt32(tabla.Rows[i].ItemArray[4]),
                        Convert.ToInt32(tabla.Rows[i].ItemArray[5])
                        );
                        asignaciones.Add(nueva);
                    }
                }

                return asignaciones;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return asignaciones;
            }
        }
    }
}
