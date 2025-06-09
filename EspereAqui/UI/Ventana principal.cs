using System;
using System.Drawing;
using System.Windows.Forms;

namespace EspereAqui.UI
{
    public partial class Ventana_principal : Form
    {
        public Ventana_principal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private Ventana_modos ventanaModos;
        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            if (ventanaModos == null || ventanaModos.IsDisposed)
            {
                ventanaModos = new Ventana_modos(this);
                ventanaModos.StartPosition = FormStartPosition.CenterScreen;
            }
            ventanaModos.Show();
            this.Hide();
        }

        private void Ventana_principal_Load(object sender, EventArgs e)
        {

            tableLayoutPanel1.Location = new Point(0, 0);
            pictureBox1.Controls.Add(tableLayoutPanel1);
        }
    }
}