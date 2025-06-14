using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspereAqui.LogicadeNegocios
{
    public class Paciente 
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Genero { get; set; }
        public bool Estado { get; set; }
        public int Prioridad { get; set; }

        public List<Especialidad> Especialidades { get; set; }

        public Paciente(string nombre, string apellido, string genero, List<Especialidad> especialidades)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;   
            this.Genero = genero;
            this.Especialidades = especialidades ?? new List<Especialidad>();
        } 

        public Paciente(string nombre, string apellido, string genero, Especialidad especialidad) 
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Genero = genero;
            this.Especialidades = new List<Especialidad> { especialidad };
        }

        public override string ToString()
        {
            string especialidadesStr = this.Especialidades.Any()
                ? string.Join(", ", this.Especialidades.Select(e => e.nombre))
                : "Ninguna";

            return $"Paciente: {Nombre} {Apellido}, Género: {Genero}, Especialidades: {especialidadesStr}";
        }
    }
}