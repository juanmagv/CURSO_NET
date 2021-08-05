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

namespace Ejercicio_Filtros
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataClasses1DataContext filtros = new DataClasses1DataContext();
        public MainWindow()
        {
            /// <summary>
            /// Inicializar Formulario y cargamos Grid con TODOS LOS DATOS
            /// </summary>
            InitializeComponent();

        }

        void cargarGrid()
        {

        }

        void cargarGridCurso()
        {

        }

        void cargarGridNombre(String cadena)
        {

        }

        void cargarGridApellido(String cadena)
        {
        }



        void cargarGridApellidoNombre(String cadena, string cadena2)
        {

        }


        /// <summary>
        /// Habilitar y deshabilit Check
        /// </summary>
        private void CheckBox1_Checked(object sender, RoutedEventArgs e)
        {


        }

        private void CheckBox1_UnChecked(object sender, RoutedEventArgs e)
        {


        }

        private void CheckBox2_Checked(object sender, RoutedEventArgs e)
        {
  
        }

        private void CheckBox2_UnChecked(object sender, RoutedEventArgs e)
        {


        }

        private void CheckBox4_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox4_UnChecked(object sender, RoutedEventArgs e)
        {


        }

        private void CheckBox5_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox5_UnChecked(object sender, RoutedEventArgs e)
        {


        }

        /// <summary>
        ///Deshabilita instructores
        /// </summary>

        private void CheckBox3_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox3_UnChecked(object sender, RoutedEventArgs e)
        {


        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
