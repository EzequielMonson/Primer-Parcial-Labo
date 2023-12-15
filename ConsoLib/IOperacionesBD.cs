using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public interface IOperacionesBD<T>
    {


        void Insertar(T entidad);
        void Actualizar(T entidad);
        void Eliminar(T entidad);
        T ObtenerPor(int identificacion, string consulta);
        List<T> ObtenerTodos();
    }

}
