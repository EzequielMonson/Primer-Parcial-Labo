using Clases;
using Microsoft.VisualBasic.Logging;
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
    public partial class Registro : Formulario
    {
        public Administrador administrador;
        public Inquilino inquilino;
        public string nombre;
        public string apellido;
        public string correo;
        public string dni;
        public string telefono;
        public int edad;
        public string fechaNacimiento;
        public string rol;
        public string clave;
        public string ciudad;
        public string direccion;




        public Registro()
        {
            InitializeComponent();

        }
        private void Registro_Load(object sender, EventArgs e)
        {
        }
        private void RadInquilino_CheckedChanged(object sender, EventArgs e)
        {
            this.grpDatosViviendas.Visible = true;
            this.grpDatosEmpleo.Visible = false;
            rol = "inquilino";
            this.btnSiguiente.Visible = true;
            this.btnSiguiente.Location = new Point(264, 143);
            this.grpDatosIngreso.Visible = true;

        }

        private void radAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            this.grpDatosViviendas.Visible = false;
            this.grpDatosEmpleo.Visible = true;
            this.grpDatosEmpleo.Location = grpDatosViviendas.Location;
            rol = "administrador";
            this.grpDatosIngreso.Visible = true;
            this.btnSiguiente.Visible = true;
            this.btnSiguiente.Location = new Point(340, 570);
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInicio menu = new FrmInicio();
            menu.Show();
        }
        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            nombre = this.txtNombre.Text;
            apellido = this.txtApellido.Text;
            correo = this.txtCorreo.Text;
            dni = this.txtDni.Text;
            telefono = this.txtTelefono.Text;
            fechaNacimiento = this.dtpFechaNacimiento.Text;
            ciudad = this.cboCiudad.Text;
            direccion = this.txtDireccion.Text; 
            try
            {
                edad = int.Parse(this.txtEdad.Text);
            }
            catch (FormatException)
            {
              
                MessageBox.Show("Error: El dato edad no es númerico","Error" ,MessageBoxButtons.OK);
            }
            if (edad < 18)
            {
                MessageBox.Show("Usted no puede registrarse porque no es un adulto.", "Error", MessageBoxButtons.OK);
            }
            
            if ((this.txtClaveIngreso.Text == this.txtConfirmacionClave.Text) && (correo == this.txtCorfirmacionCorreo.Text))
            {
                clave = this.txtClaveIngreso.Text;
                correo = this.txtCorreo.Text;
            }
            else
            {
                MessageBox.Show("Los datos de ingreso no son iguales. ", "Error", MessageBoxButtons.OK);

            }
            if (rol == "inquilino")
            {
                MessageBox.Show("inquilino", "Log in", MessageBoxButtons.OK);
                this.inquilino = new Inquilino(nombre, apellido, correo, clave, ciudad, 1000, direccion);
                MessageBox.Show(this.inquilino.ToString());         
            }
            else
            {
                MessageBox.Show("Administador");
            }


        }

        private void chklServicios_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

    }
}
