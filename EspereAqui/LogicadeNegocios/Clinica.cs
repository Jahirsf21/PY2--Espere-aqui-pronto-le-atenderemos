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



        public void AgregarPacienteAFilaConsultorio(Paciente paciente) {
           Consultorio consultorio = this.ObtenerConsultorioOptimo(this.ObtenerConsultoriosEspecialidad(paciente.especialidad));
           consultorio.AgregarPacienteFila(paciente);
        }

        public List<Consultorio> ObtenerConsultoriosEspecialidad(Especialidad especialidad)
        {
            List<Consultorio> resultado = new List<Consultorio>();
            foreach (Consultorio cons in this.Consultorios){
                if (cons.Especialidades.Contains(especialidad)) resultado.Add(cons);
            }
            return resultado;

        }

        public Consultorio ObtenerConsultorioOptimo(List<Consultorio> consultorios)
        {
            Consultorio mejor = consultorios[0];
            foreach (Consultorio cons in consultorios)
            {
                if (cons.ObtenerLongitudFila() < mejor.ObtenerLongitudFila()) mejor = cons;
            }
            return mejor;
        }




    }


}
