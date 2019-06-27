namespace Duke4.CXC.Archivo
{
    partial class cxcmanMoneda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cxcmanMoneda));
            this.Txtdescripcion = new Duke4.Logistica.TxtMayuscula();
            this.TxtCodigo = new Duke4.Logistica.TxtEntero();
            this.btnBuscar = new Duke4.Logistica.BtnBuscar();
            this.lblBase1 = new Duke4.Logistica.LblBase();
            this.lblBase2 = new Duke4.Logistica.LblBase();
            this.lblBase3 = new Duke4.Logistica.LblBase();
            this.lblBase4 = new Duke4.Logistica.LblBase();
            this.TxtTasa = new Duke4.Logistica.TxtDecimal();
            this.Txtabreviatura = new Duke4.Logistica.TxtMayuscula();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.Txtabreviatura);
            this.MainPanel.Controls.Add(this.TxtTasa);
            this.MainPanel.Controls.Add(this.lblBase4);
            this.MainPanel.Controls.Add(this.lblBase3);
            this.MainPanel.Controls.Add(this.lblBase2);
            this.MainPanel.Controls.Add(this.lblBase1);
            this.MainPanel.Controls.Add(this.btnBuscar);
            this.MainPanel.Controls.Add(this.TxtCodigo);
            this.MainPanel.Controls.Add(this.Txtdescripcion);
            this.MainPanel.Location = new System.Drawing.Point(1, 130);
            this.MainPanel.Size = new System.Drawing.Size(756, 156);
            this.MainPanel.Controls.SetChildIndex(this.LblEstado, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtdescripcion, 0);
            this.MainPanel.Controls.SetChildIndex(this.TxtCodigo, 0);
            this.MainPanel.Controls.SetChildIndex(this.btnBuscar, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase1, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase2, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase3, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase4, 0);
            this.MainPanel.Controls.SetChildIndex(this.TxtTasa, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtabreviatura, 0);
            // 
            // LblEstado
            // 
            this.LblEstado.Location = new System.Drawing.Point(278, 3);
            this.LblEstado.Size = new System.Drawing.Size(0, 23);
            this.LblEstado.Text = "";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 263);
            this.panel2.Size = new System.Drawing.Size(768, 11);
            // 
            // LblAlerta
            // 
            this.LblAlerta.Location = new System.Drawing.Point(165, 487);
            this.LblAlerta.Size = new System.Drawing.Size(0, 23);
            this.LblAlerta.Text = "";
            // 
            // LblFunctionName
            // 
            this.LblFunctionName.Location = new System.Drawing.Point(445, 66);
            this.LblFunctionName.Size = new System.Drawing.Size(158, 32);
            this.LblFunctionName.Text = "Creando...";
            // 
            // LblAlerta
            // 
            this.LblAlerta.Location = new System.Drawing.Point(165, 487);
            this.LblAlerta.Size = new System.Drawing.Size(0, 23);
            this.LblAlerta.Text = "";
            // 
            // Txtdescripcion
            // 
            this.Txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtdescripcion.Location = new System.Drawing.Point(105, 32);
            this.Txtdescripcion.Name = "Txtdescripcion";
            this.Txtdescripcion.Size = new System.Drawing.Size(354, 23);
            this.Txtdescripcion.TabIndex = 1;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(105, 3);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 23);
            this.TxtCodigo.TabIndex = 0;
            this.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigo_KeyDown);
            this.TxtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodigo_Validating_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(206, 1);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(24, 24);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Text = " ";
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar Moneda");
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar1_Click);
            // 
            // lblBase1
            // 
            this.lblBase1.AutoSize = true;
            this.lblBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase1.ForeColor = System.Drawing.Color.Black;
            this.lblBase1.Location = new System.Drawing.Point(12, 10);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(52, 16);
            this.lblBase1.TabIndex = 19;
            this.lblBase1.Text = "Código";
            // 
            // lblBase2
            // 
            this.lblBase2.AutoSize = true;
            this.lblBase2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase2.ForeColor = System.Drawing.Color.Black;
            this.lblBase2.Location = new System.Drawing.Point(12, 96);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(38, 16);
            this.lblBase2.TabIndex = 20;
            this.lblBase2.Text = "Tasa";
            // 
            // lblBase3
            // 
            this.lblBase3.AutoSize = true;
            this.lblBase3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase3.ForeColor = System.Drawing.Color.Black;
            this.lblBase3.Location = new System.Drawing.Point(12, 64);
            this.lblBase3.Name = "lblBase3";
            this.lblBase3.Size = new System.Drawing.Size(84, 16);
            this.lblBase3.TabIndex = 21;
            this.lblBase3.Text = "Abreviatura";
            // 
            // lblBase4
            // 
            this.lblBase4.AutoSize = true;
            this.lblBase4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase4.ForeColor = System.Drawing.Color.Black;
            this.lblBase4.Location = new System.Drawing.Point(12, 37);
            this.lblBase4.Name = "lblBase4";
            this.lblBase4.Size = new System.Drawing.Size(83, 16);
            this.lblBase4.TabIndex = 22;
            this.lblBase4.Text = "Descripción";
            // 
            // TxtTasa
            // 
            this.TxtTasa.Location = new System.Drawing.Point(105, 93);
            this.TxtTasa.Name = "TxtTasa";
            this.TxtTasa.Size = new System.Drawing.Size(100, 23);
            this.TxtTasa.TabIndex = 3;
            this.TxtTasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtTasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTasa_KeyPress);
            // 
            // Txtabreviatura
            // 
            this.Txtabreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtabreviatura.Location = new System.Drawing.Point(105, 64);
            this.Txtabreviatura.Name = "Txtabreviatura";
            this.Txtabreviatura.Size = new System.Drawing.Size(100, 23);
            this.Txtabreviatura.TabIndex = 2;
            // 
            // cxcmanMoneda
            // 
            this.ClientSize = new System.Drawing.Size(851, 305);
            this.Name = "cxcmanMoneda";
            this.Load += new System.EventHandler(this.cxcmanMoneda_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Logistica.TxtMayuscula Txtdescripcion;
        private Logistica.LblBase lblBase4;
        private Logistica.LblBase lblBase3;
        private Logistica.LblBase lblBase2;
        private Logistica.LblBase lblBase1;
        private Logistica.BtnBuscar btnBuscar;
        private Logistica.TxtEntero TxtCodigo;
        private Logistica.TxtMayuscula Txtabreviatura;
        private Logistica.TxtDecimal TxtTasa;
    }
}
