using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Clases;
using MySql.Data.MySqlClient;

namespace Clases
{
    public class OperacionesBDServicio<T> : IOperacionesBD<Servicio>
    {
        private string CadenaConexion;
        private int IdentificacionAdmin;
        public delegate void MostrarMensajeErrorDelegate(string mensaje);

        public event MostrarMensajeErrorDelegate OnMostrarMensajeError;

        public OperacionesBDServicio(string cadenaConexion, int identificacionAdmin)
        {
            CadenaConexion = cadenaConexion;
            IdentificacionAdmin = identificacionAdmin;
        }
        public void Actualizar(Servicio servicioIngresado)
        {
            string consultaUpdate = "UPDATE servicios SET  precio = @precio" +
                        "WHERE identificacionArriendador = @identificacionArriendador AND nombre = @nombre";
            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("Conexion abierta");

                    using (MySqlCommand comando = new MySqlCommand(consultaUpdate, conexion))
                    {
                        // Asignar parámetros con los valores actualizados
                        comando.Parameters.AddWithValue("@precio", servicioIngresado.Precio);

                        comando.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts."))
                    {
                        EnviarMensajeErrorBD("Base de datos desconectada");
                    }
                    else
                    {
                        Console.WriteLine("Error de base de datos: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    EnviarMensajeErrorBD($"Error: {ex}");
                }
                finally
                {
                    conexion.Close();
                    Console.WriteLine("Conexion cerrada");
                }
            }
        }
        public void Actualizar(Servicio servicioIngresado,int dniInquilino , string consulta, bool servicioSeleccionado)
        {
            
            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("Conexion abierta");

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@dniInquilino", dniInquilino);
                        // Asignar parámetros con los valores actualizados
                        if (servicioIngresado.Nombre == "Agua")
                        {
                            comando.Parameters.AddWithValue("@agua", servicioSeleccionado);
                        }
                        if (servicioIngresado.Nombre == "Gas")
                        {
                            comando.Parameters.AddWithValue("@gas", servicioSeleccionado);
                        }
                        if (servicioIngresado.Nombre == "Internet")
                        {
                            comando.Parameters.AddWithValue("@internet", servicioSeleccionado);
                        }
                        if (servicioIngresado.Nombre == "Cable")
                        {
                            comando.Parameters.AddWithValue("@Cable", servicioSeleccionado);
                        }
                        if (servicioIngresado.Nombre == "Luz")
                        {
                            comando.Parameters.AddWithValue("@luz", servicioSeleccionado);
                        }
                        if (servicioIngresado.Nombre == "Alquiler")
                        {
                            comando.Parameters.AddWithValue("@alquiler", servicioSeleccionado);
                        }
                        comando.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts."))
                    {
                        EnviarMensajeErrorBD("Base de datos desconectada");
                    }
                    else
                    {
                        Console.WriteLine("Error de base de datos: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    EnviarMensajeErrorBD($"Error: {ex}");
                }
                finally
                {
                    conexion.Close();
                    Console.WriteLine("Conexion cerrada");
                }
            }
        }
        public void Eliminar(Servicio servicio)
        {
            string consultaDelete = "DELETE FROM servicios WHERE identificacionAdmin  = @identificacionArriendador";

            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("Conexion abierta");

                    using (MySqlCommand comando = new MySqlCommand(consultaDelete, conexion))
                    {
                        comando.Parameters.AddWithValue("@identificacionAdmin", servicio.IdentificacionArriendador);

                        comando.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts."))
                    {
                        EnviarMensajeErrorBD("Base de datos desconectada");
                    }
                    else
                    {
                        Console.WriteLine("Error de base de datos: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    EnviarMensajeErrorBD($"Error: {ex}");
                }
                finally
                {
                    conexion.Close();
                    Console.WriteLine("Conexion cerrada");
                }
            }
        }
        public void Eliminar(Servicio servicio, int dniInquilino)
        {
            string consultaDelete = "DELETE FROM servicios_activos WHERE dniInquilino  = @dniInquilino";

            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("Conexion abierta");

                    using (MySqlCommand comando = new MySqlCommand(consultaDelete, conexion))
                    {
                        comando.Parameters.AddWithValue("@dniInquilino", dniInquilino);

                        comando.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts."))
                    {
                        EnviarMensajeErrorBD("Base de datos desconectada");
                    }
                    else
                    {
                        Console.WriteLine("Error de base de datos: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    EnviarMensajeErrorBD($"Error: {ex}");
                }
                finally
                {
                    conexion.Close();
                    Console.WriteLine("Conexion cerrada");
                }
            }
        }


        public void Insertar(Servicio servicioIngresado)
        {
            string consulta = "INSERT INTO servicios (nombre, precio, identificacionAdmin)" +
                " VALUES (@nombre, @precio, @identificacionAdmin)";
            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("Conexion abierta");

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", servicioIngresado.Nombre);
                        comando.Parameters.AddWithValue("@precio", servicioIngresado.Precio);
                        comando.Parameters.AddWithValue("@identificacionAdmin", servicioIngresado.IdentificacionArriendador);
                 
                        comando.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts."))
                    {
                        EnviarMensajeErrorBD("Base de datos desconectada");
                    }
                    else
                    {
                        Console.WriteLine("Error de base de datos: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    EnviarMensajeErrorBD($"Error al insertar: {ex}");
                }
                finally
                {
                    conexion.Close();
                    Console.WriteLine("Conexion cerrada");

                }
            }
        }
        public void InsertarLista(List<Servicio> serviciosIngresados, Inquilino inquilino)
        {
            if (VerificarRegistro(inquilino.Dni))
            {
                foreach (var servicio in serviciosIngresados)
                {
                    Eliminar(servicio,inquilino.Dni);
                }
                
            }
            string consulta = "INSERT INTO servicios_activos (Agua, Luz, Gas, Internet, Cable, Alquiler, dniInquilino)" +
                " VALUES (@agua, @luz, @gas, @internet, @cable, @alquiler, @dniInquilino)";
            bool agua = false;
            bool luz = false;
            bool internet = false;
            bool cable = false;
            bool alquiler = false;
            bool gas = false;
            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("Conexion abierta");
                    
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@dniInquilino", inquilino.Dni);
                        foreach (Servicio servicioIngresado in serviciosIngresados)
                        {
                            switch (servicioIngresado.Nombre.ToLower())
                            {
                                case "agua":
                                    agua = true;
                                    break;
                                case "gas":
                                    gas = true;
                                    break;
                                case "internet":
                                    internet = true;
                                    break;
                                case "cable":
                                    cable = true;
                                    break;
                                case "luz":
                                    luz= true;
                                    break;
                                case "alquiler":
                                    alquiler = true ;
                                    break;
                            }
                        }
                        comando.Parameters.AddWithValue("@agua", agua);
                        comando.Parameters.AddWithValue("@gas", gas);
                        comando.Parameters.AddWithValue("@internet", internet);
                        comando.Parameters.AddWithValue("@cable", cable);
                        comando.Parameters.AddWithValue("@luz", luz);
                        comando.Parameters.AddWithValue("@alquiler", alquiler);

                        comando.ExecuteNonQuery();
                        
                    }
                }
                catch (MySqlException ex)
                {
                    if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts."))
                    {
                        EnviarMensajeErrorBD("Base de datos desconectada");
                    }
                    else
                    {
                        Console.WriteLine("Error de base de datos: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    EnviarMensajeErrorBD($"Error al insertar: {ex}");
                }
                finally
                {
                    conexion.Close();
                    Console.WriteLine("Conexion cerrada");

                }
            }
        }
        public bool VerificarRegistro(int dniInquilino)
        {
            string consultaSelect = "SELECT COUNT(*) FROM servicios_activos WHERE dniInquilino = @dniInquilino";

            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    //Console.WriteLine("Conexion abierta");

                    using (MySqlCommand comando = new MySqlCommand(consultaSelect, conexion))
                    {
                        comando.Parameters.AddWithValue("@dniInquilino", dniInquilino);
                        
                        int cantidad = Convert.ToInt32(comando.ExecuteScalar());

                        return cantidad > 0;
                    }
                }
                catch (MySqlException ex)
                {
                    if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts."))
                    {
                        EnviarMensajeErrorBD("Base de datos desconectada");
                    }
                    else
                    {
                        Console.WriteLine("Error de base de datos: " + ex.Message);
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    EnviarMensajeErrorBD($"Error al verificar existencia: {ex}");
                    return false;
                }
                finally
                {
                    conexion.Close();
                    //Console.WriteLine("Conexion cerrada");
                }
            }
        }


    
        public Servicio ObtenerPor(int identificacion, string consulta)
        {
            Servicio unServicio = null;
            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                Servicio servicio = new Servicio
                                {

                                    IdentificacionArriendador = int.TryParse(reader["identificacionArriendador"].ToString(), out int identificacionArriendador) ? identificacionArriendador : 0,
                                    Precio = int.TryParse(reader["precio"].ToString(), out int piso) ? piso : 0,
                                    Nombre = reader["nombre"].ToString(),
                                };

                                unServicio = servicio;
                            }

                        }
                    }
                }
                catch (MySqlException ex)
                {
                    if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts."))
                    {
                        EnviarMensajeErrorBD("Base de datos desconectada");
                    }
                    else
                    {
                        Console.WriteLine("Error de base de datos: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    EnviarMensajeErrorBD($"Error: {ex}");
                }

                finally
                {
                    conexion.Close();
                    //Console.WriteLine("Conexion cerrada");

                }
                return unServicio;
            }
        
        }
        public Servicio ObtenerPor(int identificacion, string consulta, string nombreServicio)
        {
            Servicio unServicio = null;
            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", nombreServicio);
                        comando.Parameters.AddWithValue("@identificacionAdmin", identificacion);
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                Servicio servicio = new Servicio
                                {

                                    Nombre = reader["nombre"].ToString(),
                                    Precio = int.TryParse(reader["precio"].ToString(), out int piso) ? piso : 0,
                                    IdentificacionArriendador = int.TryParse(reader["identificacionAdmin"].ToString(), out int identificacionArriendador) ? identificacionArriendador : 0,
                                };

                                unServicio = servicio;
                            }

                        }
                    }
                }
                catch (MySqlException ex)
                {
                    if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts."))
                    {
                        EnviarMensajeErrorBD("Base de datos desconectada");
                    }
                    else
                    {
                        Console.WriteLine("Error de base de datos: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    EnviarMensajeErrorBD($"Error: {ex}");
                }

                finally
                {
                    conexion.Close();
                    //Console.WriteLine("Conexion cerrada");

                }
                return unServicio;
            }

        }

        public List<Servicio> ObtenerServiciosActivos(int identificacion, int dniInquilino)
        {
            List<Servicio> serviciosActivos = new List<Servicio>();


            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();

                    string consulta = @"
                SELECT s.Nombre, s.Precio, s.IdentificacionAdmin
                FROM servicios s
                JOIN servicios_activos a ON 
                    (s.Nombre = 'Agua' AND a.Agua = true) OR
                    (s.Nombre = 'Luz' AND a.Luz = true) OR
                    (s.Nombre = 'Gas' AND a.Gas = true) OR
                    (s.Nombre = 'Internet' AND a.Internet = true) OR
                    (s.Nombre = 'Cable' AND a.Cable = true) OR
                    (s.Nombre = 'Alquiler' AND a.Alquiler = true)
                WHERE s.IdentificacionAdmin = @IdentificacionAdmin AND a.DniInquilino = @DniInquilino
            ";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdentificacionAdmin", identificacion);
                        comando.Parameters.AddWithValue("@DniInquilino", dniInquilino);

                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                Servicio servicio = new Servicio
                                {
                                    Nombre = lector["Nombre"].ToString(),
                                    Precio = Convert.ToInt32(lector["Precio"]),
                                    IdentificacionArriendador = Convert.ToInt32(lector["IdentificacionAdmin"])
                                };
                                    serviciosActivos.Add(servicio);
                                
                            }
                        }
                    }
                }


                catch (MySqlException ex)
                {
                    Console.WriteLine("Error de base de datos: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener servicios activos: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
            return serviciosActivos;;
        }
        public List<Servicio> ObtenerTodos()
        {
            string consultaSelect = "SELECT * FROM servicios WHERE identificacionAdmin = @IdentificacionAdmin";

            List<Servicio> servicios = new List<Servicio>();

            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();

                    using (MySqlCommand comando = new MySqlCommand(consultaSelect, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdentificacionAdmin", IdentificacionAdmin);
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Servicio servicio = new Servicio
                                {
                                    IdentificacionArriendador = int.TryParse(reader["identificacionAdmin"].ToString(), out int identificacionArriendador) ? identificacionArriendador : 0,
                                    Precio = int.TryParse(reader["precio"].ToString(), out int piso) ? piso : 0,
                                    Nombre = reader["nombre"].ToString(),
                                };

                                servicios.Add(servicio);
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts."))
                    {
                        EnviarMensajeErrorBD("Base de datos desconectada");
                    }
                    else
                    {
                        Console.WriteLine("Error de base de datos: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    EnviarMensajeErrorBD($"Error: {ex}");
                }

                finally
                {
                    conexion.Close();
                }
                return servicios;

            }
        }
        public void EnviarMensajeErrorBD(string mensaje)
        {
            OnMostrarMensajeError?.Invoke(mensaje);
        }
    }
}
