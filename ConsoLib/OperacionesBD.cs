using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Clases
{
   
    public abstract class OperacionesBD<T> : IOperacionesBD<T>
    {
        private MySqlConnection conexion;

        public delegate void MostrarMensajeErrorDelegate(string mensaje);

        public event MostrarMensajeErrorDelegate OnMostrarMensajeError;

        public OperacionesBD(string cadenaConexion)
        {
            this.conexion = new MySqlConnection(cadenaConexion);
        }

        public virtual void Actualizar(T entidad)
        {
            throw new NotImplementedException();
        }

        public virtual void Eliminar(T entidad)
        {
            throw new NotImplementedException();
        }

        public virtual void Insertar(T entidad, string comando)
        {
            using (MySqlCommand comandoSql = new MySqlCommand(comando, conexion))
            {

                try
                {
                    conexion.Open();
                    comandoSql.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al insertar: {ex.Message}");
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        public virtual T ObtenerPor(int identificacion, string consulta)
        {
            throw new NotImplementedException();
        }

        public virtual List<T> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        public void EnviarMensajeErrorBD(string mensaje)
        {
            OnMostrarMensajeError?.Invoke(mensaje);
        }



    }
}
