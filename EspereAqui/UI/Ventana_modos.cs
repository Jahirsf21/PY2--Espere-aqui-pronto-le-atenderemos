using System;
using System.Drawing;
using System.Windows.Forms;
using EspereAqui.LogicadeNegocios;

namespace EspereAqui.UI
{
    public partial class Ventana_modos : Form
    {
        private Ventana_principal principal;
        private Ventana_simulacion simulacion;
        private Clinica clinica;

        public Ventana_modos(Ventana_principal principal, Clinica clinica)
        {
            InitializeComponent();
            this.principal = principal;
            this.clinica = clinica;
        }

        private void Ventana_modos_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.Location = new Point(0, 0);
            pictureBox1.Controls.Add(tableLayoutPanel1);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            principal.Show();
            principal.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
        }

        private void btnModoManual_Click(object sender, EventArgs e)
        {
            AbrirSimulacion("manual");
        }

        private void btnModoAuto_Click(object sender, EventArgs e)
        {
            AbrirSimulacion("auto");
        }


        private void AbrirSimulacion(string modo)
        {
            if (simulacion == null || simulacion.IsDisposed)
            {
                simulacion = new Ventana_simulacion(this.clinica, modo);
                simulacion.StartPosition = FormStartPosition.CenterScreen;
            }
            simulacion.Show();
            this.Hide();
        }

    }
}
