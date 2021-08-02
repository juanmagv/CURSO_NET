using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace altas_bajas_y_modificacione_LINQ_tp_SQL_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } DataClasses1DataContext dbhospital = new DataClasses1DataContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        void CargarGrid()
        {
            var cargarGrid = from u in dbhospital.usuarios select u;
          
            dataGridView1.DataSource = cargarGrid;


        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtBuscar.Text != "")


                {
                    usuarios Myusuarios = dbhospital.usuarios.Single(u =>
                    u.nombre.Contains(txtBuscar.Text));
                    txtId.Text = Myusuarios.id.ToString();
                    txtName.Text = Myusuarios.nombre;
                    txtApellido.Text = Myusuarios.apellido;
                    txtEdad.Text = Myusuarios.edad.ToString();
                    cbCasado.Checked = Myusuarios.casado;

                    //contains es como el like
                    var buscarNombre = from usuarios in dbhospital.usuarios where usuarios.nombre.Contains(txtBuscar.Text) select usuarios;


                    dataGridView1.DataSource = buscarNombre;

                }
                else
                {
                    var cargarGrid = from u in dbhospital.usuarios select u;

                    dataGridView1.DataSource = cargarGrid;
                }


            }
            catch
            {
                MessageBox.Show("No existe");
            }




        }
       

        private void btAlta_Click(object sender, EventArgs e)
        {
            try
            {
                usuarios Myusuarios = new usuarios();
                Myusuarios.id = Int32.Parse(txtId.Text);
                Myusuarios.nombre = txtName.Text;
                Myusuarios.apellido = txtApellido.Text;
                Myusuarios.edad = Int32.Parse(txtEdad.Text);
                Myusuarios.casado = cbCasado.Checked;
                dbhospital.usuarios.InsertOnSubmit(Myusuarios);
                dbhospital.SubmitChanges();
                CargarGrid();
                contar();
                


            }
            catch{

                MessageBox.Show("Faltan datos");
            }
          



        }

        void contar()
        {
            var ContarLabel = (from u in
                              dbhospital.usuarios
                               select u.id).Count();
            lbContar.Text = "Existen "+ContarLabel.ToString()+" registros";
        }

        private void btBaja_Click(object sender, EventArgs e)
        {
            try
            {
                usuarios Myusuarios = dbhospital.usuarios.Single(u =>
                u.id == Int32.Parse(txtId.Text));
                dbhospital.usuarios.DeleteOnSubmit(Myusuarios);
                dbhospital.SubmitChanges();
                CargarGrid();
                contar();
               



            }
            catch
            {
                if (txtBuscar.Text == "") MessageBox.Show("Faltan datos");
            }



        }

        private void btMod_Click(object sender, EventArgs e)
        {
            try
            {
                usuarios Myusuarios = dbhospital.usuarios.Single(u =>
                u.id == Int32.Parse(txtId.Text));
                Myusuarios.nombre = txtName.Text;
                Myusuarios.apellido = txtApellido.Text;
                Myusuarios.edad = Int32.Parse(txtEdad.Text);
                Myusuarios.casado = cbCasado.Checked;
                dbhospital.SubmitChanges();
                CargarGrid();
                contar();
            


            }
            catch
            {
                if (txtId.Text == "" || txtName.Text == "" || txtEdad.Text == "" || txtId.Text == "" || txtEdad.Text == "") MessageBox.Show("Faltan datos");
            }
          
            }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtBuscar.Text = "";
            txtName.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            cbCasado.Checked = false;
        }
    }
}
