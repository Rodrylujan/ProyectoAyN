namespace ProyectoAyN
{
    partial class prePago
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prePago));
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvPago = new System.Windows.Forms.DataGridView();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.dtpPago = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMontoPago = new System.Windows.Forms.TextBox();
            this.txtidComprobantePagos = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNB = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.pictureBoxSalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPago)).BeginInit();
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevo.BackColor = System.Drawing.Color.PowderBlue;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnNuevo.Location = new System.Drawing.Point(1087, 21);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(139, 45);
            this.btnNuevo.TabIndex = 18;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvPago
            // 
            this.dgvPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPago.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPago.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPago.ColumnHeadersHeight = 40;
            this.dgvPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPago.EnableHeadersVisualStyles = false;
            this.dgvPago.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPago.Location = new System.Drawing.Point(5, 72);
            this.dgvPago.Name = "dgvPago";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPago.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPago.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPago.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPago.Size = new System.Drawing.Size(1241, 173);
            this.dgvPago.TabIndex = 17;
            this.dgvPago.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPago_CellContentClick);
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDatos.Controls.Add(this.cmbTipoPago);
            this.groupBoxDatos.Controls.Add(this.label2);
            this.groupBoxDatos.Controls.Add(this.cmbEmpleado);
            this.groupBoxDatos.Controls.Add(this.dtpPago);
            this.groupBoxDatos.Controls.Add(this.label5);
            this.groupBoxDatos.Controls.Add(this.txtMontoPago);
            this.groupBoxDatos.Controls.Add(this.txtidComprobantePagos);
            this.groupBoxDatos.Controls.Add(this.btnCancelar);
            this.groupBoxDatos.Controls.Add(this.btnAgregar);
            this.groupBoxDatos.Controls.Add(this.label1);
            this.groupBoxDatos.Controls.Add(this.labelNB);
            this.groupBoxDatos.Controls.Add(this.labelID);
            this.groupBoxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBoxDatos.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxDatos.Location = new System.Drawing.Point(10, 263);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(1241, 389);
            this.groupBoxDatos.TabIndex = 20;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "GRUPO DE DATOS DEL PAGO";
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Location = new System.Drawing.Point(485, 153);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(175, 28);
            this.cmbTipoPago.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(334, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tipo de Pago";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(145, 150);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(162, 28);
            this.cmbEmpleado.TabIndex = 10;
            // 
            // dtpPago
            // 
            this.dtpPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.dtpPago.Location = new System.Drawing.Point(27, 246);
            this.dtpPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpPago.Name = "dtpPago";
            this.dtpPago.Size = new System.Drawing.Size(351, 31);
            this.dtpPago.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label5.Location = new System.Drawing.Point(26, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de Registro";
            // 
            // txtMontoPago
            // 
            this.txtMontoPago.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMontoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtMontoPago.Location = new System.Drawing.Point(321, 95);
            this.txtMontoPago.Name = "txtMontoPago";
            this.txtMontoPago.Size = new System.Drawing.Size(349, 31);
            this.txtMontoPago.TabIndex = 2;
            // 
            // txtidComprobantePagos
            // 
            this.txtidComprobantePagos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtidComprobantePagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtidComprobantePagos.Location = new System.Drawing.Point(321, 38);
            this.txtidComprobantePagos.Name = "txtidComprobantePagos";
            this.txtidComprobantePagos.Size = new System.Drawing.Size(117, 31);
            this.txtidComprobantePagos.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(800, 319);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 45);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(27, 319);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 45);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado";
            // 
            // labelNB
            // 
            this.labelNB.AutoSize = true;
            this.labelNB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelNB.ForeColor = System.Drawing.Color.White;
            this.labelNB.Location = new System.Drawing.Point(22, 95);
            this.labelNB.Name = "labelNB";
            this.labelNB.Size = new System.Drawing.Size(72, 25);
            this.labelNB.TabIndex = 0;
            this.labelNB.Text = "Monto";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(22, 38);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(197, 25);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Comprobante Pago";
            // 
            // pictureBoxSalir
            // 
            this.pictureBoxSalir.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSalir.Image")));
            this.pictureBoxSalir.Location = new System.Drawing.Point(23, 21);
            this.pictureBoxSalir.Name = "pictureBoxSalir";
            this.pictureBoxSalir.Size = new System.Drawing.Size(39, 35);
            this.pictureBoxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSalir.TabIndex = 19;
            this.pictureBoxSalir.TabStop = false;
            this.pictureBoxSalir.Click += new System.EventHandler(this.pictureBoxSalir_Click);
            // 
            // prePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1251, 657);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.pictureBoxSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvPago);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "prePago";
            this.Text = "prePago";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPago)).EndInit();
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvPago;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.DateTimePicker dtpPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMontoPago;
        private System.Windows.Forms.TextBox txtidComprobantePagos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNB;
        private System.Windows.Forms.Label labelID;
    }
}