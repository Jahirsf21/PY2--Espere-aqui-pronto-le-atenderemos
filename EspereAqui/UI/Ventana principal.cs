using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void button1_Click(object sender, EventArgs e) // ir a modos
        {
            if (ventanaModos == null || ventanaModos.IsDisposed)
            {
                ventanaModos = new Ventana_modos(this);
                ventanaModos.StartPosition = FormStartPosition.CenterScreen;
            }
            ventanaModos.Show();
            this.Hide();
        }
    }
}
