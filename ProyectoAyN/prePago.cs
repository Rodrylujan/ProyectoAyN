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
    public partial class prePago : Form
    {
        public prePago()
        {
            InitializeComponent();
            LlenarDatosComboBoxTipoPago();
            LlenarDatosComboBoxEmpleado();
            groupBoxDatos.Visible = false;
            listarPagos();
        }
        #region combobox
        private void LlenarDatosComboBoxTipoPago()
        {
            cmbTipoPago.DataSource = logTipoPago.Instancia.listarTipoPago();
            cmbTipoPago.DisplayMember = "NombreTP";
            cmbTipoPago.ValueMember = "idTipoPago";
        }

        private void LlenarDatosComboBoxEmpleado()
        {
            cmbEmpleado.DataSource = logEmpleado.Instancia.listarEmpleado();
            cmbEmpleado.DisplayMember = "nombreEmpleado";
            cmbEmpleado.ValueMember = "idEmpleado";
        }
        #endregion combobox

        #region minimetodo
        public void listarPagos()
        {
            dgvPago.DataSource = logPago.Instancia.listarPagos();
        }
        private void limpiarVariables()
        {
            txtidComprobantePagos.Text = "";
            txtMontoPago.Text = " ";
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
                entPago p = new entPago();
                p.MontoPago = int.Parse(txtMontoPago.Text.Trim());
                p.fechaPago = dtpPago.Value;
                p.idEmpleado = Convert.ToInt32(cmbEmpleado.SelectedValue);
                p.idTipoPago = Convert.ToInt32(cmbTipoPago.SelectedValue);
                logPago.Instancia.insertarPago(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            groupBoxDatos.Visible = false;
            listarPagos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            groupBoxDatos.Visible = true;
            limpiarVariables();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Visible = false;
        }

        private void dgvPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvPago.Rows[e.RowIndex];
            txtidComprobantePagos.Text = filaActual.Cells[0].Value.ToString();
            txtMontoPago.Text = filaActual.Cells[1].Value.ToString();
            dtpPago.Text = filaActual.Cells[2].Value.ToString();
            cmbEmpleado.SelectedValue = Convert.ToBoolean(filaActual.Cells[3].Value);
            cmbTipoPago.SelectedValue = Convert.ToBoolean(filaActual.Cells[4].Value);
        }
    }
}
