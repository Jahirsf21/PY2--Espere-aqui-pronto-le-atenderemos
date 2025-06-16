using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspereAqui.LogicadeNegocios
{
    public class Consultorio 
    {
        private static int nextId = 1;
        public int Id { get; private set; }
        public int TiempoConsulta { get; set; }
        public List<Especialidad> Especialidades { get; set; }
        public List<Paciente> Pacientes { get; set; }
        public Paciente? pacienteActual { get; set; }
        public bool Estado;

        public Consultorio()
        {
            Id = nextId++;
            Especialidades = new List<Especialidad>();
            Pacientes = new List<Paciente>();
            pacienteActual = null;
            Estado = false;
        }

        public Consultorio(List<Especialidad> especialidades, List<Paciente> pacientes)
        {
            Id = nextId++;
            Especialidades = especialidades;
            Pacientes = pacientes;
            pacienteActual = null;
            Estado = true;
        }

        public void AgregarEspecialidad(Especialidad especialidad)
        {
            if (especialidad != null && !Especialidades.Any(e => e.nombre == especialidad.nombre))
            {
                Especialidades.Add(especialidad);
            }
        }

        public void AgregarPacienteFila(Paciente paciente)
        {
            if (!Pacientes.Contains(paciente))
            {
                Pacientes.Add(paciente);
            }
        }

        public bool Contiene(Especialidad especialidad){
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

        public int ObtenerLongitudFila()
        {
            return this.Pacientes.Count;
        }

        public List<Paciente> OrdenarPacientesPorPrioridad()
        {
            return this.Pacientes.OrderByDescending(paciente => paciente.Prioridad).ToList();
        }

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

        public override string ToString()
        {
            string especialidadesStr = Especialidades.Any()
                ? string.Join(", ", Especialidades.Select(e => e.nombre))
                : "Sin especialidad";
            string estadoStr = Estado ? "Abierto" : "Cerrado";
            string pacienteActualStr = (pacienteActual != null)
                ? $"{pacienteActual.Nombre} {pacienteActual.Apellido}".Trim()
                : "Libre";

            int tiempoToShow = 0;
            if (pacienteActual != null)
            {
                tiempoToShow = this.TiempoConsulta;
            }
            else if (Especialidades.Any())
            {
                tiempoToShow = (int)Especialidades.Average(e => e.tiempoConsulta);
            }

            int horas = tiempoToShow / 60;
            int minutos = tiempoToShow % 60;
            
            return $"ID: {Id} | Esp: {especialidadesStr} | T. Est: {horas:00}h {minutos:00}m | Estado: {estadoStr} | Atendiendo: {pacienteActualStr}";
        }
    }
}