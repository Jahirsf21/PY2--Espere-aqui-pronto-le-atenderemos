using System;
using System.Drawing;
using System.Windows.Forms;
using EspereAqui.LogicadeNegocios;
using EspereAqui.UI.Formularios;
using System.Linq;

namespace EspereAqui.UI
{
    public partial class Ventana_simulacion : Form
    {
        private Clinica clinica;
        private Ventana_modos modosForm;
        private bool _isPaused = false;
        private string modoSimulacion;

        private CrearPacientes formCrearPacientes;
        private GestionarConsultorios formGestionarConsultorios;

        public Ventana_simulacion(Ventana_modos modos, Clinica clinica, string modo)
        {
            InitializeComponent();
            this.modosForm = modos;
            this.clinica = clinica;
            this.modoSimulacion = modo;
            this.clinica.Logger = (msg) => LogMessage(msg);

            if (modo == "auto")
            {
                clinica.Automatizar();
            }
        }

        private Ventana_simulacion()
        {
            InitializeComponent();
        }

        private void Ventana_simulacion_Load(object sender, EventArgs e)
        {
            btnEmpezarGenetico.Enabled = false;
            ActualizarVistasCompletas();
        }

        private void ActualizarVistasCompletas()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(ActualizarVistasCompletas));
                return;
            }
            ActualizarVistaConsultorios();
            ActualizarFilaPacientes();
        }

        private void ActualizarVistaConsultorios()
        {
            pnlConsultoriosContainer.SuspendLayout();
            pnlConsultoriosContainer.Controls.Clear();
            int consultorioAncho = 90;
            int consultorioAltoTotal = pnlConsultoriosContainer.ClientSize.Height - 40;
            int margen = 15;
            int posX = margen;
            int posY = 20;

            var consultoriosSnapshot = clinica.Consultorios.ToList();
            foreach (var consultorio in consultoriosSnapshot)
            {
                Panel panelTarjetaConsultorio = new Panel
                {
                    Width = consultorioAncho,
                    Height = consultorioAltoTotal,
                    Location = new Point(posX, posY),
                    BackColor = Color.FromArgb(50, 0, 0, 0),
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = consultorio
                };

                PictureBox picConsultorio = new PictureBox
                {
                    Image = Properties.Resources.consultorio,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Top,
                    Height = 50,
                    BackColor = consultorio.pacienteActual != null ? Color.LightGreen : Color.Transparent
                };

                Label lblIdConsultorio = new Label
                {
                    Text = $"C-{consultorio.Id}",
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                    ForeColor = Color.White,
                    Dock = DockStyle.Top,
                    Height = 25,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                FlowLayoutPanel pnlFilaDelConsultorio = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    FlowDirection = FlowDirection.TopDown,
                    AutoScroll = true,
                    WrapContents = false,
                    BackColor = Color.Transparent,
                    Padding = new Padding(2)
                };

                panelTarjetaConsultorio.Controls.Add(pnlFilaDelConsultorio);
                panelTarjetaConsultorio.Controls.Add(picConsultorio);
                panelTarjetaConsultorio.Controls.Add(lblIdConsultorio);

                foreach (var paciente in consultorio.Pacientes.ToList())
                {
                    Panel pacienteMiniPanel = new Panel
                    {
                        Width = pnlFilaDelConsultorio.ClientSize.Width - 10,
                        Height = 70,
                        BackColor = Color.Transparent,
                        Margin = new Padding(0, 3, 0, 3)
                    };

                    var especialidadActual = paciente.ObtenerSiguienteEspecialidad();
                    string especialidadesStr = especialidadActual != null ? especialidadActual.nombre : "Terminado";

                    Label lblPacienteInfo = new Label
                    {
                        Text = $"{paciente.Nombre}\n{especialidadesStr}",
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Segoe UI", 7F, FontStyle.Bold),
                        ForeColor = Color.White,
                        BackColor = Color.Transparent
                    };
                    PictureBox imgGenero = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Dock = DockStyle.Top,
                        Height = 40,
                        BackColor = Color.Transparent,
                        Image = paciente.Genero == "Mujer" ? Properties.Resources.mujer : Properties.Resources.hombre
                    };

                    pacienteMiniPanel.Controls.Add(lblPacienteInfo);
                    pacienteMiniPanel.Controls.Add(imgGenero);
                    pnlFilaDelConsultorio.Controls.Add(pacienteMiniPanel);

                    ToolTip tipPacienteMini = new ToolTip();
                    string infoToolTipPaciente = $"Paciente: {paciente.Nombre} {paciente.Apellido}\nSiguiente: {especialidadesStr}\nPrioridad: {paciente.Prioridad}";
                    tipPacienteMini.SetToolTip(pacienteMiniPanel, infoToolTipPaciente);
                }

                ToolTip tipConsultorio = new ToolTip();
                string infoToolTip = consultorio.ToString().Replace(" | ", Environment.NewLine);
                tipConsultorio.SetToolTip(panelTarjetaConsultorio, infoToolTip);

                pnlConsultoriosContainer.Controls.Add(panelTarjetaConsultorio);
                posX += consultorioAncho + margen;
            }

            pnlConsultoriosContainer.ResumeLayout();
        }

        private void ActualizarFilaPacientes()
        {
            pnlFilaPacientes.SuspendLayout();
            pnlFilaPacientes.Controls.Clear();

            var filaClinicaSnapshot = clinica.FilaClinica.ToList();
            foreach (var paciente in filaClinicaSnapshot)
            {
                string especialidadesStr = string.Join(", ", paciente.EspecialidadesPendientes.Where(e => !e.Atendida).Select(ep => ep.Especialidad.nombre));

                Label lblInfo = new Label
                {
                    Text = $"{paciente.Nombre}\n{especialidadesStr}",
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 8, FontStyle.Bold),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.Transparent,
                    AutoSize = false
                };
                Size textSize = TextRenderer.MeasureText(lblInfo.Text, lblInfo.Font);
                int panelWidth = Math.Max(80, textSize.Width + 20);
                Panel pacientePanel = new Panel
                {
                    Width = panelWidth,
                    Height = 100,
                    Margin = new Padding(5),
                    BackColor = Color.Transparent
                };
                PictureBox imgGenero = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Top,
                    Height = 60,
                    BackColor = Color.Transparent,
                    Image = paciente.Genero == "Mujer" ? Properties.Resources.mujer : Properties.Resources.hombre
                };

                ToolTip tipPaciente = new ToolTip();
                string infoToolTip = $"Paciente: {paciente.Nombre} {paciente.Apellido}\nEspecialidades: {especialidadesStr}\nPrioridad: {paciente.Prioridad}";
                tipPaciente.SetToolTip(pacientePanel, infoToolTip);

                pacientePanel.Controls.Add(lblInfo);
                pacientePanel.Controls.Add(imgGenero);

                pnlFilaPacientes.Controls.Add(pacientePanel);
            }

            pnlFilaPacientes.ResumeLayout();
        }

        private void LogMessage(string message)
        {
            if (rtbLog.InvokeRequired)
            {
                rtbLog.Invoke(new Action<string>(LogMessage), message);
                return;
            }
            rtbLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}{Environment.NewLine}");
            rtbLog.ScrollToCaret();
        }

        private void IniciarSimulacion()
        {
            btnEmpezarAlgoritmo.Enabled = false;
            btnCargarDatos.Enabled = false;
            btnPausar.Enabled = true;
            btnEmpezarGenetico.Enabled = true;
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos JSON (*.json)|*.json|Todos los archivos (*.*)|*.*";
            openFileDialog1.Title = "Seleccionar archivo de datos";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog1.FileName;
                clinica.CargarDatosDesdeJson(rutaArchivo);
                ActualizarVistasCompletas();
            }
        }

        private void btnGestionarPacientes_Click(object sender, EventArgs e)
        {
            if (formCrearPacientes == null || formCrearPacientes.IsDisposed)
            {
                formCrearPacientes = new CrearPacientes(this, this.clinica);
            }
            this.Hide();
            formCrearPacientes.Show();
        }

        private void btnGestionarConsultorios_Click(object sender, EventArgs e)
        {
            if (formGestionarConsultorios == null || formGestionarConsultorios.IsDisposed)
            {
                formGestionarConsultorios = new GestionarConsultorios(this, clinica);
            }
            this.Hide();
            formGestionarConsultorios.Show();
        }

        private void btnEmpezarAlgoritmo_Click(object sender, EventArgs e)
        {
            Action callbackActualizarUI = () => ActualizarVistasCompletas();
            this.clinica.Fitness(callbackActualizarUI);
            IniciarSimulacion();
            btnEmpezarAlgoritmo.Text = "Simulación en Curso...";
            LogMessage("Simulación estándar iniciada...");
        }

        private void btnEmpezarGenetico_Click(object sender, EventArgs e)
        {

        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            if (!_isPaused)
            {
                clinica.PausarSimulacion();
                btnPausar.Text = "Reanudar";
                btnEmpezarGenetico.Enabled = false;
            }
            else
            {
                clinica.ReanudarSimulacion();
                btnPausar.Text = "Pausar";
                btnEmpezarGenetico.Enabled = true;
            }
            _isPaused = !_isPaused;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (btnPausar.Enabled && !_isPaused)
            {
                clinica.PausarSimulacion();
            }
            clinica.Reiniciar();
            this.modosForm.Show();
            this.Close();
        }
    }
}