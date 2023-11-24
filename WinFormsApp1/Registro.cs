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
        public string contraseña;
        public string ciudad;
        public string direccion;
        public string contactoAgencia;
        public string agencia;
        public int identificacion;
        public ValidadorInquilino validadorInquilino;
        public ValidadorAdministrador validadorAdministrador;
        public List<Administrador> listaAdministradores;


        public Registro()
        {
            InitializeComponent();

        }
        private void Registro_Load(object sender, EventArgs e)
        {
            string rutaArchivoXML = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RegistrosAdministrador.xml");
            listaAdministradores = Serializadora<Administrador>.CargarDesdeXML(rutaArchivoXML);

            // Llenar el ComboBox con los nombres de los administradores
            cboArriendador.DataSource = listaAdministradores;
            cboArriendador.DisplayMember = "nombre" + " apellido"; // nombre completo del administrador
            cboArriendador.ValueMember = "identificacion";
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
            direccion = this.txtDireccionVivienda.Text;
            contraseña = this.txtClaveIngreso.Text;
            apellido = this.txtApellido.Text;
            correo = this.txtCorreo.Text;
            fechaNacimiento = this.dtpFechaNacimiento.Text;
            ciudad = this.cboCiudad.Text;
            direccion = this.txtDireccionVivienda.Text;
            contactoAgencia = this.txtContacto.Text;
            agencia = this.txtAgencia.Text;
            telefono = ObtenerValorNumerico(this.txtTelefono.Text);
            dni = ObtenerValorNumerico(this.txtDni.Text);
            edad = ObtenerValorNumerico(this.txtEdad.Text);
            identificacion = ObtenerValorNumerico(this.txtIdentificacion.Text);


            if (rol == "inquilino")
            {
                
                this.inquilino = new Inquilino(nombre, apellido, correo, contraseña, ciudad, fechaNacimiento, telefono, direccion, dni, edad);
                ValidadorInquilino miValidadorInquilino = new ValidadorInquilino(this.inquilino);
                miValidadorInquilino.OnMostrarMensajeError += MostrarMensajeError;
                if (miValidadorInquilino.ValidarRegistro())
                {
                    Administrador administradorSeleccionado = (Administrador)cboArriendador.SelectedItem;

                    this.inquilino = new Inquilino(nombre, apellido, correo, contraseña, ciudad, fechaNacimiento, telefono, direccion, dni, edad);

                    // Crear la vivienda
                    string direccionVivienda = txtDireccionVivienda.Text;
                    int numeroHabitaciones = ObtenerValorNumerico(txtHabitaciones.Text);
                    int pisoVivienda = ObtenerValorNumerico(nudPiso.Text);
                    string departamento = cboDepartamento.Text;
                    int cantInquilinos = ObtenerValorNumerico(nudInquilinos.Text);

                    Vivienda nuevaVivienda = new Vivienda(direccionVivienda, numeroHabitaciones, pisoVivienda, administradorSeleccionado, departamento, cantInquilinos);

                    // Asignar la vivienda al inquilino
                    this.inquilino.ElegirVivienda(nuevaVivienda);

                    // Añadir el inquilino a la lista de inquilinos pendientes del administrador
                    // Actualizar el administrador en la lista y guardar en el archivo XML
                    int adminIndex = listaAdministradores.FindIndex(a => a.identificacion == administradorSeleccionado.identificacion);
                    listaAdministradores[adminIndex] = administradorSeleccionado;

                    string rutaArchivoXML = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RegistrosAdministrador.xml");
                    Serializadora<Administrador>.GuardarComoXML(listaAdministradores, rutaArchivoXML);

                    List<Inquilino> inquilinoList = new List<Inquilino> { inquilino };
                    string rutaArchivoJSON = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RegistrosInquilino.json");
                    Serializadora<Inquilino>.GuardarComoJSON(inquilinoList, rutaArchivoJSON);
                    //dministrador administradorSeleccionado = (Administrador)cboArriendador.SelectedItem;
                    MessageBox.Show($"{this.inquilino.ToString()}");
                    this.Hide();
                    FrmMenu menu = new FrmMenu();
                    menu.SetInquilino(inquilino);
                    menu.Show();
                }
            }
            else if (rol == "administrador")
            {
                this.administrador = new Administrador(nombre, apellido, correo, contraseña, ciudad, fechaNacimiento, telefono, dni, edad, agencia, contactoAgencia, identificacion);
                ValidadorAdministrador miValidadorAdministrador = new ValidadorAdministrador(this.administrador);
                miValidadorAdministrador.OnMostrarMensajeError += MostrarMensajeError;
                if (miValidadorAdministrador.ValidarRegistro())
                {
                    List<Administrador> adminList = new List<Administrador> { administrador };
                    string rutaArchivoXML = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RegistrosAdministrador.xml");
                    Serializadora<Administrador>.GuardarComoXML(adminList, rutaArchivoXML);
                    MessageBox.Show($"{this.administrador.ToString()}");
                    this.Hide();
                    FrmMenu menu = new FrmMenu();
                    menu.SetAdministrador(administrador);
                    menu.Show();
                }
            }

        }
        private int ObtenerValorNumerico(string texto)
        {
            int valor;
            if (int.TryParse(texto, out valor))
            {
                return valor;
            }
            return 0;
        }
        private void MostrarMensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
