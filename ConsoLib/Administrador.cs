using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Administrador : Usuario
    {
        public List<Vivienda> viviendasACargo;
        public List<Vivienda> viviendasDisponibles;
        public List<Inquilino> InquilinosPendientes;
        public Administrador(string nombre, string apellido, string correo, string contraseña, string ciudad,string fechaNacimiento, int telefono) : base(nombre, apellido, correo, contraseña, ciudad, fechaNacimiento, telefono)
        {
        }
        public void AgregarPago(Queue<Dictionary<string, object>> colaDeudas, string vencimiento, string fecha, int monto )
        {
            Dictionary<string, object> dictDeuda = new Dictionary<string, object>
            {
                { "vencimiento" , vencimiento},
                { "fecha" , fecha },
                { "monto", monto }
            };
            colaDeudas.Enqueue(dictDeuda);
        }
        public void MostrarInquilinosPendientes() 
        {
            foreach (var inquilino in InquilinosPendientes)
            {
                Console.WriteLine($"Nombre: {inquilino.ToString}");
                Console.WriteLine($"Correo: {inquilino.Dni}");
                Console.WriteLine($"Ciudad: {inquilino.Direccion}");
                Console.WriteLine($"Quiere alquilar en {inquilino.Vivienda.ToString}");
            }
        }
        public void AlquilarVivienda(Inquilino nuevoInquilino, Vivienda viviendaAAlquilar)
        {
            viviendaAAlquilar.Inquilino = nuevoInquilino;
            nuevoInquilino.Estado = Estado.Activo;
        }
        public override void MostrarHistorialActividades()
        {
            throw new NotImplementedException();
        }

        public override void MostrarHistorialPagos()
        {
            throw new NotImplementedException();
        }

        public void MostrarDeudores()
        { 
        }
        public void PermitirNuevoInquilino(Inquilino inquilino)
        { 

        }
    }
}
