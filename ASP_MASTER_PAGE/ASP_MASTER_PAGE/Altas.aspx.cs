using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Data;
namespace ASP_MASTER_PAGE
{
    public partial class Altas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAnnadir_Click(object sender, EventArgs e)
        {
            int cantidad;
          
                string c = System.Configuration.ConfigurationManager.ConnectionStrings["SIMULACROSQLConnectionString"].ConnectionString.ToString();
                SqlConnection conexion = new SqlConnection(c);
            try
            {
                if (IsValid)
                {
                    conexion.Open();

                    SqlCommand comando = new SqlCommand("insert into cliente(ID,nombre,apellido1,apellido2,ciudad,categoria)" +
                        "values('" + this.txtID.Text + "','" + this.txtNombre.Text + "','" + this.txtApellido1.Text +
                        "','" + this.txtApellido2.Text + "','" + this.txtciudad.Text + "','" + this.txtCategoria.Text + "')", conexion);


                    cantidad = comando.ExecuteNonQuery();
                    if (cantidad > 0)
                    {
                        Label1.ForeColor = System.Drawing.Color.Black;
                        Label1.Text = "Se registro el cliente";
                        conexion.Close();
                    }
                    else
                    {
                        Label1.ForeColor = System.Drawing.Color.Red;
                        Label1.Text = "Hay un error";
                    }


                }
                else
                {
                    Label1.ForeColor = System.Drawing.Color.Red;
                    Label1.Text = "Ojo faltan campos";
                }
            }
            catch
            {
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "EL ID YA EXISTE";
            }
           

            
        }
    }
}