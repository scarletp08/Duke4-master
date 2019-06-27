namespace Duke4
{
    partial class _mantenimientoVMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_mantenimientoVMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BtnCrear = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnActivar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnDesactivar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TxtCodigo = new Duke4.Logistica.TxtEntero();
            this.LblEstado = new Duke4.Logistica.LblGrande();
            this.TxtDescripcion = new Duke4.Logistica.TxtMayuscula();
            this.lblBase3 = new Duke4.Logistica.LblBase();
            this.lblBase2 = new Duke4.Logistica.LblBase();
            this.lblBase1 = new Duke4.Logistica.LblBase();
            this.btnBuscar = new Duke4.Logistica.BtnBuscar();
            this.cmbitbis = new Duke4.Logistica.CmbBase();
            this.LblFunctionName = new Duke4.Logistica.LblGrande();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblAlerta = new Duke4.Logistica.LblGrandeNgta();
            this.menuStrip1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCrear,
            this.BtnModificar,
            this.BtnConsultar,
            this.BtnActivar,
            this.BtnDesactivar,
            this.BtnSalvar,
            this.BtnImprimir,
            this.BtnCancelar});
            this.menuStrip1.Location = new System.Drawing.Point(3, 39);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1210, 57);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BtnCrear
            // 
            this.BtnCrear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrear.Image = ((System.Drawing.Image)(resources.GetObject("BtnCrear.Image")));
            this.BtnCrear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCrear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnCrear.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.BtnCrear.Size = new System.Drawing.Size(87, 50);
            this.BtnCrear.Text = "Crear [F6]";
            this.BtnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Image = global::Duke4.Properties.Resources.modificar32;
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.BtnModificar.Size = new System.Drawing.Size(111, 50);
            this.BtnModificar.Text = "Modificar [F3]";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.Image = global::Duke4.Properties.Resources.consulta32;
            this.BtnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnConsultar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnConsultar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.BtnConsultar.Size = new System.Drawing.Size(113, 50);
            this.BtnConsultar.Text = "Consultar [F4]";
            this.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnActivar
            // 
            this.BtnActivar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActivar.Image = global::Duke4.Properties.Resources.like__4_;
            this.BtnActivar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnActivar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnActivar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnActivar.Name = "BtnActivar";
            this.BtnActivar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnActivar.ShortcutKeyDisplayString = "";
            this.BtnActivar.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.BtnActivar.Size = new System.Drawing.Size(98, 50);
            this.BtnActivar.Text = "Activar [F1]";
            this.BtnActivar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnActivar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnActivar.Click += new System.EventHandler(this.BtnActivar_Click);
            // 
            // BtnDesactivar
            // 
            this.BtnDesactivar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesactivar.Image = global::Duke4.Properties.Resources.nolike32;
            this.BtnDesactivar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDesactivar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnDesactivar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnDesactivar.Name = "BtnDesactivar";
            this.BtnDesactivar.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.BtnDesactivar.Size = new System.Drawing.Size(121, 50);
            this.BtnDesactivar.Text = "Desactivar [F7]";
            this.BtnDesactivar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDesactivar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnDesactivar.Click += new System.EventHandler(this.BtnDesactivar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Image = global::Duke4.Properties.Resources.salbar32;
            this.BtnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.BtnSalvar.Size = new System.Drawing.Size(93, 50);
            this.BtnSalvar.Text = "Salvar [F5]";
            this.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click_1);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.Image = global::Duke4.Properties.Resources.buscar24__1_;
            this.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnImprimir.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.BtnImprimir.Size = new System.Drawing.Size(109, 50);
            this.BtnImprimir.Text = "Imprimir [F2]";
            this.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = global::Duke4.Properties.Resources.retornar32;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(114, 50);
            this.BtnCancelar.Text = "Retornar [Esc]";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.TxtCodigo);
            this.MainPanel.Controls.Add(this.LblEstado);
            this.MainPanel.Controls.Add(this.TxtDescripcion);
            this.MainPanel.Controls.Add(this.lblBase3);
            this.MainPanel.Controls.Add(this.lblBase2);
            this.MainPanel.Controls.Add(this.lblBase1);
            this.MainPanel.Controls.Add(this.btnBuscar);
            this.MainPanel.Controls.Add(this.cmbitbis);
            this.MainPanel.Location = new System.Drawing.Point(12, 99);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(445, 133);
            this.MainPanel.TabIndex = 11;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Verdana", 9F);
            this.TxtCodigo.ForeColor = System.Drawing.Color.Black;
            this.TxtCodigo.Location = new System.Drawing.Point(111, 15);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 22);
            this.TxtCodigo.TabIndex = 15;
            this.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodigo_Validating_1);
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Verdana", 14F);
            this.LblEstado.ForeColor = System.Drawing.Color.Black;
            this.LblEstado.Location = new System.Drawing.Point(278, 12);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(0, 23);
            this.LblEstado.TabIndex = 32;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDescripcion.Font = new System.Drawing.Font("Verdana", 9F);
            this.TxtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.TxtDescripcion.Location = new System.Drawing.Point(111, 44);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(282, 22);
            this.TxtDescripcion.TabIndex = 31;
            // 
            // lblBase3
            // 
            this.lblBase3.AutoSize = true;
            this.lblBase3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase3.ForeColor = System.Drawing.Color.Black;
            this.lblBase3.Location = new System.Drawing.Point(14, 44);
            this.lblBase3.Name = "lblBase3";
            this.lblBase3.Size = new System.Drawing.Size(83, 16);
            this.lblBase3.TabIndex = 27;
            this.lblBase3.Text = "Descripción";
            // 
            // lblBase2
            // 
            this.lblBase2.AutoSize = true;
            this.lblBase2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase2.ForeColor = System.Drawing.Color.Black;
            this.lblBase2.Location = new System.Drawing.Point(14, 74);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(91, 16);
            this.lblBase2.TabIndex = 26;
            this.lblBase2.Text = "Tipo de Itbis";
            // 
            // lblBase1
            // 
            this.lblBase1.AutoSize = true;
            this.lblBase1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblBase1.ForeColor = System.Drawing.Color.Black;
            this.lblBase1.Location = new System.Drawing.Point(14, 17);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(52, 16);
            this.lblBase1.TabIndex = 25;
            this.lblBase1.Text = "Código";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(228, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(24, 24);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Text = " ";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbitbis
            // 
            this.cmbitbis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbitbis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbitbis.FormattingEnabled = true;
            this.cmbitbis.Location = new System.Drawing.Point(115, 71);
            this.cmbitbis.Name = "cmbitbis";
            this.cmbitbis.ReadOnly = false;
            this.cmbitbis.Size = new System.Drawing.Size(121, 24);
            this.cmbitbis.TabIndex = 23;
            this.cmbitbis.TabStop = false;
            this.cmbitbis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbitbis_KeyPress);
            // 
            // LblFunctionName
            // 
            this.LblFunctionName.AutoSize = true;
            this.LblFunctionName.Font = new System.Drawing.Font("Verdana", 14F);
            this.LblFunctionName.ForeColor = System.Drawing.Color.Black;
            this.LblFunctionName.Location = new System.Drawing.Point(463, 99);
            this.LblFunctionName.Name = "LblFunctionName";
            this.LblFunctionName.Size = new System.Drawing.Size(64, 23);
            this.LblFunctionName.TabIndex = 14;
            this.LblFunctionName.Text = "Some";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(12, 246);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 11);
            this.panel2.TabIndex = 12;
            // 
            // LblAlerta
            // 
            this.LblAlerta.AutoSize = true;
            this.LblAlerta.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.LblAlerta.ForeColor = System.Drawing.Color.Black;
            this.LblAlerta.Location = new System.Drawing.Point(12, 263);
            this.LblAlerta.Name = "LblAlerta";
            this.LblAlerta.Size = new System.Drawing.Size(0, 23);
            this.LblAlerta.TabIndex = 13;
            // 
            // _mantenimientoVMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 297);
            this.Controls.Add(this.LblFunctionName);
            this.Controls.Add(this.LblAlerta);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "_mantenimientoVMenu";
            this.Text = "mantenimientoVMenu";
            this.Load += new System.EventHandler(this.mantenimientoVMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mantenimientoVMenu_KeyDown);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.MainPanel, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.LblAlerta, 0);
            this.Controls.SetChildIndex(this.LblFunctionName, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem BtnCrear;
        public System.Windows.Forms.ToolStripMenuItem BtnModificar;
        public System.Windows.Forms.ToolStripMenuItem BtnConsultar;
        public System.Windows.Forms.ToolStripMenuItem BtnActivar;
        public System.Windows.Forms.ToolStripMenuItem BtnDesactivar;
        public System.Windows.Forms.ToolStripMenuItem BtnImprimir;
        public System.Windows.Forms.ToolStripMenuItem BtnCancelar;
        private System.Windows.Forms.Panel MainPanel;
        private Logistica.LblBase lblBase3;
        private Logistica.LblBase lblBase2;
        private Logistica.LblBase lblBase1;
        private Logistica.BtnBuscar btnBuscar;
        private Logistica.CmbBase cmbitbis;
        private System.Windows.Forms.Panel panel2;
        private Logistica.LblGrandeNgta LblAlerta;
        public System.Windows.Forms.ToolStripMenuItem BtnSalvar;
        private Logistica.TxtMayuscula TxtDescripcion;
        private Logistica.LblGrande LblEstado;
        private Logistica.LblGrande LblFunctionName;
        private Logistica.TxtEntero TxtCodigo;
    }
}