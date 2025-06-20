using EspereAqui.LogicadeNegocios;
using System;
using System.Collections.Generic; 
using System.Drawing;
using System.Linq; 
using System.Windows.Forms;

namespace EspereAqui.UI.Formularios
{
    //Form for creating new patients in the clinic.
    public partial class CrearPacientes : Form
    {
        private Ventana_simulacion simulacion;
        private Clinica clinica;

        //Class constructor
        public CrearPacientes(Ventana_simulacion simulacion, Clinica clinica)
        {
            InitializeComponent();
            this.simulacion = simulacion;
            this.clinica = clinica;
            this.DoubleBuffered = true;
        }

        //Function CrearPacientes_Load, Event that fires when the form loads.
        // Sets the location and double buffering of the main panel.
        private void CrearPacientes_Load(object sender, EventArgs e)
        {
            mainTableLayoutPanel.Location = new Point(0, 0);
            pictureBox1.Controls.Add(mainTableLayoutPanel);
            typeof(TableLayoutPanel).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)?.SetValue(mainTableLayoutPanel, true, null);
        }

        //Back button event.
        //Shows the simulation window and hides the current form.
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            simulacion.StartPosition = FormStartPosition.CenterScreen;
            simulacion.Show();
            this.Hide();
        }

        //Create Patient button event.
        //Validates the entered data, creates a new patient, and adds them to the clinic's waiting queue.
        //Displays error or confirmation messages as appropriate and updates the interface.
        private void btnCrearPaciente_Click(object sender, EventArgs e)
        {
            string nombre = textBox2.Text.Trim();
            string apellido = textBox1.Text.Trim();
            string genero = comboBox3.Text;

            var especialidadesSeleccionadas = chkLstEspecialidades.CheckedItems.OfType<string>().ToList();

            if (string.IsNullOrWhiteSpace(nombre) || !nombre.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Ingrese un nombre válido (solo letras).", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(apellido) || !apellido.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Ingrese un apellido válido (solo letras).", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(genero))
            {
                MessageBox.Show("Seleccione un género.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (especialidadesSeleccionadas.Count == 0)
            {
                MessageBox.Show("Seleccione al menos una especialidad.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (especialidadesSeleccionadas.Count > 2)
            {
                MessageBox.Show("Puede seleccionar un máximo de 2 especialidades.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (especialidadesSeleccionadas.Contains("Ginecología") && genero != "Mujer")
            {
                MessageBox.Show("La especialidad de Ginecología solo aplica para pacientes de género femenino.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (especialidadesSeleccionadas.Contains("Urología") && genero != "Hombre")
            {
                MessageBox.Show("La especialidad de Urología solo aplica para pacientes de género masculino.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Especialidad> listaDeEspecialidades = especialidadesSeleccionadas.Select(nombreEsp => new Especialidad(nombreEsp)).ToList();

            Paciente paciente = new Paciente(nombre, apellido, genero, listaDeEspecialidades);
            simulacion.LogMessage($"INGRESO: Paciente {paciente.Nombre} {paciente.Apellido} ha sido creado");
            this.clinica.AgregarPacienteFila(paciente);
            richTextBox1.AppendText(paciente.ToString() + Environment.NewLine);
            MessageBox.Show("Paciente creado exitosamente y añadido a la fila de espera.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox2.Clear();
            textBox1.Clear();
            comboBox3.SelectedIndex = -1;
            for (int i = 0; i < chkLstEspecialidades.Items.Count; i++)
            {
                chkLstEspecialidades.SetItemChecked(i, false);
            }
            simulacion.ActualizarVistasCompletas();
        }
    }
}