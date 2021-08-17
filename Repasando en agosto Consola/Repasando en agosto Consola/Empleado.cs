using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repasando_en_agosto_Consola
{
    class Empleado :Persona

    {
        private string tipoContrato;
        private double sueldo;

        public string PtipoContrato
        {
            set { tipoContrato = value; }
            get { return tipoContrato; }
        }
        public double Psueldo
        {
            set { sueldo = value; }
            get { return sueldo; }
        }

        public void calcularSueldo(double sueldoBase)
        {
            if (this.PtipoContrato == "F")
            {
                this.Psueldo = Psueldo + 300;
              
            }
            else
            {
                this.Psueldo = Psueldo + 250;
            }
        }


    }
}
