namespace SRATAPV.Reportes.Vista
{
    partial class frmCryReporteCarteraSemanal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCryReporteCarteraSemanal));
            this.crvReporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReporte
            // 
            this.crvReporte.ActiveViewIndex = -1;
            this.crvReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReporte.Location = new System.Drawing.Point(0, 0);
            this.crvReporte.Name = "crvReporte";
            this.crvReporte.Size = new System.Drawing.Size(861, 561);
            this.crvReporte.TabIndex = 0;
            this.crvReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmCryReporteCarteraSemanal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 561);
            this.Controls.Add(this.crvReporte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCryReporteCarteraSemanal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calidad de cartera semanal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCryReporteCarteraSemanal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReporte;
    }
}