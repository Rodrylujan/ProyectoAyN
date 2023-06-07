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
    public partial class preCliente : Form
    {
        public preCliente()
        {
            InitializeComponent();
            listarCliente();
            groupBoxDatos.Visible = false;
            txtidCliente.Enabled = false;
        }
        #region Minimet
        public void listarCliente()
        {
            dgvCliente.DataSource = logCliente.Instancia.listarCliente();
        }
        private void limpiarVariables()
        {
            txtNombreC.Text = "";
            txtDni.Text = " ";
            txtTelefono.Text = " ";

        }
        #endregion Minimet

        private void groupBoxDatos_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBoxSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region btnAgregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.Nombre = txtNombreC.Text.Trim();
                c.dni = int.Parse(txtDni.Text.Trim());
                c.telefono = int.Parse(txtTelefono.Text.Trim());
                c.fecRegCliente = dtpCliente.Value;
                c.estCliente = cbEstado.Checked;
                logCliente.Instancia.InsertaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            groupBoxDatos.Enabled = false;
            listarCliente();
        }

        
        #endregion btnAgregar

        #region btnNuevoYCancelar..mas
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Visible = true;

            btnAgregar.Visible = true;
            limpiarVariables();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Visible = false;
        }
        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCliente.Rows[e.RowIndex]; //
            txtidCliente.Text = filaActual.Cells[0].Value.ToString();
            txtNombreC.Text = filaActual.Cells[1].Value.ToString();
            txtDni.Text = filaActual.Cells[2].Value.ToString();
            txtTelefono.Text = filaActual.Cells[3].Value.ToString();
            dtpCliente.Text = filaActual.Cells[4].Value.ToString();
            cbEstado.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);
        }


        #endregion btnNuevoYCancelar..mas

        
    }
}
