﻿using System;
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
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LinqTosql.sp_crear_cliente(txtdcliente.Text, txtApellidos.Text, txtNombre.Text);
           
            
        }
        void listarclientes()
        {
            dataGridView1.DataSource = LinqTosql.SP_MOSTRAR_TODA_INFORMACION();
        }
    }
}
