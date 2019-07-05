namespace Duke4.CXC.Reporte
{
    partial class Forreporte22
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
            this.dsreporte2 = new Duke4.CXC.Reporte.Dsreporte2();
            this.reportefactura2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportefactura2TableAdapter = new Duke4.CXC.Reporte.Dsreporte2TableAdapters.reportefactura2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsreporte2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportefactura2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Dsreportess2";
            reportDataSource1.Value = this.reportefactura2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Duke4.CXC.Reporte.Report2.rdlc";
            this.reportViewer1.Size = new System.Drawing.Size(751, 295);
            // 
            // dsreporte2
            // 
            this.dsreporte2.DataSetName = "Dsreporte2";
            this.dsreporte2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportefactura2BindingSource
            // 
            this.reportefactura2BindingSource.DataMember = "reportefactura2";
            this.reportefactura2BindingSource.DataSource = this.dsreporte2;
            // 
            // reportefactura2TableAdapter
            // 
            this.reportefactura2TableAdapter.ClearBeforeFill = true;
            // 
            // Forreporte22
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(751, 295);
            this.Name = "Forreporte22";
            this.Text = "MainReporte";
            this.Load += new System.EventHandler(this.Forreporte22_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsreporte2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportefactura2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource reportefactura2BindingSource;
        private Dsreporte2 dsreporte2;
        private Dsreporte2TableAdapters.reportefactura2TableAdapter reportefactura2TableAdapter;
    }
}
