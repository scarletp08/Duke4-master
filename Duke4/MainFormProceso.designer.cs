namespace Duke4
{
    partial class MainFormProceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormProceso));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LblFunctionName = new System.Windows.Forms.Label();
            this.BtnHelp = new System.Windows.Forms.Label();
            this.LblAlerta = new Duke4.Logistica.LblGrandeNgta();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.BtnSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCrear = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnBlanquear = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MainPanel.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormTitle
            // 
            this.FormTitle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormTitle.Location = new System.Drawing.Point(4, 9);
            this.FormTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FormTitle.Size = new System.Drawing.Size(59, 18);
            this.FormTitle.TabIndex = 0;
            this.FormTitle.Text = "labels1";
            this.FormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Controls.Add(this.LblFunctionName);
            this.MainPanel.Location = new System.Drawing.Point(1, 110);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(766, 332);
            this.MainPanel.TabIndex = 7;
            // 
            // LblFunctionName
            // 
            this.LblFunctionName.AutoSize = true;
            this.LblFunctionName.BackColor = System.Drawing.Color.Transparent;
            this.LblFunctionName.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFunctionName.Location = new System.Drawing.Point(496, 3);
            this.LblFunctionName.Name = "LblFunctionName";
            this.LblFunctionName.Size = new System.Drawing.Size(63, 32);
            this.LblFunctionName.TabIndex = 67;
            this.LblFunctionName.Text = "aaa";
            // 
            // BtnHelp
            // 
            this.BtnHelp.Location = new System.Drawing.Point(883, 0);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(62, 38);
            this.BtnHelp.TabIndex = 2;
            // 
            // LblAlerta
            // 
            this.LblAlerta.AutoSize = true;
            this.LblAlerta.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.LblAlerta.ForeColor = System.Drawing.Color.Black;
            this.LblAlerta.Image = ((System.Drawing.Image)(resources.GetObject("LblAlerta.Image")));
            this.LblAlerta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblAlerta.Location = new System.Drawing.Point(4, 456);
            this.LblAlerta.Name = "LblAlerta";
            this.LblAlerta.Size = new System.Drawing.Size(97, 23);
            this.LblAlerta.TabIndex = 72;
            this.LblAlerta.Text = "letrero1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.AllowMerge = false;
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSalvar,
            this.BtnModificar,
            this.BtnCrear,
            this.BtnBlanquear,
            this.BtnCancelar});
            this.menuStrip2.Location = new System.Drawing.Point(0, 39);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip2.Size = new System.Drawing.Size(1210, 62);
            this.menuStrip2.TabIndex = 73;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Image = global::Duke4.Properties.Resources.salbar32;
            this.BtnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.BtnSalvar.Size = new System.Drawing.Size(93, 55);
            this.BtnSalvar.Text = "Salvar [F5]";
            this.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnSalvar.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Image = global::Duke4.Properties.Resources.modificar32;
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.BtnModificar.Size = new System.Drawing.Size(111, 55);
            this.BtnModificar.Text = "Modificar [F3]";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnModificar.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // BtnCrear
            // 
            this.BtnCrear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrear.Image = global::Duke4.Properties.Resources.crear32;
            this.BtnCrear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCrear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnCrear.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.BtnCrear.Size = new System.Drawing.Size(87, 55);
            this.BtnCrear.Text = "Crear [F6]";
            this.BtnCrear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnCrear.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // BtnBlanquear
            // 
            this.BtnBlanquear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBlanquear.Image = global::Duke4.Properties.Resources.mop;
            this.BtnBlanquear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBlanquear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnBlanquear.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnBlanquear.Name = "BtnBlanquear";
            this.BtnBlanquear.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.BtnBlanquear.Size = new System.Drawing.Size(117, 55);
            this.BtnBlanquear.Text = "Blanquear [F6]";
            this.BtnBlanquear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBlanquear.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnBlanquear.Click += new System.EventHandler(this.BtnBlanquear_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = global::Duke4.Properties.Resources.retornar32;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(114, 55);
            this.BtnCancelar.Text = "Retornar [Esc]";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnCancelar.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(2, 442);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 11);
            this.panel2.TabIndex = 74;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 58);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // MainFormProceso
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(768, 691);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.LblAlerta);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainFormProceso";
            this.Load += new System.EventHandler(this.MainFormProceso_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormProceso_KeyDown);
            this.Controls.SetChildIndex(this.MainPanel, 0);
            this.Controls.SetChildIndex(this.LblAlerta, 0);
            this.Controls.SetChildIndex(this.menuStrip2, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private Logistica.LblBase FormTitle;
        private System.Windows.Forms.Label BtnHelp;
        public System.Windows.Forms.Panel MainPanel;
        public Logistica.LblGrandeNgta LblAlerta;
        public System.Windows.Forms.Label LblFunctionName;
        public System.Windows.Forms.MenuStrip menuStrip2;
        public System.Windows.Forms.ToolStripMenuItem BtnCrear;
        public System.Windows.Forms.ToolStripMenuItem BtnModificar;
        public System.Windows.Forms.ToolStripMenuItem BtnSalvar;
        public System.Windows.Forms.ToolStripMenuItem BtnCancelar;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem BtnBlanquear;
        public System.Windows.Forms.ToolTip toolTip1;
    }
}