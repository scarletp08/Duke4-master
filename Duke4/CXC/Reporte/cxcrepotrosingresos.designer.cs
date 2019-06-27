namespace Duke4.CXC.Reporte
{
    partial class cxcrepotrosingresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cxcrepotrosingresos));
            this.lblBase1 = new Duke4.Logistica.LblBase();
            this.cmbestatus = new Duke4.Logistica.CmbBase();
            this.lblBase14 = new Duke4.Logistica.LblBase();
            this.cmbmoneda = new Duke4.Logistica.CmbBase();
            this.lblBase8 = new Duke4.Logistica.LblBase();
            this.Txtnombrebeneficiario = new Duke4.Logistica.TxtMayuscula();
            this.BtnBuscarcliente = new Duke4.Logistica.BtnBuscar();
            this.Dtpfechafinal = new Duke4.Logistica.DtpBase();
            this.Dtpfechainicial = new Duke4.Logistica.DtpBase();
            this.lblBase3 = new Duke4.Logistica.LblBase();
            this.lblBase4 = new Duke4.Logistica.LblBase();
            this.cmborden = new Duke4.Logistica.CmbBase();
            this.lblBase12 = new Duke4.Logistica.LblBase();
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
            // lblBase1
            // 
            this.lblBase1.AutoSize = true;
            this.lblBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase1.ForeColor = System.Drawing.Color.Black;
            this.lblBase1.Location = new System.Drawing.Point(209, 142);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(91, 16);
            this.lblBase1.TabIndex = 321;
            this.lblBase1.Text = "A nombre de";
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
            this.cmbestatus.Location = new System.Drawing.Point(360, 162);
            this.cmbestatus.Name = "cmbestatus";
            this.cmbestatus.ReadOnly = false;
            this.cmbestatus.Size = new System.Drawing.Size(113, 24);
            this.cmbestatus.TabIndex = 3;
            // 
            // lblBase14
            // 
            this.lblBase14.AutoSize = true;
            this.lblBase14.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase14.ForeColor = System.Drawing.Color.Black;
            this.lblBase14.Location = new System.Drawing.Point(210, 171);
            this.lblBase14.Name = "lblBase14";
            this.lblBase14.Size = new System.Drawing.Size(58, 16);
            this.lblBase14.TabIndex = 372;
            this.lblBase14.Text = "Estatus";
            // 
            // cmbmoneda
            // 
            this.cmbmoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbmoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmoneda.FormattingEnabled = true;
            this.cmbmoneda.Location = new System.Drawing.Point(360, 190);
            this.cmbmoneda.Name = "cmbmoneda";
            this.cmbmoneda.ReadOnly = false;
            this.cmbmoneda.Size = new System.Drawing.Size(113, 24);
            this.cmbmoneda.TabIndex = 4;
            // 
            // lblBase8
            // 
            this.lblBase8.AutoSize = true;
            this.lblBase8.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase8.ForeColor = System.Drawing.Color.Black;
            this.lblBase8.Location = new System.Drawing.Point(210, 196);
            this.lblBase8.Name = "lblBase8";
            this.lblBase8.Size = new System.Drawing.Size(59, 16);
            this.lblBase8.TabIndex = 376;
            this.lblBase8.Text = "Moneda";
            // 
            // Txtnombrebeneficiario
            // 
            this.Txtnombrebeneficiario.BackColor = System.Drawing.SystemColors.Window;
            this.Txtnombrebeneficiario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtnombrebeneficiario.Location = new System.Drawing.Point(360, 137);
            this.Txtnombrebeneficiario.Name = "Txtnombrebeneficiario";
            this.Txtnombrebeneficiario.Size = new System.Drawing.Size(281, 23);
            this.Txtnombrebeneficiario.TabIndex = 2;
            this.Txtnombrebeneficiario.Text = " ";
            // 
            // BtnBuscarcliente
            // 
            this.BtnBuscarcliente.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnBuscarcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBuscarcliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBuscarcliente.FlatAppearance.BorderSize = 0;
            this.BtnBuscarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarcliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarcliente.Image")));
            this.BtnBuscarcliente.Location = new System.Drawing.Point(642, 134);
            this.BtnBuscarcliente.Name = "BtnBuscarcliente";
            this.BtnBuscarcliente.Size = new System.Drawing.Size(24, 24);
            this.BtnBuscarcliente.TabIndex = 381;
            this.BtnBuscarcliente.TabStop = false;
            this.BtnBuscarcliente.Text = " ";
            this.toolTip1.SetToolTip(this.BtnBuscarcliente, "Buscar beneficiario");
            this.BtnBuscarcliente.UseVisualStyleBackColor = false;
            this.BtnBuscarcliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // Dtpfechafinal
            // 
            this.Dtpfechafinal.CustomFormat = "dd/MM/yyyy";
            this.Dtpfechafinal.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Dtpfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtpfechafinal.Location = new System.Drawing.Point(360, 111);
            this.Dtpfechafinal.Name = "Dtpfechafinal";
            this.Dtpfechafinal.Size = new System.Drawing.Size(137, 23);
            this.Dtpfechafinal.TabIndex = 1;
            // 
            // Dtpfechainicial
            // 
            this.Dtpfechainicial.CustomFormat = "dd/MM/yyyy";
            this.Dtpfechainicial.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Dtpfechainicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtpfechainicial.Location = new System.Drawing.Point(360, 85);
            this.Dtpfechainicial.Name = "Dtpfechainicial";
            this.Dtpfechainicial.Size = new System.Drawing.Size(137, 23);
            this.Dtpfechainicial.TabIndex = 0;
            // 
            // lblBase3
            // 
            this.lblBase3.AutoSize = true;
            this.lblBase3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase3.ForeColor = System.Drawing.Color.Black;
            this.lblBase3.Location = new System.Drawing.Point(210, 116);
            this.lblBase3.Name = "lblBase3";
            this.lblBase3.Size = new System.Drawing.Size(46, 16);
            this.lblBase3.TabIndex = 386;
            this.lblBase3.Text = "Hasta";
            // 
            // lblBase4
            // 
            this.lblBase4.AutoSize = true;
            this.lblBase4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase4.ForeColor = System.Drawing.Color.Black;
            this.lblBase4.Location = new System.Drawing.Point(210, 90);
            this.lblBase4.Name = "lblBase4";
            this.lblBase4.Size = new System.Drawing.Size(48, 16);
            this.lblBase4.TabIndex = 385;
            this.lblBase4.Text = "Desde";
            // 
            // cmborden
            // 
            this.cmborden.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmborden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmborden.FormattingEnabled = true;
            this.cmborden.Items.AddRange(new object[] {
            "Numero",
            "Fecha ",
            "A nombre de"});
            this.cmborden.Location = new System.Drawing.Point(360, 218);
            this.cmborden.Name = "cmborden";
            this.cmborden.ReadOnly = false;
            this.cmborden.Size = new System.Drawing.Size(137, 24);
            this.cmborden.TabIndex = 5;
            this.cmborden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmborden_KeyPress);
            // 
            // lblBase12
            // 
            this.lblBase12.AutoSize = true;
            this.lblBase12.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase12.ForeColor = System.Drawing.Color.Black;
            this.lblBase12.Location = new System.Drawing.Point(210, 224);
            this.lblBase12.Name = "lblBase12";
            this.lblBase12.Size = new System.Drawing.Size(86, 16);
            this.lblBase12.TabIndex = 387;
            this.lblBase12.Text = "Ordenar por";
            // 
            // cxcrepotrosingresos
            // 
            this.ClientSize = new System.Drawing.Size(794, 433);
            this.Controls.Add(this.cmborden);
            this.Controls.Add(this.lblBase12);
            this.Controls.Add(this.Dtpfechafinal);
            this.Controls.Add(this.Dtpfechainicial);
            this.Controls.Add(this.lblBase3);
            this.Controls.Add(this.lblBase4);
            this.Controls.Add(this.cmbestatus);
            this.Controls.Add(this.cmbmoneda);
            this.Controls.Add(this.Txtnombrebeneficiario);
            this.Controls.Add(this.BtnBuscarcliente);
            this.Controls.Add(this.lblBase8);
            this.Controls.Add(this.lblBase14);
            this.Controls.Add(this.lblBase1);
            this.Name = "cxcrepotrosingresos";
            this.Load += new System.EventHandler(this.cxcrepotrosingresos_Load);
            this.Controls.SetChildIndex(this.Lbsformato, 0);
            this.Controls.SetChildIndex(this.lblBase1, 0);
            this.Controls.SetChildIndex(this.lblBase14, 0);
            this.Controls.SetChildIndex(this.lblBase8, 0);
            this.Controls.SetChildIndex(this.BtnBuscarcliente, 0);
            this.Controls.SetChildIndex(this.Txtnombrebeneficiario, 0);
            this.Controls.SetChildIndex(this.cmbmoneda, 0);
            this.Controls.SetChildIndex(this.cmbestatus, 0);
            this.Controls.SetChildIndex(this.lblBase4, 0);
            this.Controls.SetChildIndex(this.lblBase3, 0);
            this.Controls.SetChildIndex(this.Dtpfechainicial, 0);
            this.Controls.SetChildIndex(this.Dtpfechafinal, 0);
            this.Controls.SetChildIndex(this.lblBase12, 0);
            this.Controls.SetChildIndex(this.cmborden, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Logistica.LblBase lblBase1;
        private Logistica.CmbBase cmbestatus;
        private Logistica.LblBase lblBase14;
        private Logistica.CmbBase cmbmoneda;
        private Logistica.LblBase lblBase8;
        public Logistica.TxtMayuscula Txtnombrebeneficiario;
        public Logistica.BtnBuscar BtnBuscarcliente;
        private Logistica.DtpBase Dtpfechafinal;
        private Logistica.DtpBase Dtpfechainicial;
        private Logistica.LblBase lblBase3;
        private Logistica.LblBase lblBase4;
        private Logistica.CmbBase cmborden;
        private Logistica.LblBase lblBase12;
    }
}
