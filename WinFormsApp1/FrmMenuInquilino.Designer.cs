namespace UI
{
    partial class FrmMenuInquilino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuInquilino));
            groupBox1 = new GroupBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ColumnaUno = new DataGridViewTextBoxColumn();
            ColumnaDos = new DataGridViewTextBoxColumn();
            ColumnaTres = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            notifyIcon1 = new NotifyIcon(components);
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            ColumnUno = new DataGridViewCheckBoxColumn();
            Columna2 = new DataGridViewCheckBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(92, 215);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(611, 184);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(255, 19);
            label1.Name = "label1";
            label1.Size = new Size(110, 32);
            label1.TabIndex = 1;
            label1.Text = "DEUDAS";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 192, 192);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnaUno, ColumnaDos, ColumnaTres });
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(26, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(560, 103);
            dataGridView1.TabIndex = 0;
            // 
            // ColumnaUno
            // 
            ColumnaUno.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = Color.Salmon;
            ColumnaUno.DefaultCellStyle = dataGridViewCellStyle3;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Location = new Point(92, 36);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(611, 162);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(240, 12);
            label2.Name = "label2";
            label2.Size = new Size(137, 32);
            label2.TabIndex = 3;
            label2.Text = "MENSAJES";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.BackgroundColor = Color.FromArgb(255, 192, 192);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, ColumnUno, Columna2 });
            dataGridView2.GridColor = Color.Black;
            dataGridView2.Location = new Point(25, 47);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(560, 103);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
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
            // FrmMenuInquilino
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmMenuInquilino";
            Text = "FrmMenuInquilino";
            Load += FrmMenuInquilino_Load;
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(groupBox2, 0);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label label1;
        private DataGridViewTextBoxColumn ColumnaUno;
        private DataGridViewTextBoxColumn ColumnaDos;
        private DataGridViewTextBoxColumn ColumnaTres;
        private NotifyIcon notifyIcon1;
        private Label label2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewCheckBoxColumn ColumnUno;
        private DataGridViewCheckBoxColumn Columna2;
    }
}