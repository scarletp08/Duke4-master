﻿namespace Duke4.CXC.Archivo
{
    partial class cxcmantipocliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cxcmantipocliente));
            this.TxtCodigo = new Duke4.Logistica.TxtEntero();
            this.Txtdescripcion = new Duke4.Logistica.TxtMayuscula();
            this.lblBase1 = new Duke4.Logistica.LblBase();
            this.lblBase2 = new Duke4.Logistica.LblBase();
            this.btnBuscar = new Duke4.Logistica.BtnBuscar();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.btnBuscar);
            this.MainPanel.Controls.Add(this.lblBase2);
            this.MainPanel.Controls.Add(this.lblBase1);
            this.MainPanel.Controls.Add(this.Txtdescripcion);
            this.MainPanel.Controls.Add(this.TxtCodigo);
            this.MainPanel.Location = new System.Drawing.Point(1, 130);
            this.MainPanel.Size = new System.Drawing.Size(765, 102);
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            this.MainPanel.Controls.SetChildIndex(this.LblEstado, 0);
            this.MainPanel.Controls.SetChildIndex(this.TxtCodigo, 0);
            this.MainPanel.Controls.SetChildIndex(this.Txtdescripcion, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase1, 0);
            this.MainPanel.Controls.SetChildIndex(this.lblBase2, 0);
            this.MainPanel.Controls.SetChildIndex(this.btnBuscar, 0);
            // 
            // LblEstado
            // 
            this.LblEstado.Location = new System.Drawing.Point(278, 3);
            this.LblEstado.Size = new System.Drawing.Size(0, 23);
            this.LblEstado.Text = "";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 212);
            this.panel2.Size = new System.Drawing.Size(774, 11);
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
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(101, 2);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 23);
            this.TxtCodigo.TabIndex = 0;
            this.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigo_KeyDown);
            this.TxtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodigo_Validating);
            this.TxtCodigo.Validated += new System.EventHandler(this.TxtCodigo_Validated);
            // 
            // Txtdescripcion
            // 
            this.Txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtdescripcion.Location = new System.Drawing.Point(101, 31);
            this.Txtdescripcion.Name = "Txtdescripcion";
            this.Txtdescripcion.Size = new System.Drawing.Size(354, 23);
            this.Txtdescripcion.TabIndex = 1;
            this.Txtdescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtdescripcion_KeyPress);
            // 
            // lblBase1
            // 
            this.lblBase1.AutoSize = true;
            this.lblBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase1.ForeColor = System.Drawing.Color.Black;
            this.lblBase1.Location = new System.Drawing.Point(12, 31);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(83, 16);
            this.lblBase1.TabIndex = 16;
            this.lblBase1.Text = "Descripción";
            // 
            // lblBase2
            // 
            this.lblBase2.AutoSize = true;
            this.lblBase2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase2.ForeColor = System.Drawing.Color.Black;
            this.lblBase2.Location = new System.Drawing.Point(12, 4);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(52, 16);
            this.lblBase2.TabIndex = 17;
            this.lblBase2.Text = "Código";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(203, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(24, 24);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Text = " ";
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar Tipo Cliente");
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar1_Click);
            // 
            // cxcmantipocliente
            // 
            this.ClientSize = new System.Drawing.Size(853, 263);
            this.Name = "cxcmantipocliente";
            this.Load += new System.EventHandler(this.cxcmantipocliente_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Logistica.TxtEntero TxtCodigo;
        private Logistica.TxtMayuscula Txtdescripcion;
        private Logistica.BtnBuscar btnBuscar;
        private Logistica.LblBase lblBase2;
        private Logistica.LblBase lblBase1;
    }
}
