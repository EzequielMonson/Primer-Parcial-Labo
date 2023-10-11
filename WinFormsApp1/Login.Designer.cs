using NestApp;
using System.Windows.Forms;

namespace UI
{
    partial class Login
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
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            txtContrasenia = new TextBox();
            lblContrasenia = new Label();
            grpDatos = new GroupBox();
            button1 = new Button();
            btnInicioSesion = new Button();
            btnAtras = new Button();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // txtCorreo
            // 
            txtCorreo.ForeColor = SystemColors.ActiveCaptionText;
            txtCorreo.Location = new Point(192, 49);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(197, 23);
            txtCorreo.TabIndex = 18;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreo.Location = new Point(13, 44);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(173, 25);
            lblCorreo.TabIndex = 21;
            lblCorreo.Text = "Correo Electronico:";
            lblCorreo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(192, 103);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(197, 23);
            txtContrasenia.TabIndex = 19;
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblContrasenia.Location = new Point(13, 103);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(112, 25);
            lblContrasenia.TabIndex = 22;
            lblContrasenia.Text = "Contraseña:";
            // 
            // grpDatos
            // 
            grpDatos.BackColor = Color.FromArgb(255, 128, 128);
            grpDatos.Controls.Add(button1);
            grpDatos.Controls.Add(lblCorreo);
            grpDatos.Controls.Add(lblContrasenia);
            grpDatos.Controls.Add(txtContrasenia);
            grpDatos.Controls.Add(txtCorreo);
            grpDatos.Location = new Point(172, 102);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(445, 158);
            grpDatos.TabIndex = 27;
            grpDatos.TabStop = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(395, 103);
            button1.Name = "button1";
            button1.Size = new Size(29, 25);
            button1.TabIndex = 23;
            button1.Text = "👁";
            button1.UseVisualStyleBackColor = true;
            button1.MouseDown += MostrarContrasenia;
            button1.MouseLeave += OcultarContrasenia;
            button1.MouseHover += OcultarContrasenia;
            // 
            // btnInicioSesion
            // 
            btnInicioSesion.FlatStyle = FlatStyle.Popup;
            btnInicioSesion.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicioSesion.Location = new Point(280, 333);
            btnInicioSesion.Name = "btnInicioSesion";
            btnInicioSesion.Size = new Size(216, 55);
            btnInicioSesion.TabIndex = 28;
            btnInicioSesion.Text = "Iniciar Sesion";
            btnInicioSesion.UseVisualStyleBackColor = true;
            btnInicioSesion.Click += BtnIniciarSesion_Click;
            // 
            // btnAtras
            // 
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtras.ImageAlign = ContentAlignment.TopRight;
            btnAtras.Location = new Point(12, 12);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(30, 30);
            btnAtras.TabIndex = 29;
            btnAtras.Text = "🢀";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += VolverAtras;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtras);
            Controls.Add(btnInicioSesion);
            Controls.Add(grpDatos);
            Name = "Login";
            Text = "Form1";
            Load += BtnIniciarSesion_Click;
            Controls.SetChildIndex(grpDatos, 0);
            Controls.SetChildIndex(btnInicioSesion, 0);
            Controls.SetChildIndex(btnAtras, 0);
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtCorreo;
        private Label lblCorreo;
        private TextBox txtContrasenia;
        private Label lblContrasenia;
        private GroupBox grpDatos;
        private Button btnInicioSesion;
        private Button button1;
        private Button btnAtras;
    }
}