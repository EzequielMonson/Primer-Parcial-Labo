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
            label3 = new Label();
            chklServicios = new CheckedListBox();
            label7 = new Label();
            nudPiso = new NumericUpDown();
            cboUso = new ComboBox();
            cboDepartamento = new ComboBox();
            cboCiudad = new ComboBox();
            nudIinquilinos = new NumericUpDown();
            txtDireccion = new TextBox();
            label6 = new Label();
            cboArriendador = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            lblOcupantes = new Label();
            label8 = new Label();
            lblPiso = new Label();
            grpRol = new GroupBox();
            radInquilino = new RadioButton();
            radAdministrador = new RadioButton();
            btnAtras = new Button();
            grpDatosEmpleo = new GroupBox();
            txtIdentificacion = new TextBox();
            label5 = new Label();
            txtContacto = new TextBox();
            label1 = new Label();
            cboCiudadAdministrador = new ComboBox();
            txtAgencia = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label11 = new Label();
            btnSiguiente = new Button();
            grpDatosIngreso = new GroupBox();
            txtConfirmacionClave = new TextBox();
            label15 = new Label();
            txtCorfirmacionCorreo = new TextBox();
            label14 = new Label();
            txtClaveIngreso = new TextBox();
            label13 = new Label();
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
            groupBox4 = new GroupBox();
            grpDatosViviendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPiso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudIinquilinos).BeginInit();
            grpRol.SuspendLayout();
            grpDatosEmpleo.SuspendLayout();
            grpDatosIngreso.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatosViviendas
            // 
            grpDatosViviendas.Controls.Add(label3);
            grpDatosViviendas.Controls.Add(chklServicios);
            grpDatosViviendas.Controls.Add(label7);
            grpDatosViviendas.Controls.Add(nudPiso);
            grpDatosViviendas.Controls.Add(cboUso);
            grpDatosViviendas.Controls.Add(cboDepartamento);
            grpDatosViviendas.Controls.Add(cboCiudad);
            grpDatosViviendas.Controls.Add(nudIinquilinos);
            grpDatosViviendas.Controls.Add(txtDireccion);
            grpDatosViviendas.Controls.Add(cboArriendador);
            grpDatosViviendas.Controls.Add(label10);
            grpDatosViviendas.Controls.Add(label9);
            grpDatosViviendas.Controls.Add(lblOcupantes);
            grpDatosViviendas.Controls.Add(label8);
            grpDatosViviendas.Controls.Add(lblPiso);
            grpDatosViviendas.Controls.Add(label6);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 147);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 25;
            label3.Text = "Servicios:";
            // 
            // chklServicios
            // 
            chklServicios.BackColor = Color.FromArgb(255, 128, 128);
            chklServicios.ForeColor = Color.White;
            chklServicios.FormattingEnabled = true;
            chklServicios.Items.AddRange(new object[] { "Luz", "Agua", "Gas" });
            chklServicios.Location = new Point(412, 146);
            chklServicios.Name = "chklServicios";
            chklServicios.Size = new Size(141, 48);
            chklServicios.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(312, 114);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 23;
            label7.Text = "Uso:";
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
            // cboUso
            // 
            cboUso.BackColor = Color.FromArgb(255, 128, 128);
            cboUso.FlatStyle = FlatStyle.Popup;
            cboUso.ForeColor = Color.White;
            cboUso.FormattingEnabled = true;
            cboUso.Location = new Point(412, 110);
            cboUso.Name = "cboUso";
            cboUso.Size = new Size(141, 28);
            cboUso.TabIndex = 21;
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
            cboCiudad.Location = new Point(412, 74);
            cboCiudad.Name = "cboCiudad";
            cboCiudad.Size = new Size(141, 28);
            cboCiudad.TabIndex = 19;
            // 
            // nudIinquilinos
            // 
            nudIinquilinos.BackColor = Color.FromArgb(255, 128, 128);
            nudIinquilinos.BorderStyle = BorderStyle.FixedSingle;
            nudIinquilinos.ForeColor = Color.White;
            nudIinquilinos.Location = new Point(166, 140);
            nudIinquilinos.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            nudIinquilinos.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudIinquilinos.Name = "nudIinquilinos";
            nudIinquilinos.Size = new Size(129, 27);
            nudIinquilinos.TabIndex = 18;
            nudIinquilinos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.FromArgb(255, 128, 128);
            txtDireccion.ForeColor = Color.White;
            txtDireccion.Location = new Point(166, 37);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(129, 27);
            txtDireccion.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 40);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 16;
            label6.Text = "Dirección:";
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(32, 110);
            label10.Name = "label10";
            label10.Size = new Size(115, 20);
            label10.TabIndex = 7;
            label10.Text = "Departamento:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(312, 40);
            label9.Name = "label9";
            label9.Size = new Size(99, 20);
            label9.TabIndex = 6;
            label9.Text = "Arriendador:";
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(312, 77);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 5;
            label8.Text = "Ciudad:";
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
            grpDatosEmpleo.Controls.Add(label5);
            grpDatosEmpleo.Controls.Add(txtContacto);
            grpDatosEmpleo.Controls.Add(label1);
            grpDatosEmpleo.Controls.Add(cboCiudadAdministrador);
            grpDatosEmpleo.Controls.Add(txtAgencia);
            grpDatosEmpleo.Controls.Add(label2);
            grpDatosEmpleo.Controls.Add(label4);
            grpDatosEmpleo.Controls.Add(label11);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(297, 119);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 25;
            label5.Text = "Identificacion:";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 44);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 23;
            label1.Text = " Contacto de la agencia:";
            // 
            // cboCiudadAdministrador
            // 
            cboCiudadAdministrador.BackColor = Color.FromArgb(255, 128, 128);
            cboCiudadAdministrador.FlatStyle = FlatStyle.Popup;
            cboCiudadAdministrador.ForeColor = Color.White;
            cboCiudadAdministrador.FormattingEnabled = true;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 40);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 16;
            label2.Text = "Agencia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(312, 40);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(40, 119);
            label11.Name = "label11";
            label11.Size = new Size(61, 20);
            label11.TabIndex = 5;
            label11.Text = "Ciudad:";
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
            grpDatosIngreso.Controls.Add(label15);
            grpDatosIngreso.Controls.Add(txtCorfirmacionCorreo);
            grpDatosIngreso.Controls.Add(label14);
            grpDatosIngreso.Controls.Add(txtClaveIngreso);
            grpDatosIngreso.Controls.Add(label13);
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
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(290, 70);
            label15.Name = "label15";
            label15.Size = new Size(165, 20);
            label15.TabIndex = 23;
            label15.Text = "Confirmar contraseña:";
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
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(32, 37);
            label14.Name = "label14";
            label14.Size = new Size(133, 20);
            label14.TabIndex = 21;
            label14.Text = "Confirmar correo:";
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
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(25, 66);
            label13.Name = "label13";
            label13.Size = new Size(92, 20);
            label13.TabIndex = 19;
            label13.Text = "Contraseña:";
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
            // groupBox4
            // 
            groupBox4.Controls.Add(dtpFechaNacimiento);
            groupBox4.Controls.Add(lblFechaNacimiento);
            groupBox4.Controls.Add(lblEdad);
            groupBox4.Controls.Add(txtEdad);
            groupBox4.Controls.Add(txtCorreo);
            groupBox4.Controls.Add(lblCorreo);
            groupBox4.Controls.Add(txtDni);
            groupBox4.Controls.Add(txtTelefono);
            groupBox4.Controls.Add(txtNombre);
            groupBox4.Controls.Add(txtApellido);
            groupBox4.Controls.Add(lblTelefono);
            groupBox4.Controls.Add(lblDni);
            groupBox4.Controls.Add(lblApellido);
            groupBox4.Controls.Add(lblNombre);
            groupBox4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.ForeColor = SystemColors.ButtonHighlight;
            groupBox4.Location = new Point(83, 34);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(473, 181);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos personales";
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 745);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAtras);
            Controls.Add(grpRol);
            Controls.Add(groupBox4);
            Controls.Add(grpDatosIngreso);
            Controls.Add(grpDatosViviendas);
            Controls.Add(grpDatosEmpleo);
            Name = "Registro";
            Text = "Form1";
            Load += Registro_Load;
            Controls.SetChildIndex(grpDatosEmpleo, 0);
            Controls.SetChildIndex(grpDatosViviendas, 0);
            Controls.SetChildIndex(grpDatosIngreso, 0);
            Controls.SetChildIndex(groupBox4, 0);
            Controls.SetChildIndex(grpRol, 0);
            Controls.SetChildIndex(btnAtras, 0);
            Controls.SetChildIndex(btnSiguiente, 0);
            grpDatosViviendas.ResumeLayout(false);
            grpDatosViviendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPiso).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudIinquilinos).EndInit();
            grpRol.ResumeLayout(false);
            grpRol.PerformLayout();
            grpDatosEmpleo.ResumeLayout(false);
            grpDatosEmpleo.PerformLayout();
            grpDatosIngreso.ResumeLayout(false);
            grpDatosIngreso.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpDatosViviendas;
        private Label lblPiso;
        private GroupBox grpRol;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label lblOcupantes;
        private RadioButton radInquilino;
        private RadioButton radAdministrador;
        private ComboBox cboArriendador;
        private Label label6;
        private NumericUpDown nudIinquilinos;
        private TextBox txtDireccion;
        private Button btnAtras;
        private NumericUpDown nudPiso;
        private ComboBox cboUso;
        private ComboBox cboDepartamento;
        private ComboBox cboCiudad;
        private Label label7;
        private GroupBox grpDatosEmpleo;
        private Label label1;
        private ComboBox cboCiudadAdministrador;
        private TextBox txtAgencia;
        private Label label2;
        private Label label4;
        private Label label11;
        private TextBox txtContacto;
        private Label label3;
        private CheckedListBox chklServicios;
        private TextBox txtIdentificacion;
        private Label label5;
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
        private Label label15;
        private TextBox txtCorfirmacionCorreo;
        private Label label14;
        private TextBox txtClaveIngreso;
        private Label label13;
    }
}