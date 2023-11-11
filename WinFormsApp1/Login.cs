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
            if (this.txtCorreo.Text == "Hola" && this.txtContrasenia.Text == "123")
            {
                MessageBox.Show("Usuario logueado");
                this.Hide();
                FrmMenu menuInqui = new FrmMenu();
                menuInqui.Show();
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
