using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viernesORO
{
    class Program
    {
        static void Main(string[] args)
        {
            int ID;
            string Modelo;
            string Marca;
            int KM;
            double Precio;
            string TieneAirbag;
            string opcion;
            bool airbags;
            string TieneSidecar;
            bool sidecar;

            Coche cochin = new Coche();
            Moto motin = new Moto();
            do
            {
                Console.WriteLine("1 Crear coche \n2 Crear Moto \n3 Listar datos del Coche\n" +
               "4 Listar datos de la moto\n5 salir");
                opcion = Console.ReadLine();
                Console.Clear();

                switch (opcion)
                {
                    case "1":

                        Console.WriteLine("Introduce el ID:");
                        ID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce el Modelo:");
                        Modelo = Console.ReadLine();
                        Console.WriteLine("Introduce la  Marca:");
                        Marca = Console.ReadLine();
                        Console.WriteLine("Introduce los Kilometros:");
                        KM = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce el precio:");
                        Precio = double.Parse(Console.ReadLine());
                        Console.WriteLine("Tiene Airbag S/N");
                        TieneAirbag = Console.ReadLine();
                        cochin = new Coche(ID, Modelo, Marca, KM, Precio);
                        if (TieneAirbag == "s" || TieneAirbag == "S")
                        {
                            cochin.PAirbag = true;
                            //airbags = true;
                           // cochin.modificaPrecio(airbags);

                        }
                        else
                        {
                            if (TieneAirbag == "n" || TieneAirbag == "N")
                            {

                                airbags = false;
                                cochin.modificaPrecio(airbags);

                            }
                        }//FIN DEL ELSE

                      

                        break;

                    case "2":

                        Console.WriteLine("Introduce el ID:");
                        ID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce el Modelo:");
                        Modelo = Console.ReadLine();
                        Console.WriteLine("Introduce la  Marca:");
                        Marca = Console.ReadLine();
                        Console.WriteLine("Introduce los Kilometros:");
                        KM = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce el precio:");
                        Precio = double.Parse(Console.ReadLine());
                        Console.WriteLine("Tiene Sidecar S/N");
                        TieneSidecar = Console.ReadLine();
                         motin = new Moto(ID, Modelo, Marca, KM, Precio);
                        if (TieneSidecar == "s" || TieneSidecar == "S")
                        {
                            sidecar = true;
                            motin.modificaPrecio(sidecar);

                        }
                        else
                        {
                            if (TieneSidecar == "n" || TieneSidecar == "N")
                            {

                                sidecar = false;
                                motin.modificaPrecio(sidecar);

                            }
                        }//FIN DEL ELSE

                        

                        break;

                    case "3":
                        Console.Clear();
                        cochin.imprimirCoche();
                        Console.ReadKey();

                        break;

                    case "4":
                        Console.Clear();
                        motin.imprimirMoto();
                        Console.ReadKey();
                        break;

                }



            } while (opcion != "5");

             

            
        }
    }
}
