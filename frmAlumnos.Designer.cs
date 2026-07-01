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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            txtMatricula = new TextBox();
            txtNombre = new TextBox();
            APaterno = new TextBox();
            AMaterno = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtPromedioBachiller = new TextBox();
            cmbTutor = new ComboBox();
            cmbCarrera = new ComboBox();
            pnlAlumno = new Panel();
            lblAlumos = new Label();
            panel1 = new Panel();
            txtPassword = new TextBox();
            cmbPerfil = new ComboBox();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnNuevo = new Button();
            txtBuscarAlumno = new TextBox();
            dgvAlumnos = new DataGridView();
            pcbLogo = new PictureBox();
            lblTitulo = new Label();
            pnlAlumno.SuspendLayout();
            panel1.SuspendLayout();
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
            // APaterno
            // 
            APaterno.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            APaterno.Location = new Point(18, 93);
            APaterno.Name = "APaterno";
            APaterno.PlaceholderText = "Apellido Paterno";
            APaterno.Size = new Size(232, 33);
            APaterno.TabIndex = 2;
            // 
            // AMaterno
            // 
            AMaterno.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            AMaterno.Location = new Point(18, 132);
            AMaterno.Name = "AMaterno";
            AMaterno.PlaceholderText = "Apellido Materno";
            AMaterno.Size = new Size(232, 33);
            AMaterno.TabIndex = 3;
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
            pnlAlumno.Controls.Add(APaterno);
            pnlAlumno.Controls.Add(AMaterno);
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(cmbPerfil);
            panel1.Controls.Add(txtUsuario);
            panel1.Location = new Point(694, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 221);
            panel1.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtPassword.Location = new Point(22, 55);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(232, 33);
            txtPassword.TabIndex = 11;
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
            // 
            // txtBuscarAlumno
            // 
            txtBuscarAlumno.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscarAlumno.Location = new Point(735, 357);
            txtBuscarAlumno.Name = "txtBuscarAlumno";
            txtBuscarAlumno.PlaceholderText = "Buscar Alumno";
            txtBuscarAlumno.Size = new Size(173, 35);
            txtBuscarAlumno.TabIndex = 18;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.GreenYellow;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle4;
            dgvAlumnos.EnableHeadersVisualStyles = false;
            dgvAlumnos.Location = new Point(169, 392);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.RowTemplate.Height = 35;
            dgvAlumnos.Size = new Size(739, 140);
            dgvAlumnos.TabIndex = 16;
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
            Controls.Add(txtBuscarAlumno);
            Controls.Add(dgvAlumnos);
            Controls.Add(lblUsuario);
            Controls.Add(panel1);
            Controls.Add(lblAlumos);
            Controls.Add(pnlAlumno);
            Controls.Add(pcbLogo);
            Name = "frmAlumnos";
            Text = "frmAlumnos";
            pnlAlumno.ResumeLayout(false);
            pnlAlumno.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMatricula;
        private TextBox txtNombre;
        private TextBox APaterno;
        private TextBox AMaterno;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtPromedioBachiller;
        private ComboBox cmbTutor;
        private ComboBox cmbCarrera;
        private Panel pnlAlumno;
        private Label lblAlumos;
        private Panel panel1;
        private TextBox txtPassword;
        private ComboBox cmbPerfil;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnNuevo;
        private TextBox txtBuscarAlumno;
        private DataGridView dgvAlumnos;
        private PictureBox pcbLogo;
        private Label lblTitulo;
    }
}