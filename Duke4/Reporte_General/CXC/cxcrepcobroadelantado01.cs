using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4.Reporte_General.CXC
{
    public partial class cxcrepcobroadelantado01 : Duke4.MainReporte
    {
        public cxcrepcobroadelantado01()
        {
            InitializeComponent();
        }
        public string _id { get; set; }
        public string _montoescrito { get; set; }
        private void cxcrepcobroadelantado01_Load(object sender, EventArgs e)
        {
              Fun_Reporte();

        }
        public void Fun_Reporte()
        {
            ReportParameter[] v = new ReportParameter[2];
            v[0] = new ReportParameter("copia", _Letrero_Copia);
            v[1] = new ReportParameter("montoescrito", _montoescrito);
            // TODO: esta línea de código carga datos en la tabla 'dSCXC.Spr_rep_cxc_cobro01' Puede moverla o quitarla según sea necesario.
            this.spr_rep_cxc_cobroadelantado01TableAdapter.Fill(this.dSCXC.Spr_rep_cxc_cobroadelantado01,_id);
            this.reportViewer1.RefreshReport();
            parametros(v);
        }
    }
}
