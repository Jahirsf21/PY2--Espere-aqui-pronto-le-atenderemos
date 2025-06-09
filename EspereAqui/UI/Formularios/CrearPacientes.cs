using EspereAqui.LogicadeNegocios; 
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using EspereAqui.UI;

namespace EspereAqui.UI.Formularios
{
    public partial class CrearPacientes : Form
    {
        private Ventana_simulacion simulacion;
        public CrearPacientes(Ventana_simulacion simulacion)
        {
            InitializeComponent();
            this.simulacion = simulacion;
        }

        private void CrearPacientes_Load(object sender, EventArgs e)
        {
            mainTableLayoutPanel.Location = new Point(0, 0);
            pictureBox1.Controls.Add(mainTableLayoutPanel);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            simulacion.StartPosition = FormStartPosition.CenterScreen;
            simulacion.Show();
            this.Hide();
        }

        private void btnCrearPaciente_Click(object sender, EventArgs e)
        {
            string nombre = textBox2.Text.Trim();
            string apellido = textBox1.Text.Trim();
            string genero = comboBox3.Text;
            string especialidadTexto = comboBox2.Text;

            if (string.IsNullOrWhiteSpace(nombre) || !nombre.All(char.IsLetter))
            {
                MessageBox.Show("Ingrese un nombre válido (solo letras).", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(apellido) || !apellido.All(char.IsLetter))
            {
                MessageBox.Show("Ingrese un apellido válido (solo letras).", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(genero))
            {
                MessageBox.Show("Seleccione un género.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(especialidadTexto))
            {
                MessageBox.Show("Seleccione una especialidad.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (especialidadTexto == "Ginecología" && genero != "Mujer")
            {
                MessageBox.Show("La especialidad de Ginecología solo aplica para pacientes de género femenino.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (especialidadTexto == "Urología" && genero != "Hombre")
            {
                MessageBox.Show("La especialidad de Urología solo aplica para pacientes de género masculino.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Especialidad especialidad = new Especialidad(especialidadTexto);
            Paciente paciente = new Paciente(nombre, apellido, genero, especialidad);
            richTextBox1.AppendText(paciente.ToString() + Environment.NewLine);

            MessageBox.Show("Paciente creado exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox2.Clear();
            textBox1.Clear();
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }
    }
}