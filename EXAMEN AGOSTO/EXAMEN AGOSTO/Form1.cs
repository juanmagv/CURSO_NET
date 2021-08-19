using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_AGOSTO
{
    public partial class Form1 : Form
    {   //AÑADIMOS EL CONTEXTO DE ENTUDADES
        RepasoAgostoEntities ClientesEntity = new RepasoAgostoEntities();
    
        public Form1()
        {
            InitializeComponent();
            //INVOCAMOS EL EVENTO DE CARGAR GRID
            cargarGrid();
        }
        //DEFINIMOS UN EVENTO PARA CARGAR EL GRID
        public void cargarGrid()
        {
            dataGridView1.DataSource = ClientesEntity.CLIENTES.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
          }

        private void btagregar_Click(object sender, EventArgs e)
        {
            try
            {

               
                
                    CLIENTES Misclientes = new CLIENTES()
                    {
                        DNI = txtDNI.Text,
                        NOMBRE = txtNombres.Text,
                        APELLIDOS = txtApellidos.Text,
                        ESTADO_CIVIL = cbEstadocivil.Text,
                        E_MAIL = txtEmail.Text,
                        TELEFONO = txtTelefono.Text,
                        FECHA_NACIMIENTO = dateTimePicker1.Value

                    };
                    //Llamamos al contexto de clientes y añadimos el objeto cliente
                    ClientesEntity.CLIENTES.Add(Misclientes);
                    //GUARDAMOS EL NUEVO REGITROS EN LA BASE DE DATOS
                    ClientesEntity.SaveChanges();
                    //REFRESCAMOS EL DATAGRID
                    cargarGrid();


               
            }
            catch
            {
                if (txtDNI.Text == "" && txtNombres.Text == "" && txtApellidos.Text == "" && cbEstadocivil.Text == "" && txtEmail.Text != "" && txtTelefono.Text == "")
                {
                    MessageBox.Show("ERROR FALTAN DATOS");
                }
                else
                {
                    MessageBox.Show("DNI YA EXISTE");
                }
                    
            }
          
               


          
           
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string TextoDNI = txtDNI.Text;
            try
            {

                
                CLIENTES BuscaCliente = (from c in ClientesEntity.CLIENTES
                                         where c.DNI == txtDNI.Text
                                         select c).Single();

                txtNombres.Text = BuscaCliente.NOMBRE;
                txtApellidos.Text = BuscaCliente.APELLIDOS;
                txtTelefono.Text = BuscaCliente.TELEFONO;
                txtEmail.Text = BuscaCliente.E_MAIL;
                cbEstadocivil.Text = BuscaCliente.ESTADO_CIVIL;
                dateTimePicker1.Text = BuscaCliente.FECHA_NACIMIENTO.ToString();
            }
            catch
            {
                MessageBox.Show("Error falta el DNI");
            }
          
               
         



        }

        private void btEliminar_Click(object sender, EventArgs e)
        {   //DEFINIMOS UNA VARIABLE QUE GUARDE EL DNI
            
            string TextoDNI = txtDNI.Text;
            //METODO LAMBDA QUE CONSIGUE A UN CLINETE POR SU DNI
            try 
            {
                var deleteCliente = ClientesEntity.CLIENTES.Where(c =>
           c.DNI == TextoDNI).Single();
                //MEDIANTE LINQ
                //CLIENTES MyCliente = (from c in ClientesEntity.CLIENTES
                //where c.DNI == txtDNI.Text
                //select c).Single();
                //BORRAMOS AL CLIENTE BUSCADO
                ClientesEntity.CLIENTES.Remove(deleteCliente);
                ClientesEntity.SaveChanges();
                cargarGrid();

            }
            catch
            {
                MessageBox.Show("Falta el DNI");
            }
           
        }

        private void btModificar_Click(object sender, EventArgs e)
        {//todo CONTROLAR ENTRADA DNI
            string TextoDNI = txtDNI.Text;
            //MEDIANTE LINQ OBTENEMOS EL CLIENTE
            try
            {
                if (txtDNI.Text != "" && txtNombres.Text != "" && txtApellidos.Text != "" && cbEstadocivil.Text != "" && txtEmail.Text != "" && txtTelefono.Text != "")
                {

                    CLIENTES MyCliente = (from c in ClientesEntity.CLIENTES
                                          where c.DNI == txtDNI.Text
                                          select c).Single();
                    //DEFINIMOS LOS ATRIBUTOS DEL OBJETO MYCLIENTE
                    MyCliente.NOMBRE = txtNombres.Text;
                    MyCliente.APELLIDOS = txtApellidos.Text;
                    MyCliente.ESTADO_CIVIL = cbEstadocivil.Text;
                    MyCliente.E_MAIL = txtEmail.Text;
                    MyCliente.TELEFONO = txtTelefono.Text;
                    MyCliente.FECHA_NACIMIENTO = dateTimePicker1.Value;
                    //HACMOS EL ALVADO AEN LA BASE DE DATOS
                    ClientesEntity.SaveChanges();
                    cargarGrid();

                }
                else
                {
                    MessageBox.Show("FALTAN DATOS");
                }

            }
            catch
            {
                MessageBox.Show("NO EXISTE EL DNI");
            }
          
              
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CLIENTES BuscaCliente1 = ClientesEntity.CLIENTES.First();

                txtDNI.Text = BuscaCliente1.DNI;
                txtNombres.Text = BuscaCliente1.NOMBRE;
                txtApellidos.Text = BuscaCliente1.APELLIDOS;
                txtTelefono.Text = BuscaCliente1.TELEFONO;
                txtEmail.Text = BuscaCliente1.E_MAIL;
                cbEstadocivil.Text = BuscaCliente1.ESTADO_CIVIL;
                dateTimePicker1.Text = BuscaCliente1.FECHA_NACIMIENTO.ToString();


            }
            catch
            {
                MessageBox.Show("ERROR ESTAS EN LA PRIMERA FILA");
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                CLIENTES BuscaCliente = ClientesEntity.CLIENTES.ToList().Last();

                txtDNI.Text = BuscaCliente.DNI;
                txtNombres.Text = BuscaCliente.NOMBRE;
                txtApellidos.Text = BuscaCliente.APELLIDOS;
                txtTelefono.Text = BuscaCliente.TELEFONO;
                txtEmail.Text = BuscaCliente.E_MAIL;
                cbEstadocivil.Text = BuscaCliente.ESTADO_CIVIL;
                dateTimePicker1.Text = BuscaCliente.FECHA_NACIMIENTO.ToString();


            }
            catch
            {
                MessageBox.Show("ERROR ESTAS EN LA ULTIMA FILA");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {   //DECLARAMOS UNA VARIABLE PARA INDICAR LA FILA ANTERIOR
            try
            {
                int anterior = dataGridView1.CurrentRow.Index - 1;

                //NOS DESPLAZAMOS A LA FILA ANTERIOR
                dataGridView1.CurrentCell = dataGridView1.Rows[anterior].Cells
                    [dataGridView1.CurrentCell.ColumnIndex];
                txtDNI.Text = dataGridView1.Rows[anterior].Cells[0].Value.ToString();
                txtNombres.Text = dataGridView1.Rows[anterior].Cells[1].Value.ToString();
                txtApellidos.Text = dataGridView1.Rows[anterior].Cells[2].Value.ToString();
                cbEstadocivil.Text = dataGridView1.Rows[anterior].Cells[3].Value.ToString();
                txtTelefono.Text = dataGridView1.Rows[anterior].Cells[4].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[anterior].Cells[5].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[anterior].Cells[6].Value.ToString();


            }
            catch
            {
                MessageBox.Show("ERROR ESTAS EN LA PRIMERA FILA");
            }
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //DECLARAMOS UNA VARIABLE PARA INDICAR LA FILA SIGUIENTE
                int posterior = dataGridView1.CurrentRow.Index + 1;

                //NOS DESPLAZAMOS A LA FILA POSTERIOR


                dataGridView1.CurrentCell = dataGridView1.Rows[posterior].Cells
                 [dataGridView1.CurrentCell.ColumnIndex];
                txtDNI.Text = dataGridView1.Rows[posterior].Cells[0].Value.ToString();
                txtNombres.Text = dataGridView1.Rows[posterior].Cells[1].Value.ToString();
                txtApellidos.Text = dataGridView1.Rows[posterior].Cells[2].Value.ToString();
                cbEstadocivil.Text = dataGridView1.Rows[posterior].Cells[3].Value.ToString();
                txtTelefono.Text = dataGridView1.Rows[posterior].Cells[4].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[posterior].Cells[5].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[posterior].Cells[6].Value.ToString();


            }
            catch
            {
                MessageBox.Show("ERROR ESTAS EN LA ULTIMA FILA");
            }
           



          
                

            
           
        }

        private void btListar_Click(object sender, EventArgs e)
        {

        }
    }
}
