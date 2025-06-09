using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using EspereAqui.UI.Formularios;
using EspereAqui.LogicadeNegocios;

namespace EspereAqui.UI
{
    public partial class Ventana_simulacion : Form
    {
        private CrearPacientes crearPacientes;
        private Clinica clinica;

        public Ventana_simulacion()
        {
            this.clinica = new Clinica();
            InitializeComponent();
        }

        public Ventana_simulacion(string modo) { 
            this.clinica = new Clinica();
            InitializeComponent();
        }
        public Ventana_simulacion(CrearPacientes crearPacientes)
        {
            this.clinica = new Clinica();
            InitializeComponent();
            this.crearPacientes = crearPacientes;
        }


    }
}
