using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prySistemaEscolar
{
    public partial class frmCarreras : Form
    {
        int idCarrera;
        clsCarreras carreras;
        public frmCarreras()
        {
            InitializeComponent();
            CargarGrid();
        }
        public void CargarGrid()
        {
            carreras = new clsCarreras();
            dgvCarreras.DataSource = null;
            dgvCarreras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvCarreras.DataSource = carreras.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscarCarrera_TextChanged(object sender, EventArgs e)
        {
            carreras = new clsCarreras();
            dgvCarreras.DataSource = null;
            dgvCarreras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                carreras.NombreCarrera = txtBuscarCarrera.Text;
                dgvCarreras.DataSource = carreras.ConsultarCoincidencias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCarreras_SelectionChanged(object sender, EventArgs e)
        {
            //Campo de referencia para actualizar y eliminar registros(oculto)
            idCarrera = int.Parse(dgvCarreras.CurrentRow.Cells[0].Value.ToString());
            //Campos de referencia para actualizar y eliminar registros(visible)
            txtNombre.Text = dgvCarreras.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dgvCarreras.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int tipoOperacion = idCarrera == 0 ? 0 : 1;//condicion ternaria
                if (tipoOperacion == 1)
                {
                    var resp = MessageBox.Show("Confirmar que se desea actualizar la información seleccionada", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.No)
                    {
                        return;
                    }
                }
                carreras.IdCarrera = idCarrera;
                carreras.NombreCarrera = txtNombre.Text;
                carreras.DescripcionCarrera = txtDescripcion.Text;

                string msg = carreras.GuardarActualizarRegistros(tipoOperacion);
                MessageBox.Show(msg);
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idCarrera = 0;
            txtDescripcion.Clear();
            txtNombre.Clear();
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                carreras.IdCarrera = idCarrera;
                var resp = MessageBox.Show("Confirmar que se desea eliminar el dato selccionado", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (resp == DialogResult.Yes) 
                {
                    string msg = carreras.Eliminar();
                    MessageBox.Show(msg);
                    CargarGrid();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
