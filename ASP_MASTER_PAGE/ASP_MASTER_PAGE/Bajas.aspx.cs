using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace ASP_MASTER_PAGE
{
    public partial class Bajas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            string c = System.Configuration.ConfigurationManager.ConnectionStrings["SIMULACROSQLConnectionString"].ConnectionString.ToString();
            SqlConnection conexion = new SqlConnection(c);
            conexion.Open();
            SqlCommand comando=new SqlCommand("delete from cliente where ID='"+this.dlbajasa.Text + "'", conexion);
            comando.ExecuteNonQuery();
            GridView1.DataBind();
            conexion.Close();


        }
    }
}