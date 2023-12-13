using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Mensaje
    {
        public DateTime FechaEnvio { get; set; }
        public string Contenido { get; set; }
        public string Emisor { get; set; }

        public string Receptor { get; set; }

        public Mensaje(string contenido, string emisor, string receptor)
        {
            FechaEnvio = DateTime.Now;
            Contenido = contenido;
            Emisor = emisor;
            Receptor = receptor;
        }

        public override string ToString()
        {
            return $"{FechaEnvio.ToString("HH:mm:ss")} - {Emisor}: {Contenido}";
        }
    }

}
