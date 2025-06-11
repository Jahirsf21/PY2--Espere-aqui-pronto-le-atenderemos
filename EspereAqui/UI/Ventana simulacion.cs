using System;
using System.Drawing;
using System.Windows.Forms;
using EspereAqui.LogicadeNegocios;
using EspereAqui.UI.Formularios;

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
            this.Load += new System.EventHandler(this.Ventana_simulacion_Load);
        }

        private Ventana_simulacion()
        {
            InitializeComponent();
        }

        private void Ventana_simulacion_Load(object sender, EventArgs e)
        {
            pictureBox1.Controls.Add(pnlConsultoriosContainer);
            pictureBox1.Controls.Add(pnlBotonesGestion);
            ActualizarVistaConsultorios();
        }
        private void Ventana_simulacion_Activated(object sender, EventArgs e)
        {
            ActualizarVistaConsultorios();
        }

        private void ActualizarVistaConsultorios()
        {
            pnlConsultoriosContainer.Controls.Clear();

            foreach (var consultorio in clinica.Consultorios)
            {
                Panel consultorioPanel = new Panel
                {
                    Width = 150,
                    Height = 150,
                    Margin = new Padding(10),
                    BackColor = Color.Transparent,
                    Tag = consultorio
                };
                PictureBox imgConsultorio = new PictureBox
                {
                    Image = Properties.Resources.consultorio,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Fill,
                    BackColor = Color.Transparent
                };
                Label lblId = new Label
                {
                    Text = consultorio.Id.ToString(),
                    Font = new Font("Segoe UI", 24, FontStyle.Bold),
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(120, 0, 0, 0),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };


                string infoToolTip = consultorio.ToString().Replace(" | ", Environment.NewLine);
                this.toolTipInfo.SetToolTip(consultorioPanel, infoToolTip);
                this.toolTipInfo.SetToolTip(imgConsultorio, infoToolTip);
                this.toolTipInfo.SetToolTip(lblId, infoToolTip);
                imgConsultorio.Controls.Add(lblId);
                consultorioPanel.Controls.Add(imgConsultorio);
                pnlConsultoriosContainer.Controls.Add(consultorioPanel);
            }
        }

        private void btnGestionarPacientes_Click(object sender, EventArgs e)
        {
            if (formCrearPacientes == null || formCrearPacientes.IsDisposed)
            {
                formCrearPacientes = new CrearPacientes(this);
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
