using EspereAqui.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EspereAqui
{
    public partial class Modo_auto : Form
    {
        private Ventana_modos modos;
        public Modo_auto(Ventana_modos modos)
        {
            InitializeComponent();
            this.modos = modos;
        }

        private void button3_Click(object sender, EventArgs e) // Regresar
        {
            modos.StartPosition = FormStartPosition.CenterScreen;
            modos.Show();
            this.Hide();
        }
    }
}
