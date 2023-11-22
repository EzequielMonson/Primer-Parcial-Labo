using Clases;
using NestApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Login : Formulario

    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            string correo = this.txtCorreo.Text;
            string contraseña = this.txtContrasenia.Text;
            if (contraseña.Count() > 0 && correo.Count() > 0)
            {
                try
                {
                    // Intenta cargar los datos desde el archivo XML y validar el inicio de sesión
                    List<Administrador> listaAdministradores = Serializadora<Administrador>.CargarDesdeXML("RegistrosAdministrador.xml");
                    List<Inquilino> listaInquilinos = Serializadora<Inquilino>.CargarDesdeJSON("RegistrosInquilino.json");
                    bool usuarioEncontrado = false;
                    foreach (var administrador in listaAdministradores)
                    {
                        if (administrador.correo == correo && administrador.contraseña == contraseña)
                        {
                            // Si la validación es exitosa, muestra el mensaje y abre el formulario del menú
                            MessageBox.Show("Usuario logueado");
                            usuarioEncontrado = true;
                            this.Hide();
                            FrmMenu menuInqui = new FrmMenu();
                            menuInqui.Show();
                            break;
                        } 
                    }
                    foreach (var inquilino in listaInquilinos)
                    {
                        if (inquilino.correo == correo && inquilino.contraseña == contraseña)
                        {
                            // Si la validación es exitosa, muestra el mensaje y abre el formulario del menú
                            MessageBox.Show("Usuario logueado");
                            usuarioEncontrado = true;
                            this.Hide();
                            FrmMenu menuInqui = new FrmMenu();
                            menuInqui.Show();
                            break;
                        }
                    }
                
                    if (!usuarioEncontrado)
                    {
                        // Mostrar mensaje de error si el usuario no se encuentra
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }

                }
                catch (Exception ex)
                {
                    // Manejo de errores en la carga de datos o validación
                    MessageBox.Show($"Error al iniciar sesión: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Los espacios correo y contraseña no pueden estar vacíos");
            }
        }


        private void MostrarContrasenia(object sender, MouseEventArgs e)
        {
            this.txtContrasenia.PasswordChar = '\0';
        }

        private void OcultarContrasenia(object sender, EventArgs e)
        {
            this.txtContrasenia.PasswordChar = '*';
        }

        private void VolverAtras(object sender, EventArgs e)
        {
            this.Hide();
            FrmInicio menu = new FrmInicio();
            menu.Show();
        }
    }
}
