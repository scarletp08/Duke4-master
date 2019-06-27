namespace Duke4
{
    partial class CancelarForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.BtnElegir = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txtcancelacion = new Duke4.Logistica.TxtMayuscula();
            this.Txtusuario = new Duke4.Logistica.TxtMayuscula();
            this.Txtpassword = new Duke4.Logistica.TxtMayuscula();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormTitle
            // 
            this.FormTitle.ForeColor = System.Drawing.Color.White;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.aToolStripMenuItem1,
            this.toolStripTextBox1,
            this.BtnElegir,
            this.BtnCancelar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(161, 387);
            this.menuStrip1.TabIndex = 50;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Paint += new System.Windows.Forms.PaintEventHandler(this.menuStrip1_Paint);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.AutoSize = false;
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(195, 20);
            // 
            // aToolStripMenuItem1
            // 
            this.aToolStripMenuItem1.AutoSize = false;
            this.aToolStripMenuItem1.Name = "aToolStripMenuItem1";
            this.aToolStripMenuItem1.Size = new System.Drawing.Size(195, 20);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox1.Enabled = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(190, 24);
            // 
            // BtnElegir
            // 
            this.BtnElegir.AutoSize = false;
            this.BtnElegir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnElegir.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnElegir.Name = "BtnElegir";
            this.BtnElegir.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.BtnElegir.Size = new System.Drawing.Size(150, 30);
            this.BtnElegir.Text = "Elegir [F2]";
            this.BtnElegir.Click += new System.EventHandler(this.BtnElegir_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.AutoSize = false;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(150, 30);
            this.BtnCancelar.Text = "Retornar [Esc]";
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtDate
            // 
            this.TxtDate.Location = new System.Drawing.Point(641, 45);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.ReadOnly = true;
            this.TxtDate.Size = new System.Drawing.Size(104, 23);
            this.TxtDate.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(587, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 48;
            this.label8.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10F);
            this.label7.Location = new System.Drawing.Point(171, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Razón de la Cancelación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F);
            this.label5.Location = new System.Drawing.Point(171, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "Clave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F);
            this.label4.Location = new System.Drawing.Point(171, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Usuario";
            // 
            // LblNombre
            // 
            this.LblNombre.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.LblNombre.Location = new System.Drawing.Point(206, 92);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(539, 34);
            this.LblNombre.TabIndex = 43;
            this.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(171, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 34);
            this.label2.TabIndex = 42;
            this.label2.Text = "De ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(171, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(574, 34);
            this.label10.TabIndex = 39;
            this.label10.Text = "Desea cancelar  ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(174, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 1);
            this.panel1.TabIndex = 51;
            // 
            // Txtcancelacion
            // 
            this.Txtcancelacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtcancelacion.Location = new System.Drawing.Point(174, 281);
            this.Txtcancelacion.Multiline = true;
            this.Txtcancelacion.Name = "Txtcancelacion";
            this.Txtcancelacion.Size = new System.Drawing.Size(571, 100);
            this.Txtcancelacion.TabIndex = 3;
            this.Txtcancelacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcancelacion_KeyPress);
            // 
            // Txtusuario
            // 
            this.Txtusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtusuario.Location = new System.Drawing.Point(174, 169);
            this.Txtusuario.Name = "Txtusuario";
            this.Txtusuario.Size = new System.Drawing.Size(164, 23);
            this.Txtusuario.TabIndex = 1;
            // 
            // Txtpassword
            // 
            this.Txtpassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtpassword.Location = new System.Drawing.Point(174, 213);
            this.Txtpassword.Name = "Txtpassword";
            this.Txtpassword.PasswordChar = '*';
            this.Txtpassword.Size = new System.Drawing.Size(164, 23);
            this.Txtpassword.TabIndex = 2;
            // 
            // CancelarForm
            // 
            this.ClientSize = new System.Drawing.Size(751, 387);
            this.Controls.Add(this.Txtpassword);
            this.Controls.Add(this.Txtusuario);
            this.Controls.Add(this.Txtcancelacion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Name = "CancelarForm";
            this.Load += new System.EventHandler(this.CancelarForm_Load);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.LblNombre, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.TxtDate, 0);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.Txtcancelacion, 0);
            this.Controls.SetChildIndex(this.Txtusuario, 0);
            this.Controls.SetChildIndex(this.Txtpassword, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        public System.Windows.Forms.ToolStripMenuItem BtnElegir;
        public System.Windows.Forms.ToolStripMenuItem BtnCancelar;
        private System.Windows.Forms.TextBox TxtDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        public Logistica.TxtMayuscula Txtcancelacion;
        public Logistica.TxtMayuscula Txtusuario;
        private Logistica.TxtMayuscula Txtpassword;
    }
}
