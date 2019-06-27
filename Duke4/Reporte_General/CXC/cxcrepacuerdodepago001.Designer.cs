namespace Duke4.Reporte_General.CXC
{
    partial class cxcrepacuerdodepago001
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
            this.sprrepAcuerdoPago001BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spr_rep_Acuerdo_Pago001TableAdapter = new Duke4.DataSet_General.DSCXCTableAdapters.spr_rep_Acuerdo_Pago001TableAdapter();
            this.spr_rep_Acuerdo_Pago001BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dSCXC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprrepAcuerdoPago001BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_rep_Acuerdo_Pago001BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spr_rep_Acuerdo_Pago001BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Duke4.Reporte_General.CXC.cxcrepacuerdodepago001.rdlc";
            this.reportViewer1.Size = new System.Drawing.Size(337, 370);
            // 
            // dSCXC
            // 
            this.dSCXC.DataSetName = "DSCXC";
            this.dSCXC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sprrepAcuerdoPago001BindingSource
            // 
            this.sprrepAcuerdoPago001BindingSource.DataMember = "spr_rep_Acuerdo_Pago001";
            this.sprrepAcuerdoPago001BindingSource.DataSource = this.dSCXC;
            // 
            // spr_rep_Acuerdo_Pago001TableAdapter
            // 
            this.spr_rep_Acuerdo_Pago001TableAdapter.ClearBeforeFill = true;
            // 
            // spr_rep_Acuerdo_Pago001BindingSource
            // 
            this.spr_rep_Acuerdo_Pago001BindingSource.DataMember = "spr_rep_Acuerdo_Pago001";
            this.spr_rep_Acuerdo_Pago001BindingSource.DataSource = this.dSCXC;
            // 
            // cxcrepacuerdodepago001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(337, 370);
            this.Name = "cxcrepacuerdodepago001";
            this.Text = "MainReporte";
            this.Load += new System.EventHandler(this.cxcrepacuerdodepago001_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSCXC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprrepAcuerdoPago001BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_rep_Acuerdo_Pago001BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource spr_rep_Acuerdo_Pago001BindingSource;
        private DataSet_General.DSCXC dSCXC;
        private System.Windows.Forms.BindingSource sprrepAcuerdoPago001BindingSource;
        private DataSet_General.DSCXCTableAdapters.spr_rep_Acuerdo_Pago001TableAdapter spr_rep_Acuerdo_Pago001TableAdapter;
    }
}
