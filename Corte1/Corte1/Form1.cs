using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte1
{
    public partial class Form1 : Form
    {
        private List<Persona> personas;

        public Form1()
        {
            InitializeComponent();
            personas = new List<Persona>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombres = tbNombres.Text;
            string apellidos = tbApellidos.Text;
            DateTime fechaNacimiento = dtpFechaNac.Value;
            string ciudad = cmbCiudad.SelectedItem.ToString();

            Persona persona = new Persona(nombres, apellidos, fechaNacimiento, ciudad);
            personas.Add(persona);

            tbNombres.Clear();
            tbApellidos.Clear();
            dtpFechaNac.Value = DateTime.Now;
            cmbCiudad.SelectedIndex = -1;
        }

        private void btnMostrarEdad_Click(object sender, EventArgs e)
        {
            if (personas.Count > 0)
            {
                Persona ultimaPersona = personas[personas.Count - 1];
                int edad = CalcularEdad(ultimaPersona.FechaNacimiento);

                MessageBox.Show($"La edad de {ultimaPersona.Nombres} {ultimaPersona.Apellidos} es {edad} años.", "Edad", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (edad >= 18)
                {
                    MessageBox.Show("Es mayor de edad.", "Mayor de Edad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Es menor de edad.", "Menor de Edad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No hay personas registradas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            if (fechaActual.Month < fechaNacimiento.Month || (fechaActual.Month == fechaNacimiento.Month && fechaActual.Day < fechaNacimiento.Day))
            {
                edad--;
            }

            return edad;
        }
    }

    public class Persona
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ciudad { get; set; }

        public Persona(string nombres, string apellidos, DateTime fechaNacimiento, string ciudad)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            Ciudad = ciudad;
        }
    }
}
