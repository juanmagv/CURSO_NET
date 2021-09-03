using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viernesORO
{
    class Coche:Vehiculo
    {
        protected bool Airbag;
        protected string tieneAirbag;
        public Coche()
        {

        }
        public Coche(int int_ID, string str_Marca, string strModelo, int int_KM, double dbl_Precio,bool boAirbag) :base(
            int_ID, str_Marca, strModelo, int_KM, dbl_Precio)
        {
            this.Airbag = boAirbag;
            
        }
        public Coche(int int_ID, string str_Marca, string strModelo, int int_KM, double dbl_Precio) : base(
            int_ID, str_Marca, strModelo, int_KM, dbl_Precio)
        {

        }

        public bool PAirbag
        {
            set { PAirbag = value; }
            get { return PAirbag; }
        }

        public void modificaPrecio(bool tairbag)
        { //this.Airbag = tairbag;


            if (this.Airbag == true) {
                Precio = Precio + 200;
                tieneAirbag = "tiene Airbag";

            }
            else
            {
                if (this.Airbag == false)
                {
                    Precio = Precio+0;
                    tieneAirbag = " NO tiene Airbag";
                }
            }

            
        }
        public void imprimirCoche()
        {
            Console.WriteLine("ID coche: " + ID + "\n" + "Marca: " + Marca + "\n" + "MOdelo:" + Modelo+"\n" +
                "Precio: " + Precio + "\n" + "Airbag: " + tieneAirbag);
        }


    }
}
