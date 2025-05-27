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

        public Clinica()
        {
            Consultorios = new List<Consultorio>();

        }
    }


}
