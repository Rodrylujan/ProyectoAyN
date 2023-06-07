using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAyN.reportes
{
    public partial class frm_repor : Form
    {
        public frm_repor()
        {
            InitializeComponent();
        }

        private void frm_repor_Load(object sender, EventArgs e)
        {
            DateTime desde = DateTime.Today;
            DateTime hasta = DateTime.Now;
            MessageBox.Show(desde + " " + hasta);
            this.splistarVentaReportTableAdapter.Fill(this.dataSetRP.splistarVentaReport,desde,hasta);
            this.reportViewer1.RefreshReport();
        }
    }
}
