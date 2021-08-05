using System;

namespace Ejercicio_miercoles_repaso_de_clases
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Producto producto = new Producto();
           

            string opcion;
             
            double Total=0;
            int cantidad;
            do
            {
                Console.WriteLine("1: PARA CREAR PEDIDO\n" + "2: PARA HACER PEDIDO\n" + "3: MOSTRAR EL TOTAL\n" + "4: PARA SALIR");
                opcion = Console.ReadLine();
                switch (opcion)
                {

                    case "1":
                        Console.WriteLine("Introduce el nombre\n");
                        producto.Pnombre = Console.ReadLine();
                        Console.WriteLine("Introduce precio");
                        producto.Pprecio = float.Parse(Console.ReadLine());
                     
                        Console.Clear();
                        break;

                    case "2":
                        Console.WriteLine("Intreoduzca la cantidad");
                       cantidad = Int32.Parse(Console.ReadLine());
                        Total = Total+ producto.Pprecio * 1.21*cantidad;
                    
                        Console.Clear();
                        break;

                    case "3":
                        Console.WriteLine("El importe total es de :" + Total);
                        Console.ReadLine();
                        Console.Clear();
                        break;



                    case "4":
                        Console.WriteLine("Saliendo..");
                        Console.ReadLine();
                        Console.Clear();
                        break;













                }

                

            } while (opcion != "4");

         
        }
    }
}
