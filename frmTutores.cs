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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tutor.IdTutor == 0)
            {
                MessageBox.Show("Seleccione un tutor de la tabla primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar este tutor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string mensaje = tutor.Eliminar();
                    MessageBox.Show(mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTutores.DataSource = tutor.CargarDataGrid();
                    limpiar();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgvTutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvTutores.Rows[e.RowIndex];

                tutor.IdTutor = Convert.ToInt32(fila.Cells["Clave"].Value);
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtParentesco.Text = fila.Cells["Parentesco"].Value.ToString();
                txtDireccion.Text = fila.Cells["Dirección"].Value.ToString();
                txtTelefono.Text = fila.Cells["Teléfono"].Value.ToString();
                txtCorreo.Text = fila.Cells["Correo"].Value.ToString();

                tipoOperacion = 1;
            }
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

        private void txtBuscarTutores_TextChanged(object sender, EventArgs e)
        {
            dgvTutores.DataSource = null;
            dgvTutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                tutor.NombreTutor = txtBuscarTutores.Text;
                dgvTutores.DataSource = tutor.ConsultarCoincidencias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}