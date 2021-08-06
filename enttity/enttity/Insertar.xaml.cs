using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace enttity
{
    /// <summary>
    /// Lógica de interacción para Insertar.xaml
    /// </summary>
    public partial class Insertar : Window
    {
        EntityEntities DbEntityes = new EntityEntities();
        public Insertar()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Profesores MyProfe = new Profesores()
            {
                Id =Int32.Parse( txtId.Text),
                Nombre = txtNombre.Text,
                Especialidad = cmbEsp.Text

            };
            DbEntityes.Profesores.Add(MyProfe);
            DbEntityes.SaveChanges();
            MainWindow.ControlDatagrid.ItemsSource = DbEntityes.Profesores.ToList();
            this.Hide();
        }
    }
}
