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
    public partial class preProducto : Form
    {
        public preProducto()
        {
            InitializeComponent();
            LlenarDatosComboBoxTipoProducto();
            groupBoxDatos.Visible = false;
            listarProducto();
        }
        #region minimetodo
        public void listarProducto()
        {
            dgvProducto.DataSource = logProducto.Instancia.listarProducto();
        }
        private void limpiarVariables()
        {
            txtidProducto.Text = "";
            txtnombreProducto.Text = " ";
            txtDescripcion.Text = " ";
            txtPrecio.Text = " ";
        }
        private void LlenarDatosComboBoxTipoProducto()
        {
            cmbTipoProducto.DataSource = logTipoProducto.Instancia.listarTipoProducto();
            cmbTipoProducto.DisplayMember = "nombreTipoProducto";
            cmbTipoProducto.ValueMember = "idtipoProducto";
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
                entProducto I = new entProducto();
                I.nombreProducto = txtnombreProducto.Text.Trim();
                I.idtipoProducto = Convert.ToInt32(cmbTipoProducto.SelectedValue);
                I.descripcion = txtDescripcion.Text.Trim();

                I.costoProducto = int.Parse(txtPrecio.Text.Trim());
                logProducto.Instancia.insertarProducto(I);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            limpiarVariables();
            groupBoxDatos.Enabled = false;
            listarProducto();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnAgregar.Visible = true;
            groupBoxDatos.Visible = true;
            btnModificar.Visible = false;
            limpiarVariables();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            entProducto I = new entProducto();
            I.idProducto = int.Parse(txtidProducto.Text.Trim());
            I.nombreProducto = txtnombreProducto.Text.Trim();
            I.idtipoProducto = Convert.ToInt32(cmbTipoProducto.SelectedValue);
            I.descripcion = txtDescripcion.Text.Trim();
            I.costoProducto = int.Parse(txtPrecio.Text.Trim());
            I.idtipoProducto = Convert.ToInt32(cmbTipoProducto.SelectedValue);
            logProducto.Instancia.editarProducto(I);
            groupBoxDatos.Enabled = false;
            listarProducto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Visible=false;
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProducto.Rows[e.RowIndex]; //
            txtidProducto.Text = filaActual.Cells[0].Value.ToString();
            txtnombreProducto.Text = filaActual.Cells[1].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[2].Value.ToString();
            txtPrecio.Text = filaActual.Cells[4].Value.ToString();
            cmbTipoProducto.SelectedValue = Convert.ToBoolean(filaActual.Cells[6].Value);
        }
    }
}
