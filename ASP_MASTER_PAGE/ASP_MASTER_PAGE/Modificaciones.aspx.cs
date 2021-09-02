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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {

                string c = System.Configuration.ConfigurationManager.ConnectionStrings["SIMULACROSQLConnectionString"].ConnectionString.ToString();
                SqlConnection conexion = new SqlConnection(c);
                conexion.Open();
                SqlCommand comando = new SqlCommand("update cliente set " +
                    "nombre='" + this.txtNombre.Text +
                    "',apellido1='" + this.txtApellido1.Text +
                    "',apellido2='" + this.txtApellido2.Text +
                    "',ciudad='" + this.txtciudad.Text +
                    "',categoria='" + this.txtCategoria.Text +
                    "'where ID='" + this.dlID.Text + "'", conexion);
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                    this.Label1.Text = "Datos modificados";
                else
                    this.Label1.Text = "No existe el usuario";
                conexion.Close();

            }
        }
        protected void dlID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void btBuscar_Click(object sender, EventArgs e)
        {
            string c = System.Configuration.ConfigurationManager.ConnectionStrings["SIMULACROSQLConnectionString"].ConnectionString.ToString();
            SqlConnection conexion = new SqlConnection(c);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select ID,nombre,apellido1,apellido2,ciudad,categoria from cliente where ID='" +
                this.dlID.Text + "'", conexion);

            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                txtNombre.Text = registro["nombre"].ToString();
                txtApellido1.Text = registro["apellido1"].ToString();
                txtApellido2.Text = registro["apellido2"].ToString();
                txtciudad.Text = registro["ciudad"].ToString();
                txtCategoria.Text = registro["categoria"].ToString();

            }
            else
            {
                this.Label1.Text = "No existe el registro";
            }
            conexion.Close();
        }
    }
}