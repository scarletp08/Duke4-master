namespace Duke4.CXC.Reporte
{
    partial class cxcrepacuerdodepagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cxcrepacuerdodepagos));
            this.myLabel4 = new Duke4.Logistica.LblBase();
            this.TxtCodigocliente = new Duke4.Logistica.TxtEntero();
            this.BtnBuscarCliente = new Duke4.Logistica.BtnBuscar();
            this.Txtnombrecliente = new Duke4.Logistica.TxtMayuscula();
            this.Dtpfechafinal = new Duke4.Logistica.DtpBase();
            this.Dtpfechainicial = new Duke4.Logistica.DtpBase();
            this.lblBase2 = new Duke4.Logistica.LblBase();
            this.lblBase1 = new Duke4.Logistica.LblBase();
            this.cmbestatus = new Duke4.Logistica.CmbBase();
            this.lblBase9 = new Duke4.Logistica.LblBase();
            this.cmbtipoacuerdo = new Duke4.Logistica.CmbBase();
            this.lblBase3 = new Duke4.Logistica.LblBase();
            this.SuspendLayout();
            // 
            // Lbsformato
            // 
            this.Lbsformato.ItemHeight = 26;
            this.Lbsformato.Size = new System.Drawing.Size(216, 82);
            // 
            // Lbsorden
            // 
            this.Lbsorden.ItemHeight = 26;
            this.Lbsorden.Location = new System.Drawing.Point(329, 133);
            this.Lbsorden.Size = new System.Drawing.Size(197, 82);
            // 
            // lblGrande2
            // 
            this.lblGrande2.Location = new System.Drawing.Point(365, 107);
            // 
            // lblGrande1
            // 
            this.lblGrande1.Location = new System.Drawing.Point(61, 107);
            // 
            // FormTitle
            // 
            this.FormTitle.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.FormTitle.ForeColor = System.Drawing.Color.White;
            this.FormTitle.Size = new System.Drawing.Size(88, 23);
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(6, 283);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(53, 16);
            this.myLabel4.TabIndex = 374;
            this.myLabel4.Text = "Cliente";
            // 
            // TxtCodigocliente
            // 
            this.TxtCodigocliente.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCodigocliente.Location = new System.Drawing.Point(117, 285);
            this.TxtCodigocliente.MaxLength = 9;
            this.TxtCodigocliente.Name = "TxtCodigocliente";
            this.TxtCodigocliente.Size = new System.Drawing.Size(104, 23);
            this.TxtCodigocliente.TabIndex = 2;
            this.TxtCodigocliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCodigocliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigocliente_KeyDown);
            this.TxtCodigocliente.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodigocliente_Validating);
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.BtnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarCliente.Image")));
            this.BtnBuscarCliente.Location = new System.Drawing.Point(223, 284);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(24, 24);
            this.BtnBuscarCliente.TabIndex = 373;
            this.BtnBuscarCliente.TabStop = false;
            this.BtnBuscarCliente.Text = " ";
            this.toolTip1.SetToolTip(this.BtnBuscarCliente, "Buscar Cliente");
            this.BtnBuscarCliente.UseVisualStyleBackColor = false;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // Txtnombrecliente
            // 
            this.Txtnombrecliente.BackColor = System.Drawing.SystemColors.Window;
            this.Txtnombrecliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtnombrecliente.Enabled = false;
            this.Txtnombrecliente.Location = new System.Drawing.Point(251, 285);
            this.Txtnombrecliente.Name = "Txtnombrecliente";
            this.Txtnombrecliente.ReadOnly = true;
            this.Txtnombrecliente.Size = new System.Drawing.Size(277, 23);
            this.Txtnombrecliente.TabIndex = 375;
            this.Txtnombrecliente.TabStop = false;
            // 
            // Dtpfechafinal
            // 
            this.Dtpfechafinal.CustomFormat = "dd/MM/yyyy";
            this.Dtpfechafinal.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Dtpfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtpfechafinal.Location = new System.Drawing.Point(117, 257);
            this.Dtpfechafinal.Name = "Dtpfechafinal";
            this.Dtpfechafinal.Size = new System.Drawing.Size(117, 23);
            this.Dtpfechafinal.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Dtpfechafinal, "Seleccionar Fecha final");
            // 
            // Dtpfechainicial
            // 
            this.Dtpfechainicial.CustomFormat = "dd/MM/yyyy";
            this.Dtpfechainicial.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Dtpfechainicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtpfechainicial.Location = new System.Drawing.Point(117, 231);
            this.Dtpfechainicial.Name = "Dtpfechainicial";
            this.Dtpfechainicial.Size = new System.Drawing.Size(117, 23);
            this.Dtpfechainicial.TabIndex = 0;
            this.toolTip1.SetToolTip(this.Dtpfechainicial, "Seleccionar Fecha inicial");
            // 
            // lblBase2
            // 
            this.lblBase2.AutoSize = true;
            this.lblBase2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase2.ForeColor = System.Drawing.Color.Black;
            this.lblBase2.Location = new System.Drawing.Point(6, 259);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(46, 16);
            this.lblBase2.TabIndex = 379;
            this.lblBase2.Text = "Hasta";
            // 
            // lblBase1
            // 
            this.lblBase1.AutoSize = true;
            this.lblBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase1.ForeColor = System.Drawing.Color.Black;
            this.lblBase1.Location = new System.Drawing.Point(6, 231);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(48, 16);
            this.lblBase1.TabIndex = 378;
            this.lblBase1.Text = "Desde";
            // 
            // cmbestatus
            // 
            this.cmbestatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbestatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbestatus.FormattingEnabled = true;
            this.cmbestatus.Items.AddRange(new object[] {
            "Todas",
            "Canceladas",
            "No canceladas"});
            this.cmbestatus.Location = new System.Drawing.Point(117, 311);
            this.cmbestatus.Name = "cmbestatus";
            this.cmbestatus.ReadOnly = false;
            this.cmbestatus.Size = new System.Drawing.Size(117, 24);
            this.cmbestatus.TabIndex = 3;
            this.cmbestatus.DropDown += new System.EventHandler(this.cmbestatus_DropDown);
            this.cmbestatus.Enter += new System.EventHandler(this.cmbestatus_Enter);
            // 
            // lblBase9
            // 
            this.lblBase9.AutoSize = true;
            this.lblBase9.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase9.ForeColor = System.Drawing.Color.Black;
            this.lblBase9.Location = new System.Drawing.Point(6, 314);
            this.lblBase9.Name = "lblBase9";
            this.lblBase9.Size = new System.Drawing.Size(58, 16);
            this.lblBase9.TabIndex = 381;
            this.lblBase9.Text = "Estatus";
            // 
            // cmbtipoacuerdo
            // 
            this.cmbtipoacuerdo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbtipoacuerdo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipoacuerdo.FormattingEnabled = true;
            this.cmbtipoacuerdo.Items.AddRange(new object[] {
            "Todos ",
            "Abiertos",
            "Cerrados"});
            this.cmbtipoacuerdo.Location = new System.Drawing.Point(117, 336);
            this.cmbtipoacuerdo.Name = "cmbtipoacuerdo";
            this.cmbtipoacuerdo.ReadOnly = false;
            this.cmbtipoacuerdo.Size = new System.Drawing.Size(117, 24);
            this.cmbtipoacuerdo.TabIndex = 4;
            this.cmbtipoacuerdo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbtipoacuerdo_KeyPress);
            // 
            // lblBase3
            // 
            this.lblBase3.AutoSize = true;
            this.lblBase3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase3.ForeColor = System.Drawing.Color.Black;
            this.lblBase3.Location = new System.Drawing.Point(6, 339);
            this.lblBase3.Name = "lblBase3";
            this.lblBase3.Size = new System.Drawing.Size(62, 16);
            this.lblBase3.TabIndex = 411;
            this.lblBase3.Text = "Acuerdo";
            // 
            // cxcrepacuerdodepagos
            // 
            this.ClientSize = new System.Drawing.Size(538, 374);
            this.Controls.Add(this.cmbtipoacuerdo);
            this.Controls.Add(this.lblBase3);
            this.Controls.Add(this.cmbestatus);
            this.Controls.Add(this.lblBase9);
            this.Controls.Add(this.Dtpfechafinal);
            this.Controls.Add(this.Dtpfechainicial);
            this.Controls.Add(this.lblBase2);
            this.Controls.Add(this.lblBase1);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.TxtCodigocliente);
            this.Controls.Add(this.BtnBuscarCliente);
            this.Controls.Add(this.Txtnombrecliente);
            this.Name = "cxcrepacuerdodepagos";
            this.Load += new System.EventHandler(this.acuerdodepago_Load);
            this.Controls.SetChildIndex(this.lblGrande1, 0);
            this.Controls.SetChildIndex(this.lblGrande2, 0);
            this.Controls.SetChildIndex(this.Lbsorden, 0);
            this.Controls.SetChildIndex(this.Lbsformato, 0);
            this.Controls.SetChildIndex(this.Txtnombrecliente, 0);
            this.Controls.SetChildIndex(this.BtnBuscarCliente, 0);
            this.Controls.SetChildIndex(this.TxtCodigocliente, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.lblBase1, 0);
            this.Controls.SetChildIndex(this.lblBase2, 0);
            this.Controls.SetChildIndex(this.Dtpfechainicial, 0);
            this.Controls.SetChildIndex(this.Dtpfechafinal, 0);
            this.Controls.SetChildIndex(this.lblBase9, 0);
            this.Controls.SetChildIndex(this.cmbestatus, 0);
            this.Controls.SetChildIndex(this.lblBase3, 0);
            this.Controls.SetChildIndex(this.cmbtipoacuerdo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Logistica.LblBase myLabel4;
        public Logistica.TxtEntero TxtCodigocliente;
        public Logistica.BtnBuscar BtnBuscarCliente;
        public Logistica.TxtMayuscula Txtnombrecliente;
        private Logistica.DtpBase Dtpfechafinal;
        private Logistica.DtpBase Dtpfechainicial;
        private Logistica.LblBase lblBase2;
        private Logistica.LblBase lblBase1;
        private Logistica.CmbBase cmbestatus;
        private Logistica.LblBase lblBase9;
        private Logistica.CmbBase cmbtipoacuerdo;
        private Logistica.LblBase lblBase3;
    }
}
