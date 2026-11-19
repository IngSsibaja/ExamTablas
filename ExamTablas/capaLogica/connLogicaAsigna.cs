using ExamTablas.capaLogica;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ExamTablas.capaLogica
{
    public class connLogicaAsigna
    {
        public static int Agregarclientes_asigna(int id_asignacion, int id_reparacion, int id_tecnico, DateTime fecha_asignacion)
        {
            using (SqlConnection conn = DBconn.obtenerConexion())
            using (SqlCommand cmd = new SqlCommand("INSERT INTO asignaciones (asignacion_id, reparacion_id, tecnicos_id, fecha_asignacion)"+"VALUES (@asignacion_id, @reparacion_id, @tecnicos_id, @fecha_asignacion)", conn))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@asignacion_id", SqlDbType.Int).Value = id_asignacion;
                cmd.Parameters.Add("@reparacion_id", SqlDbType.Int).Value = id_reparacion;
                cmd.Parameters.Add("@tecnicos_id", SqlDbType.Int).Value = id_tecnico;
                cmd.Parameters.Add("@fecha_asignacion", SqlDbType.DateTime).Value = fecha_asignacion;

                return cmd.ExecuteNonQuery();
            }
        }
            public static int Modificarclientes_asigna(int id_asignacion, int id_reparacion, int id_tecnico, DateTime fecha_asignacion)
    {
        using (SqlConnection conn = DBconn.obtenerConexion())
        using (SqlCommand cmd = new SqlCommand("UPDATE asignaciones SET reparacion_id = @reparacion_id, tecnicos_id = @tecnicos_id,"+"fecha_asignacion = @fecha_asignacion WHERE asignacion_id = @asignacion_id", conn))
        {
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@asignacion_id", SqlDbType.Int).Value = id_asignacion;
            cmd.Parameters.Add("@reparacion_id", SqlDbType.Int).Value = id_reparacion;
            cmd.Parameters.Add("@tecnicos_id", SqlDbType.Int).Value = id_tecnico;
            cmd.Parameters.Add("@fecha_asignacion", SqlDbType.DateTime).Value = fecha_asignacion;

            return cmd.ExecuteNonQuery();
        }
    }
    public static int Borrarclientes_asigna(int id_asignacion)
    {
        using (SqlConnection conn = DBconn.obtenerConexion())
        using (SqlCommand cmd = new SqlCommand("DELETE FROM asignaciones WHERE asignacion_id = @asignacion_id", conn))
        {
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@asignacion_id", SqlDbType.Int).Value = id_asignacion;

            return cmd.ExecuteNonQuery();
        }
    }
        }
    }