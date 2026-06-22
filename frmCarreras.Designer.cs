namespace prySistemaEscolar
{
    partial class frmCarreras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarreras));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pcbLogo = new PictureBox();
            lblTitulo = new Label();
            pnlAgrupaControles = new Panel();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnNuevo = new Button();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            dgvCarreras = new DataGridView();
            txtBuscarCarrera = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            pnlAgrupaControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).BeginInit();
            SuspendLayout();
            // 
            // pcbLogo
            // 
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(662, 4);
            pcbLogo.Margin = new Padding(3, 4, 3, 4);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(143, 112);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 0;
            pcbLogo.TabStop = false;
            pcbLogo.Click += pictureBox1_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(494, 56);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(189, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Carreras";
            lblTitulo.Click += label1_Click;
            // 
            // pnlAgrupaControles
            // 
            pnlAgrupaControles.Controls.Add(btnGuardar);
            pnlAgrupaControles.Controls.Add(btnEliminar);
            pnlAgrupaControles.Controls.Add(btnNuevo);
            pnlAgrupaControles.Controls.Add(txtDescripcion);
            pnlAgrupaControles.Controls.Add(txtNombre);
            pnlAgrupaControles.Location = new Point(177, 124);
            pnlAgrupaControles.Margin = new Padding(3, 4, 3, 4);
            pnlAgrupaControles.Name = "pnlAgrupaControles";
            pnlAgrupaControles.Size = new Size(845, 269);
            pnlAgrupaControles.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(356, 173);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 68);
            btnGuardar.TabIndex = 4;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(588, 173);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(158, 68);
            btnEliminar.TabIndex = 3;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ControlDark;
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.Location = new Point(110, 173);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(150, 68);
            btnNuevo.TabIndex = 2;
            btnNuevo.TextAlign = ContentAlignment.BottomCenter;
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(110, 103);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Escribir una descripcion de la carrera";
            txtDescripcion.Size = new Size(636, 42);
            txtDescripcion.TabIndex = 1;
            txtDescripcion.TextChanged += textBox2_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(110, 35);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Escribir el nombre de la carrera";
            txtNombre.Size = new Size(636, 42);
            txtNombre.TabIndex = 0;
            // 
            // dgvCarreras
            // 
            dgvCarreras.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.GreenYellow;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCarreras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCarreras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvCarreras.DefaultCellStyle = dataGridViewCellStyle4;
            dgvCarreras.EnableHeadersVisualStyles = false;
            dgvCarreras.Location = new Point(177, 464);
            dgvCarreras.Margin = new Padding(3, 4, 3, 4);
            dgvCarreras.Name = "dgvCarreras";
            dgvCarreras.RowHeadersWidth = 51;
            dgvCarreras.RowTemplate.Height = 35;
            dgvCarreras.Size = new Size(845, 225);
            dgvCarreras.TabIndex = 3;
            dgvCarreras.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtBuscarCarrera
            // 
            txtBuscarCarrera.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscarCarrera.Location = new Point(824, 401);
            txtBuscarCarrera.Margin = new Padding(3, 4, 3, 4);
            txtBuscarCarrera.Name = "txtBuscarCarrera";
            txtBuscarCarrera.PlaceholderText = "Buscar Carrera";
            txtBuscarCarrera.Size = new Size(197, 42);
            txtBuscarCarrera.TabIndex = 5;
            txtBuscarCarrera.TextChanged += textBox1_TextChanged;
            // 
            // frmCarreras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 725);
            Controls.Add(txtBuscarCarrera);
            Controls.Add(dgvCarreras);
            Controls.Add(pnlAgrupaControles);
            Controls.Add(lblTitulo);
            Controls.Add(pcbLogo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCarreras";
            Text = "Registro de Carreras";
            Load += frmCarreras_Load;
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            pnlAgrupaControles.ResumeLayout(false);
            pnlAgrupaControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbLogo;
        private Label lblTitulo;
        private Panel pnlAgrupaControles;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnNuevo;
        private DataGridView dgvCarreras;
        private TextBox txtBuscarCarrera;
    }
}