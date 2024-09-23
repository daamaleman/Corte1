﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1.models
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNac { get; set; }
        public string Ciudad { get; set; }

        public Persona(string nombre, string apellido, string fechaNac, string ciudad)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNac = fechaNac;
            Ciudad = ciudad;
        }
    }
}
