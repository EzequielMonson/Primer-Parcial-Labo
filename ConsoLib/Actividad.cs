using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Actividad
    {
        public DateTime FechaHora { get; set; }
        public string Tipo { get; set; }

        
        public Actividad()
        {
        }

        public Actividad(DateTime fechaHora, string tipo)
        {
            FechaHora = fechaHora;
            Tipo = tipo;
        }
    }
}
