namespace SRATAPV.Reportes.Formas
{
    partial class frmReporteExtras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteExtras));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnCrear = new System.Windows.Forms.ToolStripButton();
            this.btnPreeliminar = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.ven_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_nombfisc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven_fecdoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven_keyven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven_coment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven2_extra1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven2_extra2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven2_extra3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven2_extra4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven2_extra5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven2_extra6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven2_extra7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven2_extra8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven2_extra9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven2_extra10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven2_extra11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven2_extra12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven2_extra13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven2_extra14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven2_extra15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven2_extra16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven2_extra17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven2_extra18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven2_extra19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven2_extra20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbExtra = new System.Windows.Forms.ComboBox();
            this.rdbFecha = new System.Windows.Forms.RadioButton();
            this.rdbExtra = new System.Windows.Forms.RadioButton();
            this.rdbCliente = new System.Windows.Forms.RadioButton();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStrip1.TabIndex = 3;
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
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(845, 361);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Búsqueda";
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
            this.ven_cliente,
            this.cli_nombfisc,
            this.ven_fecdoc,
            this.ven_keyven,
            this.ven_coment,
            this.ven2_extra1,
            this.ven2_extra2,
            this.ven2_extra3,
            this.ven2_extra4,
            this.ven2_extra5,
            this.ven2_extra6,
            this.ven2_extra7,
            this.ven2_extra8,
            this.ven2_extra9,
            this.ven2_extra10,
            this.ven2_extra11,
            this.ven2_extra12,
            this.ven2_extra13,
            this.ven2_extra14,
            this.ven2_extra15,
            this.ven2_extra16,
            this.ven2_extra17,
            this.ven2_extra18,
            this.ven2_extra19,
            this.ven2_extra20});
            this.dgvVentas.Location = new System.Drawing.Point(6, 19);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.Size = new System.Drawing.Size(833, 336);
            this.dgvVentas.TabIndex = 0;
            // 
            // ven_cliente
            // 
            this.ven_cliente.DataPropertyName = "ven_cliente";
            this.ven_cliente.HeaderText = "Cliente";
            this.ven_cliente.Name = "ven_cliente";
            this.ven_cliente.ReadOnly = true;
            this.ven_cliente.Width = 64;
            // 
            // cli_nombfisc
            // 
            this.cli_nombfisc.DataPropertyName = "cli_nombfisc";
            this.cli_nombfisc.HeaderText = "Descripción";
            this.cli_nombfisc.Name = "cli_nombfisc";
            this.cli_nombfisc.ReadOnly = true;
            this.cli_nombfisc.Width = 88;
            // 
            // ven_fecdoc
            // 
            this.ven_fecdoc.DataPropertyName = "ven_fecdoc";
            this.ven_fecdoc.HeaderText = "Fecha de documento";
            this.ven_fecdoc.Name = "ven_fecdoc";
            this.ven_fecdoc.ReadOnly = true;
            this.ven_fecdoc.Width = 122;
            // 
            // ven_keyven
            // 
            this.ven_keyven.DataPropertyName = "ven_keyven";
            this.ven_keyven.HeaderText = "Venta";
            this.ven_keyven.Name = "ven_keyven";
            this.ven_keyven.ReadOnly = true;
            this.ven_keyven.Width = 60;
            // 
            // ven_coment
            // 
            this.ven_coment.DataPropertyName = "ven_coment";
            this.ven_coment.HeaderText = "Comentarios";
            this.ven_coment.Name = "ven_coment";
            this.ven_coment.ReadOnly = true;
            this.ven_coment.Width = 90;
            // 
            // ven2_extra1
            // 
            this.ven2_extra1.DataPropertyName = "ven2_extra1";
            this.ven2_extra1.HeaderText = "";
            this.ven2_extra1.Name = "ven2_extra1";
            this.ven2_extra1.ReadOnly = true;
            this.ven2_extra1.Width = 19;
            // 
            // ven2_extra2
            // 
            this.ven2_extra2.DataPropertyName = "ven2_extra2";
            this.ven2_extra2.HeaderText = "";
            this.ven2_extra2.Name = "ven2_extra2";
            this.ven2_extra2.ReadOnly = true;
            this.ven2_extra2.Width = 19;
            // 
            // ven2_extra3
            // 
            this.ven2_extra3.DataPropertyName = "ven2_extra3";
            this.ven2_extra3.HeaderText = "";
            this.ven2_extra3.Name = "ven2_extra3";
            this.ven2_extra3.ReadOnly = true;
            this.ven2_extra3.Width = 19;
            // 
            // ven2_extra4
            // 
            this.ven2_extra4.DataPropertyName = "ven2_extra4";
            this.ven2_extra4.HeaderText = "";
            this.ven2_extra4.Name = "ven2_extra4";
            this.ven2_extra4.ReadOnly = true;
            this.ven2_extra4.Width = 19;
            // 
            // ven2_extra5
            // 
            this.ven2_extra5.DataPropertyName = "ven2_extra5";
            this.ven2_extra5.HeaderText = "";
            this.ven2_extra5.Name = "ven2_extra5";
            this.ven2_extra5.ReadOnly = true;
            this.ven2_extra5.Width = 19;
            // 
            // ven2_extra6
            // 
            this.ven2_extra6.DataPropertyName = "ven2_extra6";
            this.ven2_extra6.HeaderText = "";
            this.ven2_extra6.Name = "ven2_extra6";
            this.ven2_extra6.ReadOnly = true;
            this.ven2_extra6.Width = 19;
            // 
            // ven2_extra7
            // 
            this.ven2_extra7.DataPropertyName = "ven2_extra7";
            this.ven2_extra7.HeaderText = "";
            this.ven2_extra7.Name = "ven2_extra7";
            this.ven2_extra7.ReadOnly = true;
            this.ven2_extra7.Width = 19;
            // 
            // ven2_extra8
            // 
            this.ven2_extra8.DataPropertyName = "ven2_extra8";
            this.ven2_extra8.HeaderText = "";
            this.ven2_extra8.Name = "ven2_extra8";
            this.ven2_extra8.ReadOnly = true;
            this.ven2_extra8.Width = 19;
            // 
            // ven2_extra9
            // 
            this.ven2_extra9.DataPropertyName = "ven2_extra9";
            this.ven2_extra9.HeaderText = "";
            this.ven2_extra9.Name = "ven2_extra9";
            this.ven2_extra9.ReadOnly = true;
            this.ven2_extra9.Width = 19;
            // 
            // ven2_extra10
            // 
            this.ven2_extra10.DataPropertyName = "ven2_extra10";
            this.ven2_extra10.HeaderText = "";
            this.ven2_extra10.Name = "ven2_extra10";
            this.ven2_extra10.ReadOnly = true;
            this.ven2_extra10.Width = 19;
            // 
            // ven2_extra11
            // 
            this.ven2_extra11.DataPropertyName = "ven2_extra11";
            this.ven2_extra11.HeaderText = "";
            this.ven2_extra11.Name = "ven2_extra11";
            this.ven2_extra11.ReadOnly = true;
            this.ven2_extra11.Width = 19;
            // 
            // ven2_extra12
            // 
            this.ven2_extra12.DataPropertyName = "ven2_extra12";
            this.ven2_extra12.HeaderText = "";
            this.ven2_extra12.Name = "ven2_extra12";
            this.ven2_extra12.ReadOnly = true;
            this.ven2_extra12.Width = 19;
            // 
            // ven2_extra13
            // 
            this.ven2_extra13.DataPropertyName = "ven2_extra13";
            this.ven2_extra13.HeaderText = "";
            this.ven2_extra13.Name = "ven2_extra13";
            this.ven2_extra13.ReadOnly = true;
            this.ven2_extra13.Width = 19;
            // 
            // ven2_extra14
            // 
            this.ven2_extra14.DataPropertyName = "ven2_extra14";
            this.ven2_extra14.HeaderText = "";
            this.ven2_extra14.Name = "ven2_extra14";
            this.ven2_extra14.ReadOnly = true;
            this.ven2_extra14.Width = 19;
            // 
            // ven2_extra15
            // 
            this.ven2_extra15.DataPropertyName = "ven2_extra15";
            this.ven2_extra15.HeaderText = "";
            this.ven2_extra15.Name = "ven2_extra15";
            this.ven2_extra15.ReadOnly = true;
            this.ven2_extra15.Width = 19;
            // 
            // ven2_extra16
            // 
            this.ven2_extra16.DataPropertyName = "ven2_extra16";
            this.ven2_extra16.HeaderText = "";
            this.ven2_extra16.Name = "ven2_extra16";
            this.ven2_extra16.ReadOnly = true;
            this.ven2_extra16.Width = 19;
            // 
            // ven2_extra17
            // 
            this.ven2_extra17.DataPropertyName = "ven2_extra17";
            this.ven2_extra17.HeaderText = "";
            this.ven2_extra17.Name = "ven2_extra17";
            this.ven2_extra17.ReadOnly = true;
            this.ven2_extra17.Width = 19;
            // 
            // ven2_extra18
            // 
            this.ven2_extra18.DataPropertyName = "ven2_extra18";
            this.ven2_extra18.HeaderText = "";
            this.ven2_extra18.Name = "ven2_extra18";
            this.ven2_extra18.ReadOnly = true;
            this.ven2_extra18.Width = 19;
            // 
            // ven2_extra19
            // 
            this.ven2_extra19.DataPropertyName = "ven2_extra19";
            this.ven2_extra19.HeaderText = "";
            this.ven2_extra19.Name = "ven2_extra19";
            this.ven2_extra19.ReadOnly = true;
            this.ven2_extra19.Width = 19;
            // 
            // ven2_extra20
            // 
            this.ven2_extra20.DataPropertyName = "ven2_extra20";
            this.ven2_extra20.HeaderText = "";
            this.ven2_extra20.Name = "ven2_extra20";
            this.ven2_extra20.ReadOnly = true;
            this.ven2_extra20.Width = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbEstado);
            this.groupBox1.Controls.Add(this.cmbExtra);
            this.groupBox1.Controls.Add(this.rdbFecha);
            this.groupBox1.Controls.Add(this.rdbExtra);
            this.groupBox1.Controls.Add(this.rdbCliente);
            this.groupBox1.Controls.Add(this.txtExtra);
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
            this.groupBox1.Size = new System.Drawing.Size(845, 125);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // cmbExtra
            // 
            this.cmbExtra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExtra.Enabled = false;
            this.cmbExtra.FormattingEnabled = true;
            this.cmbExtra.Location = new System.Drawing.Point(6, 38);
            this.cmbExtra.Name = "cmbExtra";
            this.cmbExtra.Size = new System.Drawing.Size(209, 21);
            this.cmbExtra.TabIndex = 97;
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
            // rdbExtra
            // 
            this.rdbExtra.AutoSize = true;
            this.rdbExtra.Location = new System.Drawing.Point(6, 15);
            this.rdbExtra.Name = "rdbExtra";
            this.rdbExtra.Size = new System.Drawing.Size(49, 17);
            this.rdbExtra.TabIndex = 95;
            this.rdbExtra.Text = "Extra";
            this.rdbExtra.UseVisualStyleBackColor = true;
            this.rdbExtra.CheckedChanged += new System.EventHandler(this.rdbExtra_CheckedChanged);
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
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(6, 60);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.ReadOnly = true;
            this.txtExtra.Size = new System.Drawing.Size(209, 20);
            this.txtExtra.TabIndex = 2;
            this.txtExtra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtra_KeyPress);
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
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Todas",
            "Abierto",
            "Cancelado",
            "Cerrado"});
            this.cmbEstado.Location = new System.Drawing.Point(52, 91);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(163, 21);
            this.cmbEstado.TabIndex = 99;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 100;
            this.label4.Text = "Estado";
            // 
            // frmReporteExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(869, 532);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteExtras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de extras";
            this.Load += new System.EventHandler(this.frmReportePlacas_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnCrear;
        private System.Windows.Forms.ToolStripButton btnPreeliminar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFecha;
        private System.Windows.Forms.RadioButton rdbExtra;
        private System.Windows.Forms.RadioButton rdbCliente;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscaCliente;
        private System.Windows.Forms.ComboBox cmbExtra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_nombfisc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven_fecdoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven_keyven;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven_coment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven2_extra1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven2_extra2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven2_extra3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven2_extra4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven2_extra5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven2_extra6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven2_extra7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven2_extra8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven2_extra9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven2_extra10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven2_extra11;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven2_extra12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven2_extra13;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven2_extra14;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven2_extra15;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven2_extra16;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven2_extra17;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven2_extra18;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven2_extra19;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven2_extra20;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEstado;
    }
}