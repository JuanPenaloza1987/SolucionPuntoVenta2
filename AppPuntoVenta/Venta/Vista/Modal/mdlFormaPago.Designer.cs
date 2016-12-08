namespace AppPuntoVenta.Venta.Vista.Modal
{
    partial class mdlFormaPago
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
            this.dgvFormaPago = new System.Windows.Forms.DataGridView();
            this.Prefijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Letra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetodoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormaPago)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFormaPago
            // 
            this.dgvFormaPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFormaPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormaPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prefijo,
            this.Letra,
            this.MetodoPago});
            this.dgvFormaPago.Location = new System.Drawing.Point(12, 12);
            this.dgvFormaPago.Name = "dgvFormaPago";
            this.dgvFormaPago.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFormaPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFormaPago.Size = new System.Drawing.Size(260, 237);
            this.dgvFormaPago.TabIndex = 0;
            this.dgvFormaPago.DoubleClick += new System.EventHandler(this.dgvFormaPago_DoubleClick);
            // 
            // Prefijo
            // 
            this.Prefijo.DataPropertyName = "Prefijo";
            this.Prefijo.FillWeight = 50F;
            this.Prefijo.HeaderText = "";
            this.Prefijo.Name = "Prefijo";
            // 
            // Letra
            // 
            this.Letra.DataPropertyName = "Letra";
            this.Letra.FillWeight = 50F;
            this.Letra.HeaderText = "Letra";
            this.Letra.Name = "Letra";
            this.Letra.ReadOnly = true;
            // 
            // MetodoPago
            // 
            this.MetodoPago.DataPropertyName = "ClaveMetodo";
            this.MetodoPago.HeaderText = "Método de pago";
            this.MetodoPago.Name = "MetodoPago";
            this.MetodoPago.ReadOnly = true;
            // 
            // mdlFormaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dgvFormaPago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "mdlFormaPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Método de pago";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mdlFormaPago_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormaPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFormaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prefijo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Letra;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetodoPago;
    }
}