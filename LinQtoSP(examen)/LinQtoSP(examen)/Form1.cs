using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQtoSP_examen_
{
    public partial class GridD : Form

    {
        DataClasses1DataContext ClienteLinq = new DataClasses1DataContext();
        public GridD()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = "";
            TxtApellido1.Text = "";
            TxtApellido2.Text = "";
            TxtBuscar.Text = "";
            TxtTelefono.Text = "";

           
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ClienteLinq.insertarcliente(TxtNombre.Text, TxtApellido1.Text, TxtApellido2.Text, TxtTelefono.Text);
            this.listarclientes();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ClienteLinq.Modificarcliente(TxtNombre.Text,TxtApellido1.Text,TxtApellido2.Text,TxtTelefono.Text);
            this.listarclientes();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ClienteLinq.EliminarCliente(TxtNombre.Text);
            this.listarclientes();
        }
        void listarclientes()
        {
            GridDatos.DataSource = ClienteLinq.ListarClientes();
        }

        private void GridD_Load(object sender, EventArgs e)
        {
            this.listarclientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)


        {
            if ((TxtBuscar.Text== " ") || (TxtBuscar.Text =="" )){
                GridDatos.DataSource = ClienteLinq.ListarClientes();
            }
            else {
                GridDatos.DataSource = ClienteLinq.BuscarCliente(TxtBuscar.Text);
            }
            
        }
    }
}
