using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Validador<T> : IValidable<T>
    {

        public delegate void MostrarMensajeErrorDelegate(string mensaje);

        public event MostrarMensajeErrorDelegate OnMostrarMensajeError;

        public T objeto;
        private Usuario usuario;

        public Validador(T objeto)
        {
            this.objeto = objeto;
        }

        protected Validador(Usuario usuario)
        {
            this.usuario = usuario;
        }

        public bool ValidarNumero(string numero)
        {
            return int.TryParse(numero, out _);
        }

        public void EnviarMensajeError(string mensaje)
        {
            OnMostrarMensajeError?.Invoke(mensaje);
        }


      
        public bool Validar(T objeto)
        {
            throw new NotImplementedException();
        }
    }
}

