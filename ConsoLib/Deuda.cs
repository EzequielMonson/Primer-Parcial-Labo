using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Deuda
    {
        public int Monto { get; set; }
        public string Concepto { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaVencimiento { get; set; }

        public Deuda(int monto, string concepto, DateTime fechaEmision, DateTime fechaVencimiento)
        {
            Monto = monto;
            Concepto = concepto;
            FechaEmision = fechaEmision;
            FechaVencimiento = fechaVencimiento;
        }
    }

}
