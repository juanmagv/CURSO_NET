using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola_Gestion_de_un_zoologico
{
    class Mamifero :Animal
    {
        public Mamifero(String especie, String nombre, double peso, int jaula)  :base(especie,nombre,peso,jaula)
        {

        }


        public override void ClaseDeAnimalEres()
        {

            Console.WriteLine( "Soy un MAMIFERO llamado \n" + nombre + " De la especie:\n" + especie +    " Mi peso es:\n" + peso + " Mi jaula es: " + jaula+"\n");
        }

    }
}
