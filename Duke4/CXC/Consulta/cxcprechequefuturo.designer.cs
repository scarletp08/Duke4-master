namespace Duke4.CXC.Consulta
{
    partial class cxcprechequefuturo
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
            this.Dtpfechadeposito = new Duke4.Logistica.DtpBase();
            this.lblBase3 = new Duke4.Logistica.LblBase();
            this.lblBase2 = new Duke4.Logistica.LblBase();
            this.Txtnock = new Duke4.Logistica.TxtEntero();
            this.Cmbbanco = new Duke4.Logistica.CmbBase();
            this.lblBase1 = new Duke4.Logistica.LblBase();
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
            this.Txtdireccioncliente = new Duke4.Logistica.TxtMayuscula();
            this.Txtcodigocliente = new Duke4.Logistica.TxtEntero();
            this.myLabel17 = new Duke4.Logistica.LblBase();
            this.myLabel4 = new Duke4.Logistica.LblBase();
            this.Txttelefonocliente = new Duke4.Logistica.MskTelefono();
            this.Txtnombrecliente = new Duke4.Logistica.TxtMayuscula();
            this.myLabel5 = new Duke4.Logistica.LblBase();
            this.Txtcodigovendedor = new Duke4.Logistica.TxtEntero();
            this.myLabel12 = new Duke4.Logistica.LblBase();
            this.Txtnombrevendedor = new Duke4.Logistica.TxtMayuscula();
            this.Cmbmoneda = new Duke4.Logistica.CmbBase();
            this.myLabel14 = new Duke4.Logistica.LblBase();
            this.myLabel16 = new Duke4.Logistica.LblBase();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFunctionName
            // 
            this.LblFunctionName.Location = new System.Drawing.Point(614, 100);
            this.LblFunctionName.Size = new System.Drawing.Size(163, 32);
            this.LblFunctionName.Text = "     Letrero";
            // 
            // Dtpfechadeposito
            // 
            this.Dtpfechadeposito.CustomFormat = "dd/MM/yyyy";
            this.Dtpfechadeposito.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Dtpfechadeposito.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtpfechadeposito.Location = new System.Drawing.Point(370, 283);
            this.Dtpfechadeposito.Name = "Dtpfechadeposito";
            this.Dtpfechadeposito.Size = new System.Drawing.Size(114, 23);
            this.Dtpfechadeposito.TabIndex = 427;
            // 
            // lblBase3
            // 
            this.lblBase3.AutoSize = true;
            this.lblBase3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase3.ForeColor = System.Drawing.Color.Black;
            this.lblBase3.Location = new System.Drawing.Point(222, 286);
            this.lblBase3.Name = "lblBase3";
            this.lblBase3.Size = new System.Drawing.Size(110, 16);
            this.lblBase3.TabIndex = 428;
            this.lblBase3.Text = "Fecha Depósito";
            // 
            // lblBase2
            // 
            this.lblBase2.AutoSize = true;
            this.lblBase2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase2.ForeColor = System.Drawing.Color.Black;
            this.lblBase2.Location = new System.Drawing.Point(13, 286);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(79, 16);
            this.lblBase2.TabIndex = 426;
            this.lblBase2.Text = "Número CK";
            // 
            // Txtnock
            // 
            this.Txtnock.Location = new System.Drawing.Point(92, 283);
            this.Txtnock.Name = "Txtnock";
            this.Txtnock.Size = new System.Drawing.Size(100, 23);
            this.Txtnock.TabIndex = 402;
            this.Txtnock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Cmbbanco
            // 
            this.Cmbbanco.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmbbanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbbanco.FormattingEnabled = true;
            this.Cmbbanco.Location = new System.Drawing.Point(614, 167);
            this.Cmbbanco.Name = "Cmbbanco";
            this.Cmbbanco.ReadOnly = false;
            this.Cmbbanco.Size = new System.Drawing.Size(163, 24);
            this.Cmbbanco.TabIndex = 423;
            this.Cmbbanco.TabStop = false;
            // 
            // lblBase1
            // 
            this.lblBase1.AutoSize = true;
            this.lblBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase1.ForeColor = System.Drawing.Color.Black;
            this.lblBase1.Location = new System.Drawing.Point(611, 143);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(48, 16);
            this.lblBase1.TabIndex = 424;
            this.lblBase1.Text = "Banco";
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
            this.Dgv.Location = new System.Drawing.Point(16, 312);
            this.Dgv.MultiSelect = false;
            this.Dgv.Name = "Dgv";
            this.Dgv.RowHeadersVisible = false;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(761, 275);
            this.Dgv.TabIndex = 422;
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
            this.myLabel1.Location = new System.Drawing.Point(13, 143);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(61, 16);
            this.myLabel1.TabIndex = 397;
            this.myLabel1.Text = "Registro";
            // 
            // Txtchequefuturo
            // 
            this.Txtchequefuturo.BackColor = System.Drawing.SystemColors.Window;
            this.Txtchequefuturo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtchequefuturo.Enabled = false;
            this.Txtchequefuturo.Location = new System.Drawing.Point(92, 140);
            this.Txtchequefuturo.Name = "Txtchequefuturo";
            this.Txtchequefuturo.Size = new System.Drawing.Size(100, 23);
            this.Txtchequefuturo.TabIndex = 411;
            this.Txtchequefuturo.TabStop = false;
            this.Txtchequefuturo.TextChanged += new System.EventHandler(this.Txtchequefuturo_TextChanged);
            // 
            // Dtpfecha
            // 
            this.Dtpfecha.CustomFormat = "dd/MM/yyyy";
            this.Dtpfecha.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtpfecha.Location = new System.Drawing.Point(273, 140);
            this.Dtpfecha.Name = "Dtpfecha";
            this.Dtpfecha.Size = new System.Drawing.Size(114, 23);
            this.Dtpfecha.TabIndex = 398;
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(219, 143);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(48, 16);
            this.myLabel2.TabIndex = 403;
            this.myLabel2.Text = "Fecha";
            // 
            // Txtbalance
            // 
            this.Txtbalance.BackColor = System.Drawing.SystemColors.Window;
            this.Txtbalance.Enabled = false;
            this.Txtbalance.Location = new System.Drawing.Point(508, 211);
            this.Txtbalance.Name = "Txtbalance";
            this.Txtbalance.Size = new System.Drawing.Size(100, 23);
            this.Txtbalance.TabIndex = 421;
            this.Txtbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(425, 143);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(77, 16);
            this.myLabel3.TabIndex = 406;
            this.myLabel3.Text = "Referencia";
            // 
            // Txtreferencia
            // 
            this.Txtreferencia.BackColor = System.Drawing.SystemColors.Window;
            this.Txtreferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtreferencia.Location = new System.Drawing.Point(508, 140);
            this.Txtreferencia.Name = "Txtreferencia";
            this.Txtreferencia.Size = new System.Drawing.Size(100, 23);
            this.Txtreferencia.TabIndex = 399;
            // 
            // Txtdireccioncliente
            // 
            this.Txtdireccioncliente.BackColor = System.Drawing.SystemColors.Window;
            this.Txtdireccioncliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtdireccioncliente.Enabled = false;
            this.Txtdireccioncliente.Location = new System.Drawing.Point(92, 189);
            this.Txtdireccioncliente.Name = "Txtdireccioncliente";
            this.Txtdireccioncliente.ReadOnly = true;
            this.Txtdireccioncliente.Size = new System.Drawing.Size(516, 23);
            this.Txtdireccioncliente.TabIndex = 420;
            this.Txtdireccioncliente.TabStop = false;
            // 
            // Txtcodigocliente
            // 
            this.Txtcodigocliente.BackColor = System.Drawing.SystemColors.Window;
            this.Txtcodigocliente.Location = new System.Drawing.Point(92, 167);
            this.Txtcodigocliente.MaxLength = 9;
            this.Txtcodigocliente.Name = "Txtcodigocliente";
            this.Txtcodigocliente.Size = new System.Drawing.Size(100, 23);
            this.Txtcodigocliente.TabIndex = 401;
            this.Txtcodigocliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // myLabel17
            // 
            this.myLabel17.AutoSize = true;
            this.myLabel17.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel17.ForeColor = System.Drawing.Color.Black;
            this.myLabel17.Location = new System.Drawing.Point(13, 192);
            this.myLabel17.Name = "myLabel17";
            this.myLabel17.Size = new System.Drawing.Size(68, 16);
            this.myLabel17.TabIndex = 419;
            this.myLabel17.Text = "Direccion";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(13, 170);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(53, 16);
            this.myLabel4.TabIndex = 408;
            this.myLabel4.Text = "Cliente";
            // 
            // Txttelefonocliente
            // 
            this.Txttelefonocliente.Enabled = false;
            this.Txttelefonocliente.Location = new System.Drawing.Point(92, 211);
            this.Txttelefonocliente.Mask = "(000)-000-0000";
            this.Txttelefonocliente.Name = "Txttelefonocliente";
            this.Txttelefonocliente.Size = new System.Drawing.Size(109, 23);
            this.Txttelefonocliente.TabIndex = 418;
            // 
            // Txtnombrecliente
            // 
            this.Txtnombrecliente.BackColor = System.Drawing.SystemColors.Window;
            this.Txtnombrecliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtnombrecliente.Enabled = false;
            this.Txtnombrecliente.Location = new System.Drawing.Point(222, 167);
            this.Txtnombrecliente.Name = "Txtnombrecliente";
            this.Txtnombrecliente.ReadOnly = true;
            this.Txtnombrecliente.Size = new System.Drawing.Size(386, 23);
            this.Txtnombrecliente.TabIndex = 410;
            this.Txtnombrecliente.TabStop = false;
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = true;
            this.myLabel5.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel5.ForeColor = System.Drawing.Color.Black;
            this.myLabel5.Location = new System.Drawing.Point(13, 214);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(64, 16);
            this.myLabel5.TabIndex = 409;
            this.myLabel5.Text = "Telefono";
            // 
            // Txtcodigovendedor
            // 
            this.Txtcodigovendedor.BackColor = System.Drawing.SystemColors.Window;
            this.Txtcodigovendedor.Location = new System.Drawing.Point(92, 247);
            this.Txtcodigovendedor.MaxLength = 9;
            this.Txtcodigovendedor.Name = "Txtcodigovendedor";
            this.Txtcodigovendedor.Size = new System.Drawing.Size(100, 23);
            this.Txtcodigovendedor.TabIndex = 400;
            this.Txtcodigovendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // myLabel12
            // 
            this.myLabel12.AutoSize = true;
            this.myLabel12.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel12.ForeColor = System.Drawing.Color.Black;
            this.myLabel12.Location = new System.Drawing.Point(13, 251);
            this.myLabel12.Name = "myLabel12";
            this.myLabel12.Size = new System.Drawing.Size(69, 16);
            this.myLabel12.TabIndex = 412;
            this.myLabel12.Text = "Vendedor";
            // 
            // Txtnombrevendedor
            // 
            this.Txtnombrevendedor.BackColor = System.Drawing.SystemColors.Window;
            this.Txtnombrevendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtnombrevendedor.Enabled = false;
            this.Txtnombrevendedor.Location = new System.Drawing.Point(222, 247);
            this.Txtnombrevendedor.Name = "Txtnombrevendedor";
            this.Txtnombrevendedor.ReadOnly = true;
            this.Txtnombrevendedor.Size = new System.Drawing.Size(262, 23);
            this.Txtnombrevendedor.TabIndex = 413;
            this.Txtnombrevendedor.TabStop = false;
            // 
            // Cmbmoneda
            // 
            this.Cmbmoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmbmoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbmoneda.FormattingEnabled = true;
            this.Cmbmoneda.Location = new System.Drawing.Point(614, 211);
            this.Cmbmoneda.Name = "Cmbmoneda";
            this.Cmbmoneda.ReadOnly = false;
            this.Cmbmoneda.Size = new System.Drawing.Size(163, 24);
            this.Cmbmoneda.TabIndex = 415;
            this.Cmbmoneda.TabStop = false;
            // 
            // myLabel14
            // 
            this.myLabel14.AutoSize = true;
            this.myLabel14.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel14.ForeColor = System.Drawing.Color.Black;
            this.myLabel14.Location = new System.Drawing.Point(373, 214);
            this.myLabel14.Name = "myLabel14";
            this.myLabel14.Size = new System.Drawing.Size(129, 16);
            this.myLabel14.TabIndex = 414;
            this.myLabel14.Text = "Balance Pendiente";
            // 
            // myLabel16
            // 
            this.myLabel16.AutoSize = true;
            this.myLabel16.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel16.ForeColor = System.Drawing.Color.Black;
            this.myLabel16.Location = new System.Drawing.Point(611, 193);
            this.myLabel16.Name = "myLabel16";
            this.myLabel16.Size = new System.Drawing.Size(59, 16);
            this.myLabel16.TabIndex = 416;
            this.myLabel16.Text = "Moneda";
            // 
            // cxcprechequefuturo
            // 
            this.ClientSize = new System.Drawing.Size(802, 605);
            this.Controls.Add(this.Dtpfechadeposito);
            this.Controls.Add(this.lblBase3);
            this.Controls.Add(this.lblBase2);
            this.Controls.Add(this.Txtnock);
            this.Controls.Add(this.Cmbbanco);
            this.Controls.Add(this.lblBase1);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.myLabel1);
            this.Controls.Add(this.Txtchequefuturo);
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
            this.Controls.Add(this.Txtcodigovendedor);
            this.Controls.Add(this.myLabel12);
            this.Controls.Add(this.Txtnombrevendedor);
            this.Controls.Add(this.Cmbmoneda);
            this.Controls.Add(this.myLabel14);
            this.Controls.Add(this.myLabel16);
            this.Name = "cxcprechequefuturo";
            this.Load += new System.EventHandler(this.cxcprechequefuturo_Load);
            this.Controls.SetChildIndex(this.LblFunctionName, 0);
            this.Controls.SetChildIndex(this.myLabel16, 0);
            this.Controls.SetChildIndex(this.myLabel14, 0);
            this.Controls.SetChildIndex(this.Cmbmoneda, 0);
            this.Controls.SetChildIndex(this.Txtnombrevendedor, 0);
            this.Controls.SetChildIndex(this.myLabel12, 0);
            this.Controls.SetChildIndex(this.Txtcodigovendedor, 0);
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
            this.Controls.SetChildIndex(this.Txtchequefuturo, 0);
            this.Controls.SetChildIndex(this.myLabel1, 0);
            this.Controls.SetChildIndex(this.Dgv, 0);
            this.Controls.SetChildIndex(this.lblBase1, 0);
            this.Controls.SetChildIndex(this.Cmbbanco, 0);
            this.Controls.SetChildIndex(this.Txtnock, 0);
            this.Controls.SetChildIndex(this.lblBase2, 0);
            this.Controls.SetChildIndex(this.lblBase3, 0);
            this.Controls.SetChildIndex(this.Dtpfechadeposito, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Logistica.DtpBase Dtpfechadeposito;
        private Logistica.LblBase lblBase3;
        private Logistica.LblBase lblBase2;
        private Logistica.TxtEntero Txtnock;
        public Logistica.CmbBase Cmbbanco;
        private Logistica.LblBase lblBase1;
        private Logistica.GridBase Dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvidregistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsecuencia;
        private Logistica.GridBase.CalendarColumn dgvfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvreferencia;
        private Logistica.GridBase.CalendarColumn dgvvence;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdias;
        private Logistica.GridBase.DoubleColumn dgvtotal;
        private Logistica.GridBase.DoubleColumn dgvbalance;
        private Logistica.GridBase.DoubleColumn dgvaplicar;
        private Logistica.LblBase myLabel1;
        public Logistica.TxtMayuscula Txtchequefuturo;
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
        public Logistica.TxtEntero Txtcodigovendedor;
        private Logistica.LblBase myLabel12;
        public Logistica.TxtMayuscula Txtnombrevendedor;
        public Logistica.CmbBase Cmbmoneda;
        private Logistica.LblBase myLabel14;
        private Logistica.LblBase myLabel16;
    }
}
