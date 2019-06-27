namespace Duke4._newDesign.Report
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
            this.spr_rep_cxc_multipleRegistro01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Duke4._newDesign.Report.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spr_rep_cxc_multipleRegistro01TableAdapter = new Duke4._newDesign.Report.DataSet1TableAdapters.spr_rep_cxc_multipleRegistro01TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spr_rep_cxc_multipleRegistro01BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // spr_rep_cxc_multipleRegistro01BindingSource
            // 
            this.spr_rep_cxc_multipleRegistro01BindingSource.DataMember = "spr_rep_cxc_multipleRegistro01";
            this.spr_rep_cxc_multipleRegistro01BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spr_rep_cxc_multipleRegistro01BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Duke4._newDesign.Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(425, 384);
            this.reportViewer1.TabIndex = 0;
            // 
            // spr_rep_cxc_multipleRegistro01TableAdapter
            // 
            this.spr_rep_cxc_multipleRegistro01TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 384);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spr_rep_cxc_multipleRegistro01BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource spr_rep_cxc_multipleRegistro01BindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.spr_rep_cxc_multipleRegistro01TableAdapter spr_rep_cxc_multipleRegistro01TableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}