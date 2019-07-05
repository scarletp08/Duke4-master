namespace Duke4.CXC.Reporte
{
    partial class Formfactura2
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
            this.sprprocesofactura2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtreportesfac2 = new Duke4.CXC.Reporte.Dtreportesfac2();
            this.sprprocesofactura2TableAdapter = new Duke4.CXC.Reporte.Dtreportesfac2TableAdapters.sprprocesofactura2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sprprocesofactura2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtreportesfac2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Dsreportefac2";
            reportDataSource1.Value = this.sprprocesofactura2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Duke4.CXC.Reporte.Reporteprueba.rdlc";
            this.reportViewer1.Size = new System.Drawing.Size(407, 261);
            // 
            // sprprocesofactura2BindingSource
            // 
            this.sprprocesofactura2BindingSource.DataMember = "sprprocesofactura2";
            this.sprprocesofactura2BindingSource.DataSource = this.dtreportesfac2;
            // 
            // dtreportesfac2
            // 
            this.dtreportesfac2.DataSetName = "Dtreportesfac2";
            this.dtreportesfac2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sprprocesofactura2TableAdapter
            // 
            this.sprprocesofactura2TableAdapter.ClearBeforeFill = true;
            // 
            // Formfactura2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(407, 261);
            this.Name = "Formfactura2";
            this.Text = "MainReporte";
            this.Load += new System.EventHandler(this.Formfactura2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sprprocesofactura2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtreportesfac2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource sprprocesofactura2BindingSource;
        private Dtreportesfac2 dtreportesfac2;
        private Dtreportesfac2TableAdapters.sprprocesofactura2TableAdapter sprprocesofactura2TableAdapter;
    }
}
