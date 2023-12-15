using System;
using System.Reflection.PortableExecutable;
using Clases;
using MySql.Data.MySqlClient;
public class OperacionesBDAdministrador<T> : IOperacionesBD<Administrador>
{
    private string CadenaConexion;
    public delegate void MostrarMensajeErrorDelegate(string mensaje);

    public event MostrarMensajeErrorDelegate OnMostrarMensajeError;

    public OperacionesBDAdministrador(string cadenaConexion)
    {
        CadenaConexion = cadenaConexion;

    }

    public List<Administrador> ObtenerTodos()
    {
        string consultaSelect = "SELECT * FROM administradores";

        List<Administrador> administradores = new List<Administrador>();

        using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
        {
            try
            {
                conexion.Open();
                //Console.WriteLine("Conexion abierta");

                using (MySqlCommand comando = new MySqlCommand(consultaSelect, conexion))
                {
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Administrador administrador = new Administrador
                            {
                                nombre = reader["nombre"].ToString(),
                                apellido = reader["apellido"].ToString(),
                                correo = reader["correo"].ToString(),
                                contraseña = reader["clave"].ToString(),
                                ciudad = reader["ciudad"].ToString(),
                                fechaNacimiento = DateTime.TryParse(reader["fechaNacimiento"].ToString(), out DateTime fechaNacimiento) ? fechaNacimiento : DateTime.Now,
                                telefono = reader.IsDBNull(reader.GetOrdinal("telefono")) ? 0 : reader.GetInt32(reader.GetOrdinal("Telefono")),
                                dni = int.TryParse(reader["dni"].ToString(), out int dni) ? dni : 0,
                                edad = int.TryParse(reader["edad"].ToString(), out int edad) ? edad : 0,
                                agencia = reader["agencia"].ToString(),
                                contactoAgencia = reader["contactoAgencia"].ToString(),
                                Identificacion = int.TryParse(reader["identificacion"].ToString(), out int Identificacion) ? Identificacion : 0,

                            };

                            administradores.Add(administrador);
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
            return administradores;

        }
    }

    public void Insertar(Administrador administradorIngresado)
    {
        if (ExisteAdministradorConDni(administradorIngresado.dni))
        {
            EnviarMensajeErrorBD("Datos ya registrados");
            return;
        }
        string consulta = "INSERT INTO administradores (nombre, apellido, correo, clave, ciudad, fechaNacimiento, telefono, dni, edad, agencia, contactoAgencia, identificacion)"+
            " VALUES (@nombre, @apellido, @correo, @clave, @ciudad, @fechaNacimiento, @telefono, @dni, @edad, @agencia, @contactoAgencia, @identificacion)";

        using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion abierta");

                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", administradorIngresado.nombre);
                    comando.Parameters.AddWithValue("@apellido", administradorIngresado.apellido);
                    comando.Parameters.AddWithValue("@correo", administradorIngresado.correo);
                    comando.Parameters.AddWithValue("@clave", administradorIngresado.contraseña);
                    comando.Parameters.AddWithValue("@ciudad", administradorIngresado.ciudad);
                    comando.Parameters.AddWithValue("@fechaNacimiento", administradorIngresado.fechaNacimiento);
                    comando.Parameters.AddWithValue("@telefono", administradorIngresado.telefono);
                    comando.Parameters.AddWithValue("@agencia", administradorIngresado.agencia);
                    comando.Parameters.AddWithValue("@dni", administradorIngresado.dni);
                    comando.Parameters.AddWithValue("@edad", administradorIngresado.edad);
                    comando.Parameters.AddWithValue("@contactoAgencia", administradorIngresado.contactoAgencia);
                    comando.Parameters.AddWithValue("@identificacion", administradorIngresado.Identificacion);
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
    public void Actualizar(Administrador administradorIngresado)
    {
        string consultaUpdate = "UPDATE Inquilinos SET nombre = @nombre, apellido = @apellido, correo = @correo, " +
                                "clave = @clave, ciudad = @ciudad, fechaNacimiento = @fechaNacimiento, " +
                                "telefono = @telefono, direccion = @direccion, dni = @dni, edad = @edad, estado = @estado " +
                                "WHERE id = @id";

        using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion abierta");

                using (MySqlCommand comando = new MySqlCommand(consultaUpdate, conexion))
                {
                    // Asignar parámetros con los valores actualizados
                    comando.Parameters.AddWithValue("@nombre", administradorIngresado.nombre);
                    comando.Parameters.AddWithValue("@apellido", administradorIngresado.apellido);
                    comando.Parameters.AddWithValue("@correo", administradorIngresado.correo);
                    comando.Parameters.AddWithValue("@clave", administradorIngresado.contraseña);
                    comando.Parameters.AddWithValue("@ciudad", administradorIngresado.ciudad);
                    comando.Parameters.AddWithValue("@fechaNacimiento", administradorIngresado.fechaNacimiento);
                    comando.Parameters.AddWithValue("@telefono", administradorIngresado.telefono);
                    comando.Parameters.AddWithValue("@agencia", administradorIngresado.agencia);
                    comando.Parameters.AddWithValue("@dni", administradorIngresado.dni);
                    comando.Parameters.AddWithValue("@edad", administradorIngresado.edad);
                    comando.Parameters.AddWithValue("@contactoAgencia", administradorIngresado.contactoAgencia);
                    comando.Parameters.AddWithValue("@identificacion", administradorIngresado.Identificacion);

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

    public Administrador ObtenerPor(int identificacion, string consulta)
    {
        //string consulta = "SELECT * FROM administradores WHERE id = @documento";
        Administrador administrador = null;

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
                            administrador = new Administrador
                            {
                                nombre = reader["nombre"].ToString(),
                                apellido = reader["apellido"].ToString(),
                                correo = reader["correo"].ToString(),
                                contraseña = reader["clave"].ToString(),
                                ciudad = reader["ciudad"].ToString(),
                                fechaNacimiento = DateTime.TryParse(reader["fechaNacimiento"].ToString(), out DateTime fechaNacimiento) ? fechaNacimiento : DateTime.Now,
                                telefono = reader.IsDBNull(reader.GetOrdinal("telefono")) ? 0 : reader.GetInt32(reader.GetOrdinal("Telefono")),
                                dni = int.TryParse(reader["dni"].ToString(), out int dni) ? dni : 0,
                                edad = int.TryParse(reader["edad"].ToString(), out int edad) ? edad : 0,
                                agencia = reader["agencia"].ToString(),
                                contactoAgencia = reader["contactoAgencia"].ToString(),
                                Identificacion = int.TryParse(reader["identificacion"].ToString(), out int Identificacion) ? Identificacion : 0,

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
            return administrador;
        }
    }
    public void Eliminar(Administrador administrador)
    {
        string consultaDelete = "DELETE FROM administradores WHERE dni = @dni";

        using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion abierta");

                using (MySqlCommand comando = new MySqlCommand(consultaDelete, conexion))
                {
                    comando.Parameters.AddWithValue("@dni", administrador.dni);

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
    private bool ExisteAdministradorConDni(int dni)
    {
        string consultaSelect = "SELECT COUNT(*) FROM administradores WHERE dni = @dni";

        using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
        {
            try
            {
                conexion.Open();
                //Console.WriteLine("Conexion abierta");

                using (MySqlCommand comando = new MySqlCommand(consultaSelect, conexion))
                {
                    comando.Parameters.AddWithValue("@dni", dni);

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


