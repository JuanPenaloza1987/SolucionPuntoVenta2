namespace SRATAPV.Reportes.Vista
{
    partial class frmCryCotizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCryCotizacion));
            this.crvCotizacion = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvCotizacion
            // 
            this.crvCotizacion.ActiveViewIndex = -1;
            this.crvCotizacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCotizacion.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCotizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCotizacion.Location = new System.Drawing.Point(0, 0);
            this.crvCotizacion.Name = "crvCotizacion";
            this.crvCotizacion.Size = new System.Drawing.Size(861, 561);
            this.crvCotizacion.TabIndex = 0;
            this.crvCotizacion.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmCryCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 561);
            this.Controls.Add(this.crvCotizacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCryCotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotización";
            this.Load += new System.EventHandler(this.frmCryCotizacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCotizacion;
    }
}