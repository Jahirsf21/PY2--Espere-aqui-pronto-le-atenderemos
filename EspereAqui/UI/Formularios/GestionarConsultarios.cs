using EspereAqui.LogicadeNegocios;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EspereAqui.UI.Formularios
{
    public partial class GestionarConsultorios : Form
    {
        private const int MAX_CONSULTORIOS = 15;
        private const int MAX_ESPECIALIDADES_POR_CONSULTORIO = 5;

        private Ventana_simulacion simulacion;
        private Clinica clinica;

        public GestionarConsultorios(Ventana_simulacion simulacion, Clinica clinica)
        {
            InitializeComponent();
            this.simulacion = simulacion;
            this.clinica = clinica;
        }

        private void GestionarConsultorios_Load(object sender, EventArgs e)
        {
            mainTableLayoutPanel.Location = new Point(0, 0);
            pictureBox1.Controls.Add(mainTableLayoutPanel);

            nudHoras.Maximum = 2;
            nudMinutos.Maximum = 59;

            CargarEspecialidadesComboBox();
            ActualizarListaConsultorios();
            LimpiarCampos();
        }

        private void CargarEspecialidadesComboBox()
        {
            cmbEspecialidad.Items.Clear();
            cmbEspecialidad.Items.Add("Medicina general");
            cmbEspecialidad.Items.Add("Odontología");
            cmbEspecialidad.Items.Add("Cardiología");
            cmbEspecialidad.Items.Add("Pediatría");
            cmbEspecialidad.Items.Add("Urología");
            cmbEspecialidad.Items.Add("Ginecología");
            cmbEspecialidad.Items.Add("Dermatología");
            cmbEspecialidad.Items.Add("Oftalmología");
            cmbEspecialidad.Items.Add("Nutriólogo");
        }

        private void ActualizarListaConsultorios()
        {
            object selected = cmbConsultorios.SelectedItem;
            cmbConsultorios.Items.Clear();
            foreach (var consultorio in clinica.Consultorios)
            {
                cmbConsultorios.Items.Add(consultorio);
            }
            cmbConsultorios.DisplayMember = "Id";

            if (selected != null && cmbConsultorios.Items.Contains(selected))
            {
                cmbConsultorios.SelectedItem = selected;
            }

            rtbInfoConsultorios.Clear();
            foreach (var consultorio in clinica.Consultorios)
            {
                rtbInfoConsultorios.AppendText(consultorio.ToString() + Environment.NewLine);
            }
        }

        private void LimpiarCampos()
        {
            cmbConsultorios.SelectedIndex = -1;
            cmbEspecialidad.SelectedIndex = -1;
            lstEspecialidadesAgregadas.Items.Clear();
            nudHoras.Value = 0;
            nudMinutos.Value = 30;
            chkEstado.Checked = false;

            // Habilita/deshabilita el botón de crear según el límite
            btnCrear.Enabled = clinica.Consultorios.Count < MAX_CONSULTORIOS;
            btnEditar.Enabled = false; // Se habilita al seleccionar un consultorio
            btnEliminar.Enabled = false;
        }

        private void btnAnadirEspecialidad_Click(object sender, EventArgs e)
        {
            if (cmbEspecialidad.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una especialidad para añadir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (lstEspecialidadesAgregadas.Items.Count >= MAX_ESPECIALIDADES_POR_CONSULTORIO)
            {
                MessageBox.Show($"No se pueden añadir más de {MAX_ESPECIALIDADES_POR_CONSULTORIO} especialidades.", "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string especialidadSeleccionada = cmbEspecialidad.SelectedItem.ToString();
            if (!lstEspecialidadesAgregadas.Items.Contains(especialidadSeleccionada))
            {
                lstEspecialidadesAgregadas.Items.Add(especialidadSeleccionada);
            }
            else
            {
                MessageBox.Show("Esa especialidad ya ha sido añadida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (clinica.Consultorios.Count >= MAX_CONSULTORIOS)
            {
                MessageBox.Show($"No se pueden crear más de {MAX_CONSULTORIOS} consultorios.", "Límite de Consultorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnCrear.Enabled = false;
                return;
            }

            var nuevoConsultorio = new Consultorio();

            int horas = (int)nudHoras.Value;
            int minutos = (int)nudMinutos.Value;
            nuevoConsultorio.TiempoConsulta = (horas * 60) + minutos;
            nuevoConsultorio.Estado = chkEstado.Checked;

            foreach (var item in lstEspecialidadesAgregadas.Items)
            {
                nuevoConsultorio.AgregarEspecialidad(new Especialidad(item.ToString()));
            }

            clinica.AgregarConsultorio(nuevoConsultorio);

            MessageBox.Show("Consultorio creado exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ActualizarListaConsultorios();
            LimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cmbConsultorios.SelectedItem == null) return;

            var consultorioAEditar = (Consultorio)cmbConsultorios.SelectedItem;

            int horas = (int)nudHoras.Value;
            int minutos = (int)nudMinutos.Value;
            consultorioAEditar.TiempoConsulta = (horas * 60) + minutos;
            consultorioAEditar.Estado = chkEstado.Checked;

            consultorioAEditar.Especialidades.Clear();
            foreach (var item in lstEspecialidadesAgregadas.Items)
            {
                consultorioAEditar.AgregarEspecialidad(new Especialidad(item.ToString()));
            }

            MessageBox.Show("Consultorio actualizado.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ActualizarListaConsultorios();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbConsultorios.SelectedItem == null) return;

            var consultorioAEliminar = (Consultorio)cmbConsultorios.SelectedItem;
            var confirmacion = MessageBox.Show($"¿Está seguro de que desea eliminar el Consultorio ID: {consultorioAEliminar.Id}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                clinica.Consultorios.Remove(consultorioAEliminar);
                MessageBox.Show("Consultorio eliminado.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarListaConsultorios();
                LimpiarCampos();
            }
        }

        private void cmbConsultorios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbConsultorios.SelectedItem is Consultorio consultorioSeleccionado)
            {
                lstEspecialidadesAgregadas.Items.Clear();
                foreach (var esp in consultorioSeleccionado.Especialidades)
                {
                    lstEspecialidadesAgregadas.Items.Add(esp.nombre);
                }

                nudHoras.Value = consultorioSeleccionado.TiempoConsulta / 60;
                nudMinutos.Value = consultorioSeleccionado.TiempoConsulta % 60;
                chkEstado.Checked = consultorioSeleccionado.Estado;

                btnCrear.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                LimpiarCampos();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            simulacion.StartPosition = FormStartPosition.CenterScreen;
            simulacion.Show();
            this.Close();
        }
    }
}
