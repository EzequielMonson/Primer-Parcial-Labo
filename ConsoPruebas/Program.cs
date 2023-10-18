using Clases;
using System.Threading;

namespace ConsoPruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Administrador UnAdmin = new Administrador("José", "Martin", "Jose2023@Gmail.com", "123abc", "Banfield", "Remax", 12000);
            Inquilino UnInquilino = new Inquilino("Raul", "Suarez", "RSuarez@hotmail.com", "Heladera123", "Banfield", "Remax", 30000, "Av brasil 3400");

            Console.WriteLine(UnAdmin.ToString());
            Console.WriteLine(UnInquilino.ToString());
            UnAdmin.AgregarPago(UnInquilino.ColaDeudas, "10-10-2023", "10-09-2023", 10000);
            */
            File.WriteAllText(@".\archivo.txt", "hola mundo");

        }
    }
}