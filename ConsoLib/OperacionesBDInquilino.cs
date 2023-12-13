using System;
using System.Reflection.PortableExecutable;
using Clases;
using MySql.Data.MySqlClient;
public class OperacionesBDInquilino<T> : OperacionesBD<Inquilino>
{
    private string CadenaConexion;
    public OperacionesBDInquilino(string cadenaConexion) : base(cadenaConexion)
    {
        CadenaConexion = cadenaConexion;

    }

    public override List<Inquilino> ObtenerTodos()
    {
        string consultaSelect = "SELECT * FROM Inquilinos";

        List<Inquilino> inquilinos = new List<Inquilino>();

        using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
        { 
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion abierta");

                using (MySqlCommand comando = new MySqlCommand(consultaSelect, conexion))
                {
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Inquilino inquilino = new Inquilino
                            {
                                nombre = reader["nombre"].ToString(),
                                apellido = reader["apellido"].ToString(),
                                correo = reader["correo"].ToString(),
                                contraseña = reader["clave"].ToString(),
                                ciudad = reader["ciudad"].ToString(),
                                fechaNacimiento = DateTime.TryParse(reader["fechaNacimiento"].ToString(), out DateTime fechaNacimiento) ? fechaNacimiento: DateTime.Now,
                                telefono = reader.IsDBNull(reader.GetOrdinal("telefono")) ? 0 : reader.GetInt32(reader.GetOrdinal("Telefono")),
                                Direccion = reader["direccion"].ToString(),
                                dni = int.TryParse(reader["dni"].ToString(), out int dni) ? dni : 0,
                                edad = int.TryParse(reader["edad"].ToString(), out int edad) ? edad : 0,
                                Estado = Enum.TryParse(reader["estado"].ToString(), out Estado estado) ? estado : Estado.Pendiente
                            };

                            inquilinos.Add(inquilino);
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
                EnviarMensajeErrorBD($"Error al obetener todos: {ex}");
            }
            finally
            {
                conexion.Close();
                Console.WriteLine("Conexion cerrada");

            }
            return inquilinos;

        }
    }

    public override void Insertar(Inquilino inquilinoIngresado, string consulta)
    {
        if (ExisteInquilinoConDni(inquilinoIngresado.dni))
        {
            EnviarMensajeErrorBD("Datos ya registrados");
            return;
        }
        using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion abierta");

                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", inquilinoIngresado.nombre);
                    comando.Parameters.AddWithValue("@apellido", inquilinoIngresado.apellido);
                    comando.Parameters.AddWithValue("@correo", inquilinoIngresado.correo);
                    comando.Parameters.AddWithValue("@clave", inquilinoIngresado.contraseña);
                    comando.Parameters.AddWithValue("@ciudad", inquilinoIngresado.ciudad);
                    comando.Parameters.AddWithValue("@fechaNacimiento", inquilinoIngresado.fechaNacimiento);
                    comando.Parameters.AddWithValue("@telefono", inquilinoIngresado.telefono);
                    comando.Parameters.AddWithValue("@direccion", inquilinoIngresado.Direccion);
                    comando.Parameters.AddWithValue("@dni", inquilinoIngresado.dni);
                    comando.Parameters.AddWithValue("@edad", inquilinoIngresado.edad);
                    comando.Parameters.AddWithValue("@estado", inquilinoIngresado.Estado);
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
    public override void Actualizar(Inquilino inquilino)
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
                    comando.Parameters.AddWithValue("@nombre", inquilino.nombre);
                    comando.Parameters.AddWithValue("@apellido", inquilino.apellido);
                    comando.Parameters.AddWithValue("@correo", inquilino.correo);
                    comando.Parameters.AddWithValue("@clave", inquilino.contraseña);
                    comando.Parameters.AddWithValue("@ciudad", inquilino.ciudad);
                    comando.Parameters.AddWithValue("@fechaNacimiento", inquilino.fechaNacimiento);
                    comando.Parameters.AddWithValue("@telefono", inquilino.telefono);
                    comando.Parameters.AddWithValue("@direccion", inquilino.Direccion);
                    comando.Parameters.AddWithValue("@dni", inquilino.dni);
                    comando.Parameters.AddWithValue("@edad", inquilino.edad);
                    comando.Parameters.AddWithValue("@estado", inquilino.Estado);

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
                EnviarMensajeErrorBD($"Error al actualizar: {ex}");
            }
            finally
            {
                conexion.Close();
                Console.WriteLine("Conexion cerrada");
            }
        }
    }

    public override Inquilino ObtenerPor(int documento, string consulta)
    {
        //string consulta = "SELECT * FROM Inquilinos WHERE id = @documento";
        Inquilino inquilino = null;

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
                            inquilino = new Inquilino
                            {
                                nombre = reader["nombre"].ToString(),
                                apellido = reader["apellido"].ToString(),
                                correo = reader["correo"].ToString(),
                                contraseña = reader["clave"].ToString(),
                                ciudad = reader["ciudad"].ToString(),
                                fechaNacimiento = DateTime.TryParse(reader["fechaNacimiento"].ToString(), out DateTime fechaNacimiento) ? fechaNacimiento : DateTime.Now,
                                telefono = reader.IsDBNull(reader.GetOrdinal("telefono")) ? 0 : reader.GetInt32(reader.GetOrdinal("Telefono")),
                                Direccion = reader["direccion"].ToString(),
                                dni = int.TryParse(reader["dni"].ToString(), out int dni) ? dni : 0,
                                edad = int.TryParse(reader["edad"].ToString(), out int edad) ? edad : 0,
                                Estado = Enum.TryParse(reader["estado"].ToString(), out Estado estado) ? estado : Estado.Pendiente
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
                EnviarMensajeErrorBD($"Error al obtener: {ex}");
            }
            finally
            {
                conexion.Close();
                Console.WriteLine("Conexion cerrada");

            }
            return inquilino;
        }
    }
    public override void Eliminar(Inquilino inquilino)
    {
        string consultaDelete = "DELETE FROM Inquilinos WHERE dni = @dni";

        using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion abierta");

                using (MySqlCommand comando = new MySqlCommand(consultaDelete, conexion))
                {
                    comando.Parameters.AddWithValue("@dni", inquilino.dni);

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
                EnviarMensajeErrorBD($"Error al eliminar: {ex}");
            }
            finally
            {
                conexion.Close();
                Console.WriteLine("Conexion cerrada");
            }
        }
    }
    private bool ExisteInquilinoConDni(int dni)
    {
        string consultaSelect = "SELECT COUNT(*) FROM Inquilinos WHERE dni = @dni";

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


}