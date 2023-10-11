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

        public Inquilino(string nombre, string apellido, string correo, string contraseña, string ciudad, string agencia,int saldo,string direccion) : base(nombre, apellido, correo, contraseña, ciudad, agencia, saldo)
        {
            this.direccion = direccion;
            colaDeudas = new Queue<Dictionary<string, object>>(); 
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
        public void IngresarSaldo(int saldo, int saldoIngresado) 
        {
            Saldo =  saldoIngresado + saldo;
        }
    }
}
