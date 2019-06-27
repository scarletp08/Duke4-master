namespace Duke4.Reporte_General.CXC
{
    partial class cxcrepcobros001
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
            this.spr_rep_Cobro001BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSCXC = new Duke4.DataSet_General.DSCXC();
            this.sprrepCobro001BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spr_rep_Cobro001TableAdapter = new Duke4.DataSet_General.DSCXCTableAdapters.spr_rep_Cobro001TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spr_rep_Cobro001BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCXC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprrepCobro001BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spr_rep_Cobro001BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Duke4.Reporte_General.CXC.cxcrepcobros001.rdlc";
            // 
            // spr_rep_Cobro001BindingSource
            // 
            this.spr_rep_Cobro001BindingSource.DataMember = "spr_rep_Cobro001";
            this.spr_rep_Cobro001BindingSource.DataSource = this.dSCXC;
            // 
            // dSCXC
            // 
            this.dSCXC.DataSetName = "DSCXC";
            this.dSCXC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sprrepCobro001BindingSource
            // 
            this.sprrepCobro001BindingSource.DataMember = "spr_rep_Cobro001";
            this.sprrepCobro001BindingSource.DataSource = this.dSCXC;
            // 
            // spr_rep_Cobro001TableAdapter
            // 
            this.spr_rep_Cobro001TableAdapter.ClearBeforeFill = true;
            // 
            // cxcrepcobros001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "cxcrepcobros001";
            this.Text = "MainReporte";
            this.Load += new System.EventHandler(this.cxcrepcobros001_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spr_rep_Cobro001BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCXC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprrepCobro001BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet_General.DSCXC dSCXC;
        private System.Windows.Forms.BindingSource sprrepCobro001BindingSource;
        private DataSet_General.DSCXCTableAdapters.spr_rep_Cobro001TableAdapter spr_rep_Cobro001TableAdapter;
        private System.Windows.Forms.BindingSource spr_rep_Cobro001BindingSource;
    }
}
