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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            grpDeudas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDeudas).BeginInit();
            grpPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgPagos).BeginInit();
            grpInquilinoSeleccionado.SuspendLayout();
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
            dataGridViewCellStyle3.BackColor = Color.Salmon;
            fechaEmisionDeudas.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.BackColor = Color.Salmon;
            fechaAbonoPagos.DefaultCellStyle = dataGridViewCellStyle4;
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
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 788);
            Controls.Add(grpInquilinoSeleccionado);
            Controls.Add(grpPagos);
            Controls.Add(grpDeudas);
            Name = "FrmMenu";
            Text = "FrmMenu";
            Load += FrmMenu_Load;
            Controls.SetChildIndex(grpDeudas, 0);
            Controls.SetChildIndex(grpPagos, 0);
            Controls.SetChildIndex(grpInquilinoSeleccionado, 0);
            grpDeudas.ResumeLayout(false);
            grpDeudas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDeudas).EndInit();
            grpPagos.ResumeLayout(false);
            grpPagos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgPagos).EndInit();
            grpInquilinoSeleccionado.ResumeLayout(false);
            grpInquilinoSeleccionado.PerformLayout();
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
        private DataGridViewComboBoxColumn inquilino;
        private DataGridViewTextBoxColumn fechaEmisionDeudas;
        private DataGridViewTextBoxColumn cantidadAbonarDeudas;
        private DataGridViewTextBoxColumn FechaVencimiento;
        private GroupBox grpInquilinoSeleccionado;
        internal ComboBox cmbInquilinoSeleccionado;
        private Label lblInquilinoSeleccionado;
    }
}