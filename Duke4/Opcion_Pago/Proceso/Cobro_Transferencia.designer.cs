namespace Duke4.Opcion_Pago.Proceso
{
    partial class Cobro_Transferencia
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
            this.TxtMonto = new Logistica.TxtDecimal();
            this.Txtdocumento = new Logistica.TxtEntero();
            this.CbBanco = new Logistica.CmbBase();
            this.LblBase3 = new Logistica.LblBase();
            this.LblBase2 = new Logistica.LblBase();
            this.LblBase1 = new Logistica.LblBase();
            this.SuspendLayout();
            // 
            // TxtMonto
            // 
            this.TxtMonto.Location = new System.Drawing.Point(126, 71);
            this.TxtMonto.MaxLength = 14;
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(107, 23);
            this.TxtMonto.TabIndex = 3;
            this.TxtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Txtdocumento
            // 
            this.Txtdocumento.Location = new System.Drawing.Point(126, 42);
            this.Txtdocumento.MaxLength = 9;
            this.Txtdocumento.Name = "Txtdocumento";
            this.Txtdocumento.Size = new System.Drawing.Size(107, 23);
            this.Txtdocumento.TabIndex = 2;
            this.Txtdocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CbBanco
            // 
            this.CbBanco.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbBanco.FormattingEnabled = true;
            this.CbBanco.Location = new System.Drawing.Point(126, 12);
            this.CbBanco.Name = "CbBanco";
            this.CbBanco.ReadOnly = false;
            this.CbBanco.Size = new System.Drawing.Size(204, 24);
            this.CbBanco.TabIndex = 1;
            // 
            // LblBase3
            // 
            this.LblBase3.AutoSize = true;
            this.LblBase3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.LblBase3.Location = new System.Drawing.Point(4, 74);
            this.LblBase3.Name = "LblBase3";
            this.LblBase3.Size = new System.Drawing.Size(49, 16);
            this.LblBase3.TabIndex = 26;
            this.LblBase3.Text = "Monto";
            // 
            // LblBase2
            // 
            this.LblBase2.AutoSize = true;
            this.LblBase2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.LblBase2.Location = new System.Drawing.Point(4, 45);
            this.LblBase2.Name = "LblBase2";
            this.LblBase2.Size = new System.Drawing.Size(109, 16);
            this.LblBase2.TabIndex = 25;
            this.LblBase2.Text = "No. Documento";
            // 
            // LblBase1
            // 
            this.LblBase1.AutoSize = true;
            this.LblBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.LblBase1.Location = new System.Drawing.Point(4, 15);
            this.LblBase1.Name = "LblBase1";
            this.LblBase1.Size = new System.Drawing.Size(48, 16);
            this.LblBase1.TabIndex = 24;
            this.LblBase1.Text = "Banco";
            // 
            // CobroPorTransferencia
            // 
            this.ClientSize = new System.Drawing.Size(579, 121);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.Txtdocumento);
            this.Controls.Add(this.CbBanco);
            this.Controls.Add(this.LblBase3);
            this.Controls.Add(this.LblBase2);
            this.Controls.Add(this.LblBase1);
            this.Name = "CobroPorTransferencia";
            this.Load += new System.EventHandler(this.CobroPorTransferencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Logistica.TxtDecimal TxtMonto;
        public Logistica.TxtEntero Txtdocumento;
        public Logistica.CmbBase CbBanco;
        private Logistica.LblBase LblBase3;
        private Logistica.LblBase LblBase2;
        private Logistica.LblBase LblBase1;
    }
}
