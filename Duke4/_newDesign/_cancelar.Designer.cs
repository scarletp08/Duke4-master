namespace Duke4._newDesign
{
    partial class _cancelar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_cancelar));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BtnCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRetornar = new System.Windows.Forms.ToolStripMenuItem();
            this.Txtcodigoanulacion = new Duke4.Logistica.TxtEntero();
            this.myLabel4 = new Duke4.Logistica.LblBase();
            this.Txtdescripcionanulacion = new Duke4.Logistica.TxtMayuscula();
            this.BtnBuscarAnulacion = new Duke4.Logistica.BtnBuscar();
            this.Txtpassword = new Duke4.Logistica.TxtMayuscula();
            this.Txtusuario = new Duke4.Logistica.TxtMayuscula();
            this.Txtcancelacion = new Duke4.Logistica.TxtMayuscula();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            this.BtnCancelar,
            this.BtnRetornar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 40);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(758, 57);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = global::Duke4.Properties.Resources.mark;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.BtnCancelar.Size = new System.Drawing.Size(108, 50);
            this.BtnCancelar.Text = "Cancelar [F4]";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnRetornar
            // 
            this.BtnRetornar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetornar.Image = global::Duke4.Properties.Resources.retornar32;
            this.BtnRetornar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRetornar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnRetornar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnRetornar.Name = "BtnRetornar";
            this.BtnRetornar.Size = new System.Drawing.Size(114, 50);
            this.BtnRetornar.Text = "Retornar [Esc]";
            this.BtnRetornar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRetornar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnRetornar.Click += new System.EventHandler(this.BtnRetornar_Click);
            // 
            // Txtcodigoanulacion
            // 
            this.Txtcodigoanulacion.BackColor = System.Drawing.SystemColors.Window;
            this.Txtcodigoanulacion.Location = new System.Drawing.Point(17, 327);
            this.Txtcodigoanulacion.MaxLength = 9;
            this.Txtcodigoanulacion.Name = "Txtcodigoanulacion";
            this.Txtcodigoanulacion.Size = new System.Drawing.Size(100, 23);
            this.Txtcodigoanulacion.TabIndex = 308;
            this.Txtcodigoanulacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txtcodigoanulacion.Validating += new System.ComponentModel.CancelEventHandler(this.Txtcodigoanulacion_Validating);
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(13, 308);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(125, 16);
            this.myLabel4.TabIndex = 310;
            this.myLabel4.Text = "Tipo de Anulación";
            // 
            // Txtdescripcionanulacion
            // 
            this.Txtdescripcionanulacion.BackColor = System.Drawing.SystemColors.Window;
            this.Txtdescripcionanulacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtdescripcionanulacion.Enabled = false;
            this.Txtdescripcionanulacion.Location = new System.Drawing.Point(17, 349);
            this.Txtdescripcionanulacion.Name = "Txtdescripcionanulacion";
            this.Txtdescripcionanulacion.ReadOnly = true;
            this.Txtdescripcionanulacion.Size = new System.Drawing.Size(571, 23);
            this.Txtdescripcionanulacion.TabIndex = 311;
            this.Txtdescripcionanulacion.TabStop = false;
            // 
            // BtnBuscarAnulacion
            // 
            this.BtnBuscarAnulacion.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnBuscarAnulacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBuscarAnulacion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBuscarAnulacion.FlatAppearance.BorderSize = 0;
            this.BtnBuscarAnulacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarAnulacion.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarAnulacion.Image")));
            this.BtnBuscarAnulacion.Location = new System.Drawing.Point(133, 324);
            this.BtnBuscarAnulacion.Name = "BtnBuscarAnulacion";
            this.BtnBuscarAnulacion.Size = new System.Drawing.Size(24, 24);
            this.BtnBuscarAnulacion.TabIndex = 309;
            this.BtnBuscarAnulacion.TabStop = false;
            this.BtnBuscarAnulacion.Text = " ";
            this.BtnBuscarAnulacion.UseVisualStyleBackColor = false;
            this.BtnBuscarAnulacion.Click += new System.EventHandler(this.BtnBuscarAnulacion_Click);
            // 
            // Txtpassword
            // 
            this.Txtpassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtpassword.Location = new System.Drawing.Point(17, 272);
            this.Txtpassword.Name = "Txtpassword";
            this.Txtpassword.PasswordChar = '*';
            this.Txtpassword.Size = new System.Drawing.Size(164, 23);
            this.Txtpassword.TabIndex = 298;
            // 
            // Txtusuario
            // 
            this.Txtusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtusuario.Location = new System.Drawing.Point(17, 232);
            this.Txtusuario.Name = "Txtusuario";
            this.Txtusuario.Size = new System.Drawing.Size(164, 23);
            this.Txtusuario.TabIndex = 297;
            // 
            // Txtcancelacion
            // 
            this.Txtcancelacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtcancelacion.Location = new System.Drawing.Point(17, 413);
            this.Txtcancelacion.Multiline = true;
            this.Txtcancelacion.Name = "Txtcancelacion";
            this.Txtcancelacion.Size = new System.Drawing.Size(571, 65);
            this.Txtcancelacion.TabIndex = 299;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(13, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 1);
            this.panel1.TabIndex = 307;
            // 
            // TxtDate
            // 
            this.TxtDate.Location = new System.Drawing.Point(480, 110);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.ReadOnly = true;
            this.TxtDate.Size = new System.Drawing.Size(104, 23);
            this.TxtDate.TabIndex = 306;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(426, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 305;
            this.label8.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10F);
            this.label7.Location = new System.Drawing.Point(14, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 17);
            this.label7.TabIndex = 304;
            this.label7.Text = "Razón de la Cancelación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F);
            this.label5.Location = new System.Drawing.Point(14, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 303;
            this.label5.Text = "Clave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F);
            this.label4.Location = new System.Drawing.Point(14, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 302;
            this.label4.Text = "Usuario";
            // 
            // LblNombre
            // 
            this.LblNombre.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.LblNombre.Location = new System.Drawing.Point(13, 157);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(571, 34);
            this.LblNombre.TabIndex = 301;
            this.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(10, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(574, 34);
            this.label10.TabIndex = 300;
            this.label10.Text = "Desea anular el Documento  ";
            // 
            // _cancelar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 505);
            this.Controls.Add(this.Txtcodigoanulacion);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.Txtdescripcionanulacion);
            this.Controls.Add(this.BtnBuscarAnulacion);
            this.Controls.Add(this.Txtpassword);
            this.Controls.Add(this.Txtusuario);
            this.Controls.Add(this.Txtcancelacion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.menuStrip1);
            this.Name = "_cancelar";
            this.Text = "_cancelar";
            this.Load += new System.EventHandler(this._cancelar_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.LblNombre, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.TxtDate, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.Txtcancelacion, 0);
            this.Controls.SetChildIndex(this.Txtusuario, 0);
            this.Controls.SetChildIndex(this.Txtpassword, 0);
            this.Controls.SetChildIndex(this.BtnBuscarAnulacion, 0);
            this.Controls.SetChildIndex(this.Txtdescripcionanulacion, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.Txtcodigoanulacion, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem BtnCancelar;
        public System.Windows.Forms.ToolStripMenuItem BtnRetornar;
        public Logistica.TxtEntero Txtcodigoanulacion;
        private Logistica.LblBase myLabel4;
        public Logistica.TxtMayuscula Txtdescripcionanulacion;
        public Logistica.BtnBuscar BtnBuscarAnulacion;
        private Logistica.TxtMayuscula Txtpassword;
        public Logistica.TxtMayuscula Txtusuario;
        public Logistica.TxtMayuscula Txtcancelacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label label10;
    }
}