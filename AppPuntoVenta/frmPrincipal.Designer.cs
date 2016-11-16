namespace AppPuntoVenta
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.paquetesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aperturaDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corteDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.métodosDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paquetesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.paqueteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promocionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promocionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configruaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stsVenta = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlblTituloUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlblibre = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            this.menuPrincipal.SuspendLayout();
            this.stsVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paquetesToolStripMenuItem,
            this.paquetesToolStripMenuItem1,
            this.promocionesToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.aToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(784, 24);
            this.menuPrincipal.TabIndex = 3;
            this.menuPrincipal.Text = "menuStrip1";
            this.menuPrincipal.Visible = false;
            // 
            // paquetesToolStripMenuItem
            // 
            this.paquetesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aperturaDeCajaToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.corteDeCajaToolStripMenuItem,
            this.métodosDePagoToolStripMenuItem});
            this.paquetesToolStripMenuItem.Name = "paquetesToolStripMenuItem";
            this.paquetesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.paquetesToolStripMenuItem.Text = "Ventas";
            // 
            // aperturaDeCajaToolStripMenuItem
            // 
            this.aperturaDeCajaToolStripMenuItem.AccessibleName = "frmAperturaCaja";
            this.aperturaDeCajaToolStripMenuItem.Name = "aperturaDeCajaToolStripMenuItem";
            this.aperturaDeCajaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.aperturaDeCajaToolStripMenuItem.Text = "Apertura de caja";
            this.aperturaDeCajaToolStripMenuItem.Click += new System.EventHandler(this.aperturaDeCajaToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.AccessibleName = "frmVenta";
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ventasToolStripMenuItem.Text = "Venta";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // corteDeCajaToolStripMenuItem
            // 
            this.corteDeCajaToolStripMenuItem.AccessibleName = "frmCorteCaja";
            this.corteDeCajaToolStripMenuItem.Name = "corteDeCajaToolStripMenuItem";
            this.corteDeCajaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.corteDeCajaToolStripMenuItem.Text = "Corte de caja";
            this.corteDeCajaToolStripMenuItem.Click += new System.EventHandler(this.corteDeCajaToolStripMenuItem_Click);
            // 
            // métodosDePagoToolStripMenuItem
            // 
            this.métodosDePagoToolStripMenuItem.AccessibleName = "frmConfMetodoPago";
            this.métodosDePagoToolStripMenuItem.Name = "métodosDePagoToolStripMenuItem";
            this.métodosDePagoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.métodosDePagoToolStripMenuItem.Text = "Métodos de pago";
            this.métodosDePagoToolStripMenuItem.Click += new System.EventHandler(this.métodosDePagoToolStripMenuItem_Click);
            // 
            // paquetesToolStripMenuItem1
            // 
            this.paquetesToolStripMenuItem1.AccessibleName = "";
            this.paquetesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paqueteToolStripMenuItem});
            this.paquetesToolStripMenuItem1.Name = "paquetesToolStripMenuItem1";
            this.paquetesToolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.paquetesToolStripMenuItem1.Text = "Paquetes";
            // 
            // paqueteToolStripMenuItem
            // 
            this.paqueteToolStripMenuItem.AccessibleName = "frmPaquete";
            this.paqueteToolStripMenuItem.Name = "paqueteToolStripMenuItem";
            this.paqueteToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.paqueteToolStripMenuItem.Text = "Paquete";
            this.paqueteToolStripMenuItem.Click += new System.EventHandler(this.paqueteToolStripMenuItem_Click);
            // 
            // promocionesToolStripMenuItem
            // 
            this.promocionesToolStripMenuItem.AccessibleName = "";
            this.promocionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promocionToolStripMenuItem});
            this.promocionesToolStripMenuItem.Name = "promocionesToolStripMenuItem";
            this.promocionesToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.promocionesToolStripMenuItem.Text = "Promociones";
            // 
            // promocionToolStripMenuItem
            // 
            this.promocionToolStripMenuItem.AccessibleName = "frmPromocion";
            this.promocionToolStripMenuItem.Name = "promocionToolStripMenuItem";
            this.promocionToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.promocionToolStripMenuItem.Text = "Promocion";
            this.promocionToolStripMenuItem.Click += new System.EventHandler(this.promocionToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.AccessibleName = "";
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configruaciónToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // configruaciónToolStripMenuItem
            // 
            this.configruaciónToolStripMenuItem.AccessibleName = "frmConfiguracion";
            this.configruaciónToolStripMenuItem.Name = "configruaciónToolStripMenuItem";
            this.configruaciónToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.configruaciónToolStripMenuItem.Text = "Configuración";
            this.configruaciónToolStripMenuItem.Click += new System.EventHandler(this.configruaciónToolStripMenuItem_Click);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.aToolStripMenuItem.Text = "Acerca de";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // stsVenta
            // 
            this.stsVenta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tlblVersion,
            this.tlblTituloUsuario,
            this.tlblUsuario,
            this.tlblibre,
            this.tlblFecha});
            this.stsVenta.Location = new System.Drawing.Point(0, 539);
            this.stsVenta.Name = "stsVenta";
            this.stsVenta.Size = new System.Drawing.Size(784, 22);
            this.stsVenta.TabIndex = 11;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel1.Text = "Versión:";
            // 
            // tlblVersion
            // 
            this.tlblVersion.Name = "tlblVersion";
            this.tlblVersion.Size = new System.Drawing.Size(0, 17);
            // 
            // tlblTituloUsuario
            // 
            this.tlblTituloUsuario.Name = "tlblTituloUsuario";
            this.tlblTituloUsuario.Size = new System.Drawing.Size(50, 17);
            this.tlblTituloUsuario.Text = "Usuario:";
            // 
            // tlblUsuario
            // 
            this.tlblUsuario.Name = "tlblUsuario";
            this.tlblUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // tlblibre
            // 
            this.tlblibre.Name = "tlblibre";
            this.tlblibre.Size = new System.Drawing.Size(671, 17);
            this.tlblibre.Spring = true;
            this.tlblibre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlblFecha
            // 
            this.tlblFecha.Name = "tlblFecha";
            this.tlblFecha.Size = new System.Drawing.Size(0, 17);
            // 
            // tmrReloj
            // 
            this.tmrReloj.Enabled = true;
            this.tmrReloj.Tick += new System.EventHandler(this.tmrReloj_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.stsVenta);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STRATA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.stsVenta.ResumeLayout(false);
            this.stsVenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paquetesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aperturaDeCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corteDeCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paquetesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem promocionesToolStripMenuItem;
        public System.Windows.Forms.StatusStrip stsVenta;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tlblVersion;
        private System.Windows.Forms.ToolStripStatusLabel tlblTituloUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tlblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tlblibre;
        private System.Windows.Forms.ToolStripStatusLabel tlblFecha;
        private System.Windows.Forms.Timer tmrReloj;
        private System.Windows.Forms.ToolStripMenuItem métodosDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paqueteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promocionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configruaciónToolStripMenuItem;
    }
}