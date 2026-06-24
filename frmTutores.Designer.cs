namespace prySistemaEscolar
{
    partial class frmTutores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTutores));
            lblTitulo = new Label();
            pcbLogo = new PictureBox();
            pnlAgrupaControles = new Panel();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnNuevo = new Button();
            txtParentesco = new TextBox();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtCorreo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            pnlAgrupaControles.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(334, 46);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(136, 45);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Tutores";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // pcbLogo
            // 
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(476, 6);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(125, 85);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 3;
            pcbLogo.TabStop = false;
            // 
            // pnlAgrupaControles
            // 
            pnlAgrupaControles.Controls.Add(txtCorreo);
            pnlAgrupaControles.Controls.Add(txtTelefono);
            pnlAgrupaControles.Controls.Add(txtDireccion);
            pnlAgrupaControles.Controls.Add(btnGuardar);
            pnlAgrupaControles.Controls.Add(btnEliminar);
            pnlAgrupaControles.Controls.Add(btnNuevo);
            pnlAgrupaControles.Controls.Add(txtParentesco);
            pnlAgrupaControles.Controls.Add(txtNombre);
            pnlAgrupaControles.Location = new Point(164, 97);
            pnlAgrupaControles.Name = "pnlAgrupaControles";
            pnlAgrupaControles.Size = new Size(739, 324);
            pnlAgrupaControles.TabIndex = 4;
            pnlAgrupaControles.Paint += pnlAgrupaControles_Paint;
            // 
            // btnGuardar
            // 
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(306, 270);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 51);
            btnGuardar.TabIndex = 4;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(515, 270);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(138, 51);
            btnEliminar.TabIndex = 3;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ControlDark;
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.Location = new Point(84, 270);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(131, 51);
            btnNuevo.TabIndex = 2;
            btnNuevo.TextAlign = ContentAlignment.BottomCenter;
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // txtParentesco
            // 
            txtParentesco.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtParentesco.Location = new Point(84, 77);
            txtParentesco.Name = "txtParentesco";
            txtParentesco.PlaceholderText = "Escribir el parentesco del tutor";
            txtParentesco.Size = new Size(569, 35);
            txtParentesco.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(84, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Escribir el nombre del tutor ";
            txtNombre.Size = new Size(569, 35);
            txtNombre.TabIndex = 0;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(84, 159);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Escribir el telefono del tutor";
            txtTelefono.Size = new Size(569, 35);
            txtTelefono.TabIndex = 6;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(84, 118);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Escribir la direccion del tutor";
            txtDireccion.Size = new Size(569, 35);
            txtDireccion.TabIndex = 5;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(84, 200);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Escribir el correo del tutor";
            txtCorreo.Size = new Size(569, 35);
            txtCorreo.TabIndex = 7;
            // 
            // frmTutores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 544);
            Controls.Add(pnlAgrupaControles);
            Controls.Add(pcbLogo);
            Controls.Add(lblTitulo);
            Name = "frmTutores";
            Text = "frmTutores";
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            pnlAgrupaControles.ResumeLayout(false);
            pnlAgrupaControles.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private PictureBox pcbLogo;
        private Panel pnlAgrupaControles;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnNuevo;
        private TextBox txtParentesco;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtCorreo;
    }
}