namespace AppPuntoVenta.Promocion.Vista
{
    partial class frmPromocion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPromocion));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoPromocion = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpfechaFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.gbDias = new System.Windows.Forms.GroupBox();
            this.chkDomingo = new System.Windows.Forms.CheckBox();
            this.chkSabado = new System.Windows.Forms.CheckBox();
            this.chkViernes = new System.Windows.Forms.CheckBox();
            this.chkJueves = new System.Windows.Forms.CheckBox();
            this.chkMartes = new System.Windows.Forms.CheckBox();
            this.chkMiercoles = new System.Windows.Forms.CheckBox();
            this.chkLunes = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoPromocion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dgvPromocion = new System.Windows.Forms.DataGridView();
            this.prom_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prom_tpromo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prom_fini = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prom_ffin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCompra = new System.Windows.Forms.Label();
            this.txtCompra = new System.Windows.Forms.TextBox();
            this.txtGratis = new System.Windows.Forms.TextBox();
            this.lblGratis = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1Accion = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.gbDias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de promoción:";
            // 
            // cmbTipoPromocion
            // 
            this.cmbTipoPromocion.FormattingEnabled = true;
            this.cmbTipoPromocion.IntegralHeight = false;
            this.cmbTipoPromocion.Location = new System.Drawing.Point(122, 30);
            this.cmbTipoPromocion.Name = "cmbTipoPromocion";
            this.cmbTipoPromocion.Size = new System.Drawing.Size(128, 21);
            this.cmbTipoPromocion.TabIndex = 1;
            this.cmbTipoPromocion.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPromocion_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(600, 25);
            this.toolStrip1.TabIndex = 66;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(23, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(23, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Feche de fin:";
            // 
            // dtpfechaFin
            // 
            this.dtpfechaFin.Location = new System.Drawing.Point(122, 109);
            this.dtpfechaFin.Name = "dtpfechaFin";
            this.dtpfechaFin.Size = new System.Drawing.Size(194, 20);
            this.dtpfechaFin.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Feche de inicio:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(122, 83);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(194, 20);
            this.dtpFechaInicio.TabIndex = 70;
            // 
            // gbDias
            // 
            this.gbDias.Controls.Add(this.chkDomingo);
            this.gbDias.Controls.Add(this.chkSabado);
            this.gbDias.Controls.Add(this.chkViernes);
            this.gbDias.Controls.Add(this.chkJueves);
            this.gbDias.Controls.Add(this.chkMartes);
            this.gbDias.Controls.Add(this.chkMiercoles);
            this.gbDias.Controls.Add(this.chkLunes);
            this.gbDias.Location = new System.Drawing.Point(15, 135);
            this.gbDias.Name = "gbDias";
            this.gbDias.Size = new System.Drawing.Size(301, 40);
            this.gbDias.TabIndex = 71;
            this.gbDias.TabStop = false;
            // 
            // chkDomingo
            // 
            this.chkDomingo.AutoSize = true;
            this.chkDomingo.Checked = true;
            this.chkDomingo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDomingo.Location = new System.Drawing.Point(238, 19);
            this.chkDomingo.Name = "chkDomingo";
            this.chkDomingo.Size = new System.Drawing.Size(34, 17);
            this.chkDomingo.TabIndex = 6;
            this.chkDomingo.Text = "D";
            this.chkDomingo.UseVisualStyleBackColor = true;
            // 
            // chkSabado
            // 
            this.chkSabado.AutoSize = true;
            this.chkSabado.Checked = true;
            this.chkSabado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSabado.Location = new System.Drawing.Point(199, 19);
            this.chkSabado.Name = "chkSabado";
            this.chkSabado.Size = new System.Drawing.Size(33, 17);
            this.chkSabado.TabIndex = 5;
            this.chkSabado.Text = "S";
            this.chkSabado.UseVisualStyleBackColor = true;
            // 
            // chkViernes
            // 
            this.chkViernes.AutoSize = true;
            this.chkViernes.Checked = true;
            this.chkViernes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkViernes.Location = new System.Drawing.Point(160, 19);
            this.chkViernes.Name = "chkViernes";
            this.chkViernes.Size = new System.Drawing.Size(33, 17);
            this.chkViernes.TabIndex = 4;
            this.chkViernes.Text = "V";
            this.chkViernes.UseVisualStyleBackColor = true;
            // 
            // chkJueves
            // 
            this.chkJueves.AutoSize = true;
            this.chkJueves.Checked = true;
            this.chkJueves.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJueves.Location = new System.Drawing.Point(123, 19);
            this.chkJueves.Name = "chkJueves";
            this.chkJueves.Size = new System.Drawing.Size(31, 17);
            this.chkJueves.TabIndex = 3;
            this.chkJueves.Text = "J";
            this.chkJueves.UseVisualStyleBackColor = true;
            // 
            // chkMartes
            // 
            this.chkMartes.AutoSize = true;
            this.chkMartes.Checked = true;
            this.chkMartes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMartes.Location = new System.Drawing.Point(44, 19);
            this.chkMartes.Name = "chkMartes";
            this.chkMartes.Size = new System.Drawing.Size(35, 17);
            this.chkMartes.TabIndex = 2;
            this.chkMartes.Text = "M";
            this.chkMartes.UseVisualStyleBackColor = true;
            // 
            // chkMiercoles
            // 
            this.chkMiercoles.AutoSize = true;
            this.chkMiercoles.Checked = true;
            this.chkMiercoles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMiercoles.Location = new System.Drawing.Point(85, 19);
            this.chkMiercoles.Name = "chkMiercoles";
            this.chkMiercoles.Size = new System.Drawing.Size(35, 17);
            this.chkMiercoles.TabIndex = 1;
            this.chkMiercoles.Text = "M";
            this.chkMiercoles.UseVisualStyleBackColor = true;
            // 
            // chkLunes
            // 
            this.chkLunes.AutoSize = true;
            this.chkLunes.Checked = true;
            this.chkLunes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLunes.Location = new System.Drawing.Point(6, 19);
            this.chkLunes.Name = "chkLunes";
            this.chkLunes.Size = new System.Drawing.Size(32, 17);
            this.chkLunes.TabIndex = 0;
            this.chkLunes.Text = "L";
            this.chkLunes.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Código de promoción:";
            // 
            // txtCodigoPromocion
            // 
            this.txtCodigoPromocion.Location = new System.Drawing.Point(122, 57);
            this.txtCodigoPromocion.Name = "txtCodigoPromocion";
            this.txtCodigoPromocion.Size = new System.Drawing.Size(128, 20);
            this.txtCodigoPromocion.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(394, 83);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(196, 88);
            this.txtDescripcion.TabIndex = 75;
            // 
            // dgvPromocion
            // 
            this.dgvPromocion.AllowUserToAddRows = false;
            this.dgvPromocion.AllowUserToDeleteRows = false;
            this.dgvPromocion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPromocion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromocion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prom_codigo,
            this.prom_tpromo,
            this.prom_fini,
            this.prom_ffin});
            this.dgvPromocion.Location = new System.Drawing.Point(12, 204);
            this.dgvPromocion.MultiSelect = false;
            this.dgvPromocion.Name = "dgvPromocion";
            this.dgvPromocion.ReadOnly = true;
            this.dgvPromocion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPromocion.Size = new System.Drawing.Size(576, 181);
            this.dgvPromocion.TabIndex = 76;
            this.dgvPromocion.Click += new System.EventHandler(this.dgvPromocion_Click);
            this.dgvPromocion.DoubleClick += new System.EventHandler(this.dgvPromocion_DoubleClick);
            // 
            // prom_codigo
            // 
            this.prom_codigo.DataPropertyName = "prom_codigo";
            this.prom_codigo.HeaderText = "Código";
            this.prom_codigo.Name = "prom_codigo";
            this.prom_codigo.ReadOnly = true;
            // 
            // prom_tpromo
            // 
            this.prom_tpromo.DataPropertyName = "prom_tpromo";
            this.prom_tpromo.HeaderText = "Tipo";
            this.prom_tpromo.Name = "prom_tpromo";
            this.prom_tpromo.ReadOnly = true;
            // 
            // prom_fini
            // 
            this.prom_fini.DataPropertyName = "prom_fini";
            this.prom_fini.HeaderText = "Inicio";
            this.prom_fini.Name = "prom_fini";
            this.prom_fini.ReadOnly = true;
            // 
            // prom_ffin
            // 
            this.prom_ffin.DataPropertyName = "prom_ffin";
            this.prom_ffin.HeaderText = "Fin";
            this.prom_ffin.Name = "prom_ffin";
            this.prom_ffin.ReadOnly = true;
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Location = new System.Drawing.Point(256, 33);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(43, 13);
            this.lblCompra.TabIndex = 77;
            this.lblCompra.Text = "Compra";
            // 
            // txtCompra
            // 
            this.txtCompra.Location = new System.Drawing.Point(305, 30);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(34, 20);
            this.txtCompra.TabIndex = 78;
            // 
            // txtGratis
            // 
            this.txtGratis.Location = new System.Drawing.Point(385, 30);
            this.txtGratis.Name = "txtGratis";
            this.txtGratis.Size = new System.Drawing.Size(34, 20);
            this.txtGratis.TabIndex = 79;
            // 
            // lblGratis
            // 
            this.lblGratis.AutoSize = true;
            this.lblGratis.Location = new System.Drawing.Point(345, 33);
            this.lblGratis.Name = "lblGratis";
            this.lblGratis.Size = new System.Drawing.Size(34, 13);
            this.lblGratis.TabIndex = 80;
            this.lblGratis.Text = "Gratis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 13);
            this.label6.TabIndex = 81;
            this.label6.Text = "*Dar doble click en el registro (Promoción) para ver el detalle";
            // 
            // textBox1Accion
            // 
            this.textBox1Accion.Location = new System.Drawing.Point(554, 12);
            this.textBox1Accion.Name = "textBox1Accion";
            this.textBox1Accion.Size = new System.Drawing.Size(34, 20);
            this.textBox1Accion.TabIndex = 82;
            this.textBox1Accion.Text = "0";
            this.textBox1Accion.Visible = false;
            // 
            // frmPromocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 397);
            this.Controls.Add(this.textBox1Accion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblGratis);
            this.Controls.Add(this.txtGratis);
            this.Controls.Add(this.txtCompra);
            this.Controls.Add(this.lblCompra);
            this.Controls.Add(this.dgvPromocion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigoPromocion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbDias);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpfechaFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cmbTipoPromocion);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmPromocion";
            this.Text = "Promoción";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbDias.ResumeLayout(false);
            this.gbDias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoPromocion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpfechaFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.GroupBox gbDias;
        private System.Windows.Forms.CheckBox chkLunes;
        private System.Windows.Forms.CheckBox chkDomingo;
        private System.Windows.Forms.CheckBox chkSabado;
        private System.Windows.Forms.CheckBox chkViernes;
        private System.Windows.Forms.CheckBox chkJueves;
        private System.Windows.Forms.CheckBox chkMartes;
        private System.Windows.Forms.CheckBox chkMiercoles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoPromocion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dgvPromocion;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.TextBox txtCompra;
        private System.Windows.Forms.TextBox txtGratis;
        private System.Windows.Forms.Label lblGratis;
        private System.Windows.Forms.DataGridViewTextBoxColumn prom_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn prom_tpromo;
        private System.Windows.Forms.DataGridViewTextBoxColumn prom_fini;
        private System.Windows.Forms.DataGridViewTextBoxColumn prom_ffin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1Accion;
    }
}