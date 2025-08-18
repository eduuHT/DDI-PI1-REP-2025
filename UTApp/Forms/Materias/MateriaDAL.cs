using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace UTApp.Forms.Materias
{
    internal class MateriaDAL
    {
        private SqlConnection conn = new SqlConnection("workstation id=UTApp_Integradora1.mssql.somee.com;packet size=4096;user id=LuisRomán123_SQLLogin_1;pwd=b7jxk7yxyk;data source=UTApp_Integradora1.mssql.somee.com;persist security info=False;initial catalog=UTApp_Integradora1;TrustServerCertificate=True");

        public void InsertMateria(Materia materia)
        {
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("InsertMateria", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MateriaNombre", materia.Nombre);
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

        public List<Materia> GetMaterias(string busqueda = null)
        {
            List<Materia> materias = new List<Materia>();

            try
            {
                conn.Open();

                if (!string.IsNullOrEmpty(busqueda))
                {
                    SqlCommand command = new SqlCommand("GetMateriaById", conn);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MateriaID", busqueda);
                    command.ExecuteNonQuery();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        materias.Add(new Materia()
                        {
                            Id = int.Parse(reader["MateriaID"].ToString()),
                            Nombre = reader["MateriaNombre"].ToString()
                        });
                    }
                }
                else
                {
                    SqlCommand command = new SqlCommand("GetMaterias", conn);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        materias.Add(new Materia()
                        {
                            Id = int.Parse(reader["MateriaID"].ToString()),
                            Nombre = reader["MateriaNombre"].ToString()
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

            return materias;
        }

        public void UpdateMateria(Materia materia)
        {
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("UpdateMateria", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MateriaID", materia.Id);
                command.Parameters.AddWithValue("@MateriaNombre", materia.Nombre);

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

        public void DeleteMateria(int materiaId)
        {
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("DeleteMateria", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MateriaID", materiaId);

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
