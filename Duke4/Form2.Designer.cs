namespace Duke4
{
    partial class Form2
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
            this.cmbBase1 = new Duke4.Logistica.CmbBase();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbBase1
            // 
            this.cmbBase1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBase1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBase1.FormattingEnabled = true;
            this.cmbBase1.Items.AddRange(new object[] {
            "bye",
            "ok"});
            this.cmbBase1.Location = new System.Drawing.Point(300, 160);
            this.cmbBase1.Name = "cmbBase1";
            this.cmbBase1.ReadOnly = false;
            this.cmbBase1.Size = new System.Drawing.Size(139, 21);
            this.cmbBase1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "klk",
            "wawawa"});
            this.comboBox1.Location = new System.Drawing.Point(481, 310);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "seleccione";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 438);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmbBase1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion
        private Logistica.CmbBase cmbBase1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}