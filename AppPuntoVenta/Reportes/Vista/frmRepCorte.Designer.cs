﻿namespace SRATAPV.Reportes.Vista
{
    partial class frmRepCorte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepCorte));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            resources.ApplyResources(this.reportViewer1, "reportViewer1");
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SRATAPV.Reportes.Reporte.repCorteCaja.rdlc";
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.ShowZoomControl = false;
            // 
            // frmRepCorte
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRepCorte";
            this.Load += new System.EventHandler(this.frmRepCorte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}