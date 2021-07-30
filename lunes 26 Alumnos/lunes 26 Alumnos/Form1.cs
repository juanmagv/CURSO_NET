using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lunes_26_Alumnos
{
    public partial class Form1 : Form
    {

        private SqlConnection conexion = new SqlConnection("server=ASATA403\\SQLEXPRESSJUANMA;initial Catalog=lunes26;" +
           "Persist Security info=True;User=sa;PassWord=1234;");
        DataClasses1DataContext ClienteLinq = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
            this.listarCliente();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void listarCliente()
        {

            dataGridView1.DataSource = ClienteLinq.ListarTodo();
        }

        private void btBuscarCodigo_Click(object sender, EventArgs e)

        {
             if (txtBuscarCodigo.Text != "")
             {
            int codigo;
                ClienteLinq.sp_Buscar_por_Codigo(Int32.Parse(txtBuscarCodigo.Text));
            codigo = Int32.Parse(txtBuscarCodigo.Text);
            dataGridView1.DataSource = ClienteLinq.sp_Buscar_por_Codigo(codigo);
                txtBuscarCodigo.Text = "";
                txtBuscarCodigo.Text = "";
                txtBuscarDNI.Text = "";

            }
            else
            {
                MessageBox.Show("Falta el codigo a buscar");
            }
       
        }

        private void btBuscarDNI_Click(object sender, EventArgs e)
        {
            if (txtBuscarDNI.Text != "")
            {
                ClienteLinq.sp_Buscar_por_DNI(txtBuscarDNI.Text);
                dataGridView1.DataSource = ClienteLinq.sp_Buscar_por_DNI(txtBuscarDNI.Text);
                txtBuscarDNI.Text = "";
                txtBuscarCodigo.Text = "";

            }
            else
            {
                MessageBox.Show("Falta el DNI a buscar");
            }
           
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDNI.Text != "" && txtNombre.Text != "")
                {

                    conexion.Open();
                    string nombre = txtNombre.Text;
                    string DNI = txtDNI.Text;
                    string turno = cbTurno.Text;
                    string sexo = cbSexo.Text;
                    int repetidor;
                    if (chRepetidor.Checked)
                    {
                        repetidor = 1;
                    }
                    else
                    {
                        repetidor = 0;
                    }

                    string modulo = cbModulo.Text;
                    string especialidad = cbEspecialidad.Text;
                    string cadena = ("insert into Alumnos (Nombre,DNI,Turno,Sexo,Repetidor,Modulo,Especialidad)" + "values" + "('" + nombre + "'" + "," + "'" + DNI + "'" + "," + "'" +
                        turno + "'" + "," + "'" + sexo + "'" + "," + repetidor + "," + "'" + modulo + "'" + "," + "'" +
                        especialidad + "'" + ")");
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("se han guardado todos los datos");
                    this.listarCliente();
                    txtCodigo.Text = "";
                    txtDNI.Text = "";
                    txtNombre.Text = "";
                    cbEspecialidad.Text = "";
                    cbModulo.Text = "";
                    cbSexo.Text = "";
                    cbTurno.Text = "";
                    chRepetidor.Checked = false;

                    dataGridView1.DataSource = ClienteLinq.ListarTodo();
                    conexion.Close();






                }
                else
                {
                    MessageBox.Show("faltan datos");
                }




            }
            catch
            {
                MessageBox.Show("Error dato duplicado");
            }
          
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text != "")
            {
                conexion.Open();
                string DNI = txtDNI.Text;
                string cadena = "delete from Alumnos where DNI =" + "'" + DNI + "'";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    txtCodigo.Text = "";
                    txtDNI.Text = "";
                    txtNombre.Text = "";
                    MessageBox.Show("Dato borrado correctamente");
                    cbEspecialidad.Text = "";
                    cbModulo.Text = "";
                    cbSexo.Text = "";
                    cbTurno.Text = "";
                    chRepetidor.Checked = false;

                }
                else
                {
                    MessageBox.Show("No existe el registro correspondiente");
                }
                dataGridView1.DataSource = ClienteLinq.ListarTodo();
                conexion.Close();




            }
            else
            {
                MessageBox.Show("Faltan datos");
            }
               

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text != "" && txtNombre.Text != "")
            {
                conexion.Open();

                string nombre = txtNombre.Text;
                string DNI = txtDNI.Text;
                string turno = cbTurno.Text;
                string sexo = cbSexo.Text;
                int repetidor;

                if (chRepetidor.Checked)
                {
                    repetidor = 1;
                }
                else
                {
                    repetidor = 0;
                }

                string modulo = cbModulo.Text;
                string especialidad = cbEspecialidad.Text;
                string cadena = "update Alumnos set Nombre=" + "'" + nombre + "'" + "," + "DNI=" + "'" + DNI + "'" + "," +
                    "turno=" + "'" + turno + "'" + "," + "sexo=" + "'" + sexo + "'" + "," + "repetidor=+" + repetidor + "," +
                    "modulo=" + "'" + modulo + "'" + "," + "especialidad=" + "'" + especialidad + "'" + "where DNI=" + "'" + DNI + "'";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se a modificado correctamente");
                    txtCodigo.Text = "";
                    txtDNI.Text = "";
                    txtNombre.Text = "";
                    cbEspecialidad.Text = "";
                    cbModulo.Text = "";
                    cbSexo.Text = "";
                    cbTurno.Text = "";
                    chRepetidor.Checked = false;


                }
                else
                {
                    MessageBox.Show("No se ha encontrado el dato a actualizar");
                }
                dataGridView1.DataSource = ClienteLinq.ListarTodo();
                conexion.Close();

              

            }
            else
            {
                MessageBox.Show("faltan datos");
            }
               
        }
    }
}