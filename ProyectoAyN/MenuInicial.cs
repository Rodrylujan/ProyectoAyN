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
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
            perdiseño();
        }

        private void perdiseño()
        {
            PanelsubMenuProductos.Visible = false;
            PanelsubMenuPagos.Visible = false;
        }

        private void escSubMenu()
        {
            if (PanelsubMenuProductos.Visible == true)
                PanelsubMenuProductos.Visible = false;
            if (PanelsubMenuPagos.Visible == true)
                PanelsubMenuPagos.Visible = false;
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                escSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;


        }
        #region Productos
       private void btnProductos_Click_1(object sender, EventArgs e)
        {
            mostrarSubMenu(PanelsubMenuProductos);
        }
        private void btnSProducto_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new preProducto());
            escSubMenu();
        }
        private void btnSMTipoProducto_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new preTipoProducto());
            escSubMenu();
        }
        #endregion
        #region Pagos
        private void btnPagos_Click_1(object sender, EventArgs e)
        {
            mostrarSubMenu(PanelsubMenuPagos);
        }

        private void btnSMPago_Click_1(object sender, EventArgs e)
        {
            abrirFormHijo(new prePago());
            escSubMenu();
        }
        private void btnSMTipoPago_Click_1(object sender, EventArgs e)
        {
            abrirFormHijo(new preTipoPago());
            escSubMenu();
        }

        #endregion

        private Form FormActivo = null;
        private void abrirFormHijo(Form FormHijo)
        {
            if (FormActivo != null)
                FormActivo.Close();
            FormActivo = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            panelHijoForm.Controls.Add(FormHijo);
            panelHijoForm.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
        }

        private void btnSalirEjecutable_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new preVenta());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new preCliente());    
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new preEmpleado());   
        }

    }
}
