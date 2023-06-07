using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENT;
using LOG;

namespace ProyectoAyN
{
    public partial class preTipoPago : Form
    {
        public preTipoPago()
        {
            InitializeComponent();
            listarTipoPago();
            groupBoxDatos.Visible = false;
            txtidTipoPago.Enabled = true;
        }

        #region minimetodo
        public void listarTipoPago()
        {
            dgvTipoPago.DataSource = logTipoPago.Instancia.listarTipoPago();
        }
        private void limpiarVariables()
        {
            txtNombreTP.Text = "";
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
                entTipoPago tp = new entTipoPago();
                tp.idTipoPago = int.Parse(txtidTipoPago.Text.Trim());
                tp.NombreTP = txtNombreTP.Text.Trim();
                logTipoPago.Instancia.insertarTipoPago(tp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            groupBoxDatos.Enabled = false;
            listarTipoPago();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoPago tp = new entTipoPago();
                tp.idTipoPago = int.Parse(txtidTipoPago.Text.Trim());
                tp.NombreTP = txtNombreTP.Text.Trim();
                logTipoPago.Instancia.editarTipoPago(tp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            groupBoxDatos.Enabled = false;
            listarTipoPago();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Visible = false;

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
            txtidTipoPago.Enabled = false;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void dgvTipoPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvTipoPago.Rows[e.RowIndex];
            txtidTipoPago.Text = filaActual.Cells[0].Value.ToString();
            txtNombreTP.Text = filaActual.Cells[1].Value.ToString();
        }
    }
}
