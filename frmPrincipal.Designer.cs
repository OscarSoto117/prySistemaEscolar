namespace prySistemaEscolar
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            pcbMenu = new PictureBox();
            pcbTitulo = new PictureBox();
            pcbAlumnos = new PictureBox();
            pcbCarreras = new PictureBox();
            pcbDocentes = new PictureBox();
            pcbUsuarios = new PictureBox();
            pcbSalir = new PictureBox();
            pnlContenedor = new Panel();
            pcbTutores = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbTitulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbCarreras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbDocentes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbTutores).BeginInit();
            SuspendLayout();
            // 
            // pcbMenu
            // 
            pcbMenu.Image = (Image)resources.GetObject("pcbMenu.Image");
            pcbMenu.Location = new Point(10, 9);
            pcbMenu.Margin = new Padding(3, 2, 3, 2);
            pcbMenu.Name = "pcbMenu";
            pcbMenu.Size = new Size(500, 717);
            pcbMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbMenu.TabIndex = 0;
            pcbMenu.TabStop = false;
            // 
            // pcbTitulo
            // 
            pcbTitulo.Image = (Image)resources.GetObject("pcbTitulo.Image");
            pcbTitulo.Location = new Point(564, 9);
            pcbTitulo.Margin = new Padding(3, 2, 3, 2);
            pcbTitulo.Name = "pcbTitulo";
            pcbTitulo.Size = new Size(1085, 115);
            pcbTitulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbTitulo.TabIndex = 1;
            pcbTitulo.TabStop = false;
            // 
            // pcbAlumnos
            // 
            pcbAlumnos.Image = (Image)resources.GetObject("pcbAlumnos.Image");
            pcbAlumnos.Location = new Point(60, 104);
            pcbAlumnos.Margin = new Padding(3, 2, 3, 2);
            pcbAlumnos.Name = "pcbAlumnos";
            pcbAlumnos.Size = new Size(380, 98);
            pcbAlumnos.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbAlumnos.TabIndex = 2;
            pcbAlumnos.TabStop = false;
            pcbAlumnos.MouseDown += pcbGeneral_MouseDown;
            pcbAlumnos.MouseUp += pcbGeneral_MouseUp;
            // 
            // pcbCarreras
            // 
            pcbCarreras.Image = (Image)resources.GetObject("pcbCarreras.Image");
            pcbCarreras.Location = new Point(60, 206);
            pcbCarreras.Margin = new Padding(3, 2, 3, 2);
            pcbCarreras.Name = "pcbCarreras";
            pcbCarreras.Size = new Size(380, 98);
            pcbCarreras.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbCarreras.TabIndex = 3;
            pcbCarreras.TabStop = false;
            pcbCarreras.Click += pcbCarreras_Click;
            pcbCarreras.MouseDown += pcbGeneral_MouseDown;
            pcbCarreras.MouseUp += pcbGeneral_MouseUp;
            // 
            // pcbDocentes
            // 
            pcbDocentes.Image = (Image)resources.GetObject("pcbDocentes.Image");
            pcbDocentes.Location = new Point(60, 308);
            pcbDocentes.Margin = new Padding(3, 2, 3, 2);
            pcbDocentes.Name = "pcbDocentes";
            pcbDocentes.Size = new Size(380, 98);
            pcbDocentes.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbDocentes.TabIndex = 4;
            pcbDocentes.TabStop = false;
            pcbDocentes.MouseDown += pcbGeneral_MouseDown;
            pcbDocentes.MouseUp += pcbGeneral_MouseUp;
            // 
            // pcbUsuarios
            // 
            pcbUsuarios.Image = (Image)resources.GetObject("pcbUsuarios.Image");
            pcbUsuarios.Location = new Point(60, 410);
            pcbUsuarios.Margin = new Padding(3, 2, 3, 2);
            pcbUsuarios.Name = "pcbUsuarios";
            pcbUsuarios.Size = new Size(380, 98);
            pcbUsuarios.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbUsuarios.TabIndex = 5;
            pcbUsuarios.TabStop = false;
            pcbUsuarios.MouseDown += pcbGeneral_MouseDown;
            pcbUsuarios.MouseUp += pcbGeneral_MouseUp;
            // 
            // pcbSalir
            // 
            pcbSalir.Image = (Image)resources.GetObject("pcbSalir.Image");
            pcbSalir.Location = new Point(60, 613);
            pcbSalir.Margin = new Padding(3, 2, 3, 2);
            pcbSalir.Name = "pcbSalir";
            pcbSalir.Size = new Size(380, 98);
            pcbSalir.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbSalir.TabIndex = 6;
            pcbSalir.TabStop = false;
            pcbSalir.Click += pcbSalir_Click;
            pcbSalir.MouseDown += pcbGeneral_MouseDown;
            pcbSalir.MouseUp += pcbGeneral_MouseUp;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.FromArgb(144, 194, 38);
            pnlContenedor.Location = new Point(568, 143);
            pnlContenedor.Margin = new Padding(3, 2, 3, 2);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1082, 583);
            pnlContenedor.TabIndex = 7;
            pnlContenedor.Paint += pnlContenedor_Paint;
            // 
            // pcbTutores
            // 
            pcbTutores.Image = (Image)resources.GetObject("pcbTutores.Image");
            pcbTutores.Location = new Point(60, 511);
            pcbTutores.Margin = new Padding(3, 2, 3, 2);
            pcbTutores.Name = "pcbTutores";
            pcbTutores.Size = new Size(380, 98);
            pcbTutores.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbTutores.TabIndex = 8;
            pcbTutores.TabStop = false;
            pcbTutores.Click += pcbTutores_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 743);
            Controls.Add(pcbTutores);
            Controls.Add(pnlContenedor);
            Controls.Add(pcbSalir);
            Controls.Add(pcbUsuarios);
            Controls.Add(pcbDocentes);
            Controls.Add(pcbCarreras);
            Controls.Add(pcbAlumnos);
            Controls.Add(pcbTitulo);
            Controls.Add(pcbMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPrincipal";
            Text = "Sistema Escolar";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pcbMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbTitulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbCarreras).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbDocentes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbTutores).EndInit();
            ResumeLayout(false);
        }
        // pnl contenedor 
        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {
           
        }

        #endregion

        private PictureBox pcbMenu;
        private PictureBox pcbTitulo;
        private PictureBox pcbAlumnos;
        private PictureBox pcbCarreras;
        private PictureBox pcbDocentes;
        private PictureBox pcbUsuarios;
        private PictureBox pcbSalir;
        private Panel pnlContenedor;
        private PictureBox pcbTutores;
    }
}
