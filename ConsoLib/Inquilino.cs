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
        private Queue<Deuda>colaDeudas;
        private List<Pago> historialPagos;
        private Vivienda vivienda;
        private Estado estado;
        private string direccion;
        public Inquilino() 
        {
        }
        public Inquilino(string nombre, string apellido, string correo, string contraseña, string ciudad, string fechaNacimiento, int telefono, string direccion, int dni, int edad) : 
            base(nombre, apellido, correo, contraseña, ciudad, fechaNacimiento, telefono, dni, edad)
        {
            this.direccion = direccion;
            colaDeudas = new Queue<Deuda>();
            historialPagos = new List<Pago>();
            estado = Estado.Pendiente;
            
        }
    
        public int Dni  { get => dni ; }
        public Estado Estado { get => estado; set => estado = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public Vivienda Vivienda { get => vivienda; set => vivienda = value; }
        public Queue<Deuda> ColaDeudas { get => colaDeudas; set => colaDeudas = value; }
        public List<Pago> HistorialPagos { get => historialPagos; }

        public  void ElegirVivienda(Vivienda viviendaElegida)
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

                
                if (colaDeudas.Count == 0 || colaDeudas.Peek().FechaVencimiento < DateTime.Now)
                {
                    Deuda nuevaDeuda = new Deuda(precioTotal, "Alquiler", DateTime.Now, DateTime.Now.AddMonths(1));
                    AgregarDeuda(nuevaDeuda);
                }
            }
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
