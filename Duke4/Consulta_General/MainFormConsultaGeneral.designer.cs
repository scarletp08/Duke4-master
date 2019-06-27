namespace Duke4.Consulta_General
{
    partial class MainFormConsultaGeneral
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.BtnSeleccionar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtNombre = new Duke4.Logistica.TxtMayuscula();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FormTitle
            // 
            this.FormTitle.ForeColor = System.Drawing.Color.White;
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
            this.menuStrip1.Size = new System.Drawing.Size(153, 422);
            this.menuStrip1.TabIndex = 8;
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
            // MainGrid
            // 
            this.MainGrid.AllowUserToAddRows = false;
            this.MainGrid.AllowUserToDeleteRows = false;
            this.MainGrid.AllowUserToOrderColumns = true;
            this.MainGrid.AllowUserToResizeColumns = false;
            this.MainGrid.AllowUserToResizeRows = false;
            this.MainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainGrid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.MainGrid.Location = new System.Drawing.Point(169, 114);
            this.MainGrid.Margin = new System.Windows.Forms.Padding(4);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.ReadOnly = true;
            this.MainGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainGrid.RowHeadersVisible = false;
            this.MainGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainGrid.Size = new System.Drawing.Size(440, 294);
            this.MainGrid.TabIndex = 2;
            this.MainGrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.MainGrid_CellPainting);
            this.MainGrid.DoubleClick += new System.EventHandler(this.MainGrid_DoubleClick);
            this.MainGrid.Enter += new System.EventHandler(this.MainGrid_Enter);
            this.MainGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainGrid_KeyDown);
            this.MainGrid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainGrid_KeyUp);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "codigo";
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "descripcion";
            this.Column2.HeaderText = "Descripción";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // TxtNombre
            // 
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Location = new System.Drawing.Point(169, 84);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(440, 23);
            this.TxtNombre.TabIndex = 1;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            this.TxtNombre.Enter += new System.EventHandler(this.TxtNombre_Enter);
            this.TxtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNombre_KeyDown);
            this.TxtNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtNombre_KeyUp);
            this.TxtNombre.Leave += new System.EventHandler(this.TxtNombre_Leave);
            // 
            // MainFormConsultaGeneral
            // 
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(635, 422);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.MainGrid);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainFormConsultaGeneral";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormConsultaGeneral_FormClosing);
            this.Load += new System.EventHandler(this.MainFormConsultaGenerales_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormConsultaGenerales_KeyDown);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.MainGrid, 0);
            this.Controls.SetChildIndex(this.TxtNombre, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem BtnSeleccionar;
        private System.Windows.Forms.ToolStripMenuItem BtnCancelar;
        public System.Windows.Forms.DataGridView MainGrid;
        private Logistica.TxtMayuscula TxtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
