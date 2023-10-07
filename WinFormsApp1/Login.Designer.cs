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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            btnCerrar = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.Red;
            btnCerrar.Location = new Point(765, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(23, 23);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(192, 49);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(197, 23);
            textBox3.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 44);
            label4.Name = "label4";
            label4.Size = new Size(173, 25);
            label4.TabIndex = 21;
            label4.Text = "Correo Electronico:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(192, 103);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(197, 23);
            textBox6.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(13, 103);
            label6.Name = "label6";
            label6.Size = new Size(112, 25);
            label6.TabIndex = 22;
            label6.Text = "Contraseña:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Location = new Point(172, 102);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(445, 158);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(280, 333);
            button1.Name = "button1";
            button1.Size = new Size(216, 55);
            button1.TabIndex = 28;
            button1.Text = "Iniciar Sesion";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            Text = "Form1";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCerrar;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox6;
        private Label label6;
        private GroupBox groupBox2;
        private Button button1;
    }
}