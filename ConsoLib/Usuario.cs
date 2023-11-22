namespace Clases
{
    public abstract class Usuario
    {
        public string nombre;
        public string apellido;
        public string correo;
        public string contraseña;
        public string ciudad;
        public string fechaNacimiento;
        public int telefono;
        public int saldo;
        public List<Actividad> actividades;

        public Usuario()
        {
        }
        protected Usuario(string nombre, string apellido, string correo, string contraseña, string ciudad, string fechaNacimiento, int telefono)
        {
            this.correo = correo;
            this.contraseña = contraseña;
            this.nombre = nombre;
            this.apellido = apellido;
            this.ciudad = ciudad;
            this.fechaNacimiento = fechaNacimiento;
            this.telefono = telefono;
            saldo = 0;
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