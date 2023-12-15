using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Clases;
using MySql.Data.MySqlClient;

namespace Clases
{
    public class OperacionesBDVivienda<T> : IOperacionesBD<Vivienda>
    {
        private string CadenaConexion;
        public delegate void MostrarMensajeErrorDelegate(string mensaje);

        public event MostrarMensajeErrorDelegate OnMostrarMensajeError;

        public OperacionesBDVivienda(string cadenaConexion)
        {
            CadenaConexion = cadenaConexion;

        }

        public List<Vivienda> ObtenerTodos()
        {
            string consultaSelect = "SELECT * FROM viviendas";

            List<Vivienda> viviendas = new List<Vivienda>();

            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();

                    using (MySqlCommand comando = new MySqlCommand(consultaSelect, conexion))
                    {
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Vivienda vivienda = new Vivienda
                                {
                                    direccion = reader["direccion"].ToString(),
                                    numeroHabitaciones = int.TryParse(reader["numeroHabitaciones"].ToString(), out int numeroHabitaciones) ? numeroHabitaciones : 0,
                                    identificacionArriendador = int.TryParse(reader["identificacionArriendador"].ToString(), out int identificacionArriendador) ? identificacionArriendador : 0,
                                    piso = int.TryParse(reader["piso"].ToString(), out int piso) ? piso : 0,
                                    departamento = reader["departamento"].ToString(),
                                    cantInquilinos = int.TryParse(reader["cantInquilinos"].ToString(), out int cantInquilinos) ? cantInquilinos : 0,
                                    DniInquilino = int.TryParse(reader["dniInquilino"].ToString(), out int dniInquilino) ? dniInquilino : 0,
                                };

                                viviendas.Add(vivienda);
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
                return viviendas;

            }
        }

        public void Insertar(Vivienda viviendaIngresada)
        {
            if (VerificarViviendaOcupada(viviendaIngresada))
            {
                EnviarMensajeErrorBD("Vivienda ya está en uso");
                return;
            }
            string consulta = "INSERT INTO viviendas (direccion, numeroHabitaciones, piso, identificacionArriendador, departamento, cantInquilinos, dniInquilino)" +
                " VALUES (@direccion, @numeroHabitaciones, @piso, @identificacionArriendador, @departamento, @cantInquilinos, @dniInquilino)";

            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("Conexion abierta");

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@direccion", viviendaIngresada.direccion);
                        comando.Parameters.AddWithValue("@numeroHabitaciones", viviendaIngresada.numeroHabitaciones);
                        comando.Parameters.AddWithValue("@piso", viviendaIngresada.piso);
                        comando.Parameters.AddWithValue("@identificacionArriendador", viviendaIngresada.identificacionArriendador);
                        comando.Parameters.AddWithValue("@departamento", viviendaIngresada.departamento);
                        comando.Parameters.AddWithValue("@cantInquilinos", viviendaIngresada.cantInquilinos);
                        comando.Parameters.AddWithValue("@dniInquilino",viviendaIngresada.dniInquilino);
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
        public void Actualizar(Vivienda viviendaIngresada)
        {
            string consultaUpdate = "UPDATE viviendas SET direccion = @direccion, numeroHabitaciones = @numeroHabitaciones, piso = @piso, " +
                                    " departamento = @departamento, cantInquilinos = @cantInquilinos, " +
                                    "dniInquilino = @dniInquilino" +
                                    "WHERE identificacionArriendador = @identificacionArriendador";

            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("Conexion abierta");

                    using (MySqlCommand comando = new MySqlCommand(consultaUpdate, conexion))
                    {
                        // Asignar parámetros con los valores actualizados
                        comando.Parameters.AddWithValue("@direccion", viviendaIngresada.direccion);
                        comando.Parameters.AddWithValue("@numeroHabitaciones", viviendaIngresada.numeroHabitaciones);
                        comando.Parameters.AddWithValue("@piso", viviendaIngresada.piso);
                        comando.Parameters.AddWithValue("@identificacionArriendador", viviendaIngresada.identificacionArriendador);
                        comando.Parameters.AddWithValue("@departamento", viviendaIngresada.departamento);
                        comando.Parameters.AddWithValue("@cantInquilinos", viviendaIngresada.cantInquilinos);
                        comando.Parameters.AddWithValue("@dniInquilino", viviendaIngresada.dniInquilino);

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

        public Vivienda ObtenerPor(int identificacion, string consulta)
        {
            //string consulta = "SELECT * FROM administradores WHERE id = @documento";
            Vivienda vivienda = null;

            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("Conexion abierta");

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@dniInquilino", identificacion);
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                vivienda = new Vivienda
                                {
                                    direccion = reader["direccion"].ToString(),
                                    numeroHabitaciones = int.TryParse(reader["numeroHabitaciones"].ToString(), out int numeroHabitaciones) ? numeroHabitaciones : 0,
                                    identificacionArriendador = int.TryParse(reader["identificacionArriendador"].ToString(), out int identificacionArriendador) ? identificacionArriendador : 0,
                                    piso = int.TryParse(reader["piso"].ToString(), out int piso) ? piso : 0,
                                    departamento = reader["departamento"].ToString(),
                                    cantInquilinos = int.TryParse(reader["cantInquilinos"].ToString(), out int cantInquilinos) ? cantInquilinos : 0,
                                    DniInquilino = int.TryParse(reader["dniInquilino"].ToString(), out int dniInquilino) ? dniInquilino : 0,

                                };
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
                    Console.WriteLine("Conexion cerrada");

                }
                return vivienda;
            }
        }
        public List<Vivienda> ObtenerListaPor(int identificacion, string consulta)
        {
            //string consulta = "SELECT * FROM administradores WHERE id = @documento";
            List<Vivienda> viviendas = new List<Vivienda>();
            Vivienda vivienda = null;
            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("Conexion abierta");

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@identificacionArriendador", identificacion);
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                vivienda = new Vivienda
                                {
                                    direccion = reader["direccion"].ToString(),
                                    numeroHabitaciones = int.TryParse(reader["numeroHabitaciones"].ToString(), out int numeroHabitaciones) ? numeroHabitaciones : 0,
                                    identificacionArriendador = int.TryParse(reader["identificacionArriendador"].ToString(), out int identificacionArriendador) ? identificacionArriendador : 0,
                                    piso = int.TryParse(reader["piso"].ToString(), out int piso) ? piso : 0,
                                    departamento = reader["departamento"].ToString(),
                                    cantInquilinos = int.TryParse(reader["cantInquilinos"].ToString(), out int cantInquilinos) ? cantInquilinos : 0,
                                    DniInquilino = int.TryParse(reader["dniInquilino"].ToString(), out int dniInquilino) ? dniInquilino : 0,

                                };
                                viviendas.Add(vivienda);
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
                    Console.WriteLine("Conexion cerrada");

                }
                return viviendas;
            }
        }
        public void Eliminar(Vivienda vivienda)
        {
            string consultaDelete = "DELETE FROM viviendas WHERE identificacionArriendador = @identificacionArriendador";

            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("Conexion abierta");

                    using (MySqlCommand comando = new MySqlCommand(consultaDelete, conexion))
                    {
                        comando.Parameters.AddWithValue("@identificacionArriendador", vivienda.identificacionArriendador);

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
        private bool VerificarViviendaOcupada(Vivienda vivienda)
        {
            string consultaSelect = "SELECT COUNT(*) FROM viviendas WHERE departamento = @departamento AND piso = @piso AND direccion = @direccion";

            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    //Console.WriteLine("Conexion abierta");

                    using (MySqlCommand comando = new MySqlCommand(consultaSelect, conexion))
                    {
                        comando.Parameters.AddWithValue("@departamento", vivienda.departamento);
                        comando.Parameters.AddWithValue("@piso", vivienda.piso);
                        comando.Parameters.AddWithValue("@direccion", vivienda.direccion);
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
        public void EnviarMensajeErrorBD(string mensaje)
        {
            OnMostrarMensajeError?.Invoke(mensaje);
        }
    }
}
