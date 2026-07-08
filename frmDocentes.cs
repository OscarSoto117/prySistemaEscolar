using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prySistemaEscolar
{
    public partial class frmDocentes : Form
    {
        clsDocentes docentes;
        int idClaveDocente;
        int idUsuario;
        public frmDocentes()
        {
            InitializeComponent();
            CargarCombos();
            CargarGrid();
        }
        public void CargarGrid()
        {
            docentes = new clsDocentes();
            dgvDocentes.DataSource = null;
            dgvDocentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                // Asignamos la tabla virtual de la clase directamente al control visual
                dgvDocentes.DataSource = docentes.CargarDataGrid();

                // Ocultamos las columnas que no queremos que el usuario vea en la tabla
                dgvDocentes.Columns["Usuario"].Visible = false;
                dgvDocentes.Columns["vchpassword"].Visible = false;
                dgvDocentes.Columns["vchperfil"].Visible = false;
                dgvDocentes.Columns["idUsuario"].Visible = false;

                foreach (DataGridViewColumn columna in dgvDocentes.Columns)
                {
                    columna.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CargarCombos()
        {
            try
            {
                cmbPuesto.Items.Clear();
                cmbPuesto.Items.Add("-- Selecciona un Puesto --");
                cmbPuesto.Items.Add("Profesor");
                cmbPuesto.Items.Add("Coordinador");
                cmbPuesto.SelectedIndex = 0; // Forzar a que muestre el placeholder

                cmbPerfil.Items.Clear();
                cmbPerfil.Items.Add("-- Selecciona un Perfil --");
                cmbPerfil.Items.Add("Administrador");
                cmbPerfil.Items.Add("Docente");
                cmbPerfil.SelectedIndex = 0; // Forzar a que muestre el placeholder
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al rellenar los catálogos en los menús desplegables: " + ex.Message);
            }
        }

        private void dgvDocentes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                idClaveDocente = int.Parse(dgvDocentes.CurrentRow.Cells["Clave"].Value.ToString());
                idUsuario = int.Parse(dgvDocentes.CurrentRow.Cells["idUsuario"].Value.ToString());

                // Esto es para los datos del Docente
                txtNombre.Text = dgvDocentes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtTelefono.Text = dgvDocentes.CurrentRow.Cells["Teléfono"].Value.ToString();
                txtCorreo.Text = dgvDocentes.CurrentRow.Cells["Correo"].Value.ToString();
                cmbPuesto.Text = dgvDocentes.CurrentRow.Cells["Puesto"].Value.ToString();

                // Esto es para la tabla Usuarios
                txtUsuario.Text = dgvDocentes.CurrentRow.Cells["Usuario"].Value.ToString();
                txtPassword.Text = dgvDocentes.CurrentRow.Cells["vchpassword"].Value.ToString();
                cmbPerfil.Text = dgvDocentes.CurrentRow.Cells["vchperfil"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mapear los datos seleccionados: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idClaveDocente = 0;
            idUsuario = 0;
            docentes.LimpiarPanel(pnlDocente);
            docentes.LimpiarPanel(pnlUsuario);
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se determinamos el tipo de operación
                int tipoOperacion = idClaveDocente == 0 ? 0 : 1;

                docentes = new clsDocentes();

                // 1. Llenamos las propiedades del bloque Docente
                docentes.ClaveDocente = idClaveDocente; // Si es 0, no afecta porque es Auto Incrementable en el Insert
                docentes.NombreDocente = txtNombre.Text;
                docentes.Puesto = cmbPuesto.Text;
                docentes.Telefono = txtTelefono.Text;
                docentes.Correo = txtCorreo.Text;

                // 2. Llenamos las propiedades del bloque Usuario
                docentes.IdUsuario = idUsuario; // Será 0 si es nuevo, o el ID real si es update
                docentes.NombreUsuario = txtUsuario.Text;
                docentes.Password = txtPassword.Text;
                docentes.Perfil = cmbPerfil.Text;

                string msg = "";

                // Si es una modificación (tipoOperacion = 1), pedimos confirmación como en alumnos
                if (tipoOperacion == 1)
                {
                    var resp = MessageBox.Show("¿Confirmar que deseas actualizar los datos de este docente?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        msg = docentes.GuardarActualizar(tipoOperacion);
                        MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else // Si es nuevo (tipoOperacion = 0), se guarda directo
                {
                    msg = docentes.GuardarActualizar(tipoOperacion);
                    MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CargarGrid(); // Refrescamos la tabla del formulario para ver los cambios
                btnNuevo_Click(null, null); // Limpiamos pantalla después de guardar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show($"¿Desea eliminar el docente con Clave: {idClaveDocente}?\nEsta acción borrará definitivamente su cuenta de usuario.",
               "¡ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    docentes = new clsDocentes();
                    docentes.ClaveDocente = idClaveDocente;
                    docentes.IdUsuario = idUsuario;

                    string resultado = docentes.Eliminar();

                    MessageBox.Show(resultado, "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarGrid(); // Refrescamos la tabla del formulario para ver los cambios
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al eliminar: " + ex.Message,
                        "Error Operacional", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtClaveDocente_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveDocente.Text))
            {
                CargarGrid();
                return;
            }

            docentes = new clsDocentes();
            dgvDocentes.DataSource = null;
            dgvDocentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                docentes.ClaveDocente = int.Parse(txtClaveDocente.Text);
                dgvDocentes.DataSource = docentes.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Requiere asignar datos: " + ex.Message);
            }
        }
    }
}
