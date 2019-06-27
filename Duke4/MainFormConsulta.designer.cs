namespace Duke4
{
    partial class MainFormConsulta
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
            this.BtnHelp = new System.Windows.Forms.Label();
            this.LblFunctionName = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.BtnFiltrar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnPresentar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnReImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnExportar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnEnviar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCodificar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRetornar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormTitle
            // 
            this.FormTitle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormTitle.Location = new System.Drawing.Point(16, 0);
            this.FormTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FormTitle.Size = new System.Drawing.Size(59, 18);
            this.FormTitle.TabIndex = 0;
            this.FormTitle.Text = "labels1";
            this.FormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnHelp
            // 
            this.BtnHelp.Location = new System.Drawing.Point(883, 0);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(62, 38);
            this.BtnHelp.TabIndex = 2;
            // 
            // LblFunctionName
            // 
            this.LblFunctionName.AutoSize = true;
            this.LblFunctionName.BackColor = System.Drawing.Color.Transparent;
            this.LblFunctionName.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFunctionName.Location = new System.Drawing.Point(843, 198);
            this.LblFunctionName.Name = "LblFunctionName";
            this.LblFunctionName.Size = new System.Drawing.Size(0, 32);
            this.LblFunctionName.TabIndex = 67;
            // 
            // menuStrip2
            // 
            this.menuStrip2.AllowMerge = false;
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnFiltrar,
            this.BtnPresentar,
            this.BtnReImprimir,
            this.BtnGuardar,
            this.BtnExportar,
            this.BtnEnviar,
            this.BtnCancelar,
            this.BtnModificar,
            this.BtnCodificar,
            this.BtBuscar,
            this.BtnImprimir,
            this.BtnRetornar});
            this.menuStrip2.Location = new System.Drawing.Point(1, 38);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip2.Size = new System.Drawing.Size(1475, 62);
            this.menuStrip2.TabIndex = 74;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrar.Image = global::Duke4.Properties.Resources.crear32;
            this.BtnFiltrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnFiltrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnFiltrar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.BtnFiltrar.Size = new System.Drawing.Size(92, 55);
            this.BtnFiltrar.Text = "Filtrar [F4]";
            this.BtnFiltrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // BtnPresentar
            // 
            this.BtnPresentar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPresentar.Image = global::Duke4.Properties.Resources.modificar32;
            this.BtnPresentar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPresentar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnPresentar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnPresentar.Name = "BtnPresentar";
            this.BtnPresentar.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.BtnPresentar.Size = new System.Drawing.Size(115, 55);
            this.BtnPresentar.Text = "Presentar [F6]";
            this.BtnPresentar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPresentar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnPresentar.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // BtnReImprimir
            // 
            this.BtnReImprimir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReImprimir.Image = global::Duke4.Properties.Resources.consulta32;
            this.BtnReImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnReImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnReImprimir.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnReImprimir.Name = "BtnReImprimir";
            this.BtnReImprimir.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.BtnReImprimir.Size = new System.Drawing.Size(123, 55);
            this.BtnReImprimir.Text = "Reimprimir [F2]";
            this.BtnReImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnReImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnReImprimir.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = global::Duke4.Properties.Resources.like__4_;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnGuardar.ShortcutKeyDisplayString = "";
            this.BtnGuardar.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.BtnGuardar.Size = new System.Drawing.Size(93, 55);
            this.BtnGuardar.Text = "Salvar [F5]";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnActivar_Click);
            // 
            // BtnExportar
            // 
            this.BtnExportar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportar.Image = global::Duke4.Properties.Resources.nolike32;
            this.BtnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnExportar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.BtnExportar.Size = new System.Drawing.Size(95, 55);
            this.BtnExportar.Text = "Correo [F1]";
            this.BtnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnExportar.Click += new System.EventHandler(this.BtnDesactivar_Click);
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviar.Image = global::Duke4.Properties.Resources.salbar32;
            this.BtnEnviar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEnviar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnEnviar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.BtnEnviar.Size = new System.Drawing.Size(101, 55);
            this.BtnEnviar.Text = "Enviar [F10]";
            this.BtnEnviar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = global::Duke4.Properties.Resources.buscar24__1_;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.BtnCancelar.Size = new System.Drawing.Size(108, 55);
            this.BtnCancelar.Text = "Cancelar [F7]";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnCancelar.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Image = global::Duke4.Properties.Resources.retornar32;
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(117, 55);
            this.BtnModificar.Text = "Modificar [Esc]";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnModificar.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // BtnCodificar
            // 
            this.BtnCodificar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCodificar.Image = global::Duke4.Properties.Resources.retornar32;
            this.BtnCodificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCodificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnCodificar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnCodificar.Name = "BtnCodificar";
            this.BtnCodificar.Size = new System.Drawing.Size(109, 55);
            this.BtnCodificar.Text = "Codificar [F8]";
            this.BtnCodificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnCodificar.Click += new System.EventHandler(this.toolStripMenuItem14_Click);
            // 
            // BtBuscar
            // 
            this.BtBuscar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBuscar.Image = global::Duke4.Properties.Resources.retornar32;
            this.BtBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtBuscar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(95, 55);
            this.BtBuscar.Text = "Buscar [F4]";
            this.BtBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtBuscar.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.Image = global::Duke4.Properties.Resources.retornar32;
            this.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnImprimir.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(102, 55);
            this.BtnImprimir.Text = "Imprimir [A]";
            this.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnImprimir.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // BtnRetornar
            // 
            this.BtnRetornar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetornar.Image = global::Duke4.Properties.Resources.retornar32;
            this.BtnRetornar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRetornar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnRetornar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnRetornar.Name = "BtnRetornar";
            this.BtnRetornar.Size = new System.Drawing.Size(114, 55);
            this.BtnRetornar.Text = "Retornar [Esc]";
            this.BtnRetornar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRetornar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnRetornar.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // MainFormConsulta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1298, 543);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.LblFunctionName);
            this.Name = "MainFormConsulta";
            this.Load += new System.EventHandler(this.MainFormConsulta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormConsulta_KeyDown);
            this.Controls.SetChildIndex(this.LblFunctionName, 0);
            this.Controls.SetChildIndex(this.menuStrip2, 0);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private Logistica.LblBase FormTitle;
        private System.Windows.Forms.Label BtnHelp;
        public System.Windows.Forms.Label LblFunctionName;
        public System.Windows.Forms.MenuStrip menuStrip2;
        public System.Windows.Forms.ToolStripMenuItem BtnFiltrar;
        public System.Windows.Forms.ToolStripMenuItem BtnPresentar;
        public System.Windows.Forms.ToolStripMenuItem BtnReImprimir;
        public System.Windows.Forms.ToolStripMenuItem BtnGuardar;
        public System.Windows.Forms.ToolStripMenuItem BtnExportar;
        public System.Windows.Forms.ToolStripMenuItem BtnEnviar;
        public System.Windows.Forms.ToolStripMenuItem BtnCancelar;
        public System.Windows.Forms.ToolStripMenuItem BtnModificar;
        public System.Windows.Forms.ToolStripMenuItem BtnCodificar;
        public System.Windows.Forms.ToolStripMenuItem BtBuscar;
        public System.Windows.Forms.ToolStripMenuItem BtnImprimir;
        public System.Windows.Forms.ToolStripMenuItem BtnRetornar;
        public System.Windows.Forms.ToolTip toolTip1;
    }
}