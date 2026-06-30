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
            txtMatricula = new TextBox();
            txtNombre = new TextBox();
            txtAPaterno = new TextBox();
            txtAMaterno = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            SuspendLayout();
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(208, 104);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(466, 27);
            txtMatricula.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(208, 137);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(466, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtAPaterno
            // 
            txtAPaterno.Location = new Point(208, 181);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(466, 27);
            txtAPaterno.TabIndex = 2;
            // 
            // txtAMaterno
            // 
            txtAMaterno.Location = new Point(208, 223);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(466, 27);
            txtAMaterno.TabIndex = 3;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(208, 270);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(466, 27);
            txtDireccion.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(208, 315);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(466, 27);
            txtTelefono.TabIndex = 5;
            // 
            // frmAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 725);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtAMaterno);
            Controls.Add(txtAPaterno);
            Controls.Add(txtNombre);
            Controls.Add(txtMatricula);
            Name = "frmAlumnos";
            Text = "Registro de alumnos";
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
    }
}