namespace Duke4.Reporte_General.CXC
{
    partial class cxcrepdebitocredito001
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dSCXC = new Duke4.DataSet_General.DSCXC();
            this.sprrepDebCred001BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spr_rep_DebCred001TableAdapter = new Duke4.DataSet_General.DSCXCTableAdapters.spr_rep_DebCred001TableAdapter();
            this.spr_rep_DebCred001BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dSCXC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprrepDebCred001BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_rep_DebCred001BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spr_rep_DebCred001BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Duke4.Reporte_General.CXC.cxcrepdebiocredito001.rdlc";
            // 
            // dSCXC
            // 
            this.dSCXC.DataSetName = "DSCXC";
            this.dSCXC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sprrepDebCred001BindingSource
            // 
            this.sprrepDebCred001BindingSource.DataMember = "spr_rep_DebCred001";
            this.sprrepDebCred001BindingSource.DataSource = this.dSCXC;
            // 
            // spr_rep_DebCred001TableAdapter
            // 
            this.spr_rep_DebCred001TableAdapter.ClearBeforeFill = true;
            // 
            // spr_rep_DebCred001BindingSource
            // 
            this.spr_rep_DebCred001BindingSource.DataMember = "spr_rep_DebCred001";
            this.spr_rep_DebCred001BindingSource.DataSource = this.dSCXC;
            // 
            // cxcrepdebiocredito001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "cxcrepdebiocredito001";
            this.Text = "MainReporte";
            this.Load += new System.EventHandler(this.cxcrepdebiocredito001_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSCXC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprrepDebCred001BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_rep_DebCred001BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource spr_rep_DebCred001BindingSource;
        private DataSet_General.DSCXC dSCXC;
        private System.Windows.Forms.BindingSource sprrepDebCred001BindingSource;
        private DataSet_General.DSCXCTableAdapters.spr_rep_DebCred001TableAdapter spr_rep_DebCred001TableAdapter;
    }
}
