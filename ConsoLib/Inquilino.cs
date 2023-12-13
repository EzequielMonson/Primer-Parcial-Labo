using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public enum Estado
    {
        Activo,
        Inactivo,
        Pendiente,
        Rechazado
    }
    public class Inquilino : Usuario
    {
        private Queue<Deuda> colaDeudas;
        private List<Pago> historialPagos;
        private Vivienda vivienda;
        private Estado estado;
        private string direccion;
        private Tarjeta tarjeta;
        public Inquilino()
        {
        }
        public Inquilino(string nombre, string apellido, string correo, string contraseña, string ciudad, DateTime fechaNacimiento, int telefono, string direccion, int dni, int edad) :
            base(nombre, apellido, correo, contraseña, ciudad, fechaNacimiento, telefono, dni, edad)
        {
            this.direccion = direccion;
            colaDeudas = new Queue<Deuda>();
            HistorialPagos = new List<Pago>();
            estado = Estado.Pendiente;


        }
        public Tarjeta Tarjeta { get => tarjeta; set => tarjeta = value; }
        public int Dni { get => dni; }
        public Estado Estado { get => estado; set => estado = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public Vivienda Vivienda { get => vivienda; set => vivienda = value; }
        public Queue<Deuda> ColaDeudas { get => colaDeudas; set => colaDeudas = value; }
        public List<Pago> HistorialPagos { get => historialPagos; set => historialPagos = value; }

        public void ElegirVivienda(Vivienda viviendaElegida)
        {
            this.vivienda = viviendaElegida;
            vivienda.DniInquilino = Dni;
            Administrador administrador = vivienda.ObtenerAdministradorPorIdentificacion();//arriendador.inquilinosPendientes.Add(this);
            administrador.inquilinosPendientes.Add(this);
        }
        public void CalcularDeuda(Vivienda vivienda)
        {
            if (vivienda != null)
            {
                int precioTotal = vivienda.CalcularPrecioTotal();


                if (HistorialPagos.Count == 0)
                {

                    DateTime fechaVencimiento = DateTime.Now.AddMonths(1);
                    Deuda nuevaDeuda = new Deuda(precioTotal, "Alquiler", DateTime.Now, fechaVencimiento);
                    AgregarDeuda(nuevaDeuda);

                }
                else
                {
                    // Obtiene la fecha de vencimiento del último pago
                    DateTime ultimaFechaVencimiento = HistorialPagos.Last().FechaVencimiento;

                    // Calcula la diferencia en días desde la última fecha de vencimiento
                    int diasDesdeVencimiento = (int)(DateTime.Now - ultimaFechaVencimiento).TotalDays;

                    // Define el período después del cual se agregaría una nueva deuda (por ejemplo, 30 días)
                    int periodoDeuda = 30;

                    if (diasDesdeVencimiento >= periodoDeuda)
                    {
                        // Ha pasado el período definido, agrega una nueva deuda
                        DateTime nuevaFechaVencimiento = DateTime.Now.AddMonths(1);
                        Deuda nuevaDeuda = new Deuda(precioTotal, "Alquiler", DateTime.Now, nuevaFechaVencimiento);
                        AgregarDeuda(nuevaDeuda);
                    }
                }
            }
        }

        public void AgregarTarjeta(Tarjeta tarjeta)
        {
            this.Tarjeta = tarjeta;
        }
        public override void AgregarActividad(string tipo)
        {
            // Agregar actividades a la lista específica de Inquilino
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ActividadInquilino.json");
            var nuevaActividad = new Actividad(DateTime.Now, tipo);
            actividades.Add(nuevaActividad);

            // Guardar el historial actualizado en un archivo JSON específico para Inquilino
            Serializadora<Actividad>.GuardarComoJSON(actividades, rutaArchivo);
        }
        public void PagarDeuda()
        {
            try
            {
                if (colaDeudas.Count > 0)
                {
                    // Obtener la primera deuda de la cola
                    Deuda deuda = colaDeudas.Dequeue();

                    // Obtener la cantidad y concepto de la deuda
                    int monto = deuda.Monto;
                    string concepto = deuda.Concepto;

                    // Realizar el pago
                    if (saldo >= monto)
                    {
                        saldo -= monto;
                        Console.WriteLine($"Se pagó la deuda de {monto} por {concepto}.");

                        // Agregar el pago al historial de pagos
                        historialPagos.Add(new Pago(monto, deuda.FechaVencimiento));
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente para pagar la deuda.");
                    }
                }
                else
                {
                    Console.WriteLine("No hay deudas pendientes para pagar.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al intentar pagar la deuda: {ex.Message}");
            }
        }

        public void AgregarDeuda(Deuda nuevaDeuda)
        {
            // Verificar si ya hay una deuda en la cola
            if (colaDeudas.Count == 0 || colaDeudas.Peek().FechaVencimiento < DateTime.Now)
            {
                colaDeudas.Enqueue(nuevaDeuda);
            }
        }
        public void IngresarSaldo(int saldoIngresado) 
        {
            this.saldo +=  saldoIngresado;
        }

        public override void MostrarHistorialPagos()
        {
            Console.WriteLine("Historial de Pagos:");
            foreach (var pago in historialPagos)
            {
                Console.WriteLine($"Fecha de Abono: {pago.FechaAbono}, Cantidad Abonada: {pago.CantidadAbonada}, Fecha de Vencimiento: {pago.FechaVencimiento}");
            }
        }


        public override void MostrarHistorialActividades()
        {
            throw new NotImplementedException();
        }
       
    }
}
