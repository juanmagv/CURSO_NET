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
            string seleccion;
          
            do
            {
                Console.Clear();
                Console.WriteLine("1 para cliente , 2 para empleado, 3 salir");
                    seleccion =Console.ReadLine();

               
                

                switch (seleccion)
                {
                    case"1":
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
                        cli.generarCodigo();
                        Console.Clear();
                        cli.imprimir();
                     
                        break;


                    case "2":

                        Empleado emp = new Empleado();

                        Console.WriteLine("Introduce el nombre");
                        emp.Pnombre = Console.ReadLine();
                        Console.WriteLine("Introduce el apellido");
                        emp.Papellido = Console.ReadLine();
                        Console.WriteLine("Introduce el documento");
                        emp.Pdocumento = Console.ReadLine();
                        Console.WriteLine("Introduce el tipo");
                        emp.Ptipo = Console.ReadLine();
                        do
                        {
                            Console.WriteLine("Introduce el tipo de contrato F o T");
                            emp.PtipoContrato = Console.ReadLine();
                        } while (emp.PtipoContrato != "F" && emp.PtipoContrato != "f" && emp.PtipoContrato != "T"
                        && emp.PtipoContrato != "t");

                        try
                        {

                            Console.WriteLine("introduce el sueldo");
                            emp.Psueldo = double.Parse(Console.ReadLine());

                        }
                        catch
                        {
                            Console.WriteLine("El valor introducido no es un numero");
                        }



                        emp.calcularSueldo(emp.Psueldo);
                        Console.Clear();

                        Console.WriteLine("Nombre :" + emp.Pnombre + "\n" + "Apellido: " + emp.Papellido + "\n" +
                       "Documento: " + emp.Pdocumento + "\n" + "Tipo: " + emp.Ptipo + "\n" + "Tipo Contrato: " +
                       emp.PtipoContrato + "\n" + "Sueldo: " + emp.Psueldo);
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("Saliendo");
                        break;


                }


            } while (seleccion !="3");

        }
    }
}
