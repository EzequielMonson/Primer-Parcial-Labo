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
        public List<Inquilino> inquilinosPendientes;

        public Administrador() : base()
        {
        }
        public Administrador(string nombre, string apellido, string correo, string contraseña, string ciudad,string fechaNacimiento, int telefono) : base(nombre, apellido, correo, contraseña, ciudad, fechaNacimiento, telefono)
        {
            viviendasACargo = new List<Vivienda>();
            viviendasDisponibles = new List<Vivienda>();
            inquilinosPendientes = new List<Inquilino>();
        }
        /*public void AgregarPago(Queue<Dictionary<string, object>> colaDeudas, string vencimiento, string fecha, int monto )
        {
            Dictionary<string, object> dictDeuda = new Dictionary<string, object>
            {
                { "vencimiento" , vencimiento},
                { "fecha" , fecha },
                { "monto", monto }
            };
            colaDeudas.Enqueue(dictDeuda);
        }*/
        public void MostrarInquilinosPendientes() 
        {
            foreach (var inquilino in inquilinosPendientes)
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

        public override void MostrarHistorialPagos()
        {
            throw new NotImplementedException();
        }
        public override void AgregarActividad(string tipo)
        {
            // Agregar actividades a la lista específica de Inquilino
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ActividadAdministrador.json");
            var nuevaActividad = new Actividad(DateTime.Now, tipo);
            actividades.Add(nuevaActividad);

            Serializadora<Actividad>.GuardarComoJSON(actividades, rutaArchivo);
        }
        public void MostrarDeudores(List<Inquilino> listaDeudores)
        { 
        }
        public void PermitirNuevoInquilino(Inquilino inquilino)
        {
            inquilino.Estado = Estado.Activo;

        }
        public void RechazarNuevoInquilino(Inquilino inquilino)
        {
            inquilino.Estado = Estado.Rechazado;
        }
    }
}
