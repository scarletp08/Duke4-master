namespace Duke4.CXC.Archivo
{
    partial class Prueba3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prueba3));
            this.Txtcodigo = new Duke4.Logistica.TxtBase();
            this.Txtdescripcion = new Duke4.Logistica.TxtBase();
            this.lblBase1 = new Duke4.Logistica.LblBase();
            this.lblBase2 = new Duke4.Logistica.LblBase();
            this.Btnbuscar = new Duke4.Logistica.BtnBuscar();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.Btnbuscar);
            this.MainPanel.Controls.Add(this.lblBase2);
            this.MainPanel.Controls.Add(this.lblBase1);
            this.MainPanel.Controls.Add(this.Txtdescripcion);
            this.MainPanel.Controls.Add(this.Txtcodigo);
            this.MainPanel.Location = new System.Drawing.Point(1, 130);
            this.MainPanel.Size = new System.Drawing.Size(765, 134);
            this.MainPanel.Controls.SetChildIndex(this.LblEstado, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtcodigo, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtdescripcion, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase1, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase2, 0);
            this.MainPanel.Controls.SetChildIndex(this.Btnbuscar, 0);
            // 
            // LblEstado
            // 
            this.LblEstado.Size = new System.Drawing.Size(0, 23);
            this.LblEstado.Text = "";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 434);
            this.panel2.Size = new System.Drawing.Size(851, 11);
            // 
            // LblAlerta
            // 
            this.LblAlerta.Location = new System.Drawing.Point(5, 451);
            this.LblAlerta.Size = new System.Drawing.Size(0, 23);
            this.LblAlerta.Text = "";
            // 
            // LblFunctionName
            // 
            this.LblFunctionName.Location = new System.Drawing.Point(641, 101);
            this.LblFunctionName.Size = new System.Drawing.Size(158, 32);
            this.LblFunctionName.Text = "Creando...";
            // 
            // Txtcodigo
            // 
            this.Txtcodigo.Location = new System.Drawing.Point(95, 4);
            this.Txtcodigo.Name = "Txtcodigo";
            this.Txtcodigo.Size = new System.Drawing.Size(100, 23);
            this.Txtcodigo.TabIndex = 14;
            this.Txtcodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtcodigo_KeyDown);
            this.Txtcodigo.Validating += new System.ComponentModel.CancelEventHandler(this.Txtcodigo_Validating);
            // 
            // Txtdescripcion
            // 
            this.Txtdescripcion.Location = new System.Drawing.Point(95, 54);
            this.Txtdescripcion.Name = "Txtdescripcion";
            this.Txtdescripcion.Size = new System.Drawing.Size(187, 23);
            this.Txtdescripcion.TabIndex = 15;
            // 
            // lblBase1
            // 
            this.lblBase1.AutoSize = true;
            this.lblBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase1.ForeColor = System.Drawing.Color.Black;
            this.lblBase1.Location = new System.Drawing.Point(16, 7);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(52, 16);
            this.lblBase1.TabIndex = 16;
            this.lblBase1.Text = "Codigo";
            // 
            // lblBase2
            // 
            this.lblBase2.AutoSize = true;
            this.lblBase2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase2.ForeColor = System.Drawing.Color.Black;
            this.lblBase2.Location = new System.Drawing.Point(3, 57);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(83, 16);
            this.lblBase2.TabIndex = 17;
            this.lblBase2.Text = "Descripcion";
            // 
            // Btnbuscar
            // 
            this.Btnbuscar.BackColor = System.Drawing.Color.AliceBlue;
            this.Btnbuscar.FlatAppearance.BorderSize = 0;
            this.Btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("Btnbuscar.Image")));
            this.Btnbuscar.Location = new System.Drawing.Point(217, 4);
            this.Btnbuscar.Name = "Btnbuscar";
            this.Btnbuscar.Size = new System.Drawing.Size(24, 24);
            this.Btnbuscar.TabIndex = 18;
            this.Btnbuscar.TabStop = false;
            this.Btnbuscar.Text = " ";
            this.Btnbuscar.UseVisualStyleBackColor = false;
            this.Btnbuscar.Click += new System.EventHandler(this.Btnbuscar_Click);
            // 
            // Prueba3
            // 
            this.ClientSize = new System.Drawing.Size(849, 288);
            this.Name = "Prueba3";
            this.Load += new System.EventHandler(this.Prueba3_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Logistica.BtnBuscar Btnbuscar;
        private Logistica.LblBase lblBase2;
        private Logistica.LblBase lblBase1;
        private Logistica.TxtBase Txtdescripcion;
        private Logistica.TxtBase Txtcodigo;
    }
}
