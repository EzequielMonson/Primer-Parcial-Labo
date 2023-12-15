using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clases
{
    public class Pago
    {
        public DateTime FechaAbono { get; set; }
        public int CantidadAbonada { get; set; }
        public DateTime FechaVencimiento { get; set; }

        public Pago(int cantidadAbonada, DateTime fechaVencimiento)
        {
            FechaAbono = DateTime.Now; // La fecha de abono se establece como el día actual
            CantidadAbonada = cantidadAbonada;
            FechaVencimiento = fechaVencimiento;
        }
        public Pago(int cantidadAbonada, DateTime fechaVencimiento, DateTime fechaAbono)
        {
            FechaAbono = fechaAbono; // La fecha de abono se establece como el día actual
            CantidadAbonada = cantidadAbonada;
            FechaVencimiento = fechaVencimiento;
        }
    }
}
