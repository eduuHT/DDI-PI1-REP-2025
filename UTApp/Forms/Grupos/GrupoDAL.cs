using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTApp.Forms.Grupos
{
    internal class GrupoDAL
    {
        private SqlConnection conn = new SqlConnection("workstation id=UTApp_Integradora1.mssql.somee.com;packet size=4096;user id=LuisRomán123_SQLLogin_1;pwd=b7jxk7yxyk;data source=UTApp_Integradora1.mssql.somee.com;persist security info=False;initial catalog=UTApp_Integradora1;TrustServerCertificate=True");

        public void InsertGrupo(Grupo grupo)
        {
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("InsertGrupo", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@GrupoNombre", grupo.Nombre);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Grupo> GetGrupos(string busqueda = null)
        {
            List<Grupo> grupos = new List<Grupo>();

            try
            {
                conn.Open();

                if (!string.IsNullOrEmpty(busqueda))
                {
                    SqlCommand command = new SqlCommand("GetGrupoById", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    
                    command.Parameters.AddWithValue("@GrupoID", busqueda);
                    command.ExecuteNonQuery();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        grupos.Add(new Grupo
                        {
                            Id = int.Parse(reader["GrupoID"].ToString()),
                            Nombre = reader["GrupoNombre"].ToString()
                        });
                    }
                }
                else
                {
                    SqlCommand command = new SqlCommand("GetGrupos", conn);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        grupos.Add(new Grupo
                        {
                            Id = int.Parse(reader["GrupoID"].ToString()),
                            Nombre = reader["GrupoNombre"].ToString()
                        });
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

            return grupos;
        }

        public void UpdateGrupo(Grupo grupo)
        {
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("UpdateGrupo", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@GrupoID", grupo.Id);
                command.Parameters.AddWithValue("@GrupoNombre", grupo.Nombre);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteGrupo(int grupoId)
        {
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("DeleteGrupo", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@GrupoID", grupoId);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
