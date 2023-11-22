using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public enum NombreServicios
    {
        Agua,
        Internet,
        Cable,
        Luz,
        Gas,
    }

    public class Servicio
    {
        public NombreServicios Nombre { get; set; }
        public double Precio { get; set; }

        public Servicio() 
        {
        }
        public Servicio(NombreServicios nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}

