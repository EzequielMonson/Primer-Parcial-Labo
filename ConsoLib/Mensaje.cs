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
        private DateTime fechaEnvio;
        private string contenido;
        private string emisor;
        private string receptor;
        public DateTime FechaEnvio { get=> fechaEnvio; set=> fechaEnvio = value; }
        public string Contenido { get => contenido; set => contenido = value; }
        public string Emisor { get => emisor; set => emisor = value; }

        public string Receptor { get => receptor; set => receptor = value; }

        public Mensaje(string contenido, string emisor, string receptor, DateTime fechaEnvio)
        {
            FechaEnvio = fechaEnvio;
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
