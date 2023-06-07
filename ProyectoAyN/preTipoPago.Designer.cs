namespace ProyectoAyN
{
    partial class preTipoPago
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(preTipoPago));
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvTipoPago = new System.Windows.Forms.DataGridView();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.txtNombreTP = new System.Windows.Forms.TextBox();
            this.txtidTipoPago = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.labelNB = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.pictureBoxSalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPago)).BeginInit();
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnEditar.Location = new System.Drawing.Point(912, 21);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(139, 45);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackColor = System.Drawing.Color.PowderBlue;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnNuevo.Location = new System.Drawing.Point(1087, 21);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(139, 45);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvTipoPago
            // 
            this.dgvTipoPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTipoPago.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvTipoPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTipoPago.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvTipoPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipoPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTipoPago.ColumnHeadersHeight = 40;
            this.dgvTipoPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTipoPago.EnableHeadersVisualStyles = false;
            this.dgvTipoPago.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTipoPago.Location = new System.Drawing.Point(11, 94);
            this.dgvTipoPago.Name = "dgvTipoPago";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipoPago.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTipoPago.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTipoPago.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTipoPago.Size = new System.Drawing.Size(1230, 167);
            this.dgvTipoPago.TabIndex = 14;
            this.dgvTipoPago.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoPago_CellContentClick);
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDatos.Controls.Add(this.txtNombreTP);
            this.groupBoxDatos.Controls.Add(this.txtidTipoPago);
            this.groupBoxDatos.Controls.Add(this.btnCancelar);
            this.groupBoxDatos.Controls.Add(this.btnModificar);
            this.groupBoxDatos.Controls.Add(this.btnAgregar);
            this.groupBoxDatos.Controls.Add(this.labelNB);
            this.groupBoxDatos.Controls.Add(this.labelID);
            this.groupBoxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBoxDatos.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxDatos.Location = new System.Drawing.Point(10, 267);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(1230, 283);
            this.groupBoxDatos.TabIndex = 18;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "GRUPO DE DATOS DE LOS TIPOS DE PAGO";
            // 
            // txtNombreTP
            // 
            this.txtNombreTP.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNombreTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtNombreTP.Location = new System.Drawing.Point(321, 95);
            this.txtNombreTP.Name = "txtNombreTP";
            this.txtNombreTP.Size = new System.Drawing.Size(349, 31);
            this.txtNombreTP.TabIndex = 2;
            // 
            // txtidTipoPago
            // 
            this.txtidTipoPago.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtidTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtidTipoPago.Location = new System.Drawing.Point(321, 38);
            this.txtidTipoPago.Name = "txtidTipoPago";
            this.txtidTipoPago.Size = new System.Drawing.Size(117, 31);
            this.txtidTipoPago.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(1067, 214);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 45);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnModificar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificar.Location = new System.Drawing.Point(819, 214);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(139, 45);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(573, 214);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 45);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // labelNB
            // 
            this.labelNB.AutoSize = true;
            this.labelNB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelNB.ForeColor = System.Drawing.Color.White;
            this.labelNB.Location = new System.Drawing.Point(22, 95);
            this.labelNB.Name = "labelNB";
            this.labelNB.Size = new System.Drawing.Size(256, 25);
            this.labelNB.TabIndex = 0;
            this.labelNB.Text = "Nombre del Tipo de Pago";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(22, 38);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(201, 25);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID del Tipo de Pago";
            // 
            // pictureBoxSalir
            // 
            this.pictureBoxSalir.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSalir.Image")));
            this.pictureBoxSalir.Location = new System.Drawing.Point(23, 21);
            this.pictureBoxSalir.Name = "pictureBoxSalir";
            this.pictureBoxSalir.Size = new System.Drawing.Size(39, 35);
            this.pictureBoxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSalir.TabIndex = 16;
            this.pictureBoxSalir.TabStop = false;
            this.pictureBoxSalir.Click += new System.EventHandler(this.pictureBoxSalir_Click);
            // 
            // preTipoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1251, 633);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.pictureBoxSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvTipoPago);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "preTipoPago";
            this.Text = "preTipoPago";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPago)).EndInit();
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSalir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvTipoPago;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.TextBox txtNombreTP;
        private System.Windows.Forms.TextBox txtidTipoPago;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label labelNB;
        private System.Windows.Forms.Label labelID;
    }
}