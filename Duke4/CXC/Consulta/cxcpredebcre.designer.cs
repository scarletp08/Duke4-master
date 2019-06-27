namespace Duke4.CXC.Consulta
{
    partial class cxcpredebcre
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Mskncf = new Duke4.Logistica.MskNCF();
            this.lblBase2 = new Duke4.Logistica.LblBase();
            this.Txtconcepto = new Duke4.Logistica.TxtMayuscula();
            this.lblBase5 = new Duke4.Logistica.LblBase();
            this.lblBase4 = new Duke4.Logistica.LblBase();
            this.Txtitbis = new Duke4.Logistica.TxtDecimal();
            this.Txtsubtotal = new Duke4.Logistica.TxtDecimal();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBase1 = new Duke4.Logistica.LblBase();
            this.Rbndebito = new System.Windows.Forms.RadioButton();
            this.Rbncredito = new System.Windows.Forms.RadioButton();
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
            this.dgvitbis = new Duke4.Logistica.GridBase.DoubleColumn();
            this.dgvncf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtotalimporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtotalexento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtotalitbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.myLabel1 = new Duke4.Logistica.LblBase();
            this.Txtregistro = new Duke4.Logistica.TxtMayuscula();
            this.Dtpfecha = new Duke4.Logistica.DtpBase();
            this.myLabel2 = new Duke4.Logistica.LblBase();
            this.Txtbalance = new Duke4.Logistica.TxtDecimal();
            this.myLabel3 = new Duke4.Logistica.LblBase();
            this.Txtreferencia = new Duke4.Logistica.TxtMayuscula();
            this.Txtdireccioncliente = new Duke4.Logistica.TxtMayuscula();
            this.Txtcodigocliente = new Duke4.Logistica.TxtEntero();
            this.myLabel17 = new Duke4.Logistica.LblBase();
            this.myLabel4 = new Duke4.Logistica.LblBase();
            this.Txttelefonocliente = new Duke4.Logistica.MskTelefono();
            this.Txtnombrecliente = new Duke4.Logistica.TxtMayuscula();
            this.myLabel5 = new Duke4.Logistica.LblBase();
            this.label1 = new System.Windows.Forms.Label();
            this.Txttotal = new Duke4.Logistica.TxtTotal();
            this.Txtcodigovendedor = new Duke4.Logistica.TxtEntero();
            this.myLabel12 = new Duke4.Logistica.LblBase();
            this.Txtnombrevendedor = new Duke4.Logistica.TxtMayuscula();
            this.Cmbmoneda = new Duke4.Logistica.CmbBase();
            this.myLabel14 = new Duke4.Logistica.LblBase();
            this.myLabel16 = new Duke4.Logistica.LblBase();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFunctionName
            // 
            this.LblFunctionName.Location = new System.Drawing.Point(614, 100);
            this.LblFunctionName.Size = new System.Drawing.Size(163, 32);
            this.LblFunctionName.Text = "     Letrero";
            // 
            // Mskncf
            // 
            this.Mskncf.Location = new System.Drawing.Point(614, 306);
            this.Mskncf.Mask = "A0000000000";
            this.Mskncf.Name = "Mskncf";
            this.Mskncf.Size = new System.Drawing.Size(163, 23);
            this.Mskncf.TabIndex = 398;
            // 
            // lblBase2
            // 
            this.lblBase2.AutoSize = true;
            this.lblBase2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase2.ForeColor = System.Drawing.Color.Black;
            this.lblBase2.Location = new System.Drawing.Point(15, 290);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(71, 16);
            this.lblBase2.TabIndex = 397;
            this.lblBase2.Text = "Concepto";
            // 
            // Txtconcepto
            // 
            this.Txtconcepto.BackColor = System.Drawing.SystemColors.Window;
            this.Txtconcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtconcepto.Location = new System.Drawing.Point(92, 287);
            this.Txtconcepto.Multiline = true;
            this.Txtconcepto.Name = "Txtconcepto";
            this.Txtconcepto.Size = new System.Drawing.Size(516, 45);
            this.Txtconcepto.TabIndex = 396;
            this.Txtconcepto.TabStop = false;
            // 
            // lblBase5
            // 
            this.lblBase5.AutoSize = true;
            this.lblBase5.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase5.ForeColor = System.Drawing.Color.Black;
            this.lblBase5.Location = new System.Drawing.Point(496, 648);
            this.lblBase5.Name = "lblBase5";
            this.lblBase5.Size = new System.Drawing.Size(37, 16);
            this.lblBase5.TabIndex = 395;
            this.lblBase5.Text = "Itbis";
            // 
            // lblBase4
            // 
            this.lblBase4.AutoSize = true;
            this.lblBase4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase4.ForeColor = System.Drawing.Color.Black;
            this.lblBase4.Location = new System.Drawing.Point(496, 629);
            this.lblBase4.Name = "lblBase4";
            this.lblBase4.Size = new System.Drawing.Size(64, 16);
            this.lblBase4.TabIndex = 394;
            this.lblBase4.Text = "Subtotal";
            // 
            // Txtitbis
            // 
            this.Txtitbis.Enabled = false;
            this.Txtitbis.Location = new System.Drawing.Point(665, 645);
            this.Txtitbis.Name = "Txtitbis";
            this.Txtitbis.Size = new System.Drawing.Size(100, 23);
            this.Txtitbis.TabIndex = 393;
            this.Txtitbis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Txtsubtotal
            // 
            this.Txtsubtotal.Enabled = false;
            this.Txtsubtotal.Location = new System.Drawing.Point(665, 616);
            this.Txtsubtotal.Name = "Txtsubtotal";
            this.Txtsubtotal.Size = new System.Drawing.Size(100, 23);
            this.Txtsubtotal.TabIndex = 392;
            this.Txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBase1);
            this.panel1.Controls.Add(this.Rbndebito);
            this.panel1.Controls.Add(this.Rbncredito);
            this.panel1.Location = new System.Drawing.Point(613, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 70);
            this.panel1.TabIndex = 391;
            // 
            // lblBase1
            // 
            this.lblBase1.AutoSize = true;
            this.lblBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase1.ForeColor = System.Drawing.Color.Black;
            this.lblBase1.Location = new System.Drawing.Point(3, 7);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(36, 16);
            this.lblBase1.TabIndex = 217;
            this.lblBase1.Text = "Tipo";
            // 
            // Rbndebito
            // 
            this.Rbndebito.AutoSize = true;
            this.Rbndebito.Location = new System.Drawing.Point(6, 26);
            this.Rbndebito.Name = "Rbndebito";
            this.Rbndebito.Size = new System.Drawing.Size(151, 20);
            this.Rbndebito.TabIndex = 215;
            this.Rbndebito.Text = "Nota de Débito (+)";
            this.Rbndebito.UseVisualStyleBackColor = true;
            // 
            // Rbncredito
            // 
            this.Rbncredito.AutoSize = true;
            this.Rbncredito.Location = new System.Drawing.Point(6, 47);
            this.Rbncredito.Name = "Rbncredito";
            this.Rbncredito.Size = new System.Drawing.Size(154, 20);
            this.Rbncredito.TabIndex = 216;
            this.Rbncredito.Text = "Nota de Crédito (-)";
            this.Rbncredito.UseVisualStyleBackColor = true;
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
            this.dgvaplicar,
            this.dgvitbis,
            this.dgvncf,
            this.dgvtotalimporte,
            this.dgvtotalexento,
            this.dgvtotalitbis,
            this.dgvcheck});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 7.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.Dgv.Location = new System.Drawing.Point(16, 335);
            this.Dgv.MultiSelect = false;
            this.Dgv.Name = "Dgv";
            this.Dgv.RowHeadersVisible = false;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(761, 275);
            this.Dgv.TabIndex = 390;
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
            this.dgvtotal.DataPropertyName = "totalfac";
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
            this.dgvaplicar.DataPropertyName = "total";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.dgvaplicar.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvaplicar.FillWeight = 90F;
            this.dgvaplicar.HeaderText = "Aplicar";
            this.dgvaplicar.Name = "dgvaplicar";
            this.dgvaplicar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvitbis
            // 
            this.dgvitbis.DataPropertyName = "itbis";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.dgvitbis.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvitbis.HeaderText = "Itbis";
            this.dgvitbis.Name = "dgvitbis";
            this.dgvitbis.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvitbis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvncf
            // 
            this.dgvncf.DataPropertyName = "ncf";
            this.dgvncf.HeaderText = "NCF";
            this.dgvncf.Name = "dgvncf";
            this.dgvncf.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvncf.Visible = false;
            // 
            // dgvtotalimporte
            // 
            this.dgvtotalimporte.DataPropertyName = "totalimporte";
            this.dgvtotalimporte.HeaderText = "Total Importe";
            this.dgvtotalimporte.Name = "dgvtotalimporte";
            this.dgvtotalimporte.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtotalimporte.Visible = false;
            // 
            // dgvtotalexento
            // 
            this.dgvtotalexento.DataPropertyName = "totalexento";
            this.dgvtotalexento.HeaderText = "Total Exento";
            this.dgvtotalexento.Name = "dgvtotalexento";
            this.dgvtotalexento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtotalexento.Visible = false;
            // 
            // dgvtotalitbis
            // 
            this.dgvtotalitbis.DataPropertyName = "totalitbis";
            this.dgvtotalitbis.HeaderText = "Total Itbis";
            this.dgvtotalitbis.Name = "dgvtotalitbis";
            this.dgvtotalitbis.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtotalitbis.Visible = false;
            // 
            // dgvcheck
            // 
            this.dgvcheck.HeaderText = "Inc";
            this.dgvcheck.Name = "dgvcheck";
            this.dgvcheck.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel1.ForeColor = System.Drawing.Color.Black;
            this.myLabel1.Location = new System.Drawing.Point(13, 142);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(61, 16);
            this.myLabel1.TabIndex = 364;
            this.myLabel1.Text = "Registro";
            // 
            // Txtregistro
            // 
            this.Txtregistro.BackColor = System.Drawing.SystemColors.Window;
            this.Txtregistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtregistro.Enabled = false;
            this.Txtregistro.Location = new System.Drawing.Point(92, 139);
            this.Txtregistro.Name = "Txtregistro";
            this.Txtregistro.Size = new System.Drawing.Size(100, 23);
            this.Txtregistro.TabIndex = 376;
            this.Txtregistro.TabStop = false;
            this.Txtregistro.TextChanged += new System.EventHandler(this.Txtregistro_TextChanged);
            // 
            // Dtpfecha
            // 
            this.Dtpfecha.CustomFormat = "dd/MM/yyyy";
            this.Dtpfecha.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtpfecha.Location = new System.Drawing.Point(273, 137);
            this.Dtpfecha.Name = "Dtpfecha";
            this.Dtpfecha.Size = new System.Drawing.Size(114, 23);
            this.Dtpfecha.TabIndex = 365;
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(219, 142);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(48, 16);
            this.myLabel2.TabIndex = 368;
            this.myLabel2.Text = "Fecha";
            // 
            // Txtbalance
            // 
            this.Txtbalance.BackColor = System.Drawing.SystemColors.Window;
            this.Txtbalance.Enabled = false;
            this.Txtbalance.Location = new System.Drawing.Point(508, 210);
            this.Txtbalance.Name = "Txtbalance";
            this.Txtbalance.Size = new System.Drawing.Size(100, 23);
            this.Txtbalance.TabIndex = 389;
            this.Txtbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(425, 140);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(77, 16);
            this.myLabel3.TabIndex = 370;
            this.myLabel3.Text = "Referencia";
            // 
            // Txtreferencia
            // 
            this.Txtreferencia.BackColor = System.Drawing.SystemColors.Window;
            this.Txtreferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtreferencia.Location = new System.Drawing.Point(508, 135);
            this.Txtreferencia.Name = "Txtreferencia";
            this.Txtreferencia.Size = new System.Drawing.Size(100, 23);
            this.Txtreferencia.TabIndex = 366;
            // 
            // Txtdireccioncliente
            // 
            this.Txtdireccioncliente.BackColor = System.Drawing.SystemColors.Window;
            this.Txtdireccioncliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtdireccioncliente.Enabled = false;
            this.Txtdireccioncliente.Location = new System.Drawing.Point(92, 188);
            this.Txtdireccioncliente.Name = "Txtdireccioncliente";
            this.Txtdireccioncliente.ReadOnly = true;
            this.Txtdireccioncliente.Size = new System.Drawing.Size(516, 23);
            this.Txtdireccioncliente.TabIndex = 388;
            this.Txtdireccioncliente.TabStop = false;
            // 
            // Txtcodigocliente
            // 
            this.Txtcodigocliente.BackColor = System.Drawing.SystemColors.Window;
            this.Txtcodigocliente.Location = new System.Drawing.Point(92, 166);
            this.Txtcodigocliente.MaxLength = 9;
            this.Txtcodigocliente.Name = "Txtcodigocliente";
            this.Txtcodigocliente.Size = new System.Drawing.Size(100, 23);
            this.Txtcodigocliente.TabIndex = 367;
            this.Txtcodigocliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // myLabel17
            // 
            this.myLabel17.AutoSize = true;
            this.myLabel17.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel17.ForeColor = System.Drawing.Color.Black;
            this.myLabel17.Location = new System.Drawing.Point(13, 191);
            this.myLabel17.Name = "myLabel17";
            this.myLabel17.Size = new System.Drawing.Size(68, 16);
            this.myLabel17.TabIndex = 387;
            this.myLabel17.Text = "Direccion";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(13, 169);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(53, 16);
            this.myLabel4.TabIndex = 373;
            this.myLabel4.Text = "Cliente";
            // 
            // Txttelefonocliente
            // 
            this.Txttelefonocliente.Enabled = false;
            this.Txttelefonocliente.Location = new System.Drawing.Point(92, 210);
            this.Txttelefonocliente.Mask = "(000)-000-0000";
            this.Txttelefonocliente.Name = "Txttelefonocliente";
            this.Txttelefonocliente.Size = new System.Drawing.Size(109, 23);
            this.Txttelefonocliente.TabIndex = 386;
            // 
            // Txtnombrecliente
            // 
            this.Txtnombrecliente.BackColor = System.Drawing.SystemColors.Window;
            this.Txtnombrecliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtnombrecliente.Enabled = false;
            this.Txtnombrecliente.Location = new System.Drawing.Point(222, 166);
            this.Txtnombrecliente.Name = "Txtnombrecliente";
            this.Txtnombrecliente.ReadOnly = true;
            this.Txtnombrecliente.Size = new System.Drawing.Size(386, 23);
            this.Txtnombrecliente.TabIndex = 375;
            this.Txtnombrecliente.TabStop = false;
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = true;
            this.myLabel5.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel5.ForeColor = System.Drawing.Color.Black;
            this.myLabel5.Location = new System.Drawing.Point(13, 213);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(64, 16);
            this.myLabel5.TabIndex = 374;
            this.myLabel5.Text = "Telefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 678);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 385;
            this.label1.Text = "Total Cobrado   ";
            // 
            // Txttotal
            // 
            this.Txttotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Txttotal.Enabled = false;
            this.Txttotal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txttotal.Location = new System.Drawing.Point(665, 675);
            this.Txttotal.MaxLength = 21;
            this.Txttotal.Name = "Txttotal";
            this.Txttotal.Size = new System.Drawing.Size(100, 31);
            this.Txttotal.TabIndex = 384;
            this.Txttotal.TabStop = false;
            this.Txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Txtcodigovendedor
            // 
            this.Txtcodigovendedor.BackColor = System.Drawing.SystemColors.Window;
            this.Txtcodigovendedor.Location = new System.Drawing.Point(92, 253);
            this.Txtcodigovendedor.MaxLength = 9;
            this.Txtcodigovendedor.Name = "Txtcodigovendedor";
            this.Txtcodigovendedor.Size = new System.Drawing.Size(100, 23);
            this.Txtcodigovendedor.TabIndex = 371;
            this.Txtcodigovendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // myLabel12
            // 
            this.myLabel12.AutoSize = true;
            this.myLabel12.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel12.ForeColor = System.Drawing.Color.Black;
            this.myLabel12.Location = new System.Drawing.Point(13, 257);
            this.myLabel12.Name = "myLabel12";
            this.myLabel12.Size = new System.Drawing.Size(69, 16);
            this.myLabel12.TabIndex = 377;
            this.myLabel12.Text = "Vendedor";
            // 
            // Txtnombrevendedor
            // 
            this.Txtnombrevendedor.BackColor = System.Drawing.SystemColors.Window;
            this.Txtnombrevendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtnombrevendedor.Enabled = false;
            this.Txtnombrevendedor.Location = new System.Drawing.Point(222, 253);
            this.Txtnombrevendedor.Name = "Txtnombrevendedor";
            this.Txtnombrevendedor.ReadOnly = true;
            this.Txtnombrevendedor.Size = new System.Drawing.Size(262, 23);
            this.Txtnombrevendedor.TabIndex = 378;
            this.Txtnombrevendedor.TabStop = false;
            // 
            // Cmbmoneda
            // 
            this.Cmbmoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmbmoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbmoneda.FormattingEnabled = true;
            this.Cmbmoneda.Location = new System.Drawing.Point(669, 242);
            this.Cmbmoneda.Name = "Cmbmoneda";
            this.Cmbmoneda.ReadOnly = false;
            this.Cmbmoneda.Size = new System.Drawing.Size(108, 24);
            this.Cmbmoneda.TabIndex = 380;
            this.Cmbmoneda.TabStop = false;
            // 
            // myLabel14
            // 
            this.myLabel14.AutoSize = true;
            this.myLabel14.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel14.ForeColor = System.Drawing.Color.Black;
            this.myLabel14.Location = new System.Drawing.Point(373, 213);
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
            this.myLabel16.Location = new System.Drawing.Point(611, 245);
            this.myLabel16.Name = "myLabel16";
            this.myLabel16.Size = new System.Drawing.Size(59, 16);
            this.myLabel16.TabIndex = 381;
            this.myLabel16.Text = "Moneda";
            // 
            // cxcpredebcre
            // 
            this.ClientSize = new System.Drawing.Size(797, 725);
            this.Controls.Add(this.Mskncf);
            this.Controls.Add(this.lblBase2);
            this.Controls.Add(this.Txtconcepto);
            this.Controls.Add(this.lblBase5);
            this.Controls.Add(this.lblBase4);
            this.Controls.Add(this.Txtitbis);
            this.Controls.Add(this.Txtsubtotal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.myLabel1);
            this.Controls.Add(this.Txtregistro);
            this.Controls.Add(this.Dtpfecha);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.Txtbalance);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.Txtreferencia);
            this.Controls.Add(this.Txtdireccioncliente);
            this.Controls.Add(this.Txtcodigocliente);
            this.Controls.Add(this.myLabel17);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.Txttelefonocliente);
            this.Controls.Add(this.Txtnombrecliente);
            this.Controls.Add(this.myLabel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txttotal);
            this.Controls.Add(this.Txtcodigovendedor);
            this.Controls.Add(this.myLabel12);
            this.Controls.Add(this.Txtnombrevendedor);
            this.Controls.Add(this.Cmbmoneda);
            this.Controls.Add(this.myLabel14);
            this.Controls.Add(this.myLabel16);
            this.Name = "cxcpredebcre";
            this.Load += new System.EventHandler(this.cxcpredebcre_Load);
            this.Controls.SetChildIndex(this.LblFunctionName, 0);
            this.Controls.SetChildIndex(this.myLabel16, 0);
            this.Controls.SetChildIndex(this.myLabel14, 0);
            this.Controls.SetChildIndex(this.Cmbmoneda, 0);
            this.Controls.SetChildIndex(this.Txtnombrevendedor, 0);
            this.Controls.SetChildIndex(this.myLabel12, 0);
            this.Controls.SetChildIndex(this.Txtcodigovendedor, 0);
            this.Controls.SetChildIndex(this.Txttotal, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.myLabel5, 0);
            this.Controls.SetChildIndex(this.Txtnombrecliente, 0);
            this.Controls.SetChildIndex(this.Txttelefonocliente, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.myLabel17, 0);
            this.Controls.SetChildIndex(this.Txtcodigocliente, 0);
            this.Controls.SetChildIndex(this.Txtdireccioncliente, 0);
            this.Controls.SetChildIndex(this.Txtreferencia, 0);
            this.Controls.SetChildIndex(this.myLabel3, 0);
            this.Controls.SetChildIndex(this.Txtbalance, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.Dtpfecha, 0);
            this.Controls.SetChildIndex(this.Txtregistro, 0);
            this.Controls.SetChildIndex(this.myLabel1, 0);
            this.Controls.SetChildIndex(this.Dgv, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.Txtsubtotal, 0);
            this.Controls.SetChildIndex(this.Txtitbis, 0);
            this.Controls.SetChildIndex(this.lblBase4, 0);
            this.Controls.SetChildIndex(this.lblBase5, 0);
            this.Controls.SetChildIndex(this.Txtconcepto, 0);
            this.Controls.SetChildIndex(this.lblBase2, 0);
            this.Controls.SetChildIndex(this.Mskncf, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Logistica.MskNCF Mskncf;
        private Logistica.LblBase lblBase2;
        public Logistica.TxtMayuscula Txtconcepto;
        private Logistica.LblBase lblBase5;
        private Logistica.LblBase lblBase4;
        private Logistica.TxtDecimal Txtitbis;
        private Logistica.TxtDecimal Txtsubtotal;
        private System.Windows.Forms.Panel panel1;
        private Logistica.LblBase lblBase1;
        public System.Windows.Forms.RadioButton Rbndebito;
        public System.Windows.Forms.RadioButton Rbncredito;
        private Logistica.GridBase Dgv;
        private Logistica.LblBase myLabel1;
        public Logistica.TxtMayuscula Txtregistro;
        public Logistica.DtpBase Dtpfecha;
        private Logistica.LblBase myLabel2;
        public Logistica.TxtDecimal Txtbalance;
        private Logistica.LblBase myLabel3;
        public Logistica.TxtMayuscula Txtreferencia;
        public Logistica.TxtMayuscula Txtdireccioncliente;
        public Logistica.TxtEntero Txtcodigocliente;
        private Logistica.LblBase myLabel17;
        private Logistica.LblBase myLabel4;
        private Logistica.MskTelefono Txttelefonocliente;
        public Logistica.TxtMayuscula Txtnombrecliente;
        private Logistica.LblBase myLabel5;
        private System.Windows.Forms.Label label1;
        public Logistica.TxtTotal Txttotal;
        public Logistica.TxtEntero Txtcodigovendedor;
        private Logistica.LblBase myLabel12;
        public Logistica.TxtMayuscula Txtnombrevendedor;
        public Logistica.CmbBase Cmbmoneda;
        private Logistica.LblBase myLabel14;
        private Logistica.LblBase myLabel16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvidregistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsecuencia;
        private Logistica.GridBase.CalendarColumn dgvfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvreferencia;
        private Logistica.GridBase.CalendarColumn dgvvence;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdias;
        private Logistica.GridBase.DoubleColumn dgvtotal;
        private Logistica.GridBase.DoubleColumn dgvbalance;
        private Logistica.GridBase.DoubleColumn dgvaplicar;
        private Logistica.GridBase.DoubleColumn dgvitbis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvncf;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtotalimporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtotalexento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtotalitbis;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvcheck;
    }
}
