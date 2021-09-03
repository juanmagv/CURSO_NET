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
using System.Data.SqlClient;

namespace InyeccionSQL
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection conexion = new SqlConnection("server=ASATA403\\SQLEXPRESSJUANMA;initial Catalog=PruebaINyeccionsql;" +
            "Persist Security info=False;User=sa;PassWord=1234;");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                
            try
            {  
               
               
                if(txtId.Text!="" && txtId.Text!="" && txtEdad.Text != "")
                {
                    conexion.Open();
                    string iden = txtId.Text;
                    string nombre = txtNombre.Text;
                    string edad = txtEdad.Text;

                    string cadena = "insert into Personas(id,nombre,edad)" + "values(" + iden + ",'" + nombre + "'," + edad + ")";
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("los datos se han guardado correctamente");
                    txtId.Text = "";
                    txtNombre.Text = "";
                    txtEdad.Text = "";
                    conexion.Close();

                }
                else{
                    MessageBox.Show("Faltan datos");
                }
               
            }
            catch
            {
               MessageBox.Show ("Ya  existe la clave en la base de datos");
                txtId.Text = "";
                txtNombre.Text = "";
                txtEdad.Text = "";
               
            }
               
               
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            

            if (txtId2.Text != "")
            {
                conexion.Open();

                string id = txtId2.Text;
                string cadena = "select id,nombre,edad from Personas where id=" + id;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    lbNombre.Content = registro["nombre"].ToString();
                    LbEdad.Content = registro["edad"].ToString();
                    btConsulta.IsEnabled = true;

                }
                else
                {
                    MessageBox.Show("No existe un artículo con el código ingresado");

                }
                conexion.Close();

            }
            else
            {
                MessageBox.Show("Faltan datos");
            }
     
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            

            if (txtId2.Text != "")
            {
                conexion.Open();

                string iden = txtId2.Text;
                string cadena = "delete from Personas where id=" + iden;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    lbNombre.Content = "";
                    LbEdad.Content = "";
                    txtId2.Text = "";
                    MessageBox.Show("Se borrò el artículo");
                }
                else
                {
                    MessageBox.Show("No existe el registro con el código ingresado");

                    btnBorrar.IsEnabled = true;
                }
                conexion.Close();

            }
           
           

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (txtId3.Text != "")
            {
                conexion.Open();
                string cod = txtId3.Text;
                string cadena = "select id,nombre,edad from Personas where id=" + cod;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    txtNombre1.Text = registro["nombre"].ToString();
                    txtEdad1.Text = registro["edad"].ToString();
                    btnModifica.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show("No existe el artículo con el códigho ingresado");

                }
                conexion.Close();


            }
            else
            {
                MessageBox.Show("faltan datos");
            }
            

        }

        private void btnModifica_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            if(txtId3.Text!="" && txtNombre1.Text!=""  && txtEdad1.Text != ""){

                string id = txtId3.Text;
                string nombre = txtNombre1.Text;
                string edad = txtEdad1.Text;

                string cadena = "update Personas set nombre='" + nombre + "', edad=" + edad + "where id=" + id;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se modificaron los datos del artículo");
                    txtId3.Text = "";
                    txtNombre1.Text = "";
                    txtEdad1.Text = "";


                }
                else
                {
                    MessageBox.Show("No existe el articulo con el código ingresado");


                }
                conexion.Close();
            }
            else
            {
                MessageBox.Show("faltan datos");
            }
            
        }
    }
}
