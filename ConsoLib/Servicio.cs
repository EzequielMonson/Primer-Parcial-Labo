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
        Alquiler,
    }

    public class Servicio
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int IdentificacionArriendador { get; set; }

        public NombreServicios Id { get; set; }

        public Servicio() 
        {
        }
        public Servicio(string nombre, int precio, int identificacionArriendador)//, NombreServicios id)
        {
            Nombre = nombre;
            Precio = precio;
            IdentificacionArriendador = identificacionArriendador;
            //Id = id;
        }
    }
}

