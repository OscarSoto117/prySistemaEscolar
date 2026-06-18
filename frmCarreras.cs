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
        clsCarreras carreras;
        public frmCarreras()
        {
            InitializeComponent();
            carreras = new clsCarreras();
            dgvCarreras.DataSource = null;
            dgvCarreras.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCarreras.DataSource = carreras.CargarDataGrid();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCarreras_Load(object sender, EventArgs e)
        {

        }
    }
}
