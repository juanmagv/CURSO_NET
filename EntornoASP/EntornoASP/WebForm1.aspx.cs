using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntornoASP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "1";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int x = int.Parse(Label1.Text); x++; Label1.Text = x.ToString();

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (DropDownList1.Text=="Suma")
            {
                int resultado;
                int x1 = int.Parse(TextBox1.Text);
                int x2 = int.Parse(TextBox2.Text);
                resultado = x1 + x2;

                Label1.Text = "La suma de los dos valores es:" +
                    resultado;
            }
            else
            {
                if (DropDownList1.Text == "Resta")
                {
                    int resultado;
                    int x1 = int.Parse(TextBox1.Text);
                    int x2 = int.Parse(TextBox2.Text);
                    resultado = x1 - x2;

                    Label1.Text = "La resta de los dos valores es:" +
                        resultado;
                }
                else
                {
                    if (DropDownList1.Text == "Multi")
                    {
                        int resultado;
                        int x1 = int.Parse(TextBox1.Text);
                        int x2 = int.Parse(TextBox2.Text);
                        resultado = x1 * x2;

                        Label1.Text = "La multiplicacion de  de los dos valores es:" +
                            resultado;
                    }
                    else
                    {
                        if (DropDownList1.Text == "Divi")
                        {
                            int resultado;
                            int x1 = int.Parse(TextBox1.Text);
                            int x2 = int.Parse(TextBox2.Text);
                            resultado = x1 / x2;

                            Label1.Text = "La division de  de los dos valores es:" +
                                resultado;
                        }
                    }
                }
            }
        }
    }
}