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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            grpDeudas = new GroupBox();
            lblDeudas = new Label();
            dtgDeudas = new DataGridView();
            grpMensajes = new GroupBox();
            lblMensajes = new Label();
            dtgMensajes = new DataGridView();
            Propuesta = new DataGridViewTextBoxColumn();
            ColumnaFavor = new DataGridViewCheckBoxColumn();
            ColumnaContra = new DataGridViewCheckBoxColumn();
            notifyIcon1 = new NotifyIcon(components);
            grpPagos = new GroupBox();
            lblPagos = new Label();
            dtgPagos = new DataGridView();
            fechaAbonoPagos = new DataGridViewTextBoxColumn();
            cantidadAbonadaPagos = new DataGridViewTextBoxColumn();
            fechaVencimientoPagos = new DataGridViewTextBoxColumn();
            inquilino = new DataGridViewComboBoxColumn();
            fechaEmisionDeudas = new DataGridViewTextBoxColumn();
            cantidadAbonarDeudas = new DataGridViewTextBoxColumn();
            FechaVencimiento = new DataGridViewTextBoxColumn();
            grpDeudas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDeudas).BeginInit();
            grpMensajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMensajes).BeginInit();
            grpPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgPagos).BeginInit();
            SuspendLayout();
            // 
            // grpDeudas
            // 
            grpDeudas.Controls.Add(lblDeudas);
            grpDeudas.Controls.Add(dtgDeudas);
            grpDeudas.Location = new Point(92, 215);
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
            // grpMensajes
            // 
            grpMensajes.Controls.Add(lblMensajes);
            grpMensajes.Controls.Add(dtgMensajes);
            grpMensajes.Location = new Point(92, 36);
            grpMensajes.Name = "grpMensajes";
            grpMensajes.Size = new Size(611, 162);
            grpMensajes.TabIndex = 2;
            grpMensajes.TabStop = false;
            // 
            // lblMensajes
            // 
            lblMensajes.AutoSize = true;
            lblMensajes.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblMensajes.ForeColor = Color.Snow;
            lblMensajes.Location = new Point(240, 12);
            lblMensajes.Name = "lblMensajes";
            lblMensajes.Size = new Size(137, 32);
            lblMensajes.TabIndex = 3;
            lblMensajes.Text = "MENSAJES";
            lblMensajes.TextAlign = ContentAlignment.TopCenter;
            // 
            // dtgMensajes
            // 
            dtgMensajes.AllowUserToAddRows = false;
            dtgMensajes.AllowUserToDeleteRows = false;
            dtgMensajes.AllowUserToResizeColumns = false;
            dtgMensajes.AllowUserToResizeRows = false;
            dtgMensajes.BackgroundColor = Color.FromArgb(255, 192, 192);
            dtgMensajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMensajes.Columns.AddRange(new DataGridViewColumn[] { Propuesta, ColumnaFavor, ColumnaContra });
            dtgMensajes.GridColor = Color.Black;
            dtgMensajes.Location = new Point(25, 47);
            dtgMensajes.Name = "dtgMensajes";
            dtgMensajes.ReadOnly = true;
            dtgMensajes.RowTemplate.Height = 25;
            dtgMensajes.Size = new Size(560, 103);
            dtgMensajes.TabIndex = 2;
            // 
            // Propuesta
            // 
            Propuesta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Propuesta.HeaderText = "Propuesta";
            Propuesta.Name = "Propuesta";
            Propuesta.ReadOnly = true;
            Propuesta.Resizable = DataGridViewTriState.True;
            // 
            // ColumnaFavor
            // 
            ColumnaFavor.HeaderText = "Favor";
            ColumnaFavor.Name = "ColumnaFavor";
            ColumnaFavor.ReadOnly = true;
            ColumnaFavor.Resizable = DataGridViewTriState.True;
            ColumnaFavor.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnaContra
            // 
            ColumnaContra.HeaderText = "Contra";
            ColumnaContra.Name = "ColumnaContra";
            ColumnaContra.ReadOnly = true;
            ColumnaContra.Resizable = DataGridViewTriState.True;
            ColumnaContra.SortMode = DataGridViewColumnSortMode.Automatic;
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
            grpPagos.Location = new Point(92, 418);
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
            dataGridViewCellStyle2.BackColor = Color.Salmon;
            fechaAbonoPagos.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle1.BackColor = Color.Salmon;
            fechaEmisionDeudas.DefaultCellStyle = dataGridViewCellStyle1;
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
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 788);
            Controls.Add(grpPagos);
            Controls.Add(grpMensajes);
            Controls.Add(grpDeudas);
            Name = "FrmMenu";
            Text = "FrmMenu";
            Load += FrmMenu_Load;
            Controls.SetChildIndex(grpDeudas, 0);
            Controls.SetChildIndex(grpMensajes, 0);
            Controls.SetChildIndex(grpPagos, 0);
            grpDeudas.ResumeLayout(false);
            grpDeudas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDeudas).EndInit();
            grpMensajes.ResumeLayout(false);
            grpMensajes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMensajes).EndInit();
            grpPagos.ResumeLayout(false);
            grpPagos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgPagos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDeudas;
        private GroupBox grpMensajes;
        private DataGridView dtgDeudas;
        private Label lblDeudas;
        private NotifyIcon notifyIcon1;
        private Label lblMensajes;
        private DataGridView dtgMensajes;
        private GroupBox grpPagos;
        private Label lblPagos;
        private DataGridView dtgPagos;
        private DataGridViewTextBoxColumn Propuesta;
        private DataGridViewCheckBoxColumn ColumnaFavor;
        private DataGridViewCheckBoxColumn ColumnaContra;
        private DataGridViewTextBoxColumn fechaAbonoPagos;
        private DataGridViewTextBoxColumn cantidadAbonadaPagos;
        private DataGridViewTextBoxColumn fechaVencimientoPagos;
        private DataGridViewComboBoxColumn inquilino;
        private DataGridViewTextBoxColumn fechaEmisionDeudas;
        private DataGridViewTextBoxColumn cantidadAbonarDeudas;
        private DataGridViewTextBoxColumn FechaVencimiento;
    }
}