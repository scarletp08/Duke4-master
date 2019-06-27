namespace Duke4
{
    partial class MainFormMant
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormMant));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LblEstado = new Duke4.Logistica.LblGrande();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.BtnSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCrear = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnActivar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnDesactivar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblAlerta = new Duke4.Logistica.LblGrandeNgta();
            this.LblFunctionName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MainPanel.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Controls.Add(this.LblEstado);
            this.MainPanel.Location = new System.Drawing.Point(0, 145);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(765, 269);
            this.MainPanel.TabIndex = 10;
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Verdana", 14F);
            this.LblEstado.ForeColor = System.Drawing.Color.Black;
            this.LblEstado.Location = new System.Drawing.Point(590, 24);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(103, 23);
            this.LblEstado.TabIndex = 13;
            this.LblEstado.Text = "LblEstado";
            // 
            // menuStrip2
            // 
            this.menuStrip2.AllowMerge = false;
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSalvar,
            this.BtnModificar,
            this.BtnCrear,
            this.BtnConsultar,
            this.BtnActivar,
            this.BtnDesactivar,
            this.BtnImprimir,
            this.BtnCancelar});
            this.menuStrip2.Location = new System.Drawing.Point(0, 35);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip2.Size = new System.Drawing.Size(1210, 62);
            this.menuStrip2.TabIndex = 12;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            this.menuStrip2.Paint += new System.Windows.Forms.PaintEventHandler(this.menuStrip2_Paint);
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
            this.BtnSalvar.Size = new System.Drawing.Size(93, 55);
            this.BtnSalvar.Text = "Salvar [F5]";
            this.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnSalvar.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
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
            this.BtnModificar.Size = new System.Drawing.Size(111, 55);
            this.BtnModificar.Text = "Modificar [F3]";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnModificar.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // BtnCrear
            // 
            this.BtnCrear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrear.Image = global::Duke4.Properties.Resources.crear32;
            this.BtnCrear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCrear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnCrear.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.BtnCrear.Size = new System.Drawing.Size(87, 55);
            this.BtnCrear.Text = "Crear [F6]";
            this.BtnCrear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnCrear.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
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
            this.BtnConsultar.Size = new System.Drawing.Size(113, 55);
            this.BtnConsultar.Text = "Consultar [F4]";
            this.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnConsultar.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
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
            this.BtnActivar.Size = new System.Drawing.Size(98, 55);
            this.BtnActivar.Text = "Activar [F1]";
            this.BtnActivar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnActivar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnActivar.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
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
            this.BtnDesactivar.Size = new System.Drawing.Size(121, 55);
            this.BtnDesactivar.Text = "Desactivar [F7]";
            this.BtnDesactivar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDesactivar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnDesactivar.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.Image = global::Duke4.Properties.Resources.printer;
            this.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnImprimir.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.BtnImprimir.Size = new System.Drawing.Size(109, 55);
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
            this.BtnCancelar.Size = new System.Drawing.Size(114, 55);
            this.BtnCancelar.Text = "Retornar [Esc]";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(0, 428);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 11);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // LblAlerta
            // 
            this.LblAlerta.AutoSize = true;
            this.LblAlerta.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.LblAlerta.ForeColor = System.Drawing.Color.Black;
            this.LblAlerta.Image = ((System.Drawing.Image)(resources.GetObject("LblAlerta.Image")));
            this.LblAlerta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblAlerta.Location = new System.Drawing.Point(8, 447);
            this.LblAlerta.Name = "LblAlerta";
            this.LblAlerta.Size = new System.Drawing.Size(97, 23);
            this.LblAlerta.TabIndex = 73;
            this.LblAlerta.Text = "letrero1";
            // 
            // LblFunctionName
            // 
            this.LblFunctionName.AutoSize = true;
            this.LblFunctionName.BackColor = System.Drawing.Color.Transparent;
            this.LblFunctionName.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFunctionName.Location = new System.Drawing.Point(643, 108);
            this.LblFunctionName.Name = "LblFunctionName";
            this.LblFunctionName.Size = new System.Drawing.Size(0, 32);
            this.LblFunctionName.TabIndex = 74;
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.UseAnimation = false;
            // 
            // MainFormMant
            // 
            this.ClientSize = new System.Drawing.Size(849, 482);
            this.Controls.Add(this.LblFunctionName);
            this.Controls.Add(this.LblAlerta);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainFormMant";
            this.Load += new System.EventHandler(this.MainFormMant_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormMant_KeyDown);
            this.Controls.SetChildIndex(this.MainPanel, 0);
            this.Controls.SetChildIndex(this.menuStrip2, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.LblAlerta, 0);
            this.Controls.SetChildIndex(this.LblFunctionName, 0);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel MainPanel;
        public Logistica.LblGrande LblEstado;
        public System.Windows.Forms.MenuStrip menuStrip2;
        public System.Windows.Forms.ToolStripMenuItem BtnCrear;
        public System.Windows.Forms.ToolStripMenuItem BtnModificar;
        public System.Windows.Forms.ToolStripMenuItem BtnConsultar;
        public System.Windows.Forms.ToolStripMenuItem BtnActivar;
        public System.Windows.Forms.ToolStripMenuItem BtnDesactivar;
        public System.Windows.Forms.ToolStripMenuItem BtnSalvar;
        public System.Windows.Forms.ToolStripMenuItem BtnImprimir;
        public System.Windows.Forms.ToolStripMenuItem BtnCancelar;
        public System.Windows.Forms.Panel panel2;
        public Logistica.LblGrandeNgta LblAlerta;
        public System.Windows.Forms.Label LblFunctionName;
        public System.Windows.Forms.ToolTip toolTip1;
    }
}
