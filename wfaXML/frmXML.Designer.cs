namespace wfaXML
{
    partial class frmXML
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXML));
            this.tmrXML = new System.Windows.Forms.Timer(this.components);
            this.ntfXML = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // tmrXML
            // 
            this.tmrXML.Interval = 10000;
            this.tmrXML.Tick += new System.EventHandler(this.tmrXML_Tick);
            // 
            // ntfXML
            // 
            this.ntfXML.Text = "Creación de XML";
            this.ntfXML.Visible = true;
            this.ntfXML.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntfXML_MouseDoubleClick);
            // 
            // frmXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 164);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmXML";
            this.Text = "Creación de XML";
            this.Load += new System.EventHandler(this.frmXML_Load);
            this.Resize += new System.EventHandler(this.frmXML_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrXML;
        private System.Windows.Forms.NotifyIcon ntfXML;
    }
}

