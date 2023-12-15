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
        public Vivienda(string direccion, int numeroHabitaciones, int piso, int identificacionArriendador, string departamento, int cantInquilinos, int dniInquilino)
        {
            this.direccion = direccion;
            this.numeroHabitaciones = numeroHabitaciones;
            this.piso = piso;
            this.identificacionArriendador = identificacionArriendador;
            this.departamento = departamento;
            this.cantInquilinos = cantInquilinos;
            this.servicios = new List<Servicio> ();
            DniInquilino = dniInquilino;
            
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

        public int CalcularPrecioTotal()
        {
            int precio = 0;
            OperacionesBDServicio<Servicio> baseDatosServicios = new OperacionesBDServicio<Servicio>("SERVER=127.0.0.1;PORT=3306;DATABASE=nestapp;UID=root;PASSWORDS=;", identificacionArriendador);
            List<Servicio> serviciosActivos = baseDatosServicios.ObtenerServiciosActivos(identificacionArriendador, dniInquilino);
            foreach (var servicio in serviciosActivos)
            {
                precio += servicio.Precio;
            }
            return precio;

        }
       
        public Administrador ObtenerAdministradorPorIdentificacion()
        {
            try
            {
                string conexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=nestapp;UID=root;PASSWORDS=;";
                OperacionesBDAdministrador<Administrador> baseDatosAdministrador = new OperacionesBDAdministrador<Administrador>(conexion);
                List<Administrador> listaAdministradores = baseDatosAdministrador.ObtenerTodos();

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


        public int MostrarPrecio(int precioTotal)
        {

            return precioTotal;
        }
        public void AgregarServicio(Servicio nuevoServicio)
        {
            this.servicios.Add(nuevoServicio);
            CalcularDeuda(); 
        }

        public void CancelarServicio(Servicio servicioAEliminar)
        {
            for (int i = this.servicios.Count - 1; i >= 0; i--)
            {
                if (this.servicios[i] == servicioAEliminar)
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



