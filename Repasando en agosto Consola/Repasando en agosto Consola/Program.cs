using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repasando_en_agosto_Consola
{
    class Program
    {
        static void Main(string[] args)

           
        {
            int seleccion;
            Console.WriteLine("1 para cliente , 2 para empleado");
            seleccion=Int32.Parse( Console.ReadLine());

            if (seleccion == 1)
            {
                Cliente cli = new Cliente();
                Console.WriteLine("Introduce el nombre");
                cli.Pnombre = Console.ReadLine();
                Console.WriteLine("Introduce el apellido");
                cli.Papellido = Console.ReadLine();
                Console.WriteLine("Introduce el documento");
                cli.Pdocumento = Console.ReadLine();
                Console.WriteLine("Introduce el tipo");
                cli.Ptipo = Console.ReadLine();
                Console.WriteLine("introduce la categoria");
                cli.Pcategoria = Console.ReadLine();
                cli.generarCodigo(cli.Pnombre);
                Console.Clear();

                Console.WriteLine("Nombre :" + cli.Pnombre + "\n" + "Apellido: " + cli.Papellido + "\n" +
                    "Documento: " + cli.Pdocumento + "\n" + "Tipo: " + cli.Ptipo + "\n" + "Categoria: " +
                    cli.Pcategoria + "\n" + "Codigo: " + cli.Pcodigo);
                Console.ReadKey();
            }
            else
            {
                if (seleccion == 2)
                {
                    Empleado emp = new Empleado();
                    
                    Console.WriteLine("Introduce el nombre");
                    emp.Pnombre = Console.ReadLine();
                    Console.WriteLine("Introduce el apellido");
                    emp.Papellido = Console.ReadLine();
                    Console.WriteLine("Introduce el documento");
                    emp.Pdocumento = Console.ReadLine();
                    Console.WriteLine("Introduce el tipo");
                    emp.Ptipo = Console.ReadLine();
                }
            }
           

            




        }
    }
}
