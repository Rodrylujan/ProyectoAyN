using ENT;
using LOG;
using ProyectoAyN.reportes;
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
    public partial class preVenta : Form
    {
        public preVenta()
        {
            InitializeComponent();
            LlenarDatosComboBoxTipoPago();
            LlenarDatosComboBoxCliente();
            LlenarDatosComboBoxEmpleado();
            LlenarDatosComboBoxProducto();
            groupBoxDatos.Visible = false;
            listarVenta();
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

        private void LlenarDatosComboBoxCliente()
        {
            cmbCliente.DataSource = logCliente.Instancia.listarCliente();
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "idCliente";
        }

        private void LlenarDatosComboBoxProducto()
        {
            cmbProducto.DataSource = logProducto.Instancia.listarProducto();
            cmbProducto.DisplayMember = "nombreProducto";
            cmbProducto.ValueMember = "idProducto";
        }
        #endregion combobox
        #region minimetodo
        public void listarVenta()
        {
            dgvVenta.DataSource = logVenta.Instancia.listarVenta();
        }
        private void limpiarVariables()
        {
            txtidVenta.Text = "";
            txtComprobante.Text = " ";
            txtMonto.Text = " ";
        }
        #endregion minimetodo

        private void pictureBoxSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            groupBoxDatos.Visible = true;
            limpiarVariables();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Visible=false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entVenta v = new entVenta();
                v.idComprobante = int.Parse(txtComprobante.Text.Trim());
                v.idProducto = Convert.ToInt32(cmbProducto.SelectedValue);
                v.Monto = int.Parse(txtMonto.Text.Trim());
                v.fecha_hora = dtpVenta.Value;
                v.idCliente = Convert.ToInt32(cmbCliente.SelectedValue);
                v.idTipoPago = Convert.ToInt32(cmbTipoPago.SelectedValue);
                v.idEmpleado = Convert.ToInt32(cmbEmpleado.SelectedValue);
                logVenta.Instancia.insertarVenta(v);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            groupBoxDatos.Enabled = false;
            listarVenta();
        }

        private void dgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvVenta.Rows[e.RowIndex];
            txtidVenta.Text = filaActual.Cells[0].Value.ToString();
            txtComprobante.Text = filaActual.Cells[1].Value.ToString();
            cmbProducto.SelectedValue = Convert.ToBoolean(filaActual.Cells[2].Value);
            txtMonto.Text = filaActual.Cells[3].Value.ToString();
            dtpVenta.Text = filaActual.Cells[4].Value.ToString();
            cmbCliente.SelectedValue = Convert.ToBoolean(filaActual.Cells[5].Value);
            cmbTipoPago.SelectedValue = Convert.ToBoolean(filaActual.Cells[6].Value);
            cmbEmpleado.SelectedValue = Convert.ToBoolean(filaActual.Cells[7].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_repor form_Reporte = new frm_repor();
            form_Reporte.ShowDialog();
        }
    }
}
