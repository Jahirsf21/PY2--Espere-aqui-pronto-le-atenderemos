using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspereAqui.LogicadeNegocios
{
    public class Consultorio {
        public int Id { get; set; }
        public int TiempoConsulta { get; set; }
        public List<Especialidad> Especialidades {  get; set; }
        public List<Paciente> Pacientes { get; set; } //la fila
        public Paciente pacienteActual { get; set; }
        public bool Estado;

        public Consultorio() { 
            Especialidades = new List<Especialidad>();
            Pacientes = new List<Paciente>();
            Estado= false;
        }

        public void AgregarEspecialidad(Especialidad especialidad) {
            if (especialidad != null && !Especialidades.Contains(especialidad)) {
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

        public void AtenderPaciente()
        {
            if (Pacientes.Count != 0){
                pacienteActual = OrdenarPacientesPorPrioridad()[0]; 
                Pacientes.Remove(pacienteActual); //se puede cambiar por ordenar la fila por prioridad y atendiendo al primero
            }
            else{
                pacienteActual = null; 
            }
        }



    }
}
