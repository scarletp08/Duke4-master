namespace Duke4.Opcion_Pago.Proceso
{
    partial class genpropago
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(genpropago));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.BtnElegir = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.MainGrid = new Logistica.GridBase();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new Logistica.GridBase.DoubleColumn();
            this.idtipopago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequenum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorizacionnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarjetanum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechavenci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigocvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aprobacionnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentonum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monedanum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.myLabel1 = new Logistica.LblBase();
            this.Cmbopcion = new Logistica.CmbBase();
            this.button1 = new System.Windows.Forms.Button();
            this.decimalTextInput1 = new Logistica.TxtTotal();
            this.Lblalerta = new Logistica.LblGrandeNgta();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.aToolStripMenuItem1,
            this.toolStripTextBox1,
            this.BtnElegir,
            this.BtnCancelar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(15, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(142, 446);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.AutoSize = false;
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(195, 20);
            // 
            // aToolStripMenuItem1
            // 
            this.aToolStripMenuItem1.AutoSize = false;
            this.aToolStripMenuItem1.Name = "aToolStripMenuItem1";
            this.aToolStripMenuItem1.Size = new System.Drawing.Size(195, 20);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox1.Enabled = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(253, 24);
            // 
            // BtnElegir
            // 
            this.BtnElegir.AutoSize = false;
            this.BtnElegir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnElegir.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnElegir.Name = "BtnElegir";
            this.BtnElegir.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.BtnElegir.Size = new System.Drawing.Size(150, 30);
            this.BtnElegir.Text = "Procesar";
            this.BtnElegir.Click += new System.EventHandler(this.BtnElegir_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.AutoSize = false;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(150, 30);
            this.BtnCancelar.Text = "Retornar [Esc]";
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // MainGrid
            // 
            this.MainGrid.AllowUserToAddRows = false;
            this.MainGrid.AllowUserToDeleteRows = false;
            this.MainGrid.AllowUserToResizeColumns = false;
            this.MainGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.MainGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainGrid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Column2,
            this.monto,
            this.idtipopago,
            this.chequenum,
            this.idbanco,
            this.autorizacionnum,
            this.tarjetanum,
            this.fechavenci,
            this.codigocvc,
            this.aprobacionnum,
            this.idcuenta,
            this.documentonum,
            this.monedanum,
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.MainGrid.Location = new System.Drawing.Point(159, 250);
            this.MainGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainGrid.MultiSelect = false;
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MainGrid.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 8F);
            this.MainGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.MainGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainGrid.Size = new System.Drawing.Size(579, 159);
            this.MainGrid.TabIndex = 11;
            // 
            // codigo
            // 
            this.codigo.FillWeight = 30F;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripción";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // monto
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.monto.DefaultCellStyle = dataGridViewCellStyle2;
            this.monto.FillWeight = 40F;
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            this.monto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.monto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // idtipopago
            // 
            this.idtipopago.HeaderText = "Tipo pago";
            this.idtipopago.Name = "idtipopago";
            this.idtipopago.ReadOnly = true;
            this.idtipopago.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idtipopago.Visible = false;
            // 
            // chequenum
            // 
            this.chequenum.HeaderText = "Numero Ck";
            this.chequenum.Name = "chequenum";
            this.chequenum.ReadOnly = true;
            this.chequenum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.chequenum.Visible = false;
            // 
            // idbanco
            // 
            this.idbanco.HeaderText = "Banco";
            this.idbanco.Name = "idbanco";
            this.idbanco.ReadOnly = true;
            this.idbanco.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idbanco.Visible = false;
            // 
            // autorizacionnum
            // 
            this.autorizacionnum.HeaderText = "Autorización";
            this.autorizacionnum.Name = "autorizacionnum";
            this.autorizacionnum.ReadOnly = true;
            this.autorizacionnum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.autorizacionnum.Visible = false;
            // 
            // tarjetanum
            // 
            this.tarjetanum.HeaderText = "Tarjeta";
            this.tarjetanum.Name = "tarjetanum";
            this.tarjetanum.ReadOnly = true;
            this.tarjetanum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tarjetanum.Visible = false;
            // 
            // fechavenci
            // 
            this.fechavenci.HeaderText = "Fecha venc.";
            this.fechavenci.Name = "fechavenci";
            this.fechavenci.ReadOnly = true;
            this.fechavenci.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fechavenci.Visible = false;
            // 
            // codigocvc
            // 
            this.codigocvc.HeaderText = "Codigo Seguridad";
            this.codigocvc.Name = "codigocvc";
            this.codigocvc.ReadOnly = true;
            this.codigocvc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.codigocvc.Visible = false;
            // 
            // aprobacionnum
            // 
            this.aprobacionnum.HeaderText = "Aprobación";
            this.aprobacionnum.Name = "aprobacionnum";
            this.aprobacionnum.ReadOnly = true;
            this.aprobacionnum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.aprobacionnum.Visible = false;
            // 
            // idcuenta
            // 
            this.idcuenta.HeaderText = "Cta Banco";
            this.idcuenta.Name = "idcuenta";
            this.idcuenta.ReadOnly = true;
            this.idcuenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idcuenta.Visible = false;
            // 
            // documentonum
            // 
            this.documentonum.HeaderText = "No. Documento";
            this.documentonum.Name = "documentonum";
            this.documentonum.ReadOnly = true;
            this.documentonum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.documentonum.Visible = false;
            // 
            // monedanum
            // 
            this.monedanum.HeaderText = "Moneda";
            this.monedanum.Name = "monedanum";
            this.monedanum.ReadOnly = true;
            this.monedanum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.monedanum.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tipo tarjeta";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(159, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 142);
            this.panel1.TabIndex = 16;
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel1.Location = new System.Drawing.Point(171, 51);
            this.myLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(111, 16);
            this.myLabel1.TabIndex = 15;
            this.myLabel1.Text = "Opción de Pago";
            // 
            // Cmbopcion
            // 
            this.Cmbopcion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmbopcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbopcion.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Cmbopcion.FormattingEnabled = true;
            this.Cmbopcion.Location = new System.Drawing.Point(290, 48);
            this.Cmbopcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cmbopcion.Name = "Cmbopcion";
            this.Cmbopcion.ReadOnly = false;
            this.Cmbopcion.Size = new System.Drawing.Size(212, 24);
            this.Cmbopcion.TabIndex = 17;
            this.Cmbopcion.TabStop = false;
            this.Cmbopcion.SelectedIndexChanged += new System.EventHandler(this.Cmbopcion_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // decimalTextInput1
            // 
            this.decimalTextInput1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.decimalTextInput1.Enabled = false;
            this.decimalTextInput1.Location = new System.Drawing.Point(614, 415);
            this.decimalTextInput1.MaxLength = 21;
            this.decimalTextInput1.Name = "decimalTextInput1";
            this.decimalTextInput1.Size = new System.Drawing.Size(124, 22);
            this.decimalTextInput1.TabIndex = 20;
            this.decimalTextInput1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Lblalerta
            // 
            this.Lblalerta.AutoSize = true;
            this.Lblalerta.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.Lblalerta.Image = ((System.Drawing.Image)(resources.GetObject("Lblalerta.Image")));
            this.Lblalerta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lblalerta.Location = new System.Drawing.Point(155, 414);
            this.Lblalerta.Name = "Lblalerta";
            this.Lblalerta.Size = new System.Drawing.Size(0, 23);
            this.Lblalerta.TabIndex = 73;
            // 
            // Pagos
            // 
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(745, 446);
            this.Controls.Add(this.Lblalerta);
            this.Controls.Add(this.decimalTextInput1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cmbopcion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.myLabel1);
            this.Controls.Add(this.MainGrid);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Pagos";
            this.Load += new System.EventHandler(this.Pagos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pagos_KeyDown);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.MainGrid, 0);
            this.Controls.SetChildIndex(this.myLabel1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.Cmbopcion, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.decimalTextInput1, 0);
            this.Controls.SetChildIndex(this.Lblalerta, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        public System.Windows.Forms.ToolStripMenuItem BtnElegir;
        public System.Windows.Forms.ToolStripMenuItem BtnCancelar;
        private Logistica.GridBase MainGrid;
        private System.Windows.Forms.Panel panel1;
        private Logistica.LblBase myLabel1;
        private Logistica.CmbBase Cmbopcion;
        private System.Windows.Forms.Button button1;
        private Logistica.TxtTotal decimalTextInput1;
        public Logistica.LblGrandeNgta Lblalerta;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Logistica.GridBase.DoubleColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipopago;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequenum;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorizacionnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarjetanum;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechavenci;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigocvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn aprobacionnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentonum;
        private System.Windows.Forms.DataGridViewTextBoxColumn monedanum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
