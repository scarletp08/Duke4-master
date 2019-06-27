namespace Duke4.Consulta_General
{
    partial class MFConsulta_Cliente
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
            this.Txtnombre = new Duke4.Logistica.TxtMayuscula();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.BtnSeleccionar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.myLabel1 = new Duke4.Logistica.LblBase();
            this.Cmbbuscarpor = new Duke4.Logistica.CmbBase();
            this.Txtdireccion = new Duke4.Logistica.TxtMayuscula();
            this.myLabel2 = new Duke4.Logistica.LblBase();
            this.myLabel3 = new Duke4.Logistica.LblBase();
            this.myLabel4 = new Duke4.Logistica.LblBase();
            this.Txtciudad = new Duke4.Logistica.TxtMayuscula();
            this.Txtvendedor = new Duke4.Logistica.TxtMayuscula();
            this.myLabel5 = new Duke4.Logistica.LblBase();
            this.Txtemail = new Duke4.Logistica.TxtCorreo();
            this.myLabel6 = new Duke4.Logistica.LblBase();
            this.myLabel7 = new Duke4.Logistica.LblBase();
            this.myLabel8 = new Duke4.Logistica.LblBase();
            this.Mkbcelular = new Duke4.Logistica.MskTelefono();
            this.Mkbfax = new Duke4.Logistica.MskTelefono();
            this.Mkbtelefono = new Duke4.Logistica.MskTelefono();
            this.myLabel9 = new Duke4.Logistica.LblBase();
            this.myLabel10 = new Duke4.Logistica.LblBase();
            this.Txtruta = new Duke4.Logistica.TxtMayuscula();
            this.Mkbrncced = new Duke4.Logistica.MskRncCedula();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormTitle
            // 
            this.FormTitle.ForeColor = System.Drawing.Color.White;
            // 
            // Txtnombre
            // 
            this.Txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtnombre.Location = new System.Drawing.Point(158, 42);
            this.Txtnombre.Name = "Txtnombre";
            this.Txtnombre.Size = new System.Drawing.Size(439, 23);
            this.Txtnombre.TabIndex = 9;
            this.Txtnombre.TextChanged += new System.EventHandler(this.Txtnombre_TextChanged);
            this.Txtnombre.Enter += new System.EventHandler(this.Txtnombre_Enter);
            this.Txtnombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtnombre_KeyDown);
            this.Txtnombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtnombre_KeyUp);
            this.Txtnombre.Leave += new System.EventHandler(this.Txtnombre_Leave);
            // 
            // MainGrid
            // 
            this.MainGrid.AllowUserToAddRows = false;
            this.MainGrid.AllowUserToDeleteRows = false;
            this.MainGrid.AllowUserToOrderColumns = true;
            this.MainGrid.AllowUserToResizeColumns = false;
            this.MainGrid.AllowUserToResizeRows = false;
            this.MainGrid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.MainGrid.Location = new System.Drawing.Point(158, 62);
            this.MainGrid.Margin = new System.Windows.Forms.Padding(4);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.ReadOnly = true;
            this.MainGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainGrid.RowHeadersVisible = false;
            this.MainGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainGrid.Size = new System.Drawing.Size(674, 294);
            this.MainGrid.TabIndex = 10;
            this.MainGrid.TabStop = false;
            this.MainGrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.MainGrid_CellPainting);
            this.MainGrid.SelectionChanged += new System.EventHandler(this.MainGrid_SelectionChanged);
            this.MainGrid.DoubleClick += new System.EventHandler(this.MainGrid_DoubleClick);
            this.MainGrid.Enter += new System.EventHandler(this.MainGrid_Enter);
            this.MainGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainGrid_KeyDown);
            this.MainGrid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainGrid_KeyUp);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "nombre";
            this.Column1.FillWeight = 180F;
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 409;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "idcliente";
            this.Column2.FillWeight = 50F;
            this.Column2.HeaderText = "Código";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 114;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "telefono";
            this.Column3.FillWeight = 65F;
            this.Column3.HeaderText = "Teléfono";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 148;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.aToolStripMenuItem1,
            this.toolStripTextBox1,
            this.BtnSeleccionar,
            this.BtnCancelar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(153, 492);
            this.menuStrip1.TabIndex = 11;
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
            this.aToolStripMenuItem1.Enabled = false;
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
            this.toolStripTextBox1.Size = new System.Drawing.Size(189, 24);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.AutoSize = false;
            this.BtnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSeleccionar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.BtnSeleccionar.Size = new System.Drawing.Size(150, 30);
            this.BtnSeleccionar.Text = "Seleccionar [F2]";
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
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
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel1.ForeColor = System.Drawing.Color.Black;
            this.myLabel1.Location = new System.Drawing.Point(604, 42);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(78, 16);
            this.myLabel1.TabIndex = 12;
            this.myLabel1.Text = "Buscar por";
            // 
            // Cmbbuscarpor
            // 
            this.Cmbbuscarpor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmbbuscarpor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbbuscarpor.FormattingEnabled = true;
            this.Cmbbuscarpor.Items.AddRange(new object[] {
            "Nombre",
            "Código",
            "RNC / Cedula",
            "Teléfono",
            "Email",
            "Celular",
            "Fax"});
            this.Cmbbuscarpor.Location = new System.Drawing.Point(678, 41);
            this.Cmbbuscarpor.Name = "Cmbbuscarpor";
            this.Cmbbuscarpor.ReadOnly = false;
            this.Cmbbuscarpor.Size = new System.Drawing.Size(154, 24);
            this.Cmbbuscarpor.TabIndex = 13;
            this.Cmbbuscarpor.TabStop = false;
            this.Cmbbuscarpor.SelectedIndexChanged += new System.EventHandler(this.Cmbbuscarpor_SelectedIndexChanged);
            // 
            // Txtdireccion
            // 
            this.Txtdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtdireccion.Enabled = false;
            this.Txtdireccion.Location = new System.Drawing.Point(157, 379);
            this.Txtdireccion.Name = "Txtdireccion";
            this.Txtdireccion.Size = new System.Drawing.Size(304, 23);
            this.Txtdireccion.TabIndex = 14;
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(154, 360);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(68, 16);
            this.myLabel2.TabIndex = 15;
            this.myLabel2.Text = "Dirección";
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(153, 402);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(52, 16);
            this.myLabel3.TabIndex = 16;
            this.myLabel3.Text = "Ciudad";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(154, 451);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(69, 16);
            this.myLabel4.TabIndex = 17;
            this.myLabel4.Text = "Vendedor";
            // 
            // Txtciudad
            // 
            this.Txtciudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtciudad.Enabled = false;
            this.Txtciudad.Location = new System.Drawing.Point(156, 421);
            this.Txtciudad.Name = "Txtciudad";
            this.Txtciudad.Size = new System.Drawing.Size(305, 23);
            this.Txtciudad.TabIndex = 18;
            // 
            // Txtvendedor
            // 
            this.Txtvendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtvendedor.Enabled = false;
            this.Txtvendedor.Location = new System.Drawing.Point(157, 468);
            this.Txtvendedor.Name = "Txtvendedor";
            this.Txtvendedor.Size = new System.Drawing.Size(305, 23);
            this.Txtvendedor.TabIndex = 19;
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = true;
            this.myLabel5.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel5.ForeColor = System.Drawing.Color.Black;
            this.myLabel5.Location = new System.Drawing.Point(467, 360);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(41, 16);
            this.myLabel5.TabIndex = 20;
            this.myLabel5.Text = "Email";
            // 
            // Txtemail
            // 
            this.Txtemail.Enabled = false;
            this.Txtemail.Location = new System.Drawing.Point(470, 379);
            this.Txtemail.Name = "Txtemail";
            this.Txtemail.Size = new System.Drawing.Size(361, 23);
            this.Txtemail.TabIndex = 21;
            // 
            // myLabel6
            // 
            this.myLabel6.AutoSize = true;
            this.myLabel6.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel6.ForeColor = System.Drawing.Color.Black;
            this.myLabel6.Location = new System.Drawing.Point(467, 402);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Size = new System.Drawing.Size(64, 16);
            this.myLabel6.TabIndex = 22;
            this.myLabel6.Text = "Teléfono";
            // 
            // myLabel7
            // 
            this.myLabel7.AutoSize = true;
            this.myLabel7.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel7.ForeColor = System.Drawing.Color.Black;
            this.myLabel7.Location = new System.Drawing.Point(582, 402);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.Size = new System.Drawing.Size(30, 16);
            this.myLabel7.TabIndex = 23;
            this.myLabel7.Text = "Fax";
            // 
            // myLabel8
            // 
            this.myLabel8.AutoSize = true;
            this.myLabel8.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel8.ForeColor = System.Drawing.Color.Black;
            this.myLabel8.Location = new System.Drawing.Point(708, 402);
            this.myLabel8.Name = "myLabel8";
            this.myLabel8.Size = new System.Drawing.Size(52, 16);
            this.myLabel8.TabIndex = 24;
            this.myLabel8.Text = "Celular";
            // 
            // Mkbcelular
            // 
            this.Mkbcelular.Enabled = false;
            this.Mkbcelular.Location = new System.Drawing.Point(711, 421);
            this.Mkbcelular.Mask = "(000)-000-0000";
            this.Mkbcelular.Name = "Mkbcelular";
            this.Mkbcelular.Size = new System.Drawing.Size(120, 23);
            this.Mkbcelular.TabIndex = 26;
            // 
            // Mkbfax
            // 
            this.Mkbfax.Enabled = false;
            this.Mkbfax.Location = new System.Drawing.Point(585, 421);
            this.Mkbfax.Mask = "(000)-000-0000";
            this.Mkbfax.Name = "Mkbfax";
            this.Mkbfax.Size = new System.Drawing.Size(120, 23);
            this.Mkbfax.TabIndex = 27;
            // 
            // Mkbtelefono
            // 
            this.Mkbtelefono.Enabled = false;
            this.Mkbtelefono.Location = new System.Drawing.Point(470, 421);
            this.Mkbtelefono.Mask = "(000)-000-0000";
            this.Mkbtelefono.Name = "Mkbtelefono";
            this.Mkbtelefono.Size = new System.Drawing.Size(109, 23);
            this.Mkbtelefono.TabIndex = 28;
            // 
            // myLabel9
            // 
            this.myLabel9.AutoSize = true;
            this.myLabel9.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel9.ForeColor = System.Drawing.Color.Black;
            this.myLabel9.Location = new System.Drawing.Point(467, 451);
            this.myLabel9.Name = "myLabel9";
            this.myLabel9.Size = new System.Drawing.Size(38, 16);
            this.myLabel9.TabIndex = 29;
            this.myLabel9.Text = "Ruta";
            // 
            // myLabel10
            // 
            this.myLabel10.AutoSize = true;
            this.myLabel10.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.myLabel10.ForeColor = System.Drawing.Color.Black;
            this.myLabel10.Location = new System.Drawing.Point(708, 449);
            this.myLabel10.Name = "myLabel10";
            this.myLabel10.Size = new System.Drawing.Size(89, 16);
            this.myLabel10.TabIndex = 30;
            this.myLabel10.Text = "RNC/ Cedula";
            // 
            // Txtruta
            // 
            this.Txtruta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtruta.Enabled = false;
            this.Txtruta.Location = new System.Drawing.Point(470, 468);
            this.Txtruta.Name = "Txtruta";
            this.Txtruta.Size = new System.Drawing.Size(235, 23);
            this.Txtruta.TabIndex = 31;
            // 
            // Mkbrncced
            // 
            this.Mkbrncced.Enabled = false;
            this.Mkbrncced.Location = new System.Drawing.Point(711, 468);
            this.Mkbrncced.Mask = "000-0000000-0";
            this.Mkbrncced.Name = "Mkbrncced";
            this.Mkbrncced.Size = new System.Drawing.Size(120, 23);
            this.Mkbrncced.TabIndex = 32;
            // 
            // MFConsulta_Cliente
            // 
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(840, 492);
            this.Controls.Add(this.Mkbrncced);
            this.Controls.Add(this.Txtruta);
            this.Controls.Add(this.myLabel10);
            this.Controls.Add(this.myLabel9);
            this.Controls.Add(this.Mkbtelefono);
            this.Controls.Add(this.Mkbfax);
            this.Controls.Add(this.Mkbcelular);
            this.Controls.Add(this.myLabel8);
            this.Controls.Add(this.myLabel7);
            this.Controls.Add(this.myLabel6);
            this.Controls.Add(this.Txtemail);
            this.Controls.Add(this.myLabel5);
            this.Controls.Add(this.Txtvendedor);
            this.Controls.Add(this.Txtciudad);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.Txtdireccion);
            this.Controls.Add(this.Cmbbuscarpor);
            this.Controls.Add(this.myLabel1);
            this.Controls.Add(this.Txtnombre);
            this.Controls.Add(this.MainGrid);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MFConsulta_Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MFConsulta_Cliente_FormClosing);
            this.Load += new System.EventHandler(this.MFConsulta_Cliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MFConsulta_Cliente_KeyDown);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.MainGrid, 0);
            this.Controls.SetChildIndex(this.Txtnombre, 0);
            this.Controls.SetChildIndex(this.myLabel1, 0);
            this.Controls.SetChildIndex(this.Cmbbuscarpor, 0);
            this.Controls.SetChildIndex(this.Txtdireccion, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.myLabel3, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.Txtciudad, 0);
            this.Controls.SetChildIndex(this.Txtvendedor, 0);
            this.Controls.SetChildIndex(this.myLabel5, 0);
            this.Controls.SetChildIndex(this.Txtemail, 0);
            this.Controls.SetChildIndex(this.myLabel6, 0);
            this.Controls.SetChildIndex(this.myLabel7, 0);
            this.Controls.SetChildIndex(this.myLabel8, 0);
            this.Controls.SetChildIndex(this.Mkbcelular, 0);
            this.Controls.SetChildIndex(this.Mkbfax, 0);
            this.Controls.SetChildIndex(this.Mkbtelefono, 0);
            this.Controls.SetChildIndex(this.myLabel9, 0);
            this.Controls.SetChildIndex(this.myLabel10, 0);
            this.Controls.SetChildIndex(this.Txtruta, 0);
            this.Controls.SetChildIndex(this.Mkbrncced, 0);
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Logistica.TxtMayuscula Txtnombre;
        public System.Windows.Forms.DataGridView MainGrid;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem BtnSeleccionar;
        private System.Windows.Forms.ToolStripMenuItem BtnCancelar;
        private Logistica.LblBase myLabel1;
        private Logistica.CmbBase Cmbbuscarpor;
        private Logistica.TxtMayuscula Txtdireccion;
        private Logistica.LblBase myLabel2;
        private Logistica.LblBase myLabel3;
        private Logistica.LblBase myLabel4;
        private Logistica.TxtMayuscula Txtciudad;
        private Logistica.TxtMayuscula Txtvendedor;
        private Logistica.LblBase myLabel5;
        private Logistica.TxtCorreo Txtemail;
        private Logistica.LblBase myLabel6;
        private Logistica.LblBase myLabel7;
        private Logistica.LblBase myLabel8;
        private Logistica.MskTelefono Mkbcelular;
        private Logistica.MskTelefono Mkbfax;
        private Logistica.MskTelefono Mkbtelefono;
        private Logistica.LblBase myLabel9;
        private Logistica.LblBase myLabel10;
        private Logistica.TxtMayuscula Txtruta;
        private Logistica.MskRncCedula Mkbrncced;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
