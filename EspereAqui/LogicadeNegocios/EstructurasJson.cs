using System.Collections.Generic;

namespace EspereAqui.LogicadeNegocios.EstructurasJson
{
    //Class DatosClinicaJson
    //Represents the data structure used to deserialize the clinic's JSON file.
    //Contains lists of specialties and patients in JSON format.
    public class DatosClinicaJson
    {

        public List<EspecialidadJson> Especialidades { get; set; }

        public List<PacienteJson> Pacientes { get; set; }
    }

    //Class EspecialidadJson
    //Represents a specialty in the JSON file.
    //Includes the specialty name and query time.
    public class EspecialidadJson
    {
        public string Nombre { get; set; }
        public int TiempoConsulta { get; set; }
    }


    //Class PacienteJson
    //Represents a patient in the JSON file.
    //Includes first name, last name, gender, priority, and the list of required specialties.

    public class PacienteJson
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Genero { get; set; }
        public int Prioridad { get; set; }
        public List<string> EspecialidadesRequeridas { get; set; }
    }
}