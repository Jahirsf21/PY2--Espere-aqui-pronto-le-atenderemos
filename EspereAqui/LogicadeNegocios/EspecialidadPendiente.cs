namespace EspereAqui.LogicadeNegocios
{
  public class EspecialidadPendiente
  {
    public Especialidad Especialidad { get; set; }
    public bool Atendida { get; set; }

    public EspecialidadPendiente(Especialidad especialidad)
    {
      Especialidad = especialidad;
      Atendida = false;
    }
  }
}