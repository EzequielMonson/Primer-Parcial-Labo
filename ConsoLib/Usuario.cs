namespace ConsoLib
{
    public class Usuario
    {
        public string nombre;
        public string apellido;
        public string correo;
        public string contraseña;
        public Usuario(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }
        
        public void registrarUsuario()
        { 
            
        }
    }
}