using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    // Clase para gestionar los mensajes
    public class MensajeManager
    {
        private static MensajeManager instancia;

        private List<Mensaje> listaMensajesEmisor = new List<Mensaje>();
        private List<Mensaje> listaMensajesReceptor = new List<Mensaje>();

        // Proporciona una única instancia de la clase
        public static MensajeManager Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new MensajeManager();
                }
                return instancia;
            }
        }

        private MensajeManager()
        {
            // Constructor privado para asegurar que solo haya una instancia
        }

        // Métodos para obtener y guardar mensajes
        public List<Mensaje> ObtenerMensajesEmisor()
        {
            return listaMensajesEmisor;
        }

        public List<Mensaje> ObtenerMensajesReceptor()
        {
            return listaMensajesReceptor;
        }

        public void GuardarMensajeEmisor(Mensaje mensaje)
        {
            listaMensajesEmisor.Add(mensaje);
        }

        public void GuardarMensajeReceptor(Mensaje mensaje)
        {
            listaMensajesReceptor.Add(mensaje);
        }
    }

}
