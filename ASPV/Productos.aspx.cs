using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ASPV
{
    public partial class Productos : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargaDatosAlumno();
            }
        }

        public void CargaDatosAlumno()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "SPSProducto",
                    Connection = conn
                };
                conn.Open();
                tablaProducto.DataSource = cmd.ExecuteReader();
                tablaProducto.DataBind();
            }
        }

        public void GuardaAlumno()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "SP_InsertarProducto"
                };
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtnombre.Text.Trim();
                cmd.Parameters.Add("@marca", SqlDbType.VarChar).Value = txtmarca.Text.Trim();
                cmd.Parameters.Add("@categoria", SqlDbType.VarChar).Value = txtcategoria.Text.Trim();
                cmd.Parameters.Add("@cantidad", SqlDbType.VarChar).Value = txtcantidad.Text.Trim();
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        protected void BtnNuevo_Click(object sender, EventArgs e)
        {
            pnlDatoaAlumno.Visible = false;
            pnlAltaAlumno.Visible = true;
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            pnlAltaAlumno.Visible = false;
            pnlDatoaAlumno.Visible = true;
            GuardaAlumno();
            CargaDatosAlumno(); 
            
        }
    }
}