using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices.ObjectiveC;

namespace Clases
{
    public class OperacionesBDMensajes<T> : IOperacionesBD<Mensaje>
    {
        private string CadenaConexion;
        public delegate void MostrarMensajeErrorDelegate(string mensaje);
        public event MostrarMensajeErrorDelegate OnMostrarMensajeError;
        public object usuario;

        public OperacionesBDMensajes(string cadenaConexion, object receptor)
        {
            CadenaConexion = cadenaConexion;
            this.usuario = receptor;
        }
       
        public List<Mensaje> ObtenerTodos(string emisor)
        {
            string consultaSelect = "SELECT * FROM Mensajes WHERE receptor = @receptor AND emisor = @emisor";

            List<Mensaje> mensajes = new List<Mensaje>();

            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();

                    using (MySqlCommand comando = new MySqlCommand(consultaSelect, conexion))
                    {
                        comando.Parameters.AddWithValue("@receptor", usuario.ToString());
                        comando.Parameters.AddWithValue("@emisor", emisor);
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string Contenido = reader["contenido"].ToString();
                                string Emisor = reader["emisor"].ToString();
                                string Receptor = reader["receptor"].ToString();
                                DateTime FechaEnvio = DateTime.TryParse(reader["fechaEnvio"].ToString(), out DateTime fechaEnvio) ? fechaEnvio : DateTime.Now;
                                Mensaje mensaje = new Mensaje(Contenido, Emisor, Receptor, FechaEnvio);
                                mensajes.Add(mensaje);
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
                    EnviarMensajeErrorBD($"Error al obtener todos: {ex}");
                }
                finally
                {
                    conexion.Close();
                }

                return mensajes;
            }
        }

        public void Insertar(Mensaje mensaje)
        {
            string consulta = "INSERT INTO Mensajes (emisor, receptor, fechaEnvio, contenido) " +
                "VALUES (@emisor, @receptor, @fechaEnvio, @contenido)";

            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@emisor", mensaje.Emisor);
                        comando.Parameters.AddWithValue("@receptor", mensaje.Receptor);
                        comando.Parameters.AddWithValue("@fechaEnvio", mensaje.FechaEnvio);
                        comando.Parameters.AddWithValue("@contenido", mensaje.Contenido);

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
                }
            }
        }

        // Implementa los demás métodos de la interfaz IOperacionesBD<Mensaje> según sea necesario
        // ...

        private void EnviarMensajeErrorBD(string mensaje)
        {
            OnMostrarMensajeError?.Invoke(mensaje);
        }

        public void Actualizar(Mensaje entidad)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(Mensaje entidad)
        {
            throw new NotImplementedException();
        }

        public Mensaje ObtenerPor(int identificacion, string consulta)
        {
            throw new NotImplementedException();
        }

        public List<Mensaje> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
