using EspereAqui.LogicadeNegocios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EspereAqui.UI
{
    //Main window of the clinic application.
    public partial class Ventana_principal : Form
    {
        private Clinica clinica;

        //Class constructor
        public Ventana_principal()
        {
            InitializeComponent();
            clinica = new Clinica();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.DoubleBuffered = true;
        }

        private Ventana_modos ventanaModos;

        //Start button event.
        //Opens the mode selection window and hides the main window.
        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            if (ventanaModos == null || ventanaModos.IsDisposed)
            {
                ventanaModos = new Ventana_modos(this, this.clinica);
                ventanaModos.StartPosition = FormStartPosition.CenterScreen;
            }
            ventanaModos.Show();
            this.Hide();
        }

        //Event that fires when the main window loads.
        //Configures the location and double buffering of the main panel to improve graphics performance.
        private void Ventana_principal_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.Location = new Point(0, 0);
            pictureBox1.Controls.Add(tableLayoutPanel1);
            typeof(TableLayoutPanel).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)?.SetValue(tableLayoutPanel1, true, null);
        }
    }
}
