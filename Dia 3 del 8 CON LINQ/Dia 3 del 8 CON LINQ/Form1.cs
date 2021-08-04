using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dia_3_del_8_CON_LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataClasses1DataContext Hospital1 = new DataClasses1DataContext();
        DateTime date = DateTime.Now;

        private void Form1_Load(object sender, EventArgs e)
        {
            var cargaGrid = from h in Hospital1.Enfermo1 select h;
            dataGridView1.DataSource = cargaGrid;
        }


        void CargaGrid()
        {
            var cargarGrid = from h in Hospital1.Enfermo1 select h;
            dataGridView1.DataSource = cargarGrid;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Enfermo1 MyEnfermo = new Enfermo1();
                MyEnfermo.inscripcion = Int32.Parse(txtInscripcion.Text);
                MyEnfermo.Apellido = txtNombre.Text;
                if (rbHombre.Checked == true)
                {
                    MyEnfermo.S = "H";
                }
                else
                {
                    if (rbMujer.Checked == true)
                    {
                        MyEnfermo.S = "M";
                    }
                }
                MyEnfermo.Fecha_Nac = dpfechaNacimiento.Value;
                MyEnfermo.Direccion = txtDireccion.Text;
                MyEnfermo.NSS = Int32.Parse(txtSS.Text);
                Hospital1.Enfermo1.InsertOnSubmit(MyEnfermo);
                Hospital1.SubmitChanges();
                label8.Text = "DATOS GUARDADOS";
                label8.ForeColor = Color.Black;
                label8.BackColor = Color.Red;
                CargaGrid();
                
              
              

            }
            catch
            {
                if (txtInscripcion.Text == " " || txtNombre.Text == " " || txtDireccion.Text == " " || txtSS.Text == " " ||
                    (rbHombre.Checked == false && rbMujer.Checked == false) || dpfechaNacimiento.Value == date)
                {
                    MessageBox.Show("FALTAN DATOS");
                }
               
            }
            txtInscripcion.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtSS.Text = "";
            rbHombre.Checked = false;
            rbMujer.Checked = false;
            dpfechaNacimiento.Value = date;

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void BtActualizar_Click(object sender, EventArgs e)
        {
            DateTime fecha = new DateTime();
           
            try
            {
                Enfermo1 MyEnfermo = Hospital1.Enfermo1.Single(h =>
          h.inscripcion == Int32.Parse(txtInscripcion.Text));
                MyEnfermo.inscripcion = Int32.Parse(txtInscripcion.Text);
                MyEnfermo.Apellido = txtNombre.Text;
                MyEnfermo.NSS = Int32.Parse(txtSS.Text);
                MyEnfermo.Fecha_Nac = dpfechaNacimiento.Value;
                MyEnfermo.Direccion = txtDireccion.Text;
                if (rbHombre.Checked == true)
                {
                    MyEnfermo.S = "H";
                }
                else
                {
                    if (rbMujer.Checked == true)
                    {
                        MyEnfermo.S = "M";
                    }
                }

                Hospital1.SubmitChanges();
                CargaGrid();
              
                label8.Text = "DATOS MODIFICADOS";
                label8.ForeColor = Color.Black;
                label8.BackColor = Color.Red;
               

            }
            catch
            {

                if (txtInscripcion.Text == " " || txtNombre.Text == " " || txtDireccion.Text == " " || txtSS.Text == " " ||
                    (rbHombre.Checked == false && rbMujer.Checked == false) || dpfechaNacimiento.Value == date)
                {
                    MessageBox.Show("FALTAN DATOS");
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
            txtInscripcion.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtSS.Text = "";
            rbHombre.Checked = false;
            rbMujer.Checked = false;
            dpfechaNacimiento.Value = date;

        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            try
            {

                Enfermo1 MyEnfermo = Hospital1.Enfermo1.Single(h =>
              h.inscripcion == Int32.Parse(txtInscripcion.Text));
                Hospital1.Enfermo1.DeleteOnSubmit(MyEnfermo);
                Hospital1.SubmitChanges();
                CargaGrid();
             
                label8.Text = "DATOS BORRADOS";
                label8.ForeColor = Color.Black;
                label8.BackColor = Color.Red;
          

            }
            catch
            {
                if (txtInscripcion.Text == "")
                {
                    MessageBox.Show("Faltan Datos");
                }
            }

            txtInscripcion.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtSS.Text = "";
            rbHombre.Checked = false;
            rbMujer.Checked = false;
            dpfechaNacimiento.Value = date;
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
