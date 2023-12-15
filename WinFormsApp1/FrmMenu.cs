using Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NestApp;

namespace UI
{
    public partial class FrmMenu : Formulario
    {
        private Administrador administradorActual;
        private Inquilino inquilinoActual;
        public List<Inquilino> listaInquilinos;
        public Deuda deudaActual;
        public string cadenaConexion;
        public OperacionesBDInquilino<Inquilino> baseDatosInquilinos;
        public OperacionesBDAdministrador<Administrador> baseDatosAdministradores;
        public OperacionesBDServicio<Servicio> OperacionesBDServicio;
        public FrmMenu()
        {
            InitializeComponent();
            cadenaConexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=nestapp;UID=root;PASSWORDS=;";
            baseDatosInquilinos = new OperacionesBDInquilino<Inquilino>(cadenaConexion);
            baseDatosAdministradores = new OperacionesBDAdministrador<Administrador>(cadenaConexion);
            listaInquilinos = new List<Inquilino>();
        }
        public void FrmMenu_Load(object sender, EventArgs e)
        {

            listaInquilinos = baseDatosInquilinos.ObtenerTodos();

            if (UsuarioActual == TipoUsuario.Administrador)
            {

                OperacionesBDVivienda<Vivienda> baseDatosVivienda = new OperacionesBDVivienda<Vivienda>(cadenaConexion);
                List<Vivienda> listaViviendas = baseDatosVivienda.ObtenerListaPor(administradorActual.Identificacion, "SELECT * FROM viviendas WHERE identificacionArriendador = @identificacionArriendador");

                foreach (var vivienda in listaViviendas)
                {
                    foreach (var inquilino in listaInquilinos)
                    {
                        if (vivienda.dniInquilino == inquilino.dni)
                        {
                            inquilino.Vivienda = vivienda;
                            if (administradorActual.inquilinosACargo != null && !administradorActual.inquilinosACargo.Contains(inquilino))
                            {

                                administradorActual.inquilinosACargo.Add(inquilino);
                                inquilino.CalcularDeuda(vivienda);

                            }
                            else
                            {
                                administradorActual.inquilinosACargo = new List<Inquilino>();
                                if (!administradorActual.inquilinosACargo.Contains(inquilino))
                                {
                                    administradorActual.inquilinosACargo.Add(inquilino);
                                    inquilino.CalcularDeuda(vivienda);
                                }

                            }
                            if (inquilino.Estado == Estado.Pendiente)
                            {
                                if (administradorActual.inquilinosPendientes != null)
                                {
                                    administradorActual.inquilinosPendientes.Add(inquilino);
                                }
                                else
                                {
                                    administradorActual.inquilinosPendientes = new List<Inquilino> { inquilino };

                                }
                            }
                            if (inquilino.ColaDeudas != null)
                            {
                                if (inquilino.ColaDeudas.Count > 0)
                                {
                                    if (administradorActual.inquilinosDeudores != null)
                                    {
                                        administradorActual.inquilinosDeudores.Add(inquilino);
                                    }
                                    else
                                    {
                                        administradorActual.inquilinosDeudores = new List<Inquilino> { inquilino };
                                    }
                                }
                            }
                            baseDatosInquilinos.Actualizar(inquilino);
                        }

                    }
                }

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
            OperacionesBDDeudas<Deuda> baseDatosDeudas = new OperacionesBDDeudas<Deuda>(cadenaConexion, inquilinoActual);
            // Asumiendo que Inquilino tiene una propiedad Queue<Deuda> llamada ColaDeudas
            OperacionesBDTarjeta<Tarjeta> baseDatosTarjeta = new OperacionesBDTarjeta<Tarjeta>(cadenaConexion, inquilinoActual);
            string consultaTarjeta = "SELECT * FROM tarjeta WHERE dniInquilino = @dniInquilino";
            inquilinoActual.AgregarTarjeta(baseDatosTarjeta.ObtenerPor(inquilinoActual.Dni, consultaTarjeta));
            if (inquilinoActual.Tarjeta == null && UsuarioActual == TipoUsuario.Inquilino)
            {
                MessageBox.Show("Por favor, ingrese una tarjeta.");
            }
            else if (UsuarioActual == TipoUsuario.Inquilino && inquilinoActual.Tarjeta != null)
            {
                btnAgregarTarjeta.Visible = false;
            }
            Queue<Deuda> colaDeudas = new Queue<Deuda>();
            List<Deuda> listaDeudas = baseDatosDeudas.ObtenerTodos();
            foreach (var deuda in listaDeudas)
            {
                colaDeudas.Enqueue(deuda);
            }
            inquilinoActual.ColaDeudas = colaDeudas;
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
                    OperacionesBDDeudas<Deuda> baseDatosDeudas = new OperacionesBDDeudas<Deuda>(cadenaConexion, inquilinoActual);
                    OperacionesBSPago<Pago> baseDatosPagos = new OperacionesBSPago<Pago>(cadenaConexion, inquilinoActual);
                    OperacionesBDTarjeta<Tarjeta> baseDatosTarjeta = new OperacionesBDTarjeta<Tarjeta>(cadenaConexion, inquilinoActual);
                    if (inquilinoActual.Tarjeta.Saldo >= deudaActual.Monto)
                    {


                        if (inquilinoActual.HistorialPagos != null)
                        {
                            inquilinoActual.HistorialPagos.Add(nuevoPago);

                        }
                        else
                        {
                            inquilinoActual.HistorialPagos = new List<Pago> { nuevoPago };
                        }
                        baseDatosPagos.Insertar(nuevoPago);
                        inquilinoActual.Tarjeta.Saldo -= deudaActual.Monto;
                        inquilinoActual.ColaDeudas.Dequeue();
                        baseDatosDeudas.Eliminar(deudaActual);
                        baseDatosTarjeta.Actualizar(inquilinoActual.Tarjeta);
                        baseDatosInquilinos.Actualizar(inquilinoActual);
                        CargarPagos();
                        CargarDeudas();
                    }
                    else
                    {
                        MessageBox.Show("Su saldo es insuficiente, para pagar la deuda seleccionada");
                    }
                    baseDatosDeudas.OnMostrarMensajeError += MostrarMensajeError;
                    baseDatosPagos.OnMostrarMensajeError += MostrarMensajeError;
                    baseDatosTarjeta.OnMostrarMensajeError += MostrarMensajeError;
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
                grpInquilinoSeleccionado.Visible = true;
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
                grpInquilinoSeleccionado.Visible = false;
                Point ubicacion = new Point(121, 42);
                grpServicios.Location = ubicacion;
                if (UsuarioActual == TipoUsuario.Administrador)
                {
                    lblServicio.Visible = true;
                    txtPrecio.Visible = true;
                    lblPrecio.Visible = true;
                    cmbServicios.Visible = true;
                    chklServicios.Visible = false;

                }
                else
                {
                    chklServicios.Visible = true;
                    lblServicio.Visible = false;
                    txtPrecio.Visible = false;
                    lblPrecio.Visible = false;
                    cmbServicios.Visible = false;

                }
            }

        }
        private List<Inquilino> obtenerListasSegunOrden()
        {

            string opcionSeleccionada = cmbMostrar.SelectedItem.ToString();
            OperacionesBDVivienda<Vivienda> baseDeDatosVivienda = new OperacionesBDVivienda<Vivienda>(cadenaConexion);
            string consultaVivienda = "SELECT * FROM viviendas WHERE IdentificacionArriendador = @IdentificacionArriendador";
            string consultainquilino = "SELECT * FROM inquilinos WHERE dni = @dni";
            List<Vivienda> viviendas = baseDeDatosVivienda.ObtenerListaPor(administradorActual.Identificacion, consultaVivienda);
            List<Inquilino> inquilinos = new List<Inquilino>();
            foreach (Vivienda vivienda in viviendas)
            {
                Inquilino inquilino = baseDatosInquilinos.ObtenerPor(vivienda.dniInquilino, consultainquilino);
                inquilinos.Add(inquilino);
            }

            switch (opcionSeleccionada)
            {
                case "Pendientes":
                    this.btnValidarInquilino.Visible = true;
                    //List<Inquilino> listaPendientes = new List<Inquilino>();
                    return administradorActual.inquilinosPendientes; //= listaPendientes;
                                                                     //return listaPendientes;
                case "Deudores":
                    this.btnValidarInquilino.Visible = false;
                    return administradorActual.inquilinosDeudores;
                case "Todos":
                    this.btnValidarInquilino.Visible = false;
                    administradorActual.inquilinosACargo = listaInquilinos;
                    return listaInquilinos;
                default:
                    this.btnValidarInquilino.Visible = false;
                    administradorActual.inquilinosACargo = listaInquilinos;
                    return administradorActual.inquilinosACargo;
            }

        }
        private void cmbMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbInquilinoSeleccionado.DataSource = null;
            cmbInquilinoSeleccionado.Items.Clear();
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
                OperacionesBDTarjeta<Tarjeta> baseDatosTarjeta = new OperacionesBDTarjeta<Tarjeta>(cadenaConexion, inquilinoActual);
                try
                {
                    int saldoIngresado;
                    if (int.TryParse(txtMonto.Text, out saldoIngresado))
                    {
                        inquilinoActual.Tarjeta.Saldo += (saldoIngresado);
                        baseDatosTarjeta.Actualizar(inquilinoActual.Tarjeta);
                    }
                }
                catch (Exception ex)
                {
                    MostrarMensajeError("Error: " + ex);
                }
                lblCantSaldoTarjetaIngresada.Text = inquilinoActual.Tarjeta.Saldo.ToString();
            }
        }

        private void btnConfirmarTarjetaIngresada_Click(object sender, EventArgs e)
        {
            string nombreCompleto = txtNombreCompleto.Text;
            string numeroTarjeta = txtNumeroTarjetaIngresada.Text;
            string cvv = txtCvvIngresado.Text;
            int cvvEntero;
            OperacionesBDTarjeta<Tarjeta> baseDatosTarjeta = new OperacionesBDTarjeta<Tarjeta>(cadenaConexion, inquilinoActual);
            if (int.TryParse(cvv, out cvvEntero))
            {
                Tarjeta tarjetaIngresada = new Tarjeta(nombreCompleto, cvvEntero, numeroTarjeta);
                ValidadorTarjeta validadorTarjeta = new ValidadorTarjeta(tarjetaIngresada);
                validadorTarjeta.OnMostrarMensajeError += MostrarMensajeError;

                if (validadorTarjeta.Validar(tarjetaIngresada))
                {
                    lblCantSaldoTarjetaIngresada.Text = tarjetaIngresada.Saldo.ToString();

                    inquilinoActual.AgregarTarjeta(tarjetaIngresada);
                    baseDatosTarjeta.Insertar(tarjetaIngresada);

                }
                baseDatosTarjeta.OnMostrarMensajeError += MostrarMensajeError;
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


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            OperacionesBDTarjeta<Tarjeta> baseDatosTarjeta = new OperacionesBDTarjeta<Tarjeta>(cadenaConexion, inquilinoActual);

            if (inquilinoActual.Tarjeta.NumeroTarjeta == txtNumeroTarjeta.Text && inquilinoActual.Tarjeta.Cvv.ToString() == txtCvv.Text)
            {
                lblCantSaldo.Text = inquilinoActual.Tarjeta.Saldo.ToString();
                int montoIngresado;
                if (int.TryParse(txtMonto.Text, out montoIngresado))
                {
                    inquilinoActual.Tarjeta.Saldo += montoIngresado;

                    baseDatosTarjeta.Actualizar(inquilinoActual.Tarjeta);

                    lblCantSaldo.Text = inquilinoActual.Tarjeta.Saldo.ToString();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos, por favor verifique los datos de la tarjeta.");
                }
            }
        }
        private void btnValidarInquilino_Click(object sender, EventArgs e)
        {
            Inquilino inquilinoSeleccionado = (Inquilino)cmbInquilinoSeleccionado.SelectedItem;
            if (inquilinoSeleccionado != null)
            {

                inquilinoSeleccionado = administradorActual.PermitirNuevoInquilino(inquilinoSeleccionado);
                baseDatosInquilinos.Actualizar(inquilinoSeleccionado);
            }
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            CambiarYMostrarGrp(grpServicios);
            chklServicios.DataSource = Enum.GetValues(typeof(NombreServicios));
            cmbServicios.DataSource = Enum.GetValues(typeof(NombreServicios));


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (UsuarioActual == TipoUsuario.Inquilino)
            {
                if (inquilinoActual.Vivienda == null)
                {
                    OperacionesBDVivienda<Vivienda> baseDatosVivienda = new OperacionesBDVivienda<Vivienda>(cadenaConexion);
                    List<Vivienda> listaViviendas = baseDatosVivienda.ObtenerTodos();
                    foreach (var vivienda in listaViviendas)
                    {
                        if (vivienda.dniInquilino == inquilinoActual.Dni)
                        {
                            inquilinoActual.ElegirVivienda(vivienda);

                        }
                    }
                }
                OperacionesBDServicio<Servicio> baseDatosServicios = new OperacionesBDServicio<Servicio>(cadenaConexion, inquilinoActual.Vivienda.identificacionArriendador);

                List<Servicio> listaServicios = inquilinoActual.Vivienda.servicios;

                if (listaServicios == null)
                {
                    listaServicios = baseDatosServicios.ObtenerServiciosActivos(inquilinoActual.Vivienda.identificacionArriendador, inquilinoActual.Dni);
                }

                inquilinoActual.Vivienda.servicios = listaServicios;

                // Eliminar los servicios no seleccionados
                foreach (var servicio in listaServicios)
                {
                    if (!chklServicios.CheckedItems.Contains((NombreServicios)Enum.Parse(typeof(NombreServicios), servicio.Nombre)))
                    {
                        baseDatosServicios.Eliminar(servicio, inquilinoActual.Dni);
                    }
                }

                // Insertar los servicios seleccionados
                List<Servicio> listaNuevosServicios = new List<Servicio>();

                foreach (NombreServicios servicioSeleccionado in chklServicios.CheckedItems)
                {
                    string nombreServicioSeleccionado = Enum.GetName(typeof(NombreServicios), servicioSeleccionado);
                    string consulta = "SELECT * FROM servicios WHERE identificacionAdmin = @identificacionAdmin AND nombre = @nombre";
                    Servicio servicio = baseDatosServicios.ObtenerPor(inquilinoActual.Vivienda.identificacionArriendador, consulta, nombreServicioSeleccionado);

                    if (servicio != null)
                    {
                        listaNuevosServicios.Add(servicio);
                    }
                }

                // Insertar la lista de nuevos servicios
                baseDatosServicios.InsertarLista(listaNuevosServicios, inquilinoActual);

                // Volver a cargar la lista de servicios activos después de las actualizaciones
                listaServicios = baseDatosServicios.ObtenerServiciosActivos(inquilinoActual.Vivienda.identificacionArriendador, inquilinoActual.Dni);

                // Asignar la lista actualizada de servicios a la propiedad servicios de la vivienda
                inquilinoActual.Vivienda.servicios = listaServicios;




            }
            else
            {
                NombreServicios nombreServicio = (NombreServicios)cmbServicios.SelectedItem;

                int precio = int.TryParse(txtPrecio.Text, out int parsedPrecio) ? parsedPrecio : 0;

                string nombre = Enum.GetName(typeof(NombreServicios), nombreServicio);

                Servicio servicio = new Servicio(nombre, precio, administradorActual.Identificacion);

                OperacionesBDServicio<Servicio> baseDatosServicios = new OperacionesBDServicio<Servicio>(cadenaConexion, administradorActual.Identificacion);

                baseDatosServicios.Insertar(servicio);
            }
        }
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

