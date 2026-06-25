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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            pcbLogo = new PictureBox();
            pnlAgrupaControles = new Panel();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnNuevo = new Button();
            txtParentesco = new TextBox();
            txtNombre = new TextBox();
            dgvTutores = new DataGridView();
            txtBuscarTutores = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            pnlAgrupaControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTutores).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(528, 35);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(172, 57);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Tutores";
            // 
            // pcbLogo
            // 
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(690, 3);
            pcbLogo.Margin = new Padding(3, 4, 3, 4);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(117, 92);
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
            pnlAgrupaControles.Location = new Point(187, 99);
            pnlAgrupaControles.Margin = new Padding(3, 4, 3, 4);
            pnlAgrupaControles.Name = "pnlAgrupaControles";
            pnlAgrupaControles.Size = new Size(845, 367);
            pnlAgrupaControles.TabIndex = 4;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(96, 235);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Escribir el correo del tutor";
            txtCorreo.Size = new Size(650, 42);
            txtCorreo.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(96, 180);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Escribir el telefono del tutor";
            txtTelefono.Size = new Size(650, 42);
            txtTelefono.TabIndex = 6;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(96, 125);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Escribir la direccion del tutor";
            txtDireccion.Size = new Size(650, 42);
            txtDireccion.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(338, 289);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 68);
            btnGuardar.TabIndex = 4;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(578, 289);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(158, 68);
            btnEliminar.TabIndex = 3;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ControlDark;
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.Location = new Point(96, 289);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(150, 68);
            btnNuevo.TabIndex = 2;
            btnNuevo.TextAlign = ContentAlignment.BottomCenter;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtParentesco
            // 
            txtParentesco.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtParentesco.Location = new Point(96, 71);
            txtParentesco.Margin = new Padding(3, 4, 3, 4);
            txtParentesco.Name = "txtParentesco";
            txtParentesco.PlaceholderText = "Escribir el parentesco del tutor";
            txtParentesco.Size = new Size(650, 42);
            txtParentesco.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(96, 16);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Escribir el nombre del tutor ";
            txtNombre.Size = new Size(650, 42);
            txtNombre.TabIndex = 0;
            // 
            // dgvTutores
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.GreenYellow;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTutores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTutores.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTutores.EnableHeadersVisualStyles = false;
            dgvTutores.Location = new Point(194, 528);
            dgvTutores.Margin = new Padding(3, 4, 3, 4);
            dgvTutores.Name = "dgvTutores";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTutores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTutores.RowHeadersWidth = 51;
            dgvTutores.Size = new Size(838, 189);
            dgvTutores.TabIndex = 5;
            dgvTutores.SelectionChanged += dgvTutores_SelectionChanged;
            // 
            // txtBuscarTutores
            // 
            txtBuscarTutores.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscarTutores.Location = new Point(840, 473);
            txtBuscarTutores.Margin = new Padding(3, 4, 3, 4);
            txtBuscarTutores.Name = "txtBuscarTutores";
            txtBuscarTutores.PlaceholderText = "Buscar Tutores";
            txtBuscarTutores.Size = new Size(191, 42);
            txtBuscarTutores.TabIndex = 6;
            txtBuscarTutores.TextChanged += txtBuscarTutores_TextChanged;
            // 
            // frmTutores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 725);
            Controls.Add(txtBuscarTutores);
            Controls.Add(dgvTutores);
            Controls.Add(pnlAgrupaControles);
            Controls.Add(pcbLogo);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTutores";
            Text = "frmTutores";
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            pnlAgrupaControles.ResumeLayout(false);
            pnlAgrupaControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTutores).EndInit();
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
        private DataGridView dgvTutores;
        private TextBox txtBuscarTutores;
    }
}