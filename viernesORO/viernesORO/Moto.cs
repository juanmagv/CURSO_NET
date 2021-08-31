using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viernesORO
{
    class Moto : Vehiculo
    {
        bool Sidecar;
        string tieneSidecar;
        public Moto()
        {

        }
        public Moto(int int_ID, string str_Marca, string strModelo, int int_KM, double dbl_Precio, bool boSidecar) : base(
            int_ID, str_Marca, strModelo, int_KM, dbl_Precio)
        {
            this.Sidecar = boSidecar;
        }
        public Moto(int int_ID, string str_Marca, string strModelo, int int_KM, double dbl_Precio) : base(
           int_ID, str_Marca, strModelo, int_KM, dbl_Precio)
        {
            
        }

        public bool PSidecar
        {
            set { PSidecar = value; }
            get { return PSidecar; }
        }
        public void modificaPrecio( bool tSidecar)
        {
            this.Sidecar = tSidecar;

            if (this.Sidecar == true)
            {
                Precio = Precio + 50;
                tieneSidecar = "tiene Sidecar";

            }
            else
            {
                if (this.Sidecar == false)
                {
                    Precio = Precio+0;
                    tieneSidecar = " NO tiene Sidecar";
                }
            }
            

        }
        public void imprimirMoto()
        {
            Console.WriteLine("ID coche: " + ID + "\n" + "Marca: " + Marca + "\n" + "MOdelo:" + Modelo + "\n" +
                "Precio: " + Precio + "\n" + "Airbag: " + tieneSidecar);
        }
    }
}
