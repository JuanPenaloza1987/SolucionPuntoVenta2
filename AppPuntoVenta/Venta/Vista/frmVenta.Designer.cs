namespace AppPuntoVenta
{
    partial class frmVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClaveProducto = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaveArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbImagen = new System.Windows.Forms.GroupBox();
            this.imgProducto = new System.Windows.Forms.PictureBox();
            this.grbTotal = new System.Windows.Forms.GroupBox();
            this.txtFaltaPAgar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTipoCambio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOtrosPagos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCambioPrecio = new System.Windows.Forms.Button();
            this.btnTipoCambio = new System.Windows.Forms.Button();
            this.btnFormasPago = new System.Windows.Forms.Button();
            this.btnBusquedaArt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.grbImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProducto)).BeginInit();
            this.grbTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(103, 12);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(99, 25);
            this.lblClave.TabIndex = 6;
            this.lblClave.Text = "CÓDIGO:";
            // 
            // txtClaveProducto
            // 
            this.txtClaveProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveProducto.Location = new System.Drawing.Point(208, 12);
            this.txtClaveProducto.Name = "txtClaveProducto";
            this.txtClaveProducto.Size = new System.Drawing.Size(155, 30);
            this.txtClaveProducto.TabIndex = 5;
            this.txtClaveProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClaveProducto_KeyDown);
            this.txtClaveProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtClaveProducto_KeyUp);
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Precio,
            this.Cantidad,
            this.Monto,
            this.Column1,
            this.CodigoBarras,
            this.ClaveArticulo});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvProductos.Enabled = false;
            this.dgvProductos.Location = new System.Drawing.Point(91, 48);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowTemplate.Height = 25;
            this.dgvProductos.Size = new System.Drawing.Size(444, 451);
            this.dgvProductos.TabIndex = 7;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombreArticulo";
            this.Nombre.FillWeight = 500F;
            this.Nombre.HeaderText = "Producto";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle22.Format = "N2";
            dataGridViewCellStyle22.NullValue = null;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle22;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 8;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "monto";
            dataGridViewCellStyle23.Format = "N2";
            dataGridViewCellStyle23.NullValue = null;
            this.Monto.DefaultCellStyle = dataGridViewCellStyle23;
            this.Monto.HeaderText = "Monto";
            this.Monto.MinimumWidth = 8;
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "HayPromocion";
            this.Column1.HeaderText = "Promo";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CodigoBarras
            // 
            this.CodigoBarras.HeaderText = "CodigoBarras";
            this.CodigoBarras.Name = "CodigoBarras";
            this.CodigoBarras.Visible = false;
            // 
            // ClaveArticulo
            // 
            this.ClaveArticulo.HeaderText = "ClaveArticulo";
            this.ClaveArticulo.Name = "ClaveArticulo";
            this.ClaveArticulo.Visible = false;
            // 
            // grbImagen
            // 
            this.grbImagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbImagen.AutoSize = true;
            this.grbImagen.Controls.Add(this.imgProducto);
            this.grbImagen.Location = new System.Drawing.Point(541, 12);
            this.grbImagen.Name = "grbImagen";
            this.grbImagen.Size = new System.Drawing.Size(231, 198);
            this.grbImagen.TabIndex = 8;
            this.grbImagen.TabStop = false;
            // 
            // imgProducto
            // 
            this.imgProducto.Image = ((System.Drawing.Image)(resources.GetObject("imgProducto.Image")));
            this.imgProducto.Location = new System.Drawing.Point(50, 19);
            this.imgProducto.Name = "imgProducto";
            this.imgProducto.Size = new System.Drawing.Size(160, 160);
            this.imgProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgProducto.TabIndex = 0;
            this.imgProducto.TabStop = false;
            // 
            // grbTotal
            // 
            this.grbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbTotal.Controls.Add(this.txtFaltaPAgar);
            this.grbTotal.Controls.Add(this.label6);
            this.grbTotal.Controls.Add(this.lblTipoCambio);
            this.grbTotal.Controls.Add(this.label4);
            this.grbTotal.Controls.Add(this.txtOtrosPagos);
            this.grbTotal.Controls.Add(this.label5);
            this.grbTotal.Controls.Add(this.txtEfectivo);
            this.grbTotal.Controls.Add(this.txtCambio);
            this.grbTotal.Controls.Add(this.Label3);
            this.grbTotal.Controls.Add(this.Label2);
            this.grbTotal.Controls.Add(this.txtTotal);
            this.grbTotal.Controls.Add(this.btnVender);
            this.grbTotal.Controls.Add(this.Label1);
            this.grbTotal.Location = new System.Drawing.Point(541, 205);
            this.grbTotal.Name = "grbTotal";
            this.grbTotal.Size = new System.Drawing.Size(231, 294);
            this.grbTotal.TabIndex = 9;
            this.grbTotal.TabStop = false;
            this.grbTotal.Text = "Pago";
            // 
            // txtFaltaPAgar
            // 
            this.txtFaltaPAgar.BackColor = System.Drawing.SystemColors.Menu;
            this.txtFaltaPAgar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaltaPAgar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtFaltaPAgar.Location = new System.Drawing.Point(102, 82);
            this.txtFaltaPAgar.Name = "txtFaltaPAgar";
            this.txtFaltaPAgar.ReadOnly = true;
            this.txtFaltaPAgar.Size = new System.Drawing.Size(129, 30);
            this.txtFaltaPAgar.TabIndex = 15;
            this.txtFaltaPAgar.Text = "0.00";
            this.txtFaltaPAgar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "POR PAGAR:";
            // 
            // lblTipoCambio
            // 
            this.lblTipoCambio.AutoSize = true;
            this.lblTipoCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCambio.ForeColor = System.Drawing.Color.Blue;
            this.lblTipoCambio.Location = new System.Drawing.Point(127, 156);
            this.lblTipoCambio.Name = "lblTipoCambio";
            this.lblTipoCambio.Size = new System.Drawing.Size(40, 17);
            this.lblTipoCambio.TabIndex = 13;
            this.lblTipoCambio.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tipo de cambio: ";
            // 
            // txtOtrosPagos
            // 
            this.txtOtrosPagos.BackColor = System.Drawing.SystemColors.Menu;
            this.txtOtrosPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtrosPagos.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtOtrosPagos.Location = new System.Drawing.Point(102, 46);
            this.txtOtrosPagos.Name = "txtOtrosPagos";
            this.txtOtrosPagos.ReadOnly = true;
            this.txtOtrosPagos.Size = new System.Drawing.Size(129, 30);
            this.txtOtrosPagos.TabIndex = 11;
            this.txtOtrosPagos.Text = "0.00";
            this.txtOtrosPagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "PAGOS:";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.BackColor = System.Drawing.SystemColors.Info;
            this.txtEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtEfectivo.Location = new System.Drawing.Point(102, 118);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(129, 30);
            this.txtEfectivo.TabIndex = 7;
            this.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEfectivo.TextChanged += new System.EventHandler(this.txtEfectivo_TextChanged);
            this.txtEfectivo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEfectivo_KeyDown);
            // 
            // txtCambio
            // 
            this.txtCambio.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtCambio.Location = new System.Drawing.Point(102, 176);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(129, 30);
            this.txtCambio.TabIndex = 6;
            this.txtCambio.Text = "0.00";
            this.txtCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(8, 128);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(79, 17);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "EFECTIVO:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(8, 186);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 17);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "CAMBIO:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Green;
            this.txtTotal.Location = new System.Drawing.Point(102, 13);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(129, 30);
            this.txtTotal.TabIndex = 3;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnVender
            // 
            this.btnVender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVender.Location = new System.Drawing.Point(6, 244);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(219, 44);
            this.btnVender.TabIndex = 2;
            this.btnVender.Text = "PAGAR";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(6, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(85, 25);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "TOTAL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(369, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "*Preciona F1 para obtener ayuda.";
            // 
            // btnCambioPrecio
            // 
            this.btnCambioPrecio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCambioPrecio.BackgroundImage")));
            this.btnCambioPrecio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCambioPrecio.Location = new System.Drawing.Point(12, 287);
            this.btnCambioPrecio.Name = "btnCambioPrecio";
            this.btnCambioPrecio.Size = new System.Drawing.Size(73, 66);
            this.btnCambioPrecio.TabIndex = 19;
            this.btnCambioPrecio.UseMnemonic = false;
            this.btnCambioPrecio.UseVisualStyleBackColor = true;
            this.btnCambioPrecio.Click += new System.EventHandler(this.btnCambioPrecio_Click);
            this.btnCambioPrecio.MouseHover += new System.EventHandler(this.btnCambioPrecio_MouseHover);
            // 
            // btnTipoCambio
            // 
            this.btnTipoCambio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTipoCambio.BackgroundImage")));
            this.btnTipoCambio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTipoCambio.Location = new System.Drawing.Point(12, 205);
            this.btnTipoCambio.Name = "btnTipoCambio";
            this.btnTipoCambio.Size = new System.Drawing.Size(73, 73);
            this.btnTipoCambio.TabIndex = 18;
            this.btnTipoCambio.UseMnemonic = false;
            this.btnTipoCambio.UseVisualStyleBackColor = true;
            this.btnTipoCambio.Click += new System.EventHandler(this.btnTipoCambio_Click);
            this.btnTipoCambio.MouseHover += new System.EventHandler(this.btnTipoCambio_MouseHover);
            // 
            // btnFormasPago
            // 
            this.btnFormasPago.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFormasPago.BackgroundImage")));
            this.btnFormasPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFormasPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFormasPago.Location = new System.Drawing.Point(12, 122);
            this.btnFormasPago.Name = "btnFormasPago";
            this.btnFormasPago.Size = new System.Drawing.Size(73, 69);
            this.btnFormasPago.TabIndex = 17;
            this.btnFormasPago.UseMnemonic = false;
            this.btnFormasPago.UseVisualStyleBackColor = true;
            this.btnFormasPago.Click += new System.EventHandler(this.btnFormasPago_Click);
            this.btnFormasPago.MouseHover += new System.EventHandler(this.btnFormasPago_MouseHover);
            // 
            // btnBusquedaArt
            // 
            this.btnBusquedaArt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBusquedaArt.BackgroundImage")));
            this.btnBusquedaArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBusquedaArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBusquedaArt.Location = new System.Drawing.Point(12, 40);
            this.btnBusquedaArt.Name = "btnBusquedaArt";
            this.btnBusquedaArt.Size = new System.Drawing.Size(73, 67);
            this.btnBusquedaArt.TabIndex = 12;
            this.btnBusquedaArt.UseMnemonic = false;
            this.btnBusquedaArt.UseVisualStyleBackColor = true;
            this.btnBusquedaArt.Click += new System.EventHandler(this.btnBusquedaArt_Click);
            this.btnBusquedaArt.MouseHover += new System.EventHandler(this.btnBusquedaArt_MouseHover);
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.btnCambioPrecio);
            this.Controls.Add(this.btnTipoCambio);
            this.Controls.Add(this.btnFormasPago);
            this.Controls.Add(this.btnBusquedaArt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grbTotal);
            this.Controls.Add(this.grbImagen);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtClaveProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "frmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Venta";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmVenta_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.grbImagen.ResumeLayout(false);
            this.grbImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProducto)).EndInit();
            this.grbTotal.ResumeLayout(false);
            this.grbTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblClave;
        internal System.Windows.Forms.TextBox txtClaveProducto;
        internal System.Windows.Forms.DataGridView dgvProductos;
        internal System.Windows.Forms.GroupBox grbImagen;
        internal System.Windows.Forms.PictureBox imgProducto;
        internal System.Windows.Forms.GroupBox grbTotal;
        internal System.Windows.Forms.TextBox txtEfectivo;
        internal System.Windows.Forms.TextBox txtCambio;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.Button btnVender;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtOtrosPagos;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTipoCambio;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtFaltaPAgar;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveArticulo;
        private System.Windows.Forms.Button btnCambioPrecio;
        private System.Windows.Forms.Button btnTipoCambio;
        private System.Windows.Forms.Button btnFormasPago;
        private System.Windows.Forms.Button btnBusquedaArt;
    }
}