using System;
using System.Data;
using System.Windows.Forms;

namespace prySistemaEscolar
{
    public partial class frmTutores : Form
    {
        clsTutores tutor = new clsTutores();
        int tipoOperacion = 0;

        public frmTutores()
        {
            InitializeComponent();
        }

        private void frmTutores_Load(object sender, EventArgs e)
        {
            try
            {
                dgvTutores.DataSource = tutor.CargarDataGrid();
            }
            catch (Exception ex) { MessageBox.Show("Error de conexión: " + ex.Message); }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                tutor.NombreTutor = txtNombre.Text;
                tutor.Parentesco = txtParentesco.Text;
                tutor.Direccion = txtDireccion.Text;
                tutor.Telefono = txtTelefono.Text;
                tutor.Correo = txtCorreo.Text;

                string mensaje = tutor.GuardarActualizarRegistros(tipoOperacion);
                MessageBox.Show(mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvTutores.DataSource = tutor.CargarDataGrid();
                limpiar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

       

        private void limpiar()
        {
            txtNombre.Clear();
            txtParentesco.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            tipoOperacion = 0;
            tutor.IdTutor = 0;
            txtNombre.Focus();
        }

        private void lblTitulo_Click(object sender, EventArgs e) { }
        private void pnlAgrupaControles_Paint(object sender, PaintEventArgs e) { }

    }
}