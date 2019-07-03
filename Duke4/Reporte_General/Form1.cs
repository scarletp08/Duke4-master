using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4.Reporte_General
{
    public partial class Form1 : Duke4.MainReporte
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string s;

        public int idfactura
        {
            get ;
           

            set ;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
             Fun_Reporte();
        }

        public void Fun_Reporte()
        {
            

            ReportParameter[] v = new ReportParameter[1];
            v[0] = new ReportParameter("copia", _Letrero_Copia);
            // TODO: esta línea de código carga datos en la tabla 'dSCXC.Spr_rep_cxc_registro01' Puede moverla o quitarla según sea necesario.
            this.reportefacturaTableAdapter.Fill(this.dataSet1.reportefactura,idfactura);
            this.reportViewer1.RefreshReport();
            parametros(v);

        }
    }
}
