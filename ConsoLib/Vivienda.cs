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
    public enum Servicios
    {
        Agua,
        Internet,
        Cable,
        Luz,
        Gas,
    }
    public class Vivienda
    {
        private String direccion;
        private int numeroHabitaciones;
        private double costoAgua;
        private double costoLuz;
        private double costoGas;
        private int piso;
        private string arriendador;
        private string departamento;
        private int cantInquilinos;
        private List<Servicios> servicios;

        public Vivienda(string direccion, int numeroHabitaciones, double costoAgua, double costoLuz, double costoGas, int piso, string arriendador, string departamento, int cantInquilinos, Servicios servicios)
        {
            this.direccion = direccion;
            this.numeroHabitaciones = numeroHabitaciones;
            this.costoAgua = costoAgua;
            this.costoLuz = costoLuz;
            this.costoGas = costoGas;
            this.piso = piso;
            this.arriendador = arriendador;
            this.departamento = departamento;
            this.cantInquilinos = cantInquilinos;
            this.servicios = new List<Servicios>();
        }

        public int MostrarPrecio(int precioBase,List<Servicios> servicio)
        {
            return precioBase; 
        }
    }
}
