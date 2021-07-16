using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejexrcicio_consola_banco
{
    class Program
        
    { //ejercicio para gestionar las cuentas de un banco
       //se pide crear una clase de tipo cuenta para gestionar ingresos y gastos
        
        static void Main(string[] args)
        {
            int deposito = 0;
            int retiro = 0;
            Cuenta cuen = new Cuenta();

            string opcion = "";
            
            do
            {
                Console.WriteLine("1 Crear cuenta");
                Console.WriteLine("2 Depositar cantidad");
                Console.WriteLine("3 Retirar dinero");
                Console.WriteLine("4 Consultar saldo");
                Console.WriteLine("5 Salir de la App");
                Console.WriteLine("introduzaca una opcion\n");
                opcion = Console.ReadLine();
                Console.Clear();

                switch (opcion)
                {
                    case "1":


                        Console.WriteLine("Introduce el numero de cuenta");
                        cuen.PnumCuenta = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce el numero de cliente");
                        cuen.PnumCliente = Console.ReadLine();
                        Console.WriteLine("introduzca el saldo");
                        cuen.Psaldo = double.Parse(Console.ReadLine());
                        break;



                    case "2":
                        Console.WriteLine("introduce el importe del deposito");
                        deposito = int.Parse(Console.ReadLine());
                        cuen.depositar(deposito);
                        break;


                    case "3":
                          Console.WriteLine("introduce cantidad a retirar");
                        retiro = int.Parse(Console.ReadLine());
                        cuen.retirar(retiro);
                        break;

                    case "4":

                        Console.WriteLine("El saldo es " + cuen.Psaldo);
                        break;
                    case "5":
                        Console.WriteLine("Saliendo");
                        Console.ReadLine();
                        break;
                }

            } while (opcion != "5");
        }
    }
}
