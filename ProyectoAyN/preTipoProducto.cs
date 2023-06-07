using ENT;
using LOG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAyN
{
    public partial class preTipoProducto : Form
    {
        public preTipoProducto()
        {
            InitializeComponent();
            listarTipoProducto();
            groupBoxDatos.Visible = false;
            txtidTipoProducto.Enabled = true;
        }
        #region minimetodo
        public void listarTipoProducto()
        {
            dgvTipoProducto.DataSource = logTipoProducto.Instancia.listarTipoProducto();
        }
        private void limpiarVariables()
        {
            txtTipoProducto.Text = "";
            txtDescripcion.Text = " ";
        }
        #endregion minimetodo

        private void pictureBoxSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                entTipoProducto tp = new entTipoProducto();
                tp.nombreTipoProducto = txtTipoProducto.Text.Trim();
                tp.descripcionTipoProducto = txtDescripcion.Text.Trim();
                logTipoProducto.Instancia.insertarTipoProducto(tp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            groupBoxDatos.Visible = false;
            listarTipoProducto();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoProducto tp = new entTipoProducto();
                tp.idtipoProducto = int.Parse(txtidTipoProducto.Text.Trim());
                tp.nombreTipoProducto = txtTipoProducto.Text.Trim();
                tp.descripcionTipoProducto = txtDescripcion.Text.Trim();
                logTipoProducto.Instancia.editarTipoProducto(tp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            groupBoxDatos.Enabled = false;
            listarTipoProducto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Visible=false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Visible = true;
            btnAgregar.Visible = true;
            limpiarVariables();
            btnModificar.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Visible = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
            txtidTipoProducto.Enabled = false;
        }

        private void dgvTipoProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvTipoProducto.Rows[e.RowIndex]; //
            txtidTipoProducto.Text = filaActual.Cells[0].Value.ToString();
            txtTipoProducto.Text = filaActual.Cells[1].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[2].Value.ToString();
        }
    }
}
