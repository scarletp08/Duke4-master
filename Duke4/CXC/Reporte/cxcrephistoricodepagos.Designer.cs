namespace Duke4.CXC.Reporte
{
    partial class cxcrephistoricodepagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cxcrephistoricodepagos));
            this.TxtCodigocliente = new Duke4.Logistica.TxtEntero();
            this.Txtnombrecliente = new Duke4.Logistica.TxtMayuscula();
            this.BtnBuscarbeneficiario = new Duke4.Logistica.BtnBuscar();
            this.lblBase1 = new Duke4.Logistica.LblBase();
            this.cmbmoneda = new Duke4.Logistica.CmbBase();
            this.lblBase13 = new Duke4.Logistica.LblBase();
            this.cmbBase6 = new Duke4.Logistica.CmbBase();
            this.lblBase16 = new Duke4.Logistica.LblBase();
            this.dtpBase3 = new Duke4.Logistica.DtpBase();
            this.dtpBase4 = new Duke4.Logistica.DtpBase();
            this.lblBase2 = new Duke4.Logistica.LblBase();
            this.lblBase5 = new Duke4.Logistica.LblBase();
            this.SuspendLayout();
            
            // 
            // FormTitle
            // 
            this.FormTitle.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.FormTitle.ForeColor = System.Drawing.Color.White;
            this.FormTitle.Size = new System.Drawing.Size(88, 23);
            // 
            // TxtCodigocliente
            // 
            this.TxtCodigocliente.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCodigocliente.Location = new System.Drawing.Point(278, 158);
            this.TxtCodigocliente.MaxLength = 9;
            this.TxtCodigocliente.Name = "TxtCodigocliente";
            this.TxtCodigocliente.Size = new System.Drawing.Size(67, 23);
            this.TxtCodigocliente.TabIndex = 418;
            this.TxtCodigocliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCodigocliente.Validated += new System.EventHandler(this.TxtCodigocliente_Validated);
            // 
            // Txtnombrecliente
            // 
            this.Txtnombrecliente.BackColor = System.Drawing.SystemColors.Window;
            this.Txtnombrecliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtnombrecliente.Enabled = false;
            this.Txtnombrecliente.Location = new System.Drawing.Point(391, 158);
            this.Txtnombrecliente.Name = "Txtnombrecliente";
            this.Txtnombrecliente.ReadOnly = true;
            this.Txtnombrecliente.Size = new System.Drawing.Size(270, 23);
            this.Txtnombrecliente.TabIndex = 420;
            this.Txtnombrecliente.TabStop = false;
            // 
            // BtnBuscarbeneficiario
            // 
            this.BtnBuscarbeneficiario.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnBuscarbeneficiario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBuscarbeneficiario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBuscarbeneficiario.FlatAppearance.BorderSize = 0;
            this.BtnBuscarbeneficiario.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarbeneficiario.Image")));
            this.BtnBuscarbeneficiario.Location = new System.Drawing.Point(346, 158);
            this.BtnBuscarbeneficiario.Name = "BtnBuscarbeneficiario";
            this.BtnBuscarbeneficiario.Size = new System.Drawing.Size(45, 23);
            this.BtnBuscarbeneficiario.TabIndex = 419;
            this.BtnBuscarbeneficiario.TabStop = false;
            this.BtnBuscarbeneficiario.Text = " ";
            this.BtnBuscarbeneficiario.UseVisualStyleBackColor = false;
            this.BtnBuscarbeneficiario.Click += new System.EventHandler(this.BtnBuscarbeneficiario_Click);
            // 
            // lblBase1
            // 
            this.lblBase1.AutoSize = true;
            this.lblBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase1.ForeColor = System.Drawing.Color.Black;
            this.lblBase1.Location = new System.Drawing.Point(218, 158);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(53, 16);
            this.lblBase1.TabIndex = 415;
            this.lblBase1.Text = "Cliente";
            // 
            // cmbmoneda
            // 
            this.cmbmoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbmoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmoneda.FormattingEnabled = true;
            this.cmbmoneda.Location = new System.Drawing.Point(278, 201);
            this.cmbmoneda.Name = "cmbmoneda";
            this.cmbmoneda.ReadOnly = false;
            this.cmbmoneda.Size = new System.Drawing.Size(113, 24);
            this.cmbmoneda.TabIndex = 422;
            this.cmbmoneda.TabStop = false;
            // 
            // lblBase13
            // 
            this.lblBase13.AutoSize = true;
            this.lblBase13.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase13.ForeColor = System.Drawing.Color.Black;
            this.lblBase13.Location = new System.Drawing.Point(214, 201);
            this.lblBase13.Name = "lblBase13";
            this.lblBase13.Size = new System.Drawing.Size(59, 16);
            this.lblBase13.TabIndex = 421;
            this.lblBase13.Text = "Moneda";
            // 
            // cmbBase6
            // 
            this.cmbBase6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBase6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBase6.FormattingEnabled = true;
            this.cmbBase6.Items.AddRange(new object[] {
            "No.Factura",
            "Fecha Factura",
            "No.Cobro",
            "Días"});
            this.cmbBase6.Location = new System.Drawing.Point(489, 64);
            this.cmbBase6.Name = "cmbBase6";
            this.cmbBase6.ReadOnly = false;
            this.cmbBase6.Size = new System.Drawing.Size(111, 24);
            this.cmbBase6.TabIndex = 424;
            this.cmbBase6.TabStop = false;
            // 
            // lblBase16
            // 
            this.lblBase16.AutoSize = true;
            this.lblBase16.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase16.ForeColor = System.Drawing.Color.Black;
            this.lblBase16.Location = new System.Drawing.Point(498, 42);
            this.lblBase16.Name = "lblBase16";
            this.lblBase16.Size = new System.Drawing.Size(86, 16);
            this.lblBase16.TabIndex = 423;
            this.lblBase16.Text = "Ordenar por";
            // 
            // dtpBase3
            // 
            this.dtpBase3.CustomFormat = "dd/MM/yyyy";
            this.dtpBase3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.dtpBase3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBase3.Location = new System.Drawing.Point(278, 121);
            this.dtpBase3.Name = "dtpBase3";
            this.dtpBase3.Size = new System.Drawing.Size(113, 23);
            this.dtpBase3.TabIndex = 430;
            // 
            // dtpBase4
            // 
            this.dtpBase4.CustomFormat = "dd/MM/yyyy";
            this.dtpBase4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.dtpBase4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBase4.Location = new System.Drawing.Point(279, 86);
            this.dtpBase4.Name = "dtpBase4";
            this.dtpBase4.Size = new System.Drawing.Size(112, 23);
            this.dtpBase4.TabIndex = 429;
            // 
            // lblBase2
            // 
            this.lblBase2.AutoSize = true;
            this.lblBase2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase2.ForeColor = System.Drawing.Color.Black;
            this.lblBase2.Location = new System.Drawing.Point(218, 121);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(46, 16);
            this.lblBase2.TabIndex = 428;
            this.lblBase2.Text = "Hasta";
            // 
            // lblBase5
            // 
            this.lblBase5.AutoSize = true;
            this.lblBase5.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase5.ForeColor = System.Drawing.Color.Black;
            this.lblBase5.Location = new System.Drawing.Point(218, 84);
            this.lblBase5.Name = "lblBase5";
            this.lblBase5.Size = new System.Drawing.Size(48, 16);
            this.lblBase5.TabIndex = 427;
            this.lblBase5.Text = "Desde";
            // 
            // cxcrephistoricodepagos
            // 
            this.ClientSize = new System.Drawing.Size(666, 392);
            this.Controls.Add(this.dtpBase3);
            this.Controls.Add(this.dtpBase4);
            this.Controls.Add(this.lblBase2);
            this.Controls.Add(this.lblBase5);
            this.Controls.Add(this.cmbmoneda);
            this.Controls.Add(this.cmbBase6);
            this.Controls.Add(this.lblBase16);
            this.Controls.Add(this.lblBase13);
            this.Controls.Add(this.TxtCodigocliente);
            this.Controls.Add(this.Txtnombrecliente);
            this.Controls.Add(this.BtnBuscarbeneficiario);
            this.Controls.Add(this.lblBase1);
            this.Name = "cxcrephistoricodepagos";
            this.Load += new System.EventHandler(this.cxcrephistoricodepagos_Load);
            this.Controls.SetChildIndex(this.Lbsformato, 0);
            this.Controls.SetChildIndex(this.lblBase1, 0);
            this.Controls.SetChildIndex(this.BtnBuscarbeneficiario, 0);
            this.Controls.SetChildIndex(this.Txtnombrecliente, 0);
            this.Controls.SetChildIndex(this.TxtCodigocliente, 0);
            this.Controls.SetChildIndex(this.lblBase13, 0);
            this.Controls.SetChildIndex(this.lblBase16, 0);
            this.Controls.SetChildIndex(this.cmbBase6, 0);
            this.Controls.SetChildIndex(this.cmbmoneda, 0);
            this.Controls.SetChildIndex(this.lblBase5, 0);
            this.Controls.SetChildIndex(this.lblBase2, 0);
            this.Controls.SetChildIndex(this.dtpBase4, 0);
            this.Controls.SetChildIndex(this.dtpBase3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Logistica.TxtEntero TxtCodigocliente;
        public Logistica.TxtMayuscula Txtnombrecliente;
        public Logistica.BtnBuscar BtnBuscarbeneficiario;
        private Logistica.LblBase lblBase1;
        private Logistica.CmbBase cmbmoneda;
        private Logistica.LblBase lblBase13;
        private Logistica.CmbBase cmbBase6;
        private Logistica.LblBase lblBase16;
        private Logistica.DtpBase dtpBase3;
        private Logistica.DtpBase dtpBase4;
        private Logistica.LblBase lblBase2;
        private Logistica.LblBase lblBase5;
    }
}
