namespace Duke4.CXC.Reporte
{
    partial class Form1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet1234 = new Duke4.CXC.Reporte.DataSet1234();
            this.reportefactura1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportefactura1TableAdapter = new Duke4.CXC.Reporte.DataSet1234TableAdapters.reportefactura1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1234)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportefactura1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reportefactura1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Duke4.CXC.Reporte.Rreportefactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(865, 369);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet1234
            // 
            this.dataSet1234.DataSetName = "DataSet1234";
            this.dataSet1234.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportefactura1BindingSource
            // 
            this.reportefactura1BindingSource.DataMember = "reportefactura1";
            this.reportefactura1BindingSource.DataSource = this.dataSet1234;
            // 
            // reportefactura1TableAdapter
            // 
            this.reportefactura1TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 369);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1234)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportefactura1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reportefactura1BindingSource;
        private DataSet1234 dataSet1234;
        private DataSet1234TableAdapters.reportefactura1TableAdapter reportefactura1TableAdapter;
    }
}