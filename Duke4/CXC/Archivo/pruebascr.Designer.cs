namespace Duke4.CXC.Archivo
{
    partial class pruebascr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pruebascr));
            this.label2 = new System.Windows.Forms.Label();
            this.listcomentarios = new System.Windows.Forms.ListBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblBase1 = new Duke4.Logistica.LblBase();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMayuscula1 = new Duke4.Logistica.TxtMayuscula();
            this.lblBase2 = new Duke4.Logistica.LblBase();
            this.lblBase3 = new Duke4.Logistica.LblBase();
            this.txtEntero1 = new Duke4.Logistica.TxtEntero();
            this.btnBuscar1 = new Duke4.Logistica.BtnBuscar();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainPanel.Controls.Add(this.btnBuscar1);
            this.MainPanel.Controls.Add(this.txtEntero1);
            this.MainPanel.Controls.Add(this.lblBase3);
            this.MainPanel.Controls.Add(this.txtMayuscula1);
            this.MainPanel.Controls.Add(this.lblBase2);
            this.MainPanel.Controls.Add(this.lblBase1);
            this.MainPanel.Controls.Add(this.dataGridView1);
            this.MainPanel.Controls.Add(this.monthCalendar1);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.listcomentarios);
            this.MainPanel.ForeColor = System.Drawing.Color.Coral;
            this.MainPanel.Location = new System.Drawing.Point(164, 43);
            this.MainPanel.Size = new System.Drawing.Size(521, 402);
            this.MainPanel.Controls.SetChildIndex(this.LblEstado, 0);
            this.MainPanel.Controls.SetChildIndex(this.listcomentarios, 0);
            this.MainPanel.Controls.SetChildIndex(this.label2, 0);
            this.MainPanel.Controls.SetChildIndex(this.monthCalendar1, 0);
            this.MainPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase1, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase2, 0);
            this.MainPanel.Controls.SetChildIndex(this.txtMayuscula1, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase3, 0);
            this.MainPanel.Controls.SetChildIndex(this.txtEntero1, 0);
            this.MainPanel.Controls.SetChildIndex(this.btnBuscar1, 0);
            // 
            // LblAlerta
            // 
            this.LblAlerta.Location = new System.Drawing.Point(165, 487);
            this.LblAlerta.Size = new System.Drawing.Size(0, 23);
            this.LblAlerta.Text = "";
            // 
            // LblFunctionName
            // 
            this.LblFunctionName.Location = new System.Drawing.Point(689, 42);
            this.LblFunctionName.Size = new System.Drawing.Size(0, 23);
            this.LblFunctionName.Text = "";
            // 
            // LblEstado
            // 
            this.LblEstado.Size = new System.Drawing.Size(0, 23);
            this.LblEstado.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 647);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 483;
            this.label2.Text = "Observaciones";
            // 
            // listcomentarios
            // 
            this.listcomentarios.FormattingEnabled = true;
            this.listcomentarios.ItemHeight = 16;
            this.listcomentarios.Location = new System.Drawing.Point(1, 665);
            this.listcomentarios.Name = "listcomentarios";
            this.listcomentarios.Size = new System.Drawing.Size(383, 52);
            this.listcomentarios.TabIndex = 482;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(8, 49);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ScrollChange = 1;
            this.monthCalendar1.TabIndex = 19;
            this.monthCalendar1.TodayDate = new System.DateTime(2019, 4, 23, 0, 0, 0, 0);
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.GreenYellow;
            // 
            // lblBase1
            // 
            this.lblBase1.AutoSize = true;
            this.lblBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase1.ForeColor = System.Drawing.Color.Black;
            this.lblBase1.Location = new System.Drawing.Point(167, 222);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(118, 16);
            this.lblBase1.TabIndex = 485;
            this.lblBase1.Text = "Recordatorios....";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(169, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(337, 153);
            this.dataGridView1.TabIndex = 484;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // txtMayuscula1
            // 
            this.txtMayuscula1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtMayuscula1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMayuscula1.Location = new System.Drawing.Point(8, 240);
            this.txtMayuscula1.Multiline = true;
            this.txtMayuscula1.Name = "txtMayuscula1";
            this.txtMayuscula1.Size = new System.Drawing.Size(157, 154);
            this.txtMayuscula1.TabIndex = 487;
            // 
            // lblBase2
            // 
            this.lblBase2.AutoSize = true;
            this.lblBase2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase2.ForeColor = System.Drawing.Color.Black;
            this.lblBase2.Location = new System.Drawing.Point(7, 222);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(83, 16);
            this.lblBase2.TabIndex = 486;
            this.lblBase2.Text = "Descripción";
            // 
            // lblBase3
            // 
            this.lblBase3.AutoSize = true;
            this.lblBase3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase3.ForeColor = System.Drawing.Color.Black;
            this.lblBase3.Location = new System.Drawing.Point(7, 23);
            this.lblBase3.Name = "lblBase3";
            this.lblBase3.Size = new System.Drawing.Size(52, 16);
            this.lblBase3.TabIndex = 488;
            this.lblBase3.Text = "Codigo";
            // 
            // txtEntero1
            // 
            this.txtEntero1.Location = new System.Drawing.Point(61, 20);
            this.txtEntero1.Name = "txtEntero1";
            this.txtEntero1.Size = new System.Drawing.Size(67, 23);
            this.txtEntero1.TabIndex = 489;
            this.txtEntero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBuscar1
            // 
            this.btnBuscar1.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBuscar1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar1.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar1.Image")));
            this.btnBuscar1.Location = new System.Drawing.Point(129, 20);
            this.btnBuscar1.Name = "btnBuscar1";
            this.btnBuscar1.Size = new System.Drawing.Size(45, 23);
            this.btnBuscar1.TabIndex = 490;
            this.btnBuscar1.TabStop = false;
            this.btnBuscar1.Text = " ";
            this.btnBuscar1.UseVisualStyleBackColor = false;
            // 
            // pruebascr
            // 
            this.ClientSize = new System.Drawing.Size(685, 449);
            this.Name = "pruebascr";
            this.Load += new System.EventHandler(this.pruebascr_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listcomentarios;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private Logistica.LblBase lblBase1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Logistica.TxtMayuscula txtMayuscula1;
        private Logistica.LblBase lblBase2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Logistica.BtnBuscar btnBuscar1;
        private Logistica.TxtEntero txtEntero1;
        private Logistica.LblBase lblBase3;
    }
}
