namespace Duke4.Opcion_Pago.Proceso
{
    partial class Cobro_Cheque
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
            this.LblAlarma = new System.Windows.Forms.Label();
            this.TxtMonto = new Duke4.Logistica.TxtDecimal();
            this.TxtNoCK = new Duke4.Logistica.TxtEntero();
            this.CbBanco = new Duke4.Logistica.CmbBase();
            this.LblBase3 = new Duke4.Logistica.LblBase();
            this.LblBase2 = new Duke4.Logistica.LblBase();
            this.LblBase1 = new Duke4.Logistica.LblBase();
            this.LblBase4 = new Duke4.Logistica.LblBase();
            this.Txtautorizacion = new Duke4.Logistica.TxtMayuscula();
            this.SuspendLayout();
            // 
            // LblAlarma
            // 
            this.LblAlarma.AutoSize = true;
            this.LblAlarma.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlarma.Location = new System.Drawing.Point(164, 176);
            this.LblAlarma.Name = "LblAlarma";
            this.LblAlarma.Size = new System.Drawing.Size(0, 18);
            this.LblAlarma.TabIndex = 18;
            // 
            // TxtMonto
            // 
            this.TxtMonto.Location = new System.Drawing.Point(124, 93);
            this.TxtMonto.MaxLength = 14;
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(107, 23);
            this.TxtMonto.TabIndex = 4;
            this.TxtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtMonto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtMonto_KeyUp);
            this.TxtMonto.Leave += new System.EventHandler(this.TxtMonto_Leave);
            // 
            // TxtNoCK
            // 
            this.TxtNoCK.Location = new System.Drawing.Point(124, 35);
            this.TxtNoCK.MaxLength = 9;
            this.TxtNoCK.Name = "TxtNoCK";
            this.TxtNoCK.Size = new System.Drawing.Size(107, 23);
            this.TxtNoCK.TabIndex = 2;
            this.TxtNoCK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CbBanco
            // 
            this.CbBanco.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbBanco.FormattingEnabled = true;
            this.CbBanco.Location = new System.Drawing.Point(124, 5);
            this.CbBanco.Name = "CbBanco";
            this.CbBanco.ReadOnly = false;
            this.CbBanco.Size = new System.Drawing.Size(204, 24);
            this.CbBanco.TabIndex = 1;
            // 
            // LblBase3
            // 
            this.LblBase3.AutoSize = true;
            this.LblBase3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.LblBase3.Location = new System.Drawing.Point(12, 96);
            this.LblBase3.Name = "LblBase3";
            this.LblBase3.Size = new System.Drawing.Size(49, 16);
            this.LblBase3.TabIndex = 13;
            this.LblBase3.Text = "Monto";
            // 
            // LblBase2
            // 
            this.LblBase2.AutoSize = true;
            this.LblBase2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.LblBase2.Location = new System.Drawing.Point(12, 38);
            this.LblBase2.Name = "LblBase2";
            this.LblBase2.Size = new System.Drawing.Size(79, 16);
            this.LblBase2.TabIndex = 12;
            this.LblBase2.Text = "Número CK";
            // 
            // LblBase1
            // 
            this.LblBase1.AutoSize = true;
            this.LblBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.LblBase1.Location = new System.Drawing.Point(12, 8);
            this.LblBase1.Name = "LblBase1";
            this.LblBase1.Size = new System.Drawing.Size(48, 16);
            this.LblBase1.TabIndex = 11;
            this.LblBase1.Text = "Banco";
            // 
            // LblBase4
            // 
            this.LblBase4.AutoSize = true;
            this.LblBase4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.LblBase4.Location = new System.Drawing.Point(12, 67);
            this.LblBase4.Name = "LblBase4";
            this.LblBase4.Size = new System.Drawing.Size(89, 16);
            this.LblBase4.TabIndex = 20;
            this.LblBase4.Text = "Autorización";
            // 
            // Txtautorizacion
            // 
            this.Txtautorizacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtautorizacion.Location = new System.Drawing.Point(124, 64);
            this.Txtautorizacion.Name = "Txtautorizacion";
            this.Txtautorizacion.Size = new System.Drawing.Size(107, 23);
            this.Txtautorizacion.TabIndex = 3;
            // 
            // CobroConCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(577, 119);
            this.ControlBox = false;
            this.Controls.Add(this.Txtautorizacion);
            this.Controls.Add(this.LblBase4);
            this.Controls.Add(this.LblAlarma);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.TxtNoCK);
            this.Controls.Add(this.CbBanco);
            this.Controls.Add(this.LblBase3);
            this.Controls.Add(this.LblBase2);
            this.Controls.Add(this.LblBase1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CobroConCheque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.CobroConCheque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Logistica.LblBase LblBase1;
        private Logistica.LblBase LblBase2;
        private Logistica.LblBase LblBase3;
        public Logistica.CmbBase CbBanco;
        public Logistica.TxtEntero TxtNoCK;
        public Logistica.TxtDecimal TxtMonto;
        private System.Windows.Forms.Label LblAlarma;
        private Logistica.LblBase LblBase4;
        public Logistica.TxtMayuscula Txtautorizacion;
    }
}