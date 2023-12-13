using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
 

    public class Vivienda
    {
        public string direccion;
        public int numeroHabitaciones;
        public int piso;
        public int identificacionArriendador;
        public string departamento;
        public int cantInquilinos;
        public List<Servicio> servicios;
        public int dniInquilino;

        public Vivienda()
        {

        }
        public Vivienda(string direccion, int numeroHabitaciones, int piso, int identificacionArriendador, string departamento, int cantInquilinos)
        {
            this.direccion = direccion;
            this.numeroHabitaciones = numeroHabitaciones;
            this.piso = piso;
            this.identificacionArriendador = identificacionArriendador;
            this.departamento = departamento;
            this.cantInquilinos = cantInquilinos;
            this.servicios = new List<Servicio> ();
            
        }
        
        public int DniInquilino
    {
        get => dniInquilino;
        set
        {
            dniInquilino = value;
            CalcularDeuda();
        }
    }

        public int CalcularPrecioBase()
        {
           
            return 1000; 
        }
        public int CalcularPrecioTotal()
        {
            int precioTotal = CalcularPrecioBase();
            if (servicios != null)
            {
                foreach (Servicio unServicio in servicios)
                {
                    precioTotal += unServicio.Precio;
                }
            }
            return precioTotal;
        }
        public Administrador ObtenerAdministradorPorIdentificacion()
        {
            try
            {
                List<Administrador> listaAdministradores = Serializadora<Administrador>.CargarDesdeJSON("RegistrosAdministrador.json");

                if (listaAdministradores != null)
                {
                    return listaAdministradores.Find(administrador => administrador.Identificacion == identificacionArriendador);
                }
                else
                {
                    throw new Exception("La lista de administradores es nula.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener administrador por identificación: {ex.Message}");
                
                return null;
            }
        }

        public Inquilino ObtenerInquilinoPorDni(int dni)
        {
            try
            {
                List<Inquilino> listaInquilinos = Serializadora<Inquilino>.CargarDesdeJSON("RegistrosInquilinos.json");

                if (listaInquilinos != null)
                {
                    return listaInquilinos.Find(inquilino => inquilino.Dni == dni);
                }
                else
                {
                    throw new Exception("La lista de inquilinos es nula.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener inquilino por DNI: {ex.Message}");
                
                return null;
            }
        }

        private void CalcularDeuda()
        {
            Inquilino inquilino =  ObtenerInquilinoPorDni(this.dniInquilino);
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
            CalcularDeuda(); 
        }

        public void CancelarServicio(NombreServicios servicioAEliminar)
        {
            for (int i = this.servicios.Count - 1; i >= 0; i--)
            {
                if (this.servicios[i].Id == servicioAEliminar)
                {
                    this.servicios.RemoveAt(i);
                }
            }

            CalcularDeuda(); 
        }

        public override string ToString()
        {
            return $"Calle {direccion} en el piso {piso} en el departamento {departamento}";
        }
    }

}



