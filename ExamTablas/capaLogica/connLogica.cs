using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ExamTablas.capaLogica
{
    public class connLogica
    {
        public static int Agregarclientes(int id_tecnico, string nombre, string especialiadad)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = capaLogica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Insert into tecnicos (tecnicos_id, nombre, especialidad) values (@id_tecnico,@nombre,@especialidad)", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@id_tecnico", id_tecnico));
                    cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                    cmd.Parameters.Add(new SqlParameter("@especialidad", especialiadad));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
        public static int Modificarclientes(int id_tecnico, string nombre, string especialiadad)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = capaLogica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("update tecnicos set nombre=@nombre, especialidad=@especialidad where tecnicos_id=@id_tecnico", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@id_tecnico", id_tecnico));
                    cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                    cmd.Parameters.Add(new SqlParameter("@especialidad", especialiadad));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
        public static int Borrarclientes(int id_tecnico)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = capaLogica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Delete from tecnicos where tecnicos_id=@id_tecnico", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@id_tecnico", id_tecnico));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
    }
}