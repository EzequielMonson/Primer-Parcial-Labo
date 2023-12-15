namespace UI
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpDeudas = new GroupBox();
            lblDeudas = new Label();
            dtgDeudas = new DataGridView();
            inquilino = new DataGridViewComboBoxColumn();
            fechaEmisionDeudas = new DataGridViewTextBoxColumn();
            cantidadAbonarDeudas = new DataGridViewTextBoxColumn();
            FechaVencimiento = new DataGridViewTextBoxColumn();
            btnPagarDeudaSeleccionada = new Button();
            btnPagarTotalDeudas = new Button();
            grpPagos = new GroupBox();
            lblPagos = new Label();
            dtgPagos = new DataGridView();
            fechaAbonoPagos = new DataGridViewTextBoxColumn();
            cantidadAbonadaPagos = new DataGridViewTextBoxColumn();
            fechaVencimientoPagos = new DataGridViewTextBoxColumn();
            grpInquilinoSeleccionado = new GroupBox();
            btnValidarInquilino = new Button();
            lblMostrar = new Label();
            cmbMostrar = new ComboBox();
            cmbInquilinoSeleccionado = new ComboBox();
            lblInquilinoSeleccionado = new Label();
            btnOpciones = new Button();
            pnlOpciones = new Panel();
            btnAgregarTarjeta = new Button();
            btnIngresarSaldo = new Button();
            btnCerrarSesion = new Button();
            btnOpcionesEnPanel = new Button();
            btnHistorial = new Button();
            btnServicios = new Button();
            btnMensajes = new Button();
            btnMostrarPagos = new Button();
            btnMostrarDeudas = new Button();
            grpIngreseSaldo = new GroupBox();
            lblCantSaldo = new Label();
            lblSaldoActual = new Label();
            lblMonto = new Label();
            txtCvv = new TextBox();
            lblCvv = new Label();
            lblNumeroTarjeta = new Label();
            txtMonto = new TextBox();
            txtNumeroTarjeta = new TextBox();
            btnConfirmar = new Button();
            lblIngreseSaldo = new Label();
            grpDatosTarjeta = new GroupBox();
            lblNombreCompleto = new Label();
            txtNombreCompleto = new TextBox();
            lblCantSaldoTarjetaIngresada = new Label();
            lblSaldoActualTarjetaIngresada = new Label();
            txtCvvIngresado = new TextBox();
            lblNumeroTarjetaIngresada = new Label();
            lblCvvDt = new Label();
            txtNumeroTarjetaIngresada = new TextBox();
            btnConfirmarTarjetaIngresada = new Button();
            lblDatosTarjeta = new Label();
            grpServicios = new GroupBox();
            txtPrecio = new TextBox();
            btnGuardar = new Button();
            lblServicios = new Label();
            lblServicio = new Label();
            chklServicios = new CheckedListBox();
            lblPrecio = new Label();
            cmbServicios = new ComboBox();
            grpDeudas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDeudas).BeginInit();
            grpPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgPagos).BeginInit();
            grpInquilinoSeleccionado.SuspendLayout();
            pnlOpciones.SuspendLayout();
            grpIngreseSaldo.SuspendLayout();
            grpDatosTarjeta.SuspendLayout();
            grpServicios.SuspendLayout();
            SuspendLayout();
            // 
            // grpDeudas
            // 
            grpDeudas.Controls.Add(lblDeudas);
            grpDeudas.Controls.Add(dtgDeudas);
            grpDeudas.Controls.Add(btnPagarDeudaSeleccionada);
            grpDeudas.Controls.Add(btnPagarTotalDeudas);
            grpDeudas.Location = new Point(604, 231);
            grpDeudas.Name = "grpDeudas";
            grpDeudas.Size = new Size(611, 265);
            grpDeudas.TabIndex = 1;
            grpDeudas.TabStop = false;
            grpDeudas.Visible = false;
            // 
            // lblDeudas
            // 
            lblDeudas.AutoSize = true;
            lblDeudas.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDeudas.ForeColor = Color.Snow;
            lblDeudas.Location = new Point(255, 19);
            lblDeudas.Name = "lblDeudas";
            lblDeudas.Size = new Size(110, 32);
            lblDeudas.TabIndex = 1;
            lblDeudas.Text = "DEUDAS";
            lblDeudas.TextAlign = ContentAlignment.TopCenter;
            // 
            // dtgDeudas
            // 
            dtgDeudas.AllowUserToAddRows = false;
            dtgDeudas.AllowUserToDeleteRows = false;
            dtgDeudas.AllowUserToResizeColumns = false;
            dtgDeudas.AllowUserToResizeRows = false;
            dtgDeudas.BackgroundColor = Color.FromArgb(255, 192, 192);
            dtgDeudas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDeudas.Columns.AddRange(new DataGridViewColumn[] { inquilino, fechaEmisionDeudas, cantidadAbonarDeudas, FechaVencimiento });
            dtgDeudas.GridColor = Color.Black;
            dtgDeudas.Location = new Point(26, 54);
            dtgDeudas.Name = "dtgDeudas";
            dtgDeudas.ReadOnly = true;
            dtgDeudas.RowTemplate.Height = 25;
            dtgDeudas.Size = new Size(560, 103);
            dtgDeudas.TabIndex = 0;
            dtgDeudas.CellClick += dtgDeudas_CellClick;
            // 
            // inquilino
            // 
            inquilino.HeaderText = "Inquilino";
            inquilino.Name = "inquilino";
            inquilino.ReadOnly = true;
            inquilino.Visible = false;
            // 
            // fechaEmisionDeudas
            // 
            fechaEmisionDeudas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fechaEmisionDeudas.HeaderText = "Fecha de emisión";
            fechaEmisionDeudas.Name = "fechaEmisionDeudas";
            fechaEmisionDeudas.ReadOnly = true;
            fechaEmisionDeudas.Resizable = DataGridViewTriState.True;
            // 
            // cantidadAbonarDeudas
            // 
            cantidadAbonarDeudas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cantidadAbonarDeudas.HeaderText = "Cantidad a abonar";
            cantidadAbonarDeudas.Name = "cantidadAbonarDeudas";
            cantidadAbonarDeudas.ReadOnly = true;
            // 
            // FechaVencimiento
            // 
            FechaVencimiento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FechaVencimiento.HeaderText = "Fecha de vencimiento";
            FechaVencimiento.Name = "FechaVencimiento";
            FechaVencimiento.ReadOnly = true;
            // 
            // btnPagarDeudaSeleccionada
            // 
            btnPagarDeudaSeleccionada.FlatStyle = FlatStyle.Flat;
            btnPagarDeudaSeleccionada.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagarDeudaSeleccionada.ForeColor = SystemColors.ButtonFace;
            btnPagarDeudaSeleccionada.Location = new Point(68, 174);
            btnPagarDeudaSeleccionada.Name = "btnPagarDeudaSeleccionada";
            btnPagarDeudaSeleccionada.Size = new Size(211, 64);
            btnPagarDeudaSeleccionada.TabIndex = 7;
            btnPagarDeudaSeleccionada.Text = "PAGAR DEUDA";
            btnPagarDeudaSeleccionada.UseVisualStyleBackColor = true;
            btnPagarDeudaSeleccionada.Visible = false;
            btnPagarDeudaSeleccionada.Click += btnPagarDeudaSeleccionada_Click;
            // 
            // btnPagarTotalDeudas
            // 
            btnPagarTotalDeudas.FlatStyle = FlatStyle.Flat;
            btnPagarTotalDeudas.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagarTotalDeudas.ForeColor = SystemColors.ButtonFace;
            btnPagarTotalDeudas.Location = new Point(319, 174);
            btnPagarTotalDeudas.Name = "btnPagarTotalDeudas";
            btnPagarTotalDeudas.Size = new Size(211, 64);
            btnPagarTotalDeudas.TabIndex = 8;
            btnPagarTotalDeudas.Text = "PAGAR TOTAL ";
            btnPagarTotalDeudas.UseVisualStyleBackColor = true;
            btnPagarTotalDeudas.Visible = false;
            // 
            // grpPagos
            // 
            grpPagos.Controls.Add(lblPagos);
            grpPagos.Controls.Add(dtgPagos);
            grpPagos.Location = new Point(633, 442);
            grpPagos.Name = "grpPagos";
            grpPagos.Size = new Size(611, 184);
            grpPagos.TabIndex = 3;
            grpPagos.TabStop = false;
            grpPagos.Visible = false;
            // 
            // lblPagos
            // 
            lblPagos.AutoSize = true;
            lblPagos.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPagos.ForeColor = Color.Snow;
            lblPagos.Location = new Point(255, 19);
            lblPagos.Name = "lblPagos";
            lblPagos.Size = new Size(93, 32);
            lblPagos.TabIndex = 1;
            lblPagos.Text = "PAGOS";
            lblPagos.TextAlign = ContentAlignment.TopCenter;
            // 
            // dtgPagos
            // 
            dtgPagos.AllowUserToAddRows = false;
            dtgPagos.AllowUserToDeleteRows = false;
            dtgPagos.AllowUserToResizeColumns = false;
            dtgPagos.AllowUserToResizeRows = false;
            dtgPagos.BackgroundColor = Color.FromArgb(255, 192, 192);
            dtgPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPagos.Columns.AddRange(new DataGridViewColumn[] { fechaAbonoPagos, cantidadAbonadaPagos, fechaVencimientoPagos });
            dtgPagos.GridColor = Color.Black;
            dtgPagos.Location = new Point(22, 59);
            dtgPagos.Name = "dtgPagos";
            dtgPagos.ReadOnly = true;
            dtgPagos.RowTemplate.Height = 25;
            dtgPagos.Size = new Size(560, 103);
            dtgPagos.TabIndex = 0;
            // 
            // fechaAbonoPagos
            // 
            fechaAbonoPagos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fechaAbonoPagos.HeaderText = "Fecha de abono";
            fechaAbonoPagos.Name = "fechaAbonoPagos";
            fechaAbonoPagos.ReadOnly = true;
            fechaAbonoPagos.Resizable = DataGridViewTriState.True;
            // 
            // cantidadAbonadaPagos
            // 
            cantidadAbonadaPagos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cantidadAbonadaPagos.HeaderText = "Cantidad a abonada";
            cantidadAbonadaPagos.Name = "cantidadAbonadaPagos";
            cantidadAbonadaPagos.ReadOnly = true;
            // 
            // fechaVencimientoPagos
            // 
            fechaVencimientoPagos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fechaVencimientoPagos.HeaderText = "Fecha de vencimiento";
            fechaVencimientoPagos.Name = "fechaVencimientoPagos";
            fechaVencimientoPagos.ReadOnly = true;
            // 
            // grpInquilinoSeleccionado
            // 
            grpInquilinoSeleccionado.Controls.Add(btnValidarInquilino);
            grpInquilinoSeleccionado.Controls.Add(lblMostrar);
            grpInquilinoSeleccionado.Controls.Add(cmbMostrar);
            grpInquilinoSeleccionado.Controls.Add(cmbInquilinoSeleccionado);
            grpInquilinoSeleccionado.Controls.Add(lblInquilinoSeleccionado);
            grpInquilinoSeleccionado.Location = new Point(121, 42);
            grpInquilinoSeleccionado.Name = "grpInquilinoSeleccionado";
            grpInquilinoSeleccionado.Size = new Size(611, 151);
            grpInquilinoSeleccionado.TabIndex = 4;
            grpInquilinoSeleccionado.TabStop = false;
            grpInquilinoSeleccionado.Visible = false;
            // 
            // btnValidarInquilino
            // 
            btnValidarInquilino.FlatStyle = FlatStyle.Flat;
            btnValidarInquilino.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnValidarInquilino.ForeColor = SystemColors.ButtonFace;
            btnValidarInquilino.Location = new Point(227, 116);
            btnValidarInquilino.Name = "btnValidarInquilino";
            btnValidarInquilino.Size = new Size(121, 29);
            btnValidarInquilino.TabIndex = 11;
            btnValidarInquilino.Text = "ACEPTAR";
            btnValidarInquilino.UseVisualStyleBackColor = true;
            btnValidarInquilino.Visible = false;
            btnValidarInquilino.Click += btnValidarInquilino_Click;
            // 
            // lblMostrar
            // 
            lblMostrar.AutoSize = true;
            lblMostrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblMostrar.ForeColor = Color.Snow;
            lblMostrar.Location = new Point(307, 65);
            lblMostrar.Name = "lblMostrar";
            lblMostrar.Size = new Size(81, 19);
            lblMostrar.TabIndex = 13;
            lblMostrar.Text = "MOSTRAR:";
            lblMostrar.TextAlign = ContentAlignment.TopCenter;
            // 
            // cmbMostrar
            // 
            cmbMostrar.BackColor = Color.FromArgb(255, 128, 128);
            cmbMostrar.FlatStyle = FlatStyle.Flat;
            cmbMostrar.ForeColor = SystemColors.Control;
            cmbMostrar.FormattingEnabled = true;
            cmbMostrar.Location = new Point(394, 61);
            cmbMostrar.Name = "cmbMostrar";
            cmbMostrar.Size = new Size(155, 23);
            cmbMostrar.TabIndex = 12;
            cmbMostrar.SelectedIndexChanged += cmbMostrar_SelectedIndexChanged;
            // 
            // cmbInquilinoSeleccionado
            // 
            cmbInquilinoSeleccionado.BackColor = Color.FromArgb(255, 128, 128);
            cmbInquilinoSeleccionado.FlatStyle = FlatStyle.Flat;
            cmbInquilinoSeleccionado.ForeColor = SystemColors.Control;
            cmbInquilinoSeleccionado.FormattingEnabled = true;
            cmbInquilinoSeleccionado.Location = new Point(57, 90);
            cmbInquilinoSeleccionado.Name = "cmbInquilinoSeleccionado";
            cmbInquilinoSeleccionado.Size = new Size(492, 23);
            cmbInquilinoSeleccionado.TabIndex = 4;
            // 
            // lblInquilinoSeleccionado
            // 
            lblInquilinoSeleccionado.AutoSize = true;
            lblInquilinoSeleccionado.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblInquilinoSeleccionado.ForeColor = Color.Snow;
            lblInquilinoSeleccionado.Location = new Point(227, 19);
            lblInquilinoSeleccionado.Name = "lblInquilinoSeleccionado";
            lblInquilinoSeleccionado.Size = new Size(141, 32);
            lblInquilinoSeleccionado.TabIndex = 3;
            lblInquilinoSeleccionado.Text = "INQUILINO";
            lblInquilinoSeleccionado.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnOpciones
            // 
            btnOpciones.FlatStyle = FlatStyle.Flat;
            btnOpciones.Font = new Font("Segoe UI Black", 7.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnOpciones.ForeColor = SystemColors.ButtonFace;
            btnOpciones.Location = new Point(12, 13);
            btnOpciones.Name = "btnOpciones";
            btnOpciones.Size = new Size(35, 30);
            btnOpciones.TabIndex = 5;
            btnOpciones.Text = ". . .";
            btnOpciones.UseVisualStyleBackColor = true;
            btnOpciones.Click += btnOpciones_Click;
            // 
            // pnlOpciones
            // 
            pnlOpciones.BorderStyle = BorderStyle.FixedSingle;
            pnlOpciones.Controls.Add(btnAgregarTarjeta);
            pnlOpciones.Controls.Add(btnIngresarSaldo);
            pnlOpciones.Controls.Add(btnCerrarSesion);
            pnlOpciones.Controls.Add(btnOpcionesEnPanel);
            pnlOpciones.Controls.Add(btnHistorial);
            pnlOpciones.Controls.Add(btnServicios);
            pnlOpciones.Controls.Add(btnMensajes);
            pnlOpciones.Controls.Add(btnMostrarPagos);
            pnlOpciones.Controls.Add(btnMostrarDeudas);
            pnlOpciones.ForeColor = SystemColors.ButtonFace;
            pnlOpciones.Location = new Point(0, 0);
            pnlOpciones.Name = "pnlOpciones";
            pnlOpciones.Size = new Size(214, 659);
            pnlOpciones.TabIndex = 6;
            pnlOpciones.Visible = false;
            // 
            // btnAgregarTarjeta
            // 
            btnAgregarTarjeta.FlatStyle = FlatStyle.Flat;
            btnAgregarTarjeta.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarTarjeta.ForeColor = SystemColors.ButtonFace;
            btnAgregarTarjeta.Location = new Point(-1, 89);
            btnAgregarTarjeta.Name = "btnAgregarTarjeta";
            btnAgregarTarjeta.Size = new Size(211, 64);
            btnAgregarTarjeta.TabIndex = 10;
            btnAgregarTarjeta.Text = "AGREGAR TARJETA";
            btnAgregarTarjeta.UseVisualStyleBackColor = true;
            btnAgregarTarjeta.Visible = false;
            btnAgregarTarjeta.Click += btnAgregarTarjeta_Click;
            // 
            // btnIngresarSaldo
            // 
            btnIngresarSaldo.FlatStyle = FlatStyle.Flat;
            btnIngresarSaldo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresarSaldo.ForeColor = SystemColors.ButtonFace;
            btnIngresarSaldo.Location = new Point(-1, 159);
            btnIngresarSaldo.Name = "btnIngresarSaldo";
            btnIngresarSaldo.Size = new Size(211, 64);
            btnIngresarSaldo.TabIndex = 9;
            btnIngresarSaldo.Text = "INGRESAR SALDO";
            btnIngresarSaldo.UseVisualStyleBackColor = true;
            btnIngresarSaldo.Visible = false;
            btnIngresarSaldo.Click += btnIngresarSaldo_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = SystemColors.ButtonFace;
            btnCerrarSesion.Location = new Point(-1, 582);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(211, 64);
            btnCerrarSesion.TabIndex = 8;
            btnCerrarSesion.Text = "CERRAR SESIÓN";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnOpcionesEnPanel
            // 
            btnOpcionesEnPanel.FlatStyle = FlatStyle.Flat;
            btnOpcionesEnPanel.Font = new Font("Segoe UI Black", 7.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnOpcionesEnPanel.ForeColor = SystemColors.ButtonFace;
            btnOpcionesEnPanel.Location = new Point(10, 10);
            btnOpcionesEnPanel.Name = "btnOpcionesEnPanel";
            btnOpcionesEnPanel.Size = new Size(35, 30);
            btnOpcionesEnPanel.TabIndex = 7;
            btnOpcionesEnPanel.Text = ". . .";
            btnOpcionesEnPanel.UseVisualStyleBackColor = true;
            btnOpcionesEnPanel.Click += btnOpciones_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistorial.ForeColor = SystemColors.ButtonFace;
            btnHistorial.Location = new Point(0, 509);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(211, 64);
            btnHistorial.TabIndex = 4;
            btnHistorial.Text = "HISTORIAL";
            btnHistorial.UseVisualStyleBackColor = true;
            // 
            // btnServicios
            // 
            btnServicios.FlatStyle = FlatStyle.Flat;
            btnServicios.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnServicios.ForeColor = SystemColors.ButtonFace;
            btnServicios.Location = new Point(0, 439);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(211, 64);
            btnServicios.TabIndex = 3;
            btnServicios.Text = "SERVICIOS";
            btnServicios.UseVisualStyleBackColor = true;
            btnServicios.Click += btnServicios_Click;
            // 
            // btnMensajes
            // 
            btnMensajes.FlatStyle = FlatStyle.Flat;
            btnMensajes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMensajes.ForeColor = SystemColors.ButtonFace;
            btnMensajes.Location = new Point(0, 369);
            btnMensajes.Name = "btnMensajes";
            btnMensajes.Size = new Size(211, 64);
            btnMensajes.TabIndex = 2;
            btnMensajes.Text = "MENSAJES";
            btnMensajes.UseVisualStyleBackColor = true;
            btnMensajes.Click += btnMensajes_Click;
            // 
            // btnMostrarPagos
            // 
            btnMostrarPagos.FlatStyle = FlatStyle.Flat;
            btnMostrarPagos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMostrarPagos.ForeColor = SystemColors.ButtonFace;
            btnMostrarPagos.Location = new Point(0, 299);
            btnMostrarPagos.Name = "btnMostrarPagos";
            btnMostrarPagos.Size = new Size(211, 64);
            btnMostrarPagos.TabIndex = 1;
            btnMostrarPagos.Text = "PAGOS";
            btnMostrarPagos.UseVisualStyleBackColor = true;
            btnMostrarPagos.Click += btnMostrarPagos_Click;
            // 
            // btnMostrarDeudas
            // 
            btnMostrarDeudas.FlatStyle = FlatStyle.Flat;
            btnMostrarDeudas.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMostrarDeudas.ForeColor = SystemColors.ButtonFace;
            btnMostrarDeudas.Location = new Point(0, 229);
            btnMostrarDeudas.Name = "btnMostrarDeudas";
            btnMostrarDeudas.Size = new Size(211, 64);
            btnMostrarDeudas.TabIndex = 0;
            btnMostrarDeudas.Text = "DEUDAS";
            btnMostrarDeudas.UseVisualStyleBackColor = true;
            btnMostrarDeudas.Click += btnMostrarDeudas_Click;
            // 
            // grpIngreseSaldo
            // 
            grpIngreseSaldo.Controls.Add(lblCantSaldo);
            grpIngreseSaldo.Controls.Add(lblSaldoActual);
            grpIngreseSaldo.Controls.Add(lblMonto);
            grpIngreseSaldo.Controls.Add(txtCvv);
            grpIngreseSaldo.Controls.Add(lblCvv);
            grpIngreseSaldo.Controls.Add(lblNumeroTarjeta);
            grpIngreseSaldo.Controls.Add(txtMonto);
            grpIngreseSaldo.Controls.Add(txtNumeroTarjeta);
            grpIngreseSaldo.Controls.Add(btnConfirmar);
            grpIngreseSaldo.Controls.Add(lblIngreseSaldo);
            grpIngreseSaldo.Location = new Point(348, 595);
            grpIngreseSaldo.Name = "grpIngreseSaldo";
            grpIngreseSaldo.Size = new Size(611, 180);
            grpIngreseSaldo.TabIndex = 9;
            grpIngreseSaldo.TabStop = false;
            grpIngreseSaldo.Visible = false;
            // 
            // lblCantSaldo
            // 
            lblCantSaldo.AutoSize = true;
            lblCantSaldo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantSaldo.ForeColor = Color.Snow;
            lblCantSaldo.Location = new Point(171, 137);
            lblCantSaldo.Name = "lblCantSaldo";
            lblCantSaldo.Size = new Size(46, 15);
            lblCantSaldo.TabIndex = 18;
            lblCantSaldo.Text = "SALDO";
            lblCantSaldo.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSaldoActual
            // 
            lblSaldoActual.AutoSize = true;
            lblSaldoActual.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaldoActual.ForeColor = Color.Snow;
            lblSaldoActual.Location = new Point(68, 137);
            lblSaldoActual.Name = "lblSaldoActual";
            lblSaldoActual.Size = new Size(97, 15);
            lblSaldoActual.TabIndex = 17;
            lblSaldoActual.Text = "SALDO ACTUAL:";
            lblSaldoActual.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMonto.ForeColor = Color.Snow;
            lblMonto.Location = new Point(68, 100);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(55, 15);
            lblMonto.TabIndex = 16;
            lblMonto.Text = "MONTO:";
            lblMonto.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtCvv
            // 
            txtCvv.BackColor = SystemColors.Window;
            txtCvv.BorderStyle = BorderStyle.FixedSingle;
            txtCvv.Location = new Point(457, 63);
            txtCvv.Name = "txtCvv";
            txtCvv.Size = new Size(43, 23);
            txtCvv.TabIndex = 15;
            // 
            // lblCvv
            // 
            lblCvv.AutoSize = true;
            lblCvv.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCvv.ForeColor = Color.Snow;
            lblCvv.Location = new Point(418, 66);
            lblCvv.Name = "lblCvv";
            lblCvv.Size = new Size(33, 15);
            lblCvv.TabIndex = 14;
            lblCvv.Text = "CVV:";
            lblCvv.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNumeroTarjeta
            // 
            lblNumeroTarjeta.AutoSize = true;
            lblNumeroTarjeta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumeroTarjeta.ForeColor = Color.Snow;
            lblNumeroTarjeta.Location = new Point(68, 66);
            lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            lblNumeroTarjeta.Size = new Size(74, 15);
            lblNumeroTarjeta.TabIndex = 13;
            lblNumeroTarjeta.Text = "N° TARJETA:";
            lblNumeroTarjeta.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(148, 92);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(264, 23);
            txtMonto.TabIndex = 12;
            // 
            // txtNumeroTarjeta
            // 
            txtNumeroTarjeta.Location = new Point(148, 63);
            txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            txtNumeroTarjeta.Size = new Size(264, 23);
            txtNumeroTarjeta.TabIndex = 11;
            // 
            // btnConfirmar
            // 
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.ForeColor = SystemColors.ButtonFace;
            btnConfirmar.Location = new Point(353, 121);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(147, 37);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblIngreseSaldo
            // 
            lblIngreseSaldo.AutoSize = true;
            lblIngreseSaldo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngreseSaldo.ForeColor = Color.Snow;
            lblIngreseSaldo.Location = new Point(214, 19);
            lblIngreseSaldo.Name = "lblIngreseSaldo";
            lblIngreseSaldo.Size = new Size(198, 32);
            lblIngreseSaldo.TabIndex = 1;
            lblIngreseSaldo.Text = "INGRESE SALDO";
            lblIngreseSaldo.TextAlign = ContentAlignment.TopCenter;
            // 
            // grpDatosTarjeta
            // 
            grpDatosTarjeta.Controls.Add(lblNombreCompleto);
            grpDatosTarjeta.Controls.Add(txtNombreCompleto);
            grpDatosTarjeta.Controls.Add(lblCantSaldoTarjetaIngresada);
            grpDatosTarjeta.Controls.Add(lblSaldoActualTarjetaIngresada);
            grpDatosTarjeta.Controls.Add(txtCvvIngresado);
            grpDatosTarjeta.Controls.Add(lblNumeroTarjetaIngresada);
            grpDatosTarjeta.Controls.Add(lblCvvDt);
            grpDatosTarjeta.Controls.Add(txtNumeroTarjetaIngresada);
            grpDatosTarjeta.Controls.Add(btnConfirmarTarjetaIngresada);
            grpDatosTarjeta.Controls.Add(lblDatosTarjeta);
            grpDatosTarjeta.Location = new Point(579, 556);
            grpDatosTarjeta.Name = "grpDatosTarjeta";
            grpDatosTarjeta.Size = new Size(611, 180);
            grpDatosTarjeta.TabIndex = 19;
            grpDatosTarjeta.TabStop = false;
            grpDatosTarjeta.Visible = false;
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreCompleto.ForeColor = Color.Snow;
            lblNombreCompleto.Location = new Point(16, 100);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(126, 15);
            lblNombreCompleto.TabIndex = 22;
            lblNombreCompleto.Text = "NOMBRE COMPLETO:";
            lblNombreCompleto.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(148, 92);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(264, 23);
            txtNombreCompleto.TabIndex = 21;
            // 
            // lblCantSaldoTarjetaIngresada
            // 
            lblCantSaldoTarjetaIngresada.AutoSize = true;
            lblCantSaldoTarjetaIngresada.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantSaldoTarjetaIngresada.ForeColor = Color.Snow;
            lblCantSaldoTarjetaIngresada.Location = new Point(160, 133);
            lblCantSaldoTarjetaIngresada.Name = "lblCantSaldoTarjetaIngresada";
            lblCantSaldoTarjetaIngresada.Size = new Size(46, 15);
            lblCantSaldoTarjetaIngresada.TabIndex = 20;
            lblCantSaldoTarjetaIngresada.Text = "SALDO";
            lblCantSaldoTarjetaIngresada.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSaldoActualTarjetaIngresada
            // 
            lblSaldoActualTarjetaIngresada.AutoSize = true;
            lblSaldoActualTarjetaIngresada.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaldoActualTarjetaIngresada.ForeColor = Color.Snow;
            lblSaldoActualTarjetaIngresada.Location = new Point(57, 133);
            lblSaldoActualTarjetaIngresada.Name = "lblSaldoActualTarjetaIngresada";
            lblSaldoActualTarjetaIngresada.Size = new Size(97, 15);
            lblSaldoActualTarjetaIngresada.TabIndex = 19;
            lblSaldoActualTarjetaIngresada.Text = "SALDO ACTUAL:";
            lblSaldoActualTarjetaIngresada.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtCvvIngresado
            // 
            txtCvvIngresado.BackColor = SystemColors.Window;
            txtCvvIngresado.BorderStyle = BorderStyle.FixedSingle;
            txtCvvIngresado.Location = new Point(457, 63);
            txtCvvIngresado.Name = "txtCvvIngresado";
            txtCvvIngresado.Size = new Size(43, 23);
            txtCvvIngresado.TabIndex = 18;
            // 
            // lblNumeroTarjetaIngresada
            // 
            lblNumeroTarjetaIngresada.AutoSize = true;
            lblNumeroTarjetaIngresada.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumeroTarjetaIngresada.ForeColor = Color.Snow;
            lblNumeroTarjetaIngresada.Location = new Point(68, 66);
            lblNumeroTarjetaIngresada.Name = "lblNumeroTarjetaIngresada";
            lblNumeroTarjetaIngresada.Size = new Size(74, 15);
            lblNumeroTarjetaIngresada.TabIndex = 13;
            lblNumeroTarjetaIngresada.Text = "N° TARJETA:";
            lblNumeroTarjetaIngresada.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCvvDt
            // 
            lblCvvDt.AutoSize = true;
            lblCvvDt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCvvDt.ForeColor = Color.Snow;
            lblCvvDt.Location = new Point(418, 66);
            lblCvvDt.Name = "lblCvvDt";
            lblCvvDt.Size = new Size(33, 15);
            lblCvvDt.TabIndex = 17;
            lblCvvDt.Text = "CVV:";
            lblCvvDt.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNumeroTarjetaIngresada
            // 
            txtNumeroTarjetaIngresada.Location = new Point(148, 63);
            txtNumeroTarjetaIngresada.Name = "txtNumeroTarjetaIngresada";
            txtNumeroTarjetaIngresada.Size = new Size(264, 23);
            txtNumeroTarjetaIngresada.TabIndex = 11;
            // 
            // btnConfirmarTarjetaIngresada
            // 
            btnConfirmarTarjetaIngresada.FlatStyle = FlatStyle.Flat;
            btnConfirmarTarjetaIngresada.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmarTarjetaIngresada.ForeColor = SystemColors.ButtonFace;
            btnConfirmarTarjetaIngresada.Location = new Point(353, 121);
            btnConfirmarTarjetaIngresada.Name = "btnConfirmarTarjetaIngresada";
            btnConfirmarTarjetaIngresada.Size = new Size(147, 37);
            btnConfirmarTarjetaIngresada.TabIndex = 10;
            btnConfirmarTarjetaIngresada.Text = "CONFIRMAR";
            btnConfirmarTarjetaIngresada.UseVisualStyleBackColor = true;
            btnConfirmarTarjetaIngresada.Click += btnConfirmarTarjetaIngresada_Click;
            // 
            // lblDatosTarjeta
            // 
            lblDatosTarjeta.AutoSize = true;
            lblDatosTarjeta.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDatosTarjeta.ForeColor = Color.Snow;
            lblDatosTarjeta.Location = new Point(214, 19);
            lblDatosTarjeta.Name = "lblDatosTarjeta";
            lblDatosTarjeta.Size = new Size(197, 32);
            lblDatosTarjeta.TabIndex = 1;
            lblDatosTarjeta.Text = "DATOS TARJETA";
            lblDatosTarjeta.TextAlign = ContentAlignment.TopCenter;
            // 
            // grpServicios
            // 
            grpServicios.Controls.Add(txtPrecio);
            grpServicios.Controls.Add(btnGuardar);
            grpServicios.Controls.Add(lblServicios);
            grpServicios.Controls.Add(lblServicio);
            grpServicios.Controls.Add(chklServicios);
            grpServicios.Controls.Add(lblPrecio);
            grpServicios.Controls.Add(cmbServicios);
            grpServicios.Location = new Point(121, 199);
            grpServicios.Name = "grpServicios";
            grpServicios.Size = new Size(611, 151);
            grpServicios.TabIndex = 14;
            grpServicios.TabStop = false;
            grpServicios.Visible = false;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(255, 128, 128);
            txtPrecio.ForeColor = Color.White;
            txtPrecio.Location = new Point(417, 73);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(154, 23);
            txtPrecio.TabIndex = 16;
            txtPrecio.Visible = false;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = SystemColors.ButtonFace;
            btnGuardar.Location = new Point(227, 116);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(121, 29);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblServicios
            // 
            lblServicios.AutoSize = true;
            lblServicios.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblServicios.ForeColor = Color.Snow;
            lblServicios.Location = new Point(227, 19);
            lblServicios.Name = "lblServicios";
            lblServicios.Size = new Size(134, 32);
            lblServicios.TabIndex = 3;
            lblServicios.Text = "SERVICIOS";
            lblServicios.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblServicio.ForeColor = Color.Snow;
            lblServicio.Location = new Point(42, 73);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(68, 19);
            lblServicio.TabIndex = 15;
            lblServicio.Text = "Servicio:";
            lblServicio.TextAlign = ContentAlignment.TopCenter;
            lblServicio.Visible = false;
            // 
            // chklServicios
            // 
            chklServicios.BackColor = Color.FromArgb(255, 128, 128);
            chklServicios.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chklServicios.ForeColor = Color.WhiteSmoke;
            chklServicios.FormattingEnabled = true;
            chklServicios.Location = new Point(168, 58);
            chklServicios.Name = "chklServicios";
            chklServicios.Size = new Size(243, 52);
            chklServicios.TabIndex = 12;
            chklServicios.Visible = false;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecio.ForeColor = Color.Snow;
            lblPrecio.Location = new Point(343, 74);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(56, 19);
            lblPrecio.TabIndex = 17;
            lblPrecio.Text = "Precio:";
            lblPrecio.TextAlign = ContentAlignment.TopCenter;
            lblPrecio.Visible = false;
            // 
            // cmbServicios
            // 
            cmbServicios.BackColor = Color.FromArgb(255, 128, 128);
            cmbServicios.FlatStyle = FlatStyle.Flat;
            cmbServicios.ForeColor = SystemColors.Control;
            cmbServicios.FormattingEnabled = true;
            cmbServicios.Location = new Point(116, 73);
            cmbServicios.Name = "cmbServicios";
            cmbServicios.Size = new Size(155, 23);
            cmbServicios.TabIndex = 14;
            cmbServicios.Visible = false;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(797, 647);
            Controls.Add(grpDatosTarjeta);
            Controls.Add(grpIngreseSaldo);
            Controls.Add(pnlOpciones);
            Controls.Add(grpPagos);
            Controls.Add(grpDeudas);
            Controls.Add(btnOpciones);
            Controls.Add(grpInquilinoSeleccionado);
            Controls.Add(grpServicios);
            Name = "FrmMenu";
            Text = "FrmMenu";
            Load += FrmMenu_Load;
            Controls.SetChildIndex(grpServicios, 0);
            Controls.SetChildIndex(grpInquilinoSeleccionado, 0);
            Controls.SetChildIndex(btnOpciones, 0);
            Controls.SetChildIndex(grpDeudas, 0);
            Controls.SetChildIndex(grpPagos, 0);
            Controls.SetChildIndex(pnlOpciones, 0);
            Controls.SetChildIndex(grpIngreseSaldo, 0);
            Controls.SetChildIndex(grpDatosTarjeta, 0);
            grpDeudas.ResumeLayout(false);
            grpDeudas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDeudas).EndInit();
            grpPagos.ResumeLayout(false);
            grpPagos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgPagos).EndInit();
            grpInquilinoSeleccionado.ResumeLayout(false);
            grpInquilinoSeleccionado.PerformLayout();
            pnlOpciones.ResumeLayout(false);
            grpIngreseSaldo.ResumeLayout(false);
            grpIngreseSaldo.PerformLayout();
            grpDatosTarjeta.ResumeLayout(false);
            grpDatosTarjeta.PerformLayout();
            grpServicios.ResumeLayout(false);
            grpServicios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDeudas;
        private DataGridView dtgDeudas;
        private Label lblDeudas;
        private GroupBox grpPagos;
        private Label lblPagos;
        private DataGridView dtgPagos;
        private DataGridViewTextBoxColumn fechaAbonoPagos;
        private DataGridViewTextBoxColumn cantidadAbonadaPagos;
        private DataGridViewTextBoxColumn fechaVencimientoPagos;
        private GroupBox grpInquilinoSeleccionado;
        internal ComboBox cmbInquilinoSeleccionado;
        private Label lblInquilinoSeleccionado;
        private DataGridViewComboBoxColumn inquilino;
        private DataGridViewTextBoxColumn fechaEmisionDeudas;
        private DataGridViewTextBoxColumn cantidadAbonarDeudas;
        private DataGridViewTextBoxColumn FechaVencimiento;
        private Button btnOpciones;
        private Panel pnlOpciones;
        private Button btnMensajes;
        private Button btnMostrarPagos;
        private Button btnMostrarDeudas;
        private Button btnHistorial;
        private Button btnServicios;
        private Button btnOpcionesEnPanel;
        private Button btnCerrarSesion;
        private Button btnPagarDeudaSeleccionada;
        private Button btnPagarTotalDeudas;
        private Button btnIngresarSaldo;
        private GroupBox grpIngreseSaldo;
        private Label lblIngreseSaldo;
        private Label lblNumeroTarjeta;
        private TextBox txtMonto;
        private TextBox txtNumeroTarjeta;
        private Button btnConfirmar;
        private TextBox txtCvv;
        private Label lblCvv;
        private Label lblCantSaldo;
        private Label lblSaldoActual;
        private Label lblMonto;
        private Button btnAgregarTarjeta;
        private GroupBox grpDatosTarjeta;
        private Label lblMostrar;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Label lblNumeroTarjetaIngresada;
        private TextBox txtNumeroTarjetaIngresada;
        private Button btnConfirmarTarjetaIngresada;
        private Label lblDatosTarjeta;
        private Label lblNombreCompleto;
        private TextBox txtNombreCompleto;
        private Label lblCantSaldoTarjetaIngresada;
        private Label lblSaldoActualTarjetaIngresada;
        private TextBox txtCvvIngresado;
        private Label lblCvvDt;
        internal ComboBox cmbMostrar;
        private Button btnValidarInquilino;
        private GroupBox grpServicios;
        private Button btnGuardar;
        private Label lblServicios;
        private CheckedListBox chklServicios;
        internal ComboBox cmbServicios;
        private Label lblServicio;
    }
}