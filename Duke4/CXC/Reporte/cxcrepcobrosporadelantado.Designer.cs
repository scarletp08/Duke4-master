namespace Duke4.CXC.Reporte
{
    partial class cxcrepcobrosporadelantado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cxcrepcobrosporadelantado));
            this.cmbestatus = new Duke4.Logistica.CmbBase();
            this.cmbmoneda = new Duke4.Logistica.CmbBase();
            this.TxtCodigocliente = new Duke4.Logistica.TxtEntero();
            this.Txtnombrecliente = new Duke4.Logistica.TxtMayuscula();
            this.BtnBuscarbeneficiario = new Duke4.Logistica.BtnBuscar();
            this.cmborden = new Duke4.Logistica.CmbBase();
            this.lblBase16 = new Duke4.Logistica.LblBase();
            this.lblBase8 = new Duke4.Logistica.LblBase();
            this.lblBase14 = new Duke4.Logistica.LblBase();
            this.lblBase1 = new Duke4.Logistica.LblBase();
            this.Dtpfechafinal = new Duke4.Logistica.DtpBase();
            this.Dtpfechainicial = new Duke4.Logistica.DtpBase();
            this.lblBase6 = new Duke4.Logistica.LblBase();
            this.lblBase7 = new Duke4.Logistica.LblBase();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.Lbsformato.Size = new System.Drawing.Size(201, 222);
            // 
            // FormTitle
            // 
            this.FormTitle.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.FormTitle.ForeColor = System.Drawing.Color.White;
            this.FormTitle.Size = new System.Drawing.Size(88, 23);
            // 
            // cmbestatus
            // 
            this.cmbestatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbestatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbestatus.FormattingEnabled = true;
            this.cmbestatus.Items.AddRange(new object[] {
            "Todas ",
            "Canceladas",
            "No Canceladas"});
            this.cmbestatus.Location = new System.Drawing.Point(333, 156);
            this.cmbestatus.Name = "cmbestatus";
            this.cmbestatus.ReadOnly = false;
            this.cmbestatus.Size = new System.Drawing.Size(137, 24);
            this.cmbestatus.TabIndex = 3;
            // 
            // cmbmoneda
            // 
            this.cmbmoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbmoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmoneda.FormattingEnabled = true;
            this.cmbmoneda.Location = new System.Drawing.Point(333, 181);
            this.cmbmoneda.Name = "cmbmoneda";
            this.cmbmoneda.ReadOnly = false;
            this.cmbmoneda.Size = new System.Drawing.Size(137, 24);
            this.cmbmoneda.TabIndex = 4;
            // 
            // TxtCodigocliente
            // 
            this.TxtCodigocliente.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCodigocliente.Location = new System.Drawing.Point(333, 132);
            this.TxtCodigocliente.MaxLength = 9;
            this.TxtCodigocliente.Name = "TxtCodigocliente";
            this.TxtCodigocliente.Size = new System.Drawing.Size(137, 23);
            this.TxtCodigocliente.TabIndex = 2;
            this.TxtCodigocliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCodigocliente.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodigocliente_Validating);
            this.TxtCodigocliente.Validated += new System.EventHandler(this.TxtCodigocliente_Validated);
            // 
            // Txtnombrecliente
            // 
            this.Txtnombrecliente.BackColor = System.Drawing.SystemColors.Window;
            this.Txtnombrecliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtnombrecliente.Enabled = false;
            this.Txtnombrecliente.Location = new System.Drawing.Point(497, 133);
            this.Txtnombrecliente.Name = "Txtnombrecliente";
            this.Txtnombrecliente.ReadOnly = true;
            this.Txtnombrecliente.Size = new System.Drawing.Size(265, 23);
            this.Txtnombrecliente.TabIndex = 396;
            this.Txtnombrecliente.TabStop = false;
            // 
            // BtnBuscarbeneficiario
            // 
            this.BtnBuscarbeneficiario.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnBuscarbeneficiario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBuscarbeneficiario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBuscarbeneficiario.FlatAppearance.BorderSize = 0;
            this.BtnBuscarbeneficiario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarbeneficiario.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarbeneficiario.Image")));
            this.BtnBuscarbeneficiario.Location = new System.Drawing.Point(471, 132);
            this.BtnBuscarbeneficiario.Name = "BtnBuscarbeneficiario";
            this.BtnBuscarbeneficiario.Size = new System.Drawing.Size(24, 24);
            this.BtnBuscarbeneficiario.TabIndex = 395;
            this.BtnBuscarbeneficiario.TabStop = false;
            this.BtnBuscarbeneficiario.Text = " ";
            this.toolTip1.SetToolTip(this.BtnBuscarbeneficiario, "Buscar Cliente");
            this.BtnBuscarbeneficiario.UseVisualStyleBackColor = false;
            this.BtnBuscarbeneficiario.Click += new System.EventHandler(this.BtnBuscarbeneficiario_Click);
            // 
            // cmborden
            // 
            this.cmborden.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmborden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmborden.FormattingEnabled = true;
            this.cmborden.Items.AddRange(new object[] {
            "Secuencia",
            "Fecha",
            "Cliente"});
            this.cmborden.Location = new System.Drawing.Point(333, 212);
            this.cmborden.Name = "cmborden";
            this.cmborden.ReadOnly = false;
            this.cmborden.Size = new System.Drawing.Size(137, 24);
            this.cmborden.TabIndex = 5;
            // 
            // lblBase16
            // 
            this.lblBase16.AutoSize = true;
            this.lblBase16.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase16.ForeColor = System.Drawing.Color.Black;
            this.lblBase16.Location = new System.Drawing.Point(212, 215);
            this.lblBase16.Name = "lblBase16";
            this.lblBase16.Size = new System.Drawing.Size(86, 16);
            this.lblBase16.TabIndex = 392;
            this.lblBase16.Text = "Ordenar por";
            // 
            // lblBase8
            // 
            this.lblBase8.AutoSize = true;
            this.lblBase8.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase8.ForeColor = System.Drawing.Color.Black;
            this.lblBase8.Location = new System.Drawing.Point(212, 184);
            this.lblBase8.Name = "lblBase8";
            this.lblBase8.Size = new System.Drawing.Size(59, 16);
            this.lblBase8.TabIndex = 390;
            this.lblBase8.Text = "Moneda";
            // 
            // lblBase14
            // 
            this.lblBase14.AutoSize = true;
            this.lblBase14.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase14.ForeColor = System.Drawing.Color.Black;
            this.lblBase14.Location = new System.Drawing.Point(212, 161);
            this.lblBase14.Name = "lblBase14";
            this.lblBase14.Size = new System.Drawing.Size(58, 16);
            this.lblBase14.TabIndex = 388;
            this.lblBase14.Text = "Estatus";
            // 
            // lblBase1
            // 
            this.lblBase1.AutoSize = true;
            this.lblBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase1.ForeColor = System.Drawing.Color.Black;
            this.lblBase1.Location = new System.Drawing.Point(212, 137);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(53, 16);
            this.lblBase1.TabIndex = 387;
            this.lblBase1.Text = "Cliente";
            // 
            // Dtpfechafinal
            // 
            this.Dtpfechafinal.CustomFormat = "dd/MM/yyyy";
            this.Dtpfechafinal.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Dtpfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtpfechafinal.Location = new System.Drawing.Point(333, 108);
            this.Dtpfechafinal.Name = "Dtpfechafinal";
            this.Dtpfechafinal.Size = new System.Drawing.Size(137, 23);
            this.Dtpfechafinal.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Dtpfechafinal, "Seleccione Fecha final");
            // 
            // Dtpfechainicial
            // 
            this.Dtpfechainicial.CustomFormat = "dd/MM/yyyy";
            this.Dtpfechainicial.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Dtpfechainicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtpfechainicial.Location = new System.Drawing.Point(333, 82);
            this.Dtpfechainicial.Name = "Dtpfechainicial";
            this.Dtpfechainicial.Size = new System.Drawing.Size(137, 23);
            this.Dtpfechainicial.TabIndex = 0;
            this.toolTip1.SetToolTip(this.Dtpfechainicial, "Seleccione Fecha inicial");
            // 
            // lblBase6
            // 
            this.lblBase6.AutoSize = true;
            this.lblBase6.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase6.ForeColor = System.Drawing.Color.Black;
            this.lblBase6.Location = new System.Drawing.Point(212, 113);
            this.lblBase6.Name = "lblBase6";
            this.lblBase6.Size = new System.Drawing.Size(46, 16);
            this.lblBase6.TabIndex = 439;
            this.lblBase6.Text = "Hasta";
            // 
            // lblBase7
            // 
            this.lblBase7.AutoSize = true;
            this.lblBase7.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase7.ForeColor = System.Drawing.Color.Black;
            this.lblBase7.Location = new System.Drawing.Point(212, 87);
            this.lblBase7.Name = "lblBase7";
            this.lblBase7.Size = new System.Drawing.Size(48, 16);
            this.lblBase7.TabIndex = 438;
            this.lblBase7.Text = "Desde";
            // 
            // cxcrepcobrosporadelantado
            // 
            this.ClientSize = new System.Drawing.Size(770, 423);
            this.Controls.Add(this.Dtpfechafinal);
            this.Controls.Add(this.Dtpfechainicial);
            this.Controls.Add(this.lblBase6);
            this.Controls.Add(this.lblBase7);
            this.Controls.Add(this.lblBase16);
            this.Controls.Add(this.cmborden);
            this.Controls.Add(this.cmbestatus);
            this.Controls.Add(this.cmbmoneda);
            this.Controls.Add(this.TxtCodigocliente);
            this.Controls.Add(this.Txtnombrecliente);
            this.Controls.Add(this.BtnBuscarbeneficiario);
            this.Controls.Add(this.lblBase8);
            this.Controls.Add(this.lblBase14);
            this.Controls.Add(this.lblBase1);
            this.Name = "cxcrepcobrosporadelantado";
            this.Load += new System.EventHandler(this.cxcrepcobrosporadelantado_Load);
            this.Controls.SetChildIndex(this.Lbsformato, 0);
            this.Controls.SetChildIndex(this.lblBase1, 0);
            this.Controls.SetChildIndex(this.lblBase14, 0);
            this.Controls.SetChildIndex(this.lblBase8, 0);
            this.Controls.SetChildIndex(this.BtnBuscarbeneficiario, 0);
            this.Controls.SetChildIndex(this.Txtnombrecliente, 0);
            this.Controls.SetChildIndex(this.TxtCodigocliente, 0);
            this.Controls.SetChildIndex(this.cmbmoneda, 0);
            this.Controls.SetChildIndex(this.cmbestatus, 0);
            this.Controls.SetChildIndex(this.cmborden, 0);
            this.Controls.SetChildIndex(this.lblBase16, 0);
            this.Controls.SetChildIndex(this.lblBase7, 0);
            this.Controls.SetChildIndex(this.lblBase6, 0);
            this.Controls.SetChildIndex(this.Dtpfechainicial, 0);
            this.Controls.SetChildIndex(this.Dtpfechafinal, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Logistica.CmbBase cmbestatus;
        private Logistica.CmbBase cmbmoneda;
        public Logistica.TxtEntero TxtCodigocliente;
        public Logistica.TxtMayuscula Txtnombrecliente;
        public Logistica.BtnBuscar BtnBuscarbeneficiario;
        private Logistica.CmbBase cmborden;
        private Logistica.LblBase lblBase16;
        private Logistica.LblBase lblBase8;
        private Logistica.LblBase lblBase14;
        private Logistica.LblBase lblBase1;
        private Logistica.DtpBase Dtpfechafinal;
        private Logistica.DtpBase Dtpfechainicial;
        private Logistica.LblBase lblBase6;
        private Logistica.LblBase lblBase7;
    }
}
