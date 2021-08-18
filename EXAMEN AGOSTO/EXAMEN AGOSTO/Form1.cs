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
            ClientesEntity.CLIENTES.Add(Misclientes);
            ClientesEntity.SaveChanges();
            cargarGrid();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            string TextoDNI = txtDNI.Text;
            var deleteCliente = ClientesEntity.CLIENTES.Where(c =>
            c.DNI == TextoDNI).Single();
            ClientesEntity.CLIENTES.Remove(deleteCliente);
            ClientesEntity.SaveChanges();
            cargarGrid();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            CLIENTES MyCliente = (from c in ClientesEntity.CLIENTES
                                  where c.DNI == txtDNI.Text select c).Single();
            MyCliente.NOMBRE = txtNombres.Text;
            MyCliente.DNI = txtDNI.Text;
            MyCliente.APELLIDOS = txtApellidos.Text;
            MyCliente.ESTADO_CIVIL = cbEstadocivil.Text;
            MyCliente.E_MAIL = txtEmail.Text;
            MyCliente.TELEFONO = txtTelefono.Text;
            MyCliente.FECHA_NACIMIENTO = dateTimePicker1.Value;
            ClientesEntity.SaveChanges();
            cargarGrid();
           
        }
    }
}
