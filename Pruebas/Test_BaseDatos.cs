using Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    [TestClass]
    public class Test_BaseDatos
    {
        [TestMethod]
        public void InsertarAdministrador_EnBaseDeDatos()
        {
            OperacionesBDAdministrador<Administrador> baseDatosAdmin = new OperacionesBDAdministrador<Administrador>(CadenaConexion);
            
            List<Administrador> listaAdministradores = baseDatosAdmin.ObtenerTodos();
            Assert.IsNotNull(listaAdministradores);
            baseDatosAdmin.Insertar(unAdministrador);
            
            Assert.AreEqual(listaAdministradores.Count()+1, baseDatosAdmin.ObtenerTodos().Count);
        }
        [TestMethod]
        public void InsertarInquilino_EnBaseDeDatos()
        {
            OperacionesBDInquilino<Inquilino> baseDatosInqui = new OperacionesBDInquilino<Inquilino>(CadenaConexion);
            

            List<Inquilino> listaInquilinos = baseDatosInqui.ObtenerTodos();
            Assert.IsNotNull(listaInquilinos);
            baseDatosInqui.Insertar(unInquilino);

            Assert.AreEqual(listaInquilinos.Count(), baseDatosInqui.ObtenerTodos().Count);
        }
        [TestMethod]
        public void ObtenerTodosLosInquilinos_EnBaseDeDatos()
        {
            OperacionesBDInquilino<Inquilino> baseDatosInqui = new OperacionesBDInquilino<Inquilino>(CadenaConexion);

            List<Inquilino> listaInquilinos = baseDatosInqui.ObtenerTodos();

            Assert.IsNotNull(listaInquilinos);
            //Assert.IsTrue(listaInquilinos.Any()); 
            Assert.IsInstanceOfType(listaInquilinos, typeof(List<Inquilino>)); 
        }
        [TestMethod]
        public void ObtenerTodosLosAdministradores_EnBaseDeDatos()
        {
            OperacionesBDAdministrador<Administrador> baseDatosAdmin = new OperacionesBDAdministrador<Administrador>(CadenaConexion);

            List<Administrador> listaAdministradores = baseDatosAdmin.ObtenerTodos();

            Assert.IsNotNull(listaAdministradores);
            //Assert.IsTrue(listaAdministradores.Any());
            Assert.IsInstanceOfType(listaAdministradores, typeof(List<Administrador>));
        }
        [TestMethod]
        public void EliminarUnInquilino_EnBaseDeDatos()
        {
            OperacionesBDInquilino<Inquilino> baseDatosInqui = new OperacionesBDInquilino<Inquilino>(CadenaConexion);

            baseDatosInqui.Eliminar(unInquilino);

            System.Threading.Thread.Sleep(1000); 

            Assert.IsNull(baseDatosInqui.ObtenerPor(unInquilino.Dni, "SELECT * FROM Inquilinos WHERE dni = @dni"));
        }

        [TestMethod]
        public void EliminarUnAdministrador_EnBaseDeDatos()
        {
            OperacionesBDAdministrador<Administrador> baseDatosAdmin = new OperacionesBDAdministrador<Administrador>(CadenaConexion);

            baseDatosAdmin.Eliminar(unAdministrador);

            System.Threading.Thread.Sleep(1000); 

            Assert.IsNull(baseDatosAdmin.ObtenerPor(unAdministrador.Identificacion, "SELECT * FROM Administradores WHERE identificacion = @identificacion"));
        }

        public static DateTime fechaNacimientoInqui = DateTime.Now.AddYears(-20);
        public static DateTime fechaNacimientoAdmin = DateTime.Now.AddYears(-22);
        public static Administrador unAdministrador = new Administrador("Martin", "Gomez", "Martin@gmail.com", "Martin123", "Buenos Aires", fechaNacimientoAdmin, 42722312, 32212313, 22, "Remax", "Remax@gmail.com", 11111);
        public static Inquilino unInquilino = new Inquilino("Tomas", "Lopez", "Tomi@gmail.com", "Tomi123", "Buenos Aires", fechaNacimientoInqui, 42723212, "Av.Venezuela", 32132313, 20);
        private static string CadenaConexion => "SERVER=127.0.0.1;PORT=3306;DATABASE=nestapp;UID=root;PASSWORDS=;";
    }
    
}
