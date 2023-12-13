using System;
using System.Data.Common;
using System.Globalization;
using System.Net.WebSockets;
using System.Text.RegularExpressions;
namespace Clases
{
    public abstract class ValidadorUsuario<T> : Validador<T>, IValidable<T>
    {


        private Usuario unUsuario;

        public ValidadorUsuario(Usuario usuario) : base(usuario)
        {
             UnUsuario = usuario;
        }
        public Usuario UnUsuario { get => unUsuario; set => unUsuario = value;}
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


        internal bool ValidarEdadConFechaNacimiento(DateTime fechaNacimiento, int edad)
        {
            bool verificacion = false;

            int edadCalculada = DateTime.Now.Year - fechaNacimiento.Year;

            // Comparar la edad calculada con la edad proporcionada
            if (edad == edadCalculada)
            {
                verificacion = true;
            }
            // Devolver false si la fecha de nacimiento no es válida
            return verificacion;
        }



    }

}
