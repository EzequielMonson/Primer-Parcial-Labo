using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Clases
{
    public class ValidadorTarjeta : Validador<Tarjeta>, IValidable<Tarjeta>
    {
        private Tarjeta unaTarjeta;
        public ValidadorTarjeta(Tarjeta tarjeta) : base(tarjeta)
        {
            UnaTarjeta = tarjeta;
        }
        public Tarjeta UnaTarjeta { get => unaTarjeta; set => unaTarjeta = value;}
        // Implementación de la interfaz IValidable
        public new bool Validar(Tarjeta tarjeta)
        {
            if (string.IsNullOrEmpty(UnaTarjeta.NombreCompleto))
            {
                EnviarMensajeError("Por favor, ingrese un nombre completo válido.");
                return false;
            }


            if (!ValidarNumero(UnaTarjeta.Cvv.ToString()))
            {
                EnviarMensajeError("El CVV no es válido.");
                return false;
            }


            if (string.IsNullOrEmpty(UnaTarjeta.NumeroTarjeta))
            {
                EnviarMensajeError("Por favor, el complete el campo del número de la tarjeta.");
                return false;
            }
            if (!isValidCard(UnaTarjeta.NumeroTarjeta))
            {
                EnviarMensajeError("Por favor, ingrese un número tarjeta válida.");
                return false;
            }
            return true;
        }

       

        public static bool isValidCard(string numeroTarjeta)
        {
            try
            {
             
                string numeroTarjetaSinEspacios = Regex.Replace(numeroTarjeta, @"\s|-", "");

                
                string patron = @"^\d{16}$";

                
                return Regex.IsMatch(numeroTarjetaSinEspacios, patron);
            }
            catch (Exception ex)
            {
               Console.WriteLine("Error al validar la tarjeta: " + ex.Message);

                return false;
            }
        }
    }
}
