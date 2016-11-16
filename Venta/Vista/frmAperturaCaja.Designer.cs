namespace SRATAPV.Ventas.Vista
{
    partial class frmAperturaCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAperturaCaja));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFondoCaja = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtCaja = new System.Windows.Forms.TextBox();
            this.txtCajero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cajero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fondo de caja:";
            // 
            // txtFondoCaja
            // 
            this.txtFondoCaja.Location = new System.Drawing.Point(93, 86);
            this.txtFondoCaja.Name = "txtFondoCaja";
            this.txtFondoCaja.Size = new System.Drawing.Size(205, 20);
            this.txtFondoCaja.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Caja:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(223, 123);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtCaja
            // 
            this.txtCaja.Enabled = false;
            this.txtCaja.Location = new System.Drawing.Point(93, 12);
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Size = new System.Drawing.Size(205, 20);
            this.txtCaja.TabIndex = 23;
            // 
            // txtCajero
            // 
            this.txtCajero.Enabled = false;
            this.txtCajero.Location = new System.Drawing.Point(93, 48);
            this.txtCajero.Name = "txtCajero";
            this.txtCajero.Size = new System.Drawing.Size(205, 20);
            this.txtCajero.TabIndex = 24;
            // 
            // frmAperturaCaja
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(310, 164);
            this.Controls.Add(this.txtCajero);
            this.Controls.Add(this.txtCaja);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFondoCaja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(326, 203);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(326, 203);
            this.Name = "frmAperturaCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fondo de caja";
            this.Load += new System.EventHandler(this.frmAperturaCaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFondoCaja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtCaja;
        private System.Windows.Forms.TextBox txtCajero;
    }
}