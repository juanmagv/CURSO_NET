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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace enttity
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EntityEntities DbEntityes = new EntityEntities();
        public static DataGrid ControlDatagrid;
        public MainWindow()
        {
           
            InitializeComponent();
            MyDG.ItemsSource =
            DbEntityes.Profesores.ToList();
            ControlDatagrid = MyDG;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
                    Insertar Vinsertar = new
                    Insertar();
                        Vinsertar.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int id = (MyDG.SelectedItem as Profesores).Id;
            ventanaModificar Vcambiar = new ventanaModificar(id);
            Vcambiar.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int id = (MyDG.SelectedItem as Profesores).Id;
            var deleteProfe = DbEntityes.Profesores.Where(m =>
              m.Id == id).Single();
            DbEntityes.Profesores.Remove(deleteProfe);
            DbEntityes.SaveChanges();
            ControlDatagrid.ItemsSource =
                DbEntityes.Profesores.ToList();
        }
    }
}
