using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prySistemaEscolar
{
    public partial class frmPrincipal : Form
    {
        clsPrincipal principal;
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void pcbGeneral_MouseDown(object pictureSeleccionado, MouseEventArgs e)
        {
            PictureBox pcb = (PictureBox)pictureSeleccionado;
            pcb.Location = new Point(pcb.Location.X + 3, pcb.Location.Y + 3);
        }
        private void pcbGeneral_MouseUp(object pictureSeleccionado, MouseEventArgs e)
        {
            PictureBox pcb = (PictureBox)pictureSeleccionado;
            pcb.Location = new Point(pcb.Location.X - 3, pcb.Location.Y - 3);

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Cambiando el parent de los picture
            pcbAlumnos.Parent = pcbMenu;
            pcbCarreras.Parent = pcbMenu;
            pcbDocentes.Parent = pcbMenu;
            pcbUsuarios.Parent = pcbMenu;
            pcbSalir.Parent = pcbMenu;
            pcbAlumnos.BackColor = Color.Transparent;
            pcbCarreras.BackColor = Color.Transparent;
            pcbDocentes.BackColor = Color.Transparent;
            pcbUsuarios.BackColor = Color.Transparent;
            pcbSalir.BackColor = Color.Transparent;

            //Verificando Permisos
            pcbCarreras.Enabled = clsLogin.EsAdministrador;
            pcbDocentes.Enabled = clsLogin.EsAdministrador;
            pcbUsuarios.Enabled = clsLogin.EsAdministrador;

            pcbAlumnos.Enabled = clsLogin.EsDocente || clsLogin.EsAdministrador;


        }

        private void pcbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcbCarreras_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmCarreras(), pnlContenedor);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
