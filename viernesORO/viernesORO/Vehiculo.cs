using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viernesORO
{
    class Vehiculo
    {
        protected int ID;//SI LE PONGO _ID ES PROTECTED
        protected string Marca;
        protected string Modelo;
        protected int KM;
        protected double Precio;
        
        public Vehiculo()
        {

        }
        public  Vehiculo(int int_ID,string str_Marca,string strModelo,int int_KM,double dbl_Precio)
        {
            this.ID = int_ID;
            this.Marca = str_Marca;
            this.Modelo = strModelo;
            this.KM = int_KM;
            this.Precio = dbl_Precio;
        }

            
           

        public void ModificarPrecio()
        {

        }
        public void imprimir()
        {

        }



}
}
