using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization; 
namespace EspereAqui.LogicadeNegocios
{
    public class Clinica
    {

        public List<Consultorio> Consultorios { get; set; }
        public List<Paciente> FilaClinica { get; set; }
        public List<Especialidad> Especialidades { get; set; }

        public Clinica() {
            Consultorios = new List<Consultorio>();
            FilaClinica = new List<Paciente>();
            Especialidades = new List<Especialidad>();
        }

        public void AgregarPacienteFila(Paciente paciente)
        {
            if (!FilaClinica.Contains(paciente))
            {
                FilaClinica.Add(paciente);
            }
        }

        public void AgregarConsultorio(Consultorio consultorio)
        {
            if (!Consultorios.Contains(consultorio))
            {
                Consultorios.Add(consultorio);
            }
        }

        public void AgregarEspecialidad(Especialidad especialidad)
        {
            if (!Especialidades.Contains(especialidad))
            {
                Especialidades.Add(especialidad);
            }
        }



        public void AgregarPacienteAFilaConsultorio(Paciente paciente)
        {
            Consultorio consultorio = this.ObtenerConsultorioOptimo(this.ObtenerConsultoriosEspecialidad(paciente.especialidad));
            if (consultorio == null){
                this.FilaClinica.Remove(paciente); // Si no hay consultorio disponible, se devuelve al paciente al final de la fila
                this.AgregarPacienteFila(paciente);
                paciente.Prioridad += 1; // Aumentar prioridad
            }
            else{
                consultorio.AgregarPacienteFila(paciente);
                this.Consultorios.Remove(consultorio);

            }
        }

        public List<Consultorio> ObtenerConsultoriosEspecialidad(Especialidad especialidad)
        {
            List<Consultorio> resultado = new List<Consultorio>();
            foreach (Consultorio cons in this.Consultorios){
                if (cons.Especialidades.Contains(especialidad)) resultado.Add(cons);
            }
            if (resultado.Count == 0){
                Random rand = new Random();
                int num=rand.Next(1000000);
                if (num==105347) resultado.Add(this.Consultorios[0]); 
                // Mutación de 1 en un millón
                // se agrega un paciente a un consultorio que no atiende esa especialidad
            }
            return resultado;

        }

        public Consultorio ObtenerConsultorioOptimo(List<Consultorio> consultorios)
        {
            if (consultorios.Count == 0) return null;
            Consultorio mejor = consultorios[0];
            foreach (Consultorio cons in consultorios)
            {
                if (cons.ObtenerLongitudFila() < mejor.ObtenerLongitudFila()) mejor = cons;
            }
            return mejor;
        }

        public List<Paciente> OrdenarPacientesPorPrioridad(){
            return this.FilaClinica.OrderByDescending(paciente =>paciente.Prioridad).ToList();
        }

        public void Fitness()
        {
            if (this.FilaClinica.Count() != 0 && this.Consultorios.Count!=0){
                this.AgregarPacienteAFilaConsultorio(this.OrdenarPacientesPorPrioridad()[0]); //manda al paciente con mayor prioridad a un consultorio;
            }
            /*
                 Donde insertar a cada paciente de la cola de pacientes (ya)
                 Cruce de consultorios cuando se cierre una especialidad
                 Cruce de consultorios cuando se cree o cierre un consultorio
                 Si un paciente tiene una especialidad y no hay consultorios con dicha especialidad se regresa a la cola de espera y aumenta la prioridad (ya)
                 Atender en orden de prioridad(alta) a los pacientes en la cola de espera. (ya)
                 Revisar los consultorios abiertos y mandar a los paciente con prioridad alta a la cola del consultorio en la primera posición.
                 No hay especialiadades en ningun consultorio 
                 Orden en que se van a pasar los paciente con el mismo nivel de prioridad. (ya)
                 Definir maximo de personas en la fila por consultorio
                 Tiempo de consulta (Tiempo de simulacion) en base a la especialidad o cantidad de especialidades del consultorio.
                 5sg 5 minutos de simulación
                 Tipos de cruces 
                 Mutación de paciente (se cambie la especialidad, lo mandan a una fila de consultorio cuya especialidad no es la misma)

                 
                 
                 
                 
             */
        }




    }


}
