namespace AppPuntoVenta
{
    partial class frmPaquete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaquete));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dgvPaquete = new System.Windows.Forms.DataGridView();
            this.pqt_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pqt_fini = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pqt_ffin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pqt_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntxtPaquete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquete)).BeginInit();
            this.cntxtPaquete.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(118, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(123, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código de paquete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha de inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de fin";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(118, 55);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpInicio.TabIndex = 6;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(118, 81);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFin.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(407, 29);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(200, 89);
            this.txtDescripcion.TabIndex = 9;
            // 
            // dgvPaquete
            // 
            this.dgvPaquete.AllowUserToAddRows = false;
            this.dgvPaquete.AllowUserToDeleteRows = false;
            this.dgvPaquete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaquete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pqt_codigo,
            this.pqt_fini,
            this.pqt_ffin,
            this.Descricion,
            this.pqt_id});
            this.dgvPaquete.ContextMenuStrip = this.cntxtPaquete;
            this.dgvPaquete.Location = new System.Drawing.Point(15, 157);
            this.dgvPaquete.MultiSelect = false;
            this.dgvPaquete.Name = "dgvPaquete";
            this.dgvPaquete.ReadOnly = true;
            this.dgvPaquete.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPaquete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaquete.Size = new System.Drawing.Size(595, 192);
            this.dgvPaquete.TabIndex = 10;
            this.dgvPaquete.SelectionChanged += new System.EventHandler(this.dgvPaquete_SelectionChanged);
            this.dgvPaquete.Click += new System.EventHandler(this.dgvPaquete_Click);
            this.dgvPaquete.DoubleClick += new System.EventHandler(this.dgvPaquete_DoubleClick);
            // 
            // pqt_codigo
            // 
            this.pqt_codigo.DataPropertyName = "pqt_codigo";
            this.pqt_codigo.HeaderText = "Código";
            this.pqt_codigo.Name = "pqt_codigo";
            this.pqt_codigo.ReadOnly = true;
            // 
            // pqt_fini
            // 
            this.pqt_fini.DataPropertyName = "pqt_fini";
            this.pqt_fini.HeaderText = "Fecha de inicio";
            this.pqt_fini.Name = "pqt_fini";
            this.pqt_fini.ReadOnly = true;
            // 
            // pqt_ffin
            // 
            this.pqt_ffin.DataPropertyName = "pqt_ffin";
            this.pqt_ffin.HeaderText = "Fecha de fin";
            this.pqt_ffin.Name = "pqt_ffin";
            this.pqt_ffin.ReadOnly = true;
            // 
            // Descricion
            // 
            this.Descricion.DataPropertyName = "pqt_descrip";
            this.Descricion.HeaderText = "Descripción";
            this.Descricion.Name = "Descricion";
            this.Descricion.ReadOnly = true;
            // 
            // pqt_id
            // 
            this.pqt_id.DataPropertyName = "pqt_id";
            this.pqt_id.HeaderText = "Id";
            this.pqt_id.Name = "pqt_id";
            this.pqt_id.ReadOnly = true;
            this.pqt_id.Visible = false;
            // 
            // cntxtPaquete
            // 
            this.cntxtPaquete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.cntxtPaquete.Name = "cntxtPaquete";
            this.cntxtPaquete.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cntxtPaquete.Size = new System.Drawing.Size(148, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItem1.Text = "EditarPaquete";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(619, 25);
            this.toolStrip1.TabIndex = 64;
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
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = global::AppPuntoVenta.Properties.Resources.buscar_24;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 22);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "*Dar doble click en el registro (Paquete) para modificar sus artículos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(118, 111);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(123, 20);
            this.txtPrecio.TabIndex = 67;
            // 
            // frmPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 361);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvPaquete);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(635, 400);
            this.MinimumSize = new System.Drawing.Size(635, 400);
            this.Name = "frmPaquete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paquetes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquete)).EndInit();
            this.cntxtPaquete.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dgvPaquete;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn pqt_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pqt_fini;
        private System.Windows.Forms.DataGridViewTextBoxColumn pqt_ffin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricion;
        private System.Windows.Forms.DataGridViewTextBoxColumn pqt_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ContextMenuStrip cntxtPaquete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}