﻿namespace UI
{
    partial class frmLogin
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
            btnCerrar = new Button();
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
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCerrar;
    }
}