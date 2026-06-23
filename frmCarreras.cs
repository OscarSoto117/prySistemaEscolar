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
            int tipoOperacion =idCarrera== 0 ? 0 : 1;
            carreras.GuardarActualizarRegistros(tipoOperacion);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idCarrera = 0;
        }
    }
}
