namespace Duke4
{
    partial class MainFormReportes
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
            this.components = new System.ComponentModel.Container();
            this.BtnHelp = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblGrande2 = new Duke4.Logistica.LblGrande();
            this.lblGrande1 = new Duke4.Logistica.LblGrande();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BtnCrear = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbsformato = new CustomListBox.sListBox();
            this.gendbfformatoreporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSGEN = new Duke4.DataSet_General.DSGEN();
            this.Lbsorden = new CustomListBox.sListBox();
            this.gendbfformatoreporteTableAdapter = new Duke4.DataSet_General.DSGENTableAdapters.gendbfformatoreporteTableAdapter();
            this.ordenTableAdapter1 = new Duke4.DataSet_General.DSGENTableAdapters.OrdenTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gendbfformatoreporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGEN)).BeginInit();
            this.SuspendLayout();
            // 
            // FormTitle
            // 
            this.FormTitle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormTitle.Location = new System.Drawing.Point(16, 0);
            this.FormTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FormTitle.Size = new System.Drawing.Size(59, 18);
            this.FormTitle.TabIndex = 0;
            this.FormTitle.Text = "labels1";
            this.FormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnHelp
            // 
            this.BtnHelp.Location = new System.Drawing.Point(883, 0);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(62, 38);
            this.BtnHelp.TabIndex = 2;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // lblGrande2
            // 
            this.lblGrande2.AutoSize = true;
            this.lblGrande2.Font = new System.Drawing.Font("Verdana", 14F);
            this.lblGrande2.ForeColor = System.Drawing.Color.Black;
            this.lblGrande2.Location = new System.Drawing.Point(323, 107);
            this.lblGrande2.Name = "lblGrande2";
            this.lblGrande2.Size = new System.Drawing.Size(126, 23);
            this.lblGrande2.TabIndex = 83;
            this.lblGrande2.Text = "Ordenar por";
            // 
            // lblGrande1
            // 
            this.lblGrande1.AutoSize = true;
            this.lblGrande1.Font = new System.Drawing.Font("Verdana", 14F);
            this.lblGrande1.ForeColor = System.Drawing.Color.Black;
            this.lblGrande1.Location = new System.Drawing.Point(5, 107);
            this.lblGrande1.Name = "lblGrande1";
            this.lblGrande1.Size = new System.Drawing.Size(99, 23);
            this.lblGrande1.TabIndex = 81;
            this.lblGrande1.Text = "Formatos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCrear,
            this.BtnCancelar});
            this.menuStrip1.Location = new System.Drawing.Point(1, 40);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(956, 57);
            this.menuStrip1.TabIndex = 79;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BtnCrear
            // 
            this.BtnCrear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrear.Image = global::Duke4.Properties.Resources.statistics;
            this.BtnCrear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCrear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnCrear.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.BtnCrear.Size = new System.Drawing.Size(115, 50);
            this.BtnCrear.Text = "Presentar [F3]";
            this.BtnCrear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = global::Duke4.Properties.Resources.retornar32;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(114, 50);
            this.BtnCancelar.Text = "Retornar [Esc]";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Lbsformato
            // 
            this.Lbsformato.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Lbsformato.BorderColor = System.Drawing.Color.Gray;
            this.Lbsformato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbsformato.CheckedIcon = null;
            this.Lbsformato.DarkFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(157)))));
            this.Lbsformato.DarkSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(157)))));
            this.Lbsformato.DataSource = this.gendbfformatoreporteBindingSource;
            this.Lbsformato.DisplayMember = "descripcion";
            this.Lbsformato.FormattingEnabled = true;
            this.Lbsformato.IsDragging = false;
            this.Lbsformato.ItemHeight = 22;
            this.Lbsformato.ItemStyle = CustomListBox.sListBox.Style.MacStyle;
            this.Lbsformato.LightedColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.Lbsformato.LightedFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(157)))));
            this.Lbsformato.LightedSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(157)))));
            this.Lbsformato.Location = new System.Drawing.Point(9, 133);
            this.Lbsformato.Name = "Lbsformato";
            this.Lbsformato.ShowScrollbar = true;
            this.Lbsformato.Size = new System.Drawing.Size(312, 82);
            this.Lbsformato.TabIndex = 84;
            this.Lbsformato.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbsformato.ValueMember = "idformato";
            this.Lbsformato.SelectedIndexChanged += new System.EventHandler(this.Lsbformato_SelectedIndexChanged);
            // 
            // gendbfformatoreporteBindingSource
            // 
            this.gendbfformatoreporteBindingSource.DataMember = "gendbfformatoreporte";
            this.gendbfformatoreporteBindingSource.DataSource = this.dSGEN;
            // 
            // dSGEN
            // 
            this.dSGEN.DataSetName = "DSGEN";
            this.dSGEN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Lbsorden
            // 
            this.Lbsorden.AllowDrop = true;
            this.Lbsorden.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Lbsorden.BorderColor = System.Drawing.Color.Gray;
            this.Lbsorden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbsorden.CheckedIcon = null;
            this.Lbsorden.DarkFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(157)))));
            this.Lbsorden.DarkSelectedColor = System.Drawing.Color.Empty;
            this.Lbsorden.FormattingEnabled = true;
            this.Lbsorden.IsDragging = false;
            this.Lbsorden.ItemHeight = 22;
            this.Lbsorden.ItemStyle = CustomListBox.sListBox.Style.MacStyle;
            this.Lbsorden.LightedColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.Lbsorden.LightedFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(157)))));
            this.Lbsorden.LightedSelectedColor = System.Drawing.Color.Empty;
            this.Lbsorden.Location = new System.Drawing.Point(327, 133);
            this.Lbsorden.Name = "Lbsorden";
            this.Lbsorden.ShowScrollbar = true;
            this.Lbsorden.Size = new System.Drawing.Size(312, 82);
            this.Lbsorden.TabIndex = 85;
            this.Lbsorden.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbsorden.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Lbsorden_DrawItem);
            this.Lbsorden.SelectedIndexChanged += new System.EventHandler(this.Lbsorden_SelectedIndexChanged);
            this.Lbsorden.DragDrop += new System.Windows.Forms.DragEventHandler(this.Lbsorden_DragDrop);
            this.Lbsorden.DragOver += new System.Windows.Forms.DragEventHandler(this.Lbsorden_DragOver);
            this.Lbsorden.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lbsorden_MouseDown);
            this.Lbsorden.MouseLeave += new System.EventHandler(this.Lbsorden_MouseLeave);
            this.Lbsorden.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Lbsorden_MouseMove);
            // 
            // gendbfformatoreporteTableAdapter
            // 
            this.gendbfformatoreporteTableAdapter.ClearBeforeFill = true;
            // 
            // ordenTableAdapter1
            // 
            this.ordenTableAdapter1.ClearBeforeFill = true;
            // 
            // MainFormReportes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(671, 574);
            this.Controls.Add(this.Lbsorden);
            this.Controls.Add(this.Lbsformato);
            this.Controls.Add(this.lblGrande2);
            this.Controls.Add(this.lblGrande1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainFormReportes";
            this.Load += new System.EventHandler(this.MainFormReportes_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.lblGrande1, 0);
            this.Controls.SetChildIndex(this.lblGrande2, 0);
            this.Controls.SetChildIndex(this.Lbsformato, 0);
            this.Controls.SetChildIndex(this.Lbsorden, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gendbfformatoreporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGEN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private Logistica.LblBase FormTitle;
        private System.Windows.Forms.Label BtnHelp;
        public System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem BtnCrear;
        public System.Windows.Forms.ToolStripMenuItem BtnCancelar;
        private System.Windows.Forms.BindingSource gendbfformatoreporteBindingSource;
        private DataSet_General.DSGEN dSGEN;
        private DataSet_General.DSGENTableAdapters.gendbfformatoreporteTableAdapter gendbfformatoreporteTableAdapter;
        public CustomListBox.sListBox Lbsformato;
        public CustomListBox.sListBox Lbsorden;
        private DataSet_General.DSGENTableAdapters.OrdenTableAdapter ordenTableAdapter1;
        public Logistica.LblGrande lblGrande2;
        public Logistica.LblGrande lblGrande1;
    }
}