using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Inquilino : Usuario
    {
        private string direccion;
        private Queue<Dictionary<string, object>>colaDeudas;
        private Vivienda vivienda;

        public Inquilino(string nombre, string apellido, string correo, string contraseña, string ciudad, string fechaNacimiento, int telefono, string direccion) : base(nombre, apellido, correo, contraseña, ciudad, fechaNacimiento, telefono)
        {
            this.direccion = direccion;
            colaDeudas = new Queue<Dictionary<string, object>>();
            //vivienda = new Vivienda(direccion, );
        }

        

        public string Direccion { get => direccion; set => direccion = value; }
        public int Saldo { get => saldo; set => saldo = value; }
        public Queue<Dictionary<string, object>> ColaDeudas { get => colaDeudas; set => colaDeudas = value; }

        
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
            this.Saldo +=  saldoIngresado;
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
