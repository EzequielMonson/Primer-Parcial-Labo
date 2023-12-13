namespace Clases
{

    public abstract class Usuario
    {
        public string nombre;
        public string apellido;
        public string correo;
        public string contraseña;
        public string ciudad;
        public DateTime fechaNacimiento;
        public int telefono;
        public int dni;
        public int edad;
        public int saldo;
        public List<Actividad> actividades;
        
        public Usuario()
        {
        }
        protected Usuario(string nombre, string apellido, string correo, string contraseña, string ciudad, DateTime fechaNacimiento, int telefono, int dni, int edad)
        {
            this.correo = correo;
            this.contraseña = contraseña;
            this.nombre = nombre;
            this.apellido = apellido;
            this.ciudad = ciudad;
            this.fechaNacimiento = fechaNacimiento;
            this.telefono = telefono;
            saldo = 0;
            this.dni = dni;
            this.edad = edad;
            
        }
        public virtual void MostrarHistorialActividades()
        {
            foreach (var actividad in actividades)
            {
                Console.WriteLine($"{actividad.FechaHora} - {actividad.Tipo}");
            }
        }
        public abstract void AgregarActividad(string tipo);

        public abstract void MostrarHistorialPagos();
        public override string ToString()
        {
            return $"{nombre} {apellido}" ;
        }
        
    }
}