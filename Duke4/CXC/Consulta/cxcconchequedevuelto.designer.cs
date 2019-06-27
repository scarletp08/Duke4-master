namespace Duke4.CXC.Consulta
{
    partial class cxcconchequedevuelto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cxcconchequedevuelto));
            this.gridBase1 = new Duke4.Logistica.GridBase();
            this.dgvsecuencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvfecha = new Duke4.Logistica.GridBase.CalendarColumn();
            this.dgvreferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcargo = new Duke4.Logistica.GridBase.DoubleColumn();
            this.dgvtotal = new Duke4.Logistica.GridBase.DoubleColumn();
            this.dgvidregistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvnulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgventrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpBase1 = new Duke4.Logistica.DtpBase();
            this.dtpBase2 = new Duke4.Logistica.DtpBase();
            this.lblBase1 = new Duke4.Logistica.LblBase();
            this.lblBase2 = new Duke4.Logistica.LblBase();
            this.lblBase3 = new Duke4.Logistica.LblBase();
            this.lblBase4 = new Duke4.Logistica.LblBase();
            this.cmbBase1 = new Duke4.Logistica.CmbBase();
            this.cmbBase2 = new Duke4.Logistica.CmbBase();
            this.Txtcodigocliente = new Duke4.Logistica.TxtEntero();
            this.myLabel4 = new Duke4.Logistica.LblBase();
            this.Txtnombrecliente = new Duke4.Logistica.TxtMayuscula();
            this.BtnBuscarCliente = new Duke4.Logistica.BtnBuscar();
            this.cmbBase3 = new Duke4.Logistica.CmbBase();
            this.txtMayuscula1 = new Duke4.Logistica.TxtMayuscula();
            this.ckbBase1 = new Duke4.Logistica.CkbBase();
            this.lblBase5 = new Duke4.Logistica.LblBase();
            this.Txtcargo = new Duke4.Logistica.TxtDecimal();
            this.Txttotal = new Duke4.Logistica.TxtDecimal();
            this.lblBase6 = new Duke4.Logistica.LblBase();
            this.Txtcantidadregistros = new Duke4.Logistica.TxtEntero();
            this.cmbBase4 = new Duke4.Logistica.CmbBase();
            this.lblBase7 = new Duke4.Logistica.LblBase();
            ((System.ComponentModel.ISupportInitialize)(this.gridBase1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFunctionName
            // 
            this.LblFunctionName.Location = new System.Drawing.Point(738, 100);
            // 
            // FormTitle
            // 
            this.FormTitle.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.FormTitle.ForeColor = System.Drawing.Color.White;
            this.FormTitle.Size = new System.Drawing.Size(88, 23);
            // 
            // gridBase1
            // 
            this.gridBase1.AllowUserToAddRows = false;
            this.gridBase1.AllowUserToDeleteRows = false;
            this.gridBase1.AllowUserToResizeColumns = false;
            this.gridBase1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gridBase1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridBase1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBase1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridBase1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBase1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvsecuencia,
            this.dgvfecha,
            this.dgvreferencia,
            this.dgvnombre,
            this.dgvcargo,
            this.dgvtotal,
            this.dgvidregistro,
            this.dgvnulo,
            this.dgventrada});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 7.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBase1.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridBase1.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.gridBase1.Location = new System.Drawing.Point(13, 232);
            this.gridBase1.MultiSelect = false;
            this.gridBase1.Name = "gridBase1";
            this.gridBase1.RowHeadersVisible = false;
            this.gridBase1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBase1.Size = new System.Drawing.Size(911, 246);
            this.gridBase1.TabIndex = 74;
            this.gridBase1.Sorted += new System.EventHandler(this.gridBase1_Sorted_1);
            // 
            // dgvsecuencia
            // 
            this.dgvsecuencia.DataPropertyName = "secuencia";
            this.dgvsecuencia.FillWeight = 84F;
            this.dgvsecuencia.HeaderText = "Registro";
            this.dgvsecuencia.MinimumWidth = 84;
            this.dgvsecuencia.Name = "dgvsecuencia";
            this.dgvsecuencia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvfecha
            // 
            this.dgvfecha.DataPropertyName = "fecha";
            this.dgvfecha.FillWeight = 72F;
            this.dgvfecha.HeaderText = "Fecha";
            this.dgvfecha.MinimumWidth = 72;
            this.dgvfecha.Name = "dgvfecha";
            this.dgvfecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvfecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvreferencia
            // 
            this.dgvreferencia.DataPropertyName = "referencia";
            this.dgvreferencia.FillWeight = 84F;
            this.dgvreferencia.HeaderText = "NO. CK";
            this.dgvreferencia.MinimumWidth = 84;
            this.dgvreferencia.Name = "dgvreferencia";
            this.dgvreferencia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvnombre
            // 
            this.dgvnombre.DataPropertyName = "nombre";
            this.dgvnombre.FillWeight = 190F;
            this.dgvnombre.HeaderText = "Cliente";
            this.dgvnombre.MinimumWidth = 190;
            this.dgvnombre.Name = "dgvnombre";
            this.dgvnombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvcargo
            // 
            this.dgvcargo.DataPropertyName = "totalcargo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.dgvcargo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcargo.FillWeight = 88F;
            this.dgvcargo.HeaderText = "Cargo";
            this.dgvcargo.MinimumWidth = 88;
            this.dgvcargo.Name = "dgvcargo";
            this.dgvcargo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcargo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvtotal
            // 
            this.dgvtotal.DataPropertyName = "total";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.dgvtotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtotal.FillWeight = 88F;
            this.dgvtotal.HeaderText = "Monto";
            this.dgvtotal.MinimumWidth = 88;
            this.dgvtotal.Name = "dgvtotal";
            this.dgvtotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvidregistro
            // 
            this.dgvidregistro.DataPropertyName = "idregistro";
            this.dgvidregistro.HeaderText = "Idregistro";
            this.dgvidregistro.Name = "dgvidregistro";
            this.dgvidregistro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvidregistro.Visible = false;
            // 
            // dgvnulo
            // 
            this.dgvnulo.DataPropertyName = "nulo";
            this.dgvnulo.HeaderText = "Nulo";
            this.dgvnulo.Name = "dgvnulo";
            this.dgvnulo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvnulo.Visible = false;
            // 
            // dgventrada
            // 
            this.dgventrada.DataPropertyName = "entrada";
            this.dgventrada.FillWeight = 84F;
            this.dgventrada.HeaderText = "#Entrada";
            this.dgventrada.MinimumWidth = 84;
            this.dgventrada.Name = "dgventrada";
            this.dgventrada.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dtpBase1
            // 
            this.dtpBase1.CustomFormat = "dd/MM/yyyy";
            this.dtpBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.dtpBase1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBase1.Location = new System.Drawing.Point(80, 160);
            this.dtpBase1.Name = "dtpBase1";
            this.dtpBase1.Size = new System.Drawing.Size(114, 23);
            this.dtpBase1.TabIndex = 75;
            // 
            // dtpBase2
            // 
            this.dtpBase2.CustomFormat = "dd/MM/yyyy";
            this.dtpBase2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.dtpBase2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBase2.Location = new System.Drawing.Point(80, 189);
            this.dtpBase2.Name = "dtpBase2";
            this.dtpBase2.Size = new System.Drawing.Size(114, 23);
            this.dtpBase2.TabIndex = 76;
            // 
            // lblBase1
            // 
            this.lblBase1.AutoSize = true;
            this.lblBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase1.ForeColor = System.Drawing.Color.Black;
            this.lblBase1.Location = new System.Drawing.Point(13, 165);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(48, 16);
            this.lblBase1.TabIndex = 77;
            this.lblBase1.Text = "Desde";
            // 
            // lblBase2
            // 
            this.lblBase2.AutoSize = true;
            this.lblBase2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase2.ForeColor = System.Drawing.Color.Black;
            this.lblBase2.Location = new System.Drawing.Point(13, 194);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(46, 16);
            this.lblBase2.TabIndex = 78;
            this.lblBase2.Text = "Hasta";
            // 
            // lblBase3
            // 
            this.lblBase3.AutoSize = true;
            this.lblBase3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase3.ForeColor = System.Drawing.Color.Black;
            this.lblBase3.Location = new System.Drawing.Point(214, 165);
            this.lblBase3.Name = "lblBase3";
            this.lblBase3.Size = new System.Drawing.Size(59, 16);
            this.lblBase3.TabIndex = 79;
            this.lblBase3.Text = "Moneda";
            // 
            // lblBase4
            // 
            this.lblBase4.AutoSize = true;
            this.lblBase4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase4.ForeColor = System.Drawing.Color.Black;
            this.lblBase4.Location = new System.Drawing.Point(214, 194);
            this.lblBase4.Name = "lblBase4";
            this.lblBase4.Size = new System.Drawing.Size(64, 16);
            this.lblBase4.TabIndex = 80;
            this.lblBase4.Text = "Sucursal";
            // 
            // cmbBase1
            // 
            this.cmbBase1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBase1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBase1.FormattingEnabled = true;
            this.cmbBase1.Location = new System.Drawing.Point(291, 159);
            this.cmbBase1.Name = "cmbBase1";
            this.cmbBase1.ReadOnly = false;
            this.cmbBase1.Size = new System.Drawing.Size(121, 24);
            this.cmbBase1.TabIndex = 81;
            this.cmbBase1.TabStop = false;
            // 
            // cmbBase2
            // 
            this.cmbBase2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBase2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBase2.FormattingEnabled = true;
            this.cmbBase2.Location = new System.Drawing.Point(291, 186);
            this.cmbBase2.Name = "cmbBase2";
            this.cmbBase2.ReadOnly = false;
            this.cmbBase2.Size = new System.Drawing.Size(121, 24);
            this.cmbBase2.TabIndex = 82;
            this.cmbBase2.TabStop = false;
            // 
            // Txtcodigocliente
            // 
            this.Txtcodigocliente.BackColor = System.Drawing.SystemColors.Window;
            this.Txtcodigocliente.Location = new System.Drawing.Point(471, 159);
            this.Txtcodigocliente.MaxLength = 9;
            this.Txtcodigocliente.Name = "Txtcodigocliente";
            this.Txtcodigocliente.Size = new System.Drawing.Size(69, 23);
            this.Txtcodigocliente.TabIndex = 289;
            this.Txtcodigocliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txtcodigocliente.TextChanged += new System.EventHandler(this.Txtcodigocliente_TextChanged);
            this.Txtcodigocliente.Validating += new System.ComponentModel.CancelEventHandler(this.Txtcodigocliente_Validating);
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(421, 162);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(53, 16);
            this.myLabel4.TabIndex = 291;
            this.myLabel4.Text = "Cliente";
            // 
            // Txtnombrecliente
            // 
            this.Txtnombrecliente.BackColor = System.Drawing.SystemColors.Window;
            this.Txtnombrecliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtnombrecliente.Enabled = false;
            this.Txtnombrecliente.Location = new System.Drawing.Point(566, 159);
            this.Txtnombrecliente.Name = "Txtnombrecliente";
            this.Txtnombrecliente.ReadOnly = true;
            this.Txtnombrecliente.Size = new System.Drawing.Size(358, 23);
            this.Txtnombrecliente.TabIndex = 292;
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
            this.BtnBuscarCliente.Location = new System.Drawing.Point(536, 159);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(24, 24);
            this.BtnBuscarCliente.TabIndex = 290;
            this.BtnBuscarCliente.TabStop = false;
            this.BtnBuscarCliente.Text = " ";
            this.toolTip1.SetToolTip(this.BtnBuscarCliente, "Buscar Cliente");
            this.BtnBuscarCliente.UseVisualStyleBackColor = false;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // cmbBase3
            // 
            this.cmbBase3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBase3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBase3.FormattingEnabled = true;
            this.cmbBase3.Items.AddRange(new object[] {
            "Secuencia",
            "NO. CK"});
            this.cmbBase3.Location = new System.Drawing.Point(424, 186);
            this.cmbBase3.Name = "cmbBase3";
            this.cmbBase3.ReadOnly = false;
            this.cmbBase3.Size = new System.Drawing.Size(97, 24);
            this.cmbBase3.TabIndex = 293;
            this.cmbBase3.TabStop = false;
            // 
            // txtMayuscula1
            // 
            this.txtMayuscula1.BackColor = System.Drawing.Color.PeachPuff;
            this.txtMayuscula1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMayuscula1.Location = new System.Drawing.Point(527, 187);
            this.txtMayuscula1.Name = "txtMayuscula1";
            this.txtMayuscula1.Size = new System.Drawing.Size(165, 23);
            this.txtMayuscula1.TabIndex = 294;
            this.txtMayuscula1.TabStop = false;
            this.txtMayuscula1.Validating += new System.ComponentModel.CancelEventHandler(this.txtMayuscula1_Validating);
            // 
            // ckbBase1
            // 
            this.ckbBase1.AutoSize = true;
            this.ckbBase1.Location = new System.Drawing.Point(771, 188);
            this.ckbBase1.Name = "ckbBase1";
            this.ckbBase1.Size = new System.Drawing.Size(153, 20);
            this.ckbBase1.TabIndex = 295;
            this.ckbBase1.TabStop = false;
            this.ckbBase1.Text = "Ver Registros Nulos";
            this.ckbBase1.UseVisualStyleBackColor = true;
            this.ckbBase1.CheckedChanged += new System.EventHandler(this.ckbBase1_CheckedChanged);
            // 
            // lblBase5
            // 
            this.lblBase5.AutoSize = true;
            this.lblBase5.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase5.ForeColor = System.Drawing.Color.Black;
            this.lblBase5.Location = new System.Drawing.Point(568, 478);
            this.lblBase5.Name = "lblBase5";
            this.lblBase5.Size = new System.Drawing.Size(56, 16);
            this.lblBase5.TabIndex = 296;
            this.lblBase5.Text = "Totales";
            // 
            // Txtcargo
            // 
            this.Txtcargo.Enabled = false;
            this.Txtcargo.Location = new System.Drawing.Point(624, 478);
            this.Txtcargo.Name = "Txtcargo";
            this.Txtcargo.Size = new System.Drawing.Size(90, 23);
            this.Txtcargo.TabIndex = 297;
            this.Txtcargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Txttotal
            // 
            this.Txttotal.Enabled = false;
            this.Txttotal.Location = new System.Drawing.Point(713, 478);
            this.Txttotal.Name = "Txttotal";
            this.Txttotal.Size = new System.Drawing.Size(90, 23);
            this.Txttotal.TabIndex = 298;
            this.Txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBase6
            // 
            this.lblBase6.AutoSize = true;
            this.lblBase6.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase6.ForeColor = System.Drawing.Color.Black;
            this.lblBase6.Location = new System.Drawing.Point(13, 478);
            this.lblBase6.Name = "lblBase6";
            this.lblBase6.Size = new System.Drawing.Size(111, 16);
            this.lblBase6.TabIndex = 299;
            this.lblBase6.Text = "No de Registros";
            // 
            // Txtcantidadregistros
            // 
            this.Txtcantidadregistros.Enabled = false;
            this.Txtcantidadregistros.Location = new System.Drawing.Point(130, 478);
            this.Txtcantidadregistros.Name = "Txtcantidadregistros";
            this.Txtcantidadregistros.Size = new System.Drawing.Size(100, 23);
            this.Txtcantidadregistros.TabIndex = 300;
            this.Txtcantidadregistros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbBase4
            // 
            this.cmbBase4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBase4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBase4.FormattingEnabled = true;
            this.cmbBase4.Location = new System.Drawing.Point(301, 478);
            this.cmbBase4.Name = "cmbBase4";
            this.cmbBase4.ReadOnly = false;
            this.cmbBase4.Size = new System.Drawing.Size(220, 24);
            this.cmbBase4.TabIndex = 304;
            this.cmbBase4.TabStop = false;
            // 
            // lblBase7
            // 
            this.lblBase7.AutoSize = true;
            this.lblBase7.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase7.ForeColor = System.Drawing.Color.Black;
            this.lblBase7.Location = new System.Drawing.Point(236, 481);
            this.lblBase7.Name = "lblBase7";
            this.lblBase7.Size = new System.Drawing.Size(62, 16);
            this.lblBase7.TabIndex = 303;
            this.lblBase7.Text = "Formato";
            // 
            // cxcconchequedevuelto
            // 
            this.ClientSize = new System.Drawing.Size(935, 523);
            this.Controls.Add(this.cmbBase4);
            this.Controls.Add(this.lblBase7);
            this.Controls.Add(this.Txtcantidadregistros);
            this.Controls.Add(this.lblBase6);
            this.Controls.Add(this.Txttotal);
            this.Controls.Add(this.Txtcargo);
            this.Controls.Add(this.lblBase5);
            this.Controls.Add(this.ckbBase1);
            this.Controls.Add(this.txtMayuscula1);
            this.Controls.Add(this.cmbBase3);
            this.Controls.Add(this.Txtcodigocliente);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.Txtnombrecliente);
            this.Controls.Add(this.BtnBuscarCliente);
            this.Controls.Add(this.cmbBase2);
            this.Controls.Add(this.cmbBase1);
            this.Controls.Add(this.lblBase4);
            this.Controls.Add(this.lblBase3);
            this.Controls.Add(this.lblBase2);
            this.Controls.Add(this.lblBase1);
            this.Controls.Add(this.dtpBase2);
            this.Controls.Add(this.dtpBase1);
            this.Controls.Add(this.gridBase1);
            this.Name = "cxcconchequedevuelto";
            this.Load += new System.EventHandler(this.cxcconregistro_Load);
            this.Controls.SetChildIndex(this.LblFunctionName, 0);
            this.Controls.SetChildIndex(this.gridBase1, 0);
            this.Controls.SetChildIndex(this.dtpBase1, 0);
            this.Controls.SetChildIndex(this.dtpBase2, 0);
            this.Controls.SetChildIndex(this.lblBase1, 0);
            this.Controls.SetChildIndex(this.lblBase2, 0);
            this.Controls.SetChildIndex(this.lblBase3, 0);
            this.Controls.SetChildIndex(this.lblBase4, 0);
            this.Controls.SetChildIndex(this.cmbBase1, 0);
            this.Controls.SetChildIndex(this.cmbBase2, 0);
            this.Controls.SetChildIndex(this.BtnBuscarCliente, 0);
            this.Controls.SetChildIndex(this.Txtnombrecliente, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.Txtcodigocliente, 0);
            this.Controls.SetChildIndex(this.cmbBase3, 0);
            this.Controls.SetChildIndex(this.txtMayuscula1, 0);
            this.Controls.SetChildIndex(this.ckbBase1, 0);
            this.Controls.SetChildIndex(this.lblBase5, 0);
            this.Controls.SetChildIndex(this.Txtcargo, 0);
            this.Controls.SetChildIndex(this.Txttotal, 0);
            this.Controls.SetChildIndex(this.lblBase6, 0);
            this.Controls.SetChildIndex(this.Txtcantidadregistros, 0);
            this.Controls.SetChildIndex(this.lblBase7, 0);
            this.Controls.SetChildIndex(this.cmbBase4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridBase1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Logistica.GridBase gridBase1;
        private Logistica.DtpBase dtpBase1;
        private Logistica.DtpBase dtpBase2;
        private Logistica.LblBase lblBase1;
        private Logistica.LblBase lblBase2;
        private Logistica.LblBase lblBase3;
        private Logistica.LblBase lblBase4;
        private Logistica.CmbBase cmbBase1;
        private Logistica.CmbBase cmbBase2;
        public Logistica.TxtEntero Txtcodigocliente;
        private Logistica.LblBase myLabel4;
        public Logistica.TxtMayuscula Txtnombrecliente;
        public Logistica.BtnBuscar BtnBuscarCliente;
        private Logistica.CmbBase cmbBase3;
        public Logistica.TxtMayuscula txtMayuscula1;
        private Logistica.CkbBase ckbBase1;
        private Logistica.LblBase lblBase5;
        private Logistica.TxtDecimal Txtcargo;
        private Logistica.TxtDecimal Txttotal;
        private Logistica.LblBase lblBase6;
        private Logistica.TxtEntero Txtcantidadregistros;
        private Logistica.CmbBase cmbBase4;
        private Logistica.LblBase lblBase7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsecuencia;
        private Logistica.GridBase.CalendarColumn dgvfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvreferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvnombre;
        private Logistica.GridBase.DoubleColumn dgvcargo;
        private Logistica.GridBase.DoubleColumn dgvtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvidregistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvnulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgventrada;
    }
}
