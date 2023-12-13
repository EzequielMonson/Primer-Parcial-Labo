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
        public DateTime fechaNacimiento;
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
        public string confirmacionCorreo;
        public string confirmacionContraseña;
        public List<Servicio> ListaServiciosSeleccionados { get; set; }

        public Registro()
        {
            InitializeComponent();
            ListaServiciosSeleccionados = new List<Servicio>();

        }
        private void Registro_Load(object sender, EventArgs e)
        {
            string rutaArchivoAdminJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RegistrosAdministrador.json");
            if (File.Exists(rutaArchivoAdminJson))
            {
                listaAdministradores = Serializadora<Administrador>.CargarDesdeJSON(rutaArchivoAdminJson);
                // Llenar el ComboBox con los nombres de los administradores
                cboArriendador.DataSource = listaAdministradores;
                cboArriendador.DisplayMember = "ToString"; // nombre completo del administrador
                cboArriendador.ValueMember = null;
            }
            chklServicios.DataSource = Enum.GetValues(typeof(NombreServicios));
        }
        private void ObtenerServiciosSeleccionados()
        {
            ListaServiciosSeleccionados.Clear();

            foreach (NombreServicios nombreServicio in chklServicios.CheckedItems)
            {
                int precio = ObtenerPrecioServicio(nombreServicio);
                string nombre = Enum.GetName(typeof(NombreServicios), nombreServicio);
                NombreServicios id = nombreServicio;
                Servicio servicio = new Servicio(nombre, precio, id);
                ListaServiciosSeleccionados.Add(servicio);
            }
        }
        private int ObtenerPrecioServicio(NombreServicios nombreServicio)
        {
            switch (nombreServicio)
            {
                case NombreServicios.Agua:
                    return 20; // Precio del servicio de agua

                case NombreServicios.Internet:
                    return 50; // Precio del servicio de internet

                case NombreServicios.Cable:
                    return 30; // Precio del servicio de cable

                case NombreServicios.Luz:
                    return 25; // Precio del servicio de luz

                case NombreServicios.Gas:
                    return 40; // Precio del servicio de gas

                default:
                    return 0; 
            }
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
            fechaNacimiento = this.dtpFechaNacimiento.Value;
            contraseña = this.txtClaveIngreso.Text;
            apellido = this.txtApellido.Text;
            direccion = this.txtDireccionVivienda.Text;
            contactoAgencia = this.txtContacto.Text;
            agencia = this.txtAgencia.Text;
            telefono = ObtenerValorNumerico(this.txtTelefono.Text);
            dni = ObtenerValorNumerico(this.txtDni.Text);
            edad = ObtenerValorNumerico(this.txtEdad.Text);
            identificacion = ObtenerValorNumerico(this.txtIdentificacion.Text);
            confirmacionCorreo = txtCorfirmacionCorreo.Text;
            confirmacionContraseña = txtConfirmacionClave.Text;


            if (rol == "inquilino")
            {
                ciudad = this.cboCiudad.Text;
                this.inquilino = new Inquilino(nombre, apellido, correo, contraseña, ciudad, fechaNacimiento, telefono, direccion, dni, edad);
                ValidadorInquilino miValidadorInquilino = new ValidadorInquilino(this.inquilino);
                miValidadorInquilino.OnMostrarMensajeError += MostrarMensajeError;
                if (miValidadorInquilino.ConfirmarContraseña(confirmacionContraseña) && miValidadorInquilino.ConfirmarCorreo(confirmacionCorreo))
                {
                    if (miValidadorInquilino.ValidarRegistro())
                    {
                        Administrador administradorSeleccionado = (Administrador)cboArriendador.SelectedItem;

                        this.inquilino = new Inquilino(nombre, apellido, correo, contraseña, ciudad, fechaNacimiento, telefono, direccion, dni, edad);

                        // Crear la vivienda
                        string direccionVivienda = txtDireccionVivienda.Text;
                        int numeroHabitaciones = ObtenerValorNumerico(lblHabitaciones.Text);
                        int pisoVivienda = ObtenerValorNumerico(nudPiso.Text);
                        string departamento = cboDepartamento.Text;
                        int cantInquilinos = ObtenerValorNumerico(nudInquilinos.Text);
                        Vivienda nuevaVivienda = new Vivienda(direccionVivienda, numeroHabitaciones, pisoVivienda, administradorSeleccionado.Identificacion, departamento, cantInquilinos);
                        ObtenerServiciosSeleccionados();
                        foreach (var servicio in ListaServiciosSeleccionados)
                        {
                            nuevaVivienda.AgregarServicio(servicio);
                        }
                        this.inquilino.ElegirVivienda(nuevaVivienda);

                        int adminIndex = listaAdministradores.FindIndex(admin => admin.Identificacion == administradorSeleccionado.Identificacion);
                        administradorSeleccionado.viviendasACargo.Add(nuevaVivienda);
                        listaAdministradores[adminIndex] = administradorSeleccionado;

                        string rutaArchivoJsonAdministrador = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RegistrosAdministrador.json");
                        string rutaArchivoJsonInquilino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RegistrosInquilino.json");
                        Serializadora<Administrador>.GuardarComoJSON(listaAdministradores, rutaArchivoJsonAdministrador);
                        List<Inquilino> listaInquilinos = new List<Inquilino>();
                        if (File.Exists(rutaArchivoJsonInquilino))
                        {
                            listaInquilinos = Serializadora<Inquilino>.CargarDesdeJSON(rutaArchivoJsonInquilino);
                            listaInquilinos.Add(inquilino);
                        }

                        Serializadora<Inquilino>.GuardarComoJSON(listaInquilinos, rutaArchivoJsonInquilino);

                        MessageBox.Show($"{this.inquilino.ToString()}");
                        this.Hide();
                        FrmMenu menu = new FrmMenu();
                        menu.SetInquilino(inquilino);
                        menu.Show();
                    }
                }
            }
            else if (rol == "administrador")
            {
                ciudad = this.cboCiudadAdministrador.Text;
                this.administrador = new Administrador(nombre, apellido, correo, contraseña, ciudad, fechaNacimiento, telefono, dni, edad, agencia, contactoAgencia, identificacion);
                ValidadorAdministrador miValidadorAdministrador = new ValidadorAdministrador(this.administrador);
                miValidadorAdministrador.OnMostrarMensajeError += MostrarMensajeError;
                if (miValidadorAdministrador.ConfirmarContraseña(confirmacionContraseña) && miValidadorAdministrador.ConfirmarCorreo(confirmacionCorreo))
                {
                    if (miValidadorAdministrador.Validar())
                    {
                        List<Administrador> adminList = new List<Administrador> { administrador };
                        string rutaArchivoJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RegistrosAdministrador.json");
                        List<Administrador> listaAdministradores = new List<Administrador>();
                        if (File.Exists(rutaArchivoJson))
                        {
                            listaAdministradores = Serializadora<Administrador>.CargarDesdeJSON(rutaArchivoJson);
                            listaAdministradores.Add(administrador);
                        }
                        Serializadora<Administrador>.GuardarComoJSON(listaAdministradores, rutaArchivoJson);

                        MessageBox.Show($"{this.administrador.ToString()}");
                        this.Hide();
                        FrmMenu menu = new FrmMenu();
                        menu.SetAdministrador(administrador);
                        menu.Show();
                    }
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
