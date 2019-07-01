namespace Duke4.CXC.Proceso
{
    partial class cxcproregistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cxcproregistro));
            this.lblBase1 = new Duke4.Logistica.LblBase();
            this.Txtregistro = new Duke4.Logistica.TxtMayuscula();
            this.lblBase2 = new Duke4.Logistica.LblBase();
            this.Txtcodigocliente = new Duke4.Logistica.TxtEntero();
            this.lblBase3 = new Duke4.Logistica.LblBase();
            this.lblBase4 = new Duke4.Logistica.LblBase();
            this.lblBase5 = new Duke4.Logistica.LblBase();
            this.Txtnombrecliente = new Duke4.Logistica.TxtMayuscula();
            this.Txtdireccioncliente = new Duke4.Logistica.TxtMayuscula();
            this.lblBase6 = new Duke4.Logistica.LblBase();
            this.Txttelefonocliente = new Duke4.Logistica.MskTelefono();
            this.Txtrnccliente = new Duke4.Logistica.MskRncCedula();
            this.Txtbalancecliente = new Duke4.Logistica.TxtDecimal();
            this.lblBase8 = new Duke4.Logistica.LblBase();
            this.Dtpfecha = new Duke4.Logistica.DtpBase();
            this.lblBase9 = new Duke4.Logistica.LblBase();
            this.Txtreferencia = new Duke4.Logistica.TxtMayuscula();
            this.lblBase10 = new Duke4.Logistica.LblBase();
            this.lblBase11 = new Duke4.Logistica.LblBase();
            this.Mskncf = new Duke4.Logistica.MskNCF();
            this.Txtnombrevendedor = new Duke4.Logistica.TxtMayuscula();
            this.Txtcodigovendedor = new Duke4.Logistica.TxtEntero();
            this.lblBase13 = new Duke4.Logistica.LblBase();
            this.Dgv = new Duke4.Logistica.GridBase();
            this.dgvorden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvmonto = new Duke4.Logistica.GridBase.DoubleColumn();
            this.dgvitbis = new Duke4.Logistica.GridBase.DoubleColumn();
            this.dgvtotal = new Duke4.Logistica.GridBase.DoubleColumn();
            this.dgvtasaitbis = new Duke4.Logistica.GridBase.DoubleColumn();
            this.Txtdescripcionconcepto = new Duke4.Logistica.TxtMayuscula();
            this.Txtcodigoconcepto = new Duke4.Logistica.TxtEntero();
            this.lblBase12 = new Duke4.Logistica.LblBase();
            this.Txtmontogravado = new Duke4.Logistica.TxtDecimal();
            this.BtnAgregarConcepto = new System.Windows.Forms.Button();
            this.lblBase7 = new Duke4.Logistica.LblBase();
            this.Txtexcento = new Duke4.Logistica.TxtDecimal();
            this.lblBase14 = new Duke4.Logistica.LblBase();
            this.Txtgravado18 = new Duke4.Logistica.TxtDecimal();
            this.lblBase15 = new Duke4.Logistica.LblBase();
            this.Txtcomentrio = new Duke4.Logistica.TxtMayuscula();
            this.lblBase16 = new Duke4.Logistica.LblBase();
            this.lblBase17 = new Duke4.Logistica.LblBase();
            this.Cmbmoneda = new Duke4.Logistica.CmbBase();
            this.BtnBuscarConcepto = new Duke4.Logistica.BtnBuscar();
            this.Dtpfechavencimiento = new Duke4.Logistica.DtpBase();
            this.Txtitbis = new Duke4.Logistica.TxtDecimal();
            this.lblBase18 = new Duke4.Logistica.LblBase();
            this.Txtgravado16 = new Duke4.Logistica.TxtDecimal();
            this.lblBase19 = new Duke4.Logistica.LblBase();
            this.Txttotal = new Duke4.Logistica.TxtDecimal();
            this.lblBase20 = new Duke4.Logistica.LblBase();
            this.button1 = new System.Windows.Forms.Button();
            this.Ckbimprimir = new Duke4.Logistica.CkbBase();
            this.BtnBuscarVendedor = new Duke4.Logistica.BtnBuscar();
            this.BtnBuscarRegistro = new Duke4.Logistica.BtnBuscar();
            this.BtnBuscarCliente = new Duke4.Logistica.BtnBuscar();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.Ckbimprimir);
            this.MainPanel.Controls.Add(this.button1);
            this.MainPanel.Controls.Add(this.Txttotal);
            this.MainPanel.Controls.Add(this.lblBase20);
            this.MainPanel.Controls.Add(this.Txtitbis);
            this.MainPanel.Controls.Add(this.lblBase18);
            this.MainPanel.Controls.Add(this.Txtgravado16);
            this.MainPanel.Controls.Add(this.lblBase19);
            this.MainPanel.Controls.Add(this.Dtpfechavencimiento);
            this.MainPanel.Controls.Add(this.BtnBuscarConcepto);
            this.MainPanel.Controls.Add(this.BtnBuscarVendedor);
            this.MainPanel.Controls.Add(this.BtnBuscarCliente);
            this.MainPanel.Controls.Add(this.BtnBuscarRegistro);
            this.MainPanel.Controls.Add(this.Cmbmoneda);
            this.MainPanel.Controls.Add(this.lblBase17);
            this.MainPanel.Controls.Add(this.Txtcomentrio);
            this.MainPanel.Controls.Add(this.lblBase16);
            this.MainPanel.Controls.Add(this.Txtgravado18);
            this.MainPanel.Controls.Add(this.lblBase15);
            this.MainPanel.Controls.Add(this.Txtexcento);
            this.MainPanel.Controls.Add(this.lblBase14);
            this.MainPanel.Controls.Add(this.BtnAgregarConcepto);
            this.MainPanel.Controls.Add(this.Txtmontogravado);
            this.MainPanel.Controls.Add(this.Txtdescripcionconcepto);
            this.MainPanel.Controls.Add(this.Txtcodigoconcepto);
            this.MainPanel.Controls.Add(this.lblBase12);
            this.MainPanel.Controls.Add(this.Dgv);
            this.MainPanel.Controls.Add(this.Txtnombrevendedor);
            this.MainPanel.Controls.Add(this.Txtcodigovendedor);
            this.MainPanel.Controls.Add(this.lblBase13);
            this.MainPanel.Controls.Add(this.Mskncf);
            this.MainPanel.Controls.Add(this.lblBase11);
            this.MainPanel.Controls.Add(this.Txtreferencia);
            this.MainPanel.Controls.Add(this.lblBase10);
            this.MainPanel.Controls.Add(this.lblBase9);
            this.MainPanel.Controls.Add(this.Dtpfecha);
            this.MainPanel.Controls.Add(this.lblBase8);
            this.MainPanel.Controls.Add(this.Txtbalancecliente);
            this.MainPanel.Controls.Add(this.Txtrnccliente);
            this.MainPanel.Controls.Add(this.Txttelefonocliente);
            this.MainPanel.Controls.Add(this.lblBase7);
            this.MainPanel.Controls.Add(this.lblBase6);
            this.MainPanel.Controls.Add(this.Txtdireccioncliente);
            this.MainPanel.Controls.Add(this.Txtnombrecliente);
            this.MainPanel.Controls.Add(this.lblBase5);
            this.MainPanel.Controls.Add(this.lblBase4);
            this.MainPanel.Controls.Add(this.lblBase3);
            this.MainPanel.Controls.Add(this.Txtcodigocliente);
            this.MainPanel.Controls.Add(this.lblBase2);
            this.MainPanel.Controls.Add(this.Txtregistro);
            this.MainPanel.Controls.Add(this.lblBase1);
            this.MainPanel.Location = new System.Drawing.Point(8, 104);
            this.MainPanel.Size = new System.Drawing.Size(570, 553);
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            this.MainPanel.Controls.SetChildIndex(this.lblBase1, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtregistro, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase2, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtcodigocliente, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase3, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase4, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase5, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtnombrecliente, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtdireccioncliente, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase6, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase7, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txttelefonocliente, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtrnccliente, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtbalancecliente, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase8, 0);
            this.MainPanel.Controls.SetChildIndex(this.Dtpfecha, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase9, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase10, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtreferencia, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase11, 0);
            this.MainPanel.Controls.SetChildIndex(this.Mskncf, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase13, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtcodigovendedor, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtnombrevendedor, 0);
            this.MainPanel.Controls.SetChildIndex(this.Dgv, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase12, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtcodigoconcepto, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtdescripcionconcepto, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtmontogravado, 0);
            this.MainPanel.Controls.SetChildIndex(this.BtnAgregarConcepto, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase14, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtexcento, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase15, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtgravado18, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase16, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtcomentrio, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase17, 0);
            this.MainPanel.Controls.SetChildIndex(this.Cmbmoneda, 0);
            this.MainPanel.Controls.SetChildIndex(this.BtnBuscarRegistro, 0);
            this.MainPanel.Controls.SetChildIndex(this.BtnBuscarCliente, 0);
            this.MainPanel.Controls.SetChildIndex(this.BtnBuscarVendedor, 0);
            this.MainPanel.Controls.SetChildIndex(this.BtnBuscarConcepto, 0);
            this.MainPanel.Controls.SetChildIndex(this.Dtpfechavencimiento, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase19, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtgravado16, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase18, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtitbis, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase20, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txttotal, 0);
            this.MainPanel.Controls.SetChildIndex(this.button1, 0);
            this.MainPanel.Controls.SetChildIndex(this.Ckbimprimir, 0);
            this.MainPanel.Controls.SetChildIndex(this.LblFunctionName, 0);
            // 
            // LblAlerta
            // 
            this.LblAlerta.Location = new System.Drawing.Point(12, 677);
            this.LblAlerta.Size = new System.Drawing.Size(0, 23);
            this.LblAlerta.Text = "";
            // 
            // LblFunctionName
            // 
            this.LblFunctionName.Location = new System.Drawing.Point(297, 1);
            this.LblFunctionName.Size = new System.Drawing.Size(0, 32);
            this.LblFunctionName.Text = "";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(1, 685);
            this.panel2.Size = new System.Drawing.Size(588, 10);
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
            this.lblBase1.Location = new System.Drawing.Point(13, 14);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(58, 16);
            this.lblBase1.TabIndex = 0;
            this.lblBase1.Text = "Factura";
            // 
            // Txtregistro
            // 
            this.Txtregistro.BackColor = System.Drawing.SystemColors.Window;
            this.Txtregistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtregistro.Enabled = false;
            this.Txtregistro.Location = new System.Drawing.Point(92, 11);
            this.Txtregistro.Name = "Txtregistro";
            this.Txtregistro.Size = new System.Drawing.Size(100, 23);
            this.Txtregistro.TabIndex = 1;
            this.Txtregistro.Validating += new System.ComponentModel.CancelEventHandler(this.Txtregistro_Validating);
            // 
            // lblBase2
            // 
            this.lblBase2.AutoSize = true;
            this.lblBase2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase2.ForeColor = System.Drawing.Color.Black;
            this.lblBase2.Location = new System.Drawing.Point(13, 43);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(53, 16);
            this.lblBase2.TabIndex = 2;
            this.lblBase2.Text = "Cliente";
            // 
            // Txtcodigocliente
            // 
            this.Txtcodigocliente.BackColor = System.Drawing.SystemColors.Window;
            this.Txtcodigocliente.Location = new System.Drawing.Point(93, 40);
            this.Txtcodigocliente.Name = "Txtcodigocliente";
            this.Txtcodigocliente.Size = new System.Drawing.Size(100, 23);
            this.Txtcodigocliente.TabIndex = 2;
            this.Txtcodigocliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txtcodigocliente.Validating += new System.ComponentModel.CancelEventHandler(this.Txtcodigocliente_Validating);
            // 
            // lblBase3
            // 
            this.lblBase3.AutoSize = true;
            this.lblBase3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase3.ForeColor = System.Drawing.Color.Black;
            this.lblBase3.Location = new System.Drawing.Point(13, 65);
            this.lblBase3.Name = "lblBase3";
            this.lblBase3.Size = new System.Drawing.Size(57, 16);
            this.lblBase3.TabIndex = 4;
            this.lblBase3.Text = "Nombre";
            // 
            // lblBase4
            // 
            this.lblBase4.AutoSize = true;
            this.lblBase4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase4.ForeColor = System.Drawing.Color.Black;
            this.lblBase4.Location = new System.Drawing.Point(13, 87);
            this.lblBase4.Name = "lblBase4";
            this.lblBase4.Size = new System.Drawing.Size(68, 16);
            this.lblBase4.TabIndex = 5;
            this.lblBase4.Text = "Dirección";
            // 
            // lblBase5
            // 
            this.lblBase5.AutoSize = true;
            this.lblBase5.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase5.ForeColor = System.Drawing.Color.Black;
            this.lblBase5.Location = new System.Drawing.Point(13, 109);
            this.lblBase5.Name = "lblBase5";
            this.lblBase5.Size = new System.Drawing.Size(65, 16);
            this.lblBase5.TabIndex = 6;
            this.lblBase5.Text = "Télefono";
            // 
            // Txtnombrecliente
            // 
            this.Txtnombrecliente.BackColor = System.Drawing.SystemColors.Window;
            this.Txtnombrecliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtnombrecliente.Enabled = false;
            this.Txtnombrecliente.Location = new System.Drawing.Point(93, 62);
            this.Txtnombrecliente.Name = "Txtnombrecliente";
            this.Txtnombrecliente.Size = new System.Drawing.Size(465, 23);
            this.Txtnombrecliente.TabIndex = 7;
            // 
            // Txtdireccioncliente
            // 
            this.Txtdireccioncliente.BackColor = System.Drawing.SystemColors.Window;
            this.Txtdireccioncliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtdireccioncliente.Enabled = false;
            this.Txtdireccioncliente.Location = new System.Drawing.Point(93, 84);
            this.Txtdireccioncliente.Name = "Txtdireccioncliente";
            this.Txtdireccioncliente.Size = new System.Drawing.Size(465, 23);
            this.Txtdireccioncliente.TabIndex = 8;
            // 
            // lblBase6
            // 
            this.lblBase6.AutoSize = true;
            this.lblBase6.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase6.ForeColor = System.Drawing.Color.Black;
            this.lblBase6.Location = new System.Drawing.Point(216, 109);
            this.lblBase6.Name = "lblBase6";
            this.lblBase6.Size = new System.Drawing.Size(34, 16);
            this.lblBase6.TabIndex = 9;
            this.lblBase6.Text = "RNC";
            // 
            // Txttelefonocliente
            // 
            this.Txttelefonocliente.Enabled = false;
            this.Txttelefonocliente.Location = new System.Drawing.Point(93, 106);
            this.Txttelefonocliente.Mask = "(000)-000-0000";
            this.Txttelefonocliente.Name = "Txttelefonocliente";
            this.Txttelefonocliente.Size = new System.Drawing.Size(115, 23);
            this.Txttelefonocliente.TabIndex = 11;
            // 
            // Txtrnccliente
            // 
            this.Txtrnccliente.Enabled = false;
            this.Txtrnccliente.Location = new System.Drawing.Point(270, 106);
            this.Txtrnccliente.Mask = "000-0000000-0";
            this.Txtrnccliente.Name = "Txtrnccliente";
            this.Txtrnccliente.Size = new System.Drawing.Size(126, 23);
            this.Txtrnccliente.TabIndex = 12;
            // 
            // Txtbalancecliente
            // 
            this.Txtbalancecliente.BackColor = System.Drawing.SystemColors.Window;
            this.Txtbalancecliente.Enabled = false;
            this.Txtbalancecliente.Location = new System.Drawing.Point(458, 106);
            this.Txtbalancecliente.Name = "Txtbalancecliente";
            this.Txtbalancecliente.Size = new System.Drawing.Size(100, 23);
            this.Txtbalancecliente.TabIndex = 13;
            this.Txtbalancecliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBase8
            // 
            this.lblBase8.AutoSize = true;
            this.lblBase8.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase8.ForeColor = System.Drawing.Color.Black;
            this.lblBase8.Location = new System.Drawing.Point(300, 42);
            this.lblBase8.Name = "lblBase8";
            this.lblBase8.Size = new System.Drawing.Size(48, 16);
            this.lblBase8.TabIndex = 14;
            this.lblBase8.Text = "Fecha";
            // 
            // Dtpfecha
            // 
            this.Dtpfecha.CustomFormat = "dd/MM/yyyy";
            this.Dtpfecha.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtpfecha.Location = new System.Drawing.Point(380, 38);
            this.Dtpfecha.Name = "Dtpfecha";
            this.Dtpfecha.Size = new System.Drawing.Size(115, 23);
            this.Dtpfecha.TabIndex = 15;
            this.Dtpfecha.Validating += new System.ComponentModel.CancelEventHandler(this.Dtpfecha_Validating);
            // 
            // lblBase9
            // 
            this.lblBase9.AutoSize = true;
            this.lblBase9.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase9.ForeColor = System.Drawing.Color.Black;
            this.lblBase9.Location = new System.Drawing.Point(216, 143);
            this.lblBase9.Name = "lblBase9";
            this.lblBase9.Size = new System.Drawing.Size(48, 16);
            this.lblBase9.TabIndex = 16;
            this.lblBase9.Text = "Vence";
            // 
            // Txtreferencia
            // 
            this.Txtreferencia.BackColor = System.Drawing.SystemColors.Window;
            this.Txtreferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtreferencia.Location = new System.Drawing.Point(93, 138);
            this.Txtreferencia.Name = "Txtreferencia";
            this.Txtreferencia.Size = new System.Drawing.Size(116, 23);
            this.Txtreferencia.TabIndex = 3;
            this.Txtreferencia.Validating += new System.ComponentModel.CancelEventHandler(this.Txtreferencia_Validating);
            // 
            // lblBase10
            // 
            this.lblBase10.AutoSize = true;
            this.lblBase10.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase10.ForeColor = System.Drawing.Color.Black;
            this.lblBase10.Location = new System.Drawing.Point(14, 141);
            this.lblBase10.Name = "lblBase10";
            this.lblBase10.Size = new System.Drawing.Size(77, 16);
            this.lblBase10.TabIndex = 18;
            this.lblBase10.Text = "Referencia";
            // 
            // lblBase11
            // 
            this.lblBase11.AutoSize = true;
            this.lblBase11.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase11.ForeColor = System.Drawing.Color.Black;
            this.lblBase11.Location = new System.Drawing.Point(14, 183);
            this.lblBase11.Name = "lblBase11";
            this.lblBase11.Size = new System.Drawing.Size(34, 16);
            this.lblBase11.TabIndex = 20;
            this.lblBase11.Text = "NCF";
            // 
            // Mskncf
            // 
            this.Mskncf.Location = new System.Drawing.Point(93, 176);
            this.Mskncf.Mask = "A0000000000";
            this.Mskncf.Name = "Mskncf";
            this.Mskncf.Size = new System.Drawing.Size(151, 23);
            this.Mskncf.TabIndex = 4;
            // 
            // Txtnombrevendedor
            // 
            this.Txtnombrevendedor.BackColor = System.Drawing.SystemColors.Window;
            this.Txtnombrevendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtnombrevendedor.Enabled = false;
            this.Txtnombrevendedor.Location = new System.Drawing.Point(262, 205);
            this.Txtnombrevendedor.Name = "Txtnombrevendedor";
            this.Txtnombrevendedor.Size = new System.Drawing.Size(297, 23);
            this.Txtnombrevendedor.TabIndex = 25;
            // 
            // Txtcodigovendedor
            // 
            this.Txtcodigovendedor.BackColor = System.Drawing.SystemColors.Window;
            this.Txtcodigovendedor.Location = new System.Drawing.Point(93, 205);
            this.Txtcodigovendedor.Name = "Txtcodigovendedor";
            this.Txtcodigovendedor.Size = new System.Drawing.Size(100, 23);
            this.Txtcodigovendedor.TabIndex = 5;
            this.Txtcodigovendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txtcodigovendedor.TextChanged += new System.EventHandler(this.Txtcodigovendedor_TextChanged);
            this.Txtcodigovendedor.Validating += new System.ComponentModel.CancelEventHandler(this.Txtcodigovendedor_Validating);
            // 
            // lblBase13
            // 
            this.lblBase13.AutoSize = true;
            this.lblBase13.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase13.ForeColor = System.Drawing.Color.Black;
            this.lblBase13.Location = new System.Drawing.Point(13, 208);
            this.lblBase13.Name = "lblBase13";
            this.lblBase13.Size = new System.Drawing.Size(69, 16);
            this.lblBase13.TabIndex = 22;
            this.lblBase13.Text = "Vendedor";
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
            this.dgvorden,
            this.dgvid,
            this.dgvdescripcion,
            this.dgvmonto,
            this.dgvitbis,
            this.dgvtotal,
            this.dgvtasaitbis});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 7.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.Dgv.Location = new System.Drawing.Point(17, 268);
            this.Dgv.MultiSelect = false;
            this.Dgv.Name = "Dgv";
            this.Dgv.RowHeadersVisible = false;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(542, 92);
            this.Dgv.TabIndex = 26;
            this.Dgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellEndEdit);
            // 
            // dgvorden
            // 
            this.dgvorden.DataPropertyName = "orden";
            this.dgvorden.FillWeight = 80F;
            this.dgvorden.HeaderText = "Orden";
            this.dgvorden.MinimumWidth = 80;
            this.dgvorden.Name = "dgvorden";
            this.dgvorden.ReadOnly = true;
            this.dgvorden.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvid
            // 
            this.dgvid.DataPropertyName = "idconcepto";
            this.dgvid.FillWeight = 80F;
            this.dgvid.HeaderText = "Id";
            this.dgvid.MinimumWidth = 80;
            this.dgvid.Name = "dgvid";
            this.dgvid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvid.Visible = false;
            // 
            // dgvdescripcion
            // 
            this.dgvdescripcion.DataPropertyName = "descripcion";
            this.dgvdescripcion.FillWeight = 147F;
            this.dgvdescripcion.HeaderText = "Descripción";
            this.dgvdescripcion.MinimumWidth = 147;
            this.dgvdescripcion.Name = "dgvdescripcion";
            this.dgvdescripcion.ReadOnly = true;
            this.dgvdescripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvmonto
            // 
            this.dgvmonto.DataPropertyName = "precio";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.dgvmonto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvmonto.FillWeight = 90F;
            this.dgvmonto.HeaderText = "Monto";
            this.dgvmonto.MinimumWidth = 90;
            this.dgvmonto.Name = "dgvmonto";
            this.dgvmonto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvmonto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvitbis
            // 
            this.dgvitbis.DataPropertyName = "montoitbis";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.dgvitbis.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvitbis.FillWeight = 90F;
            this.dgvitbis.HeaderText = "Itbis";
            this.dgvitbis.MinimumWidth = 90;
            this.dgvitbis.Name = "dgvitbis";
            this.dgvitbis.ReadOnly = true;
            this.dgvitbis.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvitbis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvtotal
            // 
            this.dgvtotal.DataPropertyName = "montoimporte";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.dgvtotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtotal.FillWeight = 90F;
            this.dgvtotal.HeaderText = "Total";
            this.dgvtotal.MinimumWidth = 90;
            this.dgvtotal.Name = "dgvtotal";
            this.dgvtotal.ReadOnly = true;
            this.dgvtotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvtasaitbis
            // 
            this.dgvtasaitbis.DataPropertyName = "tasa";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.dgvtasaitbis.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvtasaitbis.HeaderText = "tasaitbis";
            this.dgvtasaitbis.Name = "dgvtasaitbis";
            this.dgvtasaitbis.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtasaitbis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvtasaitbis.Visible = false;
            // 
            // Txtdescripcionconcepto
            // 
            this.Txtdescripcionconcepto.BackColor = System.Drawing.SystemColors.Window;
            this.Txtdescripcionconcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtdescripcionconcepto.Location = new System.Drawing.Point(192, 244);
            this.Txtdescripcionconcepto.Name = "Txtdescripcionconcepto";
            this.Txtdescripcionconcepto.Size = new System.Drawing.Size(205, 23);
            this.Txtdescripcionconcepto.TabIndex = 29;
            // 
            // Txtcodigoconcepto
            // 
            this.Txtcodigoconcepto.BackColor = System.Drawing.SystemColors.Window;
            this.Txtcodigoconcepto.Location = new System.Drawing.Point(93, 244);
            this.Txtcodigoconcepto.Name = "Txtcodigoconcepto";
            this.Txtcodigoconcepto.Size = new System.Drawing.Size(49, 23);
            this.Txtcodigoconcepto.TabIndex = 6;
            this.Txtcodigoconcepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txtcodigoconcepto.Validating += new System.ComponentModel.CancelEventHandler(this.Txtcodigoconcepto_Validating);
            // 
            // lblBase12
            // 
            this.lblBase12.AutoSize = true;
            this.lblBase12.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase12.ForeColor = System.Drawing.Color.Black;
            this.lblBase12.Location = new System.Drawing.Point(13, 247);
            this.lblBase12.Name = "lblBase12";
            this.lblBase12.Size = new System.Drawing.Size(71, 16);
            this.lblBase12.TabIndex = 27;
            this.lblBase12.Text = "Concepto";
            // 
            // Txtmontogravado
            // 
            this.Txtmontogravado.BackColor = System.Drawing.SystemColors.Window;
            this.Txtmontogravado.Location = new System.Drawing.Point(406, 244);
            this.Txtmontogravado.Name = "Txtmontogravado";
            this.Txtmontogravado.Size = new System.Drawing.Size(100, 23);
            this.Txtmontogravado.TabIndex = 7;
            this.Txtmontogravado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnAgregarConcepto
            // 
            this.BtnAgregarConcepto.Location = new System.Drawing.Point(512, 244);
            this.BtnAgregarConcepto.Name = "BtnAgregarConcepto";
            this.BtnAgregarConcepto.Size = new System.Drawing.Size(47, 23);
            this.BtnAgregarConcepto.TabIndex = 8;
            this.BtnAgregarConcepto.Text = "button1";
            this.BtnAgregarConcepto.UseVisualStyleBackColor = true;
            this.BtnAgregarConcepto.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBase7
            // 
            this.lblBase7.AutoSize = true;
            this.lblBase7.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase7.ForeColor = System.Drawing.Color.Black;
            this.lblBase7.Location = new System.Drawing.Point(402, 109);
            this.lblBase7.Name = "lblBase7";
            this.lblBase7.Size = new System.Drawing.Size(59, 16);
            this.lblBase7.TabIndex = 10;
            this.lblBase7.Text = "Balance";
            // 
            // Txtexcento
            // 
            this.Txtexcento.BackColor = System.Drawing.SystemColors.Window;
            this.Txtexcento.Enabled = false;
            this.Txtexcento.Location = new System.Drawing.Point(16, 431);
            this.Txtexcento.Name = "Txtexcento";
            this.Txtexcento.Size = new System.Drawing.Size(100, 23);
            this.Txtexcento.TabIndex = 33;
            this.Txtexcento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBase14
            // 
            this.lblBase14.AutoSize = true;
            this.lblBase14.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase14.ForeColor = System.Drawing.Color.Black;
            this.lblBase14.Location = new System.Drawing.Point(13, 408);
            this.lblBase14.Name = "lblBase14";
            this.lblBase14.Size = new System.Drawing.Size(61, 16);
            this.lblBase14.TabIndex = 32;
            this.lblBase14.Text = "Excento";
            // 
            // Txtgravado18
            // 
            this.Txtgravado18.BackColor = System.Drawing.SystemColors.Window;
            this.Txtgravado18.Enabled = false;
            this.Txtgravado18.Location = new System.Drawing.Point(126, 431);
            this.Txtgravado18.Name = "Txtgravado18";
            this.Txtgravado18.Size = new System.Drawing.Size(100, 23);
            this.Txtgravado18.TabIndex = 35;
            this.Txtgravado18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBase15
            // 
            this.lblBase15.AutoSize = true;
            this.lblBase15.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase15.ForeColor = System.Drawing.Color.Black;
            this.lblBase15.Location = new System.Drawing.Point(343, 408);
            this.lblBase15.Name = "lblBase15";
            this.lblBase15.Size = new System.Drawing.Size(37, 16);
            this.lblBase15.TabIndex = 34;
            this.lblBase15.Text = "Itbis";
            // 
            // Txtcomentrio
            // 
            this.Txtcomentrio.BackColor = System.Drawing.SystemColors.Window;
            this.Txtcomentrio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtcomentrio.Location = new System.Drawing.Point(19, 492);
            this.Txtcomentrio.Multiline = true;
            this.Txtcomentrio.Name = "Txtcomentrio";
            this.Txtcomentrio.Size = new System.Drawing.Size(540, 34);
            this.Txtcomentrio.TabIndex = 37;
            // 
            // lblBase16
            // 
            this.lblBase16.AutoSize = true;
            this.lblBase16.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase16.ForeColor = System.Drawing.Color.Black;
            this.lblBase16.Location = new System.Drawing.Point(16, 473);
            this.lblBase16.Name = "lblBase16";
            this.lblBase16.Size = new System.Drawing.Size(82, 16);
            this.lblBase16.TabIndex = 36;
            this.lblBase16.Text = "Comentario";
            // 
            // lblBase17
            // 
            this.lblBase17.AutoSize = true;
            this.lblBase17.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase17.ForeColor = System.Drawing.Color.Black;
            this.lblBase17.Location = new System.Drawing.Point(402, 143);
            this.lblBase17.Name = "lblBase17";
            this.lblBase17.Size = new System.Drawing.Size(59, 16);
            this.lblBase17.TabIndex = 38;
            this.lblBase17.Text = "Moneda";
            // 
            // Cmbmoneda
            // 
            this.Cmbmoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmbmoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbmoneda.FormattingEnabled = true;
            this.Cmbmoneda.Location = new System.Drawing.Point(459, 135);
            this.Cmbmoneda.Name = "Cmbmoneda";
            this.Cmbmoneda.ReadOnly = false;
            this.Cmbmoneda.Size = new System.Drawing.Size(99, 24);
            this.Cmbmoneda.TabIndex = 39;
            this.Cmbmoneda.TabStop = false;
            this.toolTip1.SetToolTip(this.Cmbmoneda, "Selecione Tipo de Moneda");
            // 
            // BtnBuscarConcepto
            // 
            this.BtnBuscarConcepto.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnBuscarConcepto.FlatAppearance.BorderSize = 0;
            this.BtnBuscarConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarConcepto.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarConcepto.Image")));
            this.BtnBuscarConcepto.Location = new System.Drawing.Point(145, 244);
            this.BtnBuscarConcepto.Name = "BtnBuscarConcepto";
            this.BtnBuscarConcepto.Size = new System.Drawing.Size(24, 24);
            this.BtnBuscarConcepto.TabIndex = 43;
            this.BtnBuscarConcepto.TabStop = false;
            this.BtnBuscarConcepto.Text = " ";
            this.toolTip1.SetToolTip(this.BtnBuscarConcepto, "Buscar concepto");
            this.BtnBuscarConcepto.UseVisualStyleBackColor = false;
            this.BtnBuscarConcepto.Click += new System.EventHandler(this.BtnBuscarConcepto_Click);
            // 
            // Dtpfechavencimiento
            // 
            this.Dtpfechavencimiento.CustomFormat = "dd/MM/yyyy";
            this.Dtpfechavencimiento.Enabled = false;
            this.Dtpfechavencimiento.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Dtpfechavencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtpfechavencimiento.Location = new System.Drawing.Point(270, 136);
            this.Dtpfechavencimiento.Name = "Dtpfechavencimiento";
            this.Dtpfechavencimiento.Size = new System.Drawing.Size(126, 23);
            this.Dtpfechavencimiento.TabIndex = 44;
            // 
            // Txtitbis
            // 
            this.Txtitbis.BackColor = System.Drawing.SystemColors.Window;
            this.Txtitbis.Enabled = false;
            this.Txtitbis.Location = new System.Drawing.Point(346, 431);
            this.Txtitbis.Name = "Txtitbis";
            this.Txtitbis.Size = new System.Drawing.Size(100, 23);
            this.Txtitbis.TabIndex = 48;
            this.Txtitbis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBase18
            // 
            this.lblBase18.AutoSize = true;
            this.lblBase18.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase18.ForeColor = System.Drawing.Color.Black;
            this.lblBase18.Location = new System.Drawing.Point(123, 408);
            this.lblBase18.Name = "lblBase18";
            this.lblBase18.Size = new System.Drawing.Size(96, 16);
            this.lblBase18.TabIndex = 47;
            this.lblBase18.Text = "Gravado 18%";
            // 
            // Txtgravado16
            // 
            this.Txtgravado16.BackColor = System.Drawing.SystemColors.Window;
            this.Txtgravado16.Enabled = false;
            this.Txtgravado16.Location = new System.Drawing.Point(235, 431);
            this.Txtgravado16.Name = "Txtgravado16";
            this.Txtgravado16.Size = new System.Drawing.Size(100, 23);
            this.Txtgravado16.TabIndex = 46;
            this.Txtgravado16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBase19
            // 
            this.lblBase19.AutoSize = true;
            this.lblBase19.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase19.ForeColor = System.Drawing.Color.Black;
            this.lblBase19.Location = new System.Drawing.Point(232, 408);
            this.lblBase19.Name = "lblBase19";
            this.lblBase19.Size = new System.Drawing.Size(96, 16);
            this.lblBase19.TabIndex = 45;
            this.lblBase19.Text = "Gravado 16%";
            // 
            // Txttotal
            // 
            this.Txttotal.BackColor = System.Drawing.Color.Khaki;
            this.Txttotal.Enabled = false;
            this.Txttotal.Location = new System.Drawing.Point(457, 431);
            this.Txttotal.Name = "Txttotal";
            this.Txttotal.Size = new System.Drawing.Size(100, 23);
            this.Txttotal.TabIndex = 50;
            this.Txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBase20
            // 
            this.lblBase20.AutoSize = true;
            this.lblBase20.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase20.ForeColor = System.Drawing.Color.Black;
            this.lblBase20.Location = new System.Drawing.Point(454, 408);
            this.lblBase20.Name = "lblBase20";
            this.lblBase20.Size = new System.Drawing.Size(41, 16);
            this.lblBase20.TabIndex = 49;
            this.lblBase20.Text = "Total";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 51;
            this.button1.TabStop = false;
            this.button1.Text = "Quitar Concepto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Ckbimprimir
            // 
            this.Ckbimprimir.AutoSize = true;
            this.Ckbimprimir.Checked = true;
            this.Ckbimprimir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Ckbimprimir.Location = new System.Drawing.Point(481, 530);
            this.Ckbimprimir.Name = "Ckbimprimir";
            this.Ckbimprimir.Size = new System.Drawing.Size(78, 20);
            this.Ckbimprimir.TabIndex = 220;
            this.Ckbimprimir.TabStop = false;
            this.Ckbimprimir.Text = "Imprimir";
            this.Ckbimprimir.UseVisualStyleBackColor = true;
            // 
            // BtnBuscarVendedor
            // 
            this.BtnBuscarVendedor.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnBuscarVendedor.FlatAppearance.BorderSize = 0;
            this.BtnBuscarVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarVendedor.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarVendedor.Image")));
            this.BtnBuscarVendedor.Location = new System.Drawing.Point(209, 205);
            this.BtnBuscarVendedor.Name = "BtnBuscarVendedor";
            this.BtnBuscarVendedor.Size = new System.Drawing.Size(24, 24);
            this.BtnBuscarVendedor.TabIndex = 42;
            this.BtnBuscarVendedor.TabStop = false;
            this.BtnBuscarVendedor.Text = " ";
            this.toolTip1.SetToolTip(this.BtnBuscarVendedor, "Buscar Vendedor");
            this.BtnBuscarVendedor.UseVisualStyleBackColor = false;
            this.BtnBuscarVendedor.Click += new System.EventHandler(this.BtnBuscarVendedor_Click_1);
            // 
            // BtnBuscarRegistro
            // 
            this.BtnBuscarRegistro.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnBuscarRegistro.FlatAppearance.BorderSize = 0;
            this.BtnBuscarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarRegistro.Image")));
            this.BtnBuscarRegistro.Location = new System.Drawing.Point(209, 11);
            this.BtnBuscarRegistro.Name = "BtnBuscarRegistro";
            this.BtnBuscarRegistro.Size = new System.Drawing.Size(24, 24);
            this.BtnBuscarRegistro.TabIndex = 40;
            this.BtnBuscarRegistro.TabStop = false;
            this.BtnBuscarRegistro.Text = " ";
            this.toolTip1.SetToolTip(this.BtnBuscarRegistro, "Buscar Factura");
            this.BtnBuscarRegistro.UseVisualStyleBackColor = false;
            this.BtnBuscarRegistro.Visible = false;
            this.BtnBuscarRegistro.Click += new System.EventHandler(this.BtnBuscarRegistro_Click);
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.BtnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarCliente.Image")));
            this.BtnBuscarCliente.Location = new System.Drawing.Point(209, 39);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(24, 24);
            this.BtnBuscarCliente.TabIndex = 41;
            this.BtnBuscarCliente.TabStop = false;
            this.BtnBuscarCliente.Text = " ";
            this.toolTip1.SetToolTip(this.BtnBuscarCliente, "Buscar cliente");
            this.BtnBuscarCliente.UseVisualStyleBackColor = false;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // cxcproregistro
            // 
            this.ClientSize = new System.Drawing.Size(590, 705);
            this.Name = "cxcproregistro";
            this.Load += new System.EventHandler(this.cxcproregistro_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Logistica.MskTelefono Txttelefonocliente;
        private Logistica.LblBase lblBase6;
        private Logistica.TxtMayuscula Txtdireccioncliente;
        private Logistica.TxtMayuscula Txtnombrecliente;
        private Logistica.LblBase lblBase5;
        private Logistica.LblBase lblBase4;
        private Logistica.LblBase lblBase3;
        private Logistica.TxtEntero Txtcodigocliente;
        private Logistica.LblBase lblBase2;
        private Logistica.TxtMayuscula Txtregistro;
        private Logistica.LblBase lblBase1;
        private Logistica.TxtDecimal Txtbalancecliente;
        private Logistica.MskRncCedula Txtrnccliente;
        private Logistica.TxtDecimal Txtmontogravado;
        private Logistica.TxtMayuscula Txtdescripcionconcepto;
        private Logistica.TxtEntero Txtcodigoconcepto;
        private Logistica.LblBase lblBase12;
        private Logistica.GridBase Dgv;
        private Logistica.TxtMayuscula Txtnombrevendedor;
        private Logistica.TxtEntero Txtcodigovendedor;
        private Logistica.LblBase lblBase13;
        private Logistica.MskNCF Mskncf;
        private Logistica.LblBase lblBase11;
        private Logistica.TxtMayuscula Txtreferencia;
        private Logistica.LblBase lblBase10;
        private Logistica.LblBase lblBase9;
        private Logistica.DtpBase Dtpfecha;
        private Logistica.LblBase lblBase8;
        private System.Windows.Forms.Button BtnAgregarConcepto;
        private Logistica.TxtMayuscula Txtcomentrio;
        private Logistica.LblBase lblBase16;
        private Logistica.TxtDecimal Txtgravado18;
        private Logistica.LblBase lblBase15;
        private Logistica.TxtDecimal Txtexcento;
        private Logistica.LblBase lblBase14;
        private Logistica.LblBase lblBase7;
        private Logistica.CmbBase Cmbmoneda;
        private Logistica.LblBase lblBase17;
        private Duke4.Logistica.BtnBuscar BtnBuscarConcepto;
        private Logistica.DtpBase Dtpfechavencimiento;
        private Logistica.TxtDecimal Txttotal;
        private Logistica.LblBase lblBase20;
        private Logistica.TxtDecimal Txtitbis;
        private Logistica.LblBase lblBase18;
        private Logistica.TxtDecimal Txtgravado16;
        private Logistica.LblBase lblBase19;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvorden;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdescripcion;
        private Logistica.GridBase.DoubleColumn dgvmonto;
        private Logistica.GridBase.DoubleColumn dgvitbis;
        private Logistica.GridBase.DoubleColumn dgvtotal;
        private Logistica.GridBase.DoubleColumn dgvtasaitbis;
        public Logistica.CkbBase Ckbimprimir;
        private Logistica.BtnBuscar BtnBuscarVendedor;
        private Logistica.BtnBuscar BtnBuscarCliente;
        private Logistica.BtnBuscar BtnBuscarRegistro;
    }
}
