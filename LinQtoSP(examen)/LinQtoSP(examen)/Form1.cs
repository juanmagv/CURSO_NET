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
           
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ClienteLinq.insertarcliente(TxtNombre.Text, TxtApellido1.Text, TxtApellido2.Text, TxtTelefono.Text);
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ClienteLinq.Modificarcliente(TxtNombre.Text, TxtApellido1.Text, TxtApellido2.Text, TxtTelefono.Text);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ClienteLinq.EliminarCliente(TxtNombre.Text);
        }
    }
}
