namespace ProyectoAyN.reportes
{
    partial class frm_repor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetRP = new ProyectoAyN.reportes.DataSetRP();
            this.splistarVentaReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splistarVentaReportTableAdapter = new ProyectoAyN.reportes.DataSetRPTableAdapters.splistarVentaReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splistarVentaReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.splistarVentaReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoAyN.reportes.rpventa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1113, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetRP
            // 
            this.dataSetRP.DataSetName = "DataSetRP";
            this.dataSetRP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splistarVentaReportBindingSource
            // 
            this.splistarVentaReportBindingSource.DataMember = "splistarVentaReport";
            this.splistarVentaReportBindingSource.DataSource = this.dataSetRP;
            // 
            // splistarVentaReportTableAdapter
            // 
            this.splistarVentaReportTableAdapter.ClearBeforeFill = true;
            // 
            // frm_repor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_repor";
            this.Text = "frm_repor";
            this.Load += new System.EventHandler(this.frm_repor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splistarVentaReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource splistarVentaReportBindingSource;
        private DataSetRP dataSetRP;
        private DataSetRPTableAdapters.splistarVentaReportTableAdapter splistarVentaReportTableAdapter;
    }
}