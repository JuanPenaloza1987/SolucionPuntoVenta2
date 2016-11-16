namespace SRATAPV.Reportes.Formas
{
    partial class frmReporteCobranza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteCobranza));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnCrear = new System.Windows.Forms.ToolStripButton();
            this.btnPreeliminar = new System.Windows.Forms.ToolStripButton();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCobro = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblCntcs = new System.Windows.Forms.Label();
            this.grpTips = new System.Windows.Forms.GroupBox();
            this.rdbDetal = new System.Windows.Forms.RadioButton();
            this.rdbResum = new System.Windows.Forms.RadioButton();
            this.grpRpts = new System.Windows.Forms.GroupBox();
            this.rdbCancel = new System.Windows.Forms.RadioButton();
            this.rdbImpts = new System.Windows.Forms.RadioButton();
            this.rdbCobrz = new System.Windows.Forms.RadioButton();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbCobro = new System.Windows.Forms.ComboBox();
            this.cmbSerie = new System.Windows.Forms.ComboBox();
            this.cmbCntce = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.grpTips.SuspendLayout();
            this.grpRpts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(453, 25);
            this.toolStrip1.TabIndex = 16;
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
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(99, 86);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(44, 13);
            this.lblFecha.TabIndex = 25;
            this.lblFecha.Text = "Al Corte";
            // 
            // lblCobro
            // 
            this.lblCobro.AutoSize = true;
            this.lblCobro.Location = new System.Drawing.Point(90, 57);
            this.lblCobro.Name = "lblCobro";
            this.lblCobro.Size = new System.Drawing.Size(53, 13);
            this.lblCobro.TabIndex = 26;
            this.lblCobro.Text = "Cobro por";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(107, 114);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(36, 13);
            this.lblSerie.TabIndex = 24;
            this.lblSerie.Text = "Series";
            this.lblSerie.Visible = false;
            // 
            // lblCntcs
            // 
            this.lblCntcs.AutoSize = true;
            this.lblCntcs.Location = new System.Drawing.Point(55, 28);
            this.lblCntcs.Name = "lblCntcs";
            this.lblCntcs.Size = new System.Drawing.Size(88, 13);
            this.lblCntcs.TabIndex = 23;
            this.lblCntcs.Text = "Centro de Costos";
            // 
            // grpTips
            // 
            this.grpTips.Controls.Add(this.rdbDetal);
            this.grpTips.Controls.Add(this.rdbResum);
            this.grpTips.Location = new System.Drawing.Point(266, 28);
            this.grpTips.Name = "grpTips";
            this.grpTips.Size = new System.Drawing.Size(174, 50);
            this.grpTips.TabIndex = 22;
            this.grpTips.TabStop = false;
            this.grpTips.Text = "Tipo de Reporte";
            // 
            // rdbDetal
            // 
            this.rdbDetal.AutoSize = true;
            this.rdbDetal.Location = new System.Drawing.Point(97, 19);
            this.rdbDetal.Name = "rdbDetal";
            this.rdbDetal.Size = new System.Drawing.Size(70, 17);
            this.rdbDetal.TabIndex = 1;
            this.rdbDetal.TabStop = true;
            this.rdbDetal.Text = "Detallado";
            this.rdbDetal.UseVisualStyleBackColor = true;
            this.rdbDetal.CheckedChanged += new System.EventHandler(this.rdbDetal_CheckedChanged);
            // 
            // rdbResum
            // 
            this.rdbResum.AutoSize = true;
            this.rdbResum.Location = new System.Drawing.Point(19, 19);
            this.rdbResum.Name = "rdbResum";
            this.rdbResum.Size = new System.Drawing.Size(72, 17);
            this.rdbResum.TabIndex = 0;
            this.rdbResum.TabStop = true;
            this.rdbResum.Text = "Resumido";
            this.rdbResum.UseVisualStyleBackColor = true;
            this.rdbResum.CheckedChanged += new System.EventHandler(this.rdbResum_CheckedChanged);
            // 
            // grpRpts
            // 
            this.grpRpts.Controls.Add(this.rdbCancel);
            this.grpRpts.Controls.Add(this.rdbImpts);
            this.grpRpts.Controls.Add(this.rdbCobrz);
            this.grpRpts.Location = new System.Drawing.Point(12, 28);
            this.grpRpts.Name = "grpRpts";
            this.grpRpts.Size = new System.Drawing.Size(248, 50);
            this.grpRpts.TabIndex = 21;
            this.grpRpts.TabStop = false;
            this.grpRpts.Text = "Reporte por";
            // 
            // rdbCancel
            // 
            this.rdbCancel.AutoSize = true;
            this.rdbCancel.Location = new System.Drawing.Point(153, 19);
            this.rdbCancel.Name = "rdbCancel";
            this.rdbCancel.Size = new System.Drawing.Size(81, 17);
            this.rdbCancel.TabIndex = 2;
            this.rdbCancel.TabStop = true;
            this.rdbCancel.Text = "Cancelados";
            this.rdbCancel.UseVisualStyleBackColor = true;
            this.rdbCancel.CheckedChanged += new System.EventHandler(this.rdbCancel_CheckedChanged);
            // 
            // rdbImpts
            // 
            this.rdbImpts.AutoSize = true;
            this.rdbImpts.Location = new System.Drawing.Point(82, 19);
            this.rdbImpts.Name = "rdbImpts";
            this.rdbImpts.Size = new System.Drawing.Size(65, 17);
            this.rdbImpts.TabIndex = 1;
            this.rdbImpts.TabStop = true;
            this.rdbImpts.Text = "Importes";
            this.rdbImpts.UseVisualStyleBackColor = true;
            this.rdbImpts.CheckedChanged += new System.EventHandler(this.rdbImpts_CheckedChanged);
            // 
            // rdbCobrz
            // 
            this.rdbCobrz.AutoSize = true;
            this.rdbCobrz.Location = new System.Drawing.Point(6, 19);
            this.rdbCobrz.Name = "rdbCobrz";
            this.rdbCobrz.Size = new System.Drawing.Size(70, 17);
            this.rdbCobrz.TabIndex = 0;
            this.rdbCobrz.TabStop = true;
            this.rdbCobrz.Text = "Cobranza";
            this.rdbCobrz.UseVisualStyleBackColor = true;
            this.rdbCobrz.CheckedChanged += new System.EventHandler(this.rdbCobrz_CheckedChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(149, 83);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(99, 20);
            this.dtpFecha.TabIndex = 20;
            // 
            // cmbCobro
            // 
            this.cmbCobro.FormattingEnabled = true;
            this.cmbCobro.Location = new System.Drawing.Point(149, 54);
            this.cmbCobro.Name = "cmbCobro";
            this.cmbCobro.Size = new System.Drawing.Size(224, 21);
            this.cmbCobro.TabIndex = 19;
            // 
            // cmbSerie
            // 
            this.cmbSerie.FormattingEnabled = true;
            this.cmbSerie.Location = new System.Drawing.Point(149, 111);
            this.cmbSerie.Name = "cmbSerie";
            this.cmbSerie.Size = new System.Drawing.Size(224, 21);
            this.cmbSerie.TabIndex = 18;
            this.cmbSerie.Visible = false;
            // 
            // cmbCntce
            // 
            this.cmbCntce.FormattingEnabled = true;
            this.cmbCntce.Location = new System.Drawing.Point(149, 25);
            this.cmbCntce.Name = "cmbCntce";
            this.cmbCntce.Size = new System.Drawing.Size(224, 21);
            this.cmbCntce.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFecha2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCntcs);
            this.groupBox1.Controls.Add(this.cmbCntce);
            this.groupBox1.Controls.Add(this.lblCobro);
            this.groupBox1.Controls.Add(this.cmbSerie);
            this.groupBox1.Controls.Add(this.lblSerie);
            this.groupBox1.Controls.Add(this.cmbCobro);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 124);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Del";
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(274, 83);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(99, 20);
            this.dtpFecha2.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "al";
            // 
            // frmReporteCobranza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(453, 219);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpTips);
            this.Controls.Add(this.grpRpts);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteCobranza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobranza";
            this.Load += new System.EventHandler(this.frmReporteCobranza_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpTips.ResumeLayout(false);
            this.grpTips.PerformLayout();
            this.grpRpts.ResumeLayout(false);
            this.grpRpts.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnCrear;
        private System.Windows.Forms.ToolStripButton btnPreeliminar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCobro;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblCntcs;
        private System.Windows.Forms.GroupBox grpTips;
        private System.Windows.Forms.RadioButton rdbDetal;
        private System.Windows.Forms.RadioButton rdbResum;
        private System.Windows.Forms.GroupBox grpRpts;
        private System.Windows.Forms.RadioButton rdbCancel;
        private System.Windows.Forms.RadioButton rdbImpts;
        private System.Windows.Forms.RadioButton rdbCobrz;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbCobro;
        private System.Windows.Forms.ComboBox cmbSerie;
        private System.Windows.Forms.ComboBox cmbCntce;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.Label label1;
    }
}