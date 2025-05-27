using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspereAqui.LogicadeNegocios
{
    public class Paciente {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Estado { get; set; }
        public int Prioridad { get; set; }

        public Especialidad especialidad;

        public Paciente(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;   
            //asignar automaticamente
        } 

        public Paciente(string nombre, string apellido, Especialidad especialidad) {
            this.Nombre= nombre;
            this.Apellido = apellido;
            this.especialidad = especialidad;
        }

    }
}
