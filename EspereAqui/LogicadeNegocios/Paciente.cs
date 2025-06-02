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
        public string Genero { get; set; }
        public bool Estado { get; set; }
        public int Prioridad { get; set; }
        public Especialidad especialidad { get; set; }

        public Paciente(string nombre, string apellido, string genero, List<Especialidad> especialidades)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;   
            this.Genero = genero;
            Random rand = new Random();
            int RandNum = rand.Next(especialidades.Count);
            this.especialidad = especialidades[RandNum];
        } 

        public Paciente(string nombre, string apellido,string genero, Especialidad especialidad) {
            this.Nombre= nombre;
            this.Apellido = apellido;
            this.Genero = genero;
            this.especialidad = especialidad;
        }

        public override string ToString()
        {
            return $"Paciente: {Nombre} {Apellido}, Género: {Genero}, Especialidad: {especialidad?.nombre ?? "Ninguna"}";
        }

    }
}
