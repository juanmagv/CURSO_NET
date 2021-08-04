using System;

namespace Ejercicio_miercoles_repaso_de_clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto producto = new Producto();
          

            string opcion;
            opcion = Console.ReadLine();
            do
            {
                Console.WriteLine("1: PARA CREAR PEDIDO\n" + "2: PARA HACER PEDIDO\n" + "3: MOSTRAR EL TOTAL\n" + "4: PARA SALIR");

                switch (opcion)
                {

                    case "1":
                        Console.WriteLine("Introduce el nombre\n");
                        producto.Pnombre = Console.ReadLine();
                        Console.WriteLine("Introduce precio");
                        producto.Pprecio = float.Parse(Console.ReadLine());
                        break;
                    








                }

                

            } while (opcion != "4");

         
        }
    }
}
