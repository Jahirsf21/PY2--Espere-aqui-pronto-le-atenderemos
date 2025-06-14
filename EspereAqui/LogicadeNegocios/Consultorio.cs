using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspereAqui.LogicadeNegocios
{
    public class Consultorio {

        private static int nextId = 1;
        public int Id { get; private set; }
        public int TiempoConsulta { get; set; }
        public List<Especialidad> Especialidades {  get; set; }
        public List<Paciente> Pacientes { get; set; } //la fila
        public Paciente? pacienteActual { get; set; }
        public bool Estado;

        public Consultorio() { 
            Id = nextId++;
            Especialidades = new List<Especialidad>();
            Pacientes = new List<Paciente>();
            pacienteActual = null;
            Estado = false;
        }

        public void AgregarEspecialidad(Especialidad especialidad)
        {
            if (especialidad != null && !Especialidades.Contains(especialidad))
            {
                Especialidades.Add(especialidad);
            }
        }
        public void AgregarPacienteFila(Paciente paciente) {
            if (!Pacientes.Contains(paciente))
            {
                Pacientes.Add(paciente);
            }

        }


        public int ObtenerLongitudFila()
        {
            return this.Pacientes.Count;
        }

        public List<Paciente> OrdenarPacientesPorPrioridad()
        {
            return this.Pacientes.OrderByDescending(paciente => paciente.Prioridad).ToList();
        }

        public async void AtenderPaciente()
        {
            if (Pacientes.Count != 0){
                Pacientes = this.OrdenarPacientesPorPrioridad();
                pacienteActual = this.Pacientes[0];
                Pacientes.Remove(pacienteActual);
                await Task.Delay(1000 * this.TiempoConsulta / 10);
            }
                pacienteActual = null;
        }


        public override string ToString()
        {
            string especialidadesStr = Especialidades.Any()
                ? string.Join(", ", Especialidades.Select(e => e.nombre))
                : "Sin especialidad";
            string estadoStr = Estado ? "Abierto" : "Cerrado";
            int horas = TiempoConsulta / 60;
            int minutos = TiempoConsulta % 60;
            return $"ID: {Id} | Esp: {especialidadesStr} | Tiempo: {horas:00}h {minutos:00}m | Estado: {estadoStr}";
        }
    }
}

