using System;
using System.Drawing;
using System.Windows.Forms;
using EspereAqui.LogicadeNegocios;
using EspereAqui.UI.Formularios;
using System.Linq;

namespace EspereAqui.UI
{
    //Main clinic simulation window.
    //Allows you to view and manage offices and patients, control the simulation (start, pause, resume, end),
    // load data from files, and run the genetic or fitness algorithm.
    public partial class Ventana_simulacion : Form
    {
        private Clinica clinica;
        private Ventana_modos modos;
        private bool _isPaused = false;
        private string modoSimulacion;

        private CrearPacientes formCrearPacientes;
        private GestionarConsultorios formGestionarConsultorios;

        private int minutosSimuladosTranscurridos = 0;

        //Class constructor
        //Initializes the interface, assigns the clinic and simulation mode, and configures the logger.
        public Ventana_simulacion(Ventana_modos modos, Clinica clinica, string modo)
        {
            InitializeComponent();
            this.modos = modos;
            this.clinica = clinica;
            this.modoSimulacion = modo;
            this.clinica.Logger = (msg) => LogMessage(msg);
            this.DoubleBuffered = true;

            if (modo == "auto")
            {
                clinica.Automatizar();
            }
        }

        private Ventana_simulacion()
        {
            InitializeComponent();
        }

        //Event that fires when the window loads.
        //Disables buttons based on their initial state and updates views.
        private void Ventana_simulacion_Load(object sender, EventArgs e)
        {
            btnEmpezarGenetico.Enabled = false;
            ActualizarVistasCompletas();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var doubleBufferedProp = typeof(Panel).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            if (doubleBufferedProp != null)
            {
                doubleBufferedProp.SetValue(pnlConsultoriosContainer, true, null);
                doubleBufferedProp.SetValue(pnlFilaPacientes, true, null);
            }
        }

        //Updates all Consultorio and patient views in the interface.
        public void ActualizarVistasCompletas()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(ActualizarVistasCompletas));
                return;
            }
            ActualizarVistaConsultorios();
            ActualizarFilaPacientes();
        }

        //Updates the display of Consultorios and their patients.
        private void ActualizarVistaConsultorios()
        {
            pnlConsultoriosContainer.SuspendLayout();
            pnlConsultoriosContainer.Controls.Clear();

            int consultorioAncho = 100;
            int consultorioAltoTotal = pnlConsultoriosContainer.ClientSize.Height - 40;
            int margen = 15;
            int posX = margen;
            int posY = 20;

            foreach (var consultorio in clinica.Consultorios)
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
                Color pictureBoxBackgroundColor = consultorio.pacienteActual != null ? Color.FromArgb(120, 10, 140, 10) : Color.Transparent;

                PictureBox picConsultorio = new PictureBox
                {
                    Image = Properties.Resources.consultorio,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Top,
                    Height = 50,
                    BackColor = pictureBoxBackgroundColor
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


                string especialidadesConsultorioStr = string.Join("\n", consultorio.Especialidades.Select(e => e.nombre));
                Label lblEspecialidadesConsultorio = new Label
                {
                    Text = especialidadesConsultorioStr,
                    Font = new Font("Segoe UI", 6.5F, FontStyle.Italic),
                    ForeColor = Color.Cyan,
                    Dock = DockStyle.Top,
                    AutoSize = true,
                    MaximumSize = new Size(consultorioAncho, 0),
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
                panelTarjetaConsultorio.Controls.Add(lblEspecialidadesConsultorio);
                panelTarjetaConsultorio.Controls.Add(lblIdConsultorio);
                panelTarjetaConsultorio.Controls.Add(picConsultorio);

                foreach (var paciente in consultorio.Pacientes)
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
                        BackColor = Color.Transparent
                    };

                    if (paciente.Genero == "Mujer")
                    {
                        imgGenero.Image = Properties.Resources.mujer;
                    }
                    else
                    {
                        imgGenero.Image = Properties.Resources.hombre;
                    }
                    pacienteMiniPanel.Controls.Add(lblPacienteInfo);
                    pacienteMiniPanel.Controls.Add(imgGenero);
                    pnlFilaDelConsultorio.Controls.Add(pacienteMiniPanel);
                    ToolTip tipPacienteMini = new ToolTip();
                    string infoToolTipPaciente = $"Paciente: {paciente.Nombre} {paciente.Apellido}\nEspecialidades: {especialidadesStr}\nPrioridad: {paciente.Prioridad}";
                    tipPacienteMini.SetToolTip(pacienteMiniPanel, infoToolTipPaciente);
                    tipPacienteMini.SetToolTip(imgGenero, infoToolTipPaciente);
                    tipPacienteMini.SetToolTip(lblPacienteInfo, infoToolTipPaciente);
                }

                ToolTip tipConsultorio = new ToolTip();
                string infoToolTip = consultorio.ToString().Replace(" | ", Environment.NewLine);
                tipConsultorio.SetToolTip(panelTarjetaConsultorio, infoToolTip);
                tipConsultorio.SetToolTip(picConsultorio, infoToolTip);
                tipConsultorio.SetToolTip(lblIdConsultorio, infoToolTip);

                pnlConsultoriosContainer.Controls.Add(panelTarjetaConsultorio);
                posX += consultorioAncho + margen;
            }

            pnlConsultoriosContainer.ResumeLayout();
        }

        //Updates the display of the general patient queue.
        private void ActualizarFilaPacientes()
        {
            pnlFilaPacientes.SuspendLayout();
            pnlFilaPacientes.Controls.Clear();

            foreach (var paciente in clinica.FilaClinica)
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
                int panelWidth = Math.Max(80, textSize.Width + 10);
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
                    BackColor = Color.Transparent
                };
                if (paciente.Genero == "Mujer")
                {
                    imgGenero.Image = Properties.Resources.mujer;
                }
                else
                {
                    imgGenero.Image = Properties.Resources.hombre;
                }
                ToolTip tipPaciente = new ToolTip();
                string infoToolTip = $"Paciente: {paciente.Nombre} {paciente.Apellido}\nEspecialidades: {especialidadesStr}\nPrioridad: {paciente.Prioridad}";
                tipPaciente.SetToolTip(pacientePanel, infoToolTip);
                tipPaciente.SetToolTip(imgGenero, infoToolTip);
                tipPaciente.SetToolTip(lblInfo, infoToolTip);

                pacientePanel.Controls.Add(lblInfo);
                pacientePanel.Controls.Add(imgGenero);

                pnlFilaPacientes.Controls.Add(pacientePanel);
            }

            pnlFilaPacientes.ResumeLayout();
        }

        //Adds a message to the simulation log, with support for threads.
        public void LogMessage(string message)
        {
            if (rtbLog.InvokeRequired)
            {
                rtbLog.Invoke(new Action<string>(LogMessage), message);
                return;
            }
            rtbLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}{Environment.NewLine}");
            rtbLog.ScrollToCaret();
        }

        //Start the simulation
        private void IniciarSimulacion()
        {
            btnEmpezarAlgoritmo.Enabled = false;
            btnCargarDatos.Enabled = false;
            btnPausar.Enabled = true;
            btnEmpezarGenetico.Enabled = true;
            minutosSimuladosTranscurridos = 0;
            lblCronometro.Text = "Tiempo: Día 1 - 00:00";
            simulacionTimer.Start();
            ActualizarVistasCompletas();
        }

        //End the simulation
        private void FinalizarSimulacion()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(FinalizarSimulacion));
                return;
            }
            simulacionTimer.Stop();
            btnPausar.Enabled = false;
            btnEmpezarGenetico.Enabled = false;
            btnEmpezarAlgoritmo.Enabled = true;
            btnCargarDatos.Enabled = true;
            btnEmpezarAlgoritmo.Text = "Empezar Simulación";
            _isPaused = false;
            btnPausar.Text = "Pausar";
        }

        //Event to load data from a JSON file.
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

        //Event to open the patient management form.
        private void btnGestionarPacientes_Click(object sender, EventArgs e)
        {
            if (formCrearPacientes == null || formCrearPacientes.IsDisposed)
            {
                formCrearPacientes = new CrearPacientes(this, this.clinica);
            }
            this.Hide();
            formCrearPacientes.Show();
        }

        //Event to open the Consultorio management form.
        private void btnGestionarConsultorios_Click(object sender, EventArgs e)
        {
            if (formGestionarConsultorios == null || formGestionarConsultorios.IsDisposed)
            {
                formGestionarConsultorios = new GestionarConsultorios(this, clinica);
            }
            this.Hide();
            formGestionarConsultorios.Show();
        }

        //Start the simulation
        private void btnEmpezarAlgoritmo_Click(object sender, EventArgs e)
        {
            if (clinica.Consultorios.Any() && clinica.FilaClinica.Any())
            {
                Action callbackActualizarUI = () => ActualizarVistasCompletas();
                Action callbackFinSimulacion = () => FinalizarSimulacion();
                this.clinica.IniciarFitness(callbackActualizarUI, callbackFinSimulacion);
                IniciarSimulacion();
                btnEmpezarAlgoritmo.Text = "Simulación en Curso...";
                LogMessage("Simulación estándar iniciada...");
            }
            else
            {
                LogMessage("No se puede empezar la simulación si no hay consultorios ni pacientes.");
            }
        }

        //Event to execute the genetic algorithm.
        private void btnEmpezarGenetico_Click(object sender, EventArgs e)
        {
            clinica.Genetico();
            ActualizarVistasCompletas();
        }

        //Event to pause or resume the simulation.
        private void btnPausar_Click(object sender, EventArgs e)
        {
            if (!_isPaused)
            {
                clinica.PausarSimulacion();
                simulacionTimer.Stop();
                btnPausar.Text = "Reanudar";
                btnEmpezarGenetico.Enabled = false;
            }
            else
            {
                clinica.ReanudarSimulacion();
                simulacionTimer.Start();
                btnPausar.Text = "Pausar";
                btnEmpezarGenetico.Enabled = true;
            }
            _isPaused = !_isPaused;
            ActualizarVistasCompletas();
        }

        //Event to exit the simulation and return to the modes window.
        private void btnSalir_Click(object sender, EventArgs e)
        {
            simulacionTimer.Stop();
            clinica.DetenerTodosLosProcesos();
            this.modos.Show();
            this.Close();
        }

        //Event that runs when the simulation window is closed.
        //Stops the simulation and cleans up resources.
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            simulacionTimer.Stop();
            clinica.DetenerTodosLosProcesos();
            base.OnFormClosing(e);
        }

        //Simulation timer event.
        //Updates the simulated timer in the interface.
        private void simulacionTimer_Tick(object sender, EventArgs e)
        {
            minutosSimuladosTranscurridos += 5;

            int totalMinutosEnUnDia = 24 * 60;
            int dias = (minutosSimuladosTranscurridos / totalMinutosEnUnDia) + 1;
            int minutosDelDiaActual = minutosSimuladosTranscurridos % totalMinutosEnUnDia;
            int horas = minutosDelDiaActual / 60;
            int minutos = minutosDelDiaActual % 60;

            lblCronometro.Text = $"Tiempo: Día {dias} - {horas:D2}:{minutos:D2}";
        }
    }
}