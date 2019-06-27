namespace Duke4
{
    partial class MainBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBar));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.BtnHelp = new System.Windows.Forms.Label();
            this.FormTitle = new Duke4.Logistica.LblGrandeNgta();
            this.label3 = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.HeaderPanel.Controls.Add(this.BtnHelp);
            this.HeaderPanel.Controls.Add(this.FormTitle);
            this.HeaderPanel.Controls.Add(this.label3);
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(4);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Padding = new System.Windows.Forms.Padding(3);
            this.HeaderPanel.Size = new System.Drawing.Size(1300, 38);
            this.HeaderPanel.TabIndex = 8;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            this.HeaderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseMove);
            this.HeaderPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseUp);
            // 
            // BtnHelp
            // 
            this.BtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("BtnHelp.Image")));
            this.BtnHelp.Location = new System.Drawing.Point(1232, 0);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(40, 35);
            this.BtnHelp.TabIndex = 9;
            this.BtnHelp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnHelp_MouseDown);
            this.BtnHelp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnHelp_MouseMove);
            this.BtnHelp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnHelp_MouseUp);
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.FormTitle.ForeColor = System.Drawing.Color.White;
            this.FormTitle.Location = new System.Drawing.Point(12, 9);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(0, 23);
            this.FormTitle.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 35);
            this.label3.TabIndex = 3;
            // 
            // MainBar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 452);
            this.ControlBox = false;
            this.Controls.Add(this.HeaderPanel);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainBar_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainBar_Paint);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BtnHelp;
        public Logistica.LblGrandeNgta FormTitle;
        private System.Windows.Forms.Panel HeaderPanel;
    }
}