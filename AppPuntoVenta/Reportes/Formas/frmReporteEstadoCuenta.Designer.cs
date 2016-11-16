namespace SRATAPV.Reportes.Formas
{
    partial class frmReporteEstadoCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteEstadoCuenta));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnCrear = new System.Windows.Forms.ToolStripButton();
            this.btnPreeliminar = new System.Windows.Forms.ToolStripButton();
            this.txtNomUno = new System.Windows.Forms.TextBox();
            this.txtNomDos = new System.Windows.Forms.TextBox();
            this.txtCdgDos = new System.Windows.Forms.TextBox();
            this.txtCdgUno = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblSNDos = new System.Windows.Forms.Label();
            this.lblSNUno = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(533, 25);
            this.toolStrip1.TabIndex = 15;
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
            // txtNomUno
            // 
            this.txtNomUno.Location = new System.Drawing.Point(230, 62);
            this.txtNomUno.Name = "txtNomUno";
            this.txtNomUno.Size = new System.Drawing.Size(250, 20);
            this.txtNomUno.TabIndex = 23;
            this.txtNomUno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            // 
            // txtNomDos
            // 
            this.txtNomDos.Location = new System.Drawing.Point(230, 90);
            this.txtNomDos.Name = "txtNomDos";
            this.txtNomDos.Size = new System.Drawing.Size(250, 20);
            this.txtNomDos.TabIndex = 22;
            this.txtNomDos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            // 
            // txtCdgDos
            // 
            this.txtCdgDos.Location = new System.Drawing.Point(124, 90);
            this.txtCdgDos.Name = "txtCdgDos";
            this.txtCdgDos.Size = new System.Drawing.Size(100, 20);
            this.txtCdgDos.TabIndex = 21;
            this.txtCdgDos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            // 
            // txtCdgUno
            // 
            this.txtCdgUno.Location = new System.Drawing.Point(124, 62);
            this.txtCdgUno.Name = "txtCdgUno";
            this.txtCdgUno.Size = new System.Drawing.Size(100, 20);
            this.txtCdgUno.TabIndex = 20;
            this.txtCdgUno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(124, 34);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.TabIndex = 19;
            // 
            // lblSNDos
            // 
            this.lblSNDos.AutoSize = true;
            this.lblSNDos.Location = new System.Drawing.Point(26, 93);
            this.lblSNDos.Name = "lblSNDos";
            this.lblSNDos.Size = new System.Drawing.Size(92, 13);
            this.lblSNDos.TabIndex = 18;
            this.lblSNDos.Text = "Socio de Negocio";
            // 
            // lblSNUno
            // 
            this.lblSNUno.AutoSize = true;
            this.lblSNUno.Location = new System.Drawing.Point(26, 65);
            this.lblSNUno.Name = "lblSNUno";
            this.lblSNUno.Size = new System.Drawing.Size(92, 13);
            this.lblSNUno.TabIndex = 17;
            this.lblSNUno.Text = "Socio de Negocio";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(38, 37);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(80, 13);
            this.lblFecha.TabIndex = 16;
            this.lblFecha.Text = "Fecha de Corte";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.txtNomUno);
            this.groupBox1.Controls.Add(this.lblSNUno);
            this.groupBox1.Controls.Add(this.txtNomDos);
            this.groupBox1.Controls.Add(this.lblSNDos);
            this.groupBox1.Controls.Add(this.txtCdgDos);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.txtCdgUno);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 143);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // frmReporteEstadoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(533, 183);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteEstadoCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estado de cuenta";
            this.Load += new System.EventHandler(this.frmReporteEstadoCuenta_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtNomUno;
        private System.Windows.Forms.TextBox txtNomDos;
        private System.Windows.Forms.TextBox txtCdgDos;
        private System.Windows.Forms.TextBox txtCdgUno;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblSNDos;
        private System.Windows.Forms.Label lblSNUno;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}