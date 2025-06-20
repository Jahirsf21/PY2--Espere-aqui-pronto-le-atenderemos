namespace EspereAqui.LogicadeNegocios
{
  //Class EspecialidadPendiente,
  //Represents a specialty pending care for a patient.
  //Stores the specialty and whether or not the patient has already been treated.
  public class EspecialidadPendiente
  {
    public Especialidad Especialidad { get; set; }
    public bool Atendida { get; set; }

    //Class constructor
    public EspecialidadPendiente(Especialidad especialidad)
    {
      Especialidad = especialidad;
      Atendida = false;
    }
  }
}