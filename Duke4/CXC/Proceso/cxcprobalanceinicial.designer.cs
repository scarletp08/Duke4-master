namespace Duke4.CXC.Proceso
{
    partial class cxcprobalanceinicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cxcprobalanceinicial));
            this.Dgv = new Duke4.Logistica.GridBase();
            this.factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new Duke4.Logistica.GridBase.CalendarColumn();
            this.fechaven = new Duke4.Logistica.GridBase.CalendarColumn();
            this.monto = new Duke4.Logistica.GridBase.DoubleColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.Txttotal = new Duke4.Logistica.TxtDecimal();
            this.LblBase15 = new Duke4.Logistica.LblBase();
            this.Txtbalance = new Duke4.Logistica.TxtDecimal();
            this.Txtdireccioncliente = new Duke4.Logistica.TxtMayuscula();
            this.Txtcodigocliente = new Duke4.Logistica.TxtEntero();
            this.myLabel17 = new Duke4.Logistica.LblBase();
            this.myLabel4 = new Duke4.Logistica.LblBase();
            this.Txttelefonocliente = new Duke4.Logistica.MskTelefono();
            this.Txtnombrecliente = new Duke4.Logistica.TxtMayuscula();
            this.BtnBuscarCliente = new Duke4.Logistica.BtnBuscar();
            this.myLabel5 = new Duke4.Logistica.LblBase();
            this.myLabel14 = new Duke4.Logistica.LblBase();
            this.Cmbmoneda = new Duke4.Logistica.CmbBase();
            this.myLabel16 = new Duke4.Logistica.LblBase();
            this.BtnBuscarVendedor = new Duke4.Logistica.BtnBuscar();
            this.Txtcodigovendedor = new Duke4.Logistica.TxtEntero();
            this.myLabel12 = new Duke4.Logistica.LblBase();
            this.Txtnombrevendedor = new Duke4.Logistica.TxtMayuscula();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.BtnBuscarVendedor);
            this.MainPanel.Controls.Add(this.Txtcodigovendedor);
            this.MainPanel.Controls.Add(this.myLabel12);
            this.MainPanel.Controls.Add(this.Txtnombrevendedor);
            this.MainPanel.Controls.Add(this.Cmbmoneda);
            this.MainPanel.Controls.Add(this.myLabel16);
            this.MainPanel.Controls.Add(this.Txtbalance);
            this.MainPanel.Controls.Add(this.Txtdireccioncliente);
            this.MainPanel.Controls.Add(this.Txtcodigocliente);
            this.MainPanel.Controls.Add(this.myLabel17);
            this.MainPanel.Controls.Add(this.myLabel4);
            this.MainPanel.Controls.Add(this.Txttelefonocliente);
            this.MainPanel.Controls.Add(this.Txtnombrecliente);
            this.MainPanel.Controls.Add(this.BtnBuscarCliente);
            this.MainPanel.Controls.Add(this.myLabel5);
            this.MainPanel.Controls.Add(this.myLabel14);
            this.MainPanel.Controls.Add(this.Dgv);
            this.MainPanel.Controls.Add(this.button1);
            this.MainPanel.Controls.Add(this.Txttotal);
            this.MainPanel.Controls.Add(this.LblBase15);
            this.MainPanel.Location = new System.Drawing.Point(0, 108);
            this.MainPanel.Size = new System.Drawing.Size(622, 441);
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
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
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 556);
            this.panel2.Size = new System.Drawing.Size(770, 11);
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
            this.factura,
            this.fecha,
            this.fechaven,
            this.monto});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 7.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv.DefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.Dgv.Location = new System.Drawing.Point(11, 130);
            this.Dgv.MultiSelect = false;
            this.Dgv.Name = "Dgv";
            this.Dgv.RowHeadersVisible = false;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(589, 271);
            this.Dgv.TabIndex = 3;
            this.Dgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGridBase_CellEndEdit);
            this.Dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGridBase_CellValueChanged);
            this.Dgv.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.MainGridBase_EditingControlShowing);
            // 
            // factura
            // 
            this.factura.HeaderText = "Factura";
            this.factura.Name = "factura";
            this.factura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fecha
            // 
            dataGridViewCellStyle2.Format = "99/99/99";
            this.fecha.DefaultCellStyle = dataGridViewCellStyle2;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // fechaven
            // 
            dataGridViewCellStyle3.Format = "d";
            this.fechaven.DefaultCellStyle = dataGridViewCellStyle3;
            this.fechaven.HeaderText = "Vence";
            this.fechaven.Name = "fechaven";
            this.fechaven.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fechaven.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // monto
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.monto.DefaultCellStyle = dataGridViewCellStyle4;
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.monto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 231;
            this.button1.TabStop = false;
            this.button1.Text = "Quitar Factura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txttotal
            // 
            this.Txttotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Txttotal.Enabled = false;
            this.Txttotal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txttotal.Location = new System.Drawing.Point(500, 407);
            this.Txttotal.MaxLength = 14;
            this.Txttotal.Name = "Txttotal";
            this.Txttotal.Size = new System.Drawing.Size(100, 23);
            this.Txttotal.TabIndex = 230;
            this.Txttotal.TabStop = false;
            this.Txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblBase15
            // 
            this.LblBase15.AutoSize = true;
            this.LblBase15.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.LblBase15.ForeColor = System.Drawing.Color.Black;
            this.LblBase15.Location = new System.Drawing.Point(453, 414);
            this.LblBase15.Name = "LblBase15";
            this.LblBase15.Size = new System.Drawing.Size(41, 16);
            this.LblBase15.TabIndex = 229;
            this.LblBase15.Text = "Total";
            // 
            // Txtbalance
            // 
            this.Txtbalance.BackColor = System.Drawing.SystemColors.Window;
            this.Txtbalance.Enabled = false;
            this.Txtbalance.Location = new System.Drawing.Point(275, 47);
            this.Txtbalance.Name = "Txtbalance";
            this.Txtbalance.Size = new System.Drawing.Size(100, 23);
            this.Txtbalance.TabIndex = 397;
            this.Txtbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Txtdireccioncliente
            // 
            this.Txtdireccioncliente.BackColor = System.Drawing.SystemColors.Window;
            this.Txtdireccioncliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtdireccioncliente.Enabled = false;
            this.Txtdireccioncliente.Location = new System.Drawing.Point(94, 25);
            this.Txtdireccioncliente.Name = "Txtdireccioncliente";
            this.Txtdireccioncliente.ReadOnly = true;
            this.Txtdireccioncliente.Size = new System.Drawing.Size(506, 23);
            this.Txtdireccioncliente.TabIndex = 396;
            this.Txtdireccioncliente.TabStop = false;
            // 
            // Txtcodigocliente
            // 
            this.Txtcodigocliente.BackColor = System.Drawing.SystemColors.Window;
            this.Txtcodigocliente.Location = new System.Drawing.Point(94, 3);
            this.Txtcodigocliente.MaxLength = 9;
            this.Txtcodigocliente.Name = "Txtcodigocliente";
            this.Txtcodigocliente.Size = new System.Drawing.Size(100, 23);
            this.Txtcodigocliente.TabIndex = 388;
            this.Txtcodigocliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txtcodigocliente.Validating += new System.ComponentModel.CancelEventHandler(this.Txtcodigocliente_Validating);
            // 
            // myLabel17
            // 
            this.myLabel17.AutoSize = true;
            this.myLabel17.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel17.ForeColor = System.Drawing.Color.Black;
            this.myLabel17.Location = new System.Drawing.Point(15, 28);
            this.myLabel17.Name = "myLabel17";
            this.myLabel17.Size = new System.Drawing.Size(68, 16);
            this.myLabel17.TabIndex = 395;
            this.myLabel17.Text = "Direccion";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(15, 6);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(53, 16);
            this.myLabel4.TabIndex = 390;
            this.myLabel4.Text = "Cliente";
            // 
            // Txttelefonocliente
            // 
            this.Txttelefonocliente.Enabled = false;
            this.Txttelefonocliente.Location = new System.Drawing.Point(94, 47);
            this.Txttelefonocliente.Mask = "(000)-000-0000";
            this.Txttelefonocliente.Name = "Txttelefonocliente";
            this.Txttelefonocliente.Size = new System.Drawing.Size(109, 23);
            this.Txttelefonocliente.TabIndex = 394;
            // 
            // Txtnombrecliente
            // 
            this.Txtnombrecliente.BackColor = System.Drawing.SystemColors.Window;
            this.Txtnombrecliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtnombrecliente.Enabled = false;
            this.Txtnombrecliente.Location = new System.Drawing.Point(275, 3);
            this.Txtnombrecliente.Name = "Txtnombrecliente";
            this.Txtnombrecliente.ReadOnly = true;
            this.Txtnombrecliente.Size = new System.Drawing.Size(325, 23);
            this.Txtnombrecliente.TabIndex = 392;
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
            this.BtnBuscarCliente.Location = new System.Drawing.Point(224, 3);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(24, 24);
            this.BtnBuscarCliente.TabIndex = 389;
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
            this.myLabel5.Location = new System.Drawing.Point(15, 50);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(64, 16);
            this.myLabel5.TabIndex = 391;
            this.myLabel5.Text = "Telefono";
            // 
            // myLabel14
            // 
            this.myLabel14.AutoSize = true;
            this.myLabel14.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel14.ForeColor = System.Drawing.Color.Black;
            this.myLabel14.Location = new System.Drawing.Point(221, 50);
            this.myLabel14.Name = "myLabel14";
            this.myLabel14.Size = new System.Drawing.Size(59, 16);
            this.myLabel14.TabIndex = 393;
            this.myLabel14.Text = "Balance";
            // 
            // Cmbmoneda
            // 
            this.Cmbmoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmbmoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbmoneda.FormattingEnabled = true;
            this.Cmbmoneda.Location = new System.Drawing.Point(446, 47);
            this.Cmbmoneda.Name = "Cmbmoneda";
            this.Cmbmoneda.ReadOnly = false;
            this.Cmbmoneda.Size = new System.Drawing.Size(154, 24);
            this.Cmbmoneda.TabIndex = 398;
            this.Cmbmoneda.TabStop = false;
            this.toolTip1.SetToolTip(this.Cmbmoneda, "Seleccione el tipo de moneda");
            // 
            // myLabel16
            // 
            this.myLabel16.AutoSize = true;
            this.myLabel16.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel16.ForeColor = System.Drawing.Color.Black;
            this.myLabel16.Location = new System.Drawing.Point(381, 50);
            this.myLabel16.Name = "myLabel16";
            this.myLabel16.Size = new System.Drawing.Size(59, 16);
            this.myLabel16.TabIndex = 399;
            this.myLabel16.Text = "Moneda";
            // 
            // BtnBuscarVendedor
            // 
            this.BtnBuscarVendedor.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnBuscarVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBuscarVendedor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBuscarVendedor.FlatAppearance.BorderSize = 0;
            this.BtnBuscarVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarVendedor.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarVendedor.Image")));
            this.BtnBuscarVendedor.Location = new System.Drawing.Point(224, 91);
            this.BtnBuscarVendedor.Name = "BtnBuscarVendedor";
            this.BtnBuscarVendedor.Size = new System.Drawing.Size(24, 24);
            this.BtnBuscarVendedor.TabIndex = 401;
            this.BtnBuscarVendedor.TabStop = false;
            this.BtnBuscarVendedor.Text = " ";
            this.toolTip1.SetToolTip(this.BtnBuscarVendedor, "Buscar Vendedor");
            this.BtnBuscarVendedor.UseVisualStyleBackColor = false;
            this.BtnBuscarVendedor.Click += new System.EventHandler(this.BtnBuscarVendedor_Click);
            // 
            // Txtcodigovendedor
            // 
            this.Txtcodigovendedor.BackColor = System.Drawing.SystemColors.Window;
            this.Txtcodigovendedor.Location = new System.Drawing.Point(94, 91);
            this.Txtcodigovendedor.MaxLength = 9;
            this.Txtcodigovendedor.Name = "Txtcodigovendedor";
            this.Txtcodigovendedor.Size = new System.Drawing.Size(100, 23);
            this.Txtcodigovendedor.TabIndex = 400;
            this.Txtcodigovendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txtcodigovendedor.Validating += new System.ComponentModel.CancelEventHandler(this.Txtcodigovendedor_Validating);
            // 
            // myLabel12
            // 
            this.myLabel12.AutoSize = true;
            this.myLabel12.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel12.ForeColor = System.Drawing.Color.Black;
            this.myLabel12.Location = new System.Drawing.Point(15, 95);
            this.myLabel12.Name = "myLabel12";
            this.myLabel12.Size = new System.Drawing.Size(69, 16);
            this.myLabel12.TabIndex = 402;
            this.myLabel12.Text = "Vendedor";
            // 
            // Txtnombrevendedor
            // 
            this.Txtnombrevendedor.BackColor = System.Drawing.SystemColors.Window;
            this.Txtnombrevendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtnombrevendedor.Enabled = false;
            this.Txtnombrevendedor.Location = new System.Drawing.Point(278, 91);
            this.Txtnombrevendedor.Name = "Txtnombrevendedor";
            this.Txtnombrevendedor.ReadOnly = true;
            this.Txtnombrevendedor.Size = new System.Drawing.Size(322, 23);
            this.Txtnombrevendedor.TabIndex = 403;
            this.Txtnombrevendedor.TabStop = false;
            // 
            // cxcprobalanceinicial
            // 
            this.ClientSize = new System.Drawing.Size(624, 595);
            this.Name = "cxcprobalanceinicial";
            this.Load += new System.EventHandler(this.MPPBalance_Inicial_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Logistica.TxtDecimal Txttotal;
        private Logistica.LblBase LblBase15;
        private System.Windows.Forms.Button button1;
        public Logistica.GridBase Dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn factura;
        private Logistica.GridBase.CalendarColumn fecha;
        private Logistica.GridBase.CalendarColumn fechaven;
        private Logistica.GridBase.DoubleColumn monto;
        public Logistica.TxtDecimal Txtbalance;
        public Logistica.TxtMayuscula Txtdireccioncliente;
        public Logistica.TxtEntero Txtcodigocliente;
        private Logistica.LblBase myLabel17;
        private Logistica.LblBase myLabel4;
        private Logistica.MskTelefono Txttelefonocliente;
        public Logistica.TxtMayuscula Txtnombrecliente;
        public Logistica.BtnBuscar BtnBuscarCliente;
        private Logistica.LblBase myLabel5;
        private Logistica.LblBase myLabel14;
        public Logistica.CmbBase Cmbmoneda;
        private Logistica.LblBase myLabel16;
        public Logistica.BtnBuscar BtnBuscarVendedor;
        public Logistica.TxtEntero Txtcodigovendedor;
        private Logistica.LblBase myLabel12;
        public Logistica.TxtMayuscula Txtnombrevendedor;
    }
}
