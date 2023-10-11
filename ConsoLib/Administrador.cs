using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Administrador : Usuario
    {
        public Administrador(string nombre, string apellido, string correo, string contraseña, string ciudad, string agencia, int saldo) : base(nombre, apellido, correo, contraseña, ciudad, agencia, saldo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.contraseña = contraseña;
            this.ciudad = ciudad;
            this.agencia = agencia;
            this.saldo = saldo;
        }
        public void AgregarPago(Queue<Dictionary<string, object>> colaDeudas, string vencimiento, string fecha, int monto )
        {
            Dictionary<string, object> dictDeuda = new Dictionary<string, object>
            {
                { "vencimiento" , vencimiento},
                { "fecha" , fecha },
                { "monto", monto }
            };
            colaDeudas.Enqueue(dictDeuda);
        }
    }
}
