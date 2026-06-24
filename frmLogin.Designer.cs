namespace prySistemaEscolar
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pcbLoginFondo = new PictureBox();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnAcceder = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbLoginFondo).BeginInit();
            SuspendLayout();
            // 
            // pcbLoginFondo
            // 
            pcbLoginFondo.Image = (Image)resources.GetObject("pcbLoginFondo.Image");
            pcbLoginFondo.Location = new Point(47, 40);
            pcbLoginFondo.Name = "pcbLoginFondo";
            pcbLoginFondo.Size = new Size(416, 363);
            pcbLoginFondo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLoginFondo.TabIndex = 0;
            pcbLoginFondo.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            txtUsuario.Location = new Point(513, 128);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Nombre del usuario";
            txtUsuario.Size = new Size(441, 61);
            txtUsuario.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            txtPassword.Location = new Point(513, 199);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña del usuario";
            txtPassword.Size = new Size(441, 61);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnAcceder
            // 
            btnAcceder.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            btnAcceder.Location = new Point(513, 291);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(185, 57);
            btnAcceder.TabIndex = 4;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            btnSalir.Location = new Point(769, 291);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(185, 57);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 491);
            Controls.Add(btnSalir);
            Controls.Add(btnAcceder);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(pcbLoginFondo);
            Name = "frmLogin";
            Text = "Control de acceso";
            WindowState = FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)pcbLoginFondo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbLoginFondo;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnAcceder;
        private Button btnSalir;
    }
}
