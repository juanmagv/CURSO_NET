using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace basedatosASP
{
    public partial class alta : System.Web.UI.Page
    {
        
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString.ToString();
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            
            SqlCommand comando = new SqlCommand("insert into usuarios(nombre,clave,mail) values('" + this.txtNombre.Text +
                "','" + this.txtClave.Text + "','" + this.txtMail.Text + "')", conexion);
            comando.ExecuteNonQuery();
            Label4.Text = "Se registro el usuario";
            conexion.Close();
        }
    }
}