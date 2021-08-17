using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repasando_en_agosto_Consola
{
   public class Persona
    {
        protected string nombres;
        protected string apellidos;
        protected string documento;
        protected string tipo;
        //protected para que las otras clases puedan utilizar sus propiedades

    public  Persona()
        {

        }
    public    Persona(string str_nombre,string str_apellidos,string str_documento, string str_tipo)
        {
            this.nombres = str_nombre;
            this.apellidos = str_apellidos;
            this.documento = str_documento;
            this.tipo = str_tipo;
        }

    public string Pnombre
        {
            set { nombres = value; }
            get { return nombres; }
        }
    public string Papellido
        {
            set { apellidos = value; }
            get { return apellidos; }
        }
    public string Pdocumento
        {
            set { documento = value; }
            get { return documento; }
        }
    public string Ptipo
        {
            set { tipo = value; }
            get { return tipo; }
        }


    }
}
