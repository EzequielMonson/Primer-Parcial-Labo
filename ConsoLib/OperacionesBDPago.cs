using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class OperacionesBSPago<T> : IOperacionesBD<Pago>
    {
        private string CadenaConexion;
        public delegate void MostrarMensajeErrorDelegate(string mensaje);
        public Inquilino inquilino;

        public event MostrarMensajeErrorDelegate OnMostrarMensajeError;

        public OperacionesBSPago(string cadenaConexion, Inquilino inquilino)
        {
            CadenaConexion = cadenaConexion;
            this.inquilino = inquilino;
        }
        public void Actualizar(Pago entidad)
        {
            throw new NotImplementedException();
        }

        public List<Pago> ObtenerTodos()
        {
            string consultaSelect = "SELECT * FROM pagos WHERE inquilinoDni = @dniInquilino";

            List<Pago> pagos = new List<Pago>();

            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();

                    using (MySqlCommand comando = new MySqlCommand(consultaSelect, conexion))
                    {
                        comando.Parameters.AddWithValue("@dniInquilino", inquilino.Dni);
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //(int monto, string concepto, DateTime fechaEmision, DateTime fechaVencimiento)
                                
                                int CantidadAbonada = int.TryParse(reader["cantidadAbonada"].ToString(), out int cantidadAbonada) ? cantidadAbonada : 0;
                                int DniInquilino = int.TryParse(reader["inquilinoDni"].ToString(), out int dniInquilino) ? dniInquilino : 0;
                                DateTime FechaAbono = DateTime.TryParse(reader["fechaAbono"].ToString(), out DateTime fechaAbono) ? fechaAbono : DateTime.Now;
                                DateTime FechaVencimiento = DateTime.TryParse(reader["fechaVencimiento"].ToString(), out DateTime fechaVencimiento) ? fechaVencimiento : DateTime.Now;

                                Pago pago = new Pago(cantidadAbonada,fechaVencimiento, fechaAbono);
                                pagos.Add(pago);
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
                return pagos;

            }
        }

        public void Insertar(Pago pago)
        {
            string consulta = "INSERT INTO pagos (fechaAbono, cantidadAbonada,fechaVencimiento, inquilinoDni)" +
                " VALUES (@fechaAbono, @cantidadAbonada, @fechaVencimiento, @dniInquilino)";
            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("Conexion abierta");

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@fechaAbono", pago.FechaAbono);
                        comando.Parameters.AddWithValue("@cantidadAbonada", pago.CantidadAbonada);
                        comando.Parameters.AddWithValue("@fechaVencimiento", pago.FechaVencimiento);
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


        public void Eliminar(Pago pago)
        {
            string consultaDelete = "DELETE FROM deudas WHERE dniInquilino = @dniInquilino AND @fechaAbono == fechaAbono";

            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("Conexion abierta");

                    using (MySqlCommand comando = new MySqlCommand(consultaDelete, conexion))
                    {
                        comando.Parameters.AddWithValue("@dniInquilino", inquilino.dni);
                        comando.Parameters.AddWithValue("@fechaAbono", pago.FechaAbono);

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
        public void EnviarMensajeErrorBD(string mensaje)
        {
            OnMostrarMensajeError?.Invoke(mensaje);
        }

        public Pago ObtenerPor(int identificacion, string consulta)
        {
            throw new NotImplementedException();
        }
    }

}
