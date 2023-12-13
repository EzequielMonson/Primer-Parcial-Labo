using Clases;
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
using System.Text.Json;
using NestApp;
using System.Runtime.InteropServices;

namespace UI
{
    public partial class FrmMenu : Formulario
    {
        private Administrador administradorActual;
        private Inquilino inquilinoActual;
        public List<Inquilino> listaInquilinos;
        public Deuda deudaActual;
        public FrmMenu()
        {
            InitializeComponent();
        }
        public void FrmMenu_Load(object sender, EventArgs e)
        {
            string jsonFilePath = "registrosInquilino.json";

            if (File.Exists(jsonFilePath))
            {
                listaInquilinos = Serializadora<Inquilino>.CargarDesdeJSON(jsonFilePath);
            }
            else
            {
                MessageBox.Show("El archivo JSON no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listaInquilinos = new List<Inquilino>();
            }
            if (UsuarioActual == TipoUsuario.Administrador)
            {
                List<Vivienda> listaVivienda = administradorActual.viviendasACargo;

                foreach (var vivienda in listaVivienda)
                {
                    foreach (var inquilino in listaInquilinos)
                    {

                        if (vivienda.dniInquilino == inquilino.dni)
                        {
                            if (administradorActual.inquilinosACargo != null)
                            {
                                administradorActual.inquilinosACargo.Add(inquilino);
                                inquilino.CalcularDeuda(vivienda);
                            }
                            else
                            {
                                administradorActual.inquilinosACargo = new List<Inquilino> { inquilino };
                            }
                            if (inquilino.Estado == Estado.Pendiente)
                            {

                                administradorActual.inquilinosPendientes.Add(inquilino);
                            }
                            if (inquilino.ColaDeudas.Count > 0)
                            {
                                administradorActual.inquilinosDeudores.Add(inquilino);
                            }
                        }

                    }
                }
                Serializadora<Inquilino>.GuardarComoJSON(listaInquilinos, jsonFilePath);
                this.cmbMostrar.DataSource = new List<string> { "Pendientes", "Deudores", "Todos" };
                this.cmbInquilinoSeleccionado.DataSource = obtenerListasSegunOrden();
                this.grpInquilinoSeleccionado.Visible = true;
                cmbInquilinoSeleccionado.DisplayMember = "ToString";
                cmbInquilinoSeleccionado.ValueMember = null;

                Inquilino inquilinoSeleccionado = (Inquilino)cmbInquilinoSeleccionado.SelectedItem;
                this.inquilinoActual = inquilinoSeleccionado;

                if (inquilinoSeleccionado != null)
                {
                    // Mostrar el nombre del inquilino en algún control, por ejemplo, un label
                    lblInquilinoSeleccionado.Text = $"INQUILINO: {inquilinoSeleccionado.ToString()}";
                    lblInquilinoSeleccionado.Location = new Point(70, 19);
                    CargarPagos();
                    CargarDeudas();
                }
                cmbInquilinoSeleccionado.SelectedIndexChanged += cmbInquilinoSeleccionado_SelectedIndexChanged;


            }
            if (UsuarioActual == TipoUsuario.Inquilino)
            {
                if (inquilinoActual.Estado == Estado.Activo)
                {
                    CargarPagos();
                    CargarDeudas();
                }
                else
                {
                    if (inquilinoActual.Estado == Estado.Pendiente)
                    {
                        MessageBox.Show($"Su solicitud de ingreso fue enviada, aguarde a ser validado por el administrador");
                        this.Close();
                        FrmInicio inicio = new FrmInicio();
                        inicio.Show();
                    }
                }
            }
        }
        private void cmbInquilinoSeleccionado_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpDeudas.Visible = false;
            grpPagos.Visible = false;
            Inquilino inquilinoSeleccionado = (Inquilino)cmbInquilinoSeleccionado.SelectedItem;
            this.inquilinoActual = inquilinoSeleccionado;
            if (inquilinoSeleccionado != null)
            {
                lblInquilinoSeleccionado.Text = $"INQUILINO: {inquilinoSeleccionado.ToString()}";
                lblInquilinoSeleccionado.Location = new Point(70, 19);


                CargarPagos();
                CargarDeudas();
            }
        }
        public enum TipoUsuario
        {
            Administrador,
            Inquilino
        }

        public TipoUsuario UsuarioActual { get; private set; }

        // método para establecer el administrador actual
        public void SetAdministrador(Administrador administrador)
        {

            administradorActual = administrador;
            UsuarioActual = TipoUsuario.Administrador;

        }

        public void SetInquilino(Inquilino inquilino)
        {
            inquilinoActual = inquilino;
            UsuarioActual = TipoUsuario.Inquilino;
            this.grpInquilinoSeleccionado.Visible = false;
            if (inquilinoActual.Tarjeta == null)
            {
                btnAgregarTarjeta.Visible = true;
            }



        }
        private void CargarPagos()
        {

            dtgPagos.Rows.Clear();
            // Asumiendo que Inquilino tiene una propiedad List<Pago> llamada Pagos
            List<Pago> listaPagos = inquilinoActual.HistorialPagos;

            if (listaPagos != null)
            {
                foreach (var pago in listaPagos)
                {
                    // Añadir una nueva fila y llenar las columnas específicas
                    int rowIndex = dtgPagos.Rows.Add();
                    dtgPagos.Rows[rowIndex].Cells["fechaAbonoPagos"].Value = pago.FechaAbono;
                    dtgPagos.Rows[rowIndex].Cells["cantidadAbonadaPagos"].Value = pago.CantidadAbonada;
                    dtgPagos.Rows[rowIndex].Cells["fechaVencimientoPagos"].Value = pago.FechaVencimiento;
                }
            }
        }
        private void CargarDeudas()
        {
            // Asumiendo que Inquilino tiene una propiedad Queue<Deuda> llamada ColaDeudas
            if (inquilinoActual.Tarjeta == null)
            {
                MessageBox.Show("Por favor, ingrese una tarjeta.");
            }
            Queue<Deuda> colaDeudas = inquilinoActual.ColaDeudas;

            dtgDeudas.Rows.Clear();

            foreach (var deuda in colaDeudas)
            {
                // Añadir una nueva fila y llenar las columnas específicas
                int rowIndex = dtgDeudas.Rows.Add();
                dtgDeudas.Rows[rowIndex].Cells["fechaEmisionDeudas"].Value = deuda.FechaEmision;
                dtgDeudas.Rows[rowIndex].Cells["cantidadAbonarDeudas"].Value = deuda.Monto;
                dtgDeudas.Rows[rowIndex].Cells["FechaVencimiento"].Value = deuda.FechaVencimiento;

                // Verificar si el usuario actual es un administrador
                if (UsuarioActual == TipoUsuario.Administrador)
                {
                    // Asumiendo que Administrador tiene una propiedad List<Inquilino> llamada InquilinosDeudores
                    List<Inquilino> inquilinosDeudores = administradorActual.inquilinosDeudores;

                    // Buscar el inquilino asociado a la deuda
                    Inquilino inquilinoDeudor = inquilinosDeudores.FirstOrDefault(i => i.ColaDeudas.Contains(deuda));

                    // Mostrar el nombre del inquilino en la columna "inquilino"
                    dtgDeudas.Rows[rowIndex].Cells["inquilino"].Value = inquilinoDeudor != null ? inquilinoDeudor.nombre : "No disponible";
                }
            }
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            if (!pnlOpciones.Visible)
            {
                pnlOpciones.Visible = true;
            }
            else
            {
                pnlOpciones.Visible = false;
            }
            if (UsuarioActual != TipoUsuario.Administrador)
            {
                btnIngresarSaldo.Visible = true;
            }
        }

        private void btnMostrarDeudas_Click(object sender, EventArgs e)
        {
            CambiarYMostrarGrp(grpDeudas);
            CargarDeudas();
        }

        private void btnMostrarPagos_Click(object sender, EventArgs e)
        {
            CambiarYMostrarGrp(grpPagos);
            CargarPagos();
        }



        private void dtgDeudas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UsuarioActual != TipoUsuario.Administrador)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dtgDeudas.Rows[e.RowIndex];
                    if (selectedRow.Cells["fechaEmisionDeudas"].Value != null)
                    {
                        DateTime fechaEmisionSeleccionada = (DateTime)selectedRow.Cells["fechaEmisionDeudas"].Value;
                        Deuda deudaSeleccionada = ObtenerDeudaPorFecha(fechaEmisionSeleccionada);


                        if (deudaSeleccionada != null)
                        {
                            btnPagarDeudaSeleccionada.Visible = true;
                            this.deudaActual = deudaSeleccionada;

                        }

                    }
                }
            }
        }

        private Deuda ObtenerDeudaPorFecha(DateTime fechaEmisionSeleccionada)
        {
            foreach (Deuda deuda in inquilinoActual.ColaDeudas)
            {
                if (deuda.FechaEmision == fechaEmisionSeleccionada)
                {
                    return deuda; // Se encontró la deuda con la fecha de emisión dada
                }
            }

            return null; // No se encontró ninguna deuda con la fecha de emisión dada
        }

        private void btnPagarDeudaSeleccionada_Click(object sender, EventArgs e)
        {
            if (deudaActual != null)
            {
                DialogResult resultado = MessageBox.Show($"¿Deseas pagar la deuda seleccionada con monto: {deudaActual.Monto}?",
                                                          "Confirmar Pago",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    // Actualizar el saldo del inquili
                    Pago nuevoPago = new Pago(deudaActual.Monto, deudaActual.FechaVencimiento);
                    inquilinoActual.HistorialPagos.Add(nuevoPago);
                    inquilinoActual.Tarjeta.Saldo -= deudaActual.Monto;
                    inquilinoActual.ColaDeudas.Dequeue();
                    string jsonFilePath = "registrosInquilino.json";
                    List<Inquilino> listaInquilinos = Serializadora<Inquilino>.CargarDesdeJSON(jsonFilePath);
                    foreach (var inquilino in listaInquilinos)
                    {
                        if (inquilino.Dni == inquilinoActual.Dni)
                        {
                            listaInquilinos.Remove(inquilino);
                            listaInquilinos.Add(inquilinoActual);
                            break;
                        }

                    }
                    Serializadora<Inquilino>.GuardarComoJSON(listaInquilinos, jsonFilePath);

                    CargarPagos();
                    CargarDeudas();
                }
                else
                {
                    // El usuario eligió no pagar la deuda, puedes realizar acciones adicionales si es necesario
                }
            }
        }
        private void CambiarYMostrarGrp(GroupBox grpSeleccionado)
        {
            if (UsuarioActual == TipoUsuario.Inquilino)
            {
                Point ubicacion = new Point(121, 42);
                grpSeleccionado.Location = ubicacion;
            }
            else
            {
                Point ubicacion = new Point(121, 170);
                grpSeleccionado.Location = ubicacion;
            }
            if (!grpPagos.Visible && grpPagos == grpSeleccionado)
            {
                grpDeudas.Visible = false;
                grpPagos.Visible = true;
                grpDatosTarjeta.Visible = false;
                grpIngreseSaldo.Visible = false;
                grpServicios.Visible = false;
            }
            if (!grpDatosTarjeta.Visible && grpDatosTarjeta == grpSeleccionado)
            {
                grpDeudas.Visible = false;
                grpPagos.Visible = false;
                grpDatosTarjeta.Visible = true;
                grpIngreseSaldo.Visible = false;
                grpServicios.Visible = false;
            }
            if (!grpDeudas.Visible && grpDeudas == grpSeleccionado)
            {
                grpDeudas.Visible = true;
                grpPagos.Visible = false;
                grpDatosTarjeta.Visible = false;
                grpIngreseSaldo.Visible = false;
                grpServicios.Visible = false;
            }
            if (!grpIngreseSaldo.Visible && grpIngreseSaldo == grpSeleccionado)
            {
                grpDeudas.Visible = false;
                grpPagos.Visible = false;
                grpDatosTarjeta.Visible = false;
                grpIngreseSaldo.Visible = true;
                grpServicios.Visible = false;
            }
            if (!grpServicios.Visible && grpServicios == grpSeleccionado)
            {
                grpDeudas.Visible = false;
                grpPagos.Visible = false;
                grpDatosTarjeta.Visible = false;
                grpIngreseSaldo.Visible = false;
                grpServicios.Visible = true;
            }

        }
        private List<Inquilino> obtenerListasSegunOrden()
        {
            string opcionSeleccionada = cmbMostrar.SelectedItem.ToString();

            switch (opcionSeleccionada)
            {
                case "Pendientes":
                    this.btnValidarInquilino.Visible = true;

                    return administradorActual.inquilinosPendientes;
                case "Deudores":
                    this.btnValidarInquilino.Visible = false;
                    return administradorActual.inquilinosDeudores;
                case "Todos":
                    this.btnValidarInquilino.Visible = false;
                    return administradorActual.inquilinosACargo;
                default:
                    this.btnValidarInquilino.Visible = false;
                    return administradorActual.inquilinosACargo;
            }

        }
        private void cmbMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbInquilinoSeleccionado.DataSource = obtenerListasSegunOrden();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInicio inicio = new FrmInicio();
            inicio.Show();
        }

        private void btnIngresarSaldo_Click(object sender, EventArgs e)
        {
            if (inquilinoActual.Tarjeta != null)
            {
                CambiarYMostrarGrp(grpIngreseSaldo);
                lblCantSaldoTarjetaIngresada.Text = inquilinoActual.Tarjeta.Saldo.ToString();
                try
                {
                    int saldoIngresado;
                    if (int.TryParse(txtMonto.Text, out saldoIngresado))
                    {
                        inquilinoActual.IngresarSaldo(saldoIngresado);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error: " + ex);
                }
            }
        }

        private void btnConfirmarTarjetaIngresada_Click(object sender, EventArgs e)
        {
            string nombreCompleto = txtNombreCompleto.Text;
            string numeroTarjeta = txtNumeroTarjetaIngresada.Text;
            string cvv = txtCvvIngresado.Text;
            int cvvEntero;
            if (int.TryParse(cvv, out cvvEntero))
            {
                Tarjeta tarjetaIngresada = new Tarjeta(nombreCompleto, cvvEntero, numeroTarjeta);
                ValidadorTarjeta validadorTarjeta = new ValidadorTarjeta(tarjetaIngresada);
                validadorTarjeta.OnMostrarMensajeError += MostrarMensajeError;

                if (validadorTarjeta.Validar(tarjetaIngresada))
                {
                    lblCantSaldoTarjetaIngresada.Text = tarjetaIngresada.Saldo.ToString();

                    inquilinoActual.AgregarTarjeta(tarjetaIngresada);

                    string rutaArchivoJsonInquilino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RegistrosInquilino.json");

                    if (File.Exists(rutaArchivoJsonInquilino))
                    {
                        List<Inquilino> listaInquilinos = Serializadora<Inquilino>.CargarDesdeJSON(rutaArchivoJsonInquilino);

                        foreach (var inquilino in listaInquilinos)
                        {
                            if (inquilino.Dni == inquilinoActual.Dni)
                            {
                                listaInquilinos.Remove(inquilino);
                                listaInquilinos.Add(inquilinoActual);
                                break;
                            }
                        }

                        Serializadora<Inquilino>.GuardarComoJSON(listaInquilinos, rutaArchivoJsonInquilino);
                    }
                }
            }
        }

        private void MostrarMensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAgregarTarjeta_Click(object sender, EventArgs e)
        {
            CambiarYMostrarGrp(grpDatosTarjeta);
        }

        private void cmbInquilinoSeleccionado_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (inquilinoActual.Tarjeta.NumeroTarjeta == txtNumeroTarjeta.Text && inquilinoActual.Tarjeta.Cvv.ToString() == txtCvv.Text)
            {
                lblCantSaldo.Text = inquilinoActual.Tarjeta.Saldo.ToString();
                int montoIngresado;
                if (int.TryParse(txtMonto.Text, out montoIngresado))
                {
                    inquilinoActual.Tarjeta.Saldo += montoIngresado;
                }
            }
            else
            {
                MessageBox.Show("Datos incorrectos, por favor verifique los datos de la tarjeta.");
            }
        }

        private void btnValidarInquilino_Click(object sender, EventArgs e)
        {
            Inquilino inquilinoSeleccionado = (Inquilino)cmbInquilinoSeleccionado.SelectedItem;
            inquilinoActual = inquilinoSeleccionado;
            administradorActual.PermitirNuevoInquilino(inquilinoSeleccionado);
            string rutaArchivoJsonInquilino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RegistrosInquilino.json");
            if (File.Exists(rutaArchivoJsonInquilino))
            {
                List<Inquilino> listaInquilinos = Serializadora<Inquilino>.CargarDesdeJSON(rutaArchivoJsonInquilino);
                foreach (var inquilino in listaInquilinos)
                {
                    if (inquilino.Dni == inquilinoActual.Dni)
                    {
                        listaInquilinos.Remove(inquilino);
                        listaInquilinos.Add(inquilinoActual);
                        break;
                    }
                }

            }
            Serializadora<Inquilino>.GuardarComoJSON(listaInquilinos, rutaArchivoJsonInquilino);
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            CambiarYMostrarGrp(grpServicios);
            chklServicios.DataSource = Enum.GetValues(typeof(NombreServicios));


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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<Servicio> listaServiciosSeleccionados = new List<Servicio>();
            inquilinoActual.Vivienda.servicios.Clear();
            foreach (NombreServicios nombreServicio in chklServicios.CheckedItems)
            {
                int precio = ObtenerPrecioServicio(nombreServicio);
                string nombre = Enum.GetName(typeof(NombreServicios), nombreServicio);
                NombreServicios id = nombreServicio;
                Servicio servicio = new Servicio(nombre, precio, id);
                listaServiciosSeleccionados.Add(servicio);
            }
            foreach (var servicio in listaServiciosSeleccionados)
            {
                inquilinoActual.Vivienda.AgregarServicio(servicio);
            }
            string rutaArchivoJsonInquilino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RegistrosInquilino.json");
            List<Inquilino> listaInquilinos = Serializadora<Inquilino>.CargarDesdeJSON(rutaArchivoJsonInquilino);
            foreach (var inquilino in listaInquilinos)
            {
                if (inquilino.dni == inquilinoActual.Dni)
                {
                    listaInquilinos.Remove(inquilino);
                    listaInquilinos.Add(inquilinoActual);
                    break;
                }
            }
            Serializadora<Inquilino>.GuardarComoJSON(listaInquilinos, rutaArchivoJsonInquilino);
        }
        //private void btnMensajes_Click(object sender, EventArgs e)
        //{
        //    List<Administrador> listaAdmin = Serializadora<Administrador>.CargarDesdeJSON("registrosAdministrador.json");
        //    List<Inquilino> listaInqui = Serializadora<Inquilino>.CargarDesdeJSON("registrosInquilino.json");

        //    List<FrmMensajes> formulariosMensajes = new List<FrmMensajes>();

        //    foreach (var admin in listaAdmin)
        //    {
        //        FrmMensajes mensajes = new FrmMensajes();
        //        mensajes.SetAdministrador(admin);
        //        formulariosMensajes.Add(mensajes);
        //    }

        //    foreach (var inqui in listaInqui)
        //    {
        //        FrmMensajes mensajes = new FrmMensajes();
        //        mensajes.SetInquilino(inqui);
        //        formulariosMensajes.Add(mensajes);
        //    }

        //    // Mostrar todos los formularios al mismo tiempo
        //    foreach (var formulario in formulariosMensajes)
        //    {
        //        formulario.Show();
        //    }
        //}



        private void btnMensajes_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMensajes mensajes = new FrmMensajes();
            if (UsuarioActual == TipoUsuario.Administrador)
            {
                mensajes.SetAdministrador(administradorActual);

            }
            else
            {
                mensajes.SetInquilino(inquilinoActual);

            }
            mensajes.Show();
        }
    }
}
