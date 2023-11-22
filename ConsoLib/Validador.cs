using System;


namespace Clases
{
    public class Validador
    {
        // Define un delegado para manejar la comunicación de errores
        public delegate void MostrarMensajeErrorDelegate(string mensaje);

        // Evento que se dispara cuando ocurre un error
        public static event MostrarMensajeErrorDelegate OnMostrarMensajeError;

        public static bool ValidarRegistro(string nombre, string apellido, string correo, int dni, int telefono, int edad, string fechaNacimiento, string rol, string clave, string ciudad, string direccion)
        {
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                EnviarMensajeError("Por favor, ingrese un nombre y apellido válidos.");
                return false;
            }

            if (!IsValidEmail(correo))
            {
                EnviarMensajeError("Por favor, ingrese una dirección de correo electrónico válida.");
                return false;
            }

            if (dni <= 0 || telefono <= 0 || edad <= 0)
            {
                EnviarMensajeError("Por favor, ingrese valores válidos para DNI, teléfono y edad.");
                return false;
            }

            if (!IsValidDate(fechaNacimiento) || !ValidarEdadConFechaNacimiento(fechaNacimiento, edad))
            {
                EnviarMensajeError("Por favor, ingrese una fecha de nacimiento válida que coincida con la edad.");
                return false;
            }

            if (string.IsNullOrEmpty(rol) || (rol != "inquilino" && rol != "administrador"))
            {
                EnviarMensajeError("Por favor, seleccione un rol.");
                return false;
            }

            if (string.IsNullOrEmpty(clave))
            {
                EnviarMensajeError("Por favor, ingrese una clave válida.");
                return false;
            }

            if (string.IsNullOrEmpty(ciudad) || string.IsNullOrEmpty(direccion))
            {
                EnviarMensajeError("Por favor, ingrese una ciudad y dirección válidas.");
                return false;
            }

            // Todas las validaciones pasaron
            return true;
        }

        private static bool IsValidEmail(string email)
        {
            try
            {
                var correo = new System.Net.Mail.MailAddress(email);
                return correo.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private static bool IsValidDate(string date)
        {
            DateTime result;
            return DateTime.TryParse(date, out result);
        }

        private static bool ValidarEdadConFechaNacimiento(string fechaNacimiento, int edad)
        {
            DateTime fechaNac;
            if (DateTime.TryParse(fechaNacimiento, out fechaNac))
            {
                int edadCalculada = DateTime.Now.Year - fechaNac.Year;

                if (DateTime.Now < fechaNac.AddYears(edadCalculada))
                {
                    edadCalculada--;
                }

                return edad == edadCalculada;
            }

            return false;
        }

        private static void EnviarMensajeError(string mensaje)
        {
            // Disparar el evento para comunicar el error
            OnMostrarMensajeError?.Invoke(mensaje);
        }
    }
}
