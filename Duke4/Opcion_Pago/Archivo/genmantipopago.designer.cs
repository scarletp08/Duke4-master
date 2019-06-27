namespace Duke4.Opcion_Pago.Archivo
{
    partial class genmantipopago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(genmantipopago));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ckbcvc = new Duke4.Logistica.CkbBase();
            this.Ckbmoneda = new Duke4.Logistica.CkbBase();
            this.Ckbdocumento = new Duke4.Logistica.CkbBase();
            this.Ckbcheque = new Duke4.Logistica.CkbBase();
            this.Ckbtarjeta = new Duke4.Logistica.CkbBase();
            this.Ckbtipotarjeta = new Duke4.Logistica.CkbBase();
            this.Ckbaprobacion = new Duke4.Logistica.CkbBase();
            this.Ckbcuentaban = new Duke4.Logistica.CkbBase();
            this.Ckbbanco = new Duke4.Logistica.CkbBase();
            this.Ckbautorizacion = new Duke4.Logistica.CkbBase();
            this.Ckbfechaven = new Duke4.Logistica.CkbBase();
            this.myLabel1 = new Duke4.Logistica.LblBase();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.myLabel2 = new Duke4.Logistica.LblBase();
            this.label1 = new Duke4.Logistica.LblBase();
            this.Txtdescripcion = new Duke4.Logistica.TxtMayuscula();
            this.Txtcodigo = new Duke4.Logistica.TxtEntero();
            this.LblLetrero = new Duke4.Logistica.LblGrandeNgta();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.LblLetrero);
            this.MainPanel.Controls.Add(this.BtnBuscar);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.Txtcodigo);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.myLabel2);
            this.MainPanel.Controls.Add(this.myLabel1);
            this.MainPanel.Controls.Add(this.Txtdescripcion);
            this.MainPanel.Size = new System.Drawing.Size(528, 242);
            this.MainPanel.Controls.SetChildIndex(this.Txtdescripcion, 0);
            this.MainPanel.Controls.SetChildIndex(this.myLabel1, 0);
            this.MainPanel.Controls.SetChildIndex(this.myLabel2, 0);
            this.MainPanel.Controls.SetChildIndex(this.label1, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtcodigo, 0);
            this.MainPanel.Controls.SetChildIndex(this.panel1, 0);
            this.MainPanel.Controls.SetChildIndex(this.BtnBuscar, 0);
            this.MainPanel.Controls.SetChildIndex(this.LblEstado, 0);
            this.MainPanel.Controls.SetChildIndex(this.LblLetrero, 0);
            // 
            // LblAlerta
            // 
            this.LblAlerta.Location = new System.Drawing.Point(165, 506);
            this.LblAlerta.Size = new System.Drawing.Size(0, 23);
            this.LblAlerta.Text = "";
            // 
            // LblFunctionName
            // 
            this.LblFunctionName.Location = new System.Drawing.Point(716, 42);
            this.LblFunctionName.Size = new System.Drawing.Size(0, 23);
            this.LblFunctionName.Text = "";
            // 
            // LblEstado
            // 
            this.LblEstado.Size = new System.Drawing.Size(0, 23);
            this.LblEstado.Text = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Ckbcvc);
            this.panel1.Controls.Add(this.Ckbmoneda);
            this.panel1.Controls.Add(this.Ckbdocumento);
            this.panel1.Controls.Add(this.Ckbcheque);
            this.panel1.Controls.Add(this.Ckbtarjeta);
            this.panel1.Controls.Add(this.Ckbtipotarjeta);
            this.panel1.Controls.Add(this.Ckbaprobacion);
            this.panel1.Controls.Add(this.Ckbcuentaban);
            this.panel1.Controls.Add(this.Ckbbanco);
            this.panel1.Controls.Add(this.Ckbautorizacion);
            this.panel1.Controls.Add(this.Ckbfechaven);
            this.panel1.Location = new System.Drawing.Point(7, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 156);
            this.panel1.TabIndex = 41;
            // 
            // Ckbcvc
            // 
            this.Ckbcvc.AutoSize = true;
            this.Ckbcvc.Location = new System.Drawing.Point(3, 133);
            this.Ckbcvc.Name = "Ckbcvc";
            this.Ckbcvc.Size = new System.Drawing.Size(99, 20);
            this.Ckbcvc.TabIndex = 53;
            this.Ckbcvc.TabStop = false;
            this.Ckbcvc.Text = "CVV ó CVC";
            this.Ckbcvc.UseVisualStyleBackColor = true;
            // 
            // Ckbmoneda
            // 
            this.Ckbmoneda.AutoSize = true;
            this.Ckbmoneda.Location = new System.Drawing.Point(212, 107);
            this.Ckbmoneda.Name = "Ckbmoneda";
            this.Ckbmoneda.Size = new System.Drawing.Size(150, 20);
            this.Ckbmoneda.TabIndex = 48;
            this.Ckbmoneda.TabStop = false;
            this.Ckbmoneda.Text = "Moneda Extranjera";
            this.Ckbmoneda.UseVisualStyleBackColor = true;
            // 
            // Ckbdocumento
            // 
            this.Ckbdocumento.AutoSize = true;
            this.Ckbdocumento.Location = new System.Drawing.Point(212, 81);
            this.Ckbdocumento.Name = "Ckbdocumento";
            this.Ckbdocumento.Size = new System.Drawing.Size(116, 20);
            this.Ckbdocumento.TabIndex = 49;
            this.Ckbdocumento.TabStop = false;
            this.Ckbdocumento.Text = "# Documento";
            this.Ckbdocumento.UseVisualStyleBackColor = true;
            // 
            // Ckbcheque
            // 
            this.Ckbcheque.AutoSize = true;
            this.Ckbcheque.Location = new System.Drawing.Point(3, 3);
            this.Ckbcheque.Name = "Ckbcheque";
            this.Ckbcheque.Size = new System.Drawing.Size(91, 20);
            this.Ckbcheque.TabIndex = 42;
            this.Ckbcheque.TabStop = false;
            this.Ckbcheque.Text = "# Cheque";
            this.Ckbcheque.UseVisualStyleBackColor = true;
            // 
            // Ckbtarjeta
            // 
            this.Ckbtarjeta.AutoSize = true;
            this.Ckbtarjeta.Location = new System.Drawing.Point(3, 81);
            this.Ckbtarjeta.Name = "Ckbtarjeta";
            this.Ckbtarjeta.Size = new System.Drawing.Size(88, 20);
            this.Ckbtarjeta.TabIndex = 52;
            this.Ckbtarjeta.TabStop = false;
            this.Ckbtarjeta.Text = "# Tarjeta";
            this.Ckbtarjeta.UseVisualStyleBackColor = true;
            // 
            // Ckbtipotarjeta
            // 
            this.Ckbtipotarjeta.AutoSize = true;
            this.Ckbtipotarjeta.Location = new System.Drawing.Point(212, 55);
            this.Ckbtipotarjeta.Name = "Ckbtipotarjeta";
            this.Ckbtipotarjeta.Size = new System.Drawing.Size(106, 20);
            this.Ckbtipotarjeta.TabIndex = 46;
            this.Ckbtipotarjeta.TabStop = false;
            this.Ckbtipotarjeta.Text = "Tipo Tarjeta";
            this.Ckbtipotarjeta.UseVisualStyleBackColor = true;
            // 
            // Ckbaprobacion
            // 
            this.Ckbaprobacion.AutoSize = true;
            this.Ckbaprobacion.Location = new System.Drawing.Point(212, 3);
            this.Ckbaprobacion.Name = "Ckbaprobacion";
            this.Ckbaprobacion.Size = new System.Drawing.Size(115, 20);
            this.Ckbaprobacion.TabIndex = 47;
            this.Ckbaprobacion.TabStop = false;
            this.Ckbaprobacion.Text = "# Aprobación";
            this.Ckbaprobacion.UseVisualStyleBackColor = true;
            // 
            // Ckbcuentaban
            // 
            this.Ckbcuentaban.AutoSize = true;
            this.Ckbcuentaban.Location = new System.Drawing.Point(212, 29);
            this.Ckbcuentaban.Name = "Ckbcuentaban";
            this.Ckbcuentaban.Size = new System.Drawing.Size(100, 20);
            this.Ckbcuentaban.TabIndex = 45;
            this.Ckbcuentaban.TabStop = false;
            this.Ckbcuentaban.Text = "Cta. Banco";
            this.Ckbcuentaban.UseVisualStyleBackColor = true;
            // 
            // Ckbbanco
            // 
            this.Ckbbanco.AutoSize = true;
            this.Ckbbanco.Location = new System.Drawing.Point(3, 29);
            this.Ckbbanco.Name = "Ckbbanco";
            this.Ckbbanco.Size = new System.Drawing.Size(67, 20);
            this.Ckbbanco.TabIndex = 51;
            this.Ckbbanco.TabStop = false;
            this.Ckbbanco.Text = "Banco";
            this.Ckbbanco.UseVisualStyleBackColor = true;
            // 
            // Ckbautorizacion
            // 
            this.Ckbautorizacion.AutoSize = true;
            this.Ckbautorizacion.Location = new System.Drawing.Point(3, 55);
            this.Ckbautorizacion.Name = "Ckbautorizacion";
            this.Ckbautorizacion.Size = new System.Drawing.Size(108, 20);
            this.Ckbautorizacion.TabIndex = 43;
            this.Ckbautorizacion.TabStop = false;
            this.Ckbautorizacion.Text = "Autorización";
            this.Ckbautorizacion.UseVisualStyleBackColor = true;
            // 
            // Ckbfechaven
            // 
            this.Ckbfechaven.AutoSize = true;
            this.Ckbfechaven.Location = new System.Drawing.Point(3, 107);
            this.Ckbfechaven.Name = "Ckbfechaven";
            this.Ckbfechaven.Size = new System.Drawing.Size(151, 20);
            this.Ckbfechaven.TabIndex = 44;
            this.Ckbfechaven.TabStop = false;
            this.Ckbfechaven.Text = "Fecha Vencimiento";
            this.Ckbfechaven.UseVisualStyleBackColor = true;
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel1.ForeColor = System.Drawing.Color.Black;
            this.myLabel1.Location = new System.Drawing.Point(6, 63);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(40, 16);
            this.myLabel1.TabIndex = 0;
            this.myLabel1.Text = "Pedir";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.Location = new System.Drawing.Point(211, 4);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(60, 25);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "  ";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(7, 43);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(83, 16);
            this.myLabel2.TabIndex = 46;
            this.myLabel2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Código";
            // 
            // Txtdescripcion
            // 
            this.Txtdescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.Txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtdescripcion.Location = new System.Drawing.Point(104, 36);
            this.Txtdescripcion.Name = "Txtdescripcion";
            this.Txtdescripcion.Size = new System.Drawing.Size(401, 23);
            this.Txtdescripcion.TabIndex = 3;
            // 
            // Txtcodigo
            // 
            this.Txtcodigo.BackColor = System.Drawing.SystemColors.Window;
            this.Txtcodigo.Location = new System.Drawing.Point(104, 6);
            this.Txtcodigo.MaxLength = 9;
            this.Txtcodigo.Name = "Txtcodigo";
            this.Txtcodigo.Size = new System.Drawing.Size(100, 23);
            this.Txtcodigo.TabIndex = 1;
            this.Txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txtcodigo.Leave += new System.EventHandler(this.Txtcodigo_Leave);
            this.Txtcodigo.Validating += new System.ComponentModel.CancelEventHandler(this.Txtcodigo_Validating);
            // 
            // LblLetrero
            // 
            this.LblLetrero.AutoSize = true;
            this.LblLetrero.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.LblLetrero.ForeColor = System.Drawing.Color.Black;
            this.LblLetrero.Location = new System.Drawing.Point(271, 0);
            this.LblLetrero.Name = "LblLetrero";
            this.LblLetrero.Size = new System.Drawing.Size(0, 23);
            this.LblLetrero.TabIndex = 47;
            // 
            // Pgenmantipopago
            // 
            this.ClientSize = new System.Drawing.Size(696, 345);
            this.Name = "Pgenmantipopago";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Logistica.LblBase myLabel1;
        public System.Windows.Forms.Button BtnBuscar;
        private Logistica.LblBase myLabel2;
        private Logistica.LblBase label1;
        public Logistica.TxtMayuscula Txtdescripcion;
        public Logistica.TxtEntero Txtcodigo;
        public Logistica.CkbBase Ckbcvc;
        public Logistica.CkbBase Ckbmoneda;
        public Logistica.CkbBase Ckbdocumento;
        public Logistica.CkbBase Ckbcheque;
        public Logistica.CkbBase Ckbtarjeta;
        public Logistica.CkbBase Ckbtipotarjeta;
        public Logistica.CkbBase Ckbaprobacion;
        public Logistica.CkbBase Ckbcuentaban;
        public Logistica.CkbBase Ckbbanco;
        public Logistica.CkbBase Ckbautorizacion;
        public Logistica.CkbBase Ckbfechaven;
        public Logistica.LblGrandeNgta LblLetrero;
    }
}
