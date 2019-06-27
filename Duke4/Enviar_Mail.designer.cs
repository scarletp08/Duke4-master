namespace Duke4
{
    partial class Enviar_Mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enviar_Mail));
            this.lblBase4 = new Duke4.Logistica.LblBase();
            this.txtBase1 = new Duke4.Logistica.TxtBase();
            this.lblBase3 = new Duke4.Logistica.LblBase();
            this.lblBase2 = new Duke4.Logistica.LblBase();
            this.lblBase1 = new Duke4.Logistica.LblBase();
            this.menuBase1 = new Duke4.Logistica.menuBase();
            this.BtnEnviar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRetornar = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtAttachments = new Duke4.Logistica.TxtNota();
            this.txtBase2 = new Duke4.Logistica.TxtBase();
            this.txtEmail = new Duke4.Logistica.TxtBase();
            this.menuBase1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBase4
            // 
            this.lblBase4.AutoSize = true;
            this.lblBase4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase4.ForeColor = System.Drawing.Color.Black;
            this.lblBase4.Location = new System.Drawing.Point(21, 323);
            this.lblBase4.Name = "lblBase4";
            this.lblBase4.Size = new System.Drawing.Size(162, 16);
            this.lblBase4.TabIndex = 351;
            this.lblBase4.Text = "Documentos anexados:";
            // 
            // txtBase1
            // 
            this.txtBase1.Location = new System.Drawing.Point(114, 164);
            this.txtBase1.Name = "txtBase1";
            this.txtBase1.Size = new System.Drawing.Size(474, 23);
            this.txtBase1.TabIndex = 1;
            // 
            // lblBase3
            // 
            this.lblBase3.AutoSize = true;
            this.lblBase3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase3.ForeColor = System.Drawing.Color.Black;
            this.lblBase3.Location = new System.Drawing.Point(21, 200);
            this.lblBase3.Name = "lblBase3";
            this.lblBase3.Size = new System.Drawing.Size(62, 16);
            this.lblBase3.TabIndex = 348;
            this.lblBase3.Text = "Mensaje";
            // 
            // lblBase2
            // 
            this.lblBase2.AutoSize = true;
            this.lblBase2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase2.ForeColor = System.Drawing.Color.Black;
            this.lblBase2.Location = new System.Drawing.Point(21, 167);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(54, 16);
            this.lblBase2.TabIndex = 347;
            this.lblBase2.Text = "Asunto";
            // 
            // lblBase1
            // 
            this.lblBase1.AutoSize = true;
            this.lblBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase1.ForeColor = System.Drawing.Color.Black;
            this.lblBase1.Location = new System.Drawing.Point(21, 117);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(87, 16);
            this.lblBase1.TabIndex = 346;
            this.lblBase1.Text = "Destinatario";
            // 
            // menuBase1
            // 
            this.menuBase1.AutoSize = false;
            this.menuBase1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuBase1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuBase1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnEnviar,
            this.BtnRetornar});
            this.menuBase1.Location = new System.Drawing.Point(0, 40);
            this.menuBase1.Name = "menuBase1";
            this.menuBase1.ShowItemToolTips = true;
            this.menuBase1.Size = new System.Drawing.Size(860, 62);
            this.menuBase1.TabIndex = 345;
            this.menuBase1.Text = "menuBase1";
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviar.Image = global::Duke4.Properties.Resources.email__2_;
            this.BtnEnviar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEnviar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnEnviar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.BtnEnviar.Size = new System.Drawing.Size(101, 55);
            this.BtnEnviar.Text = "Enviar [F10]";
            this.BtnEnviar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // BtnRetornar
            // 
            this.BtnRetornar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetornar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRetornar.Image")));
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
            // TxtAttachments
            // 
            this.TxtAttachments.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtAttachments.Enabled = false;
            this.TxtAttachments.Location = new System.Drawing.Point(24, 342);
            this.TxtAttachments.Multiline = true;
            this.TxtAttachments.Name = "TxtAttachments";
            this.TxtAttachments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtAttachments.Size = new System.Drawing.Size(564, 44);
            this.TxtAttachments.TabIndex = 3;
            // 
            // txtBase2
            // 
            this.txtBase2.Location = new System.Drawing.Point(24, 219);
            this.txtBase2.Multiline = true;
            this.txtBase2.Name = "txtBase2";
            this.txtBase2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBase2.Size = new System.Drawing.Size(571, 89);
            this.txtBase2.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(114, 114);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEmail.Size = new System.Drawing.Size(474, 42);
            this.txtEmail.TabIndex = 0;
            // 
            // Enviar_Mail
            // 
            this.ClientSize = new System.Drawing.Size(627, 413);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtBase2);
            this.Controls.Add(this.TxtAttachments);
            this.Controls.Add(this.lblBase4);
            this.Controls.Add(this.txtBase1);
            this.Controls.Add(this.lblBase3);
            this.Controls.Add(this.lblBase2);
            this.Controls.Add(this.lblBase1);
            this.Controls.Add(this.menuBase1);
            this.Name = "Enviar_Mail";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Enviar_Mail2_Load);
            this.Controls.SetChildIndex(this.menuBase1, 0);
            this.Controls.SetChildIndex(this.lblBase1, 0);
            this.Controls.SetChildIndex(this.lblBase2, 0);
            this.Controls.SetChildIndex(this.lblBase3, 0);
            this.Controls.SetChildIndex(this.txtBase1, 0);
            this.Controls.SetChildIndex(this.lblBase4, 0);
            this.Controls.SetChildIndex(this.TxtAttachments, 0);
            this.Controls.SetChildIndex(this.txtBase2, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.menuBase1.ResumeLayout(false);
            this.menuBase1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Logistica.LblBase lblBase4;
        private Logistica.TxtBase txtBase1;
        private Logistica.LblBase lblBase3;
        private Logistica.LblBase lblBase2;
        private Logistica.LblBase lblBase1;
        private Logistica.menuBase menuBase1;
        public System.Windows.Forms.ToolStripMenuItem BtnEnviar;
        public System.Windows.Forms.ToolStripMenuItem BtnRetornar;
        private Logistica.TxtNota TxtAttachments;
        private Logistica.TxtBase txtBase2;
        private Logistica.TxtBase txtEmail;
    }
}
