using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class OperacionesBDDeudas<T> : IOperacionesBD<Deuda>
    {
        private string CadenaConexion;
        public delegate void MostrarMensajeErrorDelegate(string mensaje);
        public Inquilino inquilino;

        public event MostrarMensajeErrorDelegate OnMostrarMensajeError;

        public OperacionesBDDeudas(string cadenaConexion, Inquilino inquilino)
        {
            CadenaConexion = cadenaConexion;
            this.inquilino = inquilino;
        }
        public void Actualizar(Deuda entidad)
        {
            throw new NotImplementedException();
        }

        public List<Deuda> ObtenerTodos()
        {
            string consultaSelect = "SELECT * FROM deudas WHERE inquilinoDni = @dniInquilino";

            List<Deuda> deudas = new List<Deuda>();

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

                                int Monto = int.TryParse(reader["monto"].ToString(), out int monto) ? monto : 0;
                                string Concepto = reader["concepto"].ToString();
                                DateTime FechaEmision = DateTime.TryParse(reader["fechaEmision"].ToString(), out DateTime fechaEmision) ? fechaEmision : DateTime.Now;
                                DateTime FechaVencimiento = DateTime.TryParse(reader["fechaVencimiento"].ToString(), out DateTime fechaVencimiento) ? fechaVencimiento : DateTime.Now;
                                
                                Deuda deuda = new Deuda(Monto, Concepto, FechaEmision, FechaVencimiento);
                                deudas.Add(deuda);
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
                return deudas;

            }
        }

        public void Insertar(Deuda deuda)
        {
            if (ExisteDeuda(deuda))
            {
                EnviarMensajeErrorBD("Datos ya registrados");
                return;
            }
            string consulta = "INSERT INTO deudas (monto, concepto, fechaEmision,fechaVencimiento, inquilinoDni)" +
                " VALUES (@monto, @concepto, @fechaEmision, @fechaVencimiento, @dniInquilino)";

            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("Conexion abierta");

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@monto", deuda.Monto);
                        comando.Parameters.AddWithValue("@concepto", deuda.Concepto);
                        comando.Parameters.AddWithValue("@fechaEmision", deuda.FechaEmision);
                        comando.Parameters.AddWithValue("@fechaVencimiento", deuda.FechaVencimiento);
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
        public Deuda ObtenerPor(int identificacion, string consulta)
        {
            //string consulta = "SELECT * FROM administradores WHERE id = @documento";
            Deuda deuda;
            Queue<Deuda> ColaDeudas = new Queue<Deuda>();

            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("Conexion abierta");

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //(int monto, string concepto, DateTime fechaEmision, DateTime fechaVencimiento)

                                int Monto = int.TryParse(reader["Monto"].ToString(), out int monto) ? monto : 0;
                                string Concepto = reader["concepto"].ToString();
                                DateTime FechaEmision = DateTime.TryParse(reader["fechaEmision"].ToString(), out DateTime fechaEmision) ? fechaEmision : DateTime.Now;
                                DateTime FechaVencimiento = DateTime.TryParse(reader["fechaVencimiento"].ToString(), out DateTime fechaVencimiento) ? fechaVencimiento : DateTime.Now;

                                deuda = new Deuda(Monto, Concepto, FechaEmision, FechaVencimiento);
                                ColaDeudas.Enqueue(deuda);
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
                return ColaDeudas.First<Deuda>();
            }
        }

        public void Eliminar(Deuda deuda)
        {
            string consultaDelete = "DELETE FROM deudas WHERE inquilinoDni = @dniInquilino AND @fechaEmision = fechaEmision";

            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("Conexion abierta");

                    using (MySqlCommand comando = new MySqlCommand(consultaDelete, conexion))
                    {
                        comando.Parameters.AddWithValue("@dniInquilino", inquilino.dni);
                        comando.Parameters.AddWithValue("@fechaEmision", deuda.FechaEmision);

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
        private bool ExisteDeuda(Deuda deuda)
        {
            string consultaSelect = "SELECT COUNT(*) FROM deudas WHERE inquilinoDni = @dniInquilino AND fechaEmision = @fechaEmision";

            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    //Console.WriteLine("Conexion abierta");

                    using (MySqlCommand comando = new MySqlCommand(consultaSelect, conexion))
                    {
                        comando.Parameters.AddWithValue("@dniInquilino", inquilino.Dni);
                        comando.Parameters.AddWithValue("@fechaEmision", deuda.FechaEmision);
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
