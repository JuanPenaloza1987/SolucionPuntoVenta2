namespace AppPuntoVenta.Venta.Vista
{
    partial class frmConfMetodoPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfMetodoPago));
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.cmbMEtodoPAgo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.dgvAtajo = new System.Windows.Forms.DataGridView();
            this.cmeto_tec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.met_keymet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmeto_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntxtMetodo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtajo)).BeginInit();
            this.cntxtMetodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Método de pago:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(375, 25);
            this.toolStrip1.TabIndex = 67;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = global::AppPuntoVenta.Properties.Resources.nuevo_24;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(23, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = global::AppPuntoVenta.Properties.Resources.guardar_24;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(23, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = global::AppPuntoVenta.Properties.Resources.cancelar_32;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbMEtodoPAgo
            // 
            this.cmbMEtodoPAgo.FormattingEnabled = true;
            this.cmbMEtodoPAgo.Location = new System.Drawing.Point(106, 32);
            this.cmbMEtodoPAgo.Name = "cmbMEtodoPAgo";
            this.cmbMEtodoPAgo.Size = new System.Drawing.Size(146, 21);
            this.cmbMEtodoPAgo.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Atajo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "CTRL + ";
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(152, 59);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(100, 20);
            this.txtLetra.TabIndex = 71;
            this.txtLetra.TextChanged += new System.EventHandler(this.txtLetra_TextChanged);
            // 
            // dgvAtajo
            // 
            this.dgvAtajo.AllowUserToAddRows = false;
            this.dgvAtajo.AllowUserToDeleteRows = false;
            this.dgvAtajo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAtajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtajo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmeto_tec,
            this.met_keymet,
            this.cmeto_id});
            this.dgvAtajo.ContextMenuStrip = this.cntxtMetodo;
            this.dgvAtajo.Location = new System.Drawing.Point(12, 98);
            this.dgvAtajo.Name = "dgvAtajo";
            this.dgvAtajo.ReadOnly = true;
            this.dgvAtajo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAtajo.Size = new System.Drawing.Size(351, 150);
            this.dgvAtajo.TabIndex = 72;
            // 
            // cmeto_tec
            // 
            this.cmeto_tec.DataPropertyName = "cmeto_tec";
            this.cmeto_tec.FillWeight = 97.72733F;
            this.cmeto_tec.HeaderText = "Método de pago";
            this.cmeto_tec.Name = "cmeto_tec";
            this.cmeto_tec.ReadOnly = true;
            // 
            // met_keymet
            // 
            this.met_keymet.DataPropertyName = "met_keymet";
            this.met_keymet.FillWeight = 100.7498F;
            this.met_keymet.HeaderText = "Atajo";
            this.met_keymet.Name = "met_keymet";
            this.met_keymet.ReadOnly = true;
            // 
            // cmeto_id
            // 
            this.cmeto_id.DataPropertyName = "cmeto_id";
            this.cmeto_id.HeaderText = "ID";
            this.cmeto_id.Name = "cmeto_id";
            this.cmeto_id.ReadOnly = true;
            this.cmeto_id.Visible = false;
            // 
            // cntxtMetodo
            // 
            this.cntxtMetodo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.cntxtMetodo.Name = "cntxtMetodo";
            this.cntxtMetodo.Size = new System.Drawing.Size(105, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem1.Text = "Editar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // frmConfMetodoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 260);
            this.Controls.Add(this.dgvAtajo);
            this.Controls.Add(this.txtLetra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMEtodoPAgo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfMetodoPago";
            this.Text = "Configuración de metodos de pago";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtajo)).EndInit();
            this.cntxtMetodo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ComboBox cmbMEtodoPAgo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.DataGridView dgvAtajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmeto_tec;
        private System.Windows.Forms.DataGridViewTextBoxColumn met_keymet;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmeto_id;
        private System.Windows.Forms.ContextMenuStrip cntxtMetodo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}