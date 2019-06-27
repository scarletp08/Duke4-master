namespace Duke4._newDesign
{
    partial class _conModify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_conModify));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BtnCrear = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBase1 = new Duke4.Logistica.LblBase();
            this.lblBase2 = new Duke4.Logistica.LblBase();
            this.lblBase3 = new Duke4.Logistica.LblBase();
            this.lblBase4 = new Duke4.Logistica.LblBase();
            this.dtpBase1 = new Duke4.Logistica.DtpBase();
            this.txtreferencia = new Duke4.Logistica.TxtMayuscula();
            this.Txtnombre = new Duke4.Logistica.TxtMayuscula();
            this.BtnBuscarCliente = new Duke4.Logistica.BtnBuscar();
            this.TxtCodigo = new Duke4.Logistica.TxtEntero();
            this.txtNota = new Duke4.Logistica.TxtNota();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCrear,
            this.BtnCancelar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 39);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(758, 57);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BtnCrear
            // 
            this.BtnCrear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrear.Image = global::Duke4.Properties.Resources.resume;
            this.BtnCrear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCrear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnCrear.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.BtnCrear.Size = new System.Drawing.Size(111, 50);
            this.BtnCrear.Text = "Modificar [F3]";
            this.BtnCrear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = global::Duke4.Properties.Resources.retornar32;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(114, 50);
            this.BtnCancelar.Text = "Retornar [Esc]";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // lblBase1
            // 
            this.lblBase1.AutoSize = true;
            this.lblBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase1.ForeColor = System.Drawing.Color.Black;
            this.lblBase1.Location = new System.Drawing.Point(38, 129);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(48, 16);
            this.lblBase1.TabIndex = 13;
            this.lblBase1.Text = "Fecha";
            // 
            // lblBase2
            // 
            this.lblBase2.AutoSize = true;
            this.lblBase2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase2.ForeColor = System.Drawing.Color.Black;
            this.lblBase2.Location = new System.Drawing.Point(38, 156);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(77, 16);
            this.lblBase2.TabIndex = 14;
            this.lblBase2.Text = "Referencia";
            // 
            // lblBase3
            // 
            this.lblBase3.AutoSize = true;
            this.lblBase3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase3.ForeColor = System.Drawing.Color.Black;
            this.lblBase3.Location = new System.Drawing.Point(38, 187);
            this.lblBase3.Name = "lblBase3";
            this.lblBase3.Size = new System.Drawing.Size(69, 16);
            this.lblBase3.TabIndex = 15;
            this.lblBase3.Text = "Vendedor";
            // 
            // lblBase4
            // 
            this.lblBase4.AutoSize = true;
            this.lblBase4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase4.ForeColor = System.Drawing.Color.Black;
            this.lblBase4.Location = new System.Drawing.Point(38, 217);
            this.lblBase4.Name = "lblBase4";
            this.lblBase4.Size = new System.Drawing.Size(82, 16);
            this.lblBase4.TabIndex = 16;
            this.lblBase4.Text = "Comentario";
            // 
            // dtpBase1
            // 
            this.dtpBase1.CustomFormat = "dd/MM/yyyy";
            this.dtpBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.dtpBase1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBase1.Location = new System.Drawing.Point(125, 124);
            this.dtpBase1.Name = "dtpBase1";
            this.dtpBase1.Size = new System.Drawing.Size(112, 23);
            this.dtpBase1.TabIndex = 17;
            // 
            // txtreferencia
            // 
            this.txtreferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtreferencia.Location = new System.Drawing.Point(125, 153);
            this.txtreferencia.Name = "txtreferencia";
            this.txtreferencia.Size = new System.Drawing.Size(202, 23);
            this.txtreferencia.TabIndex = 18;
            // 
            // Txtnombre
            // 
            this.Txtnombre.BackColor = System.Drawing.SystemColors.Window;
            this.Txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtnombre.Enabled = false;
            this.Txtnombre.Location = new System.Drawing.Point(224, 178);
            this.Txtnombre.Name = "Txtnombre";
            this.Txtnombre.ReadOnly = true;
            this.Txtnombre.Size = new System.Drawing.Size(281, 23);
            this.Txtnombre.TabIndex = 386;
            this.Txtnombre.TabStop = false;
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.BtnBuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarCliente.Image")));
            this.BtnBuscarCliente.Location = new System.Drawing.Point(194, 177);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(24, 24);
            this.BtnBuscarCliente.TabIndex = 385;
            this.BtnBuscarCliente.TabStop = false;
            this.BtnBuscarCliente.Text = " ";
            this.BtnBuscarCliente.UseVisualStyleBackColor = false;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCodigo.Location = new System.Drawing.Point(126, 178);
            this.TxtCodigo.MaxLength = 9;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(64, 23);
            this.TxtCodigo.TabIndex = 384;
            this.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodigo_Validating);
            // 
            // txtNota
            // 
            this.txtNota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNota.Location = new System.Drawing.Point(41, 236);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNota.Size = new System.Drawing.Size(464, 105);
            this.txtNota.TabIndex = 387;
            // 
            // _conModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 399);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.Txtnombre);
            this.Controls.Add(this.BtnBuscarCliente);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.txtreferencia);
            this.Controls.Add(this.dtpBase1);
            this.Controls.Add(this.lblBase4);
            this.Controls.Add(this.lblBase3);
            this.Controls.Add(this.lblBase2);
            this.Controls.Add(this.lblBase1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_conModify";
            this.Text = "_conModify";
            this.Load += new System.EventHandler(this._conModify_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.lblBase1, 0);
            this.Controls.SetChildIndex(this.lblBase2, 0);
            this.Controls.SetChildIndex(this.lblBase3, 0);
            this.Controls.SetChildIndex(this.lblBase4, 0);
            this.Controls.SetChildIndex(this.dtpBase1, 0);
            this.Controls.SetChildIndex(this.txtreferencia, 0);
            this.Controls.SetChildIndex(this.TxtCodigo, 0);
            this.Controls.SetChildIndex(this.BtnBuscarCliente, 0);
            this.Controls.SetChildIndex(this.Txtnombre, 0);
            this.Controls.SetChildIndex(this.txtNota, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem BtnCrear;
        public System.Windows.Forms.ToolStripMenuItem BtnCancelar;
        private Logistica.LblBase lblBase1;
        private Logistica.LblBase lblBase2;
        private Logistica.LblBase lblBase3;
        private Logistica.LblBase lblBase4;
        private Logistica.DtpBase dtpBase1;
        private Logistica.TxtMayuscula txtreferencia;
        public Logistica.TxtMayuscula Txtnombre;
        public Logistica.BtnBuscar BtnBuscarCliente;
        public Logistica.TxtEntero TxtCodigo;
        private Logistica.TxtNota txtNota;
    }
}