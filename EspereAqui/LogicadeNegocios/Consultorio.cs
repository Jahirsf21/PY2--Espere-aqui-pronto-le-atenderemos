using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspereAqui.LogicadeNegocios
{
    //Class Consultorio
    //Manage your specialties, patient queue, current patient in care, and their status (open/closed).
    //Allows you to add specialties and patients, and manage patients by priority and specialty.
    public class Consultorio
    {
        public int Id { get; private set; }
        public int TiempoConsulta { get; set; }
        public List<Especialidad> Especialidades { get; set; }
        public List<Paciente> Pacientes { get; set; }
        public Paciente? pacienteActual { get; set; }
        public bool Estado;


        //Class constructor
        public Consultorio(int id)
        {
            Id = id;
            Especialidades = new List<Especialidad>();
            Pacientes = new List<Paciente>();
            pacienteActual = null;
            Estado = false;
        }

        //Class constructor
        public Consultorio(List<Especialidad> especialidades, List<Paciente> pacientes, int id)
        {
            Id = id;
            Especialidades = especialidades;
            Pacientes = pacientes;
            pacienteActual = null;
            Estado = true;
        }

        //Function AgregarEspecialidad, Add a specialty to the Consultorio list of specialties.
        public void AgregarEspecialidad(Especialidad especialidad)
        {
            if (especialidad != null && !Especialidades.Any(e => e.nombre == especialidad.nombre))
            {
                Especialidades.Add(especialidad);
            }
        }

        //Function AgregarPacienteFila, Add a patient to the Consultorio patient list.
        public void AgregarPacienteFila(Paciente paciente)
        {
            if (!Pacientes.Contains(paciente))
            {
                Pacientes.Add(paciente);
            }
        }

        //Function ObtenerCantidadPacientesEspecialidad, return the number of patients in the queue whose specialty corresponds to the entry's specialty.
        public int ObtenerCantidadPacientesEspecialidad(Especialidad especialidad)
        {
            int cantidadPacientes = 0;
            foreach (Paciente pac in Pacientes)
            {
                if (pac.EspecialidadesPendientes[0].Especialidad == especialidad)
                {
                    cantidadPacientes++;
                }
            }
            return cantidadPacientes;
        }

        //Function Contiene, determines whether a specialty is already on the practice's specialty list or not.
        public bool Contiene(Especialidad especialidad)
        {
            if (!this.Estado) return false;
            foreach (Especialidad esp in this.Especialidades)
            {
                if (esp.nombre == especialidad.nombre)
                {
                    return true;
                }
            }
            return false;
        }


        //Function ObtenerLongitudFila, Returns the number of patients in the queue
        public int ObtenerLongitudFila()
        {
            return this.Pacientes.Count;
        }

        //Function OrdenarPacientesPorPrioridad, Sort the Consultorio's patient list by highest priority.
        public List<Paciente> OrdenarPacientesPorPrioridad()
        {
            return this.Pacientes.OrderByDescending(paciente => paciente.Prioridad).ToList();
        }

        //Function AtenderPaciente, Sees the next patient in the Consultorio queue based on their priority and pending specialty.
        //If the Consultorio cannot see the specialty, raises the patient's priority and returns them to the general queue.
        //Simulates the appointment time asynchronously, marks the specialty as attended, and updates the patient's status.
        //Calls callbacks to log events and notify the completion of the appointment.
        public async void AtenderPaciente(Action<Paciente> onConsultaTerminada, Action<string> logger)
        {
            if (pacienteActual != null || Pacientes.Count == 0)
                return;

            Pacientes = OrdenarPacientesPorPrioridad();
            pacienteActual = Pacientes[0];
            Pacientes.Remove(pacienteActual);

            var pacienteSiendoAtendido = pacienteActual;
            Especialidad actual = pacienteSiendoAtendido.ObtenerSiguienteEspecialidad();

            if (actual != null && !this.Especialidades.Any(e => e.nombre == actual.nombre))
            {
                pacienteSiendoAtendido.Prioridad += 2;
                logger?.Invoke($"REORDEN: Paciente {pacienteSiendoAtendido.Nombre} {pacienteSiendoAtendido.Apellido} devuelto a la fila general (+2 prioridad) porque C-{Id} no atiende {actual.nombre}.");
                pacienteActual = null;
                onConsultaTerminada?.Invoke(pacienteSiendoAtendido);
                return;
            }
            if (actual != null)
            {
                TiempoConsulta = actual.tiempoConsulta;

                logger?.Invoke($"ATENDIENDO: C-{Id} empieza a atender a {pacienteSiendoAtendido.Nombre} para {actual.nombre}.");

                onConsultaTerminada?.Invoke(null);

                await Task.Delay(1000 * TiempoConsulta / 5);

                pacienteSiendoAtendido.MarcarEspecialidadComoAtendida(actual);

                if (pacienteSiendoAtendido.TieneEspecialidadesPendientes())
                {
                    logger?.Invoke($"RE-ENCOLADO: {pacienteSiendoAtendido.Nombre} terminó {actual.nombre} en C-{Id}. Regresa a la fila general.");
                    pacienteSiendoAtendido.estado = false;
                    pacienteSiendoAtendido.Prioridad++;
                }
                else
                {
                    pacienteSiendoAtendido.estado = true;
                }
            }
            pacienteActual = null;
            onConsultaTerminada?.Invoke(pacienteSiendoAtendido);
        }


        //Function toString, Returns a text string containing the office's information, including its ID, specialties, estimated consultation time,
        //status (open/closed), and the patient being seen (if there is one).
        public override string ToString()
        {
            string especialidadesStr = Especialidades.Any() ? string.Join(", ", Especialidades.Select(e => e.nombre)) : "Sin especialidad";
            string estadoStr = Estado ? "Abierto" : "Cerrado";
            string pacienteActualStr = (pacienteActual != null)? $"{pacienteActual.Nombre} {pacienteActual.Apellido}".Trim() : "Libre";
            int tiempoAMostrar = 0;
            if (pacienteActual != null)
            {
                tiempoAMostrar = this.TiempoConsulta;
            }
            else if (Especialidades.Any())
            {
                tiempoAMostrar  = (int)Especialidades.Average(e => e.tiempoConsulta);
            }
            int horas = tiempoAMostrar  / 60;
            int minutos = tiempoAMostrar  % 60;
            return $"ID: {Id} | Esp: {especialidadesStr} | T. Est: {horas:00}h {minutos:00}m | Estado: {estadoStr} | Atendiendo: {pacienteActualStr}";
        }
    }
}