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
    /// Lógica de interacción para ventanaModificar.xaml
    /// </summary>
    public partial class ventanaModificar : Window
    {
        EntityEntities DbEntityes = new EntityEntities();
        int id;

        public ventanaModificar(int idProfesor)
        {
            InitializeComponent();
            id = idProfesor;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Profesores MyProfe = (from m in DbEntityes.Profesores
                                  where m.Id == id
                                  select m).Single();


            MyProfe.Nombre = TxtNombre.Text;
            MyProfe.Especialidad = cmbEspec.Text;
            DbEntityes.SaveChanges();
            MainWindow.ControlDatagrid.ItemsSource = DbEntityes.Profesores.ToList();
            this.Hide();
        }
    }
}
