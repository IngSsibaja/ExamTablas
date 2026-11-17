using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamTablas.capaPresentacion
{
    public partial class tecnicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }
        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            using (SqlCommand cmd = new SqlCommand("Select * FROM tecnicos", con))
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
            if (capaLogica.connLogica.Agregarclientes(int.Parse(txtid_tecnico.Text), txtnombre.Text, txtespecialidad.Text) > 0)
            {
                LlenarGrid();
            }
        }
        protected void btnEditar_Click(object sender, EventArgs e)
        {
            if (capaLogica.connLogica.Modificarclientes(int.Parse(txtid_tecnico.Text), txtnombre.Text, txtespecialidad.Text) > 0)
            {
                LlenarGrid();
            }
        }
        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            if (capaLogica.connLogica.Borrarclientes(int.Parse(txtid_tecnico.Text)) > 0)
            {
                LlenarGrid();
            }
        }
    }
}