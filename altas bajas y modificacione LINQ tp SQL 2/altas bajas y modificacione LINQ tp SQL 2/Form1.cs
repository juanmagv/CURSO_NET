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

        }

        void CargarGrid()
        {
            var cargarGrid = from u in dbhospital.usuarios
            select u.id;
            dataGridView1.DataSource = cargarGrid;


        }
    }
}
