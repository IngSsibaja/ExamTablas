using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;


namespace ExamTablas.capaPresentacion
{
    public partial class asignaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGridAsigna();
        }
        protected void LlenarGridAsigna()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            using (SqlCommand cmd = new SqlCommand("Select * FROM asignaciones", con))
            {
                con.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    GridView1.DataSource = rdr;
                    GridView1.DataBind();
                }
            }
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (capaLogica.connLogicaAsigna.Agregarclientes_asigna(int.Parse(txtid_asignacion.Text), int.Parse(txtid_reparacion.Text), int.Parse(txtid_tecnico.Text), DateTime.Parse(txtfecha_asignacion.Text)) > 0)
            {
                LlenarGridAsigna();
            }
        }
        protected void btnEditar_Click(object sender, EventArgs e)
        {
            if (capaLogica.connLogicaAsigna.Modificarclientes_asigna(int.Parse(txtid_asignacion.Text), int.Parse(txtid_reparacion.Text), int.Parse(txtid_tecnico.Text), DateTime.Parse(txtfecha_asignacion.Text)) > 0)
            {
                LlenarGridAsigna();
            }
        }
        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            if (capaLogica.connLogicaAsigna.Borrarclientes_asigna(int.Parse(txtid_asignacion.Text)) > 0)
            {
                LlenarGridAsigna();
            }
        }
    }
}