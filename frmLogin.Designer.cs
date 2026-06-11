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
            ptbLoginIcono = new PictureBox();
            btnAcceder = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbLoginFondo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbLoginIcono).BeginInit();
            SuspendLayout();
            // 
            // pcbLoginFondo
            // 
            pcbLoginFondo.Image = (Image)resources.GetObject("pcbLoginFondo.Image");
            pcbLoginFondo.Location = new Point(108, 85);
            pcbLoginFondo.Name = "pcbLoginFondo";
            pcbLoginFondo.Size = new Size(456, 500);
            pcbLoginFondo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLoginFondo.TabIndex = 0;
            pcbLoginFondo.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.Location = new Point(715, 143);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Nombre del usuario";
            txtUsuario.Size = new Size(238, 34);
            txtUsuario.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(715, 205);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña del usuario";
            txtPassword.Size = new Size(238, 34);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // ptbLoginIcono
            // 
            ptbLoginIcono.Image = (Image)resources.GetObject("ptbLoginIcono.Image");
            ptbLoginIcono.Location = new Point(1064, 91);
            ptbLoginIcono.Name = "ptbLoginIcono";
            ptbLoginIcono.Size = new Size(229, 212);
            ptbLoginIcono.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbLoginIcono.TabIndex = 3;
            ptbLoginIcono.TabStop = false;
            // 
            // btnAcceder
            // 
            btnAcceder.Font = new Font("Segoe UI", 12F);
            btnAcceder.Location = new Point(715, 262);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(105, 41);
            btnAcceder.TabIndex = 4;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 12F);
            btnSalir.Location = new Point(848, 262);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(105, 41);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 991);
            Controls.Add(btnSalir);
            Controls.Add(btnAcceder);
            Controls.Add(ptbLoginIcono);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(pcbLoginFondo);
            Name = "frmLogin";
            Text = "Control de acceso";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pcbLoginFondo).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbLoginIcono).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbLoginFondo;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private PictureBox ptbLoginIcono;
        private Button btnAcceder;
        private Button btnSalir;
    }
}
