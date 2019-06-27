namespace Duke4.CXC.Archivo
{
    partial class cxcmanmunicipios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cxcmanmunicipios));
            this.TxtCodigo = new Duke4.Logistica.TxtEntero();
            this.Txtdescripcion = new Duke4.Logistica.TxtMayuscula();
            this.btnBuscar = new Duke4.Logistica.BtnBuscar();
            this.lblBase1 = new Duke4.Logistica.LblBase();
            this.lblBase2 = new Duke4.Logistica.LblBase();
            this.lblBase4 = new Duke4.Logistica.LblBase();
            this.btnBuscarprovincia = new Duke4.Logistica.BtnBuscar();
            this.Txtdescripcionprovincia = new Duke4.Logistica.TxtMayuscula();
            this.TxtCodigoprovincia = new Duke4.Logistica.TxtEntero();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.lblBase4);
            this.MainPanel.Controls.Add(this.btnBuscarprovincia);
            this.MainPanel.Controls.Add(this.Txtdescripcionprovincia);
            this.MainPanel.Controls.Add(this.TxtCodigoprovincia);
            this.MainPanel.Controls.Add(this.lblBase2);
            this.MainPanel.Controls.Add(this.lblBase1);
            this.MainPanel.Controls.Add(this.btnBuscar);
            this.MainPanel.Controls.Add(this.Txtdescripcion);
            this.MainPanel.Controls.Add(this.TxtCodigo);
            this.MainPanel.Location = new System.Drawing.Point(1, 130);
            this.MainPanel.Size = new System.Drawing.Size(758, 153);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.Controls.SetChildIndex(this.LblEstado, 0);
            this.MainPanel.Controls.SetChildIndex(this.TxtCodigo, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtdescripcion, 0);
            this.MainPanel.Controls.SetChildIndex(this.btnBuscar, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase1, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase2, 0);
            this.MainPanel.Controls.SetChildIndex(this.TxtCodigoprovincia, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtdescripcionprovincia, 0);
            this.MainPanel.Controls.SetChildIndex(this.btnBuscarprovincia, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase4, 0);
            // 
            // LblEstado
            // 
            this.LblEstado.Location = new System.Drawing.Point(279, 3);
            this.LblEstado.Size = new System.Drawing.Size(0, 23);
            this.LblEstado.Text = "";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 270);
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
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(96, 3);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 23);
            this.TxtCodigo.TabIndex = 0;
            this.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCodigo.TextChanged += new System.EventHandler(this.TxtCodigo_TextChanged);
            this.TxtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigo_KeyDown);
            this.TxtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodigo_Validating);
            // 
            // Txtdescripcion
            // 
            this.Txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtdescripcion.Location = new System.Drawing.Point(96, 32);
            this.Txtdescripcion.Name = "Txtdescripcion";
            this.Txtdescripcion.Size = new System.Drawing.Size(354, 23);
            this.Txtdescripcion.TabIndex = 1;
            this.Txtdescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtdescripcion_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(197, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(24, 24);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Text = " ";
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar Municipio");
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBase1
            // 
            this.lblBase1.AutoSize = true;
            this.lblBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase1.ForeColor = System.Drawing.Color.Black;
            this.lblBase1.Location = new System.Drawing.Point(7, 5);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(52, 16);
            this.lblBase1.TabIndex = 17;
            this.lblBase1.Text = "Código";
            // 
            // lblBase2
            // 
            this.lblBase2.AutoSize = true;
            this.lblBase2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase2.ForeColor = System.Drawing.Color.Black;
            this.lblBase2.Location = new System.Drawing.Point(7, 32);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(83, 16);
            this.lblBase2.TabIndex = 18;
            this.lblBase2.Text = "Descripción";
            // 
            // lblBase4
            // 
            this.lblBase4.AutoSize = true;
            this.lblBase4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase4.ForeColor = System.Drawing.Color.Black;
            this.lblBase4.Location = new System.Drawing.Point(7, 68);
            this.lblBase4.Name = "lblBase4";
            this.lblBase4.Size = new System.Drawing.Size(67, 16);
            this.lblBase4.TabIndex = 22;
            this.lblBase4.Text = "Provincia";
            // 
            // btnBuscarprovincia
            // 
            this.btnBuscarprovincia.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBuscarprovincia.FlatAppearance.BorderSize = 0;
            this.btnBuscarprovincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarprovincia.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarprovincia.Image")));
            this.btnBuscarprovincia.Location = new System.Drawing.Point(197, 65);
            this.btnBuscarprovincia.Name = "btnBuscarprovincia";
            this.btnBuscarprovincia.Size = new System.Drawing.Size(24, 24);
            this.btnBuscarprovincia.TabIndex = 21;
            this.btnBuscarprovincia.TabStop = false;
            this.btnBuscarprovincia.Text = " ";
            this.toolTip1.SetToolTip(this.btnBuscarprovincia, "Buscar Provincia");
            this.btnBuscarprovincia.UseVisualStyleBackColor = false;
            this.btnBuscarprovincia.Click += new System.EventHandler(this.btnBuscarprovincia_Click);
            // 
            // Txtdescripcionprovincia
            // 
            this.Txtdescripcionprovincia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtdescripcionprovincia.Enabled = false;
            this.Txtdescripcionprovincia.Location = new System.Drawing.Point(96, 95);
            this.Txtdescripcionprovincia.Name = "Txtdescripcionprovincia";
            this.Txtdescripcionprovincia.Size = new System.Drawing.Size(354, 23);
            this.Txtdescripcionprovincia.TabIndex = 3;
            // 
            // TxtCodigoprovincia
            // 
            this.TxtCodigoprovincia.Location = new System.Drawing.Point(96, 66);
            this.TxtCodigoprovincia.Name = "TxtCodigoprovincia";
            this.TxtCodigoprovincia.Size = new System.Drawing.Size(100, 23);
            this.TxtCodigoprovincia.TabIndex = 2;
            this.TxtCodigoprovincia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCodigoprovincia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigoprovincia_KeyDown);
            this.TxtCodigoprovincia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoprovincia_KeyPress);
            this.TxtCodigoprovincia.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodigoprovincia_Validating);
            // 
            // cxcmanmunicipios
            // 
            this.ClientSize = new System.Drawing.Size(853, 321);
            this.Name = "cxcmanmunicipios";
            this.Load += new System.EventHandler(this.cxcmanmunicipios_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Logistica.TxtEntero TxtCodigo;
        private Logistica.TxtMayuscula Txtdescripcion;
        private Logistica.LblBase lblBase1;
        private Logistica.BtnBuscar btnBuscar;
        private Logistica.LblBase lblBase4;
        private Logistica.BtnBuscar btnBuscarprovincia;
        private Logistica.TxtMayuscula Txtdescripcionprovincia;
        private Logistica.TxtEntero TxtCodigoprovincia;
        private Logistica.LblBase lblBase2;
    }
}
