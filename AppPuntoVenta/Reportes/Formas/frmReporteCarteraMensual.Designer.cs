namespace SRATAPV.Reportes.Formas
{
    partial class frmReporteCarteraMensual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteCarteraMensual));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlDesglose = new System.Windows.Forms.Panel();
            this.rdbPorMes = new System.Windows.Forms.RadioButton();
            this.rdbAgrupado = new System.Windows.Forms.RadioButton();
            this.rdbCoordinador = new System.Windows.Forms.RadioButton();
            this.rdbMes = new System.Windows.Forms.RadioButton();
            this.rdbDesglosado = new System.Windows.Forms.RadioButton();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCoordinadorH = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCoordinadorD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCentroCosto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnCrear = new System.Windows.Forms.ToolStripButton();
            this.btnPreeliminar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.pnlDesglose.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pnlDesglose);
            this.groupBox1.Controls.Add(this.rdbCoordinador);
            this.groupBox1.Controls.Add(this.rdbMes);
            this.groupBox1.Controls.Add(this.rdbDesglosado);
            this.groupBox1.Controls.Add(this.txtAnio);
            this.groupBox1.Controls.Add(this.cmbMes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbCoordinadorH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbCoordinadorD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbCentroCosto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // pnlDesglose
            // 
            this.pnlDesglose.Controls.Add(this.rdbPorMes);
            this.pnlDesglose.Controls.Add(this.rdbAgrupado);
            this.pnlDesglose.Location = new System.Drawing.Point(25, 34);
            this.pnlDesglose.Name = "pnlDesglose";
            this.pnlDesglose.Size = new System.Drawing.Size(144, 25);
            this.pnlDesglose.TabIndex = 11;
            this.pnlDesglose.Visible = false;
            // 
            // rdbPorMes
            // 
            this.rdbPorMes.AutoSize = true;
            this.rdbPorMes.Location = new System.Drawing.Point(78, 3);
            this.rdbPorMes.Name = "rdbPorMes";
            this.rdbPorMes.Size = new System.Drawing.Size(63, 17);
            this.rdbPorMes.TabIndex = 3;
            this.rdbPorMes.Text = "Por mes";
            this.rdbPorMes.UseVisualStyleBackColor = true;
            // 
            // rdbAgrupado
            // 
            this.rdbAgrupado.AutoSize = true;
            this.rdbAgrupado.Checked = true;
            this.rdbAgrupado.Location = new System.Drawing.Point(3, 3);
            this.rdbAgrupado.Name = "rdbAgrupado";
            this.rdbAgrupado.Size = new System.Drawing.Size(71, 17);
            this.rdbAgrupado.TabIndex = 2;
            this.rdbAgrupado.TabStop = true;
            this.rdbAgrupado.Text = "Agrupado";
            this.rdbAgrupado.UseVisualStyleBackColor = true;
            // 
            // rdbCoordinador
            // 
            this.rdbCoordinador.AutoSize = true;
            this.rdbCoordinador.Location = new System.Drawing.Point(311, 15);
            this.rdbCoordinador.Name = "rdbCoordinador";
            this.rdbCoordinador.Size = new System.Drawing.Size(127, 17);
            this.rdbCoordinador.TabIndex = 9;
            this.rdbCoordinador.Text = "Total por Coordinador";
            this.rdbCoordinador.UseVisualStyleBackColor = true;
            this.rdbCoordinador.CheckedChanged += new System.EventHandler(this.rdbCoordinador_CheckedChanged);
            // 
            // rdbMes
            // 
            this.rdbMes.AutoSize = true;
            this.rdbMes.Location = new System.Drawing.Point(165, 15);
            this.rdbMes.Name = "rdbMes";
            this.rdbMes.Size = new System.Drawing.Size(90, 17);
            this.rdbMes.TabIndex = 8;
            this.rdbMes.Text = "Total por Mes";
            this.rdbMes.UseVisualStyleBackColor = true;
            this.rdbMes.CheckedChanged += new System.EventHandler(this.rdbMes_CheckedChanged);
            // 
            // rdbDesglosado
            // 
            this.rdbDesglosado.AutoSize = true;
            this.rdbDesglosado.Checked = true;
            this.rdbDesglosado.Location = new System.Drawing.Point(28, 15);
            this.rdbDesglosado.Name = "rdbDesglosado";
            this.rdbDesglosado.Size = new System.Drawing.Size(81, 17);
            this.rdbDesglosado.TabIndex = 7;
            this.rdbDesglosado.TabStop = true;
            this.rdbDesglosado.Text = "Desglosado";
            this.rdbDesglosado.UseVisualStyleBackColor = true;
            this.rdbDesglosado.CheckedChanged += new System.EventHandler(this.rdbDesglosado_CheckedChanged);
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(286, 152);
            this.txtAnio.MaxLength = 4;
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(108, 20);
            this.txtAnio.TabIndex = 4;
            this.txtAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnio_KeyPress);
            this.txtAnio.Leave += new System.EventHandler(this.txtAnio_Leave);
            // 
            // cmbMes
            // 
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbMes.Location = new System.Drawing.Point(126, 152);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(123, 21);
            this.cmbMes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Centro de costo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coordinador";
            // 
            // cmbCoordinadorH
            // 
            this.cmbCoordinadorH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoordinadorH.FormattingEnabled = true;
            this.cmbCoordinadorH.Location = new System.Drawing.Point(126, 123);
            this.cmbCoordinadorH.Name = "cmbCoordinadorH";
            this.cmbCoordinadorH.Size = new System.Drawing.Size(268, 21);
            this.cmbCoordinadorH.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "desde";
            // 
            // cmbCoordinadorD
            // 
            this.cmbCoordinadorD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoordinadorD.FormattingEnabled = true;
            this.cmbCoordinadorD.Location = new System.Drawing.Point(126, 94);
            this.cmbCoordinadorD.Name = "cmbCoordinadorD";
            this.cmbCoordinadorD.Size = new System.Drawing.Size(268, 21);
            this.cmbCoordinadorD.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "hasta";
            // 
            // cmbCentroCosto
            // 
            this.cmbCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCentroCosto.FormattingEnabled = true;
            this.cmbCentroCosto.Location = new System.Drawing.Point(126, 65);
            this.cmbCentroCosto.Name = "cmbCentroCosto";
            this.cmbCentroCosto.Size = new System.Drawing.Size(268, 21);
            this.cmbCentroCosto.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Al corte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "mes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Año";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnBuscar,
            this.btnGuardar,
            this.btnModificar,
            this.btnCancelar,
            this.btnCrear,
            this.btnPreeliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(486, 25);
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
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            // frmReporteCarteraMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(486, 231);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteCarteraMensual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calidad de Cartera Mensual";
            this.Load += new System.EventHandler(this.frmReporteCarteraMensual_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlDesglose.ResumeLayout(false);
            this.pnlDesglose.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCoordinadorH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCoordinadorD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCentroCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnCrear;
        private System.Windows.Forms.ToolStripButton btnPreeliminar;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.RadioButton rdbCoordinador;
        private System.Windows.Forms.RadioButton rdbMes;
        private System.Windows.Forms.RadioButton rdbDesglosado;
        private System.Windows.Forms.Panel pnlDesglose;
        private System.Windows.Forms.RadioButton rdbPorMes;
        private System.Windows.Forms.RadioButton rdbAgrupado;
    }
}