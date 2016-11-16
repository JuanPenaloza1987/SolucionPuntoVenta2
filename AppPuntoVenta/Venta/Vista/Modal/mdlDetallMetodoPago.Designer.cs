namespace AppPuntoVenta.Venta.Vista.Modal
{
    partial class mdlDetallMetodoPago
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
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTituloDetalle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblNoAplica = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.cmbDetalle = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoPago.Location = new System.Drawing.Point(141, 29);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(115, 20);
            this.lblMetodoPago.TabIndex = 0;
            this.lblMetodoPago.Text = "lblMetodoPago";
            this.lblMetodoPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Método:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloDetalle
            // 
            this.lblTituloDetalle.AutoSize = true;
            this.lblTituloDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDetalle.Location = new System.Drawing.Point(72, 63);
            this.lblTituloDetalle.Name = "lblTituloDetalle";
            this.lblTituloDetalle.Size = new System.Drawing.Size(63, 20);
            this.lblTituloDetalle.TabIndex = 2;
            this.lblTituloDetalle.Text = "Detalle:";
            this.lblTituloDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Monto:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(137, 100);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 26);
            this.txtMonto.TabIndex = 4;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // lblNoAplica
            // 
            this.lblNoAplica.AutoSize = true;
            this.lblNoAplica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAplica.Location = new System.Drawing.Point(141, 63);
            this.lblNoAplica.Name = "lblNoAplica";
            this.lblNoAplica.Size = new System.Drawing.Size(35, 20);
            this.lblNoAplica.TabIndex = 5;
            this.lblNoAplica.Text = "N/A";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalle.Location = new System.Drawing.Point(137, 60);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(100, 26);
            this.txtDetalle.TabIndex = 6;
            this.txtDetalle.Visible = false;
            // 
            // cmbDetalle
            // 
            this.cmbDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDetalle.FormattingEnabled = true;
            this.cmbDetalle.Location = new System.Drawing.Point(137, 60);
            this.cmbDetalle.Name = "cmbDetalle";
            this.cmbDetalle.Size = new System.Drawing.Size(121, 28);
            this.cmbDetalle.TabIndex = 7;
            this.cmbDetalle.Visible = false;
            // 
            // mdlDetallMetodoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 141);
            this.Controls.Add(this.cmbDetalle);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.lblNoAplica);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTituloDetalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMetodoPago);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(335, 180);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(335, 180);
            this.Name = "mdlDetallMetodoPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle de método de pago";
            this.Load += new System.EventHandler(this.mdlDetallMetodoPago_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mdlDetallMetodoPago_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTituloDetalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblNoAplica;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.ComboBox cmbDetalle;
    }
}