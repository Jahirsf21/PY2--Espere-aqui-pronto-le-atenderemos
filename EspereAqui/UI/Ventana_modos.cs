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


    public partial class Ventana_modos : Form
    {
        private Ventana_principal principal;
        private Modo_auto auto;
        private Ventana_manual manual;
        public Ventana_modos(Ventana_principal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void button3_Click(object sender, EventArgs e) // Regresar
        {
            principal.Show();
            principal.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
        }


        private void button2_Click(object sender, EventArgs e) // Manual
        {
            if (manual == null || manual.IsDisposed)
            {
                manual = new Ventana_manual(this);
                manual.StartPosition = FormStartPosition.CenterScreen;
            }
            manual.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) // auto
        {
            if (auto == null || auto.IsDisposed)
            {
                auto = new Modo_auto(this);
                auto.StartPosition = FormStartPosition.CenterScreen;
            }
            auto.Show();
            this.Hide();
        }
    }
}
