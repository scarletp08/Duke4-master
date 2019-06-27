namespace Duke4
{
    partial class reporteVmenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BtnPresentar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.BtnPresentar,
            this.BtnCancelar});
            this.menuStrip1.Location = new System.Drawing.Point(3, 41);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1210, 55);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BtnPresentar
            // 
            this.BtnPresentar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPresentar.Image = global::Duke4.Properties.Resources.report;
            this.BtnPresentar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPresentar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnPresentar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnPresentar.Name = "BtnPresentar";
            this.BtnPresentar.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.BtnPresentar.Size = new System.Drawing.Size(115, 48);
            this.BtnPresentar.Text = "Presentar [F3]";
            this.BtnPresentar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPresentar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = global::Duke4.Properties.Resources.retornar32;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(114, 48);
            this.BtnCancelar.Text = "Retornar [Esc]";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Order by with RDB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Formats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 267);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Filetrs";
            // 
            // reporteVmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "reporteVmenu";
            this.Text = "reporteVmenu";
            this.Load += new System.EventHandler(this.reporteVmenu_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem BtnPresentar;
        public System.Windows.Forms.ToolStripMenuItem BtnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}