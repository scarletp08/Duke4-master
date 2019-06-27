namespace Duke4._newDesign
{
    partial class _ConsultaGeneral
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BtnSeleccionar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRetornar = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtNombre = new Duke4.Logistica.TxtMayuscula();
            this.txtCodigo = new Duke4.Logistica.TxtEntero();
            this.MainGrid = new Duke4.Logistica.GridBase();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
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
            this.BtnSeleccionar,
            this.BtnRetornar});
            this.menuStrip1.Location = new System.Drawing.Point(1, 38);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(634, 62);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Paint += new System.Windows.Forms.PaintEventHandler(this.menuStrip1_Paint);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.Image = global::Duke4.Properties.Resources.tap;
            this.BtnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSeleccionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnSeleccionar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.BtnSeleccionar.Size = new System.Drawing.Size(127, 55);
            this.BtnSeleccionar.Text = "Seleccionar [F2]";
            this.BtnSeleccionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click_1);
            // 
            // BtnRetornar
            // 
            this.BtnRetornar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetornar.Image = global::Duke4.Properties.Resources.retornar32;
            this.BtnRetornar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRetornar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnRetornar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnRetornar.Name = "BtnRetornar";
            this.BtnRetornar.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.BtnRetornar.Size = new System.Drawing.Size(114, 55);
            this.BtnRetornar.Text = "Retornar [Esc]";
            this.BtnRetornar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRetornar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnRetornar.Click += new System.EventHandler(this.BtnRetornar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Location = new System.Drawing.Point(16, 105);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(343, 23);
            this.TxtNombre.TabIndex = 0;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            this.TxtNombre.Enter += new System.EventHandler(this.TxtNombre_Enter);
            this.TxtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNombre_KeyDown);
            this.TxtNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtNombre_KeyUp);
            this.TxtNombre.Leave += new System.EventHandler(this.TxtNombre_Leave);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(365, 105);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(91, 23);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtEntero1_TextChanged);
            this.txtCodigo.Enter += new System.EventHandler(this.txtCodigo_Enter);
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            this.txtCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyUp);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // MainGrid
            // 
            this.MainGrid.AllowUserToAddRows = false;
            this.MainGrid.AllowUserToDeleteRows = false;
            this.MainGrid.AllowUserToResizeColumns = false;
            this.MainGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.MainGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.MainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainGrid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 7.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.MainGrid.Location = new System.Drawing.Point(16, 134);
            this.MainGrid.MultiSelect = false;
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.RowHeadersVisible = false;
            this.MainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainGrid.Size = new System.Drawing.Size(440, 294);
            this.MainGrid.TabIndex = 9;
            this.MainGrid.DoubleClick += new System.EventHandler(this.MainGrid_DoubleClick);
            this.MainGrid.Enter += new System.EventHandler(this.MainGrid_Enter);
            this.MainGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainGrid_KeyDown);
            this.MainGrid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainGrid_KeyUp);
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "descripcion";
            this.Column3.FillWeight = 400F;
            this.Column3.HeaderText = "Descripción";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "codigo";
            this.Column4.HeaderText = "Código";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // _ConsultaGeneral
            // 
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 458);
            this.Controls.Add(this.MainGrid);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.menuStrip1);
            this.Name = "_ConsultaGeneral";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormConsultaGeneral_FormClosing);
            this.Load += new System.EventHandler(this.MainFormConsultaGenerales_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormConsultaGenerales_KeyDown);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.TxtNombre, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.MainGrid, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        private Logistica.TxtMayuscula TxtNombre;
        public System.Windows.Forms.ToolStripMenuItem BtnSeleccionar;
        public System.Windows.Forms.ToolStripMenuItem BtnRetornar;
        private Logistica.TxtEntero txtCodigo;
        private Logistica.GridBase MainGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
