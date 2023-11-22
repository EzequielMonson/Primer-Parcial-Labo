using Clases;
using System.Threading;

namespace ConsoPruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RegistroAdministrador.xml");
            Administrador aaaa = new Administrador("José", "Martin", "Jose2023@Gmail.com", "123abc", "Banfield", "Remax", 12000);
            List<Administrador> listaAdmins = new List<Administrador>();
            listaAdmins.Add(aaaa);
            Administrador eeee = new Administrador("Leo", "Monier", "leomonier@Gmail.com", "chichi22", "Cordoba", "LarsonCompany", 251536231);
            listaAdmins.Add(eeee);
            /*Serializadora<Administrador>.GuardarComoJSON(listaAdmins, rutaArchivo);*/
            Serializadora<Administrador>.GuardarComoXML(listaAdmins, rutaArchivo);
            List<Administrador> NuevaLista;
            NuevaLista = Serializadora<Administrador>.CargarDesdeXML(rutaArchivo);
            Console.WriteLine("guardado como XML.");
            foreach (var admin in NuevaLista) 
            {
                Console.WriteLine(admin.ToString());
            }
            Console.WriteLine($"En: {rutaArchivo}");
            

            

        }
    }
}