using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CuestionarioASP_NET
{
    public partial class Default : System.Web.UI.Page
    { int nota;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButton4.Checked == true) nota = nota + 1;

            if (RadioButton8.Checked == true) nota = nota + 1;
            if (RadioButton12.Checked == true) nota = nota + 1;
            if (RadioButton16.Checked == true) nota = nota + 1;
            if (IsValid) Response.Redirect("accesoPermitido.html");
            if (nota == 0)
            {
                homer.Visible = true;
            }
            else
            {
                homer2.Visible = true;
            }
            Label1.Text = "Has acertado " + nota + " preguntas ";

        }
            
    }
}