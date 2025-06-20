using EspereAqui.LogicadeNegocios;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EspereAqui.UI.Formularios
{
    //Form to manage the clinic's Consultorios.
    //Allows you to create, edit, delete, and view Consultorios, as well as manage their specialties and status (open/closed).
    public partial class GestionarConsultorios : Form
    {
        private const int MAX_CONSULTORIOS = 15;
        private const int MAX_ESPECIALIDADES_POR_CONSULTORIO = 5;

        private Ventana_simulacion simulacion;
        private Clinica clinica;

        //Class constructor
        public GestionarConsultorios(Ventana_simulacion simulacion, Clinica clinica)
        {
            InitializeComponent();
            this.simulacion = simulacion;
            this.clinica = clinica;
            this.DoubleBuffered = true;
        }

        //Event that fires when the form loads.
        //Configures the interface, loads the specialties, and updates the list of Consultorios.
        private void GestionarConsultorios_Load(object sender, EventArgs e)
        {
            mainTableLayoutPanel.Location = new Point(0, 0);
            pictureBox1.Controls.Add(mainTableLayoutPanel);
            typeof(TableLayoutPanel).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)?.SetValue(mainTableLayoutPanel, true, null);

            CargarEspecialidadesComboBox();
            ActualizarListaConsultorios();
            LimpiarCampos();
        }

        // Loads the available specialties in the ComboBox.
        private void CargarEspecialidadesComboBox()
        {
            cmbEspecialidad.Items.Clear();
            foreach (var especialidad in clinica.Especialidades.OrderBy(e => e.nombre))
            {
                cmbEspecialidad.Items.Add(especialidad.nombre);
            }
        }

        //Updates the list of Consultorios in the interface and displays their information.
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
            simulacion.ActualizarVistasCompletas();
        }

        //Clears form fields and resets controls.
        private void LimpiarCampos()
        {
            cmbConsultorios.SelectedIndex = -1;
            cmbEspecialidad.SelectedIndex = -1;
            lstEspecialidadesAgregadas.Items.Clear();
            chkEstado.Checked = false;
            btnCrear.Enabled = clinica.Consultorios.Count < MAX_CONSULTORIOS;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        //Event to add a specialty to the Consultorio being created/edited.
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

        //Event to remove a specialty from the Consultorio list.
        private void btnQuitarEspecialidad_Click(object sender, EventArgs e)
        {
            if (lstEspecialidadesAgregadas.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una especialidad de la lista para quitar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (lstEspecialidadesAgregadas.Items.Count <= 1)
            {
                MessageBox.Show("Un consultorio debe tener al menos una especialidad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstEspecialidadesAgregadas.Items.Remove(lstEspecialidadesAgregadas.SelectedItem);
        }

        //Event to create a new Consultorio with the selected specialties.
        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (clinica.Consultorios.Count >= MAX_CONSULTORIOS)
            {
                MessageBox.Show($"No se pueden crear más de {MAX_CONSULTORIOS} consultorios.", "Límite de Consultorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnCrear.Enabled = false;
                return;
            }

            if (lstEspecialidadesAgregadas.Items.Count == 0)
            {
                MessageBox.Show("Debe añadir al menos una especialidad al consultorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!chkEstado.Checked && clinica.Consultorios.Count(c => c.Estado) == 0)
            {
                MessageBox.Show("No se pueden tener todos los consultorios cerrados. Debe haber al menos uno abierto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevoConsultorio = new Consultorio(clinica.getNextId());
            nuevoConsultorio.Estado = chkEstado.Checked;

            foreach (var item in lstEspecialidadesAgregadas.Items)
            {
                nuevoConsultorio.AgregarEspecialidad(new Especialidad(item.ToString()));
            }

            clinica.AgregarConsultorio(nuevoConsultorio);
            MessageBox.Show("Consultorio creado exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            simulacion.LogMessage($"INGRESO: Consultorio {nuevoConsultorio.Id} ha sido creado");
            ActualizarListaConsultorios();
            simulacion.ActualizarVistasCompletas();
            LimpiarCampos();
        }

        //Event to edit the selected Consultorio, updating its specialties and status.
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cmbConsultorios.SelectedItem == null) return;

            if (lstEspecialidadesAgregadas.Items.Count == 0)
            {
                MessageBox.Show("Debe añadir al menos una especialidad al consultorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var consultorioAEditar = (Consultorio)cmbConsultorios.SelectedItem;

            bool seCierra = consultorioAEditar.Estado && !chkEstado.Checked;

            if (consultorioAEditar.Estado && !chkEstado.Checked && clinica.Consultorios.Count(c => c.Estado) == 1)
            {
                MessageBox.Show("No se puede cerrar el último consultorio abierto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var especialidadesAntes = consultorioAEditar.Especialidades.Select(e => e.nombre).ToList();
            consultorioAEditar.Estado = chkEstado.Checked;
            consultorioAEditar.Especialidades.Clear();
            foreach (var item in lstEspecialidadesAgregadas.Items)
            {
                consultorioAEditar.AgregarEspecialidad(new Especialidad(item.ToString()));
            }
            var especialidadesDespues = consultorioAEditar.Especialidades.Select(e => e.nombre).ToList();
            var especialidadesEliminadas = especialidadesAntes.Except(especialidadesDespues).ToList();

            if (especialidadesEliminadas.Any())
            {
                var pacientesAReordenar = consultorioAEditar.Pacientes
                    .Where(p => p.ObtenerSiguienteEspecialidad() != null && especialidadesEliminadas.Contains(p.ObtenerSiguienteEspecialidad().nombre))
                    .ToList();
                foreach (var paciente in pacientesAReordenar)
                {
                    paciente.Prioridad += 2;
                    clinica.Logger?.Invoke($"REORDEN: Paciente {paciente.Nombre} {paciente.Apellido} recibe +2 prioridad por eliminación de especialidad en consultorio C-{consultorioAEditar.Id}.");
                    clinica.FilaClinica.Add(paciente);
                    consultorioAEditar.Pacientes.Remove(paciente);
                }
                if (pacientesAReordenar.Any())
                {
                    clinica.Logger?.Invoke($"ADMIN: Se eliminaron especialidades en C-{consultorioAEditar.Id}. Pacientes devueltos a la fila general.");
                }
            }
            if (seCierra)
            {
                foreach (var paciente in consultorioAEditar.Pacientes.ToList())
                {
                    paciente.Prioridad += 2;
                    clinica.Logger?.Invoke($"REORDEN: Paciente {paciente.Nombre} {paciente.Apellido} recibe +2 prioridad por cierre de consultorio C-{consultorioAEditar.Id}.");
                }
                clinica.FilaClinica.AddRange(consultorioAEditar.Pacientes);
                clinica.Logger?.Invoke($"ADMIN: Se ha cerrado el consultorio C-{consultorioAEditar.Id}. Pacientes devueltos a la fila general.");
                consultorioAEditar.Pacientes.Clear();
            }

            MessageBox.Show("Consultorio actualizado.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizarListaConsultorios();
            simulacion.ActualizarVistasCompletas();
            LimpiarCampos();
        }

        //Event to delete the selected Consultorio, with validations.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbConsultorios.SelectedItem == null) return;

            var consultorioAEliminar = (Consultorio)cmbConsultorios.SelectedItem;

            if (consultorioAEliminar.Estado && clinica.Consultorios.Count(c => c.Estado) == 1)
            {
                MessageBox.Show("No se puede eliminar el último consultorio abierto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show($"¿Está seguro de que desea eliminar el Consultorio ID: {consultorioAEliminar.Id}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                clinica.EliminarConsultorio(consultorioAEliminar);
                MessageBox.Show("Consultorio eliminado.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarListaConsultorios();
                LimpiarCampos();
            }
        }


        //Event that fires when a practice is selected from the list.
        //Loads its specialties and status into the form controls.
        private void cmbConsultorios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbConsultorios.SelectedItem is Consultorio consultorioSeleccionado)
            {
                lstEspecialidadesAgregadas.Items.Clear();
                foreach (var esp in consultorioSeleccionado.Especialidades)
                {
                    lstEspecialidadesAgregadas.Items.Add(esp.nombre);
                }
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

        //Event to clear all form fields.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        //Event to return to the simulation window and close the current form.
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            simulacion.StartPosition = FormStartPosition.CenterScreen;
            simulacion.Show();
            this.Close();
        }
    }
}