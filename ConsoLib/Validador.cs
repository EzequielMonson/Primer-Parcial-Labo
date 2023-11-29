using System;
using System.Globalization;
using System.Text.RegularExpressions;
namespace Clases
{
    public abstract class Validador<T>
    {
        public delegate void MostrarMensajeErrorDelegate(string mensaje);

        public event MostrarMensajeErrorDelegate OnMostrarMensajeError;

        private T usuario;
        
        public Validador(T usuario)
        { 
            this.usuario = usuario;
        }
        public abstract bool ValidarRegistro();

        internal bool IsValidEmail(string email)
        {
            try
            {
                // Verificar si el correo no es nulo antes de validar
                if (email != null)
                {
                    // Expresión regular para validar correos electrónicos
                    string patronCorreo = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                    Regex regexCorreo = new Regex(patronCorreo);

                    // Verificar si el correo coincide con la expresión regular
                    return regexCorreo.IsMatch(email);
                }
                return false;
            }
            catch (RegexMatchTimeoutException)
            {
                // Manejar la excepción si hay un tiempo de espera al validar la expresión regular
                return false;
            }
        }


        internal bool IsValidDate(string date)
        {
            DateTime result;
            return DateTime.TryParse(date, out result);
        }

        internal bool ValidarEdadConFechaNacimiento(string fechaNacimiento, int edad)
        {
            DateTime fechaNac;

            // Intentar analizar la fecha de nacimiento con el formato "dd/MM/yyyy"
            if (DateTime.TryParseExact(fechaNacimiento, "dd/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaNac) || (DateTime.TryParseExact(fechaNacimiento, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaNac)))
            {
                // Calcular la edad directamente usando el año actual y el año de nacimiento
                int edadCalculada = DateTime.Now.Year - fechaNac.Year;

                // Comparar la edad calculada con la edad proporcionada
                return edad == edadCalculada;
            }

            // Devolver false si la fecha de nacimiento no es válida
            return false;
        }


        public bool ValidarNumero(string numero)
        {
            return int.TryParse(numero, out _);
        }

        public void EnviarMensajeError(string mensaje)
        {
            OnMostrarMensajeError?.Invoke(mensaje);
        }
    }

}
