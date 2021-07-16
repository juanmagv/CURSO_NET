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
                Console.WriteLine("Crear cuenta");
                Console.WriteLine("Depositar cantidad");
                Console.WriteLine("Retirar dinero");
                Console.WriteLine("Consultar saldo");
                Console.WriteLine("Salir de la App");
                Console.WriteLine("introduzaca una opcion");
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
                }

            } while (opcion != "5");
        }
    }
}
