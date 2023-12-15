namespace UI
{
    partial class FrmMensajes : Formulario
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
            txtMensaje = new TextBox();
            btnEnviar = new Button();
            panel1 = new Panel();
            lstContactos = new ListBox();
            rtbChat = new RichTextBox();
            lblInquilino = new Label();
            btnAtras = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtMensaje
            // 
            txtMensaje.BackColor = Color.White;
            txtMensaje.ForeColor = Color.Black;
            txtMensaje.Location = new Point(216, 377);
            txtMensaje.Multiline = true;
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(502, 61);
            txtMensaje.TabIndex = 1;
            txtMensaje.Visible = false;
            // 
            // btnEnviar
            // 
            btnEnviar.FlatStyle = FlatStyle.Popup;
            btnEnviar.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnviar.ForeColor = SystemColors.ButtonFace;
            btnEnviar.Location = new Point(724, 377);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(64, 61);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "▶";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Visible = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 108, 108);
            panel1.Controls.Add(lstContactos);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 451);
            panel1.TabIndex = 3;
            // 
            // lstContactos
            // 
            lstContactos.BackColor = Color.FromArgb(255, 128, 128);
            lstContactos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lstContactos.ForeColor = Color.WhiteSmoke;
            lstContactos.FormattingEnabled = true;
            lstContactos.ItemHeight = 21;
            lstContactos.Location = new Point(14, 17);
            lstContactos.Name = "lstContactos";
            lstContactos.Size = new Size(161, 424);
            lstContactos.TabIndex = 0;
            // 
            // rtbChat
            // 
            rtbChat.Location = new Point(216, 61);
            rtbChat.Name = "rtbChat";
            rtbChat.ReadOnly = true;
            rtbChat.Size = new Size(572, 310);
            rtbChat.TabIndex = 5;
            rtbChat.Text = "";
            rtbChat.Visible = false;
            // 
            // lblInquilino
            // 
            lblInquilino.AutoSize = true;
            lblInquilino.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInquilino.ForeColor = SystemColors.ControlLightLight;
            lblInquilino.Location = new Point(239, 23);
            lblInquilino.Name = "lblInquilino";
            lblInquilino.Size = new Size(95, 21);
            lblInquilino.TabIndex = 6;
            lblInquilino.Text = "INQUILINO";
            // 
            // btnAtras
            // 
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtras.ImageAlign = ContentAlignment.TopRight;
            btnAtras.Location = new Point(724, 12);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(30, 30);
            btnAtras.TabIndex = 30;
            btnAtras.Text = "🢀";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // FrmMensajes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtras);
            Controls.Add(lblInquilino);
            Controls.Add(rtbChat);
            Controls.Add(panel1);
            Controls.Add(btnEnviar);
            Controls.Add(txtMensaje);
            Name = "FrmMensajes";
            Load += FrmMensajes_Load;
            Controls.SetChildIndex(txtMensaje, 0);
            Controls.SetChildIndex(btnEnviar, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(rtbChat, 0);
            Controls.SetChildIndex(lblInquilino, 0);
            Controls.SetChildIndex(btnAtras, 0);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMensaje;
        private Button btnEnviar;
        private Panel panel1;
        private ListBox lstContactos;
        private RichTextBox rtbChat;
        private Label lblInquilino;
        private Button btnAtras;
    }
}