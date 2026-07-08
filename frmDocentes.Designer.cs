namespace prySistemaEscolar
{
    partial class frmDocentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocentes));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnNuevo = new Button();
            txtClaveDocente = new TextBox();
            dgvDocentes = new DataGridView();
            lblUsuario = new Label();
            pnlUsuario = new Panel();
            txtPassword = new TextBox();
            cmbPerfil = new ComboBox();
            txtUsuario = new TextBox();
            lblDocentes = new Label();
            pnlDocente = new Panel();
            cmbPuesto = new ComboBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            pcbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).BeginInit();
            pnlUsuario.SuspendLayout();
            pnlDocente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(505, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(207, 57);
            lblTitulo.TabIndex = 30;
            lblTitulo.Text = "Docentes";
            // 
            // btnGuardar
            // 
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(526, 439);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 68);
            btnGuardar.TabIndex = 28;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(682, 439);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 68);
            btnEliminar.TabIndex = 26;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ControlDark;
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.Location = new Point(369, 439);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(150, 68);
            btnNuevo.TabIndex = 25;
            btnNuevo.TextAlign = ContentAlignment.BottomCenter;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtClaveDocente
            // 
            txtClaveDocente.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtClaveDocente.Location = new Point(898, 468);
            txtClaveDocente.Margin = new Padding(3, 4, 3, 4);
            txtClaveDocente.Name = "txtClaveDocente";
            txtClaveDocente.PlaceholderText = "Buscar Docente";
            txtClaveDocente.Size = new Size(206, 42);
            txtClaveDocente.TabIndex = 29;
            txtClaveDocente.TextChanged += txtClaveDocente_TextChanged;
            // 
            // dgvDocentes
            // 
            dgvDocentes.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.PaleTurquoise;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDocentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDocentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvDocentes.DefaultCellStyle = dataGridViewCellStyle4;
            dgvDocentes.EnableHeadersVisualStyles = false;
            dgvDocentes.Location = new Point(259, 515);
            dgvDocentes.Margin = new Padding(3, 4, 3, 4);
            dgvDocentes.Name = "dgvDocentes";
            dgvDocentes.ReadOnly = true;
            dgvDocentes.RowHeadersWidth = 51;
            dgvDocentes.RowTemplate.Height = 35;
            dgvDocentes.Size = new Size(845, 187);
            dgvDocentes.TabIndex = 27;
            dgvDocentes.SelectionChanged += dgvDocentes_SelectionChanged;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(718, 101);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(102, 32);
            lblUsuario.TabIndex = 24;
            lblUsuario.Text = "Usuario";
            // 
            // pnlUsuario
            // 
            pnlUsuario.BackColor = SystemColors.ActiveCaption;
            pnlUsuario.BorderStyle = BorderStyle.Fixed3D;
            pnlUsuario.Controls.Add(txtPassword);
            pnlUsuario.Controls.Add(cmbPerfil);
            pnlUsuario.Controls.Add(txtUsuario);
            pnlUsuario.Location = new Point(718, 137);
            pnlUsuario.Margin = new Padding(3, 4, 3, 4);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(386, 293);
            pnlUsuario.TabIndex = 23;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtPassword.Location = new Point(25, 69);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(290, 39);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // cmbPerfil
            // 
            cmbPerfil.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Location = new Point(25, 121);
            cmbPerfil.Margin = new Padding(3, 4, 3, 4);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(290, 40);
            cmbPerfil.TabIndex = 10;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtUsuario.Location = new Point(25, 22);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(290, 39);
            txtUsuario.TabIndex = 10;
            // 
            // lblDocentes
            // 
            lblDocentes.AutoSize = true;
            lblDocentes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocentes.Location = new Point(260, 101);
            lblDocentes.Name = "lblDocentes";
            lblDocentes.Size = new Size(120, 32);
            lblDocentes.TabIndex = 22;
            lblDocentes.Text = "Docentes";
            // 
            // pnlDocente
            // 
            pnlDocente.BackColor = SystemColors.ActiveCaption;
            pnlDocente.BorderStyle = BorderStyle.Fixed3D;
            pnlDocente.Controls.Add(cmbPuesto);
            pnlDocente.Controls.Add(txtCorreo);
            pnlDocente.Controls.Add(txtTelefono);
            pnlDocente.Controls.Add(txtNombre);
            pnlDocente.Location = new Point(259, 139);
            pnlDocente.Margin = new Padding(3, 4, 3, 4);
            pnlDocente.Name = "pnlDocente";
            pnlDocente.Size = new Size(417, 292);
            pnlDocente.TabIndex = 21;
            // 
            // cmbPuesto
            // 
            cmbPuesto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            cmbPuesto.FormattingEnabled = true;
            cmbPuesto.Location = new Point(21, 166);
            cmbPuesto.Margin = new Padding(3, 4, 3, 4);
            cmbPuesto.Name = "cmbPuesto";
            cmbPuesto.Size = new Size(290, 40);
            cmbPuesto.TabIndex = 9;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtCorreo.Location = new Point(21, 119);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(290, 39);
            txtCorreo.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtTelefono.Location = new Point(21, 67);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(290, 39);
            txtTelefono.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtNombre.Location = new Point(21, 20);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(290, 39);
            txtNombre.TabIndex = 1;
            // 
            // pcbLogo
            // 
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(718, 4);
            pcbLogo.Margin = new Padding(3, 4, 3, 4);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(170, 92);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 31;
            pcbLogo.TabStop = false;
            // 
            // frmDocentes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 710);
            Controls.Add(lblTitulo);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(txtClaveDocente);
            Controls.Add(dgvDocentes);
            Controls.Add(lblUsuario);
            Controls.Add(pnlUsuario);
            Controls.Add(lblDocentes);
            Controls.Add(pnlDocente);
            Controls.Add(pcbLogo);
            Name = "frmDocentes";
            Text = "frmDocentes";
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).EndInit();
            pnlUsuario.ResumeLayout(false);
            pnlUsuario.PerformLayout();
            pnlDocente.ResumeLayout(false);
            pnlDocente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnNuevo;
        private TextBox txtClaveDocente;
        private DataGridView dgvDocentes;
        private Label lblUsuario;
        private Panel pnlUsuario;
        private TextBox txtPassword;
        private ComboBox cmbPerfil;
        private TextBox txtUsuario;
        private Label lblDocentes;
        private Panel pnlDocente;
        private ComboBox cmbPuesto;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private PictureBox pcbLogo;
    }
}