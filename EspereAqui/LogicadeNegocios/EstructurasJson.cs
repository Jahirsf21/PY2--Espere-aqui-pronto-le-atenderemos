using System.Collections.Generic;

namespace EspereAqui.LogicadeNegocios.EstructurasJson
{
    public class DatosClinicaJson
    {

        public List<EspecialidadJson> Especialidades { get; set; }

        public List<PacienteJson> Pacientes { get; set; }
    }


    public class EspecialidadJson
    {
        public string Nombre { get; set; }
        public int TiempoConsulta { get; set; }
    }


    public class PacienteJson
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Genero { get; set; }
        // Lista de nombres de las especialidades que necesita el paciente
        public List<string> EspecialidadesRequeridas { get; set; }
    }
}