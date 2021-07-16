using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola_Gestion_de_un_zoologico
{
    class Insecto : Animal
    {
        private bool vuela;
        public Insecto(string especie, string nombre, double peso, int jaula,bool vuela) :base(especie, nombre, peso, jaula){
            }


    public override void ClaseDeAnimalEres()
    {
            if (vuela == true){
                Console.WriteLine("Soy un INSECTO llamado \n" + nombre + " De la especie:\n" + especie + " Mi peso es:\n" + peso + " Mi jaula es: \n" + jaula + " Y vuelo\n");
            }
            else
            {
                Console.WriteLine("Soy un INSECTO llamado \n" + nombre + " De la especie:\n" + especie + " Mi peso es:\n" + peso + " Mi jaula es: \n" + jaula + "NO VUELO\n");
            }

            
        }
}
}
