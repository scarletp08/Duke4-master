namespace Duke4.CXC.Proceso
{
    partial class cxcproacuerdopago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cxcproacuerdopago));
            this.Txtacuerdopago = new Duke4.Logistica.TxtMayuscula();
            this.lblBase1 = new Duke4.Logistica.LblBase();
            this.BtnBuscarAcuerdoPago = new Duke4.Logistica.BtnBuscar();
            this.Dtpfecha = new Duke4.Logistica.DtpBase();
            this.myLabel2 = new Duke4.Logistica.LblBase();
            this.Txtcodigocliente = new Duke4.Logistica.TxtEntero();
            this.myLabel4 = new Duke4.Logistica.LblBase();
            this.Txtnombrecliente = new Duke4.Logistica.TxtMayuscula();
            this.BtnBuscarCliente = new Duke4.Logistica.BtnBuscar();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtmonto = new Duke4.Logistica.TxtDecimal();
            this.lblBase2 = new Duke4.Logistica.LblBase();
            this.Cmbhorario = new Duke4.Logistica.CmbBase();
            this.myLabel16 = new Duke4.Logistica.LblBase();
            this.lblBase3 = new Duke4.Logistica.LblBase();
            this.Txtconcepto = new Duke4.Logistica.TxtMayuscula();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBase4 = new Duke4.Logistica.LblBase();
            this.Rdbabierto = new Duke4.Logistica.RdbBase();
            this.Rdbcerrado = new Duke4.Logistica.RdbBase();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.Rdbcerrado);
            this.MainPanel.Controls.Add(this.Rdbabierto);
            this.MainPanel.Controls.Add(this.lblBase4);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.lblBase3);
            this.MainPanel.Controls.Add(this.Txtconcepto);
            this.MainPanel.Controls.Add(this.Cmbhorario);
            this.MainPanel.Controls.Add(this.myLabel16);
            this.MainPanel.Controls.Add(this.lblBase2);
            this.MainPanel.Controls.Add(this.Txtmonto);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.Txtcodigocliente);
            this.MainPanel.Controls.Add(this.myLabel4);
            this.MainPanel.Controls.Add(this.Txtnombrecliente);
            this.MainPanel.Controls.Add(this.BtnBuscarCliente);
            this.MainPanel.Controls.Add(this.Dtpfecha);
            this.MainPanel.Controls.Add(this.myLabel2);
            this.MainPanel.Controls.Add(this.BtnBuscarAcuerdoPago);
            this.MainPanel.Controls.Add(this.lblBase1);
            this.MainPanel.Controls.Add(this.Txtacuerdopago);
            this.MainPanel.Location = new System.Drawing.Point(1, 114);
            this.MainPanel.Size = new System.Drawing.Size(531, 242);
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
            this.panel2.Location = new System.Drawing.Point(1, 357);
            this.panel2.Size = new System.Drawing.Size(768, 11);
            // 
            // FormTitle
            // 
            this.FormTitle.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.FormTitle.ForeColor = System.Drawing.Color.White;
            this.FormTitle.Size = new System.Drawing.Size(88, 23);
            // 
            // Txtacuerdopago
            // 
            this.Txtacuerdopago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtacuerdopago.Location = new System.Drawing.Point(99, 3);
            this.Txtacuerdopago.Name = "Txtacuerdopago";
            this.Txtacuerdopago.Size = new System.Drawing.Size(100, 23);
            this.Txtacuerdopago.TabIndex = 0;
            this.Txtacuerdopago.Validating += new System.ComponentModel.CancelEventHandler(this.Txtcobro_Validating);
            // 
            // lblBase1
            // 
            this.lblBase1.AutoSize = true;
            this.lblBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase1.ForeColor = System.Drawing.Color.Black;
            this.lblBase1.Location = new System.Drawing.Point(5, 6);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(61, 16);
            this.lblBase1.TabIndex = 1;
            this.lblBase1.Text = "Registro";
            // 
            // BtnBuscarAcuerdoPago
            // 
            this.BtnBuscarAcuerdoPago.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnBuscarAcuerdoPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBuscarAcuerdoPago.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBuscarAcuerdoPago.FlatAppearance.BorderSize = 0;
            this.BtnBuscarAcuerdoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarAcuerdoPago.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarAcuerdoPago.Image")));
            this.BtnBuscarAcuerdoPago.Location = new System.Drawing.Point(221, 3);
            this.BtnBuscarAcuerdoPago.Name = "BtnBuscarAcuerdoPago";
            this.BtnBuscarAcuerdoPago.Size = new System.Drawing.Size(24, 24);
            this.BtnBuscarAcuerdoPago.TabIndex = 281;
            this.BtnBuscarAcuerdoPago.TabStop = false;
            this.BtnBuscarAcuerdoPago.Text = " ";
            this.toolTip1.SetToolTip(this.BtnBuscarAcuerdoPago, "Buscar Acuerdo de pago");
            this.BtnBuscarAcuerdoPago.UseVisualStyleBackColor = false;
            this.BtnBuscarAcuerdoPago.Click += new System.EventHandler(this.BtnBuscarAcuerdoPago_Click);
            // 
            // Dtpfecha
            // 
            this.Dtpfecha.CustomFormat = "dd/MM/yyyy";
            this.Dtpfecha.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtpfecha.Location = new System.Drawing.Point(392, 3);
            this.Dtpfecha.Name = "Dtpfecha";
            this.Dtpfecha.Size = new System.Drawing.Size(114, 23);
            this.Dtpfecha.TabIndex = 282;
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(311, 6);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(48, 16);
            this.myLabel2.TabIndex = 283;
            this.myLabel2.Text = "Fecha";
            // 
            // Txtcodigocliente
            // 
            this.Txtcodigocliente.BackColor = System.Drawing.SystemColors.Window;
            this.Txtcodigocliente.Location = new System.Drawing.Point(99, 51);
            this.Txtcodigocliente.MaxLength = 9;
            this.Txtcodigocliente.Name = "Txtcodigocliente";
            this.Txtcodigocliente.Size = new System.Drawing.Size(100, 23);
            this.Txtcodigocliente.TabIndex = 289;
            this.Txtcodigocliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txtcodigocliente.Validating += new System.ComponentModel.CancelEventHandler(this.Txtcodigocliente_Validating);
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(5, 54);
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
            this.Txtnombrecliente.Location = new System.Drawing.Point(99, 80);
            this.Txtnombrecliente.Name = "Txtnombrecliente";
            this.Txtnombrecliente.ReadOnly = true;
            this.Txtnombrecliente.Size = new System.Drawing.Size(407, 23);
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
            this.BtnBuscarCliente.Location = new System.Drawing.Point(221, 51);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(24, 24);
            this.BtnBuscarCliente.TabIndex = 290;
            this.BtnBuscarCliente.TabStop = false;
            this.BtnBuscarCliente.Text = " ";
            this.toolTip1.SetToolTip(this.BtnBuscarCliente, "Buscar Cliente");
            this.BtnBuscarCliente.UseVisualStyleBackColor = false;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 2);
            this.label1.TabIndex = 293;
            this.label1.Text = "label1";
            // 
            // Txtmonto
            // 
            this.Txtmonto.BackColor = System.Drawing.SystemColors.Window;
            this.Txtmonto.Location = new System.Drawing.Point(8, 131);
            this.Txtmonto.MaxLength = 14;
            this.Txtmonto.Name = "Txtmonto";
            this.Txtmonto.Size = new System.Drawing.Size(100, 23);
            this.Txtmonto.TabIndex = 294;
            this.Txtmonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBase2
            // 
            this.lblBase2.AutoSize = true;
            this.lblBase2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase2.ForeColor = System.Drawing.Color.Black;
            this.lblBase2.Location = new System.Drawing.Point(6, 112);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(49, 16);
            this.lblBase2.TabIndex = 295;
            this.lblBase2.Text = "Monto";
            // 
            // Cmbhorario
            // 
            this.Cmbhorario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmbhorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbhorario.FormattingEnabled = true;
            this.Cmbhorario.Items.AddRange(new object[] {
            "DIA",
            "MAÑANA",
            "TARDE"});
            this.Cmbhorario.Location = new System.Drawing.Point(406, 131);
            this.Cmbhorario.Name = "Cmbhorario";
            this.Cmbhorario.ReadOnly = false;
            this.Cmbhorario.Size = new System.Drawing.Size(100, 24);
            this.Cmbhorario.TabIndex = 298;
            this.Cmbhorario.TabStop = false;
            // 
            // myLabel16
            // 
            this.myLabel16.AutoSize = true;
            this.myLabel16.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel16.ForeColor = System.Drawing.Color.Black;
            this.myLabel16.Location = new System.Drawing.Point(403, 112);
            this.myLabel16.Name = "myLabel16";
            this.myLabel16.Size = new System.Drawing.Size(54, 16);
            this.myLabel16.TabIndex = 299;
            this.myLabel16.Text = "Horario";
            // 
            // lblBase3
            // 
            this.lblBase3.AutoSize = true;
            this.lblBase3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase3.ForeColor = System.Drawing.Color.Black;
            this.lblBase3.Location = new System.Drawing.Point(8, 163);
            this.lblBase3.Name = "lblBase3";
            this.lblBase3.Size = new System.Drawing.Size(71, 16);
            this.lblBase3.TabIndex = 301;
            this.lblBase3.Text = "Concepto";
            // 
            // Txtconcepto
            // 
            this.Txtconcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtconcepto.Location = new System.Drawing.Point(11, 182);
            this.Txtconcepto.Name = "Txtconcepto";
            this.Txtconcepto.Size = new System.Drawing.Size(495, 23);
            this.Txtconcepto.TabIndex = 300;
            this.Txtconcepto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtconcepto_KeyPress);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(11, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(495, 2);
            this.label2.TabIndex = 302;
            this.label2.Text = "label2";
            // 
            // lblBase4
            // 
            this.lblBase4.AutoSize = true;
            this.lblBase4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase4.ForeColor = System.Drawing.Color.Black;
            this.lblBase4.Location = new System.Drawing.Point(8, 83);
            this.lblBase4.Name = "lblBase4";
            this.lblBase4.Size = new System.Drawing.Size(57, 16);
            this.lblBase4.TabIndex = 304;
            this.lblBase4.Text = "Nombre";
            // 
            // Rdbabierto
            // 
            this.Rdbabierto.AutoSize = true;
            this.Rdbabierto.Checked = true;
            this.Rdbabierto.Location = new System.Drawing.Point(202, 112);
            this.Rdbabierto.Name = "Rdbabierto";
            this.Rdbabierto.ReadOnly = false;
            this.Rdbabierto.Size = new System.Drawing.Size(73, 20);
            this.Rdbabierto.TabIndex = 305;
            this.Rdbabierto.TabStop = true;
            this.Rdbabierto.Text = "Abierto";
            this.Rdbabierto.UseVisualStyleBackColor = true;
            // 
            // Rdbcerrado
            // 
            this.Rdbcerrado.AutoSize = true;
            this.Rdbcerrado.Location = new System.Drawing.Point(202, 136);
            this.Rdbcerrado.Name = "Rdbcerrado";
            this.Rdbcerrado.ReadOnly = false;
            this.Rdbcerrado.Size = new System.Drawing.Size(77, 20);
            this.Rdbcerrado.TabIndex = 306;
            this.Rdbcerrado.Text = "Cerrado";
            this.Rdbcerrado.UseVisualStyleBackColor = true;
            // 
            // cxcproacuerdopago
            // 
            this.ClientSize = new System.Drawing.Size(534, 397);
            this.Name = "cxcproacuerdopago";
            this.Load += new System.EventHandler(this.cxcprocobroadelantado_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Logistica.LblBase lblBase1;
        private Logistica.TxtMayuscula Txtacuerdopago;
        public Logistica.BtnBuscar BtnBuscarAcuerdoPago;
        public Logistica.DtpBase Dtpfecha;
        private Logistica.LblBase myLabel2;
        private System.Windows.Forms.Label label1;
        public Logistica.TxtEntero Txtcodigocliente;
        private Logistica.LblBase myLabel4;
        public Logistica.TxtMayuscula Txtnombrecliente;
        public Logistica.BtnBuscar BtnBuscarCliente;
        private Logistica.LblBase lblBase2;
        public Logistica.TxtDecimal Txtmonto;
        public Logistica.CmbBase Cmbhorario;
        private Logistica.LblBase myLabel16;
        private System.Windows.Forms.Label label2;
        private Logistica.LblBase lblBase3;
        private Logistica.TxtMayuscula Txtconcepto;
        private Logistica.RdbBase Rdbcerrado;
        private Logistica.RdbBase Rdbabierto;
        private Logistica.LblBase lblBase4;
    }
}
