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
        private string modoSimulacion;

        private CrearPacientes formCrearPacientes;
        private GestionarConsultorios formGestionarConsultorios;

        public Ventana_simulacion(Clinica clinica, string modo)
        {
            InitializeComponent();
            this.clinica = clinica;
            this.modoSimulacion = modo;
        }

        private Ventana_simulacion()
        {
            InitializeComponent();
        }

        private void Ventana_simulacion_Load(object sender, EventArgs e)
        {
            ActualizarVistasCompletas();
        }

        private void Ventana_simulacion_Activated(object sender, EventArgs e)
        {
            ActualizarVistasCompletas();
        }
        
        private void ActualizarVistasCompletas()
        {
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

                PictureBox picConsultorio = new PictureBox
                {
                    Image = Properties.Resources.consultorio,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Top,
                    Height = 50
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
                
                panelTarjetaConsultorio.Controls.Add(lblIdConsultorio); 
                panelTarjetaConsultorio.Controls.Add(picConsultorio);   

                FlowLayoutPanel pnlFilaDelConsultorio = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    FlowDirection = FlowDirection.TopDown,
                    AutoScroll = true,
                    WrapContents = false,
                    BackColor = Color.Transparent
                };
                panelTarjetaConsultorio.Controls.Add(pnlFilaDelConsultorio);

                foreach (var paciente in consultorio.Pacientes)
                {
                    Panel pacienteMiniPanel = new Panel {
                        Width = pnlFilaDelConsultorio.ClientSize.Width - 5,
                        Height = 45,
                        BackColor = Color.FromArgb(80, 255, 255, 255),
                        Margin = new Padding(0, 2, 0, 2)
                    };
                    string especialidadesStr = string.Join("\n", paciente.Especialidades.Select(e => e.nombre));
                    
                    Label lblPacienteInfo = new Label {
                        Text = $"{paciente.Nombre}\n{especialidadesStr}", // Usamos la nueva cadena
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Segoe UI", 7F)
                    };
                    pacienteMiniPanel.Controls.Add(lblPacienteInfo);
                    pnlFilaDelConsultorio.Controls.Add(pacienteMiniPanel);
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

        private void ActualizarFilaPacientes()
        {
            pnlFilaPacientes.SuspendLayout();
            pnlFilaPacientes.Controls.Clear();

            foreach (var paciente in clinica.FilaClinica)
            {
                string especialidadesStr = string.Join(", ", paciente.Especialidades.Select(e => e.nombre));
                
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
    }
}