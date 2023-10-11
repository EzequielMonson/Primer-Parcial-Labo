namespace Clases
{
    public abstract class Usuario
    {
        public string nombre;
        public string apellido;
        public string correo;
        public string contraseña;
        public string ciudad;
        public string agencia;
        internal int saldo;

        protected Usuario(string nombre, string apellido, string correo, string contraseña, string ciudad,string agencia, int saldo)
        {
            this.correo = correo;
            this.contraseña = contraseña;
            this.nombre = nombre;
            this.apellido = apellido;
            this.ciudad = ciudad;
            this.agencia = agencia;
            this.saldo = saldo;
        }
        public override string ToString()
        {
            return $"{nombre} {apellido} {correo} {contraseña} {ciudad} {agencia} {saldo}" ;
        }
        
    }
}