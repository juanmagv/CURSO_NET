﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace codefirst1
{
    public class Empleado
    {
        [Key]

        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}