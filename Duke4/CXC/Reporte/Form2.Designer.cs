namespace Duke4.CXC.Reporte
{
    partial class Form2
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
            this.DataSet1234 = new Duke4.CXC.Reporte.DataSet1234();
            this.reportefactura1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportefactura1TableAdapter = new Duke4.CXC.Reporte.DataSet1234TableAdapters.reportefactura1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1234)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportefactura1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reportefactura1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Duke4.CXC.Reporte.Rreportefactura.rdlc";
            this.reportViewer1.Size = new System.Drawing.Size(804, 318);
            // 
            // DataSet1234
            // 
            this.DataSet1234.DataSetName = "DataSet1234";
            this.DataSet1234.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportefactura1BindingSource
            // 
            this.reportefactura1BindingSource.DataMember = "reportefactura1";
            this.reportefactura1BindingSource.DataSource = this.DataSet1234;
            // 
            // reportefactura1TableAdapter
            // 
            this.reportefactura1TableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(804, 318);
            this.Name = "Form2";
            this.Text = "MainReporte";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1234)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportefactura1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource reportefactura1BindingSource;
        private DataSet1234 DataSet1234;
        private DataSet1234TableAdapters.reportefactura1TableAdapter reportefactura1TableAdapter;
    }
}
