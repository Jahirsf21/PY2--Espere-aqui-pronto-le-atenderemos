using EspereAqui.LogicadeNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EspereAqui.UI
{
    public partial class Ventana_manual : Form
    {
        private Ventana_modos modos;
        public Ventana_manual(Ventana_modos modos)
        {
            InitializeComponent();
            this.modos = modos;
        }

        private void button1_Click(object sender, EventArgs e) // regresar
        {
            modos.StartPosition = FormStartPosition.CenterScreen;
            modos.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nombre = textBox2.Text.Trim();
            string apellido = textBox1.Text.Trim();
            string genero = comboBox3.Text;
            string especialidadTexto = comboBox2.Text;

            if (string.IsNullOrWhiteSpace(nombre) || !nombre.All(char.IsLetter))
            {
                MessageBox.Show("Ingrese un nombre válido (solo letras).");
                return;
            }

            if (string.IsNullOrWhiteSpace(apellido) || !apellido.All(char.IsLetter))
            {
                MessageBox.Show("Ingrese un apellido válido (solo letras).");
                return;
            }

            if (string.IsNullOrWhiteSpace(genero))
            {
                MessageBox.Show("Seleccione un género.");
                return;
            }

            if (string.IsNullOrWhiteSpace(especialidadTexto))
            {
                MessageBox.Show("Seleccione una especialidad.");
                return;
            }

            if (especialidadTexto == "Ginecología" && genero.ToLower() != "femenino")
            {
                MessageBox.Show("La especialidad de Ginecología solo aplica para pacientes de género femenino.");
                return;
            }

            if (especialidadTexto == "Urología" && genero.ToLower() != "masculino")
            {
                MessageBox.Show("La especialidad de Urología solo aplica para pacientes de género masculino.");
                return;
            }

            Especialidad especialidad = new Especialidad(especialidadTexto);
            Paciente paciente = new Paciente(nombre, apellido, genero, especialidad);
            richTextBox1.AppendText(paciente.ToString() + "\n");

            textBox2.Clear();
            textBox1.Clear();
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }
    }



}
