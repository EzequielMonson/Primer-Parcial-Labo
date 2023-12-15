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
        public List<Inquilino> inquilinosDeudores;
        public List<Inquilino> inquilinosACargo;
        public int Identificacion { get; set; }
        public string agencia;
        public string contactoAgencia;

        public Administrador() : base()
        {
        }
        public Administrador(string nombre, string apellido, string correo, string contraseña, string ciudad, DateTime fechaNacimiento, int telefono, int dni, int edad, string agencia, string contactoAgencia, int identificacion) :
            base(nombre, apellido, correo, contraseña, ciudad, fechaNacimiento, telefono, dni, edad)
        {
            this.agencia = agencia;
            this.contactoAgencia = contactoAgencia;
            this.Identificacion = identificacion;
            viviendasACargo = new List<Vivienda>();
            viviendasDisponibles = new List<Vivienda>();
            inquilinosPendientes = new List<Inquilino>();
            inquilinosDeudores = new List<Inquilino>();
            inquilinosACargo = new List<Inquilino>();

        }
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
            viviendaAAlquilar.DniInquilino = nuevoInquilino.Dni;
            nuevoInquilino.Estado = Estado.Activo;
        }

        public override void MostrarHistorialPagos()
        {
            string rutaInquilinosJson = "registrosInquilino.json";
            if (File.Exists(rutaInquilinosJson))
            {
                List<Inquilino> listaInquilinos = Serializadora<Inquilino>.CargarDesdeJSON(rutaInquilinosJson);
                foreach (var vivienda in viviendasACargo) 
                {
                    foreach (var inquilino in listaInquilinos)
                    {
                        if (vivienda.dniInquilino == inquilino.Dni)
                        {
                            inquilino.MostrarHistorialPagos();
                        }
                    }
                }

            }
        }
        public override void AgregarActividad(string tipo)
        {
            // Agregar actividades a la lista específica de Inquilino
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ActividadAdministrador.json");
            var nuevaActividad = new Actividad(DateTime.Now, tipo);
            actividades.Add(nuevaActividad);

            Serializadora<Actividad>.GuardarComoJSON(actividades, rutaArchivo);
        }
        public void EnviarDeudasMensuales()
        {
            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Now;

            // Iterar sobre las viviendas a cargo del administrador
            foreach (var vivienda in viviendasACargo)
            {
                // Obtener el inquilino de la vivienda
                Inquilino inquilino = vivienda.ObtenerInquilinoPorDni(vivienda.DniInquilino);

                // Verificar si hay un inquilino y si la vivienda tiene deudas
                if (inquilino != null && vivienda.MostrarPrecio(vivienda.CalcularPrecioTotal()) > 0)
                {
                    // Crear una nueva instancia de Deuda
                    Deuda nuevaDeuda = new Deuda(
                        vivienda.MostrarPrecio(vivienda.CalcularPrecioTotal()),
                        "Alquiler",
                        fechaActual,
                        fechaActual.AddMonths(1) // Vencimiento en un mes
                    );

                    // Agregar la nueva deuda al inquilino
                    inquilino.AgregarDeuda(nuevaDeuda);
                    // Verificar si el inquilino ya está en la lista de deudores
                    if (!inquilinosDeudores.Contains(inquilino))
                    {
                        inquilinosDeudores.Add(inquilino);
                    }
                }
            }
        }

        public void MostrarDeudores()
        {
            Console.WriteLine("Inquilinos Deudores:");
            foreach (var deudor in inquilinosDeudores)
            {
                Console.WriteLine($"Nombre: {deudor.nombre} {deudor.apellido}, DNI: {deudor.Dni}");
            }
        }
        public Inquilino PermitirNuevoInquilino(Inquilino inquilino)
        {
            inquilinosPendientes.Remove(inquilino);
            inquilino.Estado = Estado.Activo;
            return inquilino;

        }
        public void RechazarNuevoInquilino(Inquilino inquilino)
        {
            inquilino.Estado = Estado.Rechazado;
        }
    }
}
