namespace Duke4.CXC.Archivo
{
    partial class cxcmanrutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cxcmanrutas));
            this.Txtdescripcionvendedor = new Duke4.Logistica.TxtMayuscula();
            this.lblBase3 = new Duke4.Logistica.LblBase();
            this.btnBuscarvendedor = new Duke4.Logistica.BtnBuscar();
            this.TxtCodigovendedor = new Duke4.Logistica.TxtEntero();
            this.lblBase2 = new Duke4.Logistica.LblBase();
            this.lblBase1 = new Duke4.Logistica.LblBase();
            this.btnBuscar = new Duke4.Logistica.BtnBuscar();
            this.Txtdescripcion = new Duke4.Logistica.TxtMayuscula();
            this.TxtCodigo = new Duke4.Logistica.TxtEntero();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.Txtdescripcionvendedor);
            this.MainPanel.Controls.Add(this.lblBase3);
            this.MainPanel.Controls.Add(this.btnBuscarvendedor);
            this.MainPanel.Controls.Add(this.TxtCodigovendedor);
            this.MainPanel.Controls.Add(this.lblBase2);
            this.MainPanel.Controls.Add(this.lblBase1);
            this.MainPanel.Controls.Add(this.btnBuscar);
            this.MainPanel.Controls.Add(this.Txtdescripcion);
            this.MainPanel.Controls.Add(this.TxtCodigo);
            this.MainPanel.Location = new System.Drawing.Point(1, 130);
            this.MainPanel.Size = new System.Drawing.Size(768, 159);
            this.MainPanel.Controls.SetChildIndex(this.LblEstado, 0);
            this.MainPanel.Controls.SetChildIndex(this.TxtCodigo, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtdescripcion, 0);
            this.MainPanel.Controls.SetChildIndex(this.btnBuscar, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase1, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase2, 0);
            this.MainPanel.Controls.SetChildIndex(this.TxtCodigovendedor, 0);
            this.MainPanel.Controls.SetChildIndex(this.btnBuscarvendedor, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase3, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtdescripcionvendedor, 0);
            // 
            // LblEstado
            // 
            this.LblEstado.Size = new System.Drawing.Size(0, 23);
            this.LblEstado.Text = "";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 266);
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
            this.LblFunctionName.Location = new System.Drawing.Point(689, 42);
            this.LblFunctionName.Size = new System.Drawing.Size(158, 32);
            this.LblFunctionName.Text = "Creando...";
            // 
            // LblAlerta
            // 
            this.LblAlerta.Location = new System.Drawing.Point(165, 487);
            this.LblAlerta.Size = new System.Drawing.Size(0, 23);
            this.LblAlerta.Text = "";
            // 
            // Txtdescripcionvendedor
            // 
            this.Txtdescripcionvendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtdescripcionvendedor.Enabled = false;
            this.Txtdescripcionvendedor.Location = new System.Drawing.Point(94, 95);
            this.Txtdescripcionvendedor.Name = "Txtdescripcionvendedor";
            this.Txtdescripcionvendedor.Size = new System.Drawing.Size(354, 23);
            this.Txtdescripcionvendedor.TabIndex = 32;
            this.Txtdescripcionvendedor.TextChanged += new System.EventHandler(this.Txtdescripcionvendedor_TextChanged);
            // 
            // lblBase3
            // 
            this.lblBase3.AutoSize = true;
            this.lblBase3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase3.ForeColor = System.Drawing.Color.Black;
            this.lblBase3.Location = new System.Drawing.Point(7, 69);
            this.lblBase3.Name = "lblBase3";
            this.lblBase3.Size = new System.Drawing.Size(69, 16);
            this.lblBase3.TabIndex = 37;
            this.lblBase3.Text = "Vendedor";
            // 
            // btnBuscarvendedor
            // 
            this.btnBuscarvendedor.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBuscarvendedor.FlatAppearance.BorderSize = 0;
            this.btnBuscarvendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarvendedor.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarvendedor.Image")));
            this.btnBuscarvendedor.Location = new System.Drawing.Point(194, 64);
            this.btnBuscarvendedor.Name = "btnBuscarvendedor";
            this.btnBuscarvendedor.Size = new System.Drawing.Size(24, 24);
            this.btnBuscarvendedor.TabIndex = 36;
            this.btnBuscarvendedor.TabStop = false;
            this.btnBuscarvendedor.Text = " ";
            this.toolTip1.SetToolTip(this.btnBuscarvendedor, "Buscar Vendedor");
            this.btnBuscarvendedor.UseVisualStyleBackColor = false;
            this.btnBuscarvendedor.Click += new System.EventHandler(this.btnBuscarvendedor_Click);
            // 
            // TxtCodigovendedor
            // 
            this.TxtCodigovendedor.Location = new System.Drawing.Point(94, 66);
            this.TxtCodigovendedor.Name = "TxtCodigovendedor";
            this.TxtCodigovendedor.Size = new System.Drawing.Size(100, 23);
            this.TxtCodigovendedor.TabIndex = 31;
            this.TxtCodigovendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCodigovendedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigovendedor_KeyDown);
            this.TxtCodigovendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigovendedor_KeyPress);
            this.TxtCodigovendedor.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodigovendedor_Validating);
            // 
            // lblBase2
            // 
            this.lblBase2.AutoSize = true;
            this.lblBase2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase2.ForeColor = System.Drawing.Color.Black;
            this.lblBase2.Location = new System.Drawing.Point(7, 6);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(52, 16);
            this.lblBase2.TabIndex = 35;
            this.lblBase2.Text = "Código";
            // 
            // lblBase1
            // 
            this.lblBase1.AutoSize = true;
            this.lblBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase1.ForeColor = System.Drawing.Color.Black;
            this.lblBase1.Location = new System.Drawing.Point(7, 33);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(83, 16);
            this.lblBase1.TabIndex = 34;
            this.lblBase1.Text = "Descripción";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(195, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(24, 24);
            this.btnBuscar.TabIndex = 33;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Text = " ";
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar Ruta");
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Txtdescripcion
            // 
            this.Txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtdescripcion.Location = new System.Drawing.Point(94, 32);
            this.Txtdescripcion.Name = "Txtdescripcion";
            this.Txtdescripcion.Size = new System.Drawing.Size(354, 23);
            this.Txtdescripcion.TabIndex = 30;
            this.Txtdescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtdescripcion_KeyPress);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(94, 3);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 23);
            this.TxtCodigo.TabIndex = 29;
            this.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigo_KeyDown);
            this.TxtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodigo_Validating);
            this.TxtCodigo.Validated += new System.EventHandler(this.TxtCodigo_Validated);
            // 
            // cxcmanrutas
            // 
            this.ClientSize = new System.Drawing.Size(853, 320);
            this.Location = new System.Drawing.Point(0, 145);
            this.Name = "cxcmanrutas";
            this.Load += new System.EventHandler(this.cxcmanrutas_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Logistica.TxtMayuscula Txtdescripcionvendedor;
        private Logistica.LblBase lblBase3;
        private Logistica.BtnBuscar btnBuscarvendedor;
        private Logistica.TxtEntero TxtCodigovendedor;
        private Logistica.LblBase lblBase2;
        private Logistica.LblBase lblBase1;
        private Logistica.BtnBuscar btnBuscar;
        private Logistica.TxtMayuscula Txtdescripcion;
        private Logistica.TxtEntero TxtCodigo;
    }
}
