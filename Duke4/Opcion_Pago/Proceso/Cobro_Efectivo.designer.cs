namespace Duke4.Opcion_Pago.Proceso
{
    partial class Cobro_Efectivo
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
            this.Txtpago = new Logistica.TxtDecimal();
            this.LblBase1 = new Logistica.LblBase();
            this.LblBase4 = new Logistica.LblBase();
            this.LblBase2 = new Logistica.LblBase();
            this.Txtcambio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtMonto
            // 
            this.TxtMonto.Location = new System.Drawing.Point(126, 12);
            this.TxtMonto.MaxLength = 14;
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(138, 23);
            this.TxtMonto.TabIndex = 1;
            this.TxtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Txtpago
            // 
            this.Txtpago.Location = new System.Drawing.Point(125, 41);
            this.Txtpago.MaxLength = 14;
            this.Txtpago.Name = "Txtpago";
            this.Txtpago.Size = new System.Drawing.Size(138, 23);
            this.Txtpago.TabIndex = 2;
            this.Txtpago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txtpago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpago_KeyPress);
            // 
            // LblBase1
            // 
            this.LblBase1.AutoSize = true;
            this.LblBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.LblBase1.Location = new System.Drawing.Point(4, 44);
            this.LblBase1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBase1.Name = "LblBase1";
            this.LblBase1.Size = new System.Drawing.Size(69, 16);
            this.LblBase1.TabIndex = 17;
            this.LblBase1.Text = "Pagó con";
            // 
            // LblBase4
            // 
            this.LblBase4.AutoSize = true;
            this.LblBase4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.LblBase4.Location = new System.Drawing.Point(4, 15);
            this.LblBase4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBase4.Name = "LblBase4";
            this.LblBase4.Size = new System.Drawing.Size(49, 16);
            this.LblBase4.TabIndex = 15;
            this.LblBase4.Text = "Monto";
            // 
            // LblBase2
            // 
            this.LblBase2.AutoSize = true;
            this.LblBase2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.LblBase2.Location = new System.Drawing.Point(4, 75);
            this.LblBase2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBase2.Name = "LblBase2";
            this.LblBase2.Size = new System.Drawing.Size(96, 16);
            this.LblBase2.TabIndex = 19;
            this.LblBase2.Text = "Su cambio es";
            // 
            // Txtcambio
            // 
            this.Txtcambio.AutoSize = true;
            this.Txtcambio.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtcambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Txtcambio.Location = new System.Drawing.Point(121, 67);
            this.Txtcambio.Name = "Txtcambio";
            this.Txtcambio.Size = new System.Drawing.Size(0, 25);
            this.Txtcambio.TabIndex = 3;
            // 
            // CobroEfectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(579, 121);
            this.Controls.Add(this.Txtcambio);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.Txtpago);
            this.Controls.Add(this.LblBase2);
            this.Controls.Add(this.LblBase1);
            this.Controls.Add(this.LblBase4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CobroEfectivo";
            this.Load += new System.EventHandler(this.CobroEfectivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Logistica.LblBase LblBase4;
        private Logistica.LblBase LblBase1;
        private Logistica.LblBase LblBase2;
        private System.Windows.Forms.Label Txtcambio;
        public Logistica.TxtDecimal Txtpago;
        public Logistica.TxtDecimal TxtMonto;
    }
}
