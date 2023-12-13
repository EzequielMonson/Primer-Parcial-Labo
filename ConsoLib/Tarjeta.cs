using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Tarjeta
    {
        private string nombreCompleto;
        private int cvv;
        private string numeroTarjeta;
        private int saldo;
        public Tarjeta() { }

        public Tarjeta(string nombreCompleto, int cvv, string numeroTarjeta)
        {
            NombreCompleto = nombreCompleto;
            Cvv = cvv;
            NumeroTarjeta = numeroTarjeta;
            Saldo = 100000;
        }
        public int Saldo { get => saldo; set => saldo = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value;}
        public int Cvv { get => cvv; set => cvv = value; }
        public string NumeroTarjeta { get => numeroTarjeta; set => numeroTarjeta = value; }
    }
}
