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
        public OperacionesBDInquilino<Inquilino> baseDatosInquilinos;
        public OperacionesBDAdministrador<Administrador> baseDatosAdministradores;
        public string cadenaConexion;
        public Login()
        {
            InitializeComponent();
            cadenaConexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=nestapp;UID=root;PASSWORDS=;";
            baseDatosInquilinos = new OperacionesBDInquilino<Inquilino>(cadenaConexion);
            baseDatosAdministradores = new OperacionesBDAdministrador<Administrador>(cadenaConexion);
            baseDatosInquilinos.OnMostrarMensajeError += MostrarMensaje;
            baseDatosAdministradores.OnMostrarMensajeError += MostrarMensaje;
            
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            string correo = this.txtCorreo.Text;
            string contraseña = this.txtContrasenia.Text;
            if (contraseña.Count() > 0 && correo.Count() > 0)
            {
                try
                {
                    bool usuarioEncontrado = false;

                    List<Administrador> listaAdministradores = baseDatosAdministradores.ObtenerTodos();
                        
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
                    if (!usuarioEncontrado)
                    {
                        List<Inquilino> listaInquilinos = baseDatosInquilinos.ObtenerTodos();

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
                    if (!usuarioEncontrado)
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
        private void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
