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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                    
                    string rutaAdmin = "RegistrosAdministrador.json";
                    string rutaInqui = "RegistrosInquilino.json";
                    bool usuarioEncontrado = false;
                    if (File.Exists(rutaAdmin))
                    {

                        List<Administrador> listaAdministradores = Serializadora<Administrador>.CargarDesdeJSON("RegistrosAdministrador.json");
                        
                        foreach (var administrador in listaAdministradores)
                        {
                            if (administrador.correo == correo && administrador.contraseña == contraseña)
                            {
                                
                                MessageBox.Show("Usuario logueado");
                                usuarioEncontrado = true;
                                this.Hide();
                                FrmMenu menuAdmin = new FrmMenu();
                                menuAdmin.SetAdministrador(administrador);
                                menuAdmin.Show();

                                break;
                            }
                        }

                    }
                    if (File.Exists(rutaInqui) && !usuarioEncontrado)
                    {
                        List<Inquilino> listaInquilinos = Serializadora<Inquilino>.CargarDesdeJSON("RegistrosInquilino.json");

                        foreach (var inquilino in listaInquilinos)
                        {
                            if (inquilino.correo == correo && inquilino.contraseña == contraseña)
                            {
                                
                                MessageBox.Show("Usuario logueado");
                                usuarioEncontrado = true;
                                this.Hide();
                                FrmMenu menuInqui = new FrmMenu();
                                menuInqui.SetInquilino(inquilino);
                                menuInqui.Show();
                                break;
                            }
                        }

                    }
                    else if (File.Exists(rutaInqui) && File.Exists(rutaAdmin))
                    {
                        MessageBox.Show("No hay registros de usuarios.");
                    }
                    else if (!usuarioEncontrado)
                    {
                        
                        MessageBox.Show("Usuario o contraseña incorrectos");

                    }

                }
                catch (Exception ex)
                {
                    
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
            FrmInicio inicio = new FrmInicio();
            inicio.Show();
        }
    }
}
