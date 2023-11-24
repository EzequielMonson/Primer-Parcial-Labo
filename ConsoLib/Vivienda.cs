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

        public Vivienda()
        {

        }
        public Vivienda(string direccion, int numeroHabitaciones, int piso, Administrador arriendador, string departamento, int cantInquilinos)
        {
            this.direccion = direccion;
            this.numeroHabitaciones = numeroHabitaciones;
            this.piso = piso;
            this.arriendador = arriendador;
            this.departamento = departamento;
            this.cantInquilinos = cantInquilinos;
            
        }
        public Inquilino Inquilino
        {
            get => inquilino;
            set
            {
                inquilino = value;
                CalcularDeuda();
            }
        }

        public int CalcularPrecioBase()
        {
           
            return 1000; // precio base fijo de 1000
        }
        public int CalcularPrecioTotal()
        {
            int precioTotal = CalcularPrecioBase();

            foreach (Servicio unServicio in servicios)
            {
                precioTotal += unServicio.Precio;
            }

            return precioTotal;
        }

        private void CalcularDeuda()
        {
            if (inquilino != null)
            {
                int precioTotal = CalcularPrecioTotal();
                Deuda nuevaDeuda = new Deuda(precioTotal, "Alquiler", DateTime.Now, DateTime.Now.AddMonths(1));
                inquilino.AgregarDeuda(nuevaDeuda);
            }
        }


        public int MostrarPrecio(int precioBase)
        {
            int precioTotal = precioBase;

            foreach (Servicio unServicio in servicios)
            {
                precioTotal += unServicio.Precio;
            }

            return precioTotal;
        }
        public void AgregarServicio(Servicio nuevoServicio)
        {
            this.servicios.Add(nuevoServicio);
            CalcularDeuda(); // Actualiza la deuda cuando se agrega un nuevo servicio
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

            CalcularDeuda(); // Actualiza la deuda cuando se cancela un servicio
        }

        public override string ToString()
        {
            return $"El piso {piso} en el departamento {departamento}";
        }
    }

}



