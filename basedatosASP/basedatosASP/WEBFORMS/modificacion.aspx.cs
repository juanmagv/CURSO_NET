using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace basedatosASP
{
    public partial class modificacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString.ToString();
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("update usuarios set " +
                "clave='" + this.txtClave.Text +
                "',mail='" + this.txtMail.Text +
                "'where nombre='" + this.txtBuscar.Text + "'", conexion);
            int cantidad = comando.ExecuteNonQuery();
            if (cantidad == 1)
                this.Label1.Text = "datos modificados";
            else
                this.Label2.Text = "No exixte el usuario";
            conexion.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString.ToString();
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select nombre,clave,mail from usuarios " +
                " where nombre='" + this.txtBuscar.Text + "'", conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                this.txtClave.Text = registro["clave"].ToString();
                this.txtMail.Text = registro["mail"].ToString();
            }
            else
                this.Label1.Text = "No existe un usuario con dicho nombre";
            conexion.Close();
        }
    }
}