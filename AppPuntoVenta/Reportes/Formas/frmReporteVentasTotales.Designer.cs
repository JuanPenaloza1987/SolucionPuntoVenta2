namespace SRATAPV.Reportes.Formas
{
    partial class frmReporteVentasTotales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteVentasTotales));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvVentasST = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnCrear = new System.Windows.Forms.ToolStripButton();
            this.btnPreeliminar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvVentasSAP = new System.Windows.Forms.DataGridView();
            this.ReferenciaSAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacturaSAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalNC_SAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSinNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentaST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSinCanceladas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefSAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enviado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EnviadoBitacora = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasST)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasSAP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvVentasST);
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(945, 200);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "STRATA";
            // 
            // dgvVentasST
            // 
            this.dgvVentasST.AllowUserToAddRows = false;
            this.dgvVentasST.AllowUserToDeleteRows = false;
            this.dgvVentasST.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVentasST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentasST.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVentasST.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvVentasST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasST.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VentaST,
            this.ClienteST,
            this.EstadoST,
            this.FechaST,
            this.TotalST,
            this.TotalSinCanceladas,
            this.RefSAP,
            this.Enviado,
            this.EnviadoBitacora,
            this.Sucursal});
            this.dgvVentasST.Location = new System.Drawing.Point(6, 19);
            this.dgvVentasST.Name = "dgvVentasST";
            this.dgvVentasST.ReadOnly = true;
            this.dgvVentasST.Size = new System.Drawing.Size(933, 175);
            this.dgvVentasST.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnModificar,
            this.btnBuscar,
            this.btnCancelar,
            this.btnCrear,
            this.btnPreeliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(969, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = global::SRATAPV.Properties.Resources.nuevo_24;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(23, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = global::SRATAPV.Properties.Resources.guardar_24;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(23, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModificar.Enabled = false;
            this.btnModificar.Image = global::SRATAPV.Properties.Resources.modificar_24;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(23, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = global::SRATAPV.Properties.Resources.buscar_24;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 22);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = global::SRATAPV.Properties.Resources.cancelar_32;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Visible = false;
            // 
            // btnCrear
            // 
            this.btnCrear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCrear.Enabled = false;
            this.btnCrear.Image = global::SRATAPV.Properties.Resources.crear_32;
            this.btnCrear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(23, 22);
            this.btnCrear.Text = "Crear";
            this.btnCrear.Visible = false;
            // 
            // btnPreeliminar
            // 
            this.btnPreeliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPreeliminar.Enabled = false;
            this.btnPreeliminar.Image = global::SRATAPV.Properties.Resources.preeeliminar_24;
            this.btnPreeliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPreeliminar.Name = "btnPreeliminar";
            this.btnPreeliminar.Size = new System.Drawing.Size(23, 22);
            this.btnPreeliminar.Text = "Preeliminar";
            this.btnPreeliminar.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpHasta);
            this.groupBox1.Controls.Add(this.dtpDesde);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 59);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "hasta el";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Del";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(313, 23);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 1;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(46, 23);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvVentasSAP);
            this.groupBox3.Location = new System.Drawing.Point(12, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(945, 200);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SAP";
            // 
            // dgvVentasSAP
            // 
            this.dgvVentasSAP.AllowUserToAddRows = false;
            this.dgvVentasSAP.AllowUserToDeleteRows = false;
            this.dgvVentasSAP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVentasSAP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentasSAP.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVentasSAP.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvVentasSAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasSAP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReferenciaSAP,
            this.FacturaSAP,
            this.FechaSAP,
            this.TotalSAP,
            this.RefST,
            this.TotalNC_SAP,
            this.TotalSinNota});
            this.dgvVentasSAP.Location = new System.Drawing.Point(6, 19);
            this.dgvVentasSAP.Name = "dgvVentasSAP";
            this.dgvVentasSAP.ReadOnly = true;
            this.dgvVentasSAP.Size = new System.Drawing.Size(933, 175);
            this.dgvVentasSAP.TabIndex = 0;
            // 
            // ReferenciaSAP
            // 
            this.ReferenciaSAP.DataPropertyName = "ReferenciaSAP";
            this.ReferenciaSAP.HeaderText = "DocEntry";
            this.ReferenciaSAP.Name = "ReferenciaSAP";
            this.ReferenciaSAP.ReadOnly = true;
            this.ReferenciaSAP.Visible = false;
            // 
            // FacturaSAP
            // 
            this.FacturaSAP.DataPropertyName = "FacturaSAP";
            this.FacturaSAP.HeaderText = "Venta SAP";
            this.FacturaSAP.Name = "FacturaSAP";
            this.FacturaSAP.ReadOnly = true;
            // 
            // FechaSAP
            // 
            this.FechaSAP.DataPropertyName = "FechaSAP";
            this.FechaSAP.HeaderText = "Fecha SAP";
            this.FechaSAP.Name = "FechaSAP";
            this.FechaSAP.ReadOnly = true;
            // 
            // TotalSAP
            // 
            this.TotalSAP.DataPropertyName = "TotalSAP";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TotalSAP.DefaultCellStyle = dataGridViewCellStyle3;
            this.TotalSAP.HeaderText = "Total SAP";
            this.TotalSAP.Name = "TotalSAP";
            this.TotalSAP.ReadOnly = true;
            // 
            // RefST
            // 
            this.RefST.DataPropertyName = "RefST";
            this.RefST.HeaderText = "Referencia de STRATA";
            this.RefST.Name = "RefST";
            this.RefST.ReadOnly = true;
            // 
            // TotalNC_SAP
            // 
            this.TotalNC_SAP.DataPropertyName = "TotalNC_SAP";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TotalNC_SAP.DefaultCellStyle = dataGridViewCellStyle4;
            this.TotalNC_SAP.HeaderText = "Total nota de crédito";
            this.TotalNC_SAP.Name = "TotalNC_SAP";
            this.TotalNC_SAP.ReadOnly = true;
            // 
            // TotalSinNota
            // 
            this.TotalSinNota.DataPropertyName = "TotalSinNota";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TotalSinNota.DefaultCellStyle = dataGridViewCellStyle5;
            this.TotalSinNota.HeaderText = "Total sin nota de crédito";
            this.TotalSinNota.Name = "TotalSinNota";
            this.TotalSinNota.ReadOnly = true;
            // 
            // VentaST
            // 
            this.VentaST.DataPropertyName = "VentaST";
            this.VentaST.HeaderText = "Venta";
            this.VentaST.Name = "VentaST";
            this.VentaST.ReadOnly = true;
            // 
            // ClienteST
            // 
            this.ClienteST.DataPropertyName = "ClienteST";
            this.ClienteST.HeaderText = "Cliente";
            this.ClienteST.Name = "ClienteST";
            this.ClienteST.ReadOnly = true;
            // 
            // EstadoST
            // 
            this.EstadoST.DataPropertyName = "EstadoST";
            this.EstadoST.HeaderText = "Estado";
            this.EstadoST.Name = "EstadoST";
            this.EstadoST.ReadOnly = true;
            // 
            // FechaST
            // 
            this.FechaST.DataPropertyName = "FechaST";
            this.FechaST.HeaderText = "Fecha";
            this.FechaST.Name = "FechaST";
            this.FechaST.ReadOnly = true;
            // 
            // TotalST
            // 
            this.TotalST.DataPropertyName = "TotalST";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TotalST.DefaultCellStyle = dataGridViewCellStyle1;
            this.TotalST.HeaderText = "Total";
            this.TotalST.Name = "TotalST";
            this.TotalST.ReadOnly = true;
            // 
            // TotalSinCanceladas
            // 
            this.TotalSinCanceladas.DataPropertyName = "TotalSinCanceladas";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TotalSinCanceladas.DefaultCellStyle = dataGridViewCellStyle2;
            this.TotalSinCanceladas.HeaderText = "Total sin canceladas";
            this.TotalSinCanceladas.Name = "TotalSinCanceladas";
            this.TotalSinCanceladas.ReadOnly = true;
            // 
            // RefSAP
            // 
            this.RefSAP.DataPropertyName = "RefSAP";
            this.RefSAP.HeaderText = "Referencia de SAP";
            this.RefSAP.Name = "RefSAP";
            this.RefSAP.ReadOnly = true;
            // 
            // Enviado
            // 
            this.Enviado.DataPropertyName = "Enviado";
            this.Enviado.HeaderText = "Enviado";
            this.Enviado.Name = "Enviado";
            this.Enviado.ReadOnly = true;
            this.Enviado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Enviado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EnviadoBitacora
            // 
            this.EnviadoBitacora.DataPropertyName = "EnviadoBitacora";
            this.EnviadoBitacora.HeaderText = "Enviado bitacora";
            this.EnviadoBitacora.Name = "EnviadoBitacora";
            this.EnviadoBitacora.ReadOnly = true;
            this.EnviadoBitacora.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EnviadoBitacora.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Sucursal
            // 
            this.Sucursal.DataPropertyName = "Sucursal";
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.ReadOnly = true;
            // 
            // frmReporteVentasTotales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(969, 512);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteVentasTotales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Análisis de ventas";
            this.Load += new System.EventHandler(this.frmReporteVentasTotales_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasST)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasSAP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvVentasST;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnCrear;
        private System.Windows.Forms.ToolStripButton btnPreeliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvVentasSAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferenciaSAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacturaSAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefST;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalNC_SAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSinNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentaST;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteST;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoST;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaST;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalST;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSinCanceladas;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefSAP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Enviado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EnviadoBitacora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
    }
}