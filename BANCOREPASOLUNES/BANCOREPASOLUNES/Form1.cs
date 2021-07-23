using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANCOREPASOLUNES
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext LinqTosql = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listarclientes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)

        {
            if (txtNombre.Text != "" && txtApellidos.Text != "" && txtdcliente.Text != "")
            {

                try
                {
                    LinqTosql.sp_crear_cliente(txtdcliente.Text, txtApellidos.Text, txtNombre.Text);
                    this.listarclientes();

                }
                catch
                {
                    MessageBox.Show("ERROR EL USUARIO YA EXISTE");
                }




            }
            else
            {
                MessageBox.Show("FALTAN DATOS");
            }
          
          
          





        }
        void listarclientes()
        {
            dataGridView1.DataSource = LinqTosql.sp_mostrartodo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)

        {
          if  (txtdcliente.Text != "")
            {
                LinqTosql.sp_ELIMINARCLIENTE(txtdcliente.Text);
                this.listarclientes();
            }
            else
            {
                MessageBox.Show("FALTAN DATOS");
            }
           


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellidos.Text != "" && txtdcliente.Text != "")
            {
                LinqTosql.SP_MODIFICAR_CLIENTE(txtdcliente.Text, txtApellidos.Text, txtNombre.Text);
                this.listarclientes();
            }
            else
            {
                MessageBox.Show("FALTAN DATOS");
            }


           


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTNbUSCAR_Click(object sender, EventArgs e)
        {
            if (cbBusqueda.Text == "NOMBRE")
            {
               // LinqTosql.spbuscarpornombre(txtBuscar.Text);
                dataGridView1.DataSource = LinqTosql.spbuscarpornombre(txtBuscar.Text);
            }
            else
            {
                if(cbBusqueda.Text == "APELLIDO")
                {
                    dataGridView1.DataSource = LinqTosql.spbuscarporapellido(txtBuscar.Text);
                }
                else
                {
                    if (cbBusqueda.Text == "IDCLIENTE")
                    {
                        dataGridView1.DataSource = LinqTosql.spbuscarporIDCLIENTE(txtBuscar.Text);
                    }
                }
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LinqTosql.sp_mostrartodo();
            txtApellidos.Text = "";
            txtBuscar.Text = "";
            txtdcliente.Text = "";
            txtNombre.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
