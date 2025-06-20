using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspereAqui.LogicadeNegocios
{
    //Class paciente
    public class Paciente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Genero { get; set; }
        public int Prioridad { get; set; }
        public bool estado { get; set; }
        public bool mutado { get; set; }

        public List<EspecialidadPendiente> EspecialidadesPendientes { get; set; }

        //Class constructor
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


        //Function ObtenerSiguienteEspecialidad, Returns the next specialty pending attention for the patient.
        public Especialidad ObtenerSiguienteEspecialidad()
        {
            return EspecialidadesPendientes.FirstOrDefault(e => !e.Atendida)?.Especialidad;
        }
    
        //Function MarcarEspecialidadComoAtendida,Mark the specialty indicated on the patient's list of pending specialties as treated.
        public void MarcarEspecialidadComoAtendida(Especialidad especialidad)
        {
            var esp = EspecialidadesPendientes.FirstOrDefault(e => e.Especialidad.nombre == especialidad.nombre);
            if (esp != null) esp.Atendida = true;
        }
        
        //Function cambiarOrdenEspecialidades, Swap the order of the two pending specialties on the patient's list.
        public void cambiarOrdenEspecialidades()
        {
            (this.EspecialidadesPendientes[0], this.EspecialidadesPendientes[1]) = (this.EspecialidadesPendientes[1], this.EspecialidadesPendientes[0]);
        }

        //Function TieneEspecialidadesPendientes, Indicates whether the patient has at least one specialty pending care.
        public bool TieneEspecialidadesPendientes()
        {
            return EspecialidadesPendientes.Any(e => !e.Atendida);
        }


        //Function toString, returns a text string with the patient's information, including their name, gender, and the specialties pending care.
        public override string ToString()
        {
            var pendientes = EspecialidadesPendientes.Where(e => !e.Atendida).Select(e => e.Especialidad.nombre);
            string espStr = pendientes.Any() ? string.Join(", ", pendientes) : "Ninguna";
            return $"Paciente: {Nombre} {Apellido}, Género: {Genero}, Pendientes: {espStr}";
        }
    }
}