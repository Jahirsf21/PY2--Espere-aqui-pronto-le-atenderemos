using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspereAqui.LogicadeNegocios
{
    public class Paciente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Genero { get; set; }
        public int Prioridad { get; set; }
        public bool estado { get; set; } 
        public bool mutado{ get; set; }

        public List<EspecialidadPendiente> EspecialidadesPendientes { get; set; }

        public Paciente(string nombre, string apellido, string genero, List<Especialidad> especialidades)
        {
            Nombre = nombre;
            Apellido = apellido;
            Genero = genero;
            estado = true; 
            Prioridad = 0; 

            EspecialidadesPendientes = especialidades?
                .Select(e => new EspecialidadPendiente(e))
                .ToList() ?? new List<EspecialidadPendiente>();
        }

        public Especialidad ObtenerSiguienteEspecialidad()
        {
            return EspecialidadesPendientes.FirstOrDefault(e => !e.Atendida)?.Especialidad;
        }

        public void MarcarEspecialidadComoAtendida(Especialidad especialidad)
        {
            var esp = EspecialidadesPendientes.FirstOrDefault(e => e.Especialidad.nombre == especialidad.nombre);
            if (esp != null) esp.Atendida = true;
        }

        public bool TieneEspecialidadesPendientes()
        {
            return EspecialidadesPendientes.Any(e => !e.Atendida);
        }

        public override string ToString()
        {
            var pendientes = EspecialidadesPendientes
                .Where(e => !e.Atendida)
                .Select(e => e.Especialidad.nombre);
            string espStr = pendientes.Any() ? string.Join(", ", pendientes) : "Ninguna";
            return $"Paciente: {Nombre} {Apellido}, Género: {Genero}, Pendientes: {espStr}";
        }
    }
}