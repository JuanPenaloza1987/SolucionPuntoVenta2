namespace SRATAPV.Reportes.Formas
{
    partial class frmReporteVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteVentas));
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbFecha = new System.Windows.Forms.RadioButton();
            this.rdbVenta = new System.Windows.Forms.RadioButton();
            this.rdbCliente = new System.Windows.Forms.RadioButton();
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnCrear = new System.Windows.Forms.ToolStripButton();
            this.btnPreeliminar = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeModificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioModifica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentajeDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Corte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetodoDePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVentas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Venta,
            this.Usuario,
            this.Cliente,
            this.Estado,
            this.FechaDeDocumento,
            this.FechaDeRegistro,
            this.FechaDeModificacion,
            this.UsuarioModifica,
            this.Subtotal,
            this.PorcentajeDescuento,
            this.Descuento,
            this.IVA,
            this.Total,
            this.Comentarios,
            this.Cotizacion,
            this.Corte,
            this.MetodoDePago,
            this.Detalle,
            this.Referencia,
            this.Pago,
            this.UUID});
            this.dgvVentas.Location = new System.Drawing.Point(6, 19);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.Size = new System.Drawing.Size(833, 319);
            this.dgvVentas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(233, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliente.Location = new System.Drawing.Point(283, 38);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(247, 20);
            this.txtCliente.TabIndex = 3;
            this.txtCliente.Enter += new System.EventHandler(this.txtCliente_Enter);
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            this.txtCliente.Leave += new System.EventHandler(this.txtCliente_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbEstado);
            this.groupBox1.Controls.Add(this.rdbFecha);
            this.groupBox1.Controls.Add(this.rdbVenta);
            this.groupBox1.Controls.Add(this.rdbCliente);
            this.groupBox1.Controls.Add(this.txtVenta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpHasta);
            this.groupBox1.Controls.Add(this.dtpDesde);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBuscaCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // rdbFecha
            // 
            this.rdbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbFecha.AutoSize = true;
            this.rdbFecha.Checked = true;
            this.rdbFecha.Location = new System.Drawing.Point(639, 15);
            this.rdbFecha.Name = "rdbFecha";
            this.rdbFecha.Size = new System.Drawing.Size(55, 17);
            this.rdbFecha.TabIndex = 96;
            this.rdbFecha.TabStop = true;
            this.rdbFecha.Text = "Fecha";
            this.rdbFecha.UseVisualStyleBackColor = true;
            this.rdbFecha.CheckedChanged += new System.EventHandler(this.rdbFecha_CheckedChanged);
            // 
            // rdbVenta
            // 
            this.rdbVenta.AutoSize = true;
            this.rdbVenta.Location = new System.Drawing.Point(6, 15);
            this.rdbVenta.Name = "rdbVenta";
            this.rdbVenta.Size = new System.Drawing.Size(53, 17);
            this.rdbVenta.TabIndex = 95;
            this.rdbVenta.Text = "Venta";
            this.rdbVenta.UseVisualStyleBackColor = true;
            this.rdbVenta.CheckedChanged += new System.EventHandler(this.rdbVenta_CheckedChanged);
            // 
            // rdbCliente
            // 
            this.rdbCliente.AutoSize = true;
            this.rdbCliente.Location = new System.Drawing.Point(283, 15);
            this.rdbCliente.Name = "rdbCliente";
            this.rdbCliente.Size = new System.Drawing.Size(57, 17);
            this.rdbCliente.TabIndex = 94;
            this.rdbCliente.Text = "Cliente";
            this.rdbCliente.UseVisualStyleBackColor = true;
            this.rdbCliente.CheckedChanged += new System.EventHandler(this.rdbCliente_CheckedChanged);
            // 
            // txtVenta
            // 
            this.txtVenta.Location = new System.Drawing.Point(6, 38);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.ReadOnly = true;
            this.txtVenta.Size = new System.Drawing.Size(205, 20);
            this.txtVenta.TabIndex = 2;
            this.txtVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVenta_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(233, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(283, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(247, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "hasta el";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Del";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpHasta.Location = new System.Drawing.Point(639, 60);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 1;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDesde.Location = new System.Drawing.Point(639, 38);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 0;
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscaCliente.Enabled = false;
            this.btnBuscaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaCliente.Image = global::SRATAPV.Properties.Resources.buscar_32;
            this.btnBuscaCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscaCliente.Location = new System.Drawing.Point(536, 36);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(23, 23);
            this.btnBuscaCliente.TabIndex = 83;
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnModificar,
            this.btnBuscar,
            this.btnCancelar,
            this.btnCrear,
            this.btnPreeliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(869, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = global::SRATAPV.Properties.Resources.nuevo_24;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(23, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = global::SRATAPV.Properties.Resources.guardar_24;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(23, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModificar.Enabled = false;
            this.btnModificar.Image = global::SRATAPV.Properties.Resources.modificar_24;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(23, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = global::SRATAPV.Properties.Resources.buscar_24;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 22);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = global::SRATAPV.Properties.Resources.cancelar_32;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Visible = false;
            // 
            // btnCrear
            // 
            this.btnCrear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCrear.Enabled = false;
            this.btnCrear.Image = global::SRATAPV.Properties.Resources.crear_32;
            this.btnCrear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(23, 22);
            this.btnCrear.Text = "Crear";
            this.btnCrear.Visible = false;
            // 
            // btnPreeliminar
            // 
            this.btnPreeliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPreeliminar.Enabled = false;
            this.btnPreeliminar.Image = global::SRATAPV.Properties.Resources.preeeliminar_24;
            this.btnPreeliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPreeliminar.Name = "btnPreeliminar";
            this.btnPreeliminar.Size = new System.Drawing.Size(23, 22);
            this.btnPreeliminar.Text = "Preeliminar";
            this.btnPreeliminar.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvVentas);
            this.groupBox2.Location = new System.Drawing.Point(12, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(845, 344);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Búsqueda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 102;
            this.label4.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Todas",
            "Abierto",
            "Cancelado",
            "Cerrado"});
            this.cmbEstado.Location = new System.Drawing.Point(49, 60);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(162, 21);
            this.cmbEstado.TabIndex = 101;
            // 
            // Venta
            // 
            this.Venta.DataPropertyName = "Venta";
            this.Venta.HeaderText = "Venta";
            this.Venta.Name = "Venta";
            this.Venta.ReadOnly = true;
            this.Venta.Width = 60;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 68;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 64;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 65;
            // 
            // FechaDeDocumento
            // 
            this.FechaDeDocumento.DataPropertyName = "Fecha de documento";
            this.FechaDeDocumento.HeaderText = "Fecha de documento";
            this.FechaDeDocumento.Name = "FechaDeDocumento";
            this.FechaDeDocumento.ReadOnly = true;
            this.FechaDeDocumento.Width = 122;
            // 
            // FechaDeRegistro
            // 
            this.FechaDeRegistro.DataPropertyName = "Fecha de registro";
            this.FechaDeRegistro.HeaderText = "Fecha de registro";
            this.FechaDeRegistro.Name = "FechaDeRegistro";
            this.FechaDeRegistro.ReadOnly = true;
            this.FechaDeRegistro.Width = 105;
            // 
            // FechaDeModificacion
            // 
            this.FechaDeModificacion.DataPropertyName = "Fecha de modificación";
            this.FechaDeModificacion.HeaderText = "Fecha de modificación";
            this.FechaDeModificacion.Name = "FechaDeModificacion";
            this.FechaDeModificacion.ReadOnly = true;
            this.FechaDeModificacion.Width = 127;
            // 
            // UsuarioModifica
            // 
            this.UsuarioModifica.DataPropertyName = "Usuario modifica";
            this.UsuarioModifica.HeaderText = "Usuario modifica";
            this.UsuarioModifica.Name = "UsuarioModifica";
            this.UsuarioModifica.ReadOnly = true;
            this.UsuarioModifica.Width = 101;
            // 
            // Subtotal
            // 
            this.Subtotal.DataPropertyName = "Subtotal";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle1;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 71;
            // 
            // PorcentajeDescuento
            // 
            this.PorcentajeDescuento.DataPropertyName = "Porcentaje descuento";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PorcentajeDescuento.DefaultCellStyle = dataGridViewCellStyle2;
            this.PorcentajeDescuento.HeaderText = "Porcentaje descuento";
            this.PorcentajeDescuento.Name = "PorcentajeDescuento";
            this.PorcentajeDescuento.ReadOnly = true;
            this.PorcentajeDescuento.Width = 124;
            // 
            // Descuento
            // 
            this.Descuento.DataPropertyName = "Descuento";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Descuento.DefaultCellStyle = dataGridViewCellStyle3;
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            this.Descuento.Width = 84;
            // 
            // IVA
            // 
            this.IVA.DataPropertyName = "IVA";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.IVA.DefaultCellStyle = dataGridViewCellStyle4;
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            this.IVA.ReadOnly = true;
            this.IVA.Width = 49;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Total.DefaultCellStyle = dataGridViewCellStyle5;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 56;
            // 
            // Comentarios
            // 
            this.Comentarios.DataPropertyName = "Comentarios";
            this.Comentarios.HeaderText = "Comentarios";
            this.Comentarios.Name = "Comentarios";
            this.Comentarios.ReadOnly = true;
            this.Comentarios.Width = 90;
            // 
            // Cotizacion
            // 
            this.Cotizacion.DataPropertyName = "Cotizacion";
            this.Cotizacion.HeaderText = "Cotización";
            this.Cotizacion.Name = "Cotizacion";
            this.Cotizacion.ReadOnly = true;
            this.Cotizacion.Width = 81;
            // 
            // Corte
            // 
            this.Corte.DataPropertyName = "Corte";
            this.Corte.HeaderText = "Corte";
            this.Corte.Name = "Corte";
            this.Corte.ReadOnly = true;
            this.Corte.Width = 57;
            // 
            // MetodoDePago
            // 
            this.MetodoDePago.DataPropertyName = "Método de pago";
            this.MetodoDePago.HeaderText = "Método de pago";
            this.MetodoDePago.Name = "MetodoDePago";
            this.MetodoDePago.ReadOnly = true;
            this.MetodoDePago.Width = 79;
            // 
            // Detalle
            // 
            this.Detalle.DataPropertyName = "Detalle";
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.Width = 65;
            // 
            // Referencia
            // 
            this.Referencia.DataPropertyName = "Referencia";
            this.Referencia.HeaderText = "Referencia";
            this.Referencia.Name = "Referencia";
            this.Referencia.ReadOnly = true;
            this.Referencia.Width = 84;
            // 
            // Pago
            // 
            this.Pago.DataPropertyName = "Pago";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Pago.DefaultCellStyle = dataGridViewCellStyle6;
            this.Pago.HeaderText = "Pago";
            this.Pago.Name = "Pago";
            this.Pago.ReadOnly = true;
            this.Pago.Width = 57;
            // 
            // UUID
            // 
            this.UUID.DataPropertyName = "UUID";
            this.UUID.HeaderText = "UUID";
            this.UUID.Name = "UUID";
            this.UUID.ReadOnly = true;
            this.UUID.Width = 59;
            // 
            // frmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(869, 480);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de ventas";
            this.Load += new System.EventHandler(this.frmReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscaCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnCrear;
        private System.Windows.Forms.ToolStripButton btnPreeliminar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtVenta;
        private System.Windows.Forms.RadioButton rdbFecha;
        private System.Windows.Forms.RadioButton rdbVenta;
        private System.Windows.Forms.RadioButton rdbCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeModificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioModifica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentajeDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Corte;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetodoDePago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn UUID;

    }
}