namespace Duke4._newDesign
{
    partial class _codificar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.BtnSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnQuitar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRetornar = new System.Windows.Forms.ToolStripMenuItem();
            this.MainGrid = new Duke4.Logistica.GridNoArrow();
            this.nocuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debito = new Duke4.Logistica.GridBase.DoubleColumn();
            this.credito = new Duke4.Logistica.GridBase.DoubleColumn();
            this.lblBase1 = new Duke4.Logistica.LblBase();
            this.cmbBase1 = new Duke4.Logistica.CmbBase();
            this.ckbBase1 = new Duke4.Logistica.CkbBase();
            this.lblNegrita1 = new Duke4.Logistica.LblNegrita();
            this.TxtDebito = new Duke4.Logistica.TxtDecimal();
            this.TxtCredito = new Duke4.Logistica.TxtDecimal();
            this.TxtCreditoM = new Duke4.Logistica.TxtDecimal();
            this.TxtDebitoM = new Duke4.Logistica.TxtDecimal();
            this.LstCuenta = new Duke4.Logistica.LstBase();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.AllowMerge = false;
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSalvar,
            this.BtnBuscar,
            this.BtnQuitar,
            this.BtnRetornar});
            this.menuStrip2.Location = new System.Drawing.Point(0, 39);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip2.Size = new System.Drawing.Size(1210, 62);
            this.menuStrip2.TabIndex = 75;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Image = global::Duke4.Properties.Resources.crear32;
            this.BtnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.BtnSalvar.Size = new System.Drawing.Size(93, 55);
            this.BtnSalvar.Text = "Salvar [F5]";
            this.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Image = global::Duke4.Properties.Resources.modificar32;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.BtnBuscar.Size = new System.Drawing.Size(144, 55);
            this.BtnBuscar.Text = "Buscar Cuenta [F6]";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnQuitar
            // 
            this.BtnQuitar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitar.Image = global::Duke4.Properties.Resources.salbar32;
            this.BtnQuitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnQuitar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnQuitar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.BtnQuitar.Size = new System.Drawing.Size(140, 55);
            this.BtnQuitar.Text = "Quitar Cuenta [F3]";
            this.BtnQuitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // BtnRetornar
            // 
            this.BtnRetornar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetornar.Image = global::Duke4.Properties.Resources.retornar32;
            this.BtnRetornar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRetornar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnRetornar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnRetornar.Name = "BtnRetornar";
            this.BtnRetornar.Size = new System.Drawing.Size(114, 55);
            this.BtnRetornar.Text = "Retornar [Esc]";
            this.BtnRetornar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRetornar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnRetornar.Click += new System.EventHandler(this.BtnRetornar_Click);
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
            this.nocuenta,
            this.descripcion,
            this.debito,
            this.credito});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 7.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.MainGrid.Location = new System.Drawing.Point(12, 139);
            this.MainGrid.MultiSelect = false;
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.RowHeadersVisible = false;
            this.MainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainGrid.Size = new System.Drawing.Size(633, 216);
            this.MainGrid.TabIndex = 76;
            this.MainGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGrid_CellEndEdit);
            this.MainGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainGrid_KeyDown);
            // 
            // nocuenta
            // 
            this.nocuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nocuenta.DataPropertyName = "codcuenta";
            this.nocuenta.FillWeight = 50F;
            this.nocuenta.HeaderText = "Cuenta";
            this.nocuenta.Name = "nocuenta";
            this.nocuenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.FillWeight = 150F;
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // debito
            // 
            this.debito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.debito.DataPropertyName = "montodebito";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.debito.DefaultCellStyle = dataGridViewCellStyle2;
            this.debito.FillWeight = 70F;
            this.debito.HeaderText = "Débito";
            this.debito.Name = "debito";
            this.debito.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // credito
            // 
            this.credito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.credito.DataPropertyName = "montocredito";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.credito.DefaultCellStyle = dataGridViewCellStyle3;
            this.credito.FillWeight = 70F;
            this.credito.HeaderText = "Crédito";
            this.credito.Name = "credito";
            this.credito.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // lblBase1
            // 
            this.lblBase1.AutoSize = true;
            this.lblBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase1.ForeColor = System.Drawing.Color.Black;
            this.lblBase1.Location = new System.Drawing.Point(26, 113);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(36, 16);
            this.lblBase1.TabIndex = 77;
            this.lblBase1.Text = "Tipo";
            // 
            // cmbBase1
            // 
            this.cmbBase1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBase1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBase1.FormattingEnabled = true;
            this.cmbBase1.Location = new System.Drawing.Point(104, 110);
            this.cmbBase1.Name = "cmbBase1";
            this.cmbBase1.ReadOnly = false;
            this.cmbBase1.Size = new System.Drawing.Size(270, 24);
            this.cmbBase1.TabIndex = 78;
            // 
            // ckbBase1
            // 
            this.ckbBase1.AutoSize = true;
            this.ckbBase1.Location = new System.Drawing.Point(473, 112);
            this.ckbBase1.Name = "ckbBase1";
            this.ckbBase1.Size = new System.Drawing.Size(162, 20);
            this.ckbBase1.TabIndex = 79;
            this.ckbBase1.TabStop = false;
            this.ckbBase1.Text = "[F2] Auto Completar";
            this.ckbBase1.UseVisualStyleBackColor = true;
            // 
            // lblNegrita1
            // 
            this.lblNegrita1.AutoSize = true;
            this.lblNegrita1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNegrita1.ForeColor = System.Drawing.Color.Black;
            this.lblNegrita1.Location = new System.Drawing.Point(26, 367);
            this.lblNegrita1.Name = "lblNegrita1";
            this.lblNegrita1.Size = new System.Drawing.Size(87, 16);
            this.lblNegrita1.TabIndex = 80;
            this.lblNegrita1.Text = "lblNegrita1";
            this.lblNegrita1.Visible = false;
            // 
            // TxtDebito
            // 
            this.TxtDebito.Location = new System.Drawing.Point(369, 360);
            this.TxtDebito.Name = "TxtDebito";
            this.TxtDebito.Size = new System.Drawing.Size(135, 23);
            this.TxtDebito.TabIndex = 81;
            this.TxtDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtCredito
            // 
            this.TxtCredito.Location = new System.Drawing.Point(510, 360);
            this.TxtCredito.Name = "TxtCredito";
            this.TxtCredito.Size = new System.Drawing.Size(135, 23);
            this.TxtCredito.TabIndex = 82;
            this.TxtCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtCreditoM
            // 
            this.TxtCreditoM.Location = new System.Drawing.Point(509, 386);
            this.TxtCreditoM.Name = "TxtCreditoM";
            this.TxtCreditoM.Size = new System.Drawing.Size(135, 23);
            this.TxtCreditoM.TabIndex = 84;
            this.TxtCreditoM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtDebitoM
            // 
            this.TxtDebitoM.Location = new System.Drawing.Point(368, 386);
            this.TxtDebitoM.Name = "TxtDebitoM";
            this.TxtDebitoM.Size = new System.Drawing.Size(135, 23);
            this.TxtDebitoM.TabIndex = 83;
            this.TxtDebitoM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LstCuenta
            // 
            this.LstCuenta.FullRowSelect = true;
            this.LstCuenta.GridLines = true;
            this.LstCuenta.Location = new System.Drawing.Point(12, 182);
            this.LstCuenta.Name = "LstCuenta";
            this.LstCuenta.Size = new System.Drawing.Size(286, 96);
            this.LstCuenta.TabIndex = 85;
            this.LstCuenta.UseCompatibleStateImageBehavior = false;
            this.LstCuenta.View = System.Windows.Forms.View.Details;
            this.LstCuenta.DoubleClick += new System.EventHandler(this.LstCuenta_DoubleClick);
            this.LstCuenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstCuenta_KeyDown);
            // 
            // _codificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 430);
            this.Controls.Add(this.LstCuenta);
            this.Controls.Add(this.TxtCreditoM);
            this.Controls.Add(this.TxtDebitoM);
            this.Controls.Add(this.TxtCredito);
            this.Controls.Add(this.TxtDebito);
            this.Controls.Add(this.lblNegrita1);
            this.Controls.Add(this.ckbBase1);
            this.Controls.Add(this.cmbBase1);
            this.Controls.Add(this.lblBase1);
            this.Controls.Add(this.MainGrid);
            this.Controls.Add(this.menuStrip2);
            this.Name = "_codificar";
            this.Text = "_codificar";
            this.Load += new System.EventHandler(this._codificar_Load);
            this.Controls.SetChildIndex(this.menuStrip2, 0);
            this.Controls.SetChildIndex(this.MainGrid, 0);
            this.Controls.SetChildIndex(this.lblBase1, 0);
            this.Controls.SetChildIndex(this.cmbBase1, 0);
            this.Controls.SetChildIndex(this.ckbBase1, 0);
            this.Controls.SetChildIndex(this.lblNegrita1, 0);
            this.Controls.SetChildIndex(this.TxtDebito, 0);
            this.Controls.SetChildIndex(this.TxtCredito, 0);
            this.Controls.SetChildIndex(this.TxtDebitoM, 0);
            this.Controls.SetChildIndex(this.TxtCreditoM, 0);
            this.Controls.SetChildIndex(this.LstCuenta, 0);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip2;
        public System.Windows.Forms.ToolStripMenuItem BtnSalvar;
        public System.Windows.Forms.ToolStripMenuItem BtnBuscar;
        public System.Windows.Forms.ToolStripMenuItem BtnQuitar;
        public System.Windows.Forms.ToolStripMenuItem BtnRetornar;
        private Logistica.CmbBase cmbBase1;
        private Logistica.CkbBase ckbBase1;
        private Logistica.LblNegrita lblNegrita1;
        private Logistica.TxtDecimal TxtDebito;
        private Logistica.TxtDecimal TxtCredito;
        private Logistica.TxtDecimal TxtCreditoM;
        private Logistica.TxtDecimal TxtDebitoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn nocuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private Logistica.GridBase.DoubleColumn debito;
        private Logistica.GridBase.DoubleColumn credito;
        private Logistica.LstBase LstCuenta;
        public Logistica.GridNoArrow MainGrid;
        private Logistica.LblBase lblBase1;
    }
}