namespace Duke4.Opcion_Pago.Proceso
{
    partial class Cobro_Tarjeta
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
            this.Txtaprobacion = new Logistica.TxtMayuscula();
            this.TxtMonto = new Logistica.TxtDecimal();
            this.LblBase6 = new Logistica.LblBase();
            this.LblAlarma = new System.Windows.Forms.Label();
            this.CbTipo = new Logistica.CmbBase();
            this.CbBanco = new Logistica.CmbBase();
            this.LblBase5 = new Logistica.LblBase();
            this.LblBase4 = new Logistica.LblBase();
            this.LblBase3 = new Logistica.LblBase();
            this.LblBase2 = new Logistica.LblBase();
            this.LblBase1 = new Logistica.LblBase();
            this.Mkbfechaven = new System.Windows.Forms.MaskedTextBox();
            this.Txtcvc = new Logistica.TxtEntero();
            this.LblBase7 = new Logistica.LblBase();
            this.TxtNoTarjeta = new Logistica.MskTarjeta();
            this.SuspendLayout();
            // 
            // Txtaprobacion
            // 
            this.Txtaprobacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtaprobacion.Location = new System.Drawing.Point(420, 45);
            this.Txtaprobacion.Name = "Txtaprobacion";
            this.Txtaprobacion.Size = new System.Drawing.Size(138, 23);
            this.Txtaprobacion.TabIndex = 6;
            // 
            // TxtMonto
            // 
            this.TxtMonto.Location = new System.Drawing.Point(421, 75);
            this.TxtMonto.MaxLength = 14;
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(138, 23);
            this.TxtMonto.TabIndex = 7;
            this.TxtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblBase6
            // 
            this.LblBase6.AutoSize = true;
            this.LblBase6.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.LblBase6.Location = new System.Drawing.Point(3, 79);
            this.LblBase6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBase6.Name = "LblBase6";
            this.LblBase6.Size = new System.Drawing.Size(108, 16);
            this.LblBase6.TabIndex = 17;
            this.LblBase6.Text = "Cod. Seguridad";
            // 
            // LblAlarma
            // 
            this.LblAlarma.AutoSize = true;
            this.LblAlarma.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlarma.Location = new System.Drawing.Point(13, 240);
            this.LblAlarma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAlarma.Name = "LblAlarma";
            this.LblAlarma.Size = new System.Drawing.Size(0, 18);
            this.LblAlarma.TabIndex = 15;
            // 
            // CbTipo
            // 
            this.CbTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipo.FormattingEnabled = true;
            this.CbTipo.Location = new System.Drawing.Point(421, 13);
            this.CbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.CbTipo.Name = "CbTipo";
            this.CbTipo.ReadOnly = false;
            this.CbTipo.Size = new System.Drawing.Size(138, 24);
            this.CbTipo.TabIndex = 5;
            // 
            // CbBanco
            // 
            this.CbBanco.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbBanco.FormattingEnabled = true;
            this.CbBanco.Location = new System.Drawing.Point(126, 13);
            this.CbBanco.Margin = new System.Windows.Forms.Padding(4);
            this.CbBanco.Name = "CbBanco";
            this.CbBanco.ReadOnly = false;
            this.CbBanco.Size = new System.Drawing.Size(160, 24);
            this.CbBanco.TabIndex = 1;
            // 
            // LblBase5
            // 
            this.LblBase5.AutoSize = true;
            this.LblBase5.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.LblBase5.Location = new System.Drawing.Point(305, 48);
            this.LblBase5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBase5.Name = "LblBase5";
            this.LblBase5.Size = new System.Drawing.Size(108, 16);
            this.LblBase5.TabIndex = 14;
            this.LblBase5.Text = "No. Aprobación";
            // 
            // LblBase4
            // 
            this.LblBase4.AutoSize = true;
            this.LblBase4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.LblBase4.Location = new System.Drawing.Point(306, 79);
            this.LblBase4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBase4.Name = "LblBase4";
            this.LblBase4.Size = new System.Drawing.Size(49, 16);
            this.LblBase4.TabIndex = 13;
            this.LblBase4.Text = "Monto";
            // 
            // LblBase3
            // 
            this.LblBase3.AutoSize = true;
            this.LblBase3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.LblBase3.Location = new System.Drawing.Point(3, 48);
            this.LblBase3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBase3.Name = "LblBase3";
            this.LblBase3.Size = new System.Drawing.Size(108, 16);
            this.LblBase3.TabIndex = 12;
            this.LblBase3.Text = "Número Tarjeta";
            // 
            // LblBase2
            // 
            this.LblBase2.AutoSize = true;
            this.LblBase2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.LblBase2.Location = new System.Drawing.Point(306, 16);
            this.LblBase2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBase2.Name = "LblBase2";
            this.LblBase2.Size = new System.Drawing.Size(36, 16);
            this.LblBase2.TabIndex = 11;
            this.LblBase2.Text = "Tipo";
            // 
            // LblBase1
            // 
            this.LblBase1.AutoSize = true;
            this.LblBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.LblBase1.Location = new System.Drawing.Point(3, 16);
            this.LblBase1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBase1.Name = "LblBase1";
            this.LblBase1.Size = new System.Drawing.Size(48, 16);
            this.LblBase1.TabIndex = 10;
            this.LblBase1.Text = "Banco";
            // 
            // Mkbfechaven
            // 
            this.Mkbfechaven.Location = new System.Drawing.Point(126, 106);
            this.Mkbfechaven.Name = "Mkbfechaven";
            this.Mkbfechaven.Size = new System.Drawing.Size(100, 23);
            this.Mkbfechaven.TabIndex = 4;
            this.Mkbfechaven.TextChanged += new System.EventHandler(this.Mkbfechaven_TextChanged);
            this.Mkbfechaven.Enter += new System.EventHandler(this.Mkbfechaven_Enter);
            this.Mkbfechaven.Leave += new System.EventHandler(this.Mkbfechaven_Leave);
            // 
            // Txtcvc
            // 
            this.Txtcvc.Location = new System.Drawing.Point(126, 77);
            this.Txtcvc.MaxLength = 3;
            this.Txtcvc.Name = "Txtcvc";
            this.Txtcvc.Size = new System.Drawing.Size(160, 23);
            this.Txtcvc.TabIndex = 3;
            this.Txtcvc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblBase7
            // 
            this.LblBase7.AutoSize = true;
            this.LblBase7.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.LblBase7.Location = new System.Drawing.Point(3, 113);
            this.LblBase7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBase7.Name = "LblBase7";
            this.LblBase7.Size = new System.Drawing.Size(90, 16);
            this.LblBase7.TabIndex = 22;
            this.LblBase7.Text = "Fecha Venc.";
            // 
            // TxtNoTarjeta
            // 
            this.TxtNoTarjeta.Location = new System.Drawing.Point(126, 45);
            this.TxtNoTarjeta.Name = "TxtNoTarjeta";
            this.TxtNoTarjeta.Size = new System.Drawing.Size(160, 23);
            this.TxtNoTarjeta.TabIndex = 2;
            // 
            // CobroConTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(577, 142);
            this.ControlBox = false;
            this.Controls.Add(this.TxtNoTarjeta);
            this.Controls.Add(this.LblBase7);
            this.Controls.Add(this.Txtcvc);
            this.Controls.Add(this.Mkbfechaven);
            this.Controls.Add(this.Txtaprobacion);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.LblBase6);
            this.Controls.Add(this.LblAlarma);
            this.Controls.Add(this.CbTipo);
            this.Controls.Add(this.CbBanco);
            this.Controls.Add(this.LblBase5);
            this.Controls.Add(this.LblBase4);
            this.Controls.Add(this.LblBase3);
            this.Controls.Add(this.LblBase2);
            this.Controls.Add(this.LblBase1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CobroConTarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.CobroConTarjeta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Logistica.LblBase LblBase1;
        private Logistica.LblBase LblBase2;
        private Logistica.LblBase LblBase3;
        private Logistica.LblBase LblBase4;
        private Logistica.LblBase LblBase5;
        public Logistica.CmbBase CbBanco;
        public Logistica.CmbBase CbTipo;
        private System.Windows.Forms.Label LblAlarma;
        private Logistica.LblBase LblBase6;
        public Logistica.TxtDecimal TxtMonto;
        public Logistica.TxtMayuscula Txtaprobacion;
        public System.Windows.Forms.MaskedTextBox Mkbfechaven;
        public Logistica.TxtEntero Txtcvc;
        private Logistica.LblBase LblBase7;
        public Logistica.MskTarjeta TxtNoTarjeta;
    }
}