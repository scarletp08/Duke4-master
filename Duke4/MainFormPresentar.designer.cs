namespace Duke4
{
    partial class MainFormPresentar
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
            this.LblFunctionName = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.BtnReImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblFunctionName
            // 
            this.LblFunctionName.AutoSize = true;
            this.LblFunctionName.BackColor = System.Drawing.Color.Transparent;
            this.LblFunctionName.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFunctionName.Location = new System.Drawing.Point(381, 50);
            this.LblFunctionName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFunctionName.Name = "LblFunctionName";
            this.LblFunctionName.Size = new System.Drawing.Size(213, 32);
            this.LblFunctionName.TabIndex = 70;
            this.LblFunctionName.Text = "Presentando...";
            // 
            // menuStrip2
            // 
            this.menuStrip2.AllowMerge = false;
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnReImprimir,
            this.BtnCancelar});
            this.menuStrip2.Location = new System.Drawing.Point(2, 38);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip2.Size = new System.Drawing.Size(1210, 62);
            this.menuStrip2.TabIndex = 74;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // BtnReImprimir
            // 
            this.BtnReImprimir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReImprimir.Image = global::Duke4.Properties.Resources.crear32;
            this.BtnReImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnReImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnReImprimir.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnReImprimir.Name = "BtnReImprimir";
            this.BtnReImprimir.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.BtnReImprimir.Size = new System.Drawing.Size(123, 55);
            this.BtnReImprimir.Text = "Reimprimir [F2]";
            this.BtnReImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnReImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnReImprimir.Click += new System.EventHandler(this.BtnCrear_Click);
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
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // MainFormPresentar
            // 
            this.ClientSize = new System.Drawing.Size(1369, 555);
            this.Controls.Add(this.LblFunctionName);
            this.Controls.Add(this.menuStrip2);
            this.Name = "MainFormPresentar";
            this.Load += new System.EventHandler(this.MainFormPresentar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormPresentar_KeyDown);
            this.Controls.SetChildIndex(this.menuStrip2, 0);
            this.Controls.SetChildIndex(this.LblFunctionName, 0);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label LblFunctionName;
        public System.Windows.Forms.MenuStrip menuStrip2;
        public System.Windows.Forms.ToolStripMenuItem BtnReImprimir;
        public System.Windows.Forms.ToolStripMenuItem BtnCancelar;
    }
}
