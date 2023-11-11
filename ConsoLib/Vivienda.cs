using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
 

    public class Vivienda
    {
        private string direccion;
        private int numeroHabitaciones;
        private int piso;
        private Administrador arriendador;
        private string departamento;
        private int cantInquilinos;
        private List<Servicio> servicios;
        private Inquilino inquilino;
        

        public Vivienda(string direccion, int numeroHabitaciones, int piso, Administrador arriendador, string departamento, int cantInquilinos)
        {
            this.direccion = direccion;
            this.numeroHabitaciones = numeroHabitaciones;
            this.piso = piso;
            this.arriendador = arriendador;
            this.departamento = departamento;
            this.cantInquilinos = cantInquilinos;
            
        }
        public Inquilino Inquilino { get => inquilino; set => inquilino = value; }
        public double MostrarPrecio(double precioBase)
        {
            double precioTotal = precioBase;
            foreach (Servicio unServicio in servicios)
            {
                precioTotal += unServicio.Precio;
            }
            return precioTotal;
        }
        public void AgregarServicio(Servicio nuevoServicio)
        {
            this.servicios.Add(nuevoServicio);
        }
        public void CancelarServicio(NombreServicios servicioAEliminar)
        {
            for (int i = this.servicios.Count - 1; i >= 0; i--)
            {
                if (this.servicios[i].Nombre == servicioAEliminar)
                {
                    this.servicios.RemoveAt(i);
                }
            }
        }
        public override string ToString()
        {
            return $" el piso {piso} en el departamento {departamento}";
        }

    }
}


