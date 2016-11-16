namespace SRATAPV.Reportes.Vista
{
    partial class frmRepFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepFactura));
            this.rvwFactura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvwFactura
            // 
            resources.ApplyResources(this.rvwFactura, "rvwFactura");
            this.rvwFactura.LocalReport.ReportEmbeddedResource = "SRATAPV.Reportes.Reporte.repFactura.rdlc";
            this.rvwFactura.Name = "rvwFactura";
            // 
            // frmRepFactura
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.rvwFactura);
            this.Name = "frmRepFactura";
            this.Load += new System.EventHandler(this.frmRepFactura_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvwFactura;
    }
}