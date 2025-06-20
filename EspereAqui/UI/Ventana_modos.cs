using System;
using System.Drawing;
using System.Windows.Forms;
using EspereAqui.LogicadeNegocios;

namespace EspereAqui.UI
{
    
    //Window to select the clinic simulation mode (manual or automatic).
    //Allows you to navigate between the main window and the simulation window.
    public partial class Ventana_modos : Form
    {
        private Ventana_principal principal;
        private Ventana_simulacion simulacion;
        private Clinica clinica;

        //Class constructor
        public Ventana_modos(Ventana_principal principal, Clinica clinica)
        {
            InitializeComponent();
            this.principal = principal;
            this.clinica = clinica;
            this.DoubleBuffered = true;
        }


        //Event that fires when the window loads.
        //Configures the location and double buffering of the main panel to improve graphics performance.
        private void Ventana_modos_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.Location = new Point(0, 0);
            pictureBox1.Controls.Add(tableLayoutPanel1);
            typeof(TableLayoutPanel).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)?.SetValue(tableLayoutPanel1, true, null);
        }

        //Back button event.
        //Shows the main window and hides the modes window.
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            principal.Show();
            principal.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
        }

        //Manual Mode button event.
        //Opens the simulation window in manual mode.
        private void btnModoManual_Click(object sender, EventArgs e)
        {
            AbrirSimulacion("manual");
        }

        //Automatic Mode button event.
        //Opens the simulation window in Automatic mode.
        private void btnModoAuto_Click(object sender, EventArgs e)
        {
            AbrirSimulacion("auto");
        }

        //Helper method to open the simulation window in the specified mode.
        //If the simulation window does not exist or is closed, creates and displays it.
        private void AbrirSimulacion(string modo)
        {
            if (simulacion == null || simulacion.IsDisposed)
            {
                simulacion = new Ventana_simulacion(this, this.clinica, modo);
                simulacion.StartPosition = FormStartPosition.CenterScreen;
            }
            simulacion.Show();
            this.Hide();
        }

    }
}
