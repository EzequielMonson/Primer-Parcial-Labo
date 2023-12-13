using Clases;


namespace Pruebas
{
    [TestClass]
    public class Test_Validador
    {
        [TestMethod]
        public void ValidarAdministrador_DeberiaSerValido()
        {
            ValidadorAdministrador miValidadorAdministrador = new ValidadorAdministrador(unAdministrador);

            bool resultado = miValidadorAdministrador.Validar();

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void ValidarInquilino_DeberiaSerValido()
        {
            ValidadorInquilino miValidadorInquilino = new ValidadorInquilino(unInquilino);

            bool resultado = miValidadorInquilino.ValidarRegistro();

            Assert.IsTrue(resultado);
        }


        // Declarar objetos válidos para las pruebas
        public static DateTime fechaNacimiento = DateTime.Now.AddYears(-20);
        public static DateTime fechaNacimientoAdmin = DateTime.Now.AddYears(-22);
        public static Administrador unAdministrador = new Administrador("Martin", "Gomez", "Martin@gmail.com", "Martin123", "Buenos Aires", fechaNacimientoAdmin, 42722312, 32212313, 22, "Remax", "Remax@gmail.com", 11111);
        public static Inquilino unInquilino = new Inquilino("Tomas", "Lopez", "Tomi@gmail.com", "Tomi123", "Buenos Aires", fechaNacimiento, 42723212, "Av.Venezuela", 32132313, 20);

        private static string CadenaConexion => "SERVER=127.0.0.1;PORT=3306;DATABASE=nestapp;UID=root;PASSWORDS=;";
    }
}