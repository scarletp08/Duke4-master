namespace Duke4.CXC.Proceso
{
    partial class cxcprochequefuturo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cxcprochequefuturo));
            this.Dgv = new Duke4.Logistica.GridBase();
            this.dgvidregistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvsecuencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvfecha = new Duke4.Logistica.GridBase.CalendarColumn();
            this.dgvreferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvvence = new Duke4.Logistica.GridBase.CalendarColumn();
            this.dgvdias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtotal = new Duke4.Logistica.GridBase.DoubleColumn();
            this.dgvbalance = new Duke4.Logistica.GridBase.DoubleColumn();
            this.dgvaplicar = new Duke4.Logistica.GridBase.DoubleColumn();
            this.myLabel1 = new Duke4.Logistica.LblBase();
            this.Txtchequefuturo = new Duke4.Logistica.TxtMayuscula();
            this.Dtpfecha = new Duke4.Logistica.DtpBase();
            this.myLabel2 = new Duke4.Logistica.LblBase();
            this.Txtbalance = new Duke4.Logistica.TxtDecimal();
            this.myLabel3 = new Duke4.Logistica.LblBase();
            this.Txtreferencia = new Duke4.Logistica.TxtMayuscula();
            this.BtnBuscarVendedor = new Duke4.Logistica.BtnBuscar();
            this.Txtdireccioncliente = new Duke4.Logistica.TxtMayuscula();
            this.Txtcodigocliente = new Duke4.Logistica.TxtEntero();
            this.myLabel17 = new Duke4.Logistica.LblBase();
            this.myLabel4 = new Duke4.Logistica.LblBase();
            this.Txttelefonocliente = new Duke4.Logistica.MskTelefono();
            this.Txtnombrecliente = new Duke4.Logistica.TxtMayuscula();
            this.BtnBuscarCliente = new Duke4.Logistica.BtnBuscar();
            this.myLabel5 = new Duke4.Logistica.LblBase();
            this.Txtcodigovendedor = new Duke4.Logistica.TxtEntero();
            this.myLabel12 = new Duke4.Logistica.LblBase();
            this.Ckbimprimir = new Duke4.Logistica.CkbBase();
            this.Txtnombrevendedor = new Duke4.Logistica.TxtMayuscula();
            this.Cmbmoneda = new Duke4.Logistica.CmbBase();
            this.myLabel14 = new Duke4.Logistica.LblBase();
            this.myLabel16 = new Duke4.Logistica.LblBase();
            this.Cmbbanco = new Duke4.Logistica.CmbBase();
            this.lblBase1 = new Duke4.Logistica.LblBase();
            this.Txtaplicar = new Duke4.Logistica.TxtDecimal();
            this.myLabel7 = new Duke4.Logistica.LblBase();
            this.Txtnock = new Duke4.Logistica.TxtEntero();
            this.lblBase2 = new Duke4.Logistica.LblBase();
            this.Dtpfechadeposito = new Duke4.Logistica.DtpBase();
            this.lblBase3 = new Duke4.Logistica.LblBase();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.Dtpfechadeposito);
            this.MainPanel.Controls.Add(this.lblBase3);
            this.MainPanel.Controls.Add(this.lblBase2);
            this.MainPanel.Controls.Add(this.Txtnock);
            this.MainPanel.Controls.Add(this.Txtaplicar);
            this.MainPanel.Controls.Add(this.myLabel7);
            this.MainPanel.Controls.Add(this.Cmbbanco);
            this.MainPanel.Controls.Add(this.lblBase1);
            this.MainPanel.Controls.Add(this.Dgv);
            this.MainPanel.Controls.Add(this.myLabel1);
            this.MainPanel.Controls.Add(this.Txtchequefuturo);
            this.MainPanel.Controls.Add(this.Dtpfecha);
            this.MainPanel.Controls.Add(this.myLabel2);
            this.MainPanel.Controls.Add(this.Txtbalance);
            this.MainPanel.Controls.Add(this.myLabel3);
            this.MainPanel.Controls.Add(this.Txtreferencia);
            this.MainPanel.Controls.Add(this.BtnBuscarVendedor);
            this.MainPanel.Controls.Add(this.Txtdireccioncliente);
            this.MainPanel.Controls.Add(this.Txtcodigocliente);
            this.MainPanel.Controls.Add(this.myLabel17);
            this.MainPanel.Controls.Add(this.myLabel4);
            this.MainPanel.Controls.Add(this.Txttelefonocliente);
            this.MainPanel.Controls.Add(this.Txtnombrecliente);
            this.MainPanel.Controls.Add(this.BtnBuscarCliente);
            this.MainPanel.Controls.Add(this.myLabel5);
            this.MainPanel.Controls.Add(this.Txtcodigovendedor);
            this.MainPanel.Controls.Add(this.myLabel12);
            this.MainPanel.Controls.Add(this.Ckbimprimir);
            this.MainPanel.Controls.Add(this.Txtnombrevendedor);
            this.MainPanel.Controls.Add(this.Cmbmoneda);
            this.MainPanel.Controls.Add(this.myLabel14);
            this.MainPanel.Controls.Add(this.myLabel16);
            this.MainPanel.Location = new System.Drawing.Point(1, 105);
            this.MainPanel.Size = new System.Drawing.Size(795, 480);
            this.MainPanel.Controls.SetChildIndex(this.myLabel16, 0);
            this.MainPanel.Controls.SetChildIndex(this.myLabel14, 0);
            this.MainPanel.Controls.SetChildIndex(this.Cmbmoneda, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtnombrevendedor, 0);
            this.MainPanel.Controls.SetChildIndex(this.Ckbimprimir, 0);
            this.MainPanel.Controls.SetChildIndex(this.myLabel12, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtcodigovendedor, 0);
            this.MainPanel.Controls.SetChildIndex(this.myLabel5, 0);
            this.MainPanel.Controls.SetChildIndex(this.BtnBuscarCliente, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtnombrecliente, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txttelefonocliente, 0);
            this.MainPanel.Controls.SetChildIndex(this.myLabel4, 0);
            this.MainPanel.Controls.SetChildIndex(this.myLabel17, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtcodigocliente, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtdireccioncliente, 0);
            this.MainPanel.Controls.SetChildIndex(this.BtnBuscarVendedor, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtreferencia, 0);
            this.MainPanel.Controls.SetChildIndex(this.myLabel3, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtbalance, 0);
            this.MainPanel.Controls.SetChildIndex(this.myLabel2, 0);
            this.MainPanel.Controls.SetChildIndex(this.Dtpfecha, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtchequefuturo, 0);
            this.MainPanel.Controls.SetChildIndex(this.myLabel1, 0);
            this.MainPanel.Controls.SetChildIndex(this.Dgv, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase1, 0);
            this.MainPanel.Controls.SetChildIndex(this.Cmbbanco, 0);
            this.MainPanel.Controls.SetChildIndex(this.myLabel7, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtaplicar, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtnock, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase2, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase3, 0);
            this.MainPanel.Controls.SetChildIndex(this.Dtpfechadeposito, 0);
            this.MainPanel.Controls.SetChildIndex(this.LblFunctionName, 0);
            // 
            // LblAlerta
            // 
            this.LblAlerta.Location = new System.Drawing.Point(165, 517);
            this.LblAlerta.Size = new System.Drawing.Size(0, 23);
            this.LblAlerta.Text = "";
            // 
            // LblFunctionName
            // 
            this.LblFunctionName.Location = new System.Drawing.Point(744, 42);
            this.LblFunctionName.Size = new System.Drawing.Size(0, 32);
            this.LblFunctionName.Text = "";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 585);
            this.panel2.Size = new System.Drawing.Size(799, 11);
            // 
            // FormTitle
            // 
            this.FormTitle.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.FormTitle.ForeColor = System.Drawing.Color.White;
            this.FormTitle.Size = new System.Drawing.Size(88, 23);
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.AllowUserToDeleteRows = false;
            this.Dgv.AllowUserToResizeColumns = false;
            this.Dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvidregistro,
            this.dgvsecuencia,
            this.dgvfecha,
            this.dgvreferencia,
            this.dgvvence,
            this.dgvdias,
            this.dgvtotal,
            this.dgvbalance,
            this.dgvaplicar});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 7.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv.DefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.Dgv.Location = new System.Drawing.Point(17, 179);
            this.Dgv.MultiSelect = false;
            this.Dgv.Name = "Dgv";
            this.Dgv.RowHeadersVisible = false;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(761, 275);
            this.Dgv.TabIndex = 388;
            this.Dgv.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Dgv_CellBeginEdit);
            this.Dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellEndEdit);
            this.Dgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellEndEdit);
            this.Dgv.CurrentCellDirtyStateChanged += new System.EventHandler(this.Dgv_CurrentCellDirtyStateChanged);
            // 
            // dgvidregistro
            // 
            this.dgvidregistro.DataPropertyName = "idregistro";
            this.dgvidregistro.HeaderText = "idregistro";
            this.dgvidregistro.Name = "dgvidregistro";
            this.dgvidregistro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvidregistro.Visible = false;
            // 
            // dgvsecuencia
            // 
            this.dgvsecuencia.DataPropertyName = "secuencia";
            this.dgvsecuencia.FillWeight = 90F;
            this.dgvsecuencia.HeaderText = "Factura";
            this.dgvsecuencia.Name = "dgvsecuencia";
            this.dgvsecuencia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvfecha
            // 
            this.dgvfecha.DataPropertyName = "fechafac";
            this.dgvfecha.FillWeight = 77F;
            this.dgvfecha.HeaderText = "Fecha";
            this.dgvfecha.Name = "dgvfecha";
            this.dgvfecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvreferencia
            // 
            this.dgvreferencia.DataPropertyName = "referencia";
            this.dgvreferencia.HeaderText = "Ref.";
            this.dgvreferencia.Name = "dgvreferencia";
            this.dgvreferencia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvvence
            // 
            this.dgvvence.DataPropertyName = "fechavencimiento";
            this.dgvvence.FillWeight = 77F;
            this.dgvvence.HeaderText = "Vence";
            this.dgvvence.Name = "dgvvence";
            this.dgvvence.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvdias
            // 
            this.dgvdias.DataPropertyName = "dias";
            this.dgvdias.FillWeight = 35F;
            this.dgvdias.HeaderText = "Días";
            this.dgvdias.Name = "dgvdias";
            this.dgvdias.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvtotal
            // 
            this.dgvtotal.DataPropertyName = "total";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.dgvtotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtotal.FillWeight = 85F;
            this.dgvtotal.HeaderText = "Monto";
            this.dgvtotal.Name = "dgvtotal";
            this.dgvtotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvbalance
            // 
            this.dgvbalance.DataPropertyName = "balance";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.dgvbalance.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvbalance.FillWeight = 85F;
            this.dgvbalance.HeaderText = "Balance";
            this.dgvbalance.Name = "dgvbalance";
            this.dgvbalance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvaplicar
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.dgvaplicar.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvaplicar.HeaderText = "Aplicar";
            this.dgvaplicar.Name = "dgvaplicar";
            this.dgvaplicar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvaplicar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel1.ForeColor = System.Drawing.Color.Black;
            this.myLabel1.Location = new System.Drawing.Point(14, 10);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(61, 16);
            this.myLabel1.TabIndex = 364;
            this.myLabel1.Text = "Registro";
            // 
            // Txtchequefuturo
            // 
            this.Txtchequefuturo.BackColor = System.Drawing.SystemColors.Window;
            this.Txtchequefuturo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtchequefuturo.Enabled = false;
            this.Txtchequefuturo.Location = new System.Drawing.Point(93, 7);
            this.Txtchequefuturo.Name = "Txtchequefuturo";
            this.Txtchequefuturo.Size = new System.Drawing.Size(100, 23);
            this.Txtchequefuturo.TabIndex = 376;
            this.Txtchequefuturo.TabStop = false;
            // 
            // Dtpfecha
            // 
            this.Dtpfecha.CustomFormat = "dd/MM/yyyy";
            this.Dtpfecha.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtpfecha.Location = new System.Drawing.Point(274, 7);
            this.Dtpfecha.Name = "Dtpfecha";
            this.Dtpfecha.Size = new System.Drawing.Size(114, 23);
            this.Dtpfecha.TabIndex = 365;
            this.Dtpfecha.Validating += new System.ComponentModel.CancelEventHandler(this.Dtpfecha_Validating);
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(220, 10);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(48, 16);
            this.myLabel2.TabIndex = 368;
            this.myLabel2.Text = "Fecha";
            // 
            // Txtbalance
            // 
            this.Txtbalance.BackColor = System.Drawing.SystemColors.Window;
            this.Txtbalance.Enabled = false;
            this.Txtbalance.Location = new System.Drawing.Point(509, 78);
            this.Txtbalance.Name = "Txtbalance";
            this.Txtbalance.Size = new System.Drawing.Size(100, 23);
            this.Txtbalance.TabIndex = 387;
            this.Txtbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(426, 10);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(77, 16);
            this.myLabel3.TabIndex = 370;
            this.myLabel3.Text = "Referencia";
            // 
            // Txtreferencia
            // 
            this.Txtreferencia.BackColor = System.Drawing.SystemColors.Window;
            this.Txtreferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtreferencia.Location = new System.Drawing.Point(509, 7);
            this.Txtreferencia.Name = "Txtreferencia";
            this.Txtreferencia.Size = new System.Drawing.Size(100, 23);
            this.Txtreferencia.TabIndex = 366;
            // 
            // BtnBuscarVendedor
            // 
            this.BtnBuscarVendedor.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnBuscarVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBuscarVendedor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBuscarVendedor.FlatAppearance.BorderSize = 0;
            this.BtnBuscarVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarVendedor.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarVendedor.Image")));
            this.BtnBuscarVendedor.Location = new System.Drawing.Point(226, 115);
            this.BtnBuscarVendedor.Name = "BtnBuscarVendedor";
            this.BtnBuscarVendedor.Size = new System.Drawing.Size(24, 24);
            this.BtnBuscarVendedor.TabIndex = 372;
            this.BtnBuscarVendedor.TabStop = false;
            this.BtnBuscarVendedor.Text = " ";
            this.toolTip1.SetToolTip(this.BtnBuscarVendedor, "Buscar Vendedor");
            this.BtnBuscarVendedor.UseVisualStyleBackColor = false;
            this.BtnBuscarVendedor.Click += new System.EventHandler(this.BtnBuscarVendedor_Click);
            // 
            // Txtdireccioncliente
            // 
            this.Txtdireccioncliente.BackColor = System.Drawing.SystemColors.Window;
            this.Txtdireccioncliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtdireccioncliente.Enabled = false;
            this.Txtdireccioncliente.Location = new System.Drawing.Point(93, 56);
            this.Txtdireccioncliente.Name = "Txtdireccioncliente";
            this.Txtdireccioncliente.ReadOnly = true;
            this.Txtdireccioncliente.Size = new System.Drawing.Size(516, 23);
            this.Txtdireccioncliente.TabIndex = 386;
            this.Txtdireccioncliente.TabStop = false;
            // 
            // Txtcodigocliente
            // 
            this.Txtcodigocliente.BackColor = System.Drawing.SystemColors.Window;
            this.Txtcodigocliente.Location = new System.Drawing.Point(93, 34);
            this.Txtcodigocliente.MaxLength = 9;
            this.Txtcodigocliente.Name = "Txtcodigocliente";
            this.Txtcodigocliente.Size = new System.Drawing.Size(100, 23);
            this.Txtcodigocliente.TabIndex = 367;
            this.Txtcodigocliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txtcodigocliente.TextChanged += new System.EventHandler(this.Txtcodigocliente_TextChanged);
            this.Txtcodigocliente.Validating += new System.ComponentModel.CancelEventHandler(this.Txtcodigocliente_Validating);
            // 
            // myLabel17
            // 
            this.myLabel17.AutoSize = true;
            this.myLabel17.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel17.ForeColor = System.Drawing.Color.Black;
            this.myLabel17.Location = new System.Drawing.Point(14, 59);
            this.myLabel17.Name = "myLabel17";
            this.myLabel17.Size = new System.Drawing.Size(68, 16);
            this.myLabel17.TabIndex = 385;
            this.myLabel17.Text = "Direccion";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(14, 37);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(53, 16);
            this.myLabel4.TabIndex = 373;
            this.myLabel4.Text = "Cliente";
            // 
            // Txttelefonocliente
            // 
            this.Txttelefonocliente.Enabled = false;
            this.Txttelefonocliente.Location = new System.Drawing.Point(93, 78);
            this.Txttelefonocliente.Mask = "(000)-000-0000";
            this.Txttelefonocliente.Name = "Txttelefonocliente";
            this.Txttelefonocliente.Size = new System.Drawing.Size(109, 23);
            this.Txttelefonocliente.TabIndex = 384;
            // 
            // Txtnombrecliente
            // 
            this.Txtnombrecliente.BackColor = System.Drawing.SystemColors.Window;
            this.Txtnombrecliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtnombrecliente.Enabled = false;
            this.Txtnombrecliente.Location = new System.Drawing.Point(274, 34);
            this.Txtnombrecliente.Name = "Txtnombrecliente";
            this.Txtnombrecliente.ReadOnly = true;
            this.Txtnombrecliente.Size = new System.Drawing.Size(335, 23);
            this.Txtnombrecliente.TabIndex = 375;
            this.Txtnombrecliente.TabStop = false;
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.BtnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarCliente.Image")));
            this.BtnBuscarCliente.Location = new System.Drawing.Point(223, 34);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(24, 24);
            this.BtnBuscarCliente.TabIndex = 369;
            this.BtnBuscarCliente.TabStop = false;
            this.BtnBuscarCliente.Text = " ";
            this.toolTip1.SetToolTip(this.BtnBuscarCliente, "Buscar Cliente");
            this.BtnBuscarCliente.UseVisualStyleBackColor = false;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = true;
            this.myLabel5.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel5.ForeColor = System.Drawing.Color.Black;
            this.myLabel5.Location = new System.Drawing.Point(14, 81);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(64, 16);
            this.myLabel5.TabIndex = 374;
            this.myLabel5.Text = "Telefono";
            // 
            // Txtcodigovendedor
            // 
            this.Txtcodigovendedor.BackColor = System.Drawing.SystemColors.Window;
            this.Txtcodigovendedor.Location = new System.Drawing.Point(93, 114);
            this.Txtcodigovendedor.MaxLength = 9;
            this.Txtcodigovendedor.Name = "Txtcodigovendedor";
            this.Txtcodigovendedor.Size = new System.Drawing.Size(100, 23);
            this.Txtcodigovendedor.TabIndex = 367;
            this.Txtcodigovendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txtcodigovendedor.Validating += new System.ComponentModel.CancelEventHandler(this.Txtcodigovendedor_Validating);
            // 
            // myLabel12
            // 
            this.myLabel12.AutoSize = true;
            this.myLabel12.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel12.ForeColor = System.Drawing.Color.Black;
            this.myLabel12.Location = new System.Drawing.Point(14, 118);
            this.myLabel12.Name = "myLabel12";
            this.myLabel12.Size = new System.Drawing.Size(69, 16);
            this.myLabel12.TabIndex = 377;
            this.myLabel12.Text = "Vendedor";
            // 
            // Ckbimprimir
            // 
            this.Ckbimprimir.AutoSize = true;
            this.Ckbimprimir.Location = new System.Drawing.Point(700, 455);
            this.Ckbimprimir.Name = "Ckbimprimir";
            this.Ckbimprimir.Size = new System.Drawing.Size(78, 20);
            this.Ckbimprimir.TabIndex = 382;
            this.Ckbimprimir.TabStop = false;
            this.Ckbimprimir.Text = "Imprimir";
            this.Ckbimprimir.UseVisualStyleBackColor = true;
            // 
            // Txtnombrevendedor
            // 
            this.Txtnombrevendedor.BackColor = System.Drawing.SystemColors.Window;
            this.Txtnombrevendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtnombrevendedor.Enabled = false;
            this.Txtnombrevendedor.Location = new System.Drawing.Point(277, 114);
            this.Txtnombrevendedor.Name = "Txtnombrevendedor";
            this.Txtnombrevendedor.ReadOnly = true;
            this.Txtnombrevendedor.Size = new System.Drawing.Size(208, 23);
            this.Txtnombrevendedor.TabIndex = 378;
            this.Txtnombrevendedor.TabStop = false;
            // 
            // Cmbmoneda
            // 
            this.Cmbmoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmbmoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbmoneda.FormattingEnabled = true;
            this.Cmbmoneda.Location = new System.Drawing.Point(615, 78);
            this.Cmbmoneda.Name = "Cmbmoneda";
            this.Cmbmoneda.ReadOnly = false;
            this.Cmbmoneda.Size = new System.Drawing.Size(163, 24);
            this.Cmbmoneda.TabIndex = 380;
            this.Cmbmoneda.TabStop = false;
            this.toolTip1.SetToolTip(this.Cmbmoneda, "Selecione Tipo de Moneda");
            // 
            // myLabel14
            // 
            this.myLabel14.AutoSize = true;
            this.myLabel14.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel14.ForeColor = System.Drawing.Color.Black;
            this.myLabel14.Location = new System.Drawing.Point(374, 81);
            this.myLabel14.Name = "myLabel14";
            this.myLabel14.Size = new System.Drawing.Size(129, 16);
            this.myLabel14.TabIndex = 379;
            this.myLabel14.Text = "Balance Pendiente";
            // 
            // myLabel16
            // 
            this.myLabel16.AutoSize = true;
            this.myLabel16.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel16.ForeColor = System.Drawing.Color.Black;
            this.myLabel16.Location = new System.Drawing.Point(612, 60);
            this.myLabel16.Name = "myLabel16";
            this.myLabel16.Size = new System.Drawing.Size(59, 16);
            this.myLabel16.TabIndex = 381;
            this.myLabel16.Text = "Moneda";
            // 
            // Cmbbanco
            // 
            this.Cmbbanco.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmbbanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbbanco.FormattingEnabled = true;
            this.Cmbbanco.Location = new System.Drawing.Point(615, 34);
            this.Cmbbanco.Name = "Cmbbanco";
            this.Cmbbanco.ReadOnly = false;
            this.Cmbbanco.Size = new System.Drawing.Size(163, 24);
            this.Cmbbanco.TabIndex = 389;
            this.Cmbbanco.TabStop = false;
            this.toolTip1.SetToolTip(this.Cmbbanco, "Seleccione entidad Bancaria");
            // 
            // lblBase1
            // 
            this.lblBase1.AutoSize = true;
            this.lblBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase1.ForeColor = System.Drawing.Color.Black;
            this.lblBase1.Location = new System.Drawing.Point(612, 10);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(48, 16);
            this.lblBase1.TabIndex = 390;
            this.lblBase1.Text = "Banco";
            // 
            // Txtaplicar
            // 
            this.Txtaplicar.BackColor = System.Drawing.SystemColors.Window;
            this.Txtaplicar.Location = new System.Drawing.Point(678, 150);
            this.Txtaplicar.MaxLength = 14;
            this.Txtaplicar.Name = "Txtaplicar";
            this.Txtaplicar.Size = new System.Drawing.Size(100, 23);
            this.Txtaplicar.TabIndex = 369;
            this.Txtaplicar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txtaplicar.TextChanged += new System.EventHandler(this.Txtaplicar_TextChanged);
            this.Txtaplicar.Validating += new System.ComponentModel.CancelEventHandler(this.Txtaplicar_Validating);
            // 
            // myLabel7
            // 
            this.myLabel7.AutoSize = true;
            this.myLabel7.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel7.ForeColor = System.Drawing.Color.Black;
            this.myLabel7.Location = new System.Drawing.Point(612, 153);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.Size = new System.Drawing.Size(52, 16);
            this.myLabel7.TabIndex = 392;
            this.myLabel7.Text = "Aplicar";
            // 
            // Txtnock
            // 
            this.Txtnock.Location = new System.Drawing.Point(93, 150);
            this.Txtnock.Name = "Txtnock";
            this.Txtnock.Size = new System.Drawing.Size(100, 23);
            this.Txtnock.TabIndex = 368;
            this.Txtnock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBase2
            // 
            this.lblBase2.AutoSize = true;
            this.lblBase2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase2.ForeColor = System.Drawing.Color.Black;
            this.lblBase2.Location = new System.Drawing.Point(14, 153);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(79, 16);
            this.lblBase2.TabIndex = 394;
            this.lblBase2.Text = "Número CK";
            // 
            // Dtpfechadeposito
            // 
            this.Dtpfechadeposito.CustomFormat = "dd/MM/yyyy";
            this.Dtpfechadeposito.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Dtpfechadeposito.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtpfechadeposito.Location = new System.Drawing.Point(371, 150);
            this.Dtpfechadeposito.Name = "Dtpfechadeposito";
            this.Dtpfechadeposito.Size = new System.Drawing.Size(114, 23);
            this.Dtpfechadeposito.TabIndex = 395;
            this.Dtpfechadeposito.Validating += new System.ComponentModel.CancelEventHandler(this.Dtpfechadeposito_Validating);
            // 
            // lblBase3
            // 
            this.lblBase3.AutoSize = true;
            this.lblBase3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase3.ForeColor = System.Drawing.Color.Black;
            this.lblBase3.Location = new System.Drawing.Point(223, 153);
            this.lblBase3.Name = "lblBase3";
            this.lblBase3.Size = new System.Drawing.Size(110, 16);
            this.lblBase3.TabIndex = 396;
            this.lblBase3.Text = "Fecha Depósito";
            // 
            // cxcprochequefuturo
            // 
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Name = "cxcprochequefuturo";
            this.Load += new System.EventHandler(this.cxcprochequefuturo_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Logistica.GridBase Dgv;
        private Logistica.LblBase myLabel1;
        public Logistica.TxtMayuscula Txtchequefuturo;
        public Logistica.DtpBase Dtpfecha;
        private Logistica.LblBase myLabel2;
        public Logistica.TxtDecimal Txtbalance;
        private Logistica.LblBase myLabel3;
        public Logistica.TxtMayuscula Txtreferencia;
        public Logistica.BtnBuscar BtnBuscarVendedor;
        public Logistica.TxtMayuscula Txtdireccioncliente;
        public Logistica.TxtEntero Txtcodigocliente;
        private Logistica.LblBase myLabel17;
        private Logistica.LblBase myLabel4;
        private Logistica.MskTelefono Txttelefonocliente;
        public Logistica.TxtMayuscula Txtnombrecliente;
        public Logistica.BtnBuscar BtnBuscarCliente;
        private Logistica.LblBase myLabel5;
        public Logistica.TxtEntero Txtcodigovendedor;
        private Logistica.LblBase myLabel12;
        public Logistica.CkbBase Ckbimprimir;
        public Logistica.TxtMayuscula Txtnombrevendedor;
        public Logistica.CmbBase Cmbmoneda;
        private Logistica.LblBase myLabel14;
        private Logistica.LblBase myLabel16;
        public Logistica.CmbBase Cmbbanco;
        private Logistica.LblBase lblBase1;
        public Logistica.TxtDecimal Txtaplicar;
        private Logistica.LblBase myLabel7;
        public Logistica.DtpBase Dtpfechadeposito;
        private Logistica.LblBase lblBase3;
        private Logistica.LblBase lblBase2;
        private Logistica.TxtEntero Txtnock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvidregistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsecuencia;
        private Logistica.GridBase.CalendarColumn dgvfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvreferencia;
        private Logistica.GridBase.CalendarColumn dgvvence;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdias;
        private Logistica.GridBase.DoubleColumn dgvtotal;
        private Logistica.GridBase.DoubleColumn dgvbalance;
        private Logistica.GridBase.DoubleColumn dgvaplicar;
    }
}
