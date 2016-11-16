namespace AppPuntoVenta
{
    partial class mdlBusquedaProducto
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatoProducto = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.NombreProducto});
            this.dgvProductos.Location = new System.Drawing.Point(12, 60);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(560, 239);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProductos_KeyDown);
            this.dgvProductos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvProductos_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dato del producto:";
            // 
            // txtDatoProducto
            // 
            this.txtDatoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatoProducto.Location = new System.Drawing.Point(227, 15);
            this.txtDatoProducto.Name = "txtDatoProducto";
            this.txtDatoProducto.Size = new System.Drawing.Size(149, 26);
            this.txtDatoProducto.TabIndex = 2;
            this.txtDatoProducto.TextChanged += new System.EventHandler(this.txtDatoProducto_TextChanged);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "ClaveArticulo";
            this.Codigo.FillWeight = 50F;
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.DataPropertyName = "NombreArticulo";
            this.NombreProducto.HeaderText = "Nombre de producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // mdlBusquedaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.txtDatoProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "mdlBusquedaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Búsqueda de productos";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mdlBusquedaProducto_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
    }
}