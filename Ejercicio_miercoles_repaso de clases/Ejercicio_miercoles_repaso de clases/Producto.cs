using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_miercoles_repaso_de_clases
{
    class Producto
    {

        private string nombre;
        private float precio;
        private string categoria;

        public Producto()
        {

        }
        public Producto(string str_nombre,float int_precio)
        {
            nombre = str_nombre;
            precio = int_precio;
            
        }

        public Producto(string str_Nombre,float int_precio,string str_categoria)
        {
            nombre = str_Nombre;
            precio = int_precio;
            categoria = str_categoria;

        }

        public string Pnombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public float Pprecio
        {
            set { precio = value; }
            get { return precio; }
        }
        public string Pcategoria
        {
            set { categoria = value; }
            get { return categoria; }
        }
    
        public void imprimir()
        {
            Console.WriteLine("Has comprado " + this.Pnombre + " al precio de " + this.Pprecio + " Categoria " + this.categoria);
        }
     

    }

   
}
