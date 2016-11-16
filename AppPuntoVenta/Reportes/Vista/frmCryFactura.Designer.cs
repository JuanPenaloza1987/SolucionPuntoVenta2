namespace SRATAPV.Reportes.Vista
{
    partial class frmCryFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCryFactura));
            this.crvFactura = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvFactura
            // 
            this.crvFactura.ActiveViewIndex = -1;
            this.crvFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvFactura.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvFactura.Location = new System.Drawing.Point(0, 0);
            this.crvFactura.Name = "crvFactura";
            this.crvFactura.Size = new System.Drawing.Size(861, 561);
            this.crvFactura.TabIndex = 0;
            this.crvFactura.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmCryFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 561);
            this.Controls.Add(this.crvFactura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCryFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.frmCryFactura_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvFactura;
    }
}