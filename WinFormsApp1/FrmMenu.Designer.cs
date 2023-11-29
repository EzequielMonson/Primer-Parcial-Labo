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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            grpDeudas = new GroupBox();
            lblDeudas = new Label();
            dtgDeudas = new DataGridView();
            inquilino = new DataGridViewComboBoxColumn();
            fechaEmisionDeudas = new DataGridViewTextBoxColumn();
            cantidadAbonarDeudas = new DataGridViewTextBoxColumn();
            FechaVencimiento = new DataGridViewTextBoxColumn();
            notifyIcon1 = new NotifyIcon(components);
            grpPagos = new GroupBox();
            lblPagos = new Label();
            dtgPagos = new DataGridView();
            fechaAbonoPagos = new DataGridViewTextBoxColumn();
            cantidadAbonadaPagos = new DataGridViewTextBoxColumn();
            fechaVencimientoPagos = new DataGridViewTextBoxColumn();
            grpInquilinoSeleccionado = new GroupBox();
            cmbInquilinoSeleccionado = new ComboBox();
            lblInquilinoSeleccionado = new Label();
            btnOpciones = new Button();
            pnlOpciones = new Panel();
            btnIngresarSaldo = new Button();
            button4 = new Button();
            btnOpcionesEnPanel = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnMostrarPagos = new Button();
            btnMostrarDeudas = new Button();
            btnPagarDeudaSeleccionada = new Button();
            btnPagarTotalDeudas = new Button();
            grpDeudas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDeudas).BeginInit();
            grpPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgPagos).BeginInit();
            grpInquilinoSeleccionado.SuspendLayout();
            pnlOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // grpDeudas
            // 
            grpDeudas.Controls.Add(lblDeudas);
            grpDeudas.Controls.Add(dtgDeudas);
            grpDeudas.Location = new Point(121, 170);
            grpDeudas.Name = "grpDeudas";
            grpDeudas.Size = new Size(611, 184);
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
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            // 
            // grpPagos
            // 
            grpPagos.Controls.Add(lblPagos);
            grpPagos.Controls.Add(dtgPagos);
            grpPagos.Location = new Point(121, 373);
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
            dataGridViewCellStyle1.BackColor = Color.Salmon;
            fechaAbonoPagos.DefaultCellStyle = dataGridViewCellStyle1;
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
            grpInquilinoSeleccionado.Controls.Add(cmbInquilinoSeleccionado);
            grpInquilinoSeleccionado.Controls.Add(lblInquilinoSeleccionado);
            grpInquilinoSeleccionado.Location = new Point(121, 42);
            grpInquilinoSeleccionado.Name = "grpInquilinoSeleccionado";
            grpInquilinoSeleccionado.Size = new Size(611, 113);
            grpInquilinoSeleccionado.TabIndex = 4;
            grpInquilinoSeleccionado.TabStop = false;
            grpInquilinoSeleccionado.Visible = false;
            // 
            // cmbInquilinoSeleccionado
            // 
            cmbInquilinoSeleccionado.BackColor = Color.FromArgb(255, 128, 128);
            cmbInquilinoSeleccionado.FlatStyle = FlatStyle.Flat;
            cmbInquilinoSeleccionado.ForeColor = SystemColors.Control;
            cmbInquilinoSeleccionado.FormattingEnabled = true;
            cmbInquilinoSeleccionado.Location = new Point(70, 66);
            cmbInquilinoSeleccionado.Name = "cmbInquilinoSeleccionado";
            cmbInquilinoSeleccionado.Size = new Size(492, 23);
            cmbInquilinoSeleccionado.TabIndex = 4;
            // 
            // lblInquilinoSeleccionado
            // 
            lblInquilinoSeleccionado.AutoSize = true;
            lblInquilinoSeleccionado.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblInquilinoSeleccionado.ForeColor = Color.Snow;
            lblInquilinoSeleccionado.Location = new Point(240, 19);
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
            pnlOpciones.Controls.Add(btnIngresarSaldo);
            pnlOpciones.Controls.Add(button4);
            pnlOpciones.Controls.Add(btnOpcionesEnPanel);
            pnlOpciones.Controls.Add(button3);
            pnlOpciones.Controls.Add(button2);
            pnlOpciones.Controls.Add(button1);
            pnlOpciones.Controls.Add(btnMostrarPagos);
            pnlOpciones.Controls.Add(btnMostrarDeudas);
            pnlOpciones.ForeColor = SystemColors.ButtonFace;
            pnlOpciones.Location = new Point(1, 1);
            pnlOpciones.Name = "pnlOpciones";
            pnlOpciones.Size = new Size(211, 604);
            pnlOpciones.TabIndex = 6;
            pnlOpciones.Visible = false;
            // 
            // btnIngresarSaldo
            // 
            btnIngresarSaldo.FlatStyle = FlatStyle.Flat;
            btnIngresarSaldo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresarSaldo.ForeColor = SystemColors.ButtonFace;
            btnIngresarSaldo.Location = new Point(-1, 83);
            btnIngresarSaldo.Name = "btnIngresarSaldo";
            btnIngresarSaldo.Size = new Size(211, 64);
            btnIngresarSaldo.TabIndex = 9;
            btnIngresarSaldo.Text = "INGRESAR SALDO";
            btnIngresarSaldo.UseVisualStyleBackColor = true;
            btnIngresarSaldo.Visible = false;
            btnIngresarSaldo.Click += btnIngresarSaldo_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(-1, 506);
            button4.Name = "button4";
            button4.Size = new Size(211, 64);
            button4.TabIndex = 8;
            button4.Text = "CERRAR SESIÓN";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnCerrarSesion_Click;
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
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(0, 433);
            button3.Name = "button3";
            button3.Size = new Size(211, 64);
            button3.TabIndex = 4;
            button3.Text = "HISTORIAL";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(0, 363);
            button2.Name = "button2";
            button2.Size = new Size(211, 64);
            button2.TabIndex = 3;
            button2.Text = "SERVICIOS";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(0, 293);
            button1.Name = "button1";
            button1.Size = new Size(211, 64);
            button1.TabIndex = 2;
            button1.Text = "MENSAJES";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnMostrarPagos
            // 
            btnMostrarPagos.FlatStyle = FlatStyle.Flat;
            btnMostrarPagos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMostrarPagos.ForeColor = SystemColors.ButtonFace;
            btnMostrarPagos.Location = new Point(0, 223);
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
            btnMostrarDeudas.Location = new Point(0, 153);
            btnMostrarDeudas.Name = "btnMostrarDeudas";
            btnMostrarDeudas.Size = new Size(211, 64);
            btnMostrarDeudas.TabIndex = 0;
            btnMostrarDeudas.Text = "DEUDAS";
            btnMostrarDeudas.UseVisualStyleBackColor = true;
            btnMostrarDeudas.Click += btnMostrarDeudas_Click;
            // 
            // btnPagarDeudaSeleccionada
            // 
            btnPagarDeudaSeleccionada.FlatStyle = FlatStyle.Flat;
            btnPagarDeudaSeleccionada.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagarDeudaSeleccionada.ForeColor = SystemColors.ButtonFace;
            btnPagarDeudaSeleccionada.Location = new Point(191, 360);
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
            btnPagarTotalDeudas.Location = new Point(437, 360);
            btnPagarTotalDeudas.Name = "btnPagarTotalDeudas";
            btnPagarTotalDeudas.Size = new Size(211, 64);
            btnPagarTotalDeudas.TabIndex = 8;
            btnPagarTotalDeudas.Text = "PAGAR TOTAL ";
            btnPagarTotalDeudas.UseVisualStyleBackColor = true;
            btnPagarTotalDeudas.Visible = false;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 595);
            Controls.Add(pnlOpciones);
            Controls.Add(grpPagos);
            Controls.Add(btnPagarTotalDeudas);
            Controls.Add(btnPagarDeudaSeleccionada);
            Controls.Add(grpDeudas);
            Controls.Add(btnOpciones);
            Controls.Add(grpInquilinoSeleccionado);
            Name = "FrmMenu";
            Text = "FrmMenu";
            Load += FrmMenu_Load;
            Controls.SetChildIndex(grpInquilinoSeleccionado, 0);
            Controls.SetChildIndex(btnOpciones, 0);
            Controls.SetChildIndex(grpDeudas, 0);
            Controls.SetChildIndex(btnPagarDeudaSeleccionada, 0);
            Controls.SetChildIndex(btnPagarTotalDeudas, 0);
            Controls.SetChildIndex(grpPagos, 0);
            Controls.SetChildIndex(pnlOpciones, 0);
            grpDeudas.ResumeLayout(false);
            grpDeudas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDeudas).EndInit();
            grpPagos.ResumeLayout(false);
            grpPagos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgPagos).EndInit();
            grpInquilinoSeleccionado.ResumeLayout(false);
            grpInquilinoSeleccionado.PerformLayout();
            pnlOpciones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDeudas;
        private DataGridView dtgDeudas;
        private Label lblDeudas;
        private NotifyIcon notifyIcon1;
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
        private Button button1;
        private Button btnMostrarPagos;
        private Button btnMostrarDeudas;
        private Button button3;
        private Button button2;
        private Button btnOpcionesEnPanel;
        private Button button4;
        private Button btnPagarDeudaSeleccionada;
        private Button btnPagarTotalDeudas;
        private Button btnIngresarSaldo;
    }
}