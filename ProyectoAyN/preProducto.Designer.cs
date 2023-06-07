namespace ProyectoAyN
{
    partial class preProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(preProducto));
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtnombreProducto = new System.Windows.Forms.TextBox();
            this.txtidProducto = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNB = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.pictureBoxSalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
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
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
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
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvProducto
            // 
            this.dgvProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProducto.ColumnHeadersHeight = 40;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducto.EnableHeadersVisualStyles = false;
            this.dgvProducto.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProducto.Location = new System.Drawing.Point(26, 96);
            this.dgvProducto.Name = "dgvProducto";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProducto.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProducto.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProducto.Size = new System.Drawing.Size(1182, 159);
            this.dgvProducto.TabIndex = 17;
            this.dgvProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellContentClick);
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDatos.Controls.Add(this.cmbTipoProducto);
            this.groupBoxDatos.Controls.Add(this.txtDescripcion);
            this.groupBoxDatos.Controls.Add(this.txtPrecio);
            this.groupBoxDatos.Controls.Add(this.txtnombreProducto);
            this.groupBoxDatos.Controls.Add(this.txtidProducto);
            this.groupBoxDatos.Controls.Add(this.btnCancelar);
            this.groupBoxDatos.Controls.Add(this.btnModificar);
            this.groupBoxDatos.Controls.Add(this.label3);
            this.groupBoxDatos.Controls.Add(this.btnAgregar);
            this.groupBoxDatos.Controls.Add(this.label4);
            this.groupBoxDatos.Controls.Add(this.label1);
            this.groupBoxDatos.Controls.Add(this.labelNB);
            this.groupBoxDatos.Controls.Add(this.labelID);
            this.groupBoxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBoxDatos.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxDatos.Location = new System.Drawing.Point(26, 273);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(1182, 414);
            this.groupBoxDatos.TabIndex = 21;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "GRUPO DE DATOS DE PRODUCTOS";
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Location = new System.Drawing.Point(242, 297);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(263, 28);
            this.cmbTipoProducto.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtDescripcion.Location = new System.Drawing.Point(321, 141);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(349, 31);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtPrecio.Location = new System.Drawing.Point(321, 204);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(172, 31);
            this.txtPrecio.TabIndex = 2;
            // 
            // txtnombreProducto
            // 
            this.txtnombreProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtnombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtnombreProducto.Location = new System.Drawing.Point(321, 85);
            this.txtnombreProducto.Name = "txtnombreProducto";
            this.txtnombreProducto.Size = new System.Drawing.Size(349, 31);
            this.txtnombreProducto.TabIndex = 2;
            // 
            // txtidProducto
            // 
            this.txtidProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtidProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtidProducto.Location = new System.Drawing.Point(321, 38);
            this.txtidProducto.Name = "txtidProducto";
            this.txtidProducto.Size = new System.Drawing.Size(117, 31);
            this.txtidProducto.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(1021, 344);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 45);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificar.Location = new System.Drawing.Point(523, 344);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(139, 45);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo de Producto";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(27, 344);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 45);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio";
            // 
            // labelNB
            // 
            this.labelNB.AutoSize = true;
            this.labelNB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelNB.ForeColor = System.Drawing.Color.White;
            this.labelNB.Location = new System.Drawing.Point(22, 85);
            this.labelNB.Name = "labelNB";
            this.labelNB.Size = new System.Drawing.Size(214, 25);
            this.labelNB.TabIndex = 0;
            this.labelNB.Text = "Nombre del Producto";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(22, 38);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(124, 25);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID Producto";
            // 
            // pictureBoxSalir
            // 
            this.pictureBoxSalir.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSalir.Image")));
            this.pictureBoxSalir.Location = new System.Drawing.Point(23, 21);
            this.pictureBoxSalir.Name = "pictureBoxSalir";
            this.pictureBoxSalir.Size = new System.Drawing.Size(39, 35);
            this.pictureBoxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSalir.TabIndex = 20;
            this.pictureBoxSalir.TabStop = false;
            this.pictureBoxSalir.Click += new System.EventHandler(this.pictureBoxSalir_Click);
            // 
            // preProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1251, 708);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.pictureBoxSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvProducto);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "preProducto";
            this.Text = "preProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSalir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtnombreProducto;
        private System.Windows.Forms.TextBox txtidProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNB;
        private System.Windows.Forms.Label labelID;
    }
}