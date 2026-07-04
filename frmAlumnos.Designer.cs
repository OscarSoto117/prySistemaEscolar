namespace prySistemaEscolar
{
    partial class frmAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumnos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtMatricula = new TextBox();
            txtNombre = new TextBox();
            txtAPaterno = new TextBox();
            txtAMaterno = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtPromedioBachiller = new TextBox();
            cmbTutor = new ComboBox();
            cmbCarrera = new ComboBox();
            pnlAlumno = new Panel();
            lblAlumos = new Label();
            pnlUsuario = new Panel();
            txtPassword = new TextBox();
            cmbPerfil = new ComboBox();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnNuevo = new Button();
            txtMatriculaAlumno = new TextBox();
            dgvAlumnos = new DataGridView();
            pcbLogo = new PictureBox();
            lblTitulo = new Label();
            pnlAlumno.SuspendLayout();
            pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            SuspendLayout();
            // 
            // txtMatricula
            // 
            txtMatricula.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtMatricula.Location = new Point(18, 15);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "Matricula";
            txtMatricula.Size = new Size(232, 33);
            txtMatricula.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtNombre.Location = new Point(18, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(232, 33);
            txtNombre.TabIndex = 1;
            // 
            // txtAPaterno
            // 
            txtAPaterno.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtAPaterno.Location = new Point(18, 93);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.PlaceholderText = "Apellido Paterno";
            txtAPaterno.Size = new Size(232, 33);
            txtAPaterno.TabIndex = 2;
            // 
            // txtAMaterno
            // 
            txtAMaterno.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtAMaterno.Location = new Point(18, 132);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.PlaceholderText = "Apellido Materno";
            txtAMaterno.Size = new Size(232, 33);
            txtAMaterno.TabIndex = 3;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtDireccion.Location = new Point(18, 171);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Direccion";
            txtDireccion.Size = new Size(232, 33);
            txtDireccion.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtTelefono.Location = new Point(293, 15);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(232, 33);
            txtTelefono.TabIndex = 5;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtCorreo.Location = new Point(293, 54);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(232, 33);
            txtCorreo.TabIndex = 6;
            // 
            // txtPromedioBachiller
            // 
            txtPromedioBachiller.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtPromedioBachiller.Location = new Point(293, 93);
            txtPromedioBachiller.Name = "txtPromedioBachiller";
            txtPromedioBachiller.PlaceholderText = "Promedio Bachillerato";
            txtPromedioBachiller.Size = new Size(232, 33);
            txtPromedioBachiller.TabIndex = 7;
            // 
            // cmbTutor
            // 
            cmbTutor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            cmbTutor.FormattingEnabled = true;
            cmbTutor.Location = new Point(293, 132);
            cmbTutor.Name = "cmbTutor";
            cmbTutor.Size = new Size(230, 33);
            cmbTutor.TabIndex = 8;
            // 
            // cmbCarrera
            // 
            cmbCarrera.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(293, 171);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(230, 33);
            cmbCarrera.TabIndex = 9;
            // 
            // pnlAlumno
            // 
            pnlAlumno.BackColor = SystemColors.ActiveCaption;
            pnlAlumno.BorderStyle = BorderStyle.Fixed3D;
            pnlAlumno.Controls.Add(txtMatricula);
            pnlAlumno.Controls.Add(cmbCarrera);
            pnlAlumno.Controls.Add(txtCorreo);
            pnlAlumno.Controls.Add(cmbTutor);
            pnlAlumno.Controls.Add(txtPromedioBachiller);
            pnlAlumno.Controls.Add(txtTelefono);
            pnlAlumno.Controls.Add(txtNombre);
            pnlAlumno.Controls.Add(txtDireccion);
            pnlAlumno.Controls.Add(txtAPaterno);
            pnlAlumno.Controls.Add(txtAMaterno);
            pnlAlumno.Location = new Point(89, 110);
            pnlAlumno.Name = "pnlAlumno";
            pnlAlumno.Size = new Size(553, 220);
            pnlAlumno.TabIndex = 10;
            // 
            // lblAlumos
            // 
            lblAlumos.AutoSize = true;
            lblAlumos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlumos.Location = new Point(89, 82);
            lblAlumos.Name = "lblAlumos";
            lblAlumos.Size = new Size(91, 25);
            lblAlumos.TabIndex = 11;
            lblAlumos.Text = "Alumnos";
            // 
            // pnlUsuario
            // 
            pnlUsuario.BackColor = SystemColors.ActiveCaption;
            pnlUsuario.BorderStyle = BorderStyle.Fixed3D;
            pnlUsuario.Controls.Add(txtPassword);
            pnlUsuario.Controls.Add(cmbPerfil);
            pnlUsuario.Controls.Add(txtUsuario);
            pnlUsuario.Location = new Point(694, 109);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(272, 221);
            pnlUsuario.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtPassword.Location = new Point(22, 55);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(232, 33);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // cmbPerfil
            // 
            cmbPerfil.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Items.AddRange(new object[] { "Administrador", "Alumno", "Docente", "Tutor" });
            cmbPerfil.Location = new Point(22, 94);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(230, 33);
            cmbPerfil.TabIndex = 10;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtUsuario.Location = new Point(22, 16);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(232, 33);
            txtUsuario.TabIndex = 10;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(694, 81);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(81, 25);
            lblUsuario.TabIndex = 13;
            lblUsuario.Text = "Usuario";
            // 
            // btnGuardar
            // 
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(402, 335);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 51);
            btnGuardar.TabIndex = 17;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(539, 335);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(138, 51);
            btnEliminar.TabIndex = 15;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ControlDark;
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.Location = new Point(265, 335);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(131, 51);
            btnNuevo.TabIndex = 14;
            btnNuevo.TextAlign = ContentAlignment.BottomCenter;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtMatriculaAlumno
            // 
            txtMatriculaAlumno.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMatriculaAlumno.Location = new Point(735, 357);
            txtMatriculaAlumno.Name = "txtMatriculaAlumno";
            txtMatriculaAlumno.PlaceholderText = "Buscar Alumno";
            txtMatriculaAlumno.Size = new Size(173, 35);
            txtMatriculaAlumno.TabIndex = 18;
            txtMatriculaAlumno.TextChanged += txtBuscarAlumno_TextChanged;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAlumnos.EnableHeadersVisualStyles = false;
            dgvAlumnos.Location = new Point(169, 392);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.RowTemplate.Height = 35;
            dgvAlumnos.Size = new Size(739, 140);
            dgvAlumnos.TabIndex = 16;
            dgvAlumnos.SelectionChanged += dgvAlumnos_SelectionChanged;
            // 
            // pcbLogo
            // 
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(539, 12);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(149, 69);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 20;
            pcbLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(384, 36);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(157, 45);
            lblTitulo.TabIndex = 19;
            lblTitulo.Text = "Alumnos";
            // 
            // frmAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 544);
            Controls.Add(lblTitulo);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(txtMatriculaAlumno);
            Controls.Add(dgvAlumnos);
            Controls.Add(lblUsuario);
            Controls.Add(pnlUsuario);
            Controls.Add(lblAlumos);
            Controls.Add(pnlAlumno);
            Controls.Add(pcbLogo);
            Name = "frmAlumnos";
            Text = "frmAlumnos";
            pnlAlumno.ResumeLayout(false);
            pnlAlumno.PerformLayout();
            pnlUsuario.ResumeLayout(false);
            pnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMatricula;
        private TextBox txtNombre;
        private TextBox txtAPaterno;
        private TextBox txtAMaterno;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtPromedioBachiller;
        private ComboBox cmbTutor;
        private ComboBox cmbCarrera;
        private Panel pnlAlumno;
        private Label lblAlumos;
        private Panel pnlUsuario;
        private TextBox txtPassword;
        private ComboBox cmbPerfil;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnNuevo;
        private TextBox txtMatriculaAlumno;
        private DataGridView dgvAlumnos;
        private PictureBox pcbLogo;
        private Label lblTitulo;
    }
}