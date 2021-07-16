using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola_Gestion_de_un_zoologico
{
    class Ave :Animal
    {   protected string colorPlumaje;
        protected float alturaMaximaVuelo;

        public Ave(String especie, String nombre, double peso, int jaula,string colorPlumaje,float alturaMaximaVuelo) : base(especie, nombre, peso, jaula)
        {

        }

        public  override void ClaseDeAnimalEres()
        {

            Console.WriteLine( "Soy un AVE llamado \n" + nombre + " De la especie:\n" + especie + " Mi peso es:\n" + peso + " Mi jaula es: " + jaula +
                "Mi plumaje es: \n" + colorPlumaje + " Mi altura maxima de vuelo es: \n" + alturaMaximaVuelo+"\n");
        }
    }
}
