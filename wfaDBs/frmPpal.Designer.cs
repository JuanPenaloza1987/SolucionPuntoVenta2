namespace wfaDBs
{
    partial class frmPpal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPpal));
            this.tcnCnfg = new System.Windows.Forms.TabControl();
            this.tpgCnxLcl = new System.Windows.Forms.TabPage();
            this.rdbWfiCpu = new System.Windows.Forms.RadioButton();
            this.rdbEthCpu = new System.Windows.Forms.RadioButton();
            this.btnBscCpu = new System.Windows.Forms.Button();
            this.btnCncCpu = new System.Windows.Forms.Button();
            this.btnAcpCpu = new System.Windows.Forms.Button();
            this.chbStaCpu = new System.Windows.Forms.CheckBox();
            this.txtDbsCpu = new System.Windows.Forms.TextBox();
            this.txtMacCpu = new System.Windows.Forms.TextBox();
            this.txtIpaCpu = new System.Windows.Forms.TextBox();
            this.txtPatCpu = new System.Windows.Forms.TextBox();
            this.txtNamCpu = new System.Windows.Forms.TextBox();
            this.txtCdgCpu = new System.Windows.Forms.TextBox();
            this.lblDbsCpu = new System.Windows.Forms.Label();
            this.lblMacCpu = new System.Windows.Forms.Label();
            this.lblIpaCpu = new System.Windows.Forms.Label();
            this.lblPatCpu = new System.Windows.Forms.Label();
            this.lblNamCpu = new System.Windows.Forms.Label();
            this.lblCdgCpu = new System.Windows.Forms.Label();
            this.tpgCnxSrv = new System.Windows.Forms.TabPage();
            this.txtSerCnx = new System.Windows.Forms.TextBox();
            this.btnCncCnx = new System.Windows.Forms.Button();
            this.btnAcpCnx = new System.Windows.Forms.Button();
            this.txtPwdCnx = new System.Windows.Forms.TextBox();
            this.txtUsuCnx = new System.Windows.Forms.TextBox();
            this.txtDbsCnx = new System.Windows.Forms.TextBox();
            this.txtMacCnx = new System.Windows.Forms.TextBox();
            this.txtIpaCnx = new System.Windows.Forms.TextBox();
            this.txtCdgCnx = new System.Windows.Forms.TextBox();
            this.lblPwdCnx = new System.Windows.Forms.Label();
            this.lblUsuCnx = new System.Windows.Forms.Label();
            this.lblDbsCnx = new System.Windows.Forms.Label();
            this.lblMacCnx = new System.Windows.Forms.Label();
            this.lblIpaCnx = new System.Windows.Forms.Label();
            this.lblSerCnx = new System.Windows.Forms.Label();
            this.lblCdgCnx = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.ntiApp = new System.Windows.Forms.NotifyIcon(this.components);
            this.tmrEnviar = new System.Windows.Forms.Timer(this.components);
            this.tcnCnfg.SuspendLayout();
            this.tpgCnxLcl.SuspendLayout();
            this.tpgCnxSrv.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcnCnfg
            // 
            this.tcnCnfg.Controls.Add(this.tpgCnxLcl);
            this.tcnCnfg.Controls.Add(this.tpgCnxSrv);
            this.tcnCnfg.Location = new System.Drawing.Point(12, 12);
            this.tcnCnfg.Name = "tcnCnfg";
            this.tcnCnfg.SelectedIndex = 0;
            this.tcnCnfg.Size = new System.Drawing.Size(603, 306);
            this.tcnCnfg.TabIndex = 0;
            // 
            // tpgCnxLcl
            // 
            this.tpgCnxLcl.Controls.Add(this.rdbWfiCpu);
            this.tpgCnxLcl.Controls.Add(this.rdbEthCpu);
            this.tpgCnxLcl.Controls.Add(this.btnBscCpu);
            this.tpgCnxLcl.Controls.Add(this.btnCncCpu);
            this.tpgCnxLcl.Controls.Add(this.btnAcpCpu);
            this.tpgCnxLcl.Controls.Add(this.chbStaCpu);
            this.tpgCnxLcl.Controls.Add(this.txtDbsCpu);
            this.tpgCnxLcl.Controls.Add(this.txtMacCpu);
            this.tpgCnxLcl.Controls.Add(this.txtIpaCpu);
            this.tpgCnxLcl.Controls.Add(this.txtPatCpu);
            this.tpgCnxLcl.Controls.Add(this.txtNamCpu);
            this.tpgCnxLcl.Controls.Add(this.txtCdgCpu);
            this.tpgCnxLcl.Controls.Add(this.lblDbsCpu);
            this.tpgCnxLcl.Controls.Add(this.lblMacCpu);
            this.tpgCnxLcl.Controls.Add(this.lblIpaCpu);
            this.tpgCnxLcl.Controls.Add(this.lblPatCpu);
            this.tpgCnxLcl.Controls.Add(this.lblNamCpu);
            this.tpgCnxLcl.Controls.Add(this.lblCdgCpu);
            this.tpgCnxLcl.Location = new System.Drawing.Point(4, 22);
            this.tpgCnxLcl.Name = "tpgCnxLcl";
            this.tpgCnxLcl.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCnxLcl.Size = new System.Drawing.Size(595, 280);
            this.tpgCnxLcl.TabIndex = 0;
            this.tpgCnxLcl.Text = "Conexión Local";
            this.tpgCnxLcl.UseVisualStyleBackColor = true;
            // 
            // rdbWfiCpu
            // 
            this.rdbWfiCpu.AutoSize = true;
            this.rdbWfiCpu.Location = new System.Drawing.Point(446, 86);
            this.rdbWfiCpu.Name = "rdbWfiCpu";
            this.rdbWfiCpu.Size = new System.Drawing.Size(46, 17);
            this.rdbWfiCpu.TabIndex = 17;
            this.rdbWfiCpu.Text = "WiFi";
            this.rdbWfiCpu.UseVisualStyleBackColor = true;
            this.rdbWfiCpu.CheckedChanged += new System.EventHandler(this.rdbWfiCpu_CheckedChanged);
            // 
            // rdbEthCpu
            // 
            this.rdbEthCpu.AutoSize = true;
            this.rdbEthCpu.Checked = true;
            this.rdbEthCpu.Location = new System.Drawing.Point(375, 86);
            this.rdbEthCpu.Name = "rdbEthCpu";
            this.rdbEthCpu.Size = new System.Drawing.Size(65, 17);
            this.rdbEthCpu.TabIndex = 16;
            this.rdbEthCpu.TabStop = true;
            this.rdbEthCpu.Text = "Ethernet";
            this.rdbEthCpu.UseVisualStyleBackColor = true;
            this.rdbEthCpu.CheckedChanged += new System.EventHandler(this.rdbEthCpu_CheckedChanged);
            // 
            // btnBscCpu
            // 
            this.btnBscCpu.Location = new System.Drawing.Point(366, 58);
            this.btnBscCpu.Name = "btnBscCpu";
            this.btnBscCpu.Size = new System.Drawing.Size(25, 20);
            this.btnBscCpu.TabIndex = 15;
            this.btnBscCpu.Text = "...";
            this.btnBscCpu.UseVisualStyleBackColor = true;
            this.btnBscCpu.Click += new System.EventHandler(this.btnBscCpu_Click);
            // 
            // btnCncCpu
            // 
            this.btnCncCpu.Location = new System.Drawing.Point(87, 251);
            this.btnCncCpu.Name = "btnCncCpu";
            this.btnCncCpu.Size = new System.Drawing.Size(75, 23);
            this.btnCncCpu.TabIndex = 14;
            this.btnCncCpu.Text = "Cancelar";
            this.btnCncCpu.UseVisualStyleBackColor = true;
            this.btnCncCpu.Visible = false;
            this.btnCncCpu.Click += new System.EventHandler(this.btnCncCpu_Click);
            // 
            // btnAcpCpu
            // 
            this.btnAcpCpu.Location = new System.Drawing.Point(6, 251);
            this.btnAcpCpu.Name = "btnAcpCpu";
            this.btnAcpCpu.Size = new System.Drawing.Size(75, 23);
            this.btnAcpCpu.TabIndex = 13;
            this.btnAcpCpu.Text = "Guardar";
            this.btnAcpCpu.UseVisualStyleBackColor = true;
            this.btnAcpCpu.Click += new System.EventHandler(this.btnAcpCpu_Click);
            // 
            // chbStaCpu
            // 
            this.chbStaCpu.AutoSize = true;
            this.chbStaCpu.Location = new System.Drawing.Point(131, 162);
            this.chbStaCpu.Name = "chbStaCpu";
            this.chbStaCpu.Size = new System.Drawing.Size(105, 17);
            this.chbStaCpu.TabIndex = 12;
            this.chbStaCpu.Text = "Activo / Inactivo";
            this.chbStaCpu.UseVisualStyleBackColor = true;
            // 
            // txtDbsCpu
            // 
            this.txtDbsCpu.Enabled = false;
            this.txtDbsCpu.Location = new System.Drawing.Point(131, 136);
            this.txtDbsCpu.Name = "txtDbsCpu";
            this.txtDbsCpu.Size = new System.Drawing.Size(230, 20);
            this.txtDbsCpu.TabIndex = 11;
            this.txtDbsCpu.Text = "STRATA_LOCAL";
            // 
            // txtMacCpu
            // 
            this.txtMacCpu.Location = new System.Drawing.Point(131, 110);
            this.txtMacCpu.Name = "txtMacCpu";
            this.txtMacCpu.Size = new System.Drawing.Size(230, 20);
            this.txtMacCpu.TabIndex = 10;
            // 
            // txtIpaCpu
            // 
            this.txtIpaCpu.Location = new System.Drawing.Point(131, 84);
            this.txtIpaCpu.Name = "txtIpaCpu";
            this.txtIpaCpu.Size = new System.Drawing.Size(230, 20);
            this.txtIpaCpu.TabIndex = 9;
            // 
            // txtPatCpu
            // 
            this.txtPatCpu.Location = new System.Drawing.Point(131, 58);
            this.txtPatCpu.Name = "txtPatCpu";
            this.txtPatCpu.Size = new System.Drawing.Size(230, 20);
            this.txtPatCpu.TabIndex = 8;
            // 
            // txtNamCpu
            // 
            this.txtNamCpu.Location = new System.Drawing.Point(130, 32);
            this.txtNamCpu.Name = "txtNamCpu";
            this.txtNamCpu.Size = new System.Drawing.Size(230, 20);
            this.txtNamCpu.TabIndex = 7;
            // 
            // txtCdgCpu
            // 
            this.txtCdgCpu.Enabled = false;
            this.txtCdgCpu.Location = new System.Drawing.Point(130, 6);
            this.txtCdgCpu.Name = "txtCdgCpu";
            this.txtCdgCpu.Size = new System.Drawing.Size(70, 20);
            this.txtCdgCpu.TabIndex = 6;
            this.txtCdgCpu.Text = "1";
            // 
            // lblDbsCpu
            // 
            this.lblDbsCpu.AutoSize = true;
            this.lblDbsCpu.Location = new System.Drawing.Point(10, 140);
            this.lblDbsCpu.Name = "lblDbsCpu";
            this.lblDbsCpu.Size = new System.Drawing.Size(77, 13);
            this.lblDbsCpu.TabIndex = 5;
            this.lblDbsCpu.Text = "Base de Datos";
            // 
            // lblMacCpu
            // 
            this.lblMacCpu.AutoSize = true;
            this.lblMacCpu.Location = new System.Drawing.Point(10, 114);
            this.lblMacCpu.Name = "lblMacCpu";
            this.lblMacCpu.Size = new System.Drawing.Size(96, 13);
            this.lblMacCpu.TabIndex = 4;
            this.lblMacCpu.Text = "MAC Computadora";
            // 
            // lblIpaCpu
            // 
            this.lblIpaCpu.AutoSize = true;
            this.lblIpaCpu.Location = new System.Drawing.Point(10, 88);
            this.lblIpaCpu.Name = "lblIpaCpu";
            this.lblIpaCpu.Size = new System.Drawing.Size(83, 13);
            this.lblIpaCpu.TabIndex = 3;
            this.lblIpaCpu.Text = "IP Computadora";
            // 
            // lblPatCpu
            // 
            this.lblPatCpu.AutoSize = true;
            this.lblPatCpu.Location = new System.Drawing.Point(10, 62);
            this.lblPatCpu.Name = "lblPatCpu";
            this.lblPatCpu.Size = new System.Drawing.Size(103, 13);
            this.lblPatCpu.TabIndex = 2;
            this.lblPatCpu.Text = "Ruta Base de Datos";
            // 
            // lblNamCpu
            // 
            this.lblNamCpu.AutoSize = true;
            this.lblNamCpu.Location = new System.Drawing.Point(10, 36);
            this.lblNamCpu.Name = "lblNamCpu";
            this.lblNamCpu.Size = new System.Drawing.Size(68, 13);
            this.lblNamCpu.TabIndex = 1;
            this.lblNamCpu.Text = "Nombre Caja";
            // 
            // lblCdgCpu
            // 
            this.lblCdgCpu.AutoSize = true;
            this.lblCdgCpu.Location = new System.Drawing.Point(10, 10);
            this.lblCdgCpu.Name = "lblCdgCpu";
            this.lblCdgCpu.Size = new System.Drawing.Size(64, 13);
            this.lblCdgCpu.TabIndex = 0;
            this.lblCdgCpu.Text = "Codigo Caja";
            // 
            // tpgCnxSrv
            // 
            this.tpgCnxSrv.Controls.Add(this.txtSerCnx);
            this.tpgCnxSrv.Controls.Add(this.btnCncCnx);
            this.tpgCnxSrv.Controls.Add(this.btnAcpCnx);
            this.tpgCnxSrv.Controls.Add(this.txtPwdCnx);
            this.tpgCnxSrv.Controls.Add(this.txtUsuCnx);
            this.tpgCnxSrv.Controls.Add(this.txtDbsCnx);
            this.tpgCnxSrv.Controls.Add(this.txtMacCnx);
            this.tpgCnxSrv.Controls.Add(this.txtIpaCnx);
            this.tpgCnxSrv.Controls.Add(this.txtCdgCnx);
            this.tpgCnxSrv.Controls.Add(this.lblPwdCnx);
            this.tpgCnxSrv.Controls.Add(this.lblUsuCnx);
            this.tpgCnxSrv.Controls.Add(this.lblDbsCnx);
            this.tpgCnxSrv.Controls.Add(this.lblMacCnx);
            this.tpgCnxSrv.Controls.Add(this.lblIpaCnx);
            this.tpgCnxSrv.Controls.Add(this.lblSerCnx);
            this.tpgCnxSrv.Controls.Add(this.lblCdgCnx);
            this.tpgCnxSrv.Location = new System.Drawing.Point(4, 22);
            this.tpgCnxSrv.Name = "tpgCnxSrv";
            this.tpgCnxSrv.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCnxSrv.Size = new System.Drawing.Size(595, 280);
            this.tpgCnxSrv.TabIndex = 1;
            this.tpgCnxSrv.Text = "Conexión Servidor";
            this.tpgCnxSrv.UseVisualStyleBackColor = true;
            // 
            // txtSerCnx
            // 
            this.txtSerCnx.Enabled = false;
            this.txtSerCnx.Location = new System.Drawing.Point(130, 32);
            this.txtSerCnx.Name = "txtSerCnx";
            this.txtSerCnx.Size = new System.Drawing.Size(230, 20);
            this.txtSerCnx.TabIndex = 16;
            this.txtSerCnx.Text = "SRVSAPT26";
            // 
            // btnCncCnx
            // 
            this.btnCncCnx.Location = new System.Drawing.Point(87, 251);
            this.btnCncCnx.Name = "btnCncCnx";
            this.btnCncCnx.Size = new System.Drawing.Size(75, 23);
            this.btnCncCnx.TabIndex = 15;
            this.btnCncCnx.Text = "Cancelar";
            this.btnCncCnx.UseVisualStyleBackColor = true;
            this.btnCncCnx.Visible = false;
            this.btnCncCnx.Click += new System.EventHandler(this.btnCncCnx_Click);
            // 
            // btnAcpCnx
            // 
            this.btnAcpCnx.Location = new System.Drawing.Point(6, 251);
            this.btnAcpCnx.Name = "btnAcpCnx";
            this.btnAcpCnx.Size = new System.Drawing.Size(75, 23);
            this.btnAcpCnx.TabIndex = 14;
            this.btnAcpCnx.Text = "Guardar";
            this.btnAcpCnx.UseVisualStyleBackColor = true;
            this.btnAcpCnx.Visible = false;
            this.btnAcpCnx.Click += new System.EventHandler(this.btnAcpCnx_Click);
            // 
            // txtPwdCnx
            // 
            this.txtPwdCnx.Enabled = false;
            this.txtPwdCnx.Location = new System.Drawing.Point(130, 163);
            this.txtPwdCnx.Name = "txtPwdCnx";
            this.txtPwdCnx.PasswordChar = '*';
            this.txtPwdCnx.Size = new System.Drawing.Size(230, 20);
            this.txtPwdCnx.TabIndex = 13;
            this.txtPwdCnx.Text = "sap@dmin625";
            // 
            // txtUsuCnx
            // 
            this.txtUsuCnx.Enabled = false;
            this.txtUsuCnx.Location = new System.Drawing.Point(130, 137);
            this.txtUsuCnx.Name = "txtUsuCnx";
            this.txtUsuCnx.Size = new System.Drawing.Size(230, 20);
            this.txtUsuCnx.TabIndex = 12;
            this.txtUsuCnx.Text = "sa";
            // 
            // txtDbsCnx
            // 
            this.txtDbsCnx.Enabled = false;
            this.txtDbsCnx.Location = new System.Drawing.Point(130, 111);
            this.txtDbsCnx.Name = "txtDbsCnx";
            this.txtDbsCnx.Size = new System.Drawing.Size(230, 20);
            this.txtDbsCnx.TabIndex = 11;
            this.txtDbsCnx.Text = "STRATA_PV";
            // 
            // txtMacCnx
            // 
            this.txtMacCnx.Enabled = false;
            this.txtMacCnx.Location = new System.Drawing.Point(130, 85);
            this.txtMacCnx.Name = "txtMacCnx";
            this.txtMacCnx.Size = new System.Drawing.Size(230, 20);
            this.txtMacCnx.TabIndex = 10;
            this.txtMacCnx.Text = "00-0C-29-72-17-65";
            // 
            // txtIpaCnx
            // 
            this.txtIpaCnx.Enabled = false;
            this.txtIpaCnx.Location = new System.Drawing.Point(130, 59);
            this.txtIpaCnx.Name = "txtIpaCnx";
            this.txtIpaCnx.Size = new System.Drawing.Size(230, 20);
            this.txtIpaCnx.TabIndex = 9;
            this.txtIpaCnx.Text = "172.16.0.16";
            // 
            // txtCdgCnx
            // 
            this.txtCdgCnx.Enabled = false;
            this.txtCdgCnx.Location = new System.Drawing.Point(130, 6);
            this.txtCdgCnx.Name = "txtCdgCnx";
            this.txtCdgCnx.Size = new System.Drawing.Size(70, 20);
            this.txtCdgCnx.TabIndex = 7;
            this.txtCdgCnx.Text = "1";
            // 
            // lblPwdCnx
            // 
            this.lblPwdCnx.AutoSize = true;
            this.lblPwdCnx.Location = new System.Drawing.Point(10, 167);
            this.lblPwdCnx.Name = "lblPwdCnx";
            this.lblPwdCnx.Size = new System.Drawing.Size(61, 13);
            this.lblPwdCnx.TabIndex = 6;
            this.lblPwdCnx.Text = "Contraseña";
            // 
            // lblUsuCnx
            // 
            this.lblUsuCnx.AutoSize = true;
            this.lblUsuCnx.Location = new System.Drawing.Point(10, 141);
            this.lblUsuCnx.Name = "lblUsuCnx";
            this.lblUsuCnx.Size = new System.Drawing.Size(43, 13);
            this.lblUsuCnx.TabIndex = 5;
            this.lblUsuCnx.Text = "Usuario";
            // 
            // lblDbsCnx
            // 
            this.lblDbsCnx.AutoSize = true;
            this.lblDbsCnx.Location = new System.Drawing.Point(10, 115);
            this.lblDbsCnx.Name = "lblDbsCnx";
            this.lblDbsCnx.Size = new System.Drawing.Size(77, 13);
            this.lblDbsCnx.TabIndex = 4;
            this.lblDbsCnx.Text = "Base de Datos";
            // 
            // lblMacCnx
            // 
            this.lblMacCnx.AutoSize = true;
            this.lblMacCnx.Location = new System.Drawing.Point(10, 89);
            this.lblMacCnx.Name = "lblMacCnx";
            this.lblMacCnx.Size = new System.Drawing.Size(72, 13);
            this.lblMacCnx.TabIndex = 3;
            this.lblMacCnx.Text = "MAC Servidor";
            // 
            // lblIpaCnx
            // 
            this.lblIpaCnx.AutoSize = true;
            this.lblIpaCnx.Location = new System.Drawing.Point(10, 63);
            this.lblIpaCnx.Name = "lblIpaCnx";
            this.lblIpaCnx.Size = new System.Drawing.Size(59, 13);
            this.lblIpaCnx.TabIndex = 2;
            this.lblIpaCnx.Text = "IP Servidor";
            // 
            // lblSerCnx
            // 
            this.lblSerCnx.AutoSize = true;
            this.lblSerCnx.Location = new System.Drawing.Point(10, 36);
            this.lblSerCnx.Name = "lblSerCnx";
            this.lblSerCnx.Size = new System.Drawing.Size(46, 13);
            this.lblSerCnx.TabIndex = 1;
            this.lblSerCnx.Text = "Servidor";
            // 
            // lblCdgCnx
            // 
            this.lblCdgCnx.AutoSize = true;
            this.lblCdgCnx.Location = new System.Drawing.Point(10, 10);
            this.lblCdgCnx.Name = "lblCdgCnx";
            this.lblCdgCnx.Size = new System.Drawing.Size(82, 13);
            this.lblCdgCnx.TabIndex = 0;
            this.lblCdgCnx.Text = "Codigo Servidor";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(12, 324);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 16;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(93, 324);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 17;
            this.btnEnviar.Text = "Ocultar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // ntiApp
            // 
            this.ntiApp.Text = "Strata App";
            this.ntiApp.Visible = true;
            this.ntiApp.DoubleClick += new System.EventHandler(this.ntiApp_DoubleClick);
            // 
            // tmrEnviar
            // 
            this.tmrEnviar.Interval = 10000;
            this.tmrEnviar.Tick += new System.EventHandler(this.tmrEnviar_Tick);
            // 
            // frmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 359);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.tcnCnfg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPpal";
            this.Text = "Principal App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPpal_FormClosed);
            this.Load += new System.EventHandler(this.frmPpal_Load);
            this.Resize += new System.EventHandler(this.frmPpal_Resize);
            this.tcnCnfg.ResumeLayout(false);
            this.tpgCnxLcl.ResumeLayout(false);
            this.tpgCnxLcl.PerformLayout();
            this.tpgCnxSrv.ResumeLayout(false);
            this.tpgCnxSrv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcnCnfg;
        private System.Windows.Forms.TabPage tpgCnxLcl;
        private System.Windows.Forms.CheckBox chbStaCpu;
        private System.Windows.Forms.TextBox txtDbsCpu;
        private System.Windows.Forms.TextBox txtMacCpu;
        private System.Windows.Forms.TextBox txtIpaCpu;
        private System.Windows.Forms.TextBox txtPatCpu;
        private System.Windows.Forms.TextBox txtNamCpu;
        private System.Windows.Forms.TextBox txtCdgCpu;
        private System.Windows.Forms.Label lblDbsCpu;
        private System.Windows.Forms.Label lblMacCpu;
        private System.Windows.Forms.Label lblIpaCpu;
        private System.Windows.Forms.Label lblPatCpu;
        private System.Windows.Forms.Label lblNamCpu;
        private System.Windows.Forms.Label lblCdgCpu;
        private System.Windows.Forms.TabPage tpgCnxSrv;
        private System.Windows.Forms.Button btnBscCpu;
        private System.Windows.Forms.Button btnCncCpu;
        private System.Windows.Forms.Button btnAcpCpu;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCncCnx;
        private System.Windows.Forms.Button btnAcpCnx;
        private System.Windows.Forms.TextBox txtPwdCnx;
        private System.Windows.Forms.TextBox txtUsuCnx;
        private System.Windows.Forms.TextBox txtDbsCnx;
        private System.Windows.Forms.TextBox txtMacCnx;
        private System.Windows.Forms.TextBox txtIpaCnx;
        private System.Windows.Forms.TextBox txtCdgCnx;
        private System.Windows.Forms.Label lblPwdCnx;
        private System.Windows.Forms.Label lblUsuCnx;
        private System.Windows.Forms.Label lblDbsCnx;
        private System.Windows.Forms.Label lblMacCnx;
        private System.Windows.Forms.Label lblIpaCnx;
        private System.Windows.Forms.Label lblSerCnx;
        private System.Windows.Forms.Label lblCdgCnx;
        private System.Windows.Forms.RadioButton rdbWfiCpu;
        private System.Windows.Forms.RadioButton rdbEthCpu;
        private System.Windows.Forms.TextBox txtSerCnx;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.NotifyIcon ntiApp;
        private System.Windows.Forms.Timer tmrEnviar;
    }
}

