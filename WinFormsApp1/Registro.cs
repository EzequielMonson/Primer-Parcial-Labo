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
        public int dni;
        public int telefono;
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
            this.btnSiguiente.Location = new Point(340, 570);
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
            FrmInicio inicio = new FrmInicio();
            inicio.Show();
        }
        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            nombre = this.txtNombre.Text;
            apellido = this.txtApellido.Text;
            correo = this.txtCorreo.Text;
            fechaNacimiento = this.dtpFechaNacimiento.Text;
            ciudad = this.cboCiudad.Text;
            direccion = this.txtDireccion.Text;

            try
            {
                edad = int.Parse(txtEdad.Text);
                telefono = int.Parse(txtTelefono.Text);
                dni = int.Parse(txtDni.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: El dato no es numérico", "Error", MessageBoxButtons.OK);
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
                this.inquilino = new Inquilino(nombre, apellido, correo, clave, ciudad, fechaNacimiento, telefono, direccion, dni, edad);

                List<Inquilino> inquilinoList = new List<Inquilino> { inquilino };
                string rutaArchivoJSON = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RegistrosInquilino.json");
                Serializadora<Inquilino>.GuardarComoJSON(inquilinoList, rutaArchivoJSON);

                MessageBox.Show($"{this.inquilino.ToString()}");
            }
            else if (rol == "administrador")
            {
                this.administrador = new Administrador(nombre, apellido, correo, clave, ciudad, fechaNacimiento, telefono);

                List<Administrador> adminList = new List<Administrador> { administrador };
                string rutaArchivoXML = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RegistrosAdministrador.xml");
                Serializadora<Administrador>.GuardarComoXML(adminList, rutaArchivoXML);

                MessageBox.Show($"{this.administrador.ToString()}");
            }

            this.Hide();
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }



    }
}
