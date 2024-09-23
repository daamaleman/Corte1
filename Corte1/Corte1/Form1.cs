using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Corte1.Clases;

namespace Corte1
{
    public partial class Form1 : Form
    {
        private Registro registro = new Registro();

        public Form1()
        {
            InitializeComponent();
            Ciudades();
        }

        private void Ciudades()
        {
            cmbCiudad.Items.Add("Managua");
            cmbCiudad.Items.Add("Leon");
            cmbCiudad.Items.Add("Masaya");

            cmbCiudad.SelectedIndex = 0;
        }

        private void mostrarEdad_Click(object sender, EventArgs e)
        {
            if (registro.ContadorPersonas() == 0)
            {
                MessageBox.Show("No hay personas registradas.");
                return;
            }

            int ultimoIndice = registro.ContadorPersonas() - 1;
            Persona personaSeleccionada = registro.MostrarPersonas()[ultimoIndice];

            int edad = Operacion.CalcularEdad(personaSeleccionada);
            string estado = Operacion.MayorEdad(personaSeleccionada);

            lblMayorEdad.Text = $"{personaSeleccionada.Nombre} es {estado}";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombres.Text;
            string apellido = tbApellidos.Text;
            DateTime fechaNac = dtpFecha.Value;
            string ciudad = cmbCiudad.SelectedItem != null ? cmbCiudad.SelectedItem.ToString() : "";

            // Validar que los campos no estén vacíos
            if (nombre.Trim() == "" || apellido.Trim() == "" || ciudad.Trim() == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Crear una nueva persona
            Persona nuevaPersona = new Persona(nombre, apellido, fechaNac, ciudad);

            // Agregar la persona al registro
            bool agregado = registro.AgregarPersona(nuevaPersona);
            if (agregado)
            {
                MessageBox.Show("Persona agregada.");
            }
            else
            {
                MessageBox.Show("El registro está lleno.");
            }
        }
    }
}
