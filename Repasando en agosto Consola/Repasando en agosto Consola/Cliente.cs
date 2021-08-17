using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repasando_en_agosto_Consola
{
    class Cliente :Persona
    {
        private string categoria;
        private string codigo;


        public string Pcategoria
        {
            set { categoria = value; }
            get { return categoria; }
        }

        public string Pcodigo
        {
            set { codigo = value; }
            get { return codigo; }
        }

        public void generarCodigo(string  Generacodigo)
           
        {
           this.Pcodigo = "C" + this.Pnombre.Substring(0, 3)+this.Pdocumento.Substring(0,2);
           

        }

    }





}
