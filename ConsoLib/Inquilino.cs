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
        Eliminado
    }
    public class Inquilino : Usuario
    {
        private string direccion;
        private Queue<Dictionary<string, object>>colaDeudas;
        private Vivienda vivienda;
        private Estado estado;
        private readonly int dni;
        private int edad;
        public Inquilino(string nombre, string apellido, string correo, string contraseña, string ciudad, string fechaNacimiento, int telefono, string direccion, int dni, int edad) : base(nombre, apellido, correo, contraseña, ciudad, fechaNacimiento, telefono)
        {
            this.direccion = direccion;
            colaDeudas = new Queue<Dictionary<string, object>>();
            estado = Estado.Pendiente;
            this.edad = edad;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni  { get => dni ; }
        public Estado Estado { get => estado; set => estado = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public Vivienda Vivienda { get => vivienda; set => vivienda = value; }
        public Queue<Dictionary<string, object>> ColaDeudas { get => colaDeudas; set => colaDeudas = value; }

        public void ElegirVivienda(Vivienda viviendaElegida)
        {
            this.vivienda = viviendaElegida;
        }
        public void PagarDeuda()
        {
            try
            {

            }
            catch
            { 
            }
        }
        public void IngresarSaldo(int saldoIngresado) 
        {
            this.saldo +=  saldoIngresado;
        }

        public override void MostrarHistorialPagos()
        {
           
        }

        public override void MostrarHistorialActividades()
        {
            throw new NotImplementedException();
        }
       
    }
}
