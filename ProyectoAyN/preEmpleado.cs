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
    public partial class preEmpleado : Form
    {
        public preEmpleado()
        {
            InitializeComponent();
            listarEmpleado();
            groupBoxDatos.Visible = false;
            txtidEmpleado.Enabled = true;
        }


        #region minimetodo
        public void listarEmpleado()
        {
            dgvEmpleado.DataSource = logEmpleado.Instancia.listarEmpleado();
        }
        private void limpiarVariables()
        {
            txtnombreEmpleado.Text = "";
            txtDni.Text = " ";
            txttipoEmpleado.Text = " ";
        }
        #endregion minimetodo
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpleado em = new entEmpleado();
                em.nombreEmpleado = txtnombreEmpleado.Text.Trim();
                em.dni = int.Parse(txtDni.Text.Trim());
                em.TipoEmpleado = txttipoEmpleado.Text.Trim();
                logEmpleado.Instancia.insertarEmpleado(em);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            groupBoxDatos.Enabled = false;
            listarEmpleado();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpleado em = new entEmpleado();
                em.idEmpleado = int.Parse(txtidEmpleado.Text.Trim());
                em.nombreEmpleado = txtnombreEmpleado.Text.Trim();
                em.dni = int.Parse(txtDni.Text.Trim());
                em.TipoEmpleado = txttipoEmpleado.Text.Trim();
                logEmpleado.Instancia.editarEmpleado(em);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            groupBoxDatos.Enabled = false;
            listarEmpleado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Visible = true;
            btnModificar.Visible = true;
            limpiarVariables();
            btnAgregar.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Visible = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
            txtidEmpleado.Enabled = false;
        }

        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvEmpleado.Rows[e.RowIndex];
            txtidEmpleado.Text = filaActual.Cells[0].Value.ToString();
            txtnombreEmpleado.Text = filaActual.Cells[1].Value.ToString();
            txtDni.Text = filaActual.Cells[2].Value.ToString();
            txttipoEmpleado.Text = filaActual.Cells[3].Value.ToString();
        }
    }
}
