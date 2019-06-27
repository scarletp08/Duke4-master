namespace Duke4.Reporte_General.CXC
{
    partial class cxcrepregistro01
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
            this.sprrepcxcregistro01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spr_rep_cxc_registro01TableAdapter = new Duke4.DataSet_General.DSCXCTableAdapters.Spr_rep_cxc_registro01TableAdapter();
            this.Spr_rep_cxc_registro01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dSCXC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprrepcxcregistro01BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spr_rep_cxc_registro01BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Spr_rep_cxc_registro01BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Duke4.Reporte_General.CXC.cxcrepregistro01.rdlc";
            // 
            // dSCXC
            // 
            this.dSCXC.DataSetName = "DSCXC";
            this.dSCXC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sprrepcxcregistro01BindingSource
            // 
            this.sprrepcxcregistro01BindingSource.DataMember = "Spr_rep_cxc_registro01";
            this.sprrepcxcregistro01BindingSource.DataSource = this.dSCXC;
            // 
            // spr_rep_cxc_registro01TableAdapter
            // 
            this.spr_rep_cxc_registro01TableAdapter.ClearBeforeFill = true;
            // 
            // Spr_rep_cxc_registro01BindingSource
            // 
            this.Spr_rep_cxc_registro01BindingSource.DataMember = "Spr_rep_cxc_registro01";
            this.Spr_rep_cxc_registro01BindingSource.DataSource = this.dSCXC;
            // 
            // cxcrepregistro01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "cxcrepregistro01";
            this.Load += new System.EventHandler(this.cxcrepregistro01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSCXC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprrepcxcregistro01BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spr_rep_cxc_registro01BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource sprrepcxcregistro01BindingSource;
        private DataSet_General.DSCXC dSCXC;
        private DataSet_General.DSCXCTableAdapters.Spr_rep_cxc_registro01TableAdapter spr_rep_cxc_registro01TableAdapter;
        private System.Windows.Forms.BindingSource Spr_rep_cxc_registro01BindingSource;
    }
}
