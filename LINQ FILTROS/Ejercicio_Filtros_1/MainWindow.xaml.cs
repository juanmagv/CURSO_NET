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
    {  //inicializamos la clase de contexto GLOBAL
        //en main windows si es WPF
        DatosJuevesContextDataContext filtros = new DatosJuevesContextDataContext();
        public MainWindow()
        {
            /// <summary>
            /// Inicializar Formulario y cargamos Grid con TODOS LOS DATOS
            /// </summary>
            InitializeComponent();
            cargarGrid();

        }

        void cargarGrid()
        {
            //Metodo con LinQ para cargar el Datagrid
            var listargrid = from f in filtros.datosjueves
                             select f;
            DGV1.ItemsSource = listargrid;
        }

        void cargarGridCurso()
        { ///<summary
            //metodo para  filtrar los registros
            //del curso seleccionado en el combo

            String curso = ComboBox1.Text;
            var listargrid = from f in filtros.datosjueves
                             where
f.Curso == curso
                             select f;
            DGV1.ItemsSource = listargrid;
        }

        void cargarGridNombre(String cadena)
        { ///<summary>
            //metodo con LInQpara  filtrar los registros
            //por el nombre
            //OJO contents es lo mismo que like en SQL


            /// </ summary>

            string curso = ComboBox1.Text;
            var listargrid = from f in filtros.datosjueves
                             where
                                f.Curso == curso && f.Nombre.Contains(cadena)
                             select f;
            DGV1.ItemsSource = listargrid;
        }

        void cargarGridApellido(String cadena)
        {
            string curso = ComboBox1.Text;
            var listargrid = from f in filtros.datosjueves
                             where
f.Curso == curso && f.Apellido.Contains(cadena)
                             select f;
            DGV1.ItemsSource = listargrid;
        }



        void cargarGridApellidoNombre(String cadena, string cadena2)
        {
            string curso = ComboBox1.Text;
            var listagrid = from f in filtros.datosjueves
                            where
f.Curso == curso && f.Nombre.Contains(cadena) &&
f.Apellido.Contains(cadena2)
                            select f;
            DGV1.ItemsSource = listagrid;



        }


        /// <summary>
        /// Habilitar y deshabilit Check de las fechas
        /// </summary>
        private void CheckBox1_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker1.IsEnabled = true;

        }

        private void CheckBox1_UnChecked(object sender, RoutedEventArgs e)
        {

            DatePicker1.IsEnabled = false;
        }

        private void CheckBox2_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker2.IsEnabled = true;
        }

        private void CheckBox2_UnChecked(object sender, RoutedEventArgs e)
        {
            DatePicker2.IsEnabled = false;

        }

        private void CheckBox4_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker3.IsEnabled = true;
        }

        private void CheckBox4_UnChecked(object sender, RoutedEventArgs e)
        {

            DatePicker3.IsEnabled = false;
        }

        private void CheckBox5_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker4.IsEnabled = true;
        }

        private void CheckBox5_UnChecked(object sender, RoutedEventArgs e)
        {
            DatePicker4.IsEnabled = false;

        }

        /// <summary>
        ///Deshabilita instructores
        /// </summary>

        private void CheckBox3_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox4.IsEnabled = true;
            CheckBox5.IsEnabled = true;
        }

        private void CheckBox3_UnChecked(object sender, RoutedEventArgs e)
        {
            CheckBox4.IsEnabled = false;
            CheckBox5.IsEnabled = false;

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text != "" && TextBox2.Text != "")
                cargarGridApellidoNombre(TextBox1.Text, TextBox2.Text);
            else if (TextBox1.Text != "" && TextBox2.Text == "")
                cargarGridNombre(TextBox1.Text);
            else if (TextBox1.Text == "" && TextBox2.Text != "")
                cargarGridApellido(TextBox2.Text);
            else cargarGridCurso();


        }





    



        void cargarfechas(DateTime fecha1 , DateTime fecha2 )
        {

            string curso = ComboBox1.Text;

            var listagrid = from f in filtros.datosjueves
                            where f.Curso==curso &&
                f.Fecha_Ins>= fecha1 && f.Fecha_Ins<=fecha2

                            select f;
            DGV1.ItemsSource = listagrid;

        }

        private void Btn_Buscar_Click(object sender, RoutedEventArgs e)
        {
            if (CheckBox1.IsChecked == true && CheckBox2.IsChecked == true)
                cargarfechas(DatePicker1.DisplayDate, DatePicker2.DisplayDate);
        }
    }
}

