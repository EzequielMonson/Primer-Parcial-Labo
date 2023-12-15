using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class OperacionesBDTarjeta<T> : IOperacionesBD<Tarjeta>
    { 
        private string CadenaConexion;
        public delegate void MostrarMensajeErrorDelegate(string mensaje);
        public Inquilino inquilino;

        public event MostrarMensajeErrorDelegate OnMostrarMensajeError;

        public OperacionesBDTarjeta(string cadenaConexion, Inquilino inquilino)
        {
            CadenaConexion = cadenaConexion;
            this.inquilino = inquilino;
        }
        public void Actualizar(Tarjeta tarjeta)
        {
            string consultaUpdate = "UPDATE tarjeta SET  saldo = @saldo, nombreCompleto = @nombreCompleto, cvv = @cvv, numeroTarjeta = @numeroTarjeta WHERE dniInquilino = @dniInquilino";
            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("Conexion abierta");

                    using (MySqlCommand comando = new MySqlCommand(consultaUpdate, conexion))
                    {
                        // Asignar parámetros con los valores actualizados
                        comando.Parameters.AddWithValue("@saldo", tarjeta.Saldo);
                        comando.Parameters.AddWithValue("@nombreCompleto", tarjeta.NombreCompleto);
                        comando.Parameters.AddWithValue("@cvv", tarjeta.Cvv);
                        comando.Parameters.AddWithValue("@numeroTarjeta", tarjeta.NumeroTarjeta);
                        comando.Parameters.AddWithValue("@dniInquilino", inquilino.Dni);

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

        public void Insertar(Tarjeta tarjeta)
        {
            if (ExisteTarjeta())
            {
                EnviarMensajeErrorBD("Datos ya registrados");
                return;
            }
            string consulta = "INSERT INTO tarjeta (nombreCompleto, cvv, numeroTarjeta, saldo, dniInquilino)" +
                " VALUES (@nombreCompleto, @cvv, @numeroTarjeta, @saldo, @dniInquilino)";
            //(string nombreCompleto, int cvv, string numeroTarjeta)
            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("Conexion abierta");

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombreCompleto", tarjeta.NombreCompleto);
                        comando.Parameters.AddWithValue("@cvv", tarjeta.Cvv);
                        comando.Parameters.AddWithValue("@numeroTarjeta", tarjeta.NumeroTarjeta);
                        comando.Parameters.AddWithValue("@saldo", tarjeta.Saldo);
                        comando.Parameters.AddWithValue("@dniInquilino", inquilino.Dni);

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
        public Tarjeta ObtenerPor(int identificacion, string consulta)
        {
            //string consulta = "SELECT * FROM administradores WHERE id = @documento";
            Tarjeta tarjeta = null;
            

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
                                //(int monto, string concepto, DateTime fechaEmision, DateTime fechaVencimiento)
                                int Cvv = int.TryParse(reader["cvv"].ToString(), out int cvv) ? cvv : 0;
                                int Saldo = int.TryParse(reader["saldo"].ToString(), out int saldo) ? saldo : 0;
                                string NombreCompleto = reader["nombreCompleto"].ToString();
                                string NumeroTarjeta = reader["numeroTarjeta"].ToString();
                                

                                tarjeta = new Tarjeta(NombreCompleto, Cvv, NumeroTarjeta);
                                tarjeta.Saldo = Saldo;
                                
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
                return tarjeta;
            }
        }

        public void Eliminar(Tarjeta tarjeta)
        {
            string consultaDelete = "DELETE FROM tarjeta WHERE inquilinoDni = @dniInquilino ";

            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("Conexion abierta");

                    using (MySqlCommand comando = new MySqlCommand(consultaDelete, conexion))
                    {
                        comando.Parameters.AddWithValue("@dniInquilino", inquilino.dni);
                        

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
        private bool ExisteTarjeta()
        {
            string consultaSelect = "SELECT COUNT(*) FROM tarjeta WHERE dniInquilino = @dniInquilino";

            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    //Console.WriteLine("Conexion abierta");

                    using (MySqlCommand comando = new MySqlCommand(consultaSelect, conexion))
                    {
                        comando.Parameters.AddWithValue("@dniInquilino", inquilino.Dni);
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

        public List<Tarjeta> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }

}
