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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            grpDeudas = new GroupBox();
            lblDeudas = new Label();
            dtgDeudas = new DataGridView();
            ColumnaUno = new DataGridViewTextBoxColumn();
            ColumnaDos = new DataGridViewTextBoxColumn();
            ColumnaTres = new DataGridViewTextBoxColumn();
            grpMensajes = new GroupBox();
            lblMensajes = new Label();
            dtgMensajes = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            ColumnUno = new DataGridViewCheckBoxColumn();
            Columna2 = new DataGridViewCheckBoxColumn();
            notifyIcon1 = new NotifyIcon(components);
            grpPagos = new GroupBox();
            lblPagos = new Label();
            dtgPagos = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
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
            dtgDeudas.Columns.AddRange(new DataGridViewColumn[] { ColumnaUno, ColumnaDos, ColumnaTres });
            dtgDeudas.GridColor = Color.Black;
            dtgDeudas.Location = new Point(26, 54);
            dtgDeudas.Name = "dtgDeudas";
            dtgDeudas.ReadOnly = true;
            dtgDeudas.RowTemplate.Height = 25;
            dtgDeudas.Size = new Size(560, 103);
            dtgDeudas.TabIndex = 0;
            // 
            // ColumnaUno
            // 
            ColumnaUno.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.BackColor = Color.Salmon;
            ColumnaUno.DefaultCellStyle = dataGridViewCellStyle5;
            ColumnaUno.HeaderText = "Fecha de emisión";
            ColumnaUno.Name = "ColumnaUno";
            ColumnaUno.ReadOnly = true;
            ColumnaUno.Resizable = DataGridViewTriState.True;
            // 
            // ColumnaDos
            // 
            ColumnaDos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaDos.HeaderText = "Cantidad a abonar";
            ColumnaDos.Name = "ColumnaDos";
            ColumnaDos.ReadOnly = true;
            // 
            // ColumnaTres
            // 
            ColumnaTres.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaTres.HeaderText = "Fecha de vencimiento";
            ColumnaTres.Name = "ColumnaTres";
            ColumnaTres.ReadOnly = true;
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
            dtgMensajes.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, ColumnUno, Columna2 });
            dtgMensajes.GridColor = Color.Black;
            dtgMensajes.Location = new Point(25, 47);
            dtgMensajes.Name = "dtgMensajes";
            dtgMensajes.ReadOnly = true;
            dtgMensajes.RowTemplate.Height = 25;
            dtgMensajes.Size = new Size(560, 103);
            dtgMensajes.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Propuesta";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Resizable = DataGridViewTriState.True;
            // 
            // ColumnUno
            // 
            ColumnUno.HeaderText = "Favor";
            ColumnUno.Name = "ColumnUno";
            ColumnUno.ReadOnly = true;
            ColumnUno.Resizable = DataGridViewTriState.True;
            ColumnUno.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Columna2
            // 
            Columna2.HeaderText = "Contra";
            Columna2.Name = "Columna2";
            Columna2.ReadOnly = true;
            Columna2.Resizable = DataGridViewTriState.True;
            Columna2.SortMode = DataGridViewColumnSortMode.Automatic;
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
            dtgPagos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn4 });
            dtgPagos.GridColor = Color.Black;
            dtgPagos.Location = new Point(22, 59);
            dtgPagos.Name = "dtgPagos";
            dtgPagos.ReadOnly = true;
            dtgPagos.RowTemplate.Height = 25;
            dtgPagos.Size = new Size(560, 103);
            dtgPagos.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.BackColor = Color.Salmon;
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewTextBoxColumn1.HeaderText = "Fecha de abono";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Cantidad a abonada";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.HeaderText = "Fecha de vencimiento";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // FrmMenuInquilino
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 788);
            Controls.Add(grpPagos);
            Controls.Add(grpMensajes);
            Controls.Add(grpDeudas);
            Name = "FrmMenuInquilino";
            Text = "FrmMenuInquilino";
            Load += FrmMenuInquilino_Load;
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
        private DataGridViewTextBoxColumn ColumnaUno;
        private DataGridViewTextBoxColumn ColumnaDos;
        private DataGridViewTextBoxColumn ColumnaTres;
        private NotifyIcon notifyIcon1;
        private Label lblMensajes;
        private DataGridView dtgMensajes;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewCheckBoxColumn ColumnUno;
        private DataGridViewCheckBoxColumn Columna2;
        private GroupBox grpPagos;
        private Label lblPagos;
        private DataGridView dtgPagos;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}