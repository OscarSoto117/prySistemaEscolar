using System;
using System.Data;
using System.Windows.Forms;

namespace prySistemaEscolar
{
    public partial class frmTutores : Form
    {
        int idTutor;
        clsTutores tutores;

        public frmTutores()
        {
            InitializeComponent();
            CargarGrid();
        }
        public void CargarGrid()
        {
            tutores = new clsTutores();
            dgvTutores.DataSource = null;
            dgvTutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvTutores.DataSource = tutores.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtBuscarTutores_TextChanged(object sender, EventArgs e)
        {
            tutores = new clsTutores();
            dgvTutores.DataSource = null;
            dgvTutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                tutores.NombreTutor = txtBuscarTutores.Text;
                dgvTutores.DataSource = tutores.ConsultarCoincidencias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void dgvTutores_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // Validación para evitar errores si la tabla está vacía
                if (dgvTutores.CurrentRow != null)
                {
                    //Campo de referencia para actualizar y eliminar registros(oculto)
                    idTutor = int.Parse(dgvTutores.CurrentRow.Cells[0].Value.ToString());

                    //Campos de referencia para actualizar y eliminar registros(visible)
                    txtNombre.Text = dgvTutores.CurrentRow.Cells[1].Value.ToString();
                    txtParentesco.Text = dgvTutores.CurrentRow.Cells[2].Value.ToString();
                    txtDireccion.Text = dgvTutores.CurrentRow.Cells[3].Value.ToString();
                    txtTelefono.Text = dgvTutores.CurrentRow.Cells[4].Value.ToString();
                    txtCorreo.Text = dgvTutores.CurrentRow.Cells[5].Value.ToString();
                }
            }
            catch { }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int tipoOperacion = idTutor == 0 ? 0 : 1;
                tutores.IdTutor = idTutor;
                tutores.NombreTutor = txtNombre.Text;
                tutores.Parentesco = txtParentesco.Text;
                tutores.Direccion = txtDireccion.Text;
                tutores.Telefono = txtTelefono.Text;
                tutores.Correo = txtCorreo.Text;

                string msg = tutores.GuardarActualizarRegistros(tipoOperacion);
                MessageBox.Show(msg);
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                tutores.IdTutor = idTutor;
                var resp = MessageBox.Show("Confirmar que se desea eliminar el dato seleccionado", "ALERTA!!", MessageBoxButtons.YesNo);
                if (resp == DialogResult.Yes)
                {
                    string msg = tutores.Eliminar();
                    MessageBox.Show(msg);
                    CargarGrid();

                    // Se limpian las cajas después de eliminar
                    idTutor = 0;
                    txtNombre.Clear();
                    txtParentesco.Clear();
                    txtDireccion.Clear();
                    txtTelefono.Clear();
                    txtCorreo.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idTutor = 0;
            txtNombre.Clear();
            txtParentesco.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtNombre.Focus();
        }
    }
}