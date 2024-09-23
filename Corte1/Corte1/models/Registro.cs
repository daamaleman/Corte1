using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1.models
{
    internal class Registro
    {
        private Persona[] personas = new Persona[30];
        private int pos = 0;

        public void AgregarPersona(Persona persona)
        {
            if (pos < 30)
            {
                personas[pos] = persona;
                pos++;
            }
            else
            {
                Console.WriteLine("El arreglo está lleno. No se puede agregar más personas.");
            }
        }

        public void MostrarPersonas()
        {
            for (int i = 0; i < pos; i++)
            {
                Console.WriteLine($"Persona {i + 1}: {personas[i].Nombre} {personas[i].Apellido}");
            }
        }
    }
}
