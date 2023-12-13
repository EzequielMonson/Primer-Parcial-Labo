using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ValidadorInquilino : ValidadorUsuario<Inquilino>
    {
        public Inquilino unInquilino;
        public ValidadorInquilino(Inquilino inquilino) : base(inquilino)
        {
            unInquilino = inquilino;
        }

        public bool ValidarRegistro()
        {
            if (string.IsNullOrEmpty(unInquilino.nombre) || string.IsNullOrEmpty(unInquilino.apellido))
            {
                EnviarMensajeError("Por favor, ingrese un nombre y apellido válidos.");
                return false;
            }

            if (!IsValidEmail(unInquilino.correo))
            {
                EnviarMensajeError("Por favor, ingrese una dirección de correo electrónico válida.");
                return false;
            }

            if (!ValidarNumero(unInquilino.dni.ToString()))
            {
                EnviarMensajeError("El DNI no es válido.");
                return false;
            }

            if (!ValidarNumero(unInquilino.telefono.ToString()))
            {
                EnviarMensajeError("El teléfono no es válido.");
                return false;
            }

            if (!ValidarNumero(unInquilino.edad.ToString()))
            {
                EnviarMensajeError("La edad no es válida.");
                return false;
            }

            if (!ValidarEdadConFechaNacimiento(unInquilino.fechaNacimiento, unInquilino.edad))
            {
                EnviarMensajeError("Por favor, ingrese una fecha de nacimiento válida que coincida con la edad.");
                return false;
            }

            if (string.IsNullOrEmpty(unInquilino.contraseña))
            {
                EnviarMensajeError("Por favor, ingrese una contraseña válida.");
                return false;
            }

            if (string.IsNullOrEmpty(unInquilino.ciudad))
            {
                EnviarMensajeError("Por favor, ingrese una ciudad válida.");
                return false;
            }
            return true;
        }
        public bool ConfirmarCorreo(string correoIngresado)
        {

            if (unInquilino.correo == correoIngresado)
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
            if (unInquilino.contraseña == contraseñaIngresada)
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
