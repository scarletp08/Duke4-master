namespace Duke4.CXC.Archivo
{
    partial class cxcmanprovincias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cxcmanprovincias));
            this.lblBase2 = new Duke4.Logistica.LblBase();
            this.lblBase1 = new Duke4.Logistica.LblBase();
            this.btnBuscar = new Duke4.Logistica.BtnBuscar();
            this.Txtdescripcion = new Duke4.Logistica.TxtMayuscula();
            this.TxtCodigo = new Duke4.Logistica.TxtEntero();
            this.lblBase3 = new Duke4.Logistica.LblBase();
            this.btnBuscarregion = new Duke4.Logistica.BtnBuscar();
            this.TxtCodigoregion = new Duke4.Logistica.TxtEntero();
            this.Txtdescripcionregion = new Duke4.Logistica.TxtMayuscula();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.Txtdescripcionregion);
            this.MainPanel.Controls.Add(this.lblBase3);
            this.MainPanel.Controls.Add(this.btnBuscarregion);
            this.MainPanel.Controls.Add(this.TxtCodigoregion);
            this.MainPanel.Controls.Add(this.lblBase2);
            this.MainPanel.Controls.Add(this.lblBase1);
            this.MainPanel.Controls.Add(this.btnBuscar);
            this.MainPanel.Controls.Add(this.Txtdescripcion);
            this.MainPanel.Controls.Add(this.TxtCodigo);
            this.MainPanel.Location = new System.Drawing.Point(1, 130);
            this.MainPanel.Size = new System.Drawing.Size(762, 163);
            this.MainPanel.Controls.SetChildIndex(this.LblEstado, 0);
            this.MainPanel.Controls.SetChildIndex(this.TxtCodigo, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtdescripcion, 0);
            this.MainPanel.Controls.SetChildIndex(this.btnBuscar, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase1, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase2, 0);
            this.MainPanel.Controls.SetChildIndex(this.TxtCodigoregion, 0);
            this.MainPanel.Controls.SetChildIndex(this.btnBuscarregion, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase3, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtdescripcionregion, 0);
            // 
            // LblEstado
            // 
            this.LblEstado.Location = new System.Drawing.Point(283, 2);
            this.LblEstado.Size = new System.Drawing.Size(0, 23);
            this.LblEstado.Text = "";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 269);
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
            // lblBase2
            // 
            this.lblBase2.AutoSize = true;
            this.lblBase2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase2.ForeColor = System.Drawing.Color.Black;
            this.lblBase2.Location = new System.Drawing.Point(7, 4);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(52, 16);
            this.lblBase2.TabIndex = 23;
            this.lblBase2.Text = "Código";
            // 
            // lblBase1
            // 
            this.lblBase1.AutoSize = true;
            this.lblBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase1.ForeColor = System.Drawing.Color.Black;
            this.lblBase1.Location = new System.Drawing.Point(7, 31);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(83, 16);
            this.lblBase1.TabIndex = 22;
            this.lblBase1.Text = "Descripción";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(198, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(24, 24);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Text = " ";
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar Provincia");
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Txtdescripcion
            // 
            this.Txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtdescripcion.Location = new System.Drawing.Point(96, 31);
            this.Txtdescripcion.Name = "Txtdescripcion";
            this.Txtdescripcion.Size = new System.Drawing.Size(354, 23);
            this.Txtdescripcion.TabIndex = 1;
            this.Txtdescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtdescripcion_KeyPress);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(96, 2);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 23);
            this.TxtCodigo.TabIndex = 0;
            this.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigo_KeyDown);
            this.TxtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodigo_Validating);
            // 
            // lblBase3
            // 
            this.lblBase3.AutoSize = true;
            this.lblBase3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase3.ForeColor = System.Drawing.Color.Black;
            this.lblBase3.Location = new System.Drawing.Point(7, 67);
            this.lblBase3.Name = "lblBase3";
            this.lblBase3.Size = new System.Drawing.Size(51, 16);
            this.lblBase3.TabIndex = 28;
            this.lblBase3.Text = "Región";
            // 
            // btnBuscarregion
            // 
            this.btnBuscarregion.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBuscarregion.FlatAppearance.BorderSize = 0;
            this.btnBuscarregion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarregion.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarregion.Image")));
            this.btnBuscarregion.Location = new System.Drawing.Point(198, 64);
            this.btnBuscarregion.Name = "btnBuscarregion";
            this.btnBuscarregion.Size = new System.Drawing.Size(24, 24);
            this.btnBuscarregion.TabIndex = 26;
            this.btnBuscarregion.TabStop = false;
            this.btnBuscarregion.Text = " ";
            this.toolTip1.SetToolTip(this.btnBuscarregion, "Buscar Región");
            this.btnBuscarregion.UseVisualStyleBackColor = false;
            this.btnBuscarregion.Click += new System.EventHandler(this.btnBuscar1_Click);
            // 
            // TxtCodigoregion
            // 
            this.TxtCodigoregion.Location = new System.Drawing.Point(96, 65);
            this.TxtCodigoregion.Name = "TxtCodigoregion";
            this.TxtCodigoregion.Size = new System.Drawing.Size(100, 23);
            this.TxtCodigoregion.TabIndex = 2;
            this.TxtCodigoregion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCodigoregion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigoregion_KeyDown);
            this.TxtCodigoregion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoregion_KeyPress);
            this.TxtCodigoregion.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodigoregion_Validating);
            // 
            // Txtdescripcionregion
            // 
            this.Txtdescripcionregion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtdescripcionregion.Enabled = false;
            this.Txtdescripcionregion.Location = new System.Drawing.Point(96, 94);
            this.Txtdescripcionregion.Name = "Txtdescripcionregion";
            this.Txtdescripcionregion.Size = new System.Drawing.Size(354, 23);
            this.Txtdescripcionregion.TabIndex = 3;
            // 
            // cxcmanprovincias
            // 
            this.ClientSize = new System.Drawing.Size(852, 310);
            this.Name = "cxcmanprovincias";
            this.Load += new System.EventHandler(this.cxcmanprovincias_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Logistica.LblBase lblBase2;
        private Logistica.LblBase lblBase1;
        private Logistica.BtnBuscar btnBuscar;
        private Logistica.TxtMayuscula Txtdescripcion;
        private Logistica.TxtEntero TxtCodigo;
        private Logistica.LblBase lblBase3;
        private Logistica.BtnBuscar btnBuscarregion;
        private Logistica.TxtEntero TxtCodigoregion;
        private Logistica.TxtMayuscula Txtdescripcionregion;
    }
}
