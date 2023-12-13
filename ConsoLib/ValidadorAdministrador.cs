using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ValidadorAdministrador: ValidadorUsuario<Administrador>, IValidable<Administrador>
    {
        public Administrador unAdministrador;
        public ValidadorAdministrador(Administrador administrador) : base(administrador)
        {
            unAdministrador = administrador;
        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(unAdministrador.nombre) || string.IsNullOrEmpty(unAdministrador.apellido))
            {
                EnviarMensajeError("Por favor, ingrese un nombre y apellido válidos.");
                return false;
            }
            if (string.IsNullOrEmpty(unAdministrador.dni.ToString()) || !ValidarNumero(unAdministrador.dni.ToString()))
            {
                EnviarMensajeError("El DNI no es válido.");
                return false;
            }
            if (string.IsNullOrEmpty(unAdministrador.telefono.ToString()) || !ValidarNumero(unAdministrador.telefono.ToString()))
            {
                EnviarMensajeError("El teléfono no es válido.");
                return false;
            }
            if (string.IsNullOrEmpty(unAdministrador.edad.ToString()) ||  !ValidarNumero(unAdministrador.edad.ToString()))
            {
                EnviarMensajeError("La edad no es válida.");
                return false;
            }
            if (!IsValidEmail(unAdministrador.correo))
            {
                EnviarMensajeError("Por favor, ingrese una dirección de correo electrónico válida.");
                return false;
            }
            if (!ValidarEdadConFechaNacimiento(unAdministrador.fechaNacimiento, unAdministrador.edad))
            {
                EnviarMensajeError($"Por favor, ingrese una fecha de nacimiento válida que coincida con la edad. {unAdministrador.fechaNacimiento}");
                return false;
            }
            if (string.IsNullOrEmpty(unAdministrador.ciudad))
            {
                EnviarMensajeError("Por favor, ingrese una ciudad válida.");
                return false;
            }
            if (!IsValidEmail(unAdministrador.contactoAgencia))
            {
                EnviarMensajeError("Por favor, ingrese una dirección de correo electrónico válida.");
                return false;
            }
            if (!ValidarNumero(unAdministrador.Identificacion.ToString()))
            {
                EnviarMensajeError("La identificacion no es válida.");
                return false;
            }

            if (string.IsNullOrEmpty(unAdministrador.contraseña))
            {
                EnviarMensajeError("Por favor, ingrese una contraseña válida.");
                return false;
            }

            
            return true;
        }
        public bool ConfirmarCorreo(string correoIngresado)
        {

            if (unAdministrador.correo == correoIngresado)
            {

                return true;
            }
            else
            {
                EnviarMensajeError("Los correos ingresados no coinciden.");
                return false;
            }

        }

        public bool ConfirmarContraseña(string contraseñaIngresada)
        {
            if (unAdministrador.contraseña == contraseñaIngresada)
            {
                return true;
            }
            else
            {
                EnviarMensajeError("Las contraseñas ingresadas no coinciden.");
                return false;
            }

        }
    }
}
