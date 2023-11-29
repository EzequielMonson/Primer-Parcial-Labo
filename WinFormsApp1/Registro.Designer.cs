namespace UI
{
    partial class Registro
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
            grpDatosViviendas = new GroupBox();
            nudHabitaciones = new NumericUpDown();
            lblServicios = new Label();
            chklServicios = new CheckedListBox();
            lblHabitaciones = new Label();
            nudPiso = new NumericUpDown();
            cboDepartamento = new ComboBox();
            cboCiudad = new ComboBox();
            nudInquilinos = new NumericUpDown();
            txtDireccionVivienda = new TextBox();
            cboArriendador = new ComboBox();
            lblDepartamento = new Label();
            lblArriendador = new Label();
            lblOcupantes = new Label();
            lblCiudadInqui = new Label();
            lblPiso = new Label();
            lblDireccion = new Label();
            grpRol = new GroupBox();
            radInquilino = new RadioButton();
            radAdministrador = new RadioButton();
            btnAtras = new Button();
            grpDatosEmpleo = new GroupBox();
            txtIdentificacion = new TextBox();
            lblIdentificacion = new Label();
            txtContacto = new TextBox();
            lblContactoAgencia = new Label();
            cboCiudadAdministrador = new ComboBox();
            txtAgencia = new TextBox();
            lblAgencia = new Label();
            lblCiudad = new Label();
            btnSiguiente = new Button();
            grpDatosIngreso = new GroupBox();
            txtConfirmacionClave = new TextBox();
            lblConfirmarContraseña = new Label();
            txtCorfirmacionCorreo = new TextBox();
            lblConfirmarCorreo = new Label();
            txtClaveIngreso = new TextBox();
            lblContraseña = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblTelefono = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtDni = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            txtEdad = new TextBox();
            lblEdad = new Label();
            lblFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            grpDatosPersonales = new GroupBox();
            grpDatosViviendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudHabitaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPiso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInquilinos).BeginInit();
            grpRol.SuspendLayout();
            grpDatosEmpleo.SuspendLayout();
            grpDatosIngreso.SuspendLayout();
            grpDatosPersonales.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatosViviendas
            // 
            grpDatosViviendas.Controls.Add(nudHabitaciones);
            grpDatosViviendas.Controls.Add(lblServicios);
            grpDatosViviendas.Controls.Add(chklServicios);
            grpDatosViviendas.Controls.Add(lblHabitaciones);
            grpDatosViviendas.Controls.Add(nudPiso);
            grpDatosViviendas.Controls.Add(cboDepartamento);
            grpDatosViviendas.Controls.Add(cboCiudad);
            grpDatosViviendas.Controls.Add(nudInquilinos);
            grpDatosViviendas.Controls.Add(txtDireccionVivienda);
            grpDatosViviendas.Controls.Add(cboArriendador);
            grpDatosViviendas.Controls.Add(lblDepartamento);
            grpDatosViviendas.Controls.Add(lblArriendador);
            grpDatosViviendas.Controls.Add(lblOcupantes);
            grpDatosViviendas.Controls.Add(lblCiudadInqui);
            grpDatosViviendas.Controls.Add(lblPiso);
            grpDatosViviendas.Controls.Add(lblDireccion);
            grpDatosViviendas.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            grpDatosViviendas.ForeColor = Color.White;
            grpDatosViviendas.Location = new Point(83, 221);
            grpDatosViviendas.Name = "grpDatosViviendas";
            grpDatosViviendas.Size = new Size(631, 205);
            grpDatosViviendas.TabIndex = 2;
            grpDatosViviendas.TabStop = false;
            grpDatosViviendas.Text = "Datos de la vivienda";
            grpDatosViviendas.Visible = false;
            // 
            // nudHabitaciones
            // 
            nudHabitaciones.BackColor = Color.FromArgb(255, 128, 128);
            nudHabitaciones.BorderStyle = BorderStyle.FixedSingle;
            nudHabitaciones.ForeColor = Color.White;
            nudHabitaciones.Location = new Point(412, 114);
            nudHabitaciones.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            nudHabitaciones.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudHabitaciones.Name = "nudHabitaciones";
            nudHabitaciones.Size = new Size(141, 27);
            nudHabitaciones.TabIndex = 26;
            nudHabitaciones.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblServicios
            // 
            lblServicios.AutoSize = true;
            lblServicios.Location = new Point(301, 147);
            lblServicios.Name = "lblServicios";
            lblServicios.Size = new Size(75, 20);
            lblServicios.TabIndex = 25;
            lblServicios.Text = "Servicios:";
            // 
            // chklServicios
            // 
            chklServicios.BackColor = Color.FromArgb(255, 128, 128);
            chklServicios.ForeColor = Color.White;
            chklServicios.FormattingEnabled = true;
            chklServicios.Location = new Point(412, 146);
            chklServicios.Name = "chklServicios";
            chklServicios.Size = new Size(141, 48);
            chklServicios.TabIndex = 24;
            // 
            // lblHabitaciones
            // 
            lblHabitaciones.AutoSize = true;
            lblHabitaciones.Location = new Point(301, 114);
            lblHabitaciones.Name = "lblHabitaciones";
            lblHabitaciones.Size = new Size(103, 20);
            lblHabitaciones.TabIndex = 23;
            lblHabitaciones.Text = "Habitaciones:";
            // 
            // nudPiso
            // 
            nudPiso.BackColor = Color.FromArgb(255, 128, 128);
            nudPiso.BorderStyle = BorderStyle.FixedSingle;
            nudPiso.ForeColor = Color.White;
            nudPiso.Location = new Point(165, 73);
            nudPiso.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            nudPiso.Name = "nudPiso";
            nudPiso.Size = new Size(129, 27);
            nudPiso.TabIndex = 22;
            // 
            // cboDepartamento
            // 
            cboDepartamento.BackColor = Color.FromArgb(255, 128, 128);
            cboDepartamento.FlatStyle = FlatStyle.Popup;
            cboDepartamento.ForeColor = Color.White;
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(165, 106);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(130, 28);
            cboDepartamento.TabIndex = 20;
            // 
            // cboCiudad
            // 
            cboCiudad.BackColor = Color.FromArgb(255, 128, 128);
            cboCiudad.FlatStyle = FlatStyle.Popup;
            cboCiudad.ForeColor = Color.White;
            cboCiudad.FormattingEnabled = true;
            cboCiudad.Items.AddRange(new object[] { "Buenos Aires", "Córdoba", "Rosario", "Mendoza", "La Plata", "San Miguel de Tucumán", "Mar del Plata", "Salta", "Santa Fe", "San Juan", "Neuquén", "Resistencia", "Corrientes", "Posadas", "Santiago del Estero", "San Salvador de Jujuy", "Formosa", "San Luis", "Catamarca", "La Rioja", "Rawson", "Viedma", "Santa Rosa", "Ushuaia", "Comodoro Rivadavia", "Bahía Blanca", "San Rafael", "San Fernando del Valle de Catamarca", "Junín", "Tandil", "Pergamino", "San Nicolás de los Arroyos", "Olavarría", "Trelew", "Río Cuarto", "San Carlos de Bariloche", "Villa María", "Concordia", "Gualeguaychú", "Santa Cruz", "San Justo", "Zárate" });
            cboCiudad.Location = new Point(412, 74);
            cboCiudad.Name = "cboCiudad";
            cboCiudad.Size = new Size(141, 28);
            cboCiudad.TabIndex = 19;
            // 
            // nudInquilinos
            // 
            nudInquilinos.BackColor = Color.FromArgb(255, 128, 128);
            nudInquilinos.BorderStyle = BorderStyle.FixedSingle;
            nudInquilinos.ForeColor = Color.White;
            nudInquilinos.Location = new Point(166, 140);
            nudInquilinos.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            nudInquilinos.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudInquilinos.Name = "nudInquilinos";
            nudInquilinos.Size = new Size(129, 27);
            nudInquilinos.TabIndex = 18;
            nudInquilinos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtDireccionVivienda
            // 
            txtDireccionVivienda.BackColor = Color.FromArgb(255, 128, 128);
            txtDireccionVivienda.ForeColor = Color.White;
            txtDireccionVivienda.Location = new Point(166, 37);
            txtDireccionVivienda.Name = "txtDireccionVivienda";
            txtDireccionVivienda.Size = new Size(129, 27);
            txtDireccionVivienda.TabIndex = 17;
            // 
            // cboArriendador
            // 
            cboArriendador.BackColor = Color.FromArgb(255, 128, 128);
            cboArriendador.FlatStyle = FlatStyle.Popup;
            cboArriendador.ForeColor = Color.White;
            cboArriendador.FormattingEnabled = true;
            cboArriendador.Location = new Point(412, 36);
            cboArriendador.Name = "cboArriendador";
            cboArriendador.Size = new Size(141, 28);
            cboArriendador.TabIndex = 15;
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Location = new Point(32, 110);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(115, 20);
            lblDepartamento.TabIndex = 7;
            lblDepartamento.Text = "Departamento:";
            // 
            // lblArriendador
            // 
            lblArriendador.AutoSize = true;
            lblArriendador.Location = new Point(301, 40);
            lblArriendador.Name = "lblArriendador";
            lblArriendador.Size = new Size(99, 20);
            lblArriendador.TabIndex = 6;
            lblArriendador.Text = "Arriendador:";
            // 
            // lblOcupantes
            // 
            lblOcupantes.AutoSize = true;
            lblOcupantes.Location = new Point(33, 145);
            lblOcupantes.Name = "lblOcupantes";
            lblOcupantes.Size = new Size(82, 20);
            lblOcupantes.TabIndex = 5;
            lblOcupantes.Text = "Inquilinos:";
            lblOcupantes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCiudadInqui
            // 
            lblCiudadInqui.AutoSize = true;
            lblCiudadInqui.Location = new Point(301, 77);
            lblCiudadInqui.Name = "lblCiudadInqui";
            lblCiudadInqui.Size = new Size(61, 20);
            lblCiudadInqui.TabIndex = 5;
            lblCiudadInqui.Text = "Ciudad:";
            // 
            // lblPiso
            // 
            lblPiso.AutoSize = true;
            lblPiso.Location = new Point(32, 77);
            lblPiso.Name = "lblPiso";
            lblPiso.Size = new Size(42, 20);
            lblPiso.TabIndex = 4;
            lblPiso.Text = "Piso:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(33, 40);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(78, 20);
            lblDireccion.TabIndex = 16;
            lblDireccion.Text = "Dirección:";
            // 
            // grpRol
            // 
            grpRol.Controls.Add(radInquilino);
            grpRol.Controls.Add(radAdministrador);
            grpRol.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            grpRol.ForeColor = SystemColors.ButtonHighlight;
            grpRol.Location = new Point(562, 34);
            grpRol.Name = "grpRol";
            grpRol.Size = new Size(152, 181);
            grpRol.TabIndex = 3;
            grpRol.TabStop = false;
            grpRol.Text = "Usted es:";
            // 
            // radInquilino
            // 
            radInquilino.AutoSize = true;
            radInquilino.FlatStyle = FlatStyle.Popup;
            radInquilino.Location = new Point(16, 123);
            radInquilino.Name = "radInquilino";
            radInquilino.Size = new Size(88, 24);
            radInquilino.TabIndex = 1;
            radInquilino.TabStop = true;
            radInquilino.Text = "Inquilino";
            radInquilino.UseVisualStyleBackColor = true;
            radInquilino.CheckedChanged += RadInquilino_CheckedChanged;
            // 
            // radAdministrador
            // 
            radAdministrador.AutoSize = true;
            radAdministrador.FlatStyle = FlatStyle.Popup;
            radAdministrador.Location = new Point(16, 67);
            radAdministrador.Name = "radAdministrador";
            radAdministrador.Size = new Size(128, 24);
            radAdministrador.TabIndex = 0;
            radAdministrador.TabStop = true;
            radAdministrador.Text = "Administrador";
            radAdministrador.UseVisualStyleBackColor = true;
            radAdministrador.CheckedChanged += radAdministrador_CheckedChanged;
            // 
            // btnAtras
            // 
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtras.ImageAlign = ContentAlignment.TopRight;
            btnAtras.Location = new Point(12, 12);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(30, 30);
            btnAtras.TabIndex = 30;
            btnAtras.Text = "🢀";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += BtnAtras_Click;
            // 
            // grpDatosEmpleo
            // 
            grpDatosEmpleo.Controls.Add(txtIdentificacion);
            grpDatosEmpleo.Controls.Add(lblIdentificacion);
            grpDatosEmpleo.Controls.Add(txtContacto);
            grpDatosEmpleo.Controls.Add(lblContactoAgencia);
            grpDatosEmpleo.Controls.Add(cboCiudadAdministrador);
            grpDatosEmpleo.Controls.Add(txtAgencia);
            grpDatosEmpleo.Controls.Add(lblAgencia);
            grpDatosEmpleo.Controls.Add(lblCiudad);
            grpDatosEmpleo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            grpDatosEmpleo.ForeColor = Color.White;
            grpDatosEmpleo.Location = new Point(83, 432);
            grpDatosEmpleo.Name = "grpDatosEmpleo";
            grpDatosEmpleo.Size = new Size(631, 171);
            grpDatosEmpleo.TabIndex = 24;
            grpDatosEmpleo.TabStop = false;
            grpDatosEmpleo.Text = "Datos de empleo";
            grpDatosEmpleo.Visible = false;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.BackColor = Color.FromArgb(255, 128, 128);
            txtIdentificacion.ForeColor = Color.White;
            txtIdentificacion.Location = new Point(461, 119);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(150, 27);
            txtIdentificacion.TabIndex = 26;
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Location = new Point(297, 119);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(108, 20);
            lblIdentificacion.TabIndex = 25;
            lblIdentificacion.Text = "Identificacion:";
            // 
            // txtContacto
            // 
            txtContacto.BackColor = Color.FromArgb(255, 128, 128);
            txtContacto.ForeColor = Color.White;
            txtContacto.Location = new Point(461, 41);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(150, 27);
            txtContacto.TabIndex = 24;
            // 
            // lblContactoAgencia
            // 
            lblContactoAgencia.AutoSize = true;
            lblContactoAgencia.Location = new Point(281, 44);
            lblContactoAgencia.Name = "lblContactoAgencia";
            lblContactoAgencia.Size = new Size(174, 20);
            lblContactoAgencia.TabIndex = 23;
            lblContactoAgencia.Text = " Contacto de la agencia:";
            // 
            // cboCiudadAdministrador
            // 
            cboCiudadAdministrador.BackColor = Color.FromArgb(255, 128, 128);
            cboCiudadAdministrador.FlatStyle = FlatStyle.Popup;
            cboCiudadAdministrador.ForeColor = Color.White;
            cboCiudadAdministrador.FormattingEnabled = true;
            cboCiudadAdministrador.Items.AddRange(new object[] { "Buenos Aires", "Córdoba", "Rosario", "Mendoza", "La Plata", "San Miguel de Tucumán", "Mar del Plata", "Salta", "Santa Fe", "San Juan", "Neuquén", "Resistencia", "Corrientes", "Posadas", "Santiago del Estero", "San Salvador de Jujuy", "Formosa", "San Luis", "Catamarca", "La Rioja", "Rawson", "Viedma", "Santa Rosa", "Ushuaia", "Comodoro Rivadavia", "Bahía Blanca", "San Rafael", "San Fernando del Valle de Catamarca", "Junín", "Tandil", "Pergamino", "San Nicolás de los Arroyos", "Olavarría", "Trelew", "Río Cuarto", "San Carlos de Bariloche", "Villa María", "Concordia", "Gualeguaychú", "Santa Cruz", "San Justo", "Zárate", "" });
            cboCiudadAdministrador.Location = new Point(100, 116);
            cboCiudadAdministrador.Name = "cboCiudadAdministrador";
            cboCiudadAdministrador.Size = new Size(162, 28);
            cboCiudadAdministrador.TabIndex = 19;
            // 
            // txtAgencia
            // 
            txtAgencia.BackColor = Color.FromArgb(255, 128, 128);
            txtAgencia.ForeColor = Color.White;
            txtAgencia.Location = new Point(100, 41);
            txtAgencia.Name = "txtAgencia";
            txtAgencia.Size = new Size(162, 27);
            txtAgencia.TabIndex = 17;
            // 
            // lblAgencia
            // 
            lblAgencia.AutoSize = true;
            lblAgencia.Location = new Point(33, 40);
            lblAgencia.Name = "lblAgencia";
            lblAgencia.Size = new Size(69, 20);
            lblAgencia.TabIndex = 16;
            lblAgencia.Text = "Agencia:";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(40, 119);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(61, 20);
            lblCiudad.TabIndex = 5;
            lblCiudad.Text = "Ciudad:";
            // 
            // btnSiguiente
            // 
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiguiente.ForeColor = Color.White;
            btnSiguiente.Location = new Point(318, 656);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(123, 40);
            btnSiguiente.TabIndex = 31;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Visible = false;
            btnSiguiente.Click += BtnSiguiente_Click;
            // 
            // grpDatosIngreso
            // 
            grpDatosIngreso.Controls.Add(txtConfirmacionClave);
            grpDatosIngreso.Controls.Add(lblConfirmarContraseña);
            grpDatosIngreso.Controls.Add(txtCorfirmacionCorreo);
            grpDatosIngreso.Controls.Add(lblConfirmarCorreo);
            grpDatosIngreso.Controls.Add(txtClaveIngreso);
            grpDatosIngreso.Controls.Add(lblContraseña);
            grpDatosIngreso.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            grpDatosIngreso.ForeColor = Color.White;
            grpDatosIngreso.Location = new Point(83, 432);
            grpDatosIngreso.Name = "grpDatosIngreso";
            grpDatosIngreso.Size = new Size(631, 127);
            grpDatosIngreso.TabIndex = 27;
            grpDatosIngreso.TabStop = false;
            grpDatosIngreso.Text = "Datos de ingreso";
            grpDatosIngreso.Visible = false;
            // 
            // txtConfirmacionClave
            // 
            txtConfirmacionClave.BackColor = Color.FromArgb(255, 128, 128);
            txtConfirmacionClave.ForeColor = Color.White;
            txtConfirmacionClave.Location = new Point(451, 63);
            txtConfirmacionClave.Name = "txtConfirmacionClave";
            txtConfirmacionClave.Size = new Size(172, 27);
            txtConfirmacionClave.TabIndex = 24;
            // 
            // lblConfirmarContraseña
            // 
            lblConfirmarContraseña.AutoSize = true;
            lblConfirmarContraseña.Location = new Point(290, 70);
            lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            lblConfirmarContraseña.Size = new Size(165, 20);
            lblConfirmarContraseña.TabIndex = 23;
            lblConfirmarContraseña.Text = "Confirmar contraseña:";
            // 
            // txtCorfirmacionCorreo
            // 
            txtCorfirmacionCorreo.BackColor = Color.FromArgb(255, 128, 128);
            txtCorfirmacionCorreo.ForeColor = Color.White;
            txtCorfirmacionCorreo.Location = new Point(193, 30);
            txtCorfirmacionCorreo.Name = "txtCorfirmacionCorreo";
            txtCorfirmacionCorreo.Size = new Size(360, 27);
            txtCorfirmacionCorreo.TabIndex = 22;
            // 
            // lblConfirmarCorreo
            // 
            lblConfirmarCorreo.AutoSize = true;
            lblConfirmarCorreo.Location = new Point(32, 37);
            lblConfirmarCorreo.Name = "lblConfirmarCorreo";
            lblConfirmarCorreo.Size = new Size(133, 20);
            lblConfirmarCorreo.TabIndex = 21;
            lblConfirmarCorreo.Text = "Confirmar correo:";
            // 
            // txtClaveIngreso
            // 
            txtClaveIngreso.BackColor = Color.FromArgb(255, 128, 128);
            txtClaveIngreso.ForeColor = Color.White;
            txtClaveIngreso.Location = new Point(123, 59);
            txtClaveIngreso.Name = "txtClaveIngreso";
            txtClaveIngreso.Size = new Size(158, 27);
            txtClaveIngreso.TabIndex = 20;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(25, 66);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(92, 20);
            lblContraseña.TabIndex = 19;
            lblContraseña.Text = "Contraseña:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(40, 38);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(40, 71);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(71, 20);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(40, 105);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(41, 20);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(40, 139);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(74, 20);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Telefono:";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.FromArgb(255, 128, 128);
            txtApellido.ForeColor = Color.White;
            txtApellido.Location = new Point(129, 68);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 27);
            txtApellido.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(255, 128, 128);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(129, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(255, 128, 128);
            txtTelefono.ForeColor = Color.White;
            txtTelefono.Location = new Point(129, 136);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 27);
            txtTelefono.TabIndex = 9;
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.FromArgb(255, 128, 128);
            txtDni.ForeColor = Color.White;
            txtDni.Location = new Point(129, 102);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 27);
            txtDni.TabIndex = 7;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(235, 75);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(60, 20);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(255, 128, 128);
            txtCorreo.ForeColor = Color.White;
            txtCorreo.Location = new Point(301, 68);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(158, 27);
            txtCorreo.TabIndex = 14;
            // 
            // txtEdad
            // 
            txtEdad.BackColor = Color.FromArgb(255, 128, 128);
            txtEdad.ForeColor = Color.White;
            txtEdad.Location = new Point(301, 35);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(158, 27);
            txtEdad.TabIndex = 11;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(235, 42);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(47, 20);
            lblEdad.TabIndex = 15;
            lblEdad.Text = "Edad:";
            lblEdad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(235, 105);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(91, 40);
            lblFechaNacimiento.TabIndex = 16;
            lblFechaNacimiento.Text = "Fecha de\nnacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dtpFechaNacimiento.CalendarMonthBackground = Color.FromArgb(255, 128, 128);
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(332, 118);
            dtpFechaNacimiento.MaxDate = new DateTime(2123, 10, 14, 0, 0, 0, 0);
            dtpFechaNacimiento.MinDate = new DateTime(1920, 1, 1, 0, 0, 0, 0);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(127, 27);
            dtpFechaNacimiento.TabIndex = 9;
            dtpFechaNacimiento.Value = new DateTime(2023, 10, 13, 0, 0, 0, 0);
            // 
            // grpDatosPersonales
            // 
            grpDatosPersonales.Controls.Add(dtpFechaNacimiento);
            grpDatosPersonales.Controls.Add(lblFechaNacimiento);
            grpDatosPersonales.Controls.Add(lblEdad);
            grpDatosPersonales.Controls.Add(txtEdad);
            grpDatosPersonales.Controls.Add(txtCorreo);
            grpDatosPersonales.Controls.Add(lblCorreo);
            grpDatosPersonales.Controls.Add(txtDni);
            grpDatosPersonales.Controls.Add(txtTelefono);
            grpDatosPersonales.Controls.Add(txtNombre);
            grpDatosPersonales.Controls.Add(txtApellido);
            grpDatosPersonales.Controls.Add(lblTelefono);
            grpDatosPersonales.Controls.Add(lblDni);
            grpDatosPersonales.Controls.Add(lblApellido);
            grpDatosPersonales.Controls.Add(lblNombre);
            grpDatosPersonales.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            grpDatosPersonales.ForeColor = SystemColors.ButtonHighlight;
            grpDatosPersonales.Location = new Point(83, 34);
            grpDatosPersonales.Name = "grpDatosPersonales";
            grpDatosPersonales.Size = new Size(473, 181);
            grpDatosPersonales.TabIndex = 2;
            grpDatosPersonales.TabStop = false;
            grpDatosPersonales.Text = "Datos personales";
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 745);
            Controls.Add(grpDatosEmpleo);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAtras);
            Controls.Add(grpRol);
            Controls.Add(grpDatosPersonales);
            Controls.Add(grpDatosIngreso);
            Controls.Add(grpDatosViviendas);
            Name = "Registro";
            Text = "Form1";
            Load += Registro_Load;
            Controls.SetChildIndex(grpDatosViviendas, 0);
            Controls.SetChildIndex(grpDatosIngreso, 0);
            Controls.SetChildIndex(grpDatosPersonales, 0);
            Controls.SetChildIndex(grpRol, 0);
            Controls.SetChildIndex(btnAtras, 0);
            Controls.SetChildIndex(btnSiguiente, 0);
            Controls.SetChildIndex(grpDatosEmpleo, 0);
            grpDatosViviendas.ResumeLayout(false);
            grpDatosViviendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudHabitaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPiso).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInquilinos).EndInit();
            grpRol.ResumeLayout(false);
            grpRol.PerformLayout();
            grpDatosEmpleo.ResumeLayout(false);
            grpDatosEmpleo.PerformLayout();
            grpDatosIngreso.ResumeLayout(false);
            grpDatosIngreso.PerformLayout();
            grpDatosPersonales.ResumeLayout(false);
            grpDatosPersonales.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpDatosViviendas;
        private Label lblPiso;
        private GroupBox grpRol;
        private Label lblDepartamento;
        private Label lblArriendador;
        private Label lblCiudadInqui;
        private Label lblOcupantes;
        private RadioButton radInquilino;
        private RadioButton radAdministrador;
        private ComboBox cboArriendador;
        private Label lblDireccion;
        private NumericUpDown nudInquilinos;
        private TextBox txtDireccionVivienda;
        private Button btnAtras;
        private NumericUpDown nudPiso;
        private ComboBox cboDepartamento;
        private ComboBox cboCiudad;
        private GroupBox grpDatosEmpleo;
        private Label lblContactoAgencia;
        private ComboBox cboCiudadAdministrador;
        private TextBox txtAgencia;
        private Label lblAgencia;
        private Label lblCiudad;
        private TextBox txtContacto;
        private Label lblServicios;
        private CheckedListBox chklServicios;
        private TextBox txtIdentificacion;
        private Label lblIdentificacion;
        private Button btnSiguiente;
        private GroupBox grpDatosIngreso;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblTelefono;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtDni;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private TextBox txtEdad;
        private Label lblEdad;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private GroupBox groupBox4;
        private TextBox txtConfirmacionClave;
        private Label lblConfirmarContraseña;
        private TextBox txtCorfirmacionCorreo;
        private Label lblConfirmarCorreo;
        private TextBox txtClaveIngreso;
        private Label lblContraseña;
        private NumericUpDown nudHabitaciones;
        private Label lblHabitaciones;
        private GroupBox grpDatosPersonales;
    }
}