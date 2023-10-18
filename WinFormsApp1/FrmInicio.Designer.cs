namespace NestApp
{
    partial class FrmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            btnInicioSesion = new Button();
            pictureBox1 = new PictureBox();
            btnRegistrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnInicioSesion
            // 
            btnInicioSesion.FlatStyle = FlatStyle.Popup;
            btnInicioSesion.Location = new Point(285, 297);
            btnInicioSesion.Name = "btnInicioSesion";
            btnInicioSesion.Size = new Size(218, 23);
            btnInicioSesion.TabIndex = 0;
            btnInicioSesion.Text = "Inicia Sesión";
            btnInicioSesion.UseVisualStyleBackColor = true;
            btnInicioSesion.Click += BtnIniciarSesion_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(285, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 92);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Location = new Point(285, 338);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(218, 23);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrarte";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += BtnRegistrar_Click;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrar);
            Controls.Add(btnInicioSesion);
            Controls.Add(pictureBox1);
            Name = "FrmInicio";
            Text = "NestApp";
            Load += FrmMain_Load;
            Controls.SetChildIndex(pictureBox1, 0);
            Controls.SetChildIndex(btnInicioSesion, 0);
            Controls.SetChildIndex(btnRegistrar, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private Button btnInicioSesion;
        private PictureBox pictureBox1;
        private Button btnRegistrar;
    }
}