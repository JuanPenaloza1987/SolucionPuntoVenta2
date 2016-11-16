namespace AppPuntoVenta.Configuraciones
{
    partial class frmConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCaja = new System.Windows.Forms.TextBox();
            this.txtImpresora = new System.Windows.Forms.TextBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtMac = new System.Windows.Forms.TextBox();
            this.btnListo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLogo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Impresora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección MAC:";
            // 
            // txtCaja
            // 
            this.txtCaja.Location = new System.Drawing.Point(102, 68);
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Size = new System.Drawing.Size(146, 20);
            this.txtCaja.TabIndex = 4;
            // 
            // txtImpresora
            // 
            this.txtImpresora.Location = new System.Drawing.Point(102, 94);
            this.txtImpresora.Name = "txtImpresora";
            this.txtImpresora.Size = new System.Drawing.Size(146, 20);
            this.txtImpresora.TabIndex = 5;
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(102, 120);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(146, 20);
            this.txtIp.TabIndex = 6;
            // 
            // txtMac
            // 
            this.txtMac.Location = new System.Drawing.Point(102, 146);
            this.txtMac.Name = "txtMac";
            this.txtMac.Size = new System.Drawing.Size(146, 20);
            this.txtMac.TabIndex = 7;
            // 
            // btnListo
            // 
            this.btnListo.Location = new System.Drawing.Point(173, 224);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(75, 23);
            this.btnListo.TabIndex = 8;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = true;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(68, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Configuración inicial";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Logo de ticket: ";
            // 
            // txtLogo
            // 
            this.txtLogo.Enabled = false;
            this.txtLogo.Location = new System.Drawing.Point(102, 171);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.ReadOnly = true;
            this.txtLogo.Size = new System.Drawing.Size(146, 20);
            this.txtLogo.TabIndex = 12;
            this.txtLogo.Text = "C:\\STRATA_POS\\Logo.jpg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "*El logo debe de estar en esta ruta, si no,\r\n no se mostrara en el ticket.";
            // 
            // frmConfiguracion
            // 
            this.AcceptButton = this.btnListo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 259);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLogo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.txtMac);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.txtImpresora);
            this.Controls.Add(this.txtCaja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuración";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCaja;
        private System.Windows.Forms.TextBox txtImpresora;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtMac;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLogo;
        private System.Windows.Forms.Label label7;
    }
}