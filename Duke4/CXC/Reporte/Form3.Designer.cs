﻿namespace Duke4.CXC.Reporte
{
    partial class Form3
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
            this.reportefactura1TableAdapter1 = new Duke4.CXC.Reporte.DataSet1234TableAdapters.reportefactura1TableAdapter();
            this.Muestrat = new Duke4.CXC.Reporte.Muestrat();
            this.reportefacturas1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportefacturas1TableAdapter = new Duke4.CXC.Reporte.MuestratTableAdapters.reportefacturas1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Muestrat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportefacturas1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "muestratodo";
            reportDataSource1.Value = this.reportefacturas1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Duke4.CXC.Reporte.muestratodo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(622, 338);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportefactura1TableAdapter1
            // 
            this.reportefactura1TableAdapter1.ClearBeforeFill = true;
            // 
            // Muestrat
            // 
            this.Muestrat.DataSetName = "Muestrat";
            this.Muestrat.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportefacturas1BindingSource
            // 
            this.reportefacturas1BindingSource.DataMember = "reportefacturas1";
            this.reportefacturas1BindingSource.DataSource = this.Muestrat;
            // 
            // reportefacturas1TableAdapter
            // 
            this.reportefacturas1TableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 338);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Muestrat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportefacturas1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reportefacturas1BindingSource;
        private Muestrat Muestrat;
        private DataSet1234TableAdapters.reportefactura1TableAdapter reportefactura1TableAdapter1;
        private MuestratTableAdapters.reportefacturas1TableAdapter reportefacturas1TableAdapter;
    }
}