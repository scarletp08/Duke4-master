﻿namespace Duke4.Reporte_General.CXC
{
    partial class cxcrepcobroadelantadodetalle01
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
            this.sprrepcxccobroadelantadodetalle01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spr_rep_cxc_cobroadelantadodetalle01TableAdapter = new Duke4.DataSet_General.DSCXCTableAdapters.Spr_rep_cxc_cobroadelantadodetalle01TableAdapter();
            this.Spr_rep_cxc_cobroadelantadodetalle01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dSCXC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprrepcxccobroadelantadodetalle01BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spr_rep_cxc_cobroadelantadodetalle01BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Spr_rep_cxc_cobroadelantadodetalle01BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Duke4.Reporte_General.CXC.cxcrepcobroadelantadodetalle01.rdlc";
            // 
            // dSCXC
            // 
            this.dSCXC.DataSetName = "DSCXC";
            this.dSCXC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sprrepcxccobroadelantadodetalle01BindingSource
            // 
            this.sprrepcxccobroadelantadodetalle01BindingSource.DataMember = "Spr_rep_cxc_cobroadelantadodetalle01";
            this.sprrepcxccobroadelantadodetalle01BindingSource.DataSource = this.dSCXC;
            // 
            // spr_rep_cxc_cobroadelantadodetalle01TableAdapter
            // 
            this.spr_rep_cxc_cobroadelantadodetalle01TableAdapter.ClearBeforeFill = true;
            // 
            // Spr_rep_cxc_cobroadelantadodetalle01BindingSource
            // 
            this.Spr_rep_cxc_cobroadelantadodetalle01BindingSource.DataMember = "Spr_rep_cxc_cobroadelantadodetalle01";
            this.Spr_rep_cxc_cobroadelantadodetalle01BindingSource.DataSource = this.dSCXC;
            // 
            // cxcrepcobroadelantadodetalle01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "cxcrepcobroadelantadodetalle01";
            this.Load += new System.EventHandler(this.cxcrepcobro01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSCXC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprrepcxccobroadelantadodetalle01BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spr_rep_cxc_cobroadelantadodetalle01BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource Spr_rep_cxc_cobroadelantadodetalle01BindingSource;
        private DataSet_General.DSCXC dSCXC;
        private System.Windows.Forms.BindingSource sprrepcxccobroadelantadodetalle01BindingSource;
        private DataSet_General.DSCXCTableAdapters.Spr_rep_cxc_cobroadelantadodetalle01TableAdapter spr_rep_cxc_cobroadelantadodetalle01TableAdapter;
    }
}
