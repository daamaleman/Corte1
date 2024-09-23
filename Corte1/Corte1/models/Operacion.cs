using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1.models
{
    internal class Operacion
    {
        public int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            if (fechaActual.Month < fechaNacimiento.Month || (fechaActual.Month == fechaNacimiento.Month && fechaActual.Day < fechaNacimiento.Day))
            {
                edad--;
            }

            return edad;
        }

        public string DeterminarMayorEdad(int edad)
        {
            if (edad >= 18)
            {
                return "Mayor de edad";
            }
            else
            {
                return "Menor de edad";
            }
        }
    }
}
