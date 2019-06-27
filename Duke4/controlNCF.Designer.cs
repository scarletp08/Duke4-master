namespace Duke4
{
    partial class controlNCF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gridBase1 = new Duke4.Logistica.GridBase();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvidncf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBase1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.gridBase1);
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 123);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = global::Duke4.Properties.Resources.barracontrol;
            this.button1.Location = new System.Drawing.Point(-1, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 15);
            this.button1.TabIndex = 351;
            this.toolTip1.SetToolTip(this.button1, "Cerrar ventana");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(95, 20);
            this.panel3.TabIndex = 10;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Duke4.Properties.Resources.abajoazul11;
            this.pictureBox5.Location = new System.Drawing.Point(79, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(11, 11);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Duke4.Properties.Resources.abajo11;
            this.pictureBox4.Location = new System.Drawing.Point(79, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(11, 11);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "Abrir ventana NCF");
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // gridBase1
            // 
            this.gridBase1.AllowUserToAddRows = false;
            this.gridBase1.AllowUserToDeleteRows = false;
            this.gridBase1.AllowUserToResizeColumns = false;
            this.gridBase1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gridBase1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridBase1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBase1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridBase1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBase1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dgvcodigo,
            this.dgvidncf});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 7.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBase1.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridBase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBase1.Location = new System.Drawing.Point(0, 0);
            this.gridBase1.MultiSelect = false;
            this.gridBase1.Name = "gridBase1";
            this.gridBase1.RowHeadersVisible = false;
            this.gridBase1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBase1.Size = new System.Drawing.Size(225, 121);
            this.gridBase1.TabIndex = 350;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "descripcion";
            this.Column1.FillWeight = 121.9434F;
            this.Column1.HeaderText = "Tipo de NCF";
            this.Column1.MinimumWidth = 150;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvcodigo
            // 
            this.dgvcodigo.DataPropertyName = "tipo";
            this.dgvcodigo.FillWeight = 38.20893F;
            this.dgvcodigo.HeaderText = "Código";
            this.dgvcodigo.MinimumWidth = 45;
            this.dgvcodigo.Name = "dgvcodigo";
            this.dgvcodigo.ReadOnly = true;
            this.dgvcodigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvidncf
            // 
            this.dgvidncf.DataPropertyName = "idncf";
            this.dgvidncf.HeaderText = "Idncf";
            this.dgvidncf.Name = "dgvidncf";
            this.dgvidncf.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvidncf.Visible = false;
            // 
            // controlNCF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(230, 147);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "controlNCF";
            this.Text = "controlNCF";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBase1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Logistica.GridBase gridBase1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvidncf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}