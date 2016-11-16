namespace AppPuntoVenta.Promocion.Vista
{
    partial class frmDetallePromocion
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtCodigoPromocion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPromociones = new System.Windows.Forms.TabControl();
            this.tbcxc = new System.Windows.Forms.TabPage();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.part_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.art_descripc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxCxC = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescPor = new System.Windows.Forms.TabPage();
            this.dgvDescuentoPor = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescPor = new System.Windows.Forms.TextBox();
            this.tbDescImp = new System.Windows.Forms.TabPage();
            this.dgvDescuentoImp = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescImp = new System.Windows.Forms.TextBox();
            this.tbPrecioFijo = new System.Windows.Forms.TabPage();
            this.dgvPrecioFijo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecioFijo = new System.Windows.Forms.TextBox();
            this.tbRegalo = new System.Windows.Forms.TabPage();
            this.dgvRegalo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvNecesarios = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnBuscarProductoPor = new System.Windows.Forms.Button();
            this.btnBuscarProductoImp = new System.Windows.Forms.Button();
            this.btnBuscarProductoFijo = new System.Windows.Forms.Button();
            this.btnProductoReg = new System.Windows.Forms.Button();
            this.btnProductoNec = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.tbPromociones.SuspendLayout();
            this.tbcxc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.ctxCxC.SuspendLayout();
            this.tbDescPor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentoPor)).BeginInit();
            this.tbDescImp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentoImp)).BeginInit();
            this.tbPrecioFijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecioFijo)).BeginInit();
            this.tbRegalo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegalo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNecesarios)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(557, 25);
            this.toolStrip1.TabIndex = 67;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtCodigoPromocion
            // 
            this.txtCodigoPromocion.Location = new System.Drawing.Point(78, 28);
            this.txtCodigoPromocion.Name = "txtCodigoPromocion";
            this.txtCodigoPromocion.ReadOnly = true;
            this.txtCodigoPromocion.Size = new System.Drawing.Size(137, 20);
            this.txtCodigoPromocion.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Promoción:";
            // 
            // tbPromociones
            // 
            this.tbPromociones.Controls.Add(this.tbcxc);
            this.tbPromociones.Controls.Add(this.tbDescPor);
            this.tbPromociones.Controls.Add(this.tbDescImp);
            this.tbPromociones.Controls.Add(this.tbPrecioFijo);
            this.tbPromociones.Controls.Add(this.tbRegalo);
            this.tbPromociones.Location = new System.Drawing.Point(12, 54);
            this.tbPromociones.Name = "tbPromociones";
            this.tbPromociones.SelectedIndex = 0;
            this.tbPromociones.Size = new System.Drawing.Size(533, 294);
            this.tbPromociones.TabIndex = 78;
            // 
            // tbcxc
            // 
            this.tbcxc.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbcxc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbcxc.Controls.Add(this.dgvArticulos);
            this.tbcxc.Controls.Add(this.label3);
            this.tbcxc.Controls.Add(this.btnBuscarProducto);
            this.tbcxc.Location = new System.Drawing.Point(4, 22);
            this.tbcxc.Name = "tbcxc";
            this.tbcxc.Padding = new System.Windows.Forms.Padding(3);
            this.tbcxc.Size = new System.Drawing.Size(525, 268);
            this.tbcxc.TabIndex = 0;
            this.tbcxc.Text = "# x #";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.part_cantidad,
            this.art_descripc});
            this.dgvArticulos.ContextMenuStrip = this.ctxCxC;
            this.dgvArticulos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvArticulos.Location = new System.Drawing.Point(3, 44);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(519, 221);
            this.dgvArticulos.TabIndex = 83;
            // 
            // part_cantidad
            // 
            this.part_cantidad.DataPropertyName = "Codigo";
            this.part_cantidad.FillWeight = 20F;
            this.part_cantidad.HeaderText = "Clave";
            this.part_cantidad.Name = "part_cantidad";
            this.part_cantidad.ReadOnly = true;
            // 
            // art_descripc
            // 
            this.art_descripc.DataPropertyName = "NombreArticulo";
            this.art_descripc.HeaderText = "Artículo";
            this.art_descripc.Name = "art_descripc";
            this.art_descripc.ReadOnly = true;
            // 
            // ctxCxC
            // 
            this.ctxCxC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.ctxCxC.Name = "contextMenuStrip1";
            this.ctxCxC.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ctxCxC.Size = new System.Drawing.Size(195, 26);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar seleccionados";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Artículos";
            // 
            // tbDescPor
            // 
            this.tbDescPor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbDescPor.Controls.Add(this.dgvDescuentoPor);
            this.tbDescPor.Controls.Add(this.label5);
            this.tbDescPor.Controls.Add(this.txtDescPor);
            this.tbDescPor.Controls.Add(this.btnBuscarProductoPor);
            this.tbDescPor.Location = new System.Drawing.Point(4, 22);
            this.tbDescPor.Name = "tbDescPor";
            this.tbDescPor.Padding = new System.Windows.Forms.Padding(3);
            this.tbDescPor.Size = new System.Drawing.Size(525, 268);
            this.tbDescPor.TabIndex = 1;
            this.tbDescPor.Text = "Descuento %";
            // 
            // dgvDescuentoPor
            // 
            this.dgvDescuentoPor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDescuentoPor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescuentoPor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.dgvDescuentoPor.ContextMenuStrip = this.ctxCxC;
            this.dgvDescuentoPor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDescuentoPor.Location = new System.Drawing.Point(3, 44);
            this.dgvDescuentoPor.Name = "dgvDescuentoPor";
            this.dgvDescuentoPor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDescuentoPor.Size = new System.Drawing.Size(519, 221);
            this.dgvDescuentoPor.TabIndex = 83;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn2.FillWeight = 20F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Clave";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NombreArticulo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Artículo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Artículos";
            // 
            // txtDescPor
            // 
            this.txtDescPor.Location = new System.Drawing.Point(12, 12);
            this.txtDescPor.Name = "txtDescPor";
            this.txtDescPor.Size = new System.Drawing.Size(100, 20);
            this.txtDescPor.TabIndex = 77;
            // 
            // tbDescImp
            // 
            this.tbDescImp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbDescImp.Controls.Add(this.dgvDescuentoImp);
            this.tbDescImp.Controls.Add(this.label6);
            this.tbDescImp.Controls.Add(this.txtDescImp);
            this.tbDescImp.Controls.Add(this.btnBuscarProductoImp);
            this.tbDescImp.Location = new System.Drawing.Point(4, 22);
            this.tbDescImp.Name = "tbDescImp";
            this.tbDescImp.Size = new System.Drawing.Size(525, 268);
            this.tbDescImp.TabIndex = 2;
            this.tbDescImp.Text = "Descuento $";
            // 
            // dgvDescuentoImp
            // 
            this.dgvDescuentoImp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDescuentoImp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescuentoImp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.dgvDescuentoImp.ContextMenuStrip = this.ctxCxC;
            this.dgvDescuentoImp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDescuentoImp.Location = new System.Drawing.Point(0, 47);
            this.dgvDescuentoImp.Name = "dgvDescuentoImp";
            this.dgvDescuentoImp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDescuentoImp.Size = new System.Drawing.Size(525, 221);
            this.dgvDescuentoImp.TabIndex = 84;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn4.FillWeight = 20F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Clave";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NombreArticulo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Artículo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 82;
            this.label6.Text = "Artículos";
            // 
            // txtDescImp
            // 
            this.txtDescImp.Location = new System.Drawing.Point(12, 12);
            this.txtDescImp.Name = "txtDescImp";
            this.txtDescImp.Size = new System.Drawing.Size(100, 20);
            this.txtDescImp.TabIndex = 79;
            // 
            // tbPrecioFijo
            // 
            this.tbPrecioFijo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPrecioFijo.Controls.Add(this.dgvPrecioFijo);
            this.tbPrecioFijo.Controls.Add(this.label7);
            this.tbPrecioFijo.Controls.Add(this.txtPrecioFijo);
            this.tbPrecioFijo.Controls.Add(this.btnBuscarProductoFijo);
            this.tbPrecioFijo.Location = new System.Drawing.Point(4, 22);
            this.tbPrecioFijo.Name = "tbPrecioFijo";
            this.tbPrecioFijo.Size = new System.Drawing.Size(525, 268);
            this.tbPrecioFijo.TabIndex = 3;
            this.tbPrecioFijo.Text = "Precio fijo";
            // 
            // dgvPrecioFijo
            // 
            this.dgvPrecioFijo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrecioFijo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrecioFijo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5});
            this.dgvPrecioFijo.ContextMenuStrip = this.ctxCxC;
            this.dgvPrecioFijo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPrecioFijo.Location = new System.Drawing.Point(0, 47);
            this.dgvPrecioFijo.Name = "dgvPrecioFijo";
            this.dgvPrecioFijo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrecioFijo.Size = new System.Drawing.Size(525, 221);
            this.dgvPrecioFijo.TabIndex = 84;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn6.FillWeight = 20F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Clave";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NombreArticulo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Artículo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 82;
            this.label7.Text = "Artículos";
            // 
            // txtPrecioFijo
            // 
            this.txtPrecioFijo.Location = new System.Drawing.Point(12, 12);
            this.txtPrecioFijo.Name = "txtPrecioFijo";
            this.txtPrecioFijo.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioFijo.TabIndex = 79;
            // 
            // tbRegalo
            // 
            this.tbRegalo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbRegalo.Controls.Add(this.dgvRegalo);
            this.tbRegalo.Controls.Add(this.label4);
            this.tbRegalo.Controls.Add(this.label2);
            this.tbRegalo.Controls.Add(this.dgvNecesarios);
            this.tbRegalo.Controls.Add(this.btnProductoReg);
            this.tbRegalo.Controls.Add(this.btnProductoNec);
            this.tbRegalo.Location = new System.Drawing.Point(4, 22);
            this.tbRegalo.Name = "tbRegalo";
            this.tbRegalo.Padding = new System.Windows.Forms.Padding(3);
            this.tbRegalo.Size = new System.Drawing.Size(525, 268);
            this.tbRegalo.TabIndex = 4;
            this.tbRegalo.Text = "Regalo";
            // 
            // dgvRegalo
            // 
            this.dgvRegalo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegalo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegalo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgvRegalo.ContextMenuStrip = this.ctxCxC;
            this.dgvRegalo.Location = new System.Drawing.Point(274, 44);
            this.dgvRegalo.Name = "dgvRegalo";
            this.dgvRegalo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegalo.Size = new System.Drawing.Size(251, 221);
            this.dgvRegalo.TabIndex = 91;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn9.FillWeight = 20F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Clave";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NombreArticulo";
            this.dataGridViewTextBoxColumn10.HeaderText = "Artículo";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "Artículos de regalo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "Artículos necesarios";
            // 
            // dgvNecesarios
            // 
            this.dgvNecesarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNecesarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNecesarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn7});
            this.dgvNecesarios.ContextMenuStrip = this.ctxCxC;
            this.dgvNecesarios.Location = new System.Drawing.Point(3, 44);
            this.dgvNecesarios.Name = "dgvNecesarios";
            this.dgvNecesarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNecesarios.Size = new System.Drawing.Size(251, 221);
            this.dgvNecesarios.TabIndex = 84;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn8.FillWeight = 20F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Clave";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NombreArticulo";
            this.dataGridViewTextBoxColumn7.HeaderText = "Artículo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Image = global::AppPuntoVenta.Properties.Resources.buscar_32;
            this.btnBuscarProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarProducto.Location = new System.Drawing.Point(62, 13);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(22, 20);
            this.btnBuscarProducto.TabIndex = 81;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnBuscarProductoPor
            // 
            this.btnBuscarProductoPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProductoPor.Image = global::AppPuntoVenta.Properties.Resources.buscar_32;
            this.btnBuscarProductoPor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarProductoPor.Location = new System.Drawing.Point(171, 11);
            this.btnBuscarProductoPor.Name = "btnBuscarProductoPor";
            this.btnBuscarProductoPor.Size = new System.Drawing.Size(22, 20);
            this.btnBuscarProductoPor.TabIndex = 81;
            this.btnBuscarProductoPor.UseVisualStyleBackColor = true;
            this.btnBuscarProductoPor.Click += new System.EventHandler(this.btnBuscarProductoPor_Click);
            // 
            // btnBuscarProductoImp
            // 
            this.btnBuscarProductoImp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProductoImp.Image = global::AppPuntoVenta.Properties.Resources.buscar_32;
            this.btnBuscarProductoImp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarProductoImp.Location = new System.Drawing.Point(171, 11);
            this.btnBuscarProductoImp.Name = "btnBuscarProductoImp";
            this.btnBuscarProductoImp.Size = new System.Drawing.Size(22, 20);
            this.btnBuscarProductoImp.TabIndex = 81;
            this.btnBuscarProductoImp.UseVisualStyleBackColor = true;
            this.btnBuscarProductoImp.Click += new System.EventHandler(this.btnBuscarProductoImp_Click);
            // 
            // btnBuscarProductoFijo
            // 
            this.btnBuscarProductoFijo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProductoFijo.Image = global::AppPuntoVenta.Properties.Resources.buscar_32;
            this.btnBuscarProductoFijo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarProductoFijo.Location = new System.Drawing.Point(171, 11);
            this.btnBuscarProductoFijo.Name = "btnBuscarProductoFijo";
            this.btnBuscarProductoFijo.Size = new System.Drawing.Size(22, 20);
            this.btnBuscarProductoFijo.TabIndex = 81;
            this.btnBuscarProductoFijo.UseVisualStyleBackColor = true;
            this.btnBuscarProductoFijo.Click += new System.EventHandler(this.btnBuscarProductoFijo_Click);
            // 
            // btnProductoReg
            // 
            this.btnProductoReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoReg.Image = global::AppPuntoVenta.Properties.Resources.buscar_32;
            this.btnProductoReg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnProductoReg.Location = new System.Drawing.Point(379, 14);
            this.btnProductoReg.Name = "btnProductoReg";
            this.btnProductoReg.Size = new System.Drawing.Size(22, 20);
            this.btnProductoReg.TabIndex = 88;
            this.btnProductoReg.UseVisualStyleBackColor = true;
            this.btnProductoReg.Click += new System.EventHandler(this.btnProductoReg_Click);
            // 
            // btnProductoNec
            // 
            this.btnProductoNec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoNec.Image = global::AppPuntoVenta.Properties.Resources.buscar_32;
            this.btnProductoNec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnProductoNec.Location = new System.Drawing.Point(116, 15);
            this.btnProductoNec.Name = "btnProductoNec";
            this.btnProductoNec.Size = new System.Drawing.Size(22, 20);
            this.btnProductoNec.TabIndex = 85;
            this.btnProductoNec.UseVisualStyleBackColor = true;
            this.btnProductoNec.Click += new System.EventHandler(this.btnProductoNec_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = global::AppPuntoVenta.Properties.Resources.nuevo_24;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(23, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = global::AppPuntoVenta.Properties.Resources.guardar_24;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(23, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = global::AppPuntoVenta.Properties.Resources.cancelar_32;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmDetallePromocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 360);
            this.Controls.Add(this.tbPromociones);
            this.Controls.Add(this.txtCodigoPromocion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDetallePromocion";
            this.Text = "Detalle de promoción";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tbPromociones.ResumeLayout(false);
            this.tbcxc.ResumeLayout(false);
            this.tbcxc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ctxCxC.ResumeLayout(false);
            this.tbDescPor.ResumeLayout(false);
            this.tbDescPor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentoPor)).EndInit();
            this.tbDescImp.ResumeLayout(false);
            this.tbDescImp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentoImp)).EndInit();
            this.tbPrecioFijo.ResumeLayout(false);
            this.tbPrecioFijo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecioFijo)).EndInit();
            this.tbRegalo.ResumeLayout(false);
            this.tbRegalo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegalo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNecesarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.TextBox txtCodigoPromocion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbPromociones;
        private System.Windows.Forms.TabPage tbcxc;
        private System.Windows.Forms.TabPage tbDescPor;
        private System.Windows.Forms.TabPage tbDescImp;
        private System.Windows.Forms.TabPage tbPrecioFijo;
        private System.Windows.Forms.TextBox txtDescPor;
        private System.Windows.Forms.TextBox txtDescImp;
        private System.Windows.Forms.TextBox txtPrecioFijo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarProductoPor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarProductoImp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscarProductoFijo;
        private System.Windows.Forms.TabPage tbRegalo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.DataGridView dgvDescuentoPor;
        private System.Windows.Forms.DataGridView dgvDescuentoImp;
        private System.Windows.Forms.DataGridView dgvPrecioFijo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProductoReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProductoNec;
        private System.Windows.Forms.DataGridViewTextBoxColumn part_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn art_descripc;
        private System.Windows.Forms.ContextMenuStrip ctxCxC;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvRegalo;
        private System.Windows.Forms.DataGridView dgvNecesarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}