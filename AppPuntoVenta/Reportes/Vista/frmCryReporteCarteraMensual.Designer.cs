namespace SRATAPV.Reportes.Vista
{
    partial class frmCryReporteCarteraMensual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCryReporteCarteraMensual));
            this.crvMes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crvDesglose = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crvCoordinador = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvMes
            // 
            this.crvMes.ActiveViewIndex = -1;
            this.crvMes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvMes.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvMes.Location = new System.Drawing.Point(332, 111);
            this.crvMes.Name = "crvMes";
            this.crvMes.Size = new System.Drawing.Size(169, 179);
            this.crvMes.TabIndex = 2;
            this.crvMes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvMes.Visible = false;
            // 
            // crvDesglose
            // 
            this.crvDesglose.ActiveViewIndex = -1;
            this.crvDesglose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDesglose.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDesglose.Location = new System.Drawing.Point(157, 111);
            this.crvDesglose.Name = "crvDesglose";
            this.crvDesglose.Size = new System.Drawing.Size(169, 179);
            this.crvDesglose.TabIndex = 3;
            this.crvDesglose.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvDesglose.Visible = false;
            // 
            // crvCoordinador
            // 
            this.crvCoordinador.ActiveViewIndex = -1;
            this.crvCoordinador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCoordinador.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCoordinador.Location = new System.Drawing.Point(507, 111);
            this.crvCoordinador.Name = "crvCoordinador";
            this.crvCoordinador.Size = new System.Drawing.Size(169, 179);
            this.crvCoordinador.TabIndex = 4;
            this.crvCoordinador.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvCoordinador.Visible = false;
            // 
            // frmCryReporteCarteraMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 561);
            this.Controls.Add(this.crvCoordinador);
            this.Controls.Add(this.crvDesglose);
            this.Controls.Add(this.crvMes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCryReporteCarteraMensual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calidad de cartera mensual";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCryReporteCarteraMensual_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvMes;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDesglose;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCoordinador;
    }
}