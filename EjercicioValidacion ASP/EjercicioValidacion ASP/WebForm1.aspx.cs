using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioValidacion_ASP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
           
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == false)
            {
                lbChTerminos.Visible = true;
               
            }
            else
            {
               
                lbChTerminos.Visible = false;
            }

            if ((IsValid) && (CheckBox1.Checked == true)) Response.Redirect("accesopermitido.aspx");
        }
    }
    }