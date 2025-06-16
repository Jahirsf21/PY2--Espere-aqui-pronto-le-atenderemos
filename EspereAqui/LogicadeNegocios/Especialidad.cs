using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspereAqui.LogicadeNegocios
{
    public class Especialidad
    {
        public string nombre { get; set; }

        public int tiempoConsulta { get; set; }

        public Especialidad(string nombre)
        {
            this.nombre = nombre;

            switch (nombre)
            {
                case "Medicina general":
                    tiempoConsulta = 30;
                    break;
                case "Odontología":
                    tiempoConsulta = 35;
                    break;
                case "Cardiología":
                    tiempoConsulta = 45;
                    break;
                case "Pediatría":
                    tiempoConsulta = 40;
                    break;
                case "Urología":
                    tiempoConsulta = 50;
                    break;
                case "Ginecología":
                    tiempoConsulta = 55;
                    break;
                case "Dermatología":
                    tiempoConsulta = 32;
                    break;
                case "Oftalmología":
                    tiempoConsulta = 37;
                    break;
                case "Nutriólogo":
                    tiempoConsulta = 34;
                    break;
                default:
                    tiempoConsulta = 30;
                    break;
            }
        }

        public bool Equals(Especialidad esp)
        {
            if (this.nombre == esp.nombre) return true;
            return false;
        }
    }
}
